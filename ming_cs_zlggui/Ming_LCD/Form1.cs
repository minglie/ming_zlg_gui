using System;
using System.IO.Ports;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using INIFILE;
using System.Text.RegularExpressions;
using System.IO;
using System.Threading;
using System.Diagnostics;

namespace Ming_LCD
{
    public partial class Form1 : Form
    {
        private StringBuilder builder = new StringBuilder();//避免在事件处理方法中反复的创建，定义到外面。

        private ZLG_GUI_Arg fram1 = new ZLG_GUI_Arg();

        private StringBuilder fram_bulid = new StringBuilder();//避免在事件处理方法中反复的创建，定义到外面。

        private long received_count = 0;//接收计数
        private long send_count = 0;//发送计数      

        private long err_fram_count = 0;//错误包计数 



        SerialPort sp1 = new SerialPort();



        public static Graphics gpp;
           
        public Form1()
        {
            InitializeComponent();
            ZLG_GUI.lable = this.lb_LCD;
            gpp= this.lb_LCD.CreateGraphics();
            //    this.skinEngine1.SkinFile = "skin/Wave.SSK";// "DiamondGreen.ssk";
        }

        //加载
        private void Form1_Load(object sender, EventArgs e)
        {

            serialLoad();
         //   sp1.ReceivedBytesThreshold = 4;//只要有1个字符送达端口时便触发DataReceived事件 
        }


