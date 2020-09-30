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
using System.Collections.Specialized;
using System.Threading;


namespace Ming_LCD
{

    public static class StaticClass
    {
        /// 去掉字符串中的数字  
        public static string RemoveNumber(string key)
        {
            return Regex.Replace(key, @"\d", "");
        }
        //去掉字符串中的非数字
        public static string RemoveNotNumber(string key)
        {
            return Regex.Replace(key, @"[^\d]*", "");
        }

        #region 字符串和Byte之间的转化
        /// <summary>
        /// 数字和字节之间互转
        /// </summary>
        /// <param name="num"></param>
        /// <returns></returns>
        public static int IntToBitConverter(int num)
        {
            int temp = 0;
            byte[] bytes = BitConverter.GetBytes(num);//将int32转换为字节数组
            temp = BitConverter.ToInt32(bytes, 0);//将字节数组内容再转成int32类型
            return temp;
        }

        /// <summary>
        /// 将字符串转为16进制字符，允许中文
        /// </summary>
        /// <param name="s"></param>
        /// <param name="encode"></param>
        /// <returns></returns>
        public static string StringToHexString(string s, Encoding encode, string spanString)
        {
            byte[] b = encode.GetBytes(s);//按照指定编码将string编程字节数组
            string result = string.Empty;
            for (int i = 0; i < b.Length; i++)//逐字节变为16进制字符
            {
                result += Convert.ToString(b[i], 16) + spanString;
            }
            return result;
        }
        /// <summary>
        /// 将16进制字符串转为字符串
        /// </summary>
        /// <param name="hs"></param>
        /// <param name="encode"></param>
        /// <returns></returns>
        public static string HexStringToString(string hs, Encoding encode)
        {
            string strTemp = "";
            byte[] b = new byte[hs.Length / 2];
            for (int i = 0; i < hs.Length / 2; i++)
            {
                strTemp = hs.Substring(i * 2, 2);
                b[i] = Convert.ToByte(strTemp, 16);
            }
            //按照指定编码将字节数组变为字符串
            return encode.GetString(b);
        }
        /// <summary>
        /// byte[]转为16进制字符串
        /// </summary>
        /// <param name="bytes"></param>
        /// <returns></returns>
        public static string ByteToHexStr(byte[] bytes)
        {
            string returnStr = "";
            if (bytes != null)
            {
                for (int i = 0; i < bytes.Length; i++)
                {
                    returnStr += bytes[i].ToString("X2")+" ";
                }
            }
            return returnStr;
        }
        /// <summary>
        /// 将16进制的字符串转为byte[]
        /// </summary>
        /// <param name="hexString"></param>
        /// <returns></returns>
        public static byte[] StrToHexByte(string hexString)
        {
            hexString = hexString.Replace(" ", "");
            if ((hexString.Length % 2) != 0)
                hexString += " ";
            byte[] returnBytes = new byte[hexString.Length / 2];
            for (int i = 0; i < returnBytes.Length; i++)
                returnBytes[i] = Convert.ToByte(hexString.Substring(i * 2, 2), 16);
            return returnBytes;
        }
 #endregion


