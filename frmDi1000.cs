using System.IO.Ports;
namespace DI1000_Example
{
    public partial class frmDi1000 : Form
    {
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
        }
    }
}