        //数据接收使用的代理
        private delegate void myDelegate(byte[] modbusReadBuffer);
        private void modbus_sp1_DataRec_handle(byte[] readBuffer)
        {
            fram_bulid.Clear();
            if (readBuffer != null)
            {
                if (readBuffer.Length>9)
                {
                    fram1.Command = readBuffer[0];
                    fram1.x0 = readBuffer[1];
                    fram1.y0 = readBuffer[2]; ;
                    fram1.x1 = readBuffer[3]; ;
                    fram1.y1 = readBuffer[4]; ;
                    fram1.r = readBuffer[5]; ;
                    fram1.color = readBuffer[6]; ;
                    fram1.with = readBuffer[7]; ;
                    fram1.picdat = readBuffer[8]; ;

                    if (fram1.check== readBuffer[9])
                    {
                        bool color=false;
                        if(fram1.color>0)
                        {
                            color = true;
                        }
                        else
                        {
                            color = false;
                        }

                        switch (fram1.Command)
                        {
                            case 1:
                            ZLG_GUI.GUI_Point(fram1.x0,fram1.y0, color);
                            if (checkBoxDisCMD.Checked)
                            {
                                fram_bulid.Append(String.Format("GUI_Point({0},{1},{2});", fram1.x0, fram1.y0, color) + "\r\n");
                            }
                            break;

                            case 2:
                            ZLG_GUI.GUI_HLine(fram1.x0, fram1.y0, fram1.x1, color);
                            if (checkBoxDisCMD.Checked)
                            {
                                fram_bulid.Append(String.Format("GUI_HLine({0},{1},{2},{3});", fram1.x0, fram1.y0, fram1.x1, color) + "\r\n");
                            }
                            break;

                            case 3:
                                ZLG_GUI.GUI_RLine(fram1.x0, fram1.y0, fram1.y1, color);
                                if (checkBoxDisCMD.Checked)
                                {
                                    fram_bulid.Append(String.Format("GUI_RLine({0},{1},{2},{3});", fram1.x0, fram1.y0, fram1.y1, color) + "\r\n");
                                }
                                break;


                            case 4:
                                ZLG_GUI.GUI_Rectangle(fram1.x0, fram1.y0, fram1.x1, fram1.y1, color);
                                if (checkBoxDisCMD.Checked)
                                {
                                    fram_bulid.Append(String.Format("GUI_Rectangle({0},{1},{2},{3},{4});", fram1.x0, fram1.y0, fram1.x1, fram1.y1, color) + "\r\n");
                                }
                                break;

                            case 5:
                                ZLG_GUI.GUI_RectangleFill(fram1.x0, fram1.y0, fram1.x1, fram1.y1, color);
                                if (checkBoxDisCMD.Checked)
                                {
                                    fram_bulid.Append(String.Format("GUI_RectangleFill({0},{1},{2},{3},{4});", fram1.x0, fram1.y0, fram1.x1, fram1.y1, color) + "\r\n");
                                }
                                break;
 
                           case 6:
                                ZLG_GUI.GUI_Square(fram1.x0, fram1.y0, fram1.with, color);
                                if (checkBoxDisCMD.Checked)
                                {
                                    fram_bulid.Append(String.Format("GUI_Square({0},{1},{2},{3});", fram1.x0, fram1.y0, fram1.with, color) + "\r\n");
                                }
                                break;

                            case 7:
                                ZLG_GUI.GUI_Line(fram1.x0, fram1.y0, fram1.x1, fram1.y1, color);
                                if (checkBoxDisCMD.Checked)
                                {
                                    fram_bulid.Append(String.Format("GUI_Line({0},{1},{2},{3},{4});", fram1.x0, fram1.y0, fram1.x1, fram1.y1, color) + "\r\n");
                                }
                                break;

                            case 8:
                                ZLG_GUI.GUI_LineWith(fram1.x0, fram1.y0, fram1.x1, fram1.y1, fram1.with, color);
                                if (checkBoxDisCMD.Checked)
                                {
                                    fram_bulid.Append(String.Format("GUI_LineWith({0},{1},{2},{3},{4},{5});", fram1.x0, fram1.y0, fram1.x1, fram1.y1, fram1.with, color) + "\r\n");
                                }
                                break;
                            case 9:
                                ZLG_GUI.GUI_Circle(fram1.x0, fram1.y0, fram1.r, color);
                                if (checkBoxDisCMD.Checked)
                                {
                                    fram_bulid.Append(String.Format("GUI_Circle({0},{1},{2},{3});", fram1.x0, fram1.y0, fram1.r, color) + "\r\n");
                                }
                                break;
                            case 10:
                                ZLG_GUI.GUI_CircleFill(fram1.x0, fram1.y0, fram1.r, color);
                                if (checkBoxDisCMD.Checked)
                                {
                                    fram_bulid.Append(String.Format("GUI_CircleFill({0},{1},{2},{3});", fram1.x0, fram1.y0, fram1.r, color) + "\r\n");
                                }
                                break;
                            case 11:
                                ZLG_GUI.GUI_Ellipse(fram1.x0, fram1.x1, fram1.y0, fram1.y1, color);
                                if (checkBoxDisCMD.Checked)
                                {
                                    fram_bulid.Append(String.Format("GUI_Ellipse({0},{1},{2},{3},{4});", fram1.x0, fram1.x1, fram1.y0, fram1.y1, color) + "\r\n");
                                }
                                break;

                            case 12:
                                ZLG_GUI.GUI_EllipseFill(fram1.x0, fram1.x1, fram1.y0, fram1.y1, color);
                                if (checkBoxDisCMD.Checked)
                                {
                                    fram_bulid.Append(String.Format("GUI_EllipseFill({0},{1},{2},{3},{4});", fram1.x0, fram1.x1, fram1.y0, fram1.y1, color) + "\r\n");
                                }
                                break;

                            case 13:
                                ZLG_GUI.GUI_FloodFill(fram1.x0, fram1.y0, color);
                                if (checkBoxDisCMD.Checked)
                                {
                                    fram_bulid.Append(String.Format("GUI_FloodFill({0},{1},{2});", fram1.x0, fram1.y0, color) + "\r\n");
                                }
                                break;
                            case 14:
                                ZLG_GUI.GUI_PutChar5_7(fram1.x0, fram1.y0, fram1.picdat);
                                if (checkBoxDisCMD.Checked)
                                {
                                    fram_bulid.Append(String.Format("GUI_PutChar5_7 ({0},{1},{2});", fram1.x0, fram1.y0, fram1.picdat) + "\r\n");
                                }
                                break;

                            case 15:
                                ZLG_GUI.GUI_PutChar8_8(fram1.x0, fram1.y0, fram1.picdat);
                                if (checkBoxDisCMD.Checked)
                                {
                                    fram_bulid.Append(String.Format("GUI_PutChar8_8 ({0},{1},{2});", fram1.x0, fram1.y0, fram1.picdat) + "\r\n");
                                }
                                break;

                            case 16:
                                ZLG_GUI.GUI_PutChar24_32(fram1.x0, fram1.y0, fram1.picdat);
                                if (checkBoxDisCMD.Checked)
                                {
                                    fram_bulid.Append(String.Format("GUI_PutChar24_32 ({0},{1},{2});", fram1.x0, fram1.y0, fram1.picdat) + "\r\n");
                                }
                                break;

                            case 17:
                                byte[] temp= {1};

                                ZLG_GUI.GUI_LoadPic(fram1.x0, fram1.y0, temp, fram1.x1, fram1.y1);
                                if (checkBoxDisCMD.Checked)
                                {
                                    fram_bulid.Append(String.Format("GUI_Point({0},{1},{2});", fram1.x0, fram1.y0, temp, fram1.x1, fram1.y1) + "\r\n");
                                }
                                break;

                            case 18:
                                ZLG_GUI.GUI_FillSCR(false);
                                if (checkBoxDisCMD.Checked)
                                {
                                    fram_bulid.Append("GUI_FillSCR(false);" + "\r\n");
                                }
                                break;                           
                        }

                        if (checkBoxDisCMD.Checked)
                        {                        
                            txtReceive.AppendText(fram_bulid.ToString());
                        }
                    }
                    else
                    {
                         err_fram_count++;
                        textBoxErrCount.Text = err_fram_count.ToString();
                    }
                }
            }
       }


      
        void sp1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            int n = 0;
           Thread.Sleep(8);//延时5ms   
            myDelegate md = new myDelegate(modbus_sp1_DataRec_handle);