       #region CRC计算函数
        private static readonly byte[] _auchCRCHi = new byte[]//crc高位表
        {
            0x00, 0xC1, 0x81, 0x40, 0x01, 0xC0, 0x80, 0x41, 0x01, 0xC0,
            0x80, 0x41, 0x00, 0xC1, 0x81, 0x40, 0x01, 0xC0, 0x80, 0x41,
            0x00, 0xC1, 0x81, 0x40, 0x00, 0xC1, 0x81, 0x40, 0x01, 0xC0,
            0x80, 0x41, 0x01, 0xC0, 0x80, 0x41, 0x00, 0xC1, 0x81, 0x40,
            0x00, 0xC1, 0x81, 0x40, 0x01, 0xC0, 0x80, 0x41, 0x00, 0xC1,
            0x81, 0x40, 0x01, 0xC0, 0x80, 0x41, 0x01, 0xC0, 0x80, 0x41,
            0x00, 0xC1, 0x81, 0x40, 0x01, 0xC0, 0x80, 0x41, 0x00, 0xC1,
            0x81, 0x40, 0x00, 0xC1, 0x81, 0x40, 0x01, 0xC0, 0x80, 0x41,
            0x00, 0xC1, 0x81, 0x40, 0x01, 0xC0, 0x80, 0x41, 0x01, 0xC0,
            0x80, 0x41, 0x00, 0xC1, 0x81, 0x40, 0x00, 0xC1, 0x81, 0x40,
            0x01, 0xC0, 0x80, 0x41, 0x01, 0xC0, 0x80, 0x41, 0x00, 0xC1,
            0x81, 0x40, 0x01, 0xC0, 0x80, 0x41, 0x00, 0xC1, 0x81, 0x40,
            0x00, 0xC1, 0x81, 0x40, 0x01, 0xC0, 0x80, 0x41, 0x01, 0xC0,
            0x80, 0x41, 0x00, 0xC1, 0x81, 0x40, 0x00, 0xC1, 0x81, 0x40,
            0x01, 0xC0, 0x80, 0x41, 0x00, 0xC1, 0x81, 0x40, 0x01, 0xC0,
            0x80, 0x41, 0x01, 0xC0, 0x80, 0x41, 0x00, 0xC1, 0x81, 0x40,
            0x00, 0xC1, 0x81, 0x40, 0x01, 0xC0, 0x80, 0x41, 0x01, 0xC0,
            0x80, 0x41, 0x00, 0xC1, 0x81, 0x40, 0x01, 0xC0, 0x80, 0x41,
            0x00, 0xC1, 0x81, 0x40, 0x00, 0xC1, 0x81, 0x40, 0x01, 0xC0,
            0x80, 0x41, 0x00, 0xC1, 0x81, 0x40, 0x01, 0xC0, 0x80, 0x41,
            0x01, 0xC0, 0x80, 0x41, 0x00, 0xC1, 0x81, 0x40, 0x01, 0xC0,
            0x80, 0x41, 0x00, 0xC1, 0x81, 0x40, 0x00, 0xC1, 0x81, 0x40,
            0x01, 0xC0, 0x80, 0x41, 0x01, 0xC0, 0x80, 0x41, 0x00, 0xC1,
            0x81, 0x40, 0x00, 0xC1, 0x81, 0x40, 0x01, 0xC0, 0x80, 0x41,
            0x00, 0xC1, 0x81, 0x40, 0x01, 0xC0, 0x80, 0x41, 0x01, 0xC0,
            0x80, 0x41, 0x00, 0xC1, 0x81, 0x40
        };
        private static readonly byte[] _auchCRCLo = new byte[]//crc低位表
        {
            0x00, 0xC0, 0xC1, 0x01, 0xC3, 0x03, 0x02, 0xC2, 0xC6, 0x06,
            0x07, 0xC7, 0x05, 0xC5, 0xC4, 0x04, 0xCC, 0x0C, 0x0D, 0xCD,
            0x0F, 0xCF, 0xCE, 0x0E, 0x0A, 0xCA, 0xCB, 0x0B, 0xC9, 0x09,
            0x08, 0xC8, 0xD8, 0x18, 0x19, 0xD9, 0x1B, 0xDB, 0xDA, 0x1A,
            0x1E, 0xDE, 0xDF, 0x1F, 0xDD, 0x1D, 0x1C, 0xDC, 0x14, 0xD4,
            0xD5, 0x15, 0xD7, 0x17, 0x16, 0xD6, 0xD2, 0x12, 0x13, 0xD3,
            0x11, 0xD1, 0xD0, 0x10, 0xF0, 0x30, 0x31, 0xF1, 0x33, 0xF3,
            0xF2, 0x32, 0x36, 0xF6, 0xF7, 0x37, 0xF5, 0x35, 0x34, 0xF4,
            0x3C, 0xFC, 0xFD, 0x3D, 0xFF, 0x3F, 0x3E, 0xFE, 0xFA, 0x3A,
            0x3B, 0xFB, 0x39, 0xF9, 0xF8, 0x38, 0x28, 0xE8, 0xE9, 0x29,
            0xEB, 0x2B, 0x2A, 0xEA, 0xEE, 0x2E, 0x2F, 0xEF, 0x2D, 0xED,
            0xEC, 0x2C, 0xE4, 0x24, 0x25, 0xE5, 0x27, 0xE7, 0xE6, 0x26,
            0x22, 0xE2, 0xE3, 0x23, 0xE1, 0x21, 0x20, 0xE0, 0xA0, 0x60,
            0x61, 0xA1, 0x63, 0xA3, 0xA2, 0x62, 0x66, 0xA6, 0xA7, 0x67,
            0xA5, 0x65, 0x64, 0xA4, 0x6C, 0xAC, 0xAD, 0x6D, 0xAF, 0x6F,
            0x6E, 0xAE, 0xAA, 0x6A, 0x6B, 0xAB, 0x69, 0xA9, 0xA8, 0x68,
            0x78, 0xB8, 0xB9, 0x79, 0xBB, 0x7B, 0x7A, 0xBA, 0xBE, 0x7E,
            0x7F, 0xBF, 0x7D, 0xBD, 0xBC, 0x7C, 0xB4, 0x74, 0x75, 0xB5,
            0x77, 0xB7, 0xB6, 0x76, 0x72, 0xB2, 0xB3, 0x73, 0xB1, 0x71,
            0x70, 0xB0, 0x50, 0x90, 0x91, 0x51, 0x93, 0x53, 0x52, 0x92,
            0x96, 0x56, 0x57, 0x97, 0x55, 0x95, 0x94, 0x54, 0x9C, 0x5C,
            0x5D, 0x9D, 0x5F, 0x9F, 0x9E, 0x5E, 0x5A, 0x9A, 0x9B, 0x5B,
            0x99, 0x59, 0x58, 0x98, 0x88, 0x48, 0x49, 0x89, 0x4B, 0x8B,
            0x8A, 0x4A, 0x4E, 0x8E, 0x8F, 0x4F, 0x8D, 0x4D, 0x4C, 0x8C,
            0x44, 0x84, 0x85, 0x45, 0x87, 0x47, 0x46, 0x86, 0x82, 0x42,
            0x43, 0x83, 0x41, 0x81, 0x80, 0x40
        };
     

