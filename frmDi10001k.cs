using System.IO.Ports;

using Microsoft.VisualBasic;
namespace DI1000_Example
{
    public partial class frmDi10001k : Form
    {
        private SerialPort? _thisPort = null;
        private bool _shouldStopReading = false;
        private bool _isTaring = false;
        public frmDi10001k()
        {
            InitializeComponent();
        }

        private void frmDi10001k_Load(object sender, EventArgs e)
        {
            foreach (var portName in SerialPort.GetPortNames())
            {
                cmbPort.Items.Add(portName);
            }
            if (cmbPort.Items.Count > 0)
            {
                cmbPort.SelectedIndex = 0;
            }
        }

        private void btnOpenPort_Click(object sender, EventArgs e)
        {
            //
            //if port is alread open close it
            //
            _thisPort?.Close();
            //
            //set up port and open
            //
            _thisPort = new SerialPort(cmbPort.Text, 230400, Parity.None, 8, StopBits.One);
            _thisPort.Handshake = Handshake.None;
            _thisPort.ReadBufferSize = 128000;
            _thisPort.ReadTimeout = 1000;
            _thisPort.WriteTimeout = 1000;
            _thisPort.DiscardNull = true;
            try
            {
                _thisPort.Open();
                lblMessage.Text = $"{cmbPort.Text} opened at 230400 baud.";
                lblMessage.Visible = true;
                btnStart.Enabled = true;
                btnStop.Enabled = false;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Error opening port", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClosePort_Click(object sender, EventArgs e)
        {
            _thisPort?.Close();
            lblMessage.Text = $"{cmbPort.Text} closed.";
            lblMessage.Visible = true;
            btnStart.Enabled = false;
            btnStop.Enabled = false;
        }

        private async void btnStart_Click(object sender, EventArgs e)
        {
            if (_thisPort is null) return;
            btnStart.Enabled = false;
            btnStop.Enabled = true;
            await ReadContinuosly();
        }
        private void btnStop_Click(object sender, EventArgs e)
        {
            _shouldStopReading = true;
            _thisPort?.Write("A\r"); //stop streaming mode if in that mode
            btnStart.Enabled = true;
            btnStop.Enabled = false;
        }
        private async Task ReadContinuosly()
        {
            _shouldStopReading = false;
            _thisPort!.Write("A\rA\r"); //stop if already streaming
            await Task.Delay(250);
            _thisPort!.DiscardInBuffer();
            //
            //read weight per count
            //
            _thisPort.Write("SWC\r");
            await Task.Delay(100);
            var buffer = _thisPort.ReadLine().Trim();
            double weightPerCount = Convert.ToDouble(buffer);
            if (weightPerCount == 0)
            {
                //something is wrong
                MessageBox.Show("Weight per count is zero. Check device Calibration.", "Device Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            //
            //read previous tare counts
            //
            _thisPort.Write("ST0\r");
            await Task.Delay(100);
            buffer = _thisPort.ReadLine().Trim();
            int tareCounts = Convert.ToInt32(buffer);
            //
            //give command to output at high speed
            //
            _thisPort!.Write("H\r"); //issue this command once
                                     //to streaming mode
                                     //to stop send 'A'
            int rawCounts = 0;
            while (_shouldStopReading == false)
            {
                try
                {
                    buffer = _thisPort!.ReadTo("\r").Trim();
                    if (buffer[0] == '-')
                    {
                        rawCounts = -1 * Convert.ToInt32(buffer.Substring(1), 16);
                    }
                    else
                    {
                        rawCounts = Convert.ToInt32(buffer.Substring(1), 16);
                    }
                    if (rawCounts < 2) continue; //ignore small values that are likely glitches
                    //are we taring the sensor?
                    if (_isTaring)
                    {
                        tareCounts = rawCounts;
                        _isTaring = false;
                    }
                    int weightCounts = rawCounts - tareCounts;
                    double weight = weightCounts * weightPerCount;
                    txtWeight.Text = weight.ToString("F3");
                    await Task.Delay(1); //give GUI time to catch up
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error reading from port", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                }
            }
        }

        private void frmDi10001k_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void cmdTare_Click(object sender, EventArgs e)
        {
            _isTaring = true;
        }
    }
}