            if (sp1.IsOpen)
            {
                n = sp1.BytesToRead;  //先记录下来，避免某种原因，人为的原因，操作几次之间时间长，缓存不一致
              //  n = 4;
            }
               
            else return;
            byte[] byteRead = new byte[n];
            sp1.Read(byteRead, 0, n);//读取缓冲数据
            received_count += n;//增加接收计数

            builder.Clear();//清除字符串构造器的内容
            if (sp1.IsOpen) //此处可能没有必要判断是否打开串口，但为了严谨性，我还是加上了
            {
                try
                { //依次的拼接出16进制字符串


                    foreach (byte b in byteRead)
                    {
                        builder.Append(b.ToString("X2") + " ");
                    }
                    if (checkMingLCD.Checked)
                    {
                        this.Invoke(md, byteRead);
                    }

                    else
                    {

                            this.Invoke((EventHandler)(delegate
                            {
                                txtReceive.AppendText("R:" + builder.ToString() + "\r\n");
                                txtReceive.SelectionStart = txtReceive.Text.Length;//选定文本的起点是文本框结尾
                                txtReceive.ScrollToCaret();//将滚动条滚到文本框结尾
                            }));
                    }
                        this.Invoke((EventHandler)(delegate { labelGetCount.Text = "Get:" + received_count.ToString() + "|"; }));
                        //    labelGetCount.Text = "Get:" + received_count.ToString() + "|";
                    }
                catch (System.Exception ex)
                {
                    MessageBox.Show(ex.Message, "出错提示");
                    txtSend.Text = "";
                }
                     
                 
            }
            else
            {
                MessageBox.Show("请打开某个串口", "错误提示");
            }
        }