        public static ushort CRC16(Byte[] buffer, int Sset, int Eset)
        {
            byte crcHi = 0xff;  // 高位初始化

            byte crcLo = 0xff;  // 低位初始化

            for (int i = Sset; i <= Eset; i++)
            {
                int crcIndex = crcHi ^ buffer[i]; //查找crc表值

                crcHi = (byte)(crcLo ^ _auchCRCHi[crcIndex]);
                crcLo = _auchCRCLo[crcIndex];
            }
            return (ushort)(crcHi << 8 | crcLo);
        }

  

       

        //取Word变量的高位字节、低位字节
        public static byte WORD_LO(ushort crcCLo)
        {
            crcCLo = (ushort)(crcCLo & 0X00FF);
            return (byte)crcCLo;
        }

        public static byte WORD_HI(ushort crcHI)
        {
            crcHI = (ushort)(crcHI >> 8 & 0X00FF);
            return (byte)crcHI;
        }
        //取DWord变量的高位字节、低位字节的宏
        public static ushort DWORD_LO(ushort crcCLo)
        {
            crcCLo = (ushort)(crcCLo & 0X0000FFFF);
            return crcCLo;
        }

        public static ushort DWORD_HI(ushort crcHI)
        {
            crcHI = (ushort)(crcHI >> 16 & 0X0000FFFF);
            return crcHI;
        }

