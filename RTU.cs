using DiawModbus;
using System;
using System.Drawing;
using System.IO.Ports;
using System.Threading;
using System.Windows.Forms;

namespace ModbusIAI_Mind
{
    public partial class RTU : Form
    {
        private ModbusClient modbus;
        private Thread currentPositionMonitor;
        private int controlFlag;
        private bool teachModeStatus, servoStatus, homeStatus, alarmStatus;
        private delegate void ThreadDisplay(int[] data);
        private delegate void ThreadSetStatus(bool[] status);

        public RTU()
        {
            InitializeComponent();
        }

        private void RTU_Load(object sender, EventArgs e)
        {
            SetupProgram();
            SetupThread();
        }

        private void SetupProgram()
        {
            statusBar.Value = 0;
            controlFlag = 8;

            teachModeStatus = false;
            servoStatus = false;
            homeStatus = false;
            alarmStatus = false;

            string[] ports = SerialPort.GetPortNames();
            port.Items.AddRange(ports);
        }

        private void SetupThread()
        {
            currentPositionMonitor = new Thread(new ThreadStart(GetCurrentPosition));
            currentPositionMonitor.IsBackground = true;
        }
        
        private void GetCurrentPosition()
        {
            ThreadDisplay display = new ThreadDisplay(DisplayPosition);
            ThreadSetStatus statusMode = new ThreadSetStatus(SetStatusMode);

            int[] data;
            bool[] status;
            string StartingAddress;
            int intStartingAddress;

            while (modbus.Connected)
            {
                try
                {
                    StartingAddress = "9000";
                    intStartingAddress = int.Parse(StartingAddress, System.Globalization.NumberStyles.HexNumber);
                    data = modbus.ReadHoldingRegisters(intStartingAddress, 15);
                    display.Invoke(data);

                    StartingAddress = "0407";
                    intStartingAddress = int.Parse(StartingAddress, System.Globalization.NumberStyles.HexNumber);
                    status = modbus.ReadCoils(intStartingAddress, 14);
                    statusMode.Invoke(status);
                }
                catch (TimeoutException ex) { Console.WriteLine(ex); }

                Thread.Sleep(1000);
            }
        }

        private void SetStatusMode(bool[] status)
        {
            teachModeStatus = status[13];

            if (panel1.InvokeRequired)
            {
                BeginInvoke(new Action(() =>
                {
                    if (relative.Checked)
                        controlFlag = 8;
                    else if (absolute.Checked)
                        controlFlag = 0;

                    Console.WriteLine(controlFlag);

                    teachMode.Value = teachModeStatus;
                    if (alarmStatus)
                    {
                        alarm.Normalcolor = Color.Red;
                        alarm.OnHovercolor = Color.DarkRed;
                        alarm.BackColor = Color.Red;
                    }
                    else
                        alarm.BackColor = Color.FromArgb(46, 139, 87); 
                }));
            }
        }

        private void DisplayPosition(int[] data)
        {
            if (data[2] > 0)
                alarmStatus = true;

            int register1 = data[5];
            string binaryOfRegister1 = Convert.ToString(register1, 2);
            char[] dss1 = binaryOfRegister1.ToCharArray();

            if (dss1.Length > 1)
            {
                if (dss1[2] == '1')
                    servoStatus = true;
                else if (dss1[2] == '0')
                    servoStatus = false;

                if (dss1[4] == '1' || dss1[5] == '1')
                    alarmStatus = true;
                else if (dss1[4] == '0' || dss1[5] == '0')
                    alarmStatus = false;

                if (dss1[10] == '1')
                    homeStatus = true;
                else if (dss1[10] == '0')
                    homeStatus = false;

                SetupRegisters(data);
            }
        }

