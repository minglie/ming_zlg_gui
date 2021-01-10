namespace Ming_LCD
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
            this.tmSend = new System.Windows.Forms.Timer(this.components);
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tsSpNum = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsBaudRate = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsDataBits = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsStopBits = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsParity = new System.Windows.Forms.ToolStripStatusLabel();
            this.labelGetCount = new System.Windows.Forms.ToolStripStatusLabel();
            this.labelSendCount = new System.Windows.Forms.ToolStripStatusLabel();
            this.lbLcd_x = new System.Windows.Forms.ToolStripStatusLabel();
            this.lbLcd_y = new System.Windows.Forms.ToolStripStatusLabel();
            this.label10 = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.btnSend = new System.Windows.Forms.Button();
            this.txtSend = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tabPageUsartConfig = new System.Windows.Forms.TabPage();
            this.ckb_click_change_LCD = new System.Windows.Forms.CheckBox();
            this.checkBoxDisCMD = new System.Windows.Forms.CheckBox();
            this.checkMingLCD = new System.Windows.Forms.CheckBox();
            this.DisSendcheckBox = new System.Windows.Forms.CheckBox();
            this.DisTimeCheckBox1 = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cbParity = new System.Windows.Forms.ComboBox();
            this.cbStop = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cbDataBits = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cbBaudRate = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSecond = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbTimeSend = new System.Windows.Forms.CheckBox();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.rbRcvStr = new System.Windows.Forms.RadioButton();
            this.rbRcv16 = new System.Windows.Forms.RadioButton();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.radio1 = new System.Windows.Forms.RadioButton();
            this.rdSendStr = new System.Windows.Forms.RadioButton();
            this.btnSwitch = new System.Windows.Forms.Button();
            this.cbSerial = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageProgram = new System.Windows.Forms.TabPage();
            this.lb_LCD = new System.Windows.Forms.Label();
            this.txtReceive = new System.Windows.Forms.RichTextBox();
            this.textBoxErrCount = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button5 = new System.Windows.Forms.Button();
            this.statusStrip1.SuspendLayout();
            this.tabPageUsartConfig.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPageProgram.SuspendLayout();
            this.SuspendLayout();
            // 
            // tmSend
            // 
            this.tmSend.Tick += new System.EventHandler(this.tmSend_Tick);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsSpNum,
            this.tsBaudRate,
            this.tsDataBits,
            this.tsStopBits,
            this.tsParity,
            this.labelGetCount,
            this.labelSendCount,
            this.lbLcd_x,
            this.lbLcd_y});
            this.statusStrip1.Location = new System.Drawing.Point(0, 854);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1564, 22);
            this.statusStrip1.TabIndex = 12;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tsSpNum
            // 
            this.tsSpNum.Name = "tsSpNum";
            this.tsSpNum.Size = new System.Drawing.Size(95, 17);
            this.tsSpNum.Text = "串口号：未指定|";
            // 
            // tsBaudRate
            // 
            this.tsBaudRate.Name = "tsBaudRate";
            this.tsBaudRate.Size = new System.Drawing.Size(86, 17);
            this.tsBaudRate.Text = "波特率:未指定|";
            // 
            // tsDataBits
            // 
            this.tsDataBits.Name = "tsDataBits";
            this.tsDataBits.Size = new System.Drawing.Size(86, 17);
            this.tsDataBits.Text = "数据位:未指定|";
            // 
            // tsStopBits
            // 
            this.tsStopBits.Name = "tsStopBits";
            this.tsStopBits.Size = new System.Drawing.Size(86, 17);
            this.tsStopBits.Text = "停止位:未指定|";
            // 
            // tsParity
            // 
            this.tsParity.Name = "tsParity";
            this.tsParity.Size = new System.Drawing.Size(86, 17);
            this.tsParity.Text = "停止位:未指定|";
            // 
            // labelGetCount
            // 
            this.labelGetCount.Name = "labelGetCount";
            this.labelGetCount.Size = new System.Drawing.Size(41, 17);
            this.labelGetCount.Text = "Get:0|";
            // 
            // labelSendCount
            // 
            this.labelSendCount.Name = "labelSendCount";
            this.labelSendCount.Size = new System.Drawing.Size(50, 17);
            this.labelSendCount.Text = "Send:0|";
            // 
            // lbLcd_x
            // 
            this.lbLcd_x.Name = "lbLcd_x";
            this.lbLcd_x.Size = new System.Drawing.Size(58, 17);
            this.lbLcd_x.Text = "LCD_X: 0";
            // 
            // lbLcd_y
            // 
            this.lbLcd_y.Name = "lbLcd_y";
            this.lbLcd_y.Size = new System.Drawing.Size(57, 17);
            this.lbLcd_y.Text = "LCD_Y: 0";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(334, 12);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(41, 12);
            this.label10.TabIndex = 15;
            this.label10.Text = "收发区";
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(1249, 6);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(59, 23);
            this.btnClear.TabIndex = 10;
            this.btnClear.Text = "清空";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label9.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label9.Location = new System.Drawing.Point(935, 34);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(221, 12);
            this.label9.TabIndex = 31;
            this.label9.Text = "(16进制时，用空格或“，”将字节隔开)";
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(31, 401);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(60, 25);
            this.btnSend.TabIndex = 22;
            this.btnSend.Text = "发送";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // txtSend
            // 
            this.txtSend.Location = new System.Drawing.Point(31, 362);
            this.txtSend.Multiline = true;
            this.txtSend.Name = "txtSend";
            this.txtSend.Size = new System.Drawing.Size(304, 21);
            this.txtSend.TabIndex = 21;
            this.txtSend.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSend_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 335);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 12);
            this.label4.TabIndex = 20;
            this.label4.Text = "发送数据：";
            // 
            // tabPageUsartConfig
            // 
            this.tabPageUsartConfig.Controls.Add(this.ckb_click_change_LCD);
            this.tabPageUsartConfig.Controls.Add(this.checkBoxDisCMD);
            this.tabPageUsartConfig.Controls.Add(this.checkMingLCD);
            this.tabPageUsartConfig.Controls.Add(this.DisSendcheckBox);
            this.tabPageUsartConfig.Controls.Add(this.DisTimeCheckBox1);
            this.tabPageUsartConfig.Controls.Add(this.label10);
            this.tabPageUsartConfig.Controls.Add(this.groupBox1);
            this.tabPageUsartConfig.Controls.Add(this.txtSend);
            this.tabPageUsartConfig.Controls.Add(this.label4);
            this.tabPageUsartConfig.Controls.Add(this.btnSend);
            this.tabPageUsartConfig.Location = new System.Drawing.Point(4, 22);
            this.tabPageUsartConfig.Name = "tabPageUsartConfig";
            this.tabPageUsartConfig.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageUsartConfig.Size = new System.Drawing.Size(1222, 828);
            this.tabPageUsartConfig.TabIndex = 0;
            this.tabPageUsartConfig.Text = "配置面板";
            this.tabPageUsartConfig.UseVisualStyleBackColor = true;
            // 
            // ckb_click_change_LCD
            // 
            this.ckb_click_change_LCD.AutoSize = true;
            this.ckb_click_change_LCD.Location = new System.Drawing.Point(109, 550);
            this.ckb_click_change_LCD.Name = "ckb_click_change_LCD";
            this.ckb_click_change_LCD.Size = new System.Drawing.Size(120, 16);
            this.ckb_click_change_LCD.TabIndex = 42;
            this.ckb_click_change_LCD.Text = "单击液晶改变颜色";
            this.ckb_click_change_LCD.UseVisualStyleBackColor = true;
            // 
            // checkBoxDisCMD
            // 
            this.checkBoxDisCMD.AutoSize = true;
            this.checkBoxDisCMD.Checked = true;
            this.checkBoxDisCMD.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxDisCMD.Location = new System.Drawing.Point(109, 501);
            this.checkBoxDisCMD.Name = "checkBoxDisCMD";
            this.checkBoxDisCMD.Size = new System.Drawing.Size(72, 16);
            this.checkBoxDisCMD.TabIndex = 41;
            this.checkBoxDisCMD.Text = "显示命令";
            this.checkBoxDisCMD.UseVisualStyleBackColor = true;
            // 
            // checkMingLCD
            // 
            this.checkMingLCD.AutoSize = true;
            this.checkMingLCD.Checked = true;
            this.checkMingLCD.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkMingLCD.Location = new System.Drawing.Point(109, 460);
            this.checkMingLCD.Name = "checkMingLCD";
            this.checkMingLCD.Size = new System.Drawing.Size(72, 16);
            this.checkMingLCD.TabIndex = 40;
            this.checkMingLCD.Text = "Ming_LCD";
            this.checkMingLCD.UseVisualStyleBackColor = true;
            // 
            // DisSendcheckBox
            // 
            this.DisSendcheckBox.AutoSize = true;
            this.DisSendcheckBox.Checked = true;
            this.DisSendcheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.DisSendcheckBox.Location = new System.Drawing.Point(223, 406);
            this.DisSendcheckBox.Name = "DisSendcheckBox";
            this.DisSendcheckBox.Size = new System.Drawing.Size(96, 16);
            this.DisSendcheckBox.TabIndex = 38;
            this.DisSendcheckBox.Text = "显示发送内容";
            this.DisSendcheckBox.UseVisualStyleBackColor = true;
            // 
            // DisTimeCheckBox1
            // 
            this.DisTimeCheckBox1.AutoSize = true;
            this.DisTimeCheckBox1.Location = new System.Drawing.Point(110, 406);
            this.DisTimeCheckBox1.Name = "DisTimeCheckBox1";
            this.DisTimeCheckBox1.Size = new System.Drawing.Size(90, 16);
            this.DisTimeCheckBox1.TabIndex = 37;
            this.DisTimeCheckBox1.Text = " 显示时间戳";
            this.DisTimeCheckBox1.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnExit);
            this.groupBox1.Controls.Add(this.btnSave);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtSecond);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cbTimeSend);
            this.groupBox1.Controls.Add(this.groupBox8);
            this.groupBox1.Controls.Add(this.groupBox7);
            this.groupBox1.Controls.Add(this.btnSwitch);
            this.groupBox1.Controls.Add(this.cbSerial);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(31, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(297, 293);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "发送方";
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(10, 181);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(59, 23);
            this.btnExit.TabIndex = 10;
            this.btnExit.Text = "退出";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(207, 14);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 21);
            this.btnSave.TabIndex = 32;
            this.btnSave.Text = "保存设置";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cbParity);
            this.groupBox3.Controls.Add(this.cbStop);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.cbDataBits);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.cbBaudRate);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Location = new System.Drawing.Point(9, 39);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(278, 71);
            this.groupBox3.TabIndex = 30;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "串口设置";
            // 
            // cbParity
            // 
            this.cbParity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbParity.FormattingEnabled = true;
            this.cbParity.Items.AddRange(new object[] {
            "无",
            "奇校验",
            "偶校验"});
            this.cbParity.Location = new System.Drawing.Point(202, 44);
            this.cbParity.Name = "cbParity";
            this.cbParity.Size = new System.Drawing.Size(68, 20);
            this.cbParity.TabIndex = 29;
            // 
            // cbStop
            // 
            this.cbStop.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbStop.FormattingEnabled = true;
            this.cbStop.Items.AddRange(new object[] {
            "1",
            "1.5",
            "2"});
            this.cbStop.Location = new System.Drawing.Point(61, 44);
            this.cbStop.Name = "cbStop";
            this.cbStop.Size = new System.Drawing.Size(63, 20);
            this.cbStop.TabIndex = 28;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label8.Location = new System.Drawing.Point(138, 47);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 14);
            this.label8.TabIndex = 27;
            this.label8.Text = "校验位：";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.Location = new System.Drawing.Point(8, 47);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 14);
            this.label7.TabIndex = 27;
            this.label7.Text = "停止位：";
            // 
            // cbDataBits
            // 
            this.cbDataBits.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDataBits.FormattingEnabled = true;
            this.cbDataBits.Items.AddRange(new object[] {
            "5",
            "6",
            "7",
            "8"});
            this.cbDataBits.Location = new System.Drawing.Point(202, 18);
            this.cbDataBits.Name = "cbDataBits";
            this.cbDataBits.Size = new System.Drawing.Size(68, 20);
            this.cbDataBits.TabIndex = 26;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(139, 21);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 14);
            this.label6.TabIndex = 25;
            this.label6.Text = "数据位：";
            // 
            // cbBaudRate
            // 
            this.cbBaudRate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbBaudRate.FormattingEnabled = true;
            this.cbBaudRate.Items.AddRange(new object[] {
            "300",
            "600",
            "1200",
            "2400",
            "4800",
            "9600",
            "19200",
            "38400",
            "115200"});
            this.cbBaudRate.Location = new System.Drawing.Point(61, 18);
            this.cbBaudRate.Name = "cbBaudRate";
            this.cbBaudRate.Size = new System.Drawing.Size(63, 20);
            this.cbBaudRate.TabIndex = 24;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(8, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 14);
            this.label5.TabIndex = 23;
            this.label5.Text = "波特率:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(251, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 12);
            this.label3.TabIndex = 19;
            this.label3.Text = "秒";
            // 
            // txtSecond
            // 
            this.txtSecond.Location = new System.Drawing.Point(199, 154);
            this.txtSecond.Name = "txtSecond";
            this.txtSecond.Size = new System.Drawing.Size(44, 21);
            this.txtSecond.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(132, 159);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 17;
            this.label2.Text = "时间间隔：";
            // 
            // cbTimeSend
            // 
            this.cbTimeSend.AutoSize = true;
            this.cbTimeSend.Location = new System.Drawing.Point(10, 159);
            this.cbTimeSend.Name = "cbTimeSend";
            this.cbTimeSend.Size = new System.Drawing.Size(96, 16);
            this.cbTimeSend.TabIndex = 16;
            this.cbTimeSend.Text = "定时发送数据";
            this.cbTimeSend.UseVisualStyleBackColor = true;
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.rbRcvStr);
            this.groupBox8.Controls.Add(this.rbRcv16);
            this.groupBox8.Location = new System.Drawing.Point(146, 115);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(142, 36);
            this.groupBox8.TabIndex = 15;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "接收数据格式";
            // 
            // rbRcvStr
            // 
            this.rbRcvStr.AutoSize = true;
            this.rbRcvStr.Location = new System.Drawing.Point(72, 14);
            this.rbRcvStr.Name = "rbRcvStr";
            this.rbRcvStr.Size = new System.Drawing.Size(59, 16);
            this.rbRcvStr.TabIndex = 2;
            this.rbRcvStr.TabStop = true;
            this.rbRcvStr.Text = "字符串";
            this.rbRcvStr.UseVisualStyleBackColor = true;
            // 
            // rbRcv16
            // 
            this.rbRcv16.AutoSize = true;
            this.rbRcv16.Location = new System.Drawing.Point(9, 14);
            this.rbRcv16.Name = "rbRcv16";
            this.rbRcv16.Size = new System.Drawing.Size(59, 16);
            this.rbRcv16.TabIndex = 1;
            this.rbRcv16.TabStop = true;
            this.rbRcv16.Text = "16进制";
            this.rbRcv16.UseVisualStyleBackColor = true;
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.radio1);
            this.groupBox7.Controls.Add(this.rdSendStr);
            this.groupBox7.Location = new System.Drawing.Point(6, 115);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(134, 37);
            this.groupBox7.TabIndex = 14;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "发送数据格式";
            // 
            // radio1
            // 
            this.radio1.AutoSize = true;
            this.radio1.Location = new System.Drawing.Point(9, 15);
            this.radio1.Name = "radio1";
            this.radio1.Size = new System.Drawing.Size(59, 16);
            this.radio1.TabIndex = 7;
            this.radio1.TabStop = true;
            this.radio1.Text = "16进制";
            this.radio1.UseVisualStyleBackColor = true;
            // 
            // rdSendStr
            // 
            this.rdSendStr.AutoSize = true;
            this.rdSendStr.Location = new System.Drawing.Point(73, 15);
            this.rdSendStr.Name = "rdSendStr";
            this.rdSendStr.Size = new System.Drawing.Size(59, 16);
            this.rdSendStr.TabIndex = 6;
            this.rdSendStr.TabStop = true;
            this.rdSendStr.Text = "字符串";
            this.rdSendStr.UseVisualStyleBackColor = true;
            // 
            // btnSwitch
            // 
            this.btnSwitch.Location = new System.Drawing.Point(127, 14);
            this.btnSwitch.Name = "btnSwitch";
            this.btnSwitch.Size = new System.Drawing.Size(75, 21);
            this.btnSwitch.TabIndex = 9;
            this.btnSwitch.Text = "打开串口";
            this.btnSwitch.UseVisualStyleBackColor = true;
            this.btnSwitch.Click += new System.EventHandler(this.btnSwitch_Click);
            // 
            // cbSerial
            // 
            this.cbSerial.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSerial.FormattingEnabled = true;
            this.cbSerial.Location = new System.Drawing.Point(53, 14);
            this.cbSerial.Name = "cbSerial";
            this.cbSerial.Size = new System.Drawing.Size(62, 20);
            this.cbSerial.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(10, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 14);
            this.label1.TabIndex = 7;
            this.label1.Text = "串口：";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageUsartConfig);
            this.tabControl1.Controls.Add(this.tabPageProgram);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1230, 854);
            this.tabControl1.TabIndex = 13;
            // 
            // tabPageProgram
            // 
            this.tabPageProgram.Controls.Add(this.lb_LCD);
            this.tabPageProgram.Location = new System.Drawing.Point(4, 22);
            this.tabPageProgram.Name = "tabPageProgram";
            this.tabPageProgram.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageProgram.Size = new System.Drawing.Size(1222, 828);
            this.tabPageProgram.TabIndex = 1;
            this.tabPageProgram.Text = "LCD面板";
            this.tabPageProgram.UseVisualStyleBackColor = true;
            // 
            // lb_LCD
            // 
            this.lb_LCD.BackColor = System.Drawing.Color.Gainsboro;
            this.lb_LCD.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lb_LCD.Location = new System.Drawing.Point(11, 8);
            this.lb_LCD.Name = "lb_LCD";
            this.lb_LCD.Size = new System.Drawing.Size(1200, 800);
            this.lb_LCD.TabIndex = 0;
            this.lb_LCD.Text = "label11";
            this.lb_LCD.Click += new System.EventHandler(this.Lb_LCD_Click);
            this.lb_LCD.Paint += new System.Windows.Forms.PaintEventHandler(this.lb_LCD_Paint);
            this.lb_LCD.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lb_LCD_MouseClick);
            this.lb_LCD.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lb_LCD_MouseMove);
            // 
            // txtReceive
            // 
            this.txtReceive.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtReceive.Location = new System.Drawing.Point(1249, 226);
            this.txtReceive.Margin = new System.Windows.Forms.Padding(300);
            this.txtReceive.MaxLength = 10;
            this.txtReceive.Name = "txtReceive";
            this.txtReceive.ReadOnly = true;
            this.txtReceive.Size = new System.Drawing.Size(315, 624);
            this.txtReceive.TabIndex = 0;
            this.txtReceive.Text = "";
            // 
            // textBoxErrCount
            // 
            this.textBoxErrCount.Location = new System.Drawing.Point(1473, 22);
            this.textBoxErrCount.Name = "textBoxErrCount";
            this.textBoxErrCount.Size = new System.Drawing.Size(91, 21);
            this.textBoxErrCount.TabIndex = 32;
            this.textBoxErrCount.Text = "0";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(1471, 6);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(65, 12);
            this.label11.TabIndex = 33;
            this.label11.Text = "错误包计数";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1362, 6);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 34;
            this.button2.Text = "清屏";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1249, 44);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 35;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(1353, 44);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 36;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(1264, 138);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(186, 21);
            this.textBox1.TabIndex = 37;
            this.textBox1.Text = "http://localhost:8888/a.json";
            this.textBox1.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(1264, 165);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(114, 23);
            this.button4.TabIndex = 38;
            this.button4.Text = "显示远程地址图片";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.Button4_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(1456, 138);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(80, 21);
            this.textBox2.TabIndex = 39;
            this.textBox2.Text = "240,160";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(1249, 86);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 40;
            this.button5.Text = "广告字";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.Button5_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1564, 876);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.textBoxErrCount);
            this.Controls.Add(this.txtReceive);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.statusStrip1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ming_LCD模拟器  240*160";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.tabPageUsartConfig.ResumeLayout(false);
            this.tabPageUsartConfig.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPageProgram.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer tmSend;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel tsSpNum;
        private System.Windows.Forms.ToolStripStatusLabel tsBaudRate;
        private System.Windows.Forms.ToolStripStatusLabel tsDataBits;
        private System.Windows.Forms.ToolStripStatusLabel tsStopBits;
        private System.Windows.Forms.ToolStripStatusLabel tsParity;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.TextBox txtSend;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TabPage tabPageUsartConfig;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox cbParity;
        private System.Windows.Forms.ComboBox cbStop;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbDataBits;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbBaudRate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSecond;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox cbTimeSend;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.RadioButton rbRcvStr;
        private System.Windows.Forms.RadioButton rbRcv16;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.RadioButton radio1;
        private System.Windows.Forms.RadioButton rdSendStr;
        private System.Windows.Forms.Button btnSwitch;
        private System.Windows.Forms.ComboBox cbSerial;
        private System.Windows.Forms.Label label1;

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.CheckBox DisSendcheckBox;
        private System.Windows.Forms.CheckBox DisTimeCheckBox1;
        private System.Windows.Forms.TabPage tabPageProgram;
        private System.Windows.Forms.ToolStripStatusLabel labelGetCount;
        private System.Windows.Forms.ToolStripStatusLabel labelSendCount;
        private System.Windows.Forms.Label lb_LCD;
        private System.Windows.Forms.RichTextBox txtReceive;
        private System.Windows.Forms.CheckBox checkMingLCD;
        private System.Windows.Forms.TextBox textBoxErrCount;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.CheckBox checkBoxDisCMD;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolStripStatusLabel lbLcd_x;
        private System.Windows.Forms.ToolStripStatusLabel lbLcd_y;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.CheckBox ckb_click_change_LCD;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button5;
    }
}