        //判断是否是BCD码
        public static bool IS_BCD(byte BCD)
        {
            return (((((int)(BCD) & 0x000f) < 0x000a) && (((int)(BCD) & 0x00f0) < 0x00a0)) ? true : false);
        }
        //取一个字节的低位BCD码字符
        public static char BCD_LO(int bcd)
        {
            char bcdCLo = (char)((int)(bcd) & 0X000F + 0x30);
            return bcdCLo;
        }
        //取一个字节的高位BCD码字符
        public static char BCD_HI(int bcd)
        {
            char bcdHI = (char)((int)(bcd) >> 4 & 0X000F + 0x30);
            return bcdHI;
        }

        public static string ToHexString(byte[] bytes) // 0xae00cf => "AE00CF "
        {
            string hexString = string.Empty;

            if (bytes != null)
            {

                StringBuilder strB = new StringBuilder();

                for (int i = 0; i < bytes.Length; i++)
                {

                    strB.Append(bytes[i].ToString("X2"));

                }

                hexString = strB.ToString();

            }
            return hexString;

        }
        /// <summary>
        #endregion


       #region dategridview
        public static  DataTable mydt = new DataTable();
        public static DataTable NonBindSource()
            {
               
                mydt.Columns.Add("激活", Type.GetType("System.String"));
                mydt.Columns.Add("名称", Type.GetType("System.String"));
                mydt.Columns.Add("Address(1byte)", Type.GetType("System.String"));
                mydt.Columns.Add("Comand(1byte)", Type.GetType("System.String"));
                mydt.Columns.Add("Dat(2byte)", Type.GetType("System.String"));
                mydt.Columns.Add("NC", Type.GetType("System.String"));
                mydt.Columns.Add("顺序", Type.GetType("System.String"));
                string[,] mystr =
                { 
                    {"是" , "快速恒压",   "24",   "1" ,  "0",  "0",  "1"},
                    {"是" , "恒流",       "78" ,  "1",   "0",  "0",  "2"},
                    {"是" , "复位",       "65",   "1" ,  "0",  "0",  "3"},
                    {"是" , "返回温度",   "78" ,  "1",   "0",  "0",  "4"},
                    { "是" ,"返回时间",   "54" , "1",    "0",  "0",  "5"},
                    { "是" ,"关闭继电器", "87" ,  "1",   "0",  "0",  "6"},
                    { "是" ,"返回漏电流", "87" , "1",    "0",  "0",  "7"}
                };
               for (int i = 0; i < mystr.Length / 7; i++)
               {
                    DataRow mydr = mydt.NewRow();
                    mydr[0] = mystr[i, 0];
                    mydr[1] = mystr[i, 1];
                    mydr[2] = mystr[i, 2];
                    mydr[3] = mystr[i, 3];
                    mydr[4] = mystr[i, 4];
                    mydr[5] = mystr[i, 5];
                    mydr[6] = mystr[i, 6];                
                    mydt.Rows.Add(mydr);
                }                 
                return mydt;
            }
       

        public static void DataTableToTxt(DataGridView gridview, string path)
        {
            DataTable dtGrid1 = null; //定义一个数据表
            dtGrid1 = (DataTable)gridview.DataSource; //获取第一个datagridview里面的数据
            SaveFileDialog sf = new SaveFileDialog(); //实例化一个保存对话框
            sf.Filter = @"txt文件(*.txt)|*.txt|所有文件(*.*)|*.*"; //定义保存的文件的类型
            sf.FilterIndex = 1;
            sf.InitialDirectory = path;
            sf.Title = "保存命令文件";
            sf.FileName = "123";
            sf.ShowHelp = false;

            string str = "";
            if (sf.ShowDialog() == DialogResult.OK) //如果确定保存
            {
                if (sf.FileName == "") //如果没有输入文件名
                {
                    return;
                }
                StreamWriter sw = null; //定义一个文件流
                sw = new StreamWriter(sf.FileName, false, Encoding.Unicode);
          //      int allrows = gridview.Rows.Count;
          //      sw.WriteLine(allrows.ToString()); //写入表的行数，用于加载的时候使用
                sw.WriteLine("字段1\t\t字段2\t\t字段\t\t字段4\t\t字段5\t\t字段6\t\t字段7"); //写入表中的标题
                for (int i = 0; i < dtGrid1.Rows.Count; i++) //循环写入第一个表里面的数据
                {
                    for (int j = 0; j < dtGrid1.Columns.Count; j++)
                    {
                        str = dtGrid1.Rows[i][j].ToString();
                        if (str == "") str = "0";
                        sw.Write(str + "\t\t");
                    }
                    sw.WriteLine("");
                }
                sw.Dispose(); //释放资源
                sw.Close(); //关闭数据流
                MessageBox.Show("数据导出成功！", "系统提示：");

            }
        }