        //发送按钮
        private void btnSend_Click(object sender, EventArgs e)
        {
            //定义一个变量，记录发送了几个字节
            int n = 0;
            if (cbTimeSend.Checked)
            {
                tmSend.Enabled = true;
            }
            else
            {
                tmSend.Enabled = false;
            }

            if (!sp1.IsOpen) //如果没打开
            {
                MessageBox.Show("请先打开串口！", "Error");
                return;
            }

            String strSend = txtSend.Text;
            if (radio1.Checked == true)	//“HEX发送” 按钮 
            {
                //处理数字转换
                string sendBuf = strSend;
                string sendnoNull = sendBuf.Trim();
                string sendNOComma = sendnoNull.Replace(',', ' ');    //去掉英文逗号
                string sendNOComma1 = sendNOComma.Replace('，', ' '); //去掉中文逗号
                string strSendNoComma2 = sendNOComma1.Replace("0x", "");   //去掉0x
                strSendNoComma2.Replace("0X", "");   //去掉0X
                string[] strArray = strSendNoComma2.Split(' ');

                int byteBufferLength = strArray.Length;
                for (int i = 0; i < strArray.Length; i++)
                {
                    if (strArray[i] == "")
                    {
                        byteBufferLength--;
                    }
                }
                // int temp = 0;
                byte[] byteBuffer = new byte[byteBufferLength];
                int ii = 0;
                for (int i = 0; i < strArray.Length; i++)        //对获取的字符做相加运算
                {

                    Byte[] bytesOfStr = Encoding.Default.GetBytes(strArray[i]);

                    int decNum = 0;
                    if (strArray[i] == "")
                    {
                        //ii--;     //加上此句是错误的，下面的continue以延缓了一个ii，不与i同步
                        continue;
                    }
                    else
                    {
                        decNum = Convert.ToInt32(strArray[i], 16); //atrArray[i] == 12时，temp == 18 
                    }

                    try    //防止输错，使其只能输入一个字节的字符
                    {
                        byteBuffer[ii] = Convert.ToByte(decNum);
                    }
                    catch (System.Exception ex)
                    {
                        MessageBox.Show("字节越界，请逐个字节输入！", "Error");
                        tmSend.Enabled = false;
                        return;
                    }

                    ii++;
                }
                if (DisTimeCheckBox1.Checked)
                {
                    // txtReceive.Text += System.DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss fff")+":";
                    txtReceive.Text += System.DateTime.Now.ToString("HH:mm:ss:fff") + ":";
                }
                if (DisSendcheckBox.Checked)
                {
                    txtReceive.Text += "T:" + strSend + "\r\n";
                    txtReceive.SelectionStart = txtReceive.Text.Length;//选定文本的起点是文本框结尾
                    txtReceive.ScrollToCaret();//将滚动条滚到文本框结尾
                    //  txtReceive.Select(txtReceive.Text.Length-2, txtReceive.Text.Length);                 
                    //  txtReceive.SelectionColor = Color.Red;         //改变字体的颜色
                }
                sp1.Write(byteBuffer, 0, byteBuffer.Length);
                n = byteBuffer.Length;
                send_count += n;//累加发送字节数
                labelSendCount.Text = "Send:" + send_count.ToString() +"|";//更新界面
            }
            else		//以字符串形式发送时 
            {
                sp1.WriteLine(txtSend.Text);    //写入数据
            }
        }

