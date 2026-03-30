using System.IO.Ports;
namespace DI1000_Example
{
    public partial class frmDi1000 : Form
    {
        private SerialPort? _thisPort = null;
        private bool _shouldStopReading = false;
        public frmDi1000()
        {
            InitializeComponent();
        }

        private void frmDi1000_Load(object sender, EventArgs e)
        {
            foreach (var portName in SerialPort.GetPortNames())
            {
                cmbPort.Items.Add(portName);
            }
            if (cmbPort.Items.Count > 0)
            {
                cmbPort.SelectedIndex = 0;
            }
            cmbBaud.Items.Add("9600");
            cmbBaud.Items.Add("230400");
            cmbBaud.SelectedIndex = 0;
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
            _thisPort = new SerialPort(cmbPort.Text, Convert.ToInt32(cmbBaud.Text), Parity.None, 8, StopBits.One);
            _thisPort.Handshake = Handshake.None;
            _thisPort.ReadBufferSize = 128000;
            _thisPort.ReadTimeout = 1000;
            _thisPort.WriteTimeout = 1000;
            _thisPort.DiscardNull = true;
            try
            {
                _thisPort.Open();
                lblMessage.Text = $"{cmbPort.Text} opened at {cmbBaud.Text} baud.";
                lblMessage.Visible = true;
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
        }

        private async void btnStart_Click(object sender, EventArgs e)
        {
            if (_thisPort is null) return;
            if (optSingle.Checked)
            {
                await ReadOneValueAtATime();
            }
            else if (optContinuous.Checked)
            {
                await ReadContinuosly();

            }
        }
        private void btnStop_Click(object sender, EventArgs e)
        {
            _shouldStopReading = true;
            btnStart.Enabled = true;
            btnStop.Enabled = false;
            _thisPort?.Write("A\r"); //stop streaming mode if in that mode
            _thisPort = null;
        }
        private async Task ReadOneValueAtATime()
        {
            btnStart.Enabled = false;
            _shouldStopReading = false;
            while (_shouldStopReading == false)
            {
                try
                {
                    _thisPort!.Write("W\r");
                    var buffer = _thisPort!.ReadTo("\n");
                    if (buffer.Length != 13) continue; //check for valid data
                    txtWeight.Text = buffer;//convert to double and process
                    await Task.Delay(1); //give GUI time to catch up
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error reading from port", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                }
            }
        }
        private async Task ReadContinuosly()
        {
            btnStart.Enabled = false;
            _shouldStopReading = false;
            _thisPort!.Write("WC\r"); //issue this command once
                                      //to streaming mode
                                      //to stop send 'A'
            while (_shouldStopReading == false)
            {
                try
                {
                    var buffer = _thisPort!.ReadTo("\n");
                    if (buffer.Length != 13) continue; //check for valid data
                    txtWeight.Text = buffer;//convert to double and process
                    await Task.Delay(1); //give GUI time to catch up
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error reading from port", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                }
            }
        }
    }
}