        public static void TxtToDataToble(DataGridView gridview , TextBox txtName)
        {
            string str = txtName.Text;
            string[] ss = str.Split('\n');
            int a = ss.Length;
            string[,] strStr = new string[a, 7];
            string[] str1 = ss[0].ToString().Trim().Split('\t');
            for (int i = 0; i < a - 1; i++)
            {
                str1 = ss[i].ToString().Trim().Split('\t');
                strStr[i, 0] = str1[0];
                strStr[i, 1] = str1[2];
                strStr[i, 2] = str1[4];
                strStr[i, 3] = str1[6];
                strStr[i, 4] = str1[8];
                strStr[i, 5] = str1[10];
                strStr[i, 6] = str1[12];
            }
            DataTable mydt = new DataTable();
            mydt.Columns.Add("激活", Type.GetType("System.String"));
            mydt.Columns.Add("命称", Type.GetType("System.String"));
            mydt.Columns.Add("数据1", Type.GetType("System.String"));
            mydt.Columns.Add("数据2", Type.GetType("System.String"));
            mydt.Columns.Add("数据3", Type.GetType("System.String"));
            mydt.Columns.Add("数据4", Type.GetType("System.String"));
            mydt.Columns.Add("顺序", Type.GetType("System.String"));
         


            for (int i = 0; i < (strStr.Length/ 7)-2; i++)
            {
                DataRow mydr = mydt.NewRow();
                mydr[0] = strStr[i + 1, 0];
                mydr[1] = strStr[i + 1, 1];
                mydr[2] = strStr[i + 1, 2];
                mydr[3] = strStr[i + 1, 3];
                mydr[4] = strStr[i + 1, 4];
                mydr[5] = strStr[i + 1, 5];
                mydr[6] = strStr[i + 1, 6];
                mydt.Rows.Add(mydr);

            }
            StaticClass.mydt = mydt;
            gridview.DataSource = StaticClass.mydt;
        }
     

        public static string GetTxtFile(TextBox txtName,string path)
        {
            OpenFileDialog opf = new OpenFileDialog(); //实例化一个打开对话框
            opf.Filter = @"txt文件(*.txt)|*.txt|所有文件(*.*)|*.*";
            //文件筛选器的设定
            opf.FilterIndex = 1;
            opf.Title = "加载命令文件";
            opf.FileName = "123";
            opf.InitialDirectory = path;
            opf.ShowHelp = false;
            string fName = "";
            if (opf.ShowDialog() == DialogResult.OK)
            {
                fName = opf.FileName;
                string fileCon = "";
                StreamReader sr = new StreamReader(fName, System.Text.Encoding.GetEncoding("gb2312"));
                while ((fileCon = sr.ReadLine()) != null)
                {
                    txtName.Text += fileCon;
                    txtName.Text += "\r\n";
                }
                sr.Close();
                MessageBox.Show("得到Txt成功！", "系统提示：");
            }
          
            return fName;
          #endregion
        }

    }



 #region Form1
    public partial class Form1 : Form
    {


