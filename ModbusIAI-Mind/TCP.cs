using EasyModbus;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace ModbusIAI_Mind
{
    public partial class TCP : Form
    {
        private ModbusClient modbusClient = new ModbusClient();
        private Thread doMonitor;
        List<Bunifu.Framework.UI.BunifuSwitch> switches = new List<Bunifu.Framework.UI.BunifuSwitch>();
        List<PictureBox> pictureBoxes = new List<PictureBox>();
        private delegate void ThreadSetStatus(bool[] status);

        public TCP()
        {
            InitializeComponent();
        }

        private void TCP_Load(object sender, EventArgs e)
        {
            SetupForm();
            SetupThread();
        }

        private void SetupForm()
        {
            connectStatus.Value = 0;
            //Add switch to list from 15 to 0
            foreach (Control c in this.Controls)
            {
                if (c is Bunifu.Framework.UI.BunifuSwitch b)
                   switches.Add(b);

                if (c is PictureBox p)
                    pictureBoxes.Add(p);
            }
        }

        private void SetupThread()
        {
            doMonitor = new Thread(new ThreadStart(GetDOStatus));
            doMonitor.IsBackground = true;
        }

        private void GetDOStatus()
        {
            ThreadSetStatus statusMode = new ThreadSetStatus(SetDOStatus);
            bool[] status;

            while (modbusClient.Connected)
            {
                status = modbusClient.ReadCoils(16, 16);
                statusMode.Invoke(status);

                Thread.Sleep(1000);
            }
        }

        private void SetDOStatus(bool[] status)
        {
            if (panel1.InvokeRequired)
            {
                BeginInvoke(new Action(() =>
                {
                    for (int index = 15; index >= 0; index--)
                    {
                        switches[index].Value = status[15 - index];

                        if (switches[index].Value)
                            pictureBoxes[index].Image = Properties.Resources.lightOn;
                        else
                            pictureBoxes[index].Image = Properties.Resources.lightOff;
                    }
                }));
            }
        }

        private void connectTCP_Click(object sender, EventArgs e)
        {
            SetupConnection();

            if (modbusClient.Connected)
            {
                connectStatus.Value = 100;
                connectTCP.Enabled = false;
                disconnectTCP.Enabled = true;

                doMonitor.Start();
            }
        }

        private void SetupConnection()
        {
            modbusClient.IPAddress = ipAddress.Text;
            modbusClient.Port = Convert.ToInt32(port.Text);
            modbusClient.Connect();

            modbusClient.ReceiveDataChanged += new ModbusClient.ReceiveDataChangedHandler(UpdateReceivedData);
            modbusClient.SendDataChanged += new ModbusClient.SendDataChangedHandler(UpdateSentData);
        }

        private void UpdateSentData(object sender)
        {
            string sendData = BitConverter.ToString(modbusClient.sendData).Replace("-", " ");
            Console.WriteLine("tx: " + sendData);
        }

        private void UpdateReceivedData(object sender)
        {
            string recieveData = BitConverter.ToString(modbusClient.receiveData).Replace("-", " ");
            Console.WriteLine("rx: " + recieveData);
        }

        private void disconnectTCP_Click(object sender, EventArgs e)
        {
            modbusClient.Disconnect();
            if (!modbusClient.Connected)
            {
                connectStatus.Value = 0;
                connectTCP.Enabled = true;
                disconnectTCP.Enabled = false;
                ClearAllSwitches();
            }

            TCP_Load(null, EventArgs.Empty);
        }

        private void ClearAllSwitches()
        {
            for (int index = 15; index >= 0; index--)
            {
                switches[index].Value = false;
                pictureBoxes[index].Image = Properties.Resources.lightOff;
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Close();
            Starter start = new Starter();
            start.Show();
        }

        private void d0_Click(object sender, EventArgs e)
        {
            if (d0.Value)
                modbusClient.WriteSingleCoil(16, true);
            else
                modbusClient.WriteSingleCoil(16, false);
        }

        private void d1_Click(object sender, EventArgs e)
        {
            if (d1.Value)
                modbusClient.WriteSingleCoil(17, true);
            else
                modbusClient.WriteSingleCoil(17, false);
        }

        private void d2_Click(object sender, EventArgs e)
        {
            if (d2.Value)
                modbusClient.WriteSingleCoil(18, true);
            else
                modbusClient.WriteSingleCoil(18, false);
        }

        private void d3_Click(object sender, EventArgs e)
        {
            if (d3.Value)
                modbusClient.WriteSingleCoil(19, true);
            else
                modbusClient.WriteSingleCoil(19, false);
        }

        private void d4_Click(object sender, EventArgs e)
        {
            if (d4.Value)
                modbusClient.WriteSingleCoil(20, true);
            else
                modbusClient.WriteSingleCoil(20, false);
        }

        private void d5_Click(object sender, EventArgs e)
        {
            if (d5.Value)
                modbusClient.WriteSingleCoil(21, true);
            else
                modbusClient.WriteSingleCoil(21, false);
        }

        private void d6_Click(object sender, EventArgs e)
        {
            if (d6.Value)
                modbusClient.WriteSingleCoil(22, true);
            else
                modbusClient.WriteSingleCoil(22, false);
        }

        private void d7_Click(object sender, EventArgs e)
        {
            if (d7.Value)
                modbusClient.WriteSingleCoil(23, true);
            else
                modbusClient.WriteSingleCoil(23, false);
        }

        private void d8_Click(object sender, EventArgs e)
        {
            if (d8.Value)
                modbusClient.WriteSingleCoil(24, true);
            else
                modbusClient.WriteSingleCoil(24, false);
        }

        private void d9_Click(object sender, EventArgs e)
        {
            if (d9.Value)
                modbusClient.WriteSingleCoil(25, true);
            else
                modbusClient.WriteSingleCoil(25, false);
        }

        private void d10_Click(object sender, EventArgs e)
        {
            if (d10.Value)
                modbusClient.WriteSingleCoil(26, true);
            else
                modbusClient.WriteSingleCoil(26, false);
        }

        private void d11_Click(object sender, EventArgs e)
        {
            if (d11.Value)
                modbusClient.WriteSingleCoil(27, true);
            else
                modbusClient.WriteSingleCoil(27, false);
        }

        private void d12_Click(object sender, EventArgs e)
        {
            if (d12.Value)
                modbusClient.WriteSingleCoil(28, true);
            else
                modbusClient.WriteSingleCoil(28, false);
        }

        private void d13_Click(object sender, EventArgs e)
        {
            if (d13.Value)
                modbusClient.WriteSingleCoil(29, true);
            else
                modbusClient.WriteSingleCoil(29, false);
        }

        private void d14_Click(object sender, EventArgs e)
        {
            if (d14.Value)
                modbusClient.WriteSingleCoil(30, true);
            else
                modbusClient.WriteSingleCoil(30, false);
        }

        private void d15_Click(object sender, EventArgs e)
        {
            if (d15.Value)
                modbusClient.WriteSingleCoil(31, true);
            else
                modbusClient.WriteSingleCoil(31, false);
        }
    }
}
