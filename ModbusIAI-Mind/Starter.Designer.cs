
namespace ModbusIAI_Mind
{
    partial class Starter
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Starter));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.topBar = new System.Windows.Forms.Panel();
            this.topLabel = new System.Windows.Forms.Label();
            this.bunifuDragControl2 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tcpButton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.rtuButton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.topBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.topBar;
            this.bunifuDragControl1.Vertical = true;
            // 
            // topBar
            // 
            this.topBar.BackColor = System.Drawing.Color.Gray;
            this.topBar.Controls.Add(this.pictureBox1);
            this.topBar.Controls.Add(this.topLabel);
            this.topBar.Location = new System.Drawing.Point(-3, 0);
            this.topBar.Name = "topBar";
            this.topBar.Size = new System.Drawing.Size(801, 100);
            this.topBar.TabIndex = 0;
            // 
            // topLabel
            // 
            this.topLabel.AutoSize = true;
            this.topLabel.Font = new System.Drawing.Font("Times New Roman", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.topLabel.ForeColor = System.Drawing.Color.White;
            this.topLabel.Location = new System.Drawing.Point(327, 22);
            this.topLabel.Name = "topLabel";
            this.topLabel.Size = new System.Drawing.Size(181, 55);
            this.topLabel.TabIndex = 1;
            this.topLabel.Text = "Modbus";
            // 
            // bunifuDragControl2
            // 
            this.bunifuDragControl2.Fixed = true;
            this.bunifuDragControl2.Horizontal = true;
            this.bunifuDragControl2.TargetControl = this.topLabel;
            this.bunifuDragControl2.Vertical = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Location = new System.Drawing.Point(754, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(37, 33);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // tcpButton
            // 
            this.tcpButton.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.tcpButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.tcpButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tcpButton.BorderRadius = 0;
            this.tcpButton.ButtonText = "Modbus TCP (Ethernet)";
            this.tcpButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tcpButton.DisabledColor = System.Drawing.Color.Gray;
            this.tcpButton.Iconcolor = System.Drawing.Color.Transparent;
            this.tcpButton.Iconimage = null;
            this.tcpButton.Iconimage_right = null;
            this.tcpButton.Iconimage_right_Selected = null;
            this.tcpButton.Iconimage_Selected = null;
            this.tcpButton.IconMarginLeft = 0;
            this.tcpButton.IconMarginRight = 0;
            this.tcpButton.IconRightVisible = true;
            this.tcpButton.IconRightZoom = 0D;
            this.tcpButton.IconVisible = true;
            this.tcpButton.IconZoom = 90D;
            this.tcpButton.IsTab = false;
            this.tcpButton.Location = new System.Drawing.Point(53, 215);
            this.tcpButton.Name = "tcpButton";
            this.tcpButton.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.tcpButton.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.tcpButton.OnHoverTextColor = System.Drawing.Color.White;
            this.tcpButton.selected = false;
            this.tcpButton.Size = new System.Drawing.Size(303, 65);
            this.tcpButton.TabIndex = 1;
            this.tcpButton.Text = "Modbus TCP (Ethernet)";
            this.tcpButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tcpButton.Textcolor = System.Drawing.Color.White;
            this.tcpButton.TextFont = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tcpButton.Click += new System.EventHandler(this.tcpButton_Click);
            // 
            // rtuButton
            // 
            this.rtuButton.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.rtuButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.rtuButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.rtuButton.BorderRadius = 0;
            this.rtuButton.ButtonText = "Modbus RTU (Serial)";
            this.rtuButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rtuButton.DisabledColor = System.Drawing.Color.Gray;
            this.rtuButton.Iconcolor = System.Drawing.Color.Transparent;
            this.rtuButton.Iconimage = null;
            this.rtuButton.Iconimage_right = null;
            this.rtuButton.Iconimage_right_Selected = null;
            this.rtuButton.Iconimage_Selected = null;
            this.rtuButton.IconMarginLeft = 0;
            this.rtuButton.IconMarginRight = 0;
            this.rtuButton.IconRightVisible = true;
            this.rtuButton.IconRightZoom = 0D;
            this.rtuButton.IconVisible = true;
            this.rtuButton.IconZoom = 90D;
            this.rtuButton.IsTab = false;
            this.rtuButton.Location = new System.Drawing.Point(451, 215);
            this.rtuButton.Name = "rtuButton";
            this.rtuButton.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.rtuButton.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.rtuButton.OnHoverTextColor = System.Drawing.Color.White;
            this.rtuButton.selected = false;
            this.rtuButton.Size = new System.Drawing.Size(298, 65);
            this.rtuButton.TabIndex = 2;
            this.rtuButton.Text = "Modbus RTU (Serial)";
            this.rtuButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rtuButton.Textcolor = System.Drawing.Color.White;
            this.rtuButton.TextFont = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtuButton.Click += new System.EventHandler(this.rtuButton_Click);
            // 
            // Starter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rtuButton);
            this.Controls.Add(this.tcpButton);
            this.Controls.Add(this.topBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Starter";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Starter";
            this.topBar.ResumeLayout(false);
            this.topBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private System.Windows.Forms.Panel topBar;
        private System.Windows.Forms.Label topLabel;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.Framework.UI.BunifuFlatButton rtuButton;
        private Bunifu.Framework.UI.BunifuFlatButton tcpButton;
    }
}