        //开关按钮
        private void btnSwitch_Click(object sender, EventArgs e)
        {
            //serialPort1.IsOpen
            if (!sp1.IsOpen)
            {
                try
                {
                    //设置串口号
                    string serialName = cbSerial.SelectedItem.ToString();
                    sp1.PortName = serialName;

                    //设置各“串口设置”
                    string strBaudRate = cbBaudRate.Text;
                    string strDateBits = cbDataBits.Text;
                    string strStopBits = cbStop.Text;
                    Int32 iBaudRate = Convert.ToInt32(strBaudRate);
                    Int32 iDateBits = Convert.ToInt32(strDateBits);

                    sp1.BaudRate = iBaudRate;       //波特率
                    sp1.DataBits = iDateBits;       //数据位
                    switch (cbStop.Text)            //停止位
                    {
                        case "1":
                            sp1.StopBits = StopBits.One;
                            break;
                        case "1.5":
                            sp1.StopBits = StopBits.OnePointFive;
                            break;
                        case "2":
                            sp1.StopBits = StopBits.Two;
                            break;
                        default:
                            MessageBox.Show("Error：参数不正确!", "Error");
                            break;
                    }
                    switch (cbParity.Text)             //校验位
                    {
                        case "无":
                            sp1.Parity = Parity.None;
                            break;
                        case "奇校验":
                            sp1.Parity = Parity.Odd;
                            break;
                        case "偶校验":
                            sp1.Parity = Parity.Even;
                            break;
                        default:
                            MessageBox.Show("Error：参数不正确!", "Error");
                            break;
                    }

                    if (sp1.IsOpen == true)//如果打开状态，则先关闭一下
                    {
                        sp1.Close();
                    }
                    //状态栏设置
                    tsSpNum.Text = "串口号：" + sp1.PortName + "|";
                    tsBaudRate.Text = "波特率：" + sp1.BaudRate + "|";
                    tsDataBits.Text = "数据位：" + sp1.DataBits + "|";
                    tsStopBits.Text = "停止位：" + sp1.StopBits + "|";
                    tsParity.Text = "校验位：" + sp1.Parity + "|";

                    //设置必要控件不可用
               //     cbSerial.Enabled = false;
                    cbBaudRate.Enabled = false;
                    cbDataBits.Enabled = false;
                    cbStop.Enabled = false;
                    cbParity.Enabled = false;

                    sp1.Open();     //打开串口
                    btnSwitch.Text = "关闭串口";
                    txtReceive.AppendText("打开串口\r\n");


                }
                catch (System.Exception ex)
                {
                    MessageBox.Show("Error:" + ex.Message, "Error");
                    tmSend.Enabled = false;
                    return;
                }
            }
            else
            {
                //状态栏设置
                tsSpNum.Text = "串口号：未指定|";
                tsBaudRate.Text = "波特率：未指定|";
                tsDataBits.Text = "数据位：未指定|";
                tsStopBits.Text = "停止位：未指定|";
                tsParity.Text = "校验位：未指定|";
                //恢复控件功能
                //设置必要控件不可用
                cbSerial.Enabled = true;
                cbBaudRate.Enabled = true;
                cbDataBits.Enabled = true;
                cbStop.Enabled = true;
                cbParity.Enabled = true;
                sp1.Close();                    //关闭串口
                btnSwitch.Text = "打开串口";
                tmSend.Enabled = false;         //关闭计时器
            }
        }

        //清空按钮
        private void btnClear_Click(object sender, EventArgs e)
        {
            txtReceive.Text = "";       //清空文本
        }

