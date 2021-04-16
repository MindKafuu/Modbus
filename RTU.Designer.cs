
namespace ModbusIAI_Mind
{
    partial class RTU
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RTU));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.topBar = new System.Windows.Forms.Panel();
            this.backButton = new System.Windows.Forms.PictureBox();
            this.exitButton = new System.Windows.Forms.PictureBox();
            this.topLabel = new System.Windows.Forms.Label();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.bunifuDragControl2 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.disconnectIAI = new Bunifu.Framework.UI.BunifuFlatButton();
            this.connectIAI = new Bunifu.Framework.UI.BunifuFlatButton();
            this.statusBar = new System.Windows.Forms.ProgressBar();
            this.label3 = new System.Windows.Forms.Label();
            this.baudrate = new System.Windows.Forms.ComboBox();
            this.port = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.alarm = new Bunifu.Framework.UI.BunifuFlatButton();
            this.homeButton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.label5 = new System.Windows.Forms.Label();
            this.servoMode = new Bunifu.Framework.UI.BunifuSwitch();
            this.label4 = new System.Windows.Forms.Label();
            this.teachMode = new Bunifu.Framework.UI.BunifuSwitch();
            this.panel3 = new System.Windows.Forms.Panel();
            this.alarmCode = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.position = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.move = new Bunifu.Framework.UI.BunifuFlatButton();
            this.acceleration = new System.Windows.Forms.TextBox();
            this.speed = new System.Windows.Forms.TextBox();
            this.target = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.jogPlus = new Bunifu.Framework.UI.BunifuFlatButton();
            this.jogMinus = new Bunifu.Framework.UI.BunifuFlatButton();
            this.listCommand = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel5 = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.absolute = new Bunifu.Framework.UI.BunifuCheckbox();
            this.relative = new Bunifu.Framework.UI.BunifuCheckbox();
            this.topBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.backButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.exitButton)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // topBar
            // 
            this.topBar.BackColor = System.Drawing.Color.Gray;
            this.topBar.Controls.Add(this.backButton);
            this.topBar.Controls.Add(this.exitButton);
            this.topBar.Controls.Add(this.topLabel);
            this.topBar.Location = new System.Drawing.Point(-3, 0);
            this.topBar.Name = "topBar";
            this.topBar.Size = new System.Drawing.Size(932, 100);
            this.topBar.TabIndex = 0;
            // 
            // backButton
            // 
            this.backButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("backButton.BackgroundImage")));
            this.backButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.backButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.backButton.Location = new System.Drawing.Point(11, 10);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(37, 33);
            this.backButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.backButton.TabIndex = 2;
            this.backButton.TabStop = false;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("exitButton.BackgroundImage")));
            this.exitButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.exitButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exitButton.Location = new System.Drawing.Point(883, 10);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(37, 33);
            this.exitButton.TabIndex = 1;
            this.exitButton.TabStop = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // topLabel
            // 
            this.topLabel.AutoSize = true;
            this.topLabel.Font = new System.Drawing.Font("Times New Roman", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.topLabel.ForeColor = System.Drawing.Color.White;
            this.topLabel.Location = new System.Drawing.Point(380, 22);
            this.topLabel.Name = "topLabel";
            this.topLabel.Size = new System.Drawing.Size(181, 55);
            this.topLabel.TabIndex = 0;
            this.topLabel.Text = "Modbus";
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.topBar;
            this.bunifuDragControl1.Vertical = true;
            // 
            // bunifuDragControl2
            // 
            this.bunifuDragControl2.Fixed = true;
            this.bunifuDragControl2.Horizontal = true;
            this.bunifuDragControl2.TargetControl = this.topLabel;
            this.bunifuDragControl2.Vertical = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.disconnectIAI);
            this.panel1.Controls.Add(this.connectIAI);
            this.panel1.Controls.Add(this.statusBar);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.baudrate);
            this.panel1.Controls.Add(this.port);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(30, 124);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(594, 136);
            this.panel1.TabIndex = 1;
            // 
            // disconnectIAI
            // 
            this.disconnectIAI.Activecolor = System.Drawing.Color.LightSeaGreen;
            this.disconnectIAI.BackColor = System.Drawing.Color.LightSeaGreen;
            this.disconnectIAI.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.disconnectIAI.BorderRadius = 0;
            this.disconnectIAI.ButtonText = "Disconnect";
            this.disconnectIAI.Cursor = System.Windows.Forms.Cursors.Hand;
            this.disconnectIAI.DisabledColor = System.Drawing.Color.Gray;
            this.disconnectIAI.Iconcolor = System.Drawing.Color.Transparent;
            this.disconnectIAI.Iconimage = null;
            this.disconnectIAI.Iconimage_right = null;
            this.disconnectIAI.Iconimage_right_Selected = null;
            this.disconnectIAI.Iconimage_Selected = null;
            this.disconnectIAI.IconMarginLeft = 0;
            this.disconnectIAI.IconMarginRight = 0;
            this.disconnectIAI.IconRightVisible = true;
            this.disconnectIAI.IconRightZoom = 0D;
            this.disconnectIAI.IconVisible = true;
            this.disconnectIAI.IconZoom = 90D;
            this.disconnectIAI.IsTab = false;
            this.disconnectIAI.Location = new System.Drawing.Point(476, 39);
            this.disconnectIAI.Name = "disconnectIAI";
            this.disconnectIAI.Normalcolor = System.Drawing.Color.LightSeaGreen;
            this.disconnectIAI.OnHovercolor = System.Drawing.Color.DarkCyan;
            this.disconnectIAI.OnHoverTextColor = System.Drawing.Color.White;
            this.disconnectIAI.selected = false;
            this.disconnectIAI.Size = new System.Drawing.Size(99, 37);
            this.disconnectIAI.TabIndex = 11;
            this.disconnectIAI.Text = "Disconnect";
            this.disconnectIAI.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.disconnectIAI.Textcolor = System.Drawing.Color.White;
            this.disconnectIAI.TextFont = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.disconnectIAI.Click += new System.EventHandler(this.disconnectIAI_Click);
            // 
            // connectIAI
            // 
            this.connectIAI.Activecolor = System.Drawing.Color.LightSeaGreen;
            this.connectIAI.BackColor = System.Drawing.Color.LightSeaGreen;
            this.connectIAI.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.connectIAI.BorderRadius = 0;
            this.connectIAI.ButtonText = "Connect";
            this.connectIAI.Cursor = System.Windows.Forms.Cursors.Hand;
            this.connectIAI.DisabledColor = System.Drawing.Color.Gray;
            this.connectIAI.Iconcolor = System.Drawing.Color.Transparent;
            this.connectIAI.Iconimage = null;
            this.connectIAI.Iconimage_right = null;
            this.connectIAI.Iconimage_right_Selected = null;
            this.connectIAI.Iconimage_Selected = null;
            this.connectIAI.IconMarginLeft = 0;
            this.connectIAI.IconMarginRight = 0;
            this.connectIAI.IconRightVisible = true;
            this.connectIAI.IconRightZoom = 0D;
            this.connectIAI.IconVisible = true;
            this.connectIAI.IconZoom = 90D;
            this.connectIAI.IsTab = false;
            this.connectIAI.Location = new System.Drawing.Point(378, 39);
            this.connectIAI.Name = "connectIAI";
            this.connectIAI.Normalcolor = System.Drawing.Color.LightSeaGreen;
            this.connectIAI.OnHovercolor = System.Drawing.Color.DarkCyan;
            this.connectIAI.OnHoverTextColor = System.Drawing.Color.White;
            this.connectIAI.selected = false;
            this.connectIAI.Size = new System.Drawing.Size(86, 37);
            this.connectIAI.TabIndex = 10;
            this.connectIAI.Text = "Connect";
            this.connectIAI.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.connectIAI.Textcolor = System.Drawing.Color.White;
            this.connectIAI.TextFont = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.connectIAI.Click += new System.EventHandler(this.connectIAI_Click);
            // 
            // statusBar
            // 
            this.statusBar.Location = new System.Drawing.Point(55, 90);
            this.statusBar.Name = "statusBar";
            this.statusBar.Size = new System.Drawing.Size(305, 29);
            this.statusBar.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(174, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 19);
            this.label3.TabIndex = 4;
            this.label3.Text = "BaudRate";
            // 
            // baudrate
            // 
            this.baudrate.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.baudrate.FormattingEnabled = true;
            this.baudrate.Items.AddRange(new object[] {
            "4800",
            "9600",
            "19200",
            "38400",
            "115200"});
            this.baudrate.Location = new System.Drawing.Point(255, 44);
            this.baudrate.Name = "baudrate";
            this.baudrate.Size = new System.Drawing.Size(105, 27);
            this.baudrate.TabIndex = 3;
            this.baudrate.Text = "115200";
            // 
            // port
            // 
            this.port.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.port.FormattingEnabled = true;
            this.port.Location = new System.Drawing.Point(55, 44);
            this.port.Name = "port";
            this.port.Size = new System.Drawing.Size(91, 27);
            this.port.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(7, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Port";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Connection";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.alarm);
            this.panel2.Controls.Add(this.homeButton);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.servoMode);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.teachMode);
            this.panel2.Location = new System.Drawing.Point(650, 124);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(243, 136);
            this.panel2.TabIndex = 2;
            // 
            // alarm
            // 
            this.alarm.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.alarm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.alarm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.alarm.BorderRadius = 0;
            this.alarm.ButtonText = "Alarm";
            this.alarm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.alarm.DisabledColor = System.Drawing.Color.Gray;
            this.alarm.Iconcolor = System.Drawing.Color.Transparent;
            this.alarm.Iconimage = null;
            this.alarm.Iconimage_right = null;
            this.alarm.Iconimage_right_Selected = null;
            this.alarm.Iconimage_Selected = null;
            this.alarm.IconMarginLeft = 0;
            this.alarm.IconMarginRight = 0;
            this.alarm.IconRightVisible = true;
            this.alarm.IconRightZoom = 0D;
            this.alarm.IconVisible = true;
            this.alarm.IconZoom = 90D;
            this.alarm.IsTab = false;
            this.alarm.Location = new System.Drawing.Point(133, 82);
            this.alarm.Name = "alarm";
            this.alarm.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.alarm.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.alarm.OnHoverTextColor = System.Drawing.Color.White;
            this.alarm.selected = false;
            this.alarm.Size = new System.Drawing.Size(80, 37);
            this.alarm.TabIndex = 18;
            this.alarm.Text = "Alarm";
            this.alarm.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.alarm.Textcolor = System.Drawing.Color.White;
            this.alarm.TextFont = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.alarm.Click += new System.EventHandler(this.alarm_Click);
            // 
            // homeButton
            // 
            this.homeButton.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.homeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.homeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.homeButton.BorderRadius = 0;
            this.homeButton.ButtonText = "Home";
            this.homeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.homeButton.DisabledColor = System.Drawing.Color.Gray;
            this.homeButton.Iconcolor = System.Drawing.Color.Transparent;
            this.homeButton.Iconimage = null;
            this.homeButton.Iconimage_right = null;
            this.homeButton.Iconimage_right_Selected = null;
            this.homeButton.Iconimage_Selected = null;
            this.homeButton.IconMarginLeft = 0;
            this.homeButton.IconMarginRight = 0;
            this.homeButton.IconRightVisible = true;
            this.homeButton.IconRightZoom = 0D;
            this.homeButton.IconVisible = true;
            this.homeButton.IconZoom = 90D;
            this.homeButton.IsTab = false;
            this.homeButton.Location = new System.Drawing.Point(31, 82);
            this.homeButton.Name = "homeButton";
            this.homeButton.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.homeButton.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.homeButton.OnHoverTextColor = System.Drawing.Color.White;
            this.homeButton.selected = false;
            this.homeButton.Size = new System.Drawing.Size(80, 37);
            this.homeButton.TabIndex = 17;
            this.homeButton.Text = "Home";
            this.homeButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.homeButton.Textcolor = System.Drawing.Color.White;
            this.homeButton.TextFont = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.homeButton.Click += new System.EventHandler(this.homeButton_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(95, 49);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 22);
            this.label5.TabIndex = 6;
            this.label5.Text = "Servo ";
            // 
            // servoMode
            // 
            this.servoMode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.servoMode.BorderRadius = 0;
            this.servoMode.Cursor = System.Windows.Forms.Cursors.Hand;
            this.servoMode.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.servoMode.Location = new System.Drawing.Point(22, 52);
            this.servoMode.Margin = new System.Windows.Forms.Padding(4);
            this.servoMode.Name = "servoMode";
            this.servoMode.Oncolor = System.Drawing.Color.SeaGreen;
            this.servoMode.Onoffcolor = System.Drawing.Color.DarkGray;
            this.servoMode.Size = new System.Drawing.Size(51, 19);
            this.servoMode.TabIndex = 5;
            this.servoMode.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.servoMode.Value = false;
            this.servoMode.Click += new System.EventHandler(this.servoMode_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(95, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(136, 22);
            this.label4.TabIndex = 4;
            this.label4.Text = "Teaching Mode";
            // 
            // teachMode
            // 
            this.teachMode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.teachMode.BorderRadius = 0;
            this.teachMode.Cursor = System.Windows.Forms.Cursors.Hand;
            this.teachMode.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.teachMode.Location = new System.Drawing.Point(22, 18);
            this.teachMode.Margin = new System.Windows.Forms.Padding(4);
            this.teachMode.Name = "teachMode";
            this.teachMode.Oncolor = System.Drawing.Color.SeaGreen;
            this.teachMode.Onoffcolor = System.Drawing.Color.DarkGray;
            this.teachMode.Size = new System.Drawing.Size(51, 19);
            this.teachMode.TabIndex = 3;
            this.teachMode.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.teachMode.Value = false;
            this.teachMode.Click += new System.EventHandler(this.teachMode_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.alarmCode);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.position);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Location = new System.Drawing.Point(30, 283);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(319, 106);
            this.panel3.TabIndex = 3;
            // 
            // alarmCode
            // 
            this.alarmCode.AutoSize = true;
            this.alarmCode.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.alarmCode.Location = new System.Drawing.Point(226, 66);
            this.alarmCode.Name = "alarmCode";
            this.alarmCode.Size = new System.Drawing.Size(19, 21);
            this.alarmCode.TabIndex = 11;
            this.alarmCode.Text = "0";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(7, 63);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(118, 24);
            this.label10.TabIndex = 10;
            this.label10.Text = "Alarm Code";
            // 
            // position
            // 
            this.position.AutoSize = true;
            this.position.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.position.Location = new System.Drawing.Point(226, 11);
            this.position.Name = "position";
            this.position.Size = new System.Drawing.Size(19, 21);
            this.position.TabIndex = 9;
            this.position.Text = "0";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(7, 11);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(82, 24);
            this.label9.TabIndex = 8;
            this.label9.Text = "Position";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.move);
            this.panel4.Controls.Add(this.acceleration);
            this.panel4.Controls.Add(this.speed);
            this.panel4.Controls.Add(this.target);
            this.panel4.Controls.Add(this.label8);
            this.panel4.Controls.Add(this.label7);
            this.panel4.Controls.Add(this.label6);
            this.panel4.Controls.Add(this.jogPlus);
            this.panel4.Controls.Add(this.jogMinus);
            this.panel4.Location = new System.Drawing.Point(650, 283);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(243, 256);
            this.panel4.TabIndex = 4;
            // 
            // move
            // 
            this.move.Activecolor = System.Drawing.Color.LightSeaGreen;
            this.move.BackColor = System.Drawing.Color.LightSeaGreen;
            this.move.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.move.BorderRadius = 0;
            this.move.ButtonText = "Move";
            this.move.Cursor = System.Windows.Forms.Cursors.Hand;
            this.move.DisabledColor = System.Drawing.Color.Gray;
            this.move.Iconcolor = System.Drawing.Color.Transparent;
            this.move.Iconimage = null;
            this.move.Iconimage_right = null;
            this.move.Iconimage_right_Selected = null;
            this.move.Iconimage_Selected = null;
            this.move.IconMarginLeft = 0;
            this.move.IconMarginRight = 0;
            this.move.IconRightVisible = true;
            this.move.IconRightZoom = 0D;
            this.move.IconVisible = true;
            this.move.IconZoom = 90D;
            this.move.IsTab = false;
            this.move.Location = new System.Drawing.Point(133, 136);
            this.move.Name = "move";
            this.move.Normalcolor = System.Drawing.Color.LightSeaGreen;
            this.move.OnHovercolor = System.Drawing.Color.DarkCyan;
            this.move.OnHoverTextColor = System.Drawing.Color.White;
            this.move.selected = false;
            this.move.Size = new System.Drawing.Size(93, 37);
            this.move.TabIndex = 16;
            this.move.Text = "Move";
            this.move.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.move.Textcolor = System.Drawing.Color.White;
            this.move.TextFont = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.move.Click += new System.EventHandler(this.move_Click);
            // 
            // acceleration
            // 
            this.acceleration.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.acceleration.Location = new System.Drawing.Point(126, 92);
            this.acceleration.Name = "acceleration";
            this.acceleration.Size = new System.Drawing.Size(100, 26);
            this.acceleration.TabIndex = 15;
            this.acceleration.Text = "0";
            this.acceleration.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // speed
            // 
            this.speed.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.speed.Location = new System.Drawing.Point(126, 50);
            this.speed.Name = "speed";
            this.speed.Size = new System.Drawing.Size(100, 26);
            this.speed.TabIndex = 14;
            this.speed.Text = "0";
            this.speed.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // target
            // 
            this.target.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.target.Location = new System.Drawing.Point(126, 9);
            this.target.Name = "target";
            this.target.Size = new System.Drawing.Size(100, 26);
            this.target.TabIndex = 13;
            this.target.Text = "0";
            this.target.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(5, 95);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(85, 19);
            this.label8.TabIndex = 12;
            this.label8.Text = "Acceleration";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(5, 52);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 19);
            this.label7.TabIndex = 11;
            this.label7.Text = "Speed";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(5, 10);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 19);
            this.label6.TabIndex = 8;
            this.label6.Text = "Target Position";
            // 
            // jogPlus
            // 
            this.jogPlus.Activecolor = System.Drawing.Color.LightSeaGreen;
            this.jogPlus.BackColor = System.Drawing.Color.LightSeaGreen;
            this.jogPlus.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.jogPlus.BorderRadius = 0;
            this.jogPlus.ButtonText = "JOG +";
            this.jogPlus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.jogPlus.DisabledColor = System.Drawing.Color.Gray;
            this.jogPlus.Iconcolor = System.Drawing.Color.Transparent;
            this.jogPlus.Iconimage = null;
            this.jogPlus.Iconimage_right = null;
            this.jogPlus.Iconimage_right_Selected = null;
            this.jogPlus.Iconimage_Selected = null;
            this.jogPlus.IconMarginLeft = 0;
            this.jogPlus.IconMarginRight = 0;
            this.jogPlus.IconRightVisible = true;
            this.jogPlus.IconRightZoom = 0D;
            this.jogPlus.IconVisible = true;
            this.jogPlus.IconZoom = 90D;
            this.jogPlus.IsTab = false;
            this.jogPlus.Location = new System.Drawing.Point(133, 201);
            this.jogPlus.Name = "jogPlus";
            this.jogPlus.Normalcolor = System.Drawing.Color.LightSeaGreen;
            this.jogPlus.OnHovercolor = System.Drawing.Color.DarkCyan;
            this.jogPlus.OnHoverTextColor = System.Drawing.Color.White;
            this.jogPlus.selected = false;
            this.jogPlus.Size = new System.Drawing.Size(93, 37);
            this.jogPlus.TabIndex = 10;
            this.jogPlus.Text = "JOG +";
            this.jogPlus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.jogPlus.Textcolor = System.Drawing.Color.White;
            this.jogPlus.TextFont = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.jogPlus.MouseDown += new System.EventHandler(this.jogPlus_MouseDown);
            this.jogPlus.MouseUp += new System.EventHandler(this.jogPlus_MouseUp);
            // 
            // jogMinus
            // 
            this.jogMinus.Activecolor = System.Drawing.Color.LightSeaGreen;
            this.jogMinus.BackColor = System.Drawing.Color.LightSeaGreen;
            this.jogMinus.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.jogMinus.BorderRadius = 0;
            this.jogMinus.ButtonText = "JOG -";
            this.jogMinus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.jogMinus.DisabledColor = System.Drawing.Color.Gray;
            this.jogMinus.Iconcolor = System.Drawing.Color.Transparent;
            this.jogMinus.Iconimage = null;
            this.jogMinus.Iconimage_right = null;
            this.jogMinus.Iconimage_right_Selected = null;
            this.jogMinus.Iconimage_Selected = null;
            this.jogMinus.IconMarginLeft = 0;
            this.jogMinus.IconMarginRight = 0;
            this.jogMinus.IconRightVisible = true;
            this.jogMinus.IconRightZoom = 0D;
            this.jogMinus.IconVisible = true;
            this.jogMinus.IconZoom = 90D;
            this.jogMinus.IsTab = false;
            this.jogMinus.Location = new System.Drawing.Point(18, 201);
            this.jogMinus.Name = "jogMinus";
            this.jogMinus.Normalcolor = System.Drawing.Color.LightSeaGreen;
            this.jogMinus.OnHovercolor = System.Drawing.Color.DarkCyan;
            this.jogMinus.OnHoverTextColor = System.Drawing.Color.White;
            this.jogMinus.selected = false;
            this.jogMinus.Size = new System.Drawing.Size(93, 37);
            this.jogMinus.TabIndex = 9;
            this.jogMinus.Text = "JOG -";
            this.jogMinus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.jogMinus.Textcolor = System.Drawing.Color.White;
            this.jogMinus.TextFont = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.jogMinus.MouseDown += new System.EventHandler(this.jogMinus_MouseDown);
            this.jogMinus.MouseUp += new System.EventHandler(this.jogMinus_MouseUp);
            // 
            // listCommand
            // 
            this.listCommand.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.listCommand.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listCommand.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.listCommand.HideSelection = false;
            this.listCommand.Location = new System.Drawing.Point(30, 410);
            this.listCommand.Name = "listCommand";
            this.listCommand.Size = new System.Drawing.Size(594, 129);
            this.listCommand.TabIndex = 5;
            this.listCommand.UseCompatibleStateImageBehavior = false;
            this.listCommand.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Command";
            this.columnHeader1.Width = 594;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.White;
            this.panel5.Controls.Add(this.label12);
            this.panel5.Controls.Add(this.label11);
            this.panel5.Controls.Add(this.absolute);
            this.panel5.Controls.Add(this.relative);
            this.panel5.Location = new System.Drawing.Point(374, 283);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(250, 106);
            this.panel5.TabIndex = 6;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(74, 69);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(63, 19);
            this.label12.TabIndex = 18;
            this.label12.Text = "Absolute";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(74, 17);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(57, 19);
            this.label11.TabIndex = 17;
            this.label11.Text = "Relative";
            // 
            // absolute
            // 
            this.absolute.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.absolute.ChechedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.absolute.Checked = false;
            this.absolute.CheckedOnColor = System.Drawing.Color.SeaGreen;
            this.absolute.Cursor = System.Windows.Forms.Cursors.Hand;
            this.absolute.ForeColor = System.Drawing.Color.White;
            this.absolute.Location = new System.Drawing.Point(28, 68);
            this.absolute.Name = "absolute";
            this.absolute.Size = new System.Drawing.Size(20, 20);
            this.absolute.TabIndex = 1;
            this.absolute.OnChange += new System.EventHandler(this.absolute_OnChange);
            // 
            // relative
            // 
            this.relative.BackColor = System.Drawing.Color.SeaGreen;
            this.relative.ChechedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.relative.Checked = true;
            this.relative.CheckedOnColor = System.Drawing.Color.SeaGreen;
            this.relative.Cursor = System.Windows.Forms.Cursors.Hand;
            this.relative.ForeColor = System.Drawing.Color.White;
            this.relative.Location = new System.Drawing.Point(28, 16);
            this.relative.Name = "relative";
            this.relative.Size = new System.Drawing.Size(20, 20);
            this.relative.TabIndex = 0;
            this.relative.OnChange += new System.EventHandler(this.relative_OnChange);
            // 
            // RTU
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(928, 569);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.listCommand);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.topBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RTU";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.RTU_Load);
            this.topBar.ResumeLayout(false);
            this.topBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.backButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.exitButton)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel topBar;
        private System.Windows.Forms.PictureBox exitButton;
        private System.Windows.Forms.Label topLabel;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ProgressBar statusBar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox baudrate;
        private System.Windows.Forms.ComboBox port;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private Bunifu.Framework.UI.BunifuSwitch teachMode;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private Bunifu.Framework.UI.BunifuSwitch servoMode;
        private System.Windows.Forms.Panel panel4;
        private Bunifu.Framework.UI.BunifuFlatButton jogPlus;
        private Bunifu.Framework.UI.BunifuFlatButton jogMinus;
        private System.Windows.Forms.Panel panel3;
        private Bunifu.Framework.UI.BunifuFlatButton move;
        private System.Windows.Forms.TextBox acceleration;
        private System.Windows.Forms.TextBox speed;
        private System.Windows.Forms.TextBox target;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private Bunifu.Framework.UI.BunifuFlatButton alarm;
        private Bunifu.Framework.UI.BunifuFlatButton homeButton;
        private System.Windows.Forms.Label position;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label alarmCode;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ListView listCommand;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private Bunifu.Framework.UI.BunifuFlatButton disconnectIAI;
        private Bunifu.Framework.UI.BunifuFlatButton connectIAI;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private Bunifu.Framework.UI.BunifuCheckbox absolute;
        private Bunifu.Framework.UI.BunifuCheckbox relative;
        private System.Windows.Forms.PictureBox backButton;
    }
}

