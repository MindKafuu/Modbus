using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ModbusIAI_Mind
{
    public partial class Starter : Form
    {
        public Starter()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void rtuButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            RTU rtu = new RTU();
            rtu.Show();
        }

        private void tcpButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            TCP tcp = new TCP();
            tcp.Show();
        }
    }
}