            private  void serialLoad()
            {
                    INIFILE.Profile.LoadProfile();//加载所有
                    // 预置波特率
                    switch (Profile.G_BAUDRATE)
                    {
                        case "300":
                            cbBaudRate.SelectedIndex = 0;
                            break;
                        case "600":
                            cbBaudRate.SelectedIndex = 1;
                            break;
                        case "1200":
                            cbBaudRate.SelectedIndex = 2;
                            break;
                        case "2400":
                            cbBaudRate.SelectedIndex = 3;
                            break;
                        case "4800":
                            cbBaudRate.SelectedIndex = 4;
                            break;
                        case "9600":
                            cbBaudRate.SelectedIndex = 5;
                            break;
                        case "19200":
                            cbBaudRate.SelectedIndex = 6;
                            break;
                        case "38400":
                            cbBaudRate.SelectedIndex = 7;
                            break;
                        case "115200":
                            cbBaudRate.SelectedIndex = 8;
                            break;
                        default:
                            {
                                MessageBox.Show("波特率预置参数错误。");
                                return;
                            }
                    }

                    //预置波特率
                    switch (Profile.G_DATABITS)
                    {
                        case "5":
                            cbDataBits.SelectedIndex = 0;
                            break;
                        case "6":
                            cbDataBits.SelectedIndex = 1;
                            break;
                        case "7":
                            cbDataBits.SelectedIndex = 2;
                            break;
                        case "8":
                            cbDataBits.SelectedIndex = 3;
                            break;
                        default:
                            {
                                MessageBox.Show("数据位预置参数错误。");
                                return;
                            }

                    }
                    //预置停止位
                    switch (Profile.G_STOP)
                    {
                        case "1":
                            cbStop.SelectedIndex = 0;
                            break;
                        case "1.5":
                            cbStop.SelectedIndex = 1;
                            break;
                        case "2":
                            cbStop.SelectedIndex = 2;
                            break;
                        default:
                            {
                                MessageBox.Show("停止位预置参数错误。");
                                return;
                            }
                    }

                    //预置校验位
                    switch (Profile.G_PARITY)
                    {
                        case "NONE":
                            cbParity.SelectedIndex = 0;
                            break;
                        case "ODD":
                            cbParity.SelectedIndex = 1;
                            break;
                        case "EVEN":
                            cbParity.SelectedIndex = 2;
                            break;
                        default:
                            {
                                MessageBox.Show("校验位预置参数错误。");
                                return;
                            }
                    }

                    //检查是否含有串口
                    string[] str = SerialPort.GetPortNames();
                    if (str == null)
                    {
                        MessageBox.Show("本机没有串口！", "Error");
                        return;
                    }

                    //添加串口项目
                    foreach (string s in System.IO.Ports.SerialPort.GetPortNames())
                    {//获取有多少个COM口
                        //System.Diagnostics.Debug.WriteLine(s);
                        cbSerial.Items.Add(s);
                    }
                    //串口设置默认选择项
                    cbSerial.SelectedIndex = 1;         //note：获得COM9口，但别忘修改                                              
                    sp1.BaudRate = 9600;
                    //初始化SerialPort对象
                    sp1.NewLine = "\r\n";
    //                  Control.CheckForIllegalCrossThreadCalls = false;    //这个类中我们不检查跨线程的调用是否合法(因为.net 2.0以后加强了安全机制,，不允许在winform中直接跨线程访问控件的属性)
                    sp1.DataReceived += new SerialDataReceivedEventHandler(sp1_DataReceived);
                    sp1.ReceivedBytesThreshold = 1;
                    radio1.Checked = true;  //单选按钮默认是选中的
                    rbRcvStr.Checked = true;
                    //准备就绪              
                    sp1.DtrEnable = false;
                    sp1.RtsEnable = false;
                    //设置数据读取超时为1秒
                    sp1.ReadTimeout = 1000;
                    sp1.Close();


        }

    }

 }

#endregion



