namespace READ_COMPORT
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cBoxDataBits = new System.Windows.Forms.ComboBox();
            this.cBoxStopBits = new System.Windows.Forms.ComboBox();
            this.cBoxParityBits = new System.Windows.Forms.ComboBox();
            this.cBOX_BAUDRATE = new System.Windows.Forms.ComboBox();
            this.cBOX_COMPORT = new System.Windows.Forms.ComboBox();
            this.c = new System.Windows.Forms.Label();
            this.z = new System.Windows.Forms.Label();
            this.a = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.lblStatusCOM = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.btnCLOSE = new System.Windows.Forms.Button();
            this.btnOPEN = new System.Windows.Forms.Button();
            this.btnSendData = new System.Windows.Forms.Button();
            this.tBoxDataOut = new System.Windows.Forms.TextBox();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.btnClearDataOUT = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cBoxMode = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.cBoxModeDC = new System.Windows.Forms.ComboBox();
            this.btnRESET = new System.Windows.Forms.Button();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblDataOUTlength = new System.Windows.Forms.Label();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txBoxData = new System.Windows.Forms.TextBox();
            this.z2 = new ZedGraph.ZedGraphControl();
            this.btnEXIT_CLICK = new System.Windows.Forms.GroupBox();
            this.btnClearDataIn = new System.Windows.Forms.Button();
            this.chBoxAddtoOldData = new System.Windows.Forms.CheckBox();
            this.chBoxAlwaysUpdate = new System.Windows.Forms.CheckBox();
            this.tBoxDataIN = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.btnDrawGraph = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.Control = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txBoxSpeed = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txBoxMode = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txBoxPulseIn = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.btnEXIT_CLICK.SuspendLayout();
            this.Control.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cBoxDataBits);
            this.groupBox1.Controls.Add(this.cBoxStopBits);
            this.groupBox1.Controls.Add(this.cBoxParityBits);
            this.groupBox1.Controls.Add(this.cBOX_BAUDRATE);
            this.groupBox1.Controls.Add(this.cBOX_COMPORT);
            this.groupBox1.Controls.Add(this.c);
            this.groupBox1.Controls.Add(this.z);
            this.groupBox1.Controls.Add(this.a);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(1119, 200);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(346, 311);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "COMPORT";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // cBoxDataBits
            // 
            this.cBoxDataBits.FormattingEnabled = true;
            this.cBoxDataBits.Items.AddRange(new object[] {
            "6",
            "7",
            "8"});
            this.cBoxDataBits.Location = new System.Drawing.Point(153, 155);
            this.cBoxDataBits.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cBoxDataBits.Name = "cBoxDataBits";
            this.cBoxDataBits.Size = new System.Drawing.Size(180, 28);
            this.cBoxDataBits.TabIndex = 10;
            this.cBoxDataBits.Text = "8";
            // 
            // cBoxStopBits
            // 
            this.cBoxStopBits.FormattingEnabled = true;
            this.cBoxStopBits.Items.AddRange(new object[] {
            "One ",
            "Two"});
            this.cBoxStopBits.Location = new System.Drawing.Point(153, 197);
            this.cBoxStopBits.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cBoxStopBits.Name = "cBoxStopBits";
            this.cBoxStopBits.Size = new System.Drawing.Size(180, 28);
            this.cBoxStopBits.TabIndex = 9;
            this.cBoxStopBits.Text = "One ";
            // 
            // cBoxParityBits
            // 
            this.cBoxParityBits.FormattingEnabled = true;
            this.cBoxParityBits.Items.AddRange(new object[] {
            "None",
            "Odd",
            "Even"});
            this.cBoxParityBits.Location = new System.Drawing.Point(153, 238);
            this.cBoxParityBits.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cBoxParityBits.Name = "cBoxParityBits";
            this.cBoxParityBits.Size = new System.Drawing.Size(180, 28);
            this.cBoxParityBits.TabIndex = 8;
            this.cBoxParityBits.Text = "None";
            // 
            // cBOX_BAUDRATE
            // 
            this.cBOX_BAUDRATE.FormattingEnabled = true;
            this.cBOX_BAUDRATE.Items.AddRange(new object[] {
            "2400",
            "4800",
            "9600",
            "115200"});
            this.cBOX_BAUDRATE.Location = new System.Drawing.Point(153, 115);
            this.cBOX_BAUDRATE.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cBOX_BAUDRATE.Name = "cBOX_BAUDRATE";
            this.cBOX_BAUDRATE.Size = new System.Drawing.Size(180, 28);
            this.cBOX_BAUDRATE.TabIndex = 7;
            this.cBOX_BAUDRATE.Text = "115200";
            // 
            // cBOX_COMPORT
            // 
            this.cBOX_COMPORT.FormattingEnabled = true;
            this.cBOX_COMPORT.Location = new System.Drawing.Point(153, 72);
            this.cBOX_COMPORT.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cBOX_COMPORT.Name = "cBOX_COMPORT";
            this.cBOX_COMPORT.Size = new System.Drawing.Size(180, 28);
            this.cBOX_COMPORT.TabIndex = 6;
            // 
            // c
            // 
            this.c.AutoSize = true;
            this.c.Location = new System.Drawing.Point(15, 245);
            this.c.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.c.Name = "c";
            this.c.Size = new System.Drawing.Size(107, 20);
            this.c.TabIndex = 5;
            this.c.Text = "PARITY BITS";
            // 
            // z
            // 
            this.z.AutoSize = true;
            this.z.Location = new System.Drawing.Point(15, 203);
            this.z.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.z.Name = "z";
            this.z.Size = new System.Drawing.Size(91, 20);
            this.z.TabIndex = 4;
            this.z.Text = "STOP BITS";
            // 
            // a
            // 
            this.a.AutoSize = true;
            this.a.Location = new System.Drawing.Point(15, 162);
            this.a.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.a.Name = "a";
            this.a.Size = new System.Drawing.Size(92, 20);
            this.a.TabIndex = 2;
            this.a.Text = "DATA BITS";
            this.a.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 122);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "BAUD RATE";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 77);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "COMPORT";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.groupBox7);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.progressBar1);
            this.groupBox2.Controls.Add(this.btnCLOSE);
            this.groupBox2.Controls.Add(this.btnOPEN);
            this.groupBox2.Location = new System.Drawing.Point(1114, 18);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Size = new System.Drawing.Size(351, 172);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.lblStatusCOM);
            this.groupBox7.Location = new System.Drawing.Point(177, 12);
            this.groupBox7.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox7.Size = new System.Drawing.Size(168, 102);
            this.groupBox7.TabIndex = 18;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "COM PORT STATUS";
            this.groupBox7.Enter += new System.EventHandler(this.groupBox7_Enter);
            // 
            // lblStatusCOM
            // 
            this.lblStatusCOM.AutoSize = true;
            this.lblStatusCOM.Font = new System.Drawing.Font("Goudy Stout", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatusCOM.Location = new System.Drawing.Point(34, 52);
            this.lblStatusCOM.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStatusCOM.Name = "lblStatusCOM";
            this.lblStatusCOM.Size = new System.Drawing.Size(103, 32);
            this.lblStatusCOM.TabIndex = 0;
            this.lblStatusCOM.Text = "OFF";
            this.lblStatusCOM.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(286, 94);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 20);
            this.label4.TabIndex = 17;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(20, 118);
            this.progressBar1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(267, 35);
            this.progressBar1.TabIndex = 15;
            // 
            // btnCLOSE
            // 
            this.btnCLOSE.Location = new System.Drawing.Point(20, 74);
            this.btnCLOSE.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCLOSE.Name = "btnCLOSE";
            this.btnCLOSE.Size = new System.Drawing.Size(156, 35);
            this.btnCLOSE.TabIndex = 14;
            this.btnCLOSE.Text = "DISCONNECT";
            this.btnCLOSE.UseVisualStyleBackColor = true;
            this.btnCLOSE.Click += new System.EventHandler(this.btnCLOSE_Click);
            // 
            // btnOPEN
            // 
            this.btnOPEN.Location = new System.Drawing.Point(20, 29);
            this.btnOPEN.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnOPEN.Name = "btnOPEN";
            this.btnOPEN.Size = new System.Drawing.Size(156, 35);
            this.btnOPEN.TabIndex = 13;
            this.btnOPEN.Text = "CONNECT";
            this.btnOPEN.UseVisualStyleBackColor = true;
            this.btnOPEN.Click += new System.EventHandler(this.btnOPEN_Click);
            // 
            // btnSendData
            // 
            this.btnSendData.Location = new System.Drawing.Point(357, 26);
            this.btnSendData.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSendData.Name = "btnSendData";
            this.btnSendData.Size = new System.Drawing.Size(135, 80);
            this.btnSendData.TabIndex = 16;
            this.btnSendData.Text = "SEND DATA";
            this.btnSendData.UseVisualStyleBackColor = true;
            this.btnSendData.Click += new System.EventHandler(this.btnSendData_Click);
            // 
            // tBoxDataOut
            // 
            this.tBoxDataOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBoxDataOut.Location = new System.Drawing.Point(15, 31);
            this.tBoxDataOut.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tBoxDataOut.Multiline = true;
            this.tBoxDataOut.Name = "tBoxDataOut";
            this.tBoxDataOut.Size = new System.Drawing.Size(122, 39);
            this.tBoxDataOut.TabIndex = 11;
            this.tBoxDataOut.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tBoxDataOut.TextChanged += new System.EventHandler(this.tBoxDataOut_TextChanged);
            // 
            // serialPort1
            // 
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // btnClearDataOUT
            // 
            this.btnClearDataOUT.Location = new System.Drawing.Point(15, 82);
            this.btnClearDataOUT.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnClearDataOUT.Name = "btnClearDataOUT";
            this.btnClearDataOUT.Size = new System.Drawing.Size(124, 54);
            this.btnClearDataOUT.TabIndex = 17;
            this.btnClearDataOUT.Text = "CLEAR DATAOUT";
            this.btnClearDataOUT.UseVisualStyleBackColor = true;
            this.btnClearDataOUT.Click += new System.EventHandler(this.btnClearDataOUT_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Controls.Add(this.cBoxMode);
            this.groupBox4.Controls.Add(this.button1);
            this.groupBox4.Controls.Add(this.cBoxModeDC);
            this.groupBox4.Controls.Add(this.tBoxDataOut);
            this.groupBox4.Controls.Add(this.btnClearDataOUT);
            this.groupBox4.Controls.Add(this.btnRESET);
            this.groupBox4.Location = new System.Drawing.Point(28, 112);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox4.Size = new System.Drawing.Size(627, 157);
            this.groupBox4.TabIndex = 21;
            this.groupBox4.TabStop = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(304, 32);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(121, 37);
            this.label10.TabIndex = 19;
            this.label10.Text = "MODE:";
            // 
            // cBoxMode
            // 
            this.cBoxMode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cBoxMode.FormattingEnabled = true;
            this.cBoxMode.Items.AddRange(new object[] {
            "x1",
            "x4"});
            this.cBoxMode.Location = new System.Drawing.Point(298, 86);
            this.cBoxMode.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cBoxMode.Name = "cBoxMode";
            this.cBoxMode.Size = new System.Drawing.Size(136, 37);
            this.cBoxMode.TabIndex = 18;
            this.cBoxMode.Text = "x1";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(465, 31);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(146, 105);
            this.button1.TabIndex = 4;
            this.button1.Text = "EXIT";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cBoxModeDC
            // 
            this.cBoxModeDC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cBoxModeDC.FormattingEnabled = true;
            this.cBoxModeDC.Items.AddRange(new object[] {
            "+",
            "-"});
            this.cBoxModeDC.Location = new System.Drawing.Point(168, 29);
            this.cBoxModeDC.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cBoxModeDC.Name = "cBoxModeDC";
            this.cBoxModeDC.Size = new System.Drawing.Size(109, 37);
            this.cBoxModeDC.TabIndex = 8;
            this.cBoxModeDC.Text = "+";
            // 
            // btnRESET
            // 
            this.btnRESET.Location = new System.Drawing.Point(168, 82);
            this.btnRESET.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnRESET.Name = "btnRESET";
            this.btnRESET.Size = new System.Drawing.Size(112, 54);
            this.btnRESET.TabIndex = 9;
            this.btnRESET.Text = "RESET";
            this.btnRESET.UseVisualStyleBackColor = true;
            this.btnRESET.Click += new System.EventHandler(this.btnRESET_Click);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.label3);
            this.groupBox6.Controls.Add(this.lblDataOUTlength);
            this.groupBox6.Location = new System.Drawing.Point(28, 31);
            this.groupBox6.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox6.Size = new System.Drawing.Size(306, 72);
            this.groupBox6.TabIndex = 24;
            this.groupBox6.TabStop = false;
            this.groupBox6.Enter += new System.EventHandler(this.groupBox6_Enter);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(16, 25);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(191, 29);
            this.label3.TabIndex = 22;
            this.label3.Text = "Data OutLength :";
            // 
            // lblDataOUTlength
            // 
            this.lblDataOUTlength.AutoSize = true;
            this.lblDataOUTlength.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataOUTlength.Location = new System.Drawing.Point(216, 25);
            this.lblDataOUTlength.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDataOUTlength.Name = "lblDataOUTlength";
            this.lblDataOUTlength.Size = new System.Drawing.Size(39, 29);
            this.lblDataOUTlength.TabIndex = 23;
            this.lblDataOUTlength.Text = "00";
            this.lblDataOUTlength.Click += new System.EventHandler(this.label5_Click);
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.groupBox6);
            this.groupBox8.Controls.Add(this.label13);
            this.groupBox8.Controls.Add(this.btnSendData);
            this.groupBox8.Controls.Add(this.groupBox4);
            this.groupBox8.Controls.Add(this.txBoxData);
            this.groupBox8.Location = new System.Drawing.Point(798, 520);
            this.groupBox8.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox8.Size = new System.Drawing.Size(668, 291);
            this.groupBox8.TabIndex = 22;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = " Transmitter Data";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(531, 25);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(93, 29);
            this.label13.TabIndex = 11;
            this.label13.Text = "Data In:";
            this.label13.Click += new System.EventHandler(this.label13_Click);
            // 
            // txBoxData
            // 
            this.txBoxData.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txBoxData.Location = new System.Drawing.Point(526, 65);
            this.txBoxData.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txBoxData.Name = "txBoxData";
            this.txBoxData.Size = new System.Drawing.Size(108, 35);
            this.txBoxData.TabIndex = 10;
            this.txBoxData.Text = "0";
            this.txBoxData.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txBoxData.TextChanged += new System.EventHandler(this.txBoxData_TextChanged);
            // 
            // z2
            // 
            this.z2.Location = new System.Drawing.Point(18, 20);
            this.z2.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.z2.Name = "z2";
            this.z2.ScrollGrace = 0D;
            this.z2.ScrollMaxX = 0D;
            this.z2.ScrollMaxY = 0D;
            this.z2.ScrollMaxY2 = 0D;
            this.z2.ScrollMinX = 0D;
            this.z2.ScrollMinY = 0D;
            this.z2.ScrollMinY2 = 0D;
            this.z2.Size = new System.Drawing.Size(758, 789);
            this.z2.TabIndex = 23;
            // 
            // btnEXIT_CLICK
            // 
            this.btnEXIT_CLICK.Controls.Add(this.btnClearDataIn);
            this.btnEXIT_CLICK.Controls.Add(this.chBoxAddtoOldData);
            this.btnEXIT_CLICK.Controls.Add(this.chBoxAlwaysUpdate);
            this.btnEXIT_CLICK.Controls.Add(this.tBoxDataIN);
            this.btnEXIT_CLICK.Location = new System.Drawing.Point(940, 18);
            this.btnEXIT_CLICK.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnEXIT_CLICK.Name = "btnEXIT_CLICK";
            this.btnEXIT_CLICK.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnEXIT_CLICK.Size = new System.Drawing.Size(180, 492);
            this.btnEXIT_CLICK.TabIndex = 24;
            this.btnEXIT_CLICK.TabStop = false;
            this.btnEXIT_CLICK.Text = "DataOut";
            this.btnEXIT_CLICK.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // btnClearDataIn
            // 
            this.btnClearDataIn.Location = new System.Drawing.Point(20, 378);
            this.btnClearDataIn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnClearDataIn.Name = "btnClearDataIn";
            this.btnClearDataIn.Size = new System.Drawing.Size(146, 88);
            this.btnClearDataIn.TabIndex = 3;
            this.btnClearDataIn.Text = "CLEAR POSITION";
            this.btnClearDataIn.UseVisualStyleBackColor = true;
            this.btnClearDataIn.Click += new System.EventHandler(this.btnClearDataIn_Click);
            // 
            // chBoxAddtoOldData
            // 
            this.chBoxAddtoOldData.AutoSize = true;
            this.chBoxAddtoOldData.Location = new System.Drawing.Point(20, 309);
            this.chBoxAddtoOldData.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chBoxAddtoOldData.Name = "chBoxAddtoOldData";
            this.chBoxAddtoOldData.Size = new System.Drawing.Size(146, 24);
            this.chBoxAddtoOldData.TabIndex = 2;
            this.chBoxAddtoOldData.Text = "Add to old Data";
            this.chBoxAddtoOldData.UseVisualStyleBackColor = true;
            this.chBoxAddtoOldData.CheckedChanged += new System.EventHandler(this.chBoxAddtoOldData_CheckedChanged);
            // 
            // chBoxAlwaysUpdate
            // 
            this.chBoxAlwaysUpdate.AutoSize = true;
            this.chBoxAlwaysUpdate.Location = new System.Drawing.Point(20, 272);
            this.chBoxAlwaysUpdate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chBoxAlwaysUpdate.Name = "chBoxAlwaysUpdate";
            this.chBoxAlwaysUpdate.Size = new System.Drawing.Size(141, 24);
            this.chBoxAlwaysUpdate.TabIndex = 1;
            this.chBoxAlwaysUpdate.Text = "Always Update";
            this.chBoxAlwaysUpdate.UseVisualStyleBackColor = true;
            this.chBoxAlwaysUpdate.CheckedChanged += new System.EventHandler(this.chBoxAlwaysUpdate_CheckedChanged);
            // 
            // tBoxDataIN
            // 
            this.tBoxDataIN.Location = new System.Drawing.Point(16, 25);
            this.tBoxDataIN.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tBoxDataIN.Multiline = true;
            this.tBoxDataIN.Name = "tBoxDataIN";
            this.tBoxDataIN.Size = new System.Drawing.Size(144, 221);
            this.tBoxDataIN.TabIndex = 0;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(9, 377);
            this.button3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(146, 85);
            this.button3.TabIndex = 6;
            this.button3.Text = "CLEAR GRAPH";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnDrawGraph
            // 
            this.btnDrawGraph.Location = new System.Drawing.Point(4, 271);
            this.btnDrawGraph.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDrawGraph.Name = "btnDrawGraph";
            this.btnDrawGraph.Size = new System.Drawing.Size(146, 91);
            this.btnDrawGraph.TabIndex = 5;
            this.btnDrawGraph.Text = "START";
            this.btnDrawGraph.UseVisualStyleBackColor = true;
            this.btnDrawGraph.Click += new System.EventHandler(this.btnDrawGraph_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Control
            // 
            this.Control.Controls.Add(this.button3);
            this.Control.Controls.Add(this.btnDrawGraph);
            this.Control.Controls.Add(this.label11);
            this.Control.Controls.Add(this.txBoxSpeed);
            this.Control.Controls.Add(this.label9);
            this.Control.Controls.Add(this.txBoxMode);
            this.Control.Controls.Add(this.label8);
            this.Control.Controls.Add(this.txBoxPulseIn);
            this.Control.Location = new System.Drawing.Point(798, 20);
            this.Control.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Control.Name = "Control";
            this.Control.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Control.Size = new System.Drawing.Size(153, 491);
            this.Control.TabIndex = 26;
            this.Control.TabStop = false;
            this.Control.Text = "Output Parameter";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(39, 191);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(72, 20);
            this.label11.TabIndex = 6;
            this.label11.Text = "ERROR:";
            // 
            // txBoxSpeed
            // 
            this.txBoxSpeed.Location = new System.Drawing.Point(18, 215);
            this.txBoxSpeed.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txBoxSpeed.Name = "txBoxSpeed";
            this.txBoxSpeed.Size = new System.Drawing.Size(114, 26);
            this.txBoxSpeed.TabIndex = 4;
            this.txBoxSpeed.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(18, 126);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(117, 20);
            this.label9.TabIndex = 3;
            this.label9.Text = "Encoder Mode:";
            // 
            // txBoxMode
            // 
            this.txBoxMode.Location = new System.Drawing.Point(18, 149);
            this.txBoxMode.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txBoxMode.Name = "txBoxMode";
            this.txBoxMode.Size = new System.Drawing.Size(112, 26);
            this.txBoxMode.TabIndex = 2;
            this.txBoxMode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(20, 63);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(112, 20);
            this.label8.TabIndex = 1;
            this.label8.Text = "Pulse Number:";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // txBoxPulseIn
            // 
            this.txBoxPulseIn.Location = new System.Drawing.Point(20, 88);
            this.txBoxPulseIn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txBoxPulseIn.Name = "txBoxPulseIn";
            this.txBoxPulseIn.Size = new System.Drawing.Size(112, 26);
            this.txBoxPulseIn.TabIndex = 0;
            this.txBoxPulseIn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txBoxPulseIn.TextChanged += new System.EventHandler(this.txBoxPulseIn_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1484, 829);
            this.Controls.Add(this.Control);
            this.Controls.Add(this.btnEXIT_CLICK);
            this.Controls.Add(this.z2);
            this.Controls.Add(this.groupBox8);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Position Control-Group 10";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            this.btnEXIT_CLICK.ResumeLayout(false);
            this.btnEXIT_CLICK.PerformLayout();
            this.Control.ResumeLayout(false);
            this.Control.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label c;
        private System.Windows.Forms.Label z;
        private System.Windows.Forms.Label a;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cBoxDataBits;
        private System.Windows.Forms.ComboBox cBoxStopBits;
        private System.Windows.Forms.ComboBox cBoxParityBits;
        private System.Windows.Forms.ComboBox cBOX_BAUDRATE;
        private System.Windows.Forms.ComboBox cBOX_COMPORT;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnSendData;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button btnCLOSE;
        private System.Windows.Forms.Button btnOPEN;
        private System.Windows.Forms.TextBox tBoxDataOut;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnClearDataOUT;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblDataOUTlength;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Label lblStatusCOM;
        private System.Windows.Forms.GroupBox groupBox8;
        private ZedGraph.ZedGraphControl z2;
        private System.Windows.Forms.GroupBox btnEXIT_CLICK;
        private System.Windows.Forms.TextBox tBoxDataIN;
        private System.Windows.Forms.CheckBox chBoxAddtoOldData;
        private System.Windows.Forms.CheckBox chBoxAlwaysUpdate;
        private System.Windows.Forms.Button btnClearDataIn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnDrawGraph;
        private System.Windows.Forms.ComboBox cBoxMode;
        private System.Windows.Forms.GroupBox Control;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txBoxMode;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txBoxPulseIn;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txBoxSpeed;
        private System.Windows.Forms.ComboBox cBoxModeDC;
        private System.Windows.Forms.Button btnRESET;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txBoxData;
    }
}