        //退出按钮
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //关闭时事件
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            INIFILE.Profile.SaveProfile();
            sp1.Close();
        }

        private void txtSend_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (radio1.Checked == true)
            {
                //正则匹配
                string patten = "[0-9a-fA-F]|\b|0x|0X| "; //“\b”：退格键
                Regex r = new Regex(patten);
                Match m = r.Match(e.KeyChar.ToString());

                if (m.Success)//&&(txtSend.Text.LastIndexOf(" ") != txtSend.Text.Length-1))
                {
                    e.Handled = false;
                }
                else
                {
                    e.Handled = true;
                }
            }//end of radio1
            else
            {
                e.Handled = false;
            }
        }

     

        private void btnSave_Click(object sender, EventArgs e)
        {

            //设置各“串口设置”
            string strBaudRate = cbBaudRate.Text;
            string strDateBits = cbDataBits.Text;
            string strStopBits = cbStop.Text;
            Int32 iBaudRate = Convert.ToInt32(strBaudRate);
            Int32 iDateBits = Convert.ToInt32(strDateBits);

            Profile.G_BAUDRATE = iBaudRate + "";       //波特率
            Profile.G_DATABITS = iDateBits + "";       //数据位
            switch (cbStop.Text)            //停止位
            {
                case "1":
                    Profile.G_STOP = "1";
                    break;
                case "1.5":
                    Profile.G_STOP = "1.5";
                    break;
                case "2":
                    Profile.G_STOP = "2";
                    break;
                default:
                    MessageBox.Show("Error0：参数不正确!", "Error");
                    break;
            }
            switch (cbParity.Text)             //校验位
            {
                case "无":
                    Profile.G_PARITY = "NONE";
                    break;
                case "奇校验":
                    Profile.G_PARITY = "ODD";
                    break;
                case "偶校验":
                    Profile.G_PARITY = "EVEN";
                    break;
                default:
                    MessageBox.Show("Error1：参数不正确!", "Error");
                    break;
            }

            //保存设置
            // public static string G_BAUDRATE = "1200";//给ini文件赋新值，并且影响界面下拉框的显示
            //public static string G_DATABITS = "8";
            //public static string G_STOP = "1";
            //public static string G_PARITY = "NONE";
            Profile.SaveProfile();
        }

        //定时器
        private void tmSend_Tick(object sender, EventArgs e)
        {
            //转换时间间隔
            string strSecond = txtSecond.Text;
            try
            {
                int isecond = int.Parse(strSecond) * 1000;//Interval以微秒为单位
                tmSend.Interval = isecond;
                if (tmSend.Enabled == true)
                {
                    btnSend.PerformClick();
                }
            }
            catch (System.Exception ex)
            {
                tmSend.Enabled = false;
                MessageBox.Show("错误的定时输入！", "Error");
            }
        }

     

        private void lb_LCD_Paint(object sender, PaintEventArgs e)
        {
            Graphics gp = e.Graphics;
            gp.Clear(Color.Gainsboro);
            Pen p = new Pen(Color.White);
            for (int i = 5; i < 160 * 5; i = i + 5)
            {
                gp.DrawLine(p, 0, i, 1200 * 5, i);//画横白线
            }
            for (int i = 5; i < 1200 * 5; i += 5)
            {
                gp.DrawLine(p, i, 0, i, 160 * 5);
            }
            SolidBrush s = new SolidBrush(Color.Black);
            for (int x = 0; x < 240; x++)
            {
                for (int y = 0; y < 160; y++)
                {
                    if (ZLG_GUI.struArr[x, y]) gp.FillRectangle(s, x * 5 + 1, y * 5 + 1, 4, 4);

                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ZLG_GUI.GUI_Point(0, 2, true);
        }

        private void button2_Click(object sender, EventArgs e)
        {
                 Stopwatch sw = new Stopwatch();
                  sw.Start();

            ZLG_GUI.GUI_FillSCR(false);
          
            TimeSpan ts2 = sw.Elapsed;
            sw.Stop();
            var aa = ts2.TotalMilliseconds;

            textBoxErrCount.Text = aa.ToString();

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            //ZLG_GUI.GUI_HLine(3, 5, 10, true);
            //ZLG_GUI.GUI_RLine(3, 5, 10, true);
            // ZLG_GUI.GUI_Rectangle(10, 10, 50, 50, true);
            // ZLG_GUI.GUI_Line(10, 10, 70, 100, true);
            // ZLG_GUI.GUI_LineWith(10, 10, 70, 100,10, true); ;
            // ZLG_GUI.GUI_Circle(70, 100, 10, true);
            // ZLG_GUI.GUI_CircleFill(70, 100, 10, true);
            //ZLG_GUI.GUI_EllipseFill(10, 50, 10, 100, true);
            //ZLG_GUI.GUI_FloodFill(71, 98, true);
            //   ZLG_GUI.GUI_PutString5_7(20,20,"123456654564564etisuetioe0seytweywe");
            // ZLG_GUI.GUI_PutString8_8(40, 40, "123456654564564etisuetioe0seytweywe");
            //ZLG_GUI.GUI_PutChar24_32(100, 100, '7');
            //ZLG_GUI.GUI_PutChar24_32(133, 100, '4');
            // byte[] asdf = new byte[]
            //{
            //    0xf0, 0xff, 0xff, 0x10, 0x08, 0x04, 0x02, 0x01,
            //};
            //ZLG_GUI.GUI_LoadLine(50, 50, asdf, 16);

            //int[] test = { 3, 34, 6, 67, 5, 33, 2, 56, 79, 56, 3, };

            //ZLG_GUI.DeleteInArray<int>(ref test, 2);

            //ZLG_GUI.GUI_HLine(3, 5, 10, true);


           // YAT_lawn_hmi.Draw_swk();

           // YAT_lawn_hmi.Draw_meinv();

           YAT_lawn_hmi.Draw_zxc();


            //WINDOWS Win_Main = new WINDOWS( 0, 0, 160, 160, "ZLG_GUI", "Programme by CuiChao" );
            //ZLG_GUI.GUI_WindowsDraw(ref Win_Main);
            //ZLG_GUI.GUI_Circle(20, 20, 7, true);
            //ZLG_GUI.GUI_WindowsClr(ref Win_Main);

            // ZLG_GUI.GUI_WindowsHide(ref Win_Main);
            //  ZLG_GUI.GUI_Button_Cancle(101, 100);
            //  MENUICO menuico = new MENUICO(100, 100, ZLG_GUI.ICO1, ZLG_GUI.Title_ICO1, 1,null);
            //  ZLG_GUI.GUI_MenuIcoDraw(ref menuico);
        }

    private void lb_LCD_MouseMove(object sender, MouseEventArgs e)
        {
            int xPos, yPos;
            xPos = e.X / 5;
            yPos = e.Y / 5;
            lbLcd_x.Text = "LCD_X :"+ xPos.ToString();
            lbLcd_y.Text= "LCD_Y :" + yPos.ToString();

        }

        private void button3_Click(object sender, EventArgs e)
        {
             ZLG_GUI.GUI_PutString8_8(40, 0, "1234566etisuetioe0");

            ZLG_GUI.GUI_PutString8_16(20, 40,"Wellcome");
            //  ZLG_GUI.GUI_Rectangle(10, 10, 50, 50, true);
            // YAT_lawn_hmi.Draw_welcome();
            //   ZLG_GUI.GUI_PutChar24_32(100, 100, 'W');          
            //  YAT_lawn_hmi.Draw_meinv();
            // ZLG_GUI.GUI_LoadPic(0, 0, YAT_lawn_hmi.pic_meinv_152_160, 152, 160);

            //  WINDOWS Win_Main = new WINDOWS( 0, 0, 160, 160, "ZLG_GUI", "Programme by CuiChao" );
            //  ZLG_GUI.GUI_WindowsDraw(ref Win_Main);
            //YAT_lawn_hmi.Draw_welcome();

            // ZLG_GUI.GUI_Arc4(50, 50, 9, 1, true);
            //ZLG_GUI.GUI_Arc(100, 100, 50, 90, 180, true);

            //  ZLG_GUI.GUI_Pieslice(100, 100, 50, 90, 180, true);
            ZLG_GUI.GUI_Rounded_RectangleFill(70, 100, 150, 150, 10, true);
        }

        private void lb_LCD_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
                return;
            if (ckb_click_change_LCD.Checked)
            {
                int xPos, yPos;
                xPos = e.X / 5;
                yPos = e.Y / 5;
                if (ZLG_GUI.struArr[xPos, yPos] == true) ZLG_GUI.struArr[xPos, yPos] = false;
                else ZLG_GUI.struArr[xPos, yPos] = true;
                ZLG_GUI.GUI_Point(xPos, yPos, ZLG_GUI.struArr[xPos, yPos]);
                if (checkBoxDisCMD.Checked)
                {
                    string str=String.Format("GUI_Point({0},{1},{2});", xPos, yPos, ZLG_GUI.struArr[xPos, yPos]) + "\r\n";
                    txtReceive.AppendText(str);
                }
            }
        }

        private void Lb_LCD_Click(object sender, EventArgs e)
        {

        }
    }
}