        private void SetupRegisters(int[] data)
        {
            if (panel1.InvokeRequired)
            {
                BeginInvoke(new Action(() =>
                {
                    position.Text = data[1] * 0.01 + "";
                    alarmCode.Text = data[2].ToString("X");
                    servoMode.Value = servoStatus;
     
                    if (homeStatus)
                        homeButton.BackColor = Color.FromArgb(46, 139, 87);
                    else
                    {
                        homeButton.Normalcolor = Color.Gray;
                        homeButton.OnHovercolor = Color.DarkGray;
                        homeButton.BackColor = Color.Gray;
                    }
                }));
            } 
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void SetupConnection()
        {
            modbus = new ModbusClient(port.Text);

            int UnitIdentifier = 1;
            modbus.UnitIdentifier = Convert.ToByte(UnitIdentifier);
            modbus.Baudrate = Convert.ToInt32(baudrate.Text);
            modbus.DataBits = 8;

            modbus.StopBits = StopBits.One;

            modbus.ConnectionTimeout = 50;

            modbus.ModbusMode = 1;
            modbus.Parity = Parity.None;
            modbus.Connect(modbus.ModbusMode);

            modbus.receiveDataChanged += new ModbusClient.ReceiveDataChanged(UpdateReceivedData);
            modbus.sendDataChanged += new ModbusClient.SendDataChanged(UpdateSentData);
        }

        private void teachMode_Click(object sender, EventArgs e)
        {
            Console.WriteLine(teachMode.Value);
            if (teachMode.Value)
            {
                string StartingAddress = "0414";
                int intStartingAddress = int.Parse(StartingAddress, System.Globalization.NumberStyles.HexNumber);
                modbus.WriteSingleCoil(intStartingAddress, true);
            }
            else if (teachMode.Value == false)
            {
                string StartingAddress = "0414";
                int intStartingAddress = int.Parse(StartingAddress, System.Globalization.NumberStyles.HexNumber);
                modbus.WriteSingleCoil(intStartingAddress, false);
            }
        }

        private void UpdateReceivedData(object sender)
        {
            string recieveData = BitConverter.ToString(modbus.receiveData).Replace("-", " ");
            Console.WriteLine("rx: " + recieveData);
            ListViewItem rx = new ListViewItem("rx: " + recieveData);

            if (listCommand.InvokeRequired)
            {
                BeginInvoke(new Action(() => { listCommand.Items.Add(rx).EnsureVisible(); }));
            }
        }

        private void UpdateSentData(object sender)
        {
            string sendData = BitConverter.ToString(modbus.sendData).Replace("-", " ");
            Console.WriteLine("tx: " + sendData);
            ListViewItem tx = new ListViewItem("tx: " + sendData);
            if (listCommand.InvokeRequired)
            {
                BeginInvoke(new Action(() => { listCommand.Items.Add(tx).EnsureVisible(); }));
            }
        }

        private void jogMinus_MouseDown(object sender, EventArgs e)
        {
            jogMinus.BackColor = Color.Gray;

            string StartingAddress = "0417";
            int intStartingAddress = int.Parse(StartingAddress, System.Globalization.NumberStyles.HexNumber);
            try { modbus.WriteSingleCoil(intStartingAddress, true); } 
            catch (DiawModbus.Exceptions.CRCCheckFailedException ex) { Console.WriteLine(ex); }
        }

        private void jogMinus_MouseUp(object sender, EventArgs e)
        {
            jogMinus.BackColor = Color.LightSeaGreen;

            string StartingAddress = "0417";
            int intStartingAddress = int.Parse(StartingAddress, System.Globalization.NumberStyles.HexNumber);
            try { modbus.WriteSingleCoil(intStartingAddress, false); }
            catch (DiawModbus.Exceptions.CRCCheckFailedException ex) { Console.WriteLine(ex); }
        }

        private void jogPlus_MouseDown(object sender, EventArgs e)
        {
            jogPlus.BackColor = Color.Gray;

            string StartingAddress = "0416";
            int intStartingAddress = int.Parse(StartingAddress, System.Globalization.NumberStyles.HexNumber);
            try { modbus.WriteSingleCoil(intStartingAddress, true); }
            catch (DiawModbus.Exceptions.CRCCheckFailedException ex) { Console.WriteLine(ex); }
        }

        private void jogPlus_MouseUp(object sender, EventArgs e)
        {
            jogPlus.BackColor = Color.LightSeaGreen;

            string StartingAddress = "0416";
            int intStartingAddress = int.Parse(StartingAddress, System.Globalization.NumberStyles.HexNumber);
            try { modbus.WriteSingleCoil(intStartingAddress, false); }
            catch (DiawModbus.Exceptions.CRCCheckFailedException ex) { Console.WriteLine(ex); }
        }

        private void homeButton_Click(object sender, EventArgs e)
        {
            string StartingAddress = "040B";
            int intStartingAddress = int.Parse(StartingAddress, System.Globalization.NumberStyles.HexNumber);
            modbus.WriteSingleCoil(intStartingAddress, false);
            modbus.WriteSingleCoil(intStartingAddress, true);
        }

        private void connectIAI_Click(object sender, EventArgs e)
        {
            SetupConnection();

            if (modbus.Connected)
            {
                statusBar.Value = 100;
                servoMode.Value = false;
                teachMode.Value = false;
                connectIAI.Enabled = false;
                disconnectIAI.Enabled = true;
                currentPositionMonitor.Start();
            } else
            {
                MessageBox.Show("Communication port open error");
            }
        }

        private void disconnectIAI_Click(object sender, EventArgs e)
        {
            modbus.Disconnect();
            if (!modbus.Connected)
            {
                statusBar.Value = 0;
                listCommand.Clear();
                position.Text = "0";
                alarmCode.Text = "0";
                connectIAI.Enabled = true;
                disconnectIAI.Enabled = false;
            }

            RTU_Load(null, EventArgs.Empty);
        }

        private void absolute_OnChange(object sender, EventArgs e)
        {
            relative.Checked = false;
        }

        private void relative_OnChange(object sender, EventArgs e)
        {
            absolute.Checked = false;
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Close();
            Starter start = new Starter();
            start.Show();
        }

        private void alarm_Click(object sender, EventArgs e)
        {
            string StartingAddress = "0407";
            int intStartingAddress = int.Parse(StartingAddress, System.Globalization.NumberStyles.HexNumber);
            modbus.WriteSingleCoil(intStartingAddress, true);
            modbus.WriteSingleCoil(intStartingAddress, false);
        }

        private void move_Click(object sender, EventArgs e)
        {
            int data1 = 0;
            if (Convert.ToInt32(target.Text) < 0)
                data1 = 65535;

            string StartingAddress = "9900";
            int intStartingAddress = int.Parse(StartingAddress, System.Globalization.NumberStyles.HexNumber);
            int[] position = { data1, Convert.ToInt32(target.Text) * 100, 0, 10, 0, Convert.ToInt32(speed.Text) * 100, Convert.ToInt32(Convert.ToDouble(acceleration.Text) * 100), 0, controlFlag };
            modbus.WriteMultipleRegisters(intStartingAddress, position);
        }

        private void servoMode_Click(object sender, EventArgs e)
        {
            if (servoMode.Value)
            {
                string StartingAddress = "0403";
                int intStartingAddress = int.Parse(StartingAddress, System.Globalization.NumberStyles.HexNumber);
                modbus.WriteSingleCoil(intStartingAddress, true);
            }
            else if (servoMode.Value == false)
            {
                string StartingAddress = "0403";
                int intStartingAddress = int.Parse(StartingAddress, System.Globalization.NumberStyles.HexNumber);
                modbus.WriteSingleCoil(intStartingAddress, false);
            }
        }
    }
}
