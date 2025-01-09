using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Threading.Tasks;
using System.Windows.Forms;
using Guna.UI2.WinForms;

namespace RGB_Controller
{
    public partial class Main : Form
    {
        private Label lblRed1, lblGreen1, lblBlue1;
        private Label lblRed2, lblGreen2, lblBlue2;
        private Guna2TrackBar trackBarRed1, trackBarGreen1, trackBarBlue1;
        private Guna2TrackBar trackBarRed2, trackBarGreen2, trackBarBlue2;
        private Guna2Panel gradientDisplayPanel;
        private TextBox txtHex1, txtHex2;

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.lblRed1 = new System.Windows.Forms.Label();
            this.lblGreen1 = new System.Windows.Forms.Label();
            this.lblBlue1 = new System.Windows.Forms.Label();
            this.trackBarRed1 = new Guna.UI2.WinForms.Guna2TrackBar();
            this.trackBarGreen1 = new Guna.UI2.WinForms.Guna2TrackBar();
            this.trackBarBlue1 = new Guna.UI2.WinForms.Guna2TrackBar();
            this.lblRed2 = new System.Windows.Forms.Label();
            this.lblGreen2 = new System.Windows.Forms.Label();
            this.lblBlue2 = new System.Windows.Forms.Label();
            this.trackBarRed2 = new Guna.UI2.WinForms.Guna2TrackBar();
            this.trackBarGreen2 = new Guna.UI2.WinForms.Guna2TrackBar();
            this.trackBarBlue2 = new Guna.UI2.WinForms.Guna2TrackBar();
            this.gradientDisplayPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.txtHex1 = new System.Windows.Forms.TextBox();
            this.txtHex2 = new System.Windows.Forms.TextBox();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.guna2ComboBox1 = new Guna.UI2.WinForms.Guna2ComboBox();
            this.guna2ComboBox2 = new Guna.UI2.WinForms.Guna2ComboBox();
            this.Save = new Guna.UI2.WinForms.Guna2Button();
            this.Exit = new Guna.UI2.WinForms.Guna2Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.Connect = new Guna.UI2.WinForms.Guna2Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.Interval = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblRed1
            // 
            this.lblRed1.Font = new System.Drawing.Font("Nirmala UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRed1.Location = new System.Drawing.Point(12, 124);
            this.lblRed1.Name = "lblRed1";
            this.lblRed1.Size = new System.Drawing.Size(133, 33);
            this.lblRed1.TabIndex = 0;
            this.lblRed1.Text = "Red: 0";
            // 
            // lblGreen1
            // 
            this.lblGreen1.Font = new System.Drawing.Font("Nirmala UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGreen1.Location = new System.Drawing.Point(12, 174);
            this.lblGreen1.Name = "lblGreen1";
            this.lblGreen1.Size = new System.Drawing.Size(133, 33);
            this.lblGreen1.TabIndex = 2;
            this.lblGreen1.Text = "Green: 0";
            // 
            // lblBlue1
            // 
            this.lblBlue1.Font = new System.Drawing.Font("Nirmala UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBlue1.Location = new System.Drawing.Point(12, 224);
            this.lblBlue1.Name = "lblBlue1";
            this.lblBlue1.Size = new System.Drawing.Size(133, 33);
            this.lblBlue1.TabIndex = 4;
            this.lblBlue1.Text = "Blue: 0";
            // 
            // trackBarRed1
            // 
            this.trackBarRed1.Location = new System.Drawing.Point(151, 130);
            this.trackBarRed1.Maximum = 255;
            this.trackBarRed1.Name = "trackBarRed1";
            this.trackBarRed1.Size = new System.Drawing.Size(257, 23);
            this.trackBarRed1.TabIndex = 1;
            this.trackBarRed1.ThumbColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(113)))), ((int)(((byte)(255)))));
            this.trackBarRed1.Value = 0;
            this.trackBarRed1.ValueChanged += new System.EventHandler(this.TrackBar_Scroll);
            // 
            // trackBarGreen1
            // 
            this.trackBarGreen1.Location = new System.Drawing.Point(151, 180);
            this.trackBarGreen1.Maximum = 255;
            this.trackBarGreen1.Name = "trackBarGreen1";
            this.trackBarGreen1.Size = new System.Drawing.Size(257, 23);
            this.trackBarGreen1.TabIndex = 3;
            this.trackBarGreen1.ThumbColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(113)))), ((int)(((byte)(255)))));
            this.trackBarGreen1.Value = 0;
            this.trackBarGreen1.ValueChanged += new System.EventHandler(this.TrackBar_Scroll);
            // 
            // trackBarBlue1
            // 
            this.trackBarBlue1.Location = new System.Drawing.Point(151, 230);
            this.trackBarBlue1.Maximum = 255;
            this.trackBarBlue1.Name = "trackBarBlue1";
            this.trackBarBlue1.Size = new System.Drawing.Size(257, 23);
            this.trackBarBlue1.TabIndex = 5;
            this.trackBarBlue1.ThumbColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(113)))), ((int)(((byte)(255)))));
            this.trackBarBlue1.Value = 0;
            this.trackBarBlue1.ValueChanged += new System.EventHandler(this.TrackBar_Scroll);
            // 
            // lblRed2
            // 
            this.lblRed2.Font = new System.Drawing.Font("Nirmala UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRed2.Location = new System.Drawing.Point(12, 124);
            this.lblRed2.Name = "lblRed2";
            this.lblRed2.Size = new System.Drawing.Size(133, 33);
            this.lblRed2.TabIndex = 7;
            this.lblRed2.Text = "Red: 0";
            // 
            // lblGreen2
            // 
            this.lblGreen2.Font = new System.Drawing.Font("Nirmala UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGreen2.Location = new System.Drawing.Point(12, 174);
            this.lblGreen2.Name = "lblGreen2";
            this.lblGreen2.Size = new System.Drawing.Size(133, 33);
            this.lblGreen2.TabIndex = 9;
            this.lblGreen2.Text = "Green: 0";
            // 
            // lblBlue2
            // 
            this.lblBlue2.Font = new System.Drawing.Font("Nirmala UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBlue2.Location = new System.Drawing.Point(12, 224);
            this.lblBlue2.Name = "lblBlue2";
            this.lblBlue2.Size = new System.Drawing.Size(133, 33);
            this.lblBlue2.TabIndex = 11;
            this.lblBlue2.Text = "Blue: 0";
            // 
            // trackBarRed2
            // 
            this.trackBarRed2.Location = new System.Drawing.Point(159, 130);
            this.trackBarRed2.Maximum = 255;
            this.trackBarRed2.Name = "trackBarRed2";
            this.trackBarRed2.Size = new System.Drawing.Size(257, 23);
            this.trackBarRed2.TabIndex = 8;
            this.trackBarRed2.ThumbColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(113)))), ((int)(((byte)(255)))));
            this.trackBarRed2.Value = 0;
            this.trackBarRed2.ValueChanged += new System.EventHandler(this.TrackBar_Scroll);
            // 
            // trackBarGreen2
            // 
            this.trackBarGreen2.Location = new System.Drawing.Point(159, 180);
            this.trackBarGreen2.Maximum = 255;
            this.trackBarGreen2.Name = "trackBarGreen2";
            this.trackBarGreen2.Size = new System.Drawing.Size(257, 23);
            this.trackBarGreen2.TabIndex = 10;
            this.trackBarGreen2.ThumbColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(113)))), ((int)(((byte)(255)))));
            this.trackBarGreen2.Value = 0;
            this.trackBarGreen2.ValueChanged += new System.EventHandler(this.TrackBar_Scroll);
            // 
            // trackBarBlue2
            // 
            this.trackBarBlue2.Location = new System.Drawing.Point(159, 230);
            this.trackBarBlue2.Maximum = 255;
            this.trackBarBlue2.Name = "trackBarBlue2";
            this.trackBarBlue2.Size = new System.Drawing.Size(257, 23);
            this.trackBarBlue2.TabIndex = 12;
            this.trackBarBlue2.ThumbColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(113)))), ((int)(((byte)(255)))));
            this.trackBarBlue2.Value = 0;
            this.trackBarBlue2.ValueChanged += new System.EventHandler(this.TrackBar_Scroll);
            // 
            // gradientDisplayPanel
            // 
            this.gradientDisplayPanel.BackColor = System.Drawing.Color.Black;
            this.gradientDisplayPanel.BorderColor = System.Drawing.Color.Black;
            this.gradientDisplayPanel.BorderThickness = 1;
            this.gradientDisplayPanel.Location = new System.Drawing.Point(12, 288);
            this.gradientDisplayPanel.Name = "gradientDisplayPanel";
            this.gradientDisplayPanel.Size = new System.Drawing.Size(888, 223);
            this.gradientDisplayPanel.TabIndex = 14;
            this.gradientDisplayPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.gradientDisplayPanel_Paint);
            // 
            // txtHex1
            // 
            this.txtHex1.Font = new System.Drawing.Font("Nirmala UI Semilight", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHex1.Location = new System.Drawing.Point(151, 64);
            this.txtHex1.Name = "txtHex1";
            this.txtHex1.Size = new System.Drawing.Size(111, 38);
            this.txtHex1.TabIndex = 6;
            this.txtHex1.Text = "#000000";
            this.txtHex1.TextChanged += new System.EventHandler(this.TxtHex1_TextChanged);
            // 
            // txtHex2
            // 
            this.txtHex2.Font = new System.Drawing.Font("Nirmala UI Semilight", 13.8F);
            this.txtHex2.Location = new System.Drawing.Point(159, 64);
            this.txtHex2.Name = "txtHex2";
            this.txtHex2.Size = new System.Drawing.Size(111, 38);
            this.txtHex2.TabIndex = 13;
            this.txtHex2.Text = "#000000";
            this.txtHex2.TextChanged += new System.EventHandler(this.TxtHex2_TextChanged);
            // 
            // splitContainer2
            // 
            this.splitContainer2.Location = new System.Drawing.Point(12, 12);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.label3);
            this.splitContainer2.Panel1.Controls.Add(this.trackBarRed1);
            this.splitContainer2.Panel1.Controls.Add(this.label1);
            this.splitContainer2.Panel1.Controls.Add(this.trackBarGreen1);
            this.splitContainer2.Panel1.Controls.Add(this.trackBarBlue1);
            this.splitContainer2.Panel1.Controls.Add(this.lblRed1);
            this.splitContainer2.Panel1.Controls.Add(this.lblGreen1);
            this.splitContainer2.Panel1.Controls.Add(this.lblBlue1);
            this.splitContainer2.Panel1.Controls.Add(this.txtHex1);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.label4);
            this.splitContainer2.Panel2.Controls.Add(this.trackBarRed2);
            this.splitContainer2.Panel2.Controls.Add(this.trackBarGreen2);
            this.splitContainer2.Panel2.Controls.Add(this.label2);
            this.splitContainer2.Panel2.Controls.Add(this.trackBarBlue2);
            this.splitContainer2.Panel2.Controls.Add(this.lblRed2);
            this.splitContainer2.Panel2.Controls.Add(this.lblBlue2);
            this.splitContainer2.Panel2.Controls.Add(this.lblGreen2);
            this.splitContainer2.Panel2.Controls.Add(this.txtHex2);
            this.splitContainer2.Size = new System.Drawing.Size(888, 270);
            this.splitContainer2.SplitterDistance = 427;
            this.splitContainer2.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Nirmala UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 31);
            this.label3.TabIndex = 15;
            this.label3.Text = "HEX";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 38);
            this.label1.TabIndex = 14;
            this.label1.Text = "Top";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Nirmala UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 31);
            this.label4.TabIndex = 16;
            this.label4.Text = "HEX";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Nirmala UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 38);
            this.label2.TabIndex = 15;
            this.label2.Text = "Bottom";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Nirmala UI", 13.8F);
            this.label5.Location = new System.Drawing.Point(12, 537);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 31);
            this.label5.TabIndex = 16;
            this.label5.Text = "Port";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Nirmala UI", 13.8F);
            this.label6.Location = new System.Drawing.Point(12, 594);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 31);
            this.label6.TabIndex = 17;
            this.label6.Text = "Baud";
            // 
            // guna2ComboBox1
            // 
            this.guna2ComboBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2ComboBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.guna2ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.guna2ComboBox1.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2ComboBox1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2ComboBox1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.guna2ComboBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.guna2ComboBox1.ItemHeight = 30;
            this.guna2ComboBox1.Items.AddRange(new object[] {
            "300",
            "600",
            "1200",
            "2400",
            "4800",
            "9600",
            "14400",
            "19200",
            "38400",
            "57600",
            "115200",
            "128000",
            "256000",
            "500000",
            "1000000",
            "2000000",
            "4000000"});
            this.guna2ComboBox1.Location = new System.Drawing.Point(84, 589);
            this.guna2ComboBox1.Name = "guna2ComboBox1";
            this.guna2ComboBox1.Size = new System.Drawing.Size(149, 36);
            this.guna2ComboBox1.StartIndex = 5;
            this.guna2ComboBox1.TabIndex = 18;
            // 
            // guna2ComboBox2
            // 
            this.guna2ComboBox2.BackColor = System.Drawing.Color.Transparent;
            this.guna2ComboBox2.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.guna2ComboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.guna2ComboBox2.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2ComboBox2.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2ComboBox2.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.guna2ComboBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.guna2ComboBox2.ItemHeight = 30;
            this.guna2ComboBox2.Location = new System.Drawing.Point(84, 532);
            this.guna2ComboBox2.Name = "guna2ComboBox2";
            this.guna2ComboBox2.Size = new System.Drawing.Size(149, 36);
            this.guna2ComboBox2.TabIndex = 19;
            this.guna2ComboBox2.DropDown += new System.EventHandler(this.guna2ComboBox2_DropDown);
            // 
            // Save
            // 
            this.Save.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Save.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Save.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Save.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Save.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.Save.ForeColor = System.Drawing.Color.White;
            this.Save.Location = new System.Drawing.Point(460, 537);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(180, 45);
            this.Save.TabIndex = 20;
            this.Save.Text = "Save";
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // Exit
            // 
            this.Exit.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Exit.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Exit.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Exit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Exit.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exit.ForeColor = System.Drawing.Color.White;
            this.Exit.Location = new System.Drawing.Point(460, 599);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(180, 45);
            this.Exit.TabIndex = 21;
            this.Exit.Text = "Exit";
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1050;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Connect
            // 
            this.Connect.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Connect.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Connect.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Connect.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Connect.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.Connect.ForeColor = System.Drawing.Color.White;
            this.Connect.Location = new System.Drawing.Point(250, 599);
            this.Connect.Name = "Connect";
            this.Connect.Size = new System.Drawing.Size(180, 45);
            this.Connect.TabIndex = 22;
            this.Connect.Text = "Connect";
            this.Connect.Click += new System.EventHandler(this.Connect_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(250, 583);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(180, 10);
            this.progressBar1.TabIndex = 23;
            // 
            // Interval
            // 
            this.Interval.AutoSize = true;
            this.Interval.Font = new System.Drawing.Font("Nirmala UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Interval.Location = new System.Drawing.Point(248, 533);
            this.Interval.Name = "Interval";
            this.Interval.Size = new System.Drawing.Size(91, 31);
            this.Interval.TabIndex = 17;
            this.Interval.Text = "Interval";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Nirmala UI Semilight", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(345, 530);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(85, 38);
            this.textBox1.TabIndex = 16;
            this.textBox1.Text = "1050";
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(704, 517);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(143, 137);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 24;
            this.pictureBox1.TabStop = false;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(913, 656);
            this.ControlBox = false;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Interval);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Connect);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.guna2ComboBox2);
            this.Controls.Add(this.guna2ComboBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.splitContainer2);
            this.Controls.Add(this.gradientDisplayPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Main";
            this.Text = "RGB Gradient Selector";
            this.Load += new System.EventHandler(this.Main_Load);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            this.splitContainer2.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void TrackBar_Scroll(object sender, EventArgs e)
        {
            // Get values for Color 1
            int red1 = trackBarRed1.Value;
            int green1 = trackBarGreen1.Value;
            int blue1 = trackBarBlue1.Value;

            // Get values for Color 2
            int red2 = trackBarRed2.Value;
            int green2 = trackBarGreen2.Value;
            int blue2 = trackBarBlue2.Value;

            // Update the color labels and HEX values immediately
            lblRed1.Text = $"Red: {red1}";
            lblGreen1.Text = $"Green: {green1}";
            lblBlue1.Text = $"Blue: {blue1}";
            txtHex1.Text = $"#{red1:X2}{green1:X2}{blue1:X2}";

            lblRed2.Text = $"Red: {red2}";
            lblGreen2.Text = $"Green: {green2}";
            lblBlue2.Text = $"Blue: {blue2}";
            txtHex2.Text = $"#{red2:X2}{green2:X2}{blue2:X2}";

            // Call method to update the gradient preview
            UpdateGradient(red1, green1, blue1, red2, green2, blue2);
        }

        private void UpdateGradient(int red1, int green1, int blue1, int red2, int green2, int blue2)
        {
            // Directly update the gradient preview using double buffering for smooth rendering
            this.gradientDisplayPanel.Invalidate();  // Forces a redraw, calling the OnPaint method

            // Update the gradient rendering logic (we’ll use Paint event to do the rendering)
        }

        private void gradientDisplayPanel_Paint(object sender, PaintEventArgs e)
        {
            // Get the current colors from sliders
            int red1 = trackBarRed1.Value;
            int green1 = trackBarGreen1.Value;
            int blue1 = trackBarBlue1.Value;

            int red2 = trackBarRed2.Value;
            int green2 = trackBarGreen2.Value;
            int blue2 = trackBarBlue2.Value;

            // Create a gradient brush from Color 1 to Color 2
            using (LinearGradientBrush brush = new LinearGradientBrush(
                gradientDisplayPanel.ClientRectangle,
                Color.FromArgb(red1, green1, blue1),
                Color.FromArgb(red2, green2, blue2),
                0F))
            {
                e.Graphics.FillRectangle(brush, gradientDisplayPanel.ClientRectangle);
            }
        }

        private void TxtHex1_TextChanged(object sender, EventArgs e)
        {
            // If HEX value is entered for Color 1, update RGB sliders
            if (txtHex1.Text.StartsWith("#") && txtHex1.Text.Length == 7)
            {
                try
                {
                    int red1 = Convert.ToInt32(txtHex1.Text.Substring(1, 2), 16);
                    int green1 = Convert.ToInt32(txtHex1.Text.Substring(3, 2), 16);
                    int blue1 = Convert.ToInt32(txtHex1.Text.Substring(5, 2), 16);

                    trackBarRed1.Value = red1;
                    trackBarGreen1.Value = green1;
                    trackBarBlue1.Value = blue1;
                }
                catch
                {
                    // Invalid HEX input
                }
            }
        }

        private void TxtHex2_TextChanged(object sender, EventArgs e)
        {
            // If HEX value is entered for Color 2, update RGB sliders
            if (txtHex2.Text.StartsWith("#") && txtHex2.Text.Length == 7)
            {
                try
                {
                    int red2 = Convert.ToInt32(txtHex2.Text.Substring(1, 2), 16);
                    int green2 = Convert.ToInt32(txtHex2.Text.Substring(3, 2), 16);
                    int blue2 = Convert.ToInt32(txtHex2.Text.Substring(5, 2), 16);

                    trackBarRed2.Value = red2;
                    trackBarGreen2.Value = green2;
                    trackBarBlue2.Value = blue2;
                }
                catch
                {
                    // Invalid HEX input
                }
            }
        }

        private SplitContainer splitContainer2;
        private Label label3;
        private Label label1;
        private Label label2;
        private Label label4;
        private System.IO.Ports.SerialPort serialPort1;
        private System.ComponentModel.IContainer components;
        private Label label5;
        private Label label6;
        private Guna2ComboBox guna2ComboBox1;
        private Guna2ComboBox guna2ComboBox2;
        private Guna2Button Save;
        private Guna2Button Exit;
        private Timer timer1;
        private Guna2Button Connect;
        private ProgressBar progressBar1;
        private Label Interval;
        private TextBox textBox1;
        private PictureBox pictureBox1;
    }
}