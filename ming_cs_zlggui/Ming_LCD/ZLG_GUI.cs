using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using TCOLOR = System.Boolean;
using uint32 = System.Int32;
using uint8 = System.Int32;
using int32 = System.Int32;
using int8 = System.Int32;
using System.Diagnostics;

namespace Ming_LCD
{
    /// <summary>
    /// 坐标数据结构
    /// </summary>
    public struct PointXY
    {
       public  uint32 x;               // x坐标变量
        public uint32 y;               // y坐标变量
      }

  
    /// <summary>
    ///窗口数据结构 
    /// </summary>
    public struct WINDOWS
   {
        public uint32 x;         // 窗口位置(左上角的x坐标)
        public uint32 y;           // 窗口位置(左上角的y坐标)
        public uint32 with;        // 窗口宽度
        public uint32 hight;       // 窗口高度
        public string title;       // 定义标题栏指针 (标题字符为ASCII字符串，最大个数受窗口限制)
        public string state;        // 定义状态栏指针 (若为空时则不显示状态栏)   

        public WINDOWS(uint32 _x, uint32 _y, uint32 _with, uint32 _hight, string _title, string _state )
        {
            this.x = _x;
            this.y = _y;
            this.with = _with;
            this.hight = _hight;
            this.title = _title;
            this.state = _state;
        }
  
    }

    /// <summary>
    ///子菜单项的数据结构 
    /// </summary>
    public struct SMENU
    {
        public WINDOWS win;                 // 所属窗口
        public uint8 mmenu_no;             // 对应的主菜单项号(0-n)
        public uint8 no;                         // 子菜单项个数
        public string str;    // 子菜单字符串
        public uint8 state;                // 所选择的子菜单	
        public Action Function;// 子菜单对应的服务程序

        public SMENU(WINDOWS _win, uint8 _mmenu_no, uint8 _no  , string _str, uint8 _state, Action _Function)
        {
            this.win = _win;       
            this.mmenu_no = _mmenu_no;
            this.no = _no;
            this.str = _str;
            this.state = _state;
            this.Function = _Function;
        }
    };

    /// <summary>
    /// 主菜单数据结构
    /// </summary>
    public struct MMENU
    {
        public WINDOWS win;           // 所属窗口
        public uint8 no;             // 主菜单个数
        public  string str;         // 主菜单字符串
        public MMENU(WINDOWS _win,  uint8 _no, string _str)
        {
            this.win = _win;
            this.no = _no;
            this.str = _str;
        }




    };

    /// <summary>
    ///定义图标菜单数据结构 
    /// </summary>
    public struct MENUICO
    {
        public uint32 x;         // 图标菜单位置(左上角的x坐标)
        public uint32 y;           // 图标菜单位置(左上角的y坐标) 
        public Byte[]  icodat;      // 32*32的ICO数据地址
        public Byte[]  title;       // 相关标题提示 (42*13)
        public uint8 state;        // 图标菜单状态，为0时表示未选中，为1时表示已选中
        public Action Function;// 对应的服务程序
        public MENUICO(uint32 _x, uint32 _y, Byte[] _icodat, Byte[] _title, uint8 _state, Action _Function)
        {
            this.x = _x;
            this.y = _y;
            this.icodat = _icodat;
            this.title = _title;
            this.state = _state;
            this.Function = _Function;
        }



    };


    public static partial class ZLG_GUI
    {

        public static int GUI_LCM_XMAX = 240;
        public static int GUI_LCM_YMAX = 160;

        public static System.Windows.Forms.Label lable;
        public static bool[,] struArr = new bool[240, 160];
        public static Color blockColor = Color.Gainsboro;


        #region LCDDRIVE.C
        /// <summary>
        /// 在画布上打方格
        /// </summary>
        /// <param name="gp"></param>
        public static void Draw_LCD(Graphics gp)
        {
            Pen p = new Pen(Color.White);
            for (int i = 5; i < 160 * 5; i = i + 5)
            {
                gp.DrawLine(p, 0, i, 1200 * 5, i);//画横白线
            }
            for (int i = 5; i < 1200 * 5; i += 5)//横竖白线
            {
                gp.DrawLine(p, i, 0, i, 160 * 5);
            }

        }

        /// <summary>
        /// 全屏填充。直接使用数据填充显示缓冲区。
        /// </summary>
        /// <param name="dat"></param>
        public static void GUI_FillSCR(TCOLOR dat)
        {
            for (int x = 0; x < 240; x++)
            {
                for (int y = 0; y < 160; y++)
                {
                    GUI_Point(x, y, dat);
                }
            }
        }



     public static SolidBrush s = new SolidBrush(Color.Black);
        /// <summary>
        /// 在指定位置上画点
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="color"></param>
        /// 
        public static void GUI_Point(int x, int y, TCOLOR color)
        {

      //     Stopwatch sw = new Stopwatch();
        //      sw.Start();
            //耗时巨大的代码
  
        //    if (x >= GUI_LCM_XMAX || x<0) return ;
        //    if (y >= GUI_LCM_YMAX || y <0) return ;
           
            if( color)
            {
                s.Color = Color.Black;
            }
             else
            {
                s.Color = ZLG_GUI.blockColor;
            }
            Form1.gpp.FillRectangle(s, x * 5 + 1, y * 5 + 1, 4, 4);//参数为x,y,length,weigh
            ZLG_GUI.struArr[x, y] = color;
            //     TimeSpan ts2 = sw.Elapsed;
            // sw.Stop();
            //  var aa = ts2.TotalMilliseconds;
            //      gp.Dispose();//释放Graphics
        }


        /// <summary>
        /// 读取指定点的颜色。
        /// </summary>
        /// <param name="x">指定点所在列的位置</param>
        /// <param name="y">指定点所在行的位置</param>
        /// <param name="ret">保存颜色值的指针</param>
        /// <returns>返回0时表示指定地址超出有效范围</returns>
        public static int GUI_ReadPoint(uint32 x, uint32 y, out TCOLOR ret)
        {
            TCOLOR bak;
            ret = false;
            /* 参数过滤 */
            if (x >= GUI_LCM_XMAX) return (0);
            if (y >= GUI_LCM_YMAX) return (0);
            /* 取得该点颜色(用户自行更改) */
            bak = ZLG_GUI.struArr[x, y];
            ret = bak;
            return (1);
        }

        /// <summary>
        /// 画水平线
        /// </summary>
        /// <param name="x0">水平线起点所在列的位置</param>
        /// <param name="y0">水平线起点所在行的位置</param>
        /// <param name="x1">水平线起点所在行的位置</param>
        /// <param name="color">显示颜色</param>
        public static void GUI_HLine(uint32 x0, uint32 y0, uint32 x1, TCOLOR color)
        {
            uint32 temp;
            if (x0 > x1)               // 对x0、x1大小进行排列，以便画图
            {
                temp = x1;
                x1 = x0;
                x0 = temp;
            }
            do
            {
                GUI_Point(x0, y0, color);   // 逐点显示，描出垂直线
                x0++;
            }
            while (x1 >= x0);
        }


        /// <summary>
        /// 画垂直线
        /// </summary>
        /// <param name="x0">垂直线起点所在列的位置</param>
        /// <param name="y0">垂直线起点所在行的位置</param>
        /// <param name="y1">垂直线终点所在行的位置</param>
        /// <param name="color">显示颜色</param>
        public static void  GUI_RLine(uint32 x0, uint32 y0, uint32 y1, TCOLOR color)
        {
            uint32 temp;
            if (y0 > y1)       // 对y0、y1大小进行排列，以便画图
            {
                temp = y1;
                y1 = y0;
                y0 = temp;
            }
            do
            {
                GUI_Point(x0, y0, color);   // 逐点显示，描出垂直线
                y0++;
            }
            while (y1 >= y0);
        }
        #endregion


        #region GUI_BASIC.C
        /// <summary>
        /// 画矩形
        /// </summary>
        /// <param name="x0">矩形左上角的x坐标值</param>
        /// <param name="y0">矩形左上角的y坐标值</param>
        /// <param name="x1">矩形右下角的x坐标值</param>
        /// <param name="y1">矩形右下角的y坐标值</param>
        /// <param name="color">显示颜色</param>
        public static void GUI_Rectangle(uint32 x0, uint32 y0, uint32 x1, uint32 y1, TCOLOR color)
        {
            GUI_HLine(x0, y0, x1, color);
            GUI_HLine(x0, y1, x1, color);
            GUI_RLine(x0, y0, y1, color);
            GUI_RLine(x1, y0, y1, color);
        }


        /// <summary>
        /// 填充矩形。画一个填充的矩形，填充色与边框色一样。
        /// </summary>
        /// <param name="x0">矩形左上角的x坐标值</param>
        /// <param name="y0">矩形左上角的y坐标值</param>
        /// <param name="x1">矩形右下角的x坐标值</param>
        /// <param name="y1">矩形右下角的y坐标值</param>
        /// <param name="color">填充颜色</param>
        public static void GUI_RectangleFill(uint32 x0, uint32 y0, uint32 x1, uint32 y1, TCOLOR color)
        {
            uint32 i;

            /* 先找出矩形左上角与右下角的两个点，保存在(x0,y0)，(x1,y1) */
            if (x0 > x1)                        // 若x0>x1，则x0与x1交换
            {
                i = x0;
                x0 = x1;
                x1 = i;
            }
            if (y0 > y1)                        // 若y0>y1，则y0与y1交换
            {
                i = y0;
                y0 = y1;
                y1 = i;
            }

            /* 判断是否只是直线 */
            if (y0 == y1)
            {
                GUI_HLine(x0, y0, x1, color);
                return;
            }
            if (x0 == x1)
            {
                GUI_RLine(x0, y0, y1, color);
                return;
            }

            while (y0 <= y1)
            {
                GUI_HLine(x0, y0, x1, color);   // 当前画水平线
                y0++;                           // 下一行
            }
        }


        /// <summary>
        /// 画圆角矩形
        /// </summary>
        /// <param name="x0">矩形左上角的x坐标值</param>
        /// <param name="y0">矩形左上角的y坐标值</param>
        /// <param name="x1">矩形右下角的x坐标值</param>
        /// <param name="y1">矩形右下角的y坐标值</param>
        /// <param name="r">圆角矩形半径</param>
        /// <param name="color">显示颜色</param>
        public static void GUI_Rounded_Rectangle(uint32 x0, uint32 y0, uint32 x1, uint32 y1, uint32 r, TCOLOR color)
        {
            GUI_HLine(x0+r, y0, x1-r, color);
            GUI_HLine(x0+r, y1, x1-r, color);
            GUI_RLine(x0, y0+r, y1-r, color);
            GUI_RLine(x1, y0+r, y1-r, color);
            GUI_Arc4(x0 + r, y0 + r, r, 2, color);
            GUI_Arc4(x1 -r,  y0 + r, r, 1, color);
            GUI_Arc4(x0 + r, y1 - r, r, 3, color);
            GUI_Arc4(x1 - r, y1 - r, r, 4, color);
        }

        /// <summary>
        /// 填充圆角矩形。画一个圆角填充的矩形，填充色与边框色一样。
        /// </summary>
        /// <param name="x0">矩形左上角的x坐标值</param>
        /// <param name="y0">矩形左上角的y坐标值</param>
        /// <param name="x1">矩形右下角的x坐标值</param>
        /// <param name="y1">矩形右下角的y坐标值</param>
        /// < param name="r">圆角矩形半径</param>
        /// <param name="color">填充颜色</param>
        public static void GUI_Rounded_RectangleFill(uint32 x0, uint32 y0, uint32 x1, uint32 y1, uint32 r, TCOLOR color)
        {
            GUI_Rounded_Rectangle(x0, y0, x1, y1, r, color);
            GUI_FloodFill(x0 + r, y0 + r, color);
        }


        /// <summary>
        /// 画正方形
        /// </summary>
        /// <param name="x0">正方形左上角的x坐标值</param>
        /// <param name="y0">正方形左上角的y坐标值</param>
        /// <param name="with">正方形的边长</param>
        /// <param name="color">显示颜色</param>
        public static void GUI_Square(uint32 x0, uint32 y0, uint32 with, TCOLOR color)
        {
            if (with == 0) return;
            if ((x0 + with) > GUI_LCM_XMAX) return;
            if ((y0 + with) > GUI_LCM_YMAX) return;
            GUI_Rectangle(x0, y0, x0 + with, y0 + with, color);
        }


        /// <summary>
        /// Bresenham直线算法与画圆算法
        /// https://www.cnblogs.com/wlzy/p/8695226.html
        /// https://www.cnblogs.com/gamesky/archive/2012/08/21/2648623.html
        ///画任意两点之间的直线
        /// </summary>
        /// <param name="x0">直线起点的x坐标值</param>
        /// <param name="y0">直线起点的y坐标值</param>
        /// <param name="x1">直线终点的x坐标值</param>
        /// <param name="y1">直线终点的y坐标值</param>
        /// <param name="color">显示颜色</param>
        public static void GUI_Line(uint32 x0, uint32 y0, uint32 x1, uint32 y1, TCOLOR color)
        {
            int32 dx;                       // 直线x轴差值变量
            int32 dy;                   // 直线y轴差值变量
            int8 dx_sym;                    // x轴增长方向，为-1时减值方向，为1时增值方向
            int8 dy_sym;                    // y轴增长方向，为-1时减值方向，为1时增值方向
            int32 dx_x2;                    // dx*2值变量，用于加快运算速度
            int32 dy_x2;                    // dy*2值变量，用于加快运算速度
            int32 di;                       // 决策变量
            dx = x1 - x0;                       // 求取两点之间的差值
            dy = y1 - y0;
            /* 判断增长方向，或是否为水平线、垂直线、点 */
            if (dx > 0)                         // 判断x轴方向
            {
                dx_sym = 1;                 // dx>0，设置dx_sym=1
            }
            else
            {
                if (dx < 0)
                {
                    dx_sym = -1;                // dx<0，设置dx_sym=-1
                }
                else
                {  // dx==0，画垂直线，或一点
                    GUI_RLine(x0, y0, y1, color);
                    return;
                }
            }

            if (dy > 0)                         // 判断y轴方向
            {
                dy_sym = 1;                 // dy>0，设置dy_sym=1
            }
            else
            {
                if (dy < 0)
                {
                    dy_sym = -1;                // dy<0，设置dy_sym=-1
                }
                else
                {  // dy==0，画水平线，或一点
                    GUI_HLine(x0, y0, x1, color);
                    return;
                }
            }

            /* 将dx、dy取绝对值 */
            dx = dx_sym * dx;
            dy = dy_sym * dy;

            /* 计算2倍的dx及dy值 */
            dx_x2 = dx * 2;
            dy_x2 = dy * 2;

            /* 使用Bresenham法进行画直线 */
            if (dx >= dy)                       // 对于dx>=dy，则使用x轴为基准
            {
                di = dy_x2 - dx;
                while (x0 != x1)
                {
                    GUI_Point(x0, y0, color);
                    x0 += dx_sym;
                    if (di < 0)
                    {
                        di += dy_x2;            // 计算出下一步的决策值
                    }
                    else
                    {
                        di += dy_x2 - dx_x2;
                        y0 += dy_sym;
                    }
                }
                GUI_Point(x0, y0, color);       // 显示最后一点
            }
            else                                // 对于dx<dy，则使用y轴为基准
            {
                di = dx_x2 - dy;
                while (y0 != y1)
                {
                    GUI_Point(x0, y0, color);
                    y0 += dy_sym;
                    if (di < 0)
                    {
                        di += dx_x2;
                    }
                    else
                    {
                        di += dx_x2 - dy_x2;
                        x0 += dx_sym;
                    }
                }
                GUI_Point(x0, y0, color);       // 显示最后一点
            }

        }

        /// <summary>
        /// 画任意两点之间的直线，并且可设置线的宽度。
        /// </summary>
        /// <param name="x0">直线起点的x坐标值</param>
        /// <param name="y0">直线起点的y坐标值</param>
        /// <param name="x1">直线终点的x坐标值</param>
        /// <param name="y1">直线终点的y坐标值</param>
        /// <param name="with">线宽(0-50)</param>
        /// <param name="color">显示颜色</param>
        public static void GUI_LineWith(uint32 x0, uint32 y0, uint32 x1, uint32 y1, uint8 with, TCOLOR color)
        {
            int32 dx;                       // 直线x轴差值变量
            int32 dy;                   // 直线y轴差值变量
            int8 dx_sym;                    // x轴增长方向，为-1时减值方向，为1时增值方向
            int8 dy_sym;                    // y轴增长方向，为-1时减值方向，为1时增值方向
            int32 dx_x2;                    // dx*2值变量，用于加快运算速度
            int32 dy_x2;                    // dy*2值变量，用于加快运算速度
            int32 di;                       // 决策变量

            int32 wx, wy;                   // 线宽变量
            int32 draw_a, draw_b;

            /* 参数过滤 */
            if (with == 0) return;
            if (with > 50) with = 50;

            dx = x1 - x0;                       // 求取两点之间的差值
            dy = y1 - y0;

            wx = with / 2;
            wy = with - wx - 1;

            /* 判断增长方向，或是否为水平线、垂直线、点 */
            if (dx > 0)                         // 判断x轴方向
            {
                dx_sym = 1;                 // dx>0，设置dx_sym=1
            }
            else
            {
                if (dx < 0)
                {
                    dx_sym = -1;                // dx<0，设置dx_sym=-1
                }
                else
                {  /* dx==0，画垂直线，或一点 */
                    wx = x0 - wx;
                    if (wx < 0) wx = 0;
                    wy = x0 + wy;

                    while (true)
                    {
                        x0 = wx;
                        GUI_RLine(x0, y0, y1, color);
                        if (wx >= wy) break;
                        wx++;
                    }

                    return;
                }
            }

            if (dy > 0)                         // 判断y轴方向
            {
                dy_sym = 1;                 // dy>0，设置dy_sym=1
            }
            else
            {
                if (dy < 0)
                {
                    dy_sym = -1;                // dy<0，设置dy_sym=-1
                }
                else
                {  /* dy==0，画水平线，或一点 */
                    wx = y0 - wx;
                    if (wx < 0) wx = 0;
                    wy = y0 + wy;

                    while (true)
                    {
                        y0 = wx;
                        GUI_HLine(x0, y0, x1, color);
                        if (wx >= wy) break;
                        wx++;
                    }
                    return;
                }
            }

            /* 将dx、dy取绝对值 */
            dx = dx_sym * dx;
            dy = dy_sym * dy;

            /* 计算2倍的dx及dy值 */
            dx_x2 = dx * 2;
            dy_x2 = dy * 2;

            /* 使用Bresenham法进行画直线 */
            if (dx >= dy)                       // 对于dx>=dy，则使用x轴为基准
            {
                di = dy_x2 - dx;
                while (x0 != x1)
                {  /* x轴向增长，则宽度在y方向，即画垂直线 */
                    draw_a = y0 - wx;
                    if (draw_a < 0) draw_a = 0;
                    draw_b = y0 + wy;
                    GUI_RLine(x0, draw_a, draw_b, color);

                    x0 += dx_sym;
                    if (di < 0)
                    {
                        di += dy_x2;            // 计算出下一步的决策值
                    }
                    else
                    {
                        di += dy_x2 - dx_x2;
                        y0 += dy_sym;
                    }
                }
                draw_a = y0 - wx;
                if (draw_a < 0) draw_a = 0;
                draw_b = y0 + wy;
                GUI_RLine(x0, draw_a, draw_b, color);
            }
            else                                // 对于dx<dy，则使用y轴为基准
            {
                di = dx_x2 - dy;
                while (y0 != y1)
                {  /* y轴向增长，则宽度在x方向，即画水平线 */
                    draw_a = x0 - wx;
                    if (draw_a < 0) draw_a = 0;
                    draw_b = x0 + wy;
                    GUI_HLine(draw_a, y0, draw_b, color);

                    y0 += dy_sym;
                    if (di < 0)
                    {
                        di += dx_x2;
                    }
                    else
                    {
                        di += dx_x2 - dy_x2;
                        x0 += dx_sym;
                    }
                }
                draw_a = x0 - wx;
                if (draw_a < 0) draw_a = 0;
                draw_b = x0 + wy;
                GUI_HLine(draw_a, y0, draw_b, color);
            }
        }


        /// <summary>
        /// 指定圆心位置及半径，画圆。
        /// </summary>
        /// <param name="x0">圆心的x坐标值</param>
        /// <param name="y0">圆心的y坐标值</param>
        /// <param name="r">圆的半径</param>
        /// <param name="color">显示颜色</param>
        public static void GUI_Circle(uint32 x0, uint32 y0, uint32 r, TCOLOR color)
        {
            int32 draw_x0, draw_y0;         // 刽图点坐标变量
            int32 draw_x1, draw_y1;
            int32 draw_x2, draw_y2;
            int32 draw_x3, draw_y3;
            int32 draw_x4, draw_y4;
            int32 draw_x5, draw_y5;
            int32 draw_x6, draw_y6;
            int32 draw_x7, draw_y7;
            int32 xx, yy;                   // 画圆控制变量

            int32 di;                       // 决策变量

            /* 参数过滤 */
            if (0 == r) return;

            /* 计算出8个特殊点(0、45、90、135、180、225、270度)，进行显示 */
            draw_x0 = draw_x1 = x0;
            draw_y0 = draw_y1 = y0 + r;
            if (draw_y0 < GUI_LCM_YMAX) GUI_Point(draw_x0, draw_y0, color); // 90度

            draw_x2 = draw_x3 = x0;
            draw_y2 = draw_y3 = y0 - r;
            if (draw_y2 >= 0) GUI_Point(draw_x2, draw_y2, color);           // 270度


            draw_x4 = draw_x6 = x0 + r;
            draw_y4 = draw_y6 = y0;
            if (draw_x4 < GUI_LCM_XMAX) GUI_Point(draw_x4, draw_y4, color); // 0度

            draw_x5 = draw_x7 = x0 - r;
            draw_y5 = draw_y7 = y0;
            if (draw_x5 >= 0) GUI_Point(draw_x5, draw_y5, color);           // 180度   
            if (1 == r) return;                 // 若半径为1，则已圆画完


            /* 使用Bresenham法进行画圆 */
            di = 3 - 2 * r;                 // 初始化决策变量

            xx = 0;
            yy = r;
            while (xx < yy)
            {
                if (di < 0)
                {
                    di += 4 * xx + 6;
                }
                else
                {
                    di += 4 * (xx - yy) + 10;

                    yy--;
                    draw_y0--;
                    draw_y1--;
                    draw_y2++;
                    draw_y3++;
                    draw_x4--;
                    draw_x5++;
                    draw_x6--;
                    draw_x7++;
                }

                xx++;
                draw_x0++;
                draw_x1--;
                draw_x2++;
                draw_x3--;
                draw_y4++;
                draw_y5++;
                draw_y6--;
                draw_y7--;


                /* 要判断当前点是否在有效范围内 */
                if ((draw_x0 <= GUI_LCM_XMAX) && (draw_y0 >= 0))
                {
                    GUI_Point(draw_x0, draw_y0, color);
                }
                if ((draw_x1 >= 0) && (draw_y1 >= 0))
                {
                    GUI_Point(draw_x1, draw_y1, color);
                }
                if ((draw_x2 <= GUI_LCM_XMAX) && (draw_y2 <= GUI_LCM_YMAX))
                {
                    GUI_Point(draw_x2, draw_y2, color);
                }
                if ((draw_x3 >= 0) && (draw_y3 <= GUI_LCM_YMAX))
                {
                    GUI_Point(draw_x3, draw_y3, color);
                }
                if ((draw_x4 <= GUI_LCM_XMAX) && (draw_y4 >= 0))
                {
                    GUI_Point(draw_x4, draw_y4, color);
                }
                if ((draw_x5 >= 0) && (draw_y5 >= 0))
                {
                    GUI_Point(draw_x5, draw_y5, color);
                }
                if ((draw_x6 <= GUI_LCM_XMAX) && (draw_y6 <= GUI_LCM_YMAX))
                {
                    GUI_Point(draw_x6, draw_y6, color);
                }
                if ((draw_x7 >= 0) && (draw_y7 <= GUI_LCM_YMAX))
                {
                    GUI_Point(draw_x7, draw_y7, color);
                }
            }
        }


        /// <summary>
        /// 指定圆心位置及半径，画圆并填充，填充色与边框色一样。
        /// </summary>
        /// <param name="x0">圆心的x坐标值</param>
        /// <param name="y0">圆心的y坐标值</param>
        /// <param name="r">圆的半径</param>
        /// <param name="color">填充颜色</param>
        public static void GUI_CircleFill(uint32 x0, uint32 y0, uint32 r, TCOLOR color)
        {
            int32 draw_x0, draw_y0;         // 刽图点坐标变量
            int32 draw_x1, draw_y1;
            int32 draw_x2, draw_y2;
            int32 draw_x3, draw_y3;
            int32 draw_x4, draw_y4;
            int32 draw_x5, draw_y5;
            int32 draw_x6, draw_y6;
            int32 draw_x7, draw_y7;
            int32 fill_x0, fill_y0;         // 填充所需的变量，使用垂直线填充
            int32 fill_x1;
            int32 xx, yy;                   // 画圆控制变量

            int32 di;                       // 决策变量

            /* 参数过滤 */
            if (0 == r) return;

            /* 计算出4个特殊点(0、90、180、270度)，进行显示 */
            draw_x0 = draw_x1 = x0;
            draw_y0 = draw_y1 = y0 + r;
            if (draw_y0 < GUI_LCM_YMAX)
            {
                GUI_Point(draw_x0, draw_y0, color); // 90度
            }

            draw_x2 = draw_x3 = x0;
            draw_y2 = draw_y3 = y0 - r;
            if (draw_y2 >= 0)
            {
                GUI_Point(draw_x2, draw_y2, color); // 270度
            }

            draw_x4 = draw_x6 = x0 + r;
            draw_y4 = draw_y6 = y0;
            if (draw_x4 < GUI_LCM_XMAX)
            {
                GUI_Point(draw_x4, draw_y4, color); // 0度
                fill_x1 = draw_x4;
            }
            else
            {
                fill_x1 = GUI_LCM_XMAX;
            }
            fill_y0 = y0;                           // 设置填充线条起始点fill_x0
            fill_x0 = x0 - r;                       // 设置填充线条结束点fill_y1
            if (fill_x0 < 0) fill_x0 = 0;
            GUI_HLine(fill_x0, fill_y0, fill_x1, color);

            draw_x5 = draw_x7 = x0 - r;
            draw_y5 = draw_y7 = y0;
            if (draw_x5 >= 0)
            {
                GUI_Point(draw_x5, draw_y5, color); // 180度
            }
            if (1 == r) return;


            /* 使用Bresenham法进行画圆 */
            di = 3 - 2 * r;                         // 初始化决策变量

            xx = 0;
            yy = r;
            while (xx < yy)
            {
                if (di < 0)
                {
                    di += 4 * xx + 6;
                }
                else
                {
                    di += 4 * (xx - yy) + 10;

                    yy--;
                    draw_y0--;
                    draw_y1--;
                    draw_y2++;
                    draw_y3++;
                    draw_x4--;
                    draw_x5++;
                    draw_x6--;
                    draw_x7++;
                }

                xx++;
                draw_x0++;
                draw_x1--;
                draw_x2++;
                draw_x3--;
                draw_y4++;
                draw_y5++;
                draw_y6--;
                draw_y7--;


                /* 要判断当前点是否在有效范围内 */
                if ((draw_x0 <= GUI_LCM_XMAX) && (draw_y0 >= 0))
                {
                    GUI_Point(draw_x0, draw_y0, color);
                }
                if ((draw_x1 >= 0) && (draw_y1 >= 0))
                {
                    GUI_Point(draw_x1, draw_y1, color);
                }

                /* 第二点水直线填充(下半圆的点) */
                if (draw_x1 >= 0)
                {  /* 设置填充线条起始点fill_x0 */
                    fill_x0 = draw_x1;
                    /* 设置填充线条起始点fill_y0 */
                    fill_y0 = draw_y1;
                    if (fill_y0 > GUI_LCM_YMAX) fill_y0 = GUI_LCM_YMAX;
                    if (fill_y0 < 0) fill_y0 = 0;
                    /* 设置填充线条结束点fill_x1 */
                    fill_x1 = x0 * 2 - draw_x1;
                    if (fill_x1 > GUI_LCM_XMAX) fill_x1 = GUI_LCM_XMAX;
                    GUI_HLine(fill_x0, fill_y0, fill_x1, color);
                }


                if ((draw_x2 <= GUI_LCM_XMAX) && (draw_y2 <= GUI_LCM_YMAX))
                {
                    GUI_Point(draw_x2, draw_y2, color);
                }

                if ((draw_x3 >= 0) && (draw_y3 <= GUI_LCM_YMAX))
                {
                    GUI_Point(draw_x3, draw_y3, color);
                }

                /* 第四点垂直线填充(上半圆的点) */
                if (draw_x3 >= 0)
                {  /* 设置填充线条起始点fill_x0 */
                    fill_x0 = draw_x3;
                    /* 设置填充线条起始点fill_y0 */
                    fill_y0 = draw_y3;
                    if (fill_y0 > GUI_LCM_YMAX) fill_y0 = GUI_LCM_YMAX;
                    if (fill_y0 < 0) fill_y0 = 0;
                    /* 设置填充线条结束点fill_x1 */
                    fill_x1 = x0 * 2 - draw_x3;
                    if (fill_x1 > GUI_LCM_XMAX) fill_x1 = GUI_LCM_XMAX;
                    GUI_HLine(fill_x0, fill_y0, fill_x1, color);
                }


                if ((draw_x4 <= GUI_LCM_XMAX) && (draw_y4 >= 0))
                {
                    GUI_Point(draw_x4, draw_y4, color);
                }
                if ((draw_x5 >= 0) && (draw_y5 >= 0))
                {
                    GUI_Point(draw_x5, draw_y5, color);
                }

                /* 第六点垂直线填充(上半圆的点) */
                if (draw_x5 >= 0)
                {  /* 设置填充线条起始点fill_x0 */
                    fill_x0 = draw_x5;
                    /* 设置填充线条起始点fill_y0 */
                    fill_y0 = draw_y5;
                    if (fill_y0 > GUI_LCM_YMAX) fill_y0 = GUI_LCM_YMAX;
                    if (fill_y0 < 0) fill_y0 = 0;
                    /* 设置填充线条结束点fill_x1 */
                    fill_x1 = x0 * 2 - draw_x5;
                    if (fill_x1 > GUI_LCM_XMAX) fill_x1 = GUI_LCM_XMAX;
                    GUI_HLine(fill_x0, fill_y0, fill_x1, color);
                }


                if ((draw_x6 <= GUI_LCM_XMAX) && (draw_y6 <= GUI_LCM_YMAX))
                {
                    GUI_Point(draw_x6, draw_y6, color);
                }

                if ((draw_x7 >= 0) && (draw_y7 <= GUI_LCM_YMAX))
                {
                    GUI_Point(draw_x7, draw_y7, color);
                }

                /* 第八点垂直线填充(上半圆的点) */
                if (draw_x7 >= 0)
                {  /* 设置填充线条起始点fill_x0 */
                    fill_x0 = draw_x7;
                    /* 设置填充线条起始点fill_y0 */
                    fill_y0 = draw_y7;
                    if (fill_y0 > GUI_LCM_YMAX) fill_y0 = GUI_LCM_YMAX;
                    if (fill_y0 < 0) fill_y0 = 0;
                    /* 设置填充线条结束点fill_x1 */
                    fill_x1 = x0 * 2 - draw_x7;
                    if (fill_x1 > GUI_LCM_XMAX) fill_x1 = GUI_LCM_XMAX;
                    GUI_HLine(fill_x0, fill_y0, fill_x1, color);
                }

            }
        }

        /// <summary>
        /// 画正椭圆。给定椭圆的四个点的参数，最左、最右点的x轴坐标值为x0、x1，最上、最下点的y轴坐标为y0、y1。
        /// </summary>
        /// <param name="x0">最左点的x坐标值</param>
        /// <param name="x1">最右点的x坐标值</param>
        /// <param name="y0">最上点的y坐标值</param>
        /// <param name="y1">最下点的y坐标值</param>
        /// <param name="color">显示颜色</param>
        public static void GUI_Ellipse(uint32 x0, uint32 x1, uint32 y0, uint32 y1, TCOLOR color)
        {
            int32 draw_x0, draw_y0;         // 刽图点坐标变量
            int32 draw_x1, draw_y1;
            int32 draw_x2, draw_y2;
            int32 draw_x3, draw_y3;
            int32 xx, yy;                   // 画图控制变量

            int32 center_x, center_y;       // 椭圆中心点坐标变量
            int32 radius_x, radius_y;       // 椭圆的半径，x轴半径和y轴半径
            int32 radius_xx, radius_yy;     // 半径乘平方值
            int32 radius_xx2, radius_yy2;   // 半径乘平方值的两倍
            int32 di;                       // 定义决策变量

            /* 参数过滤 */
            if ((x0 == x1) || (y0 == y1)) return;

            /* 计算出椭圆中心点坐标 */
            center_x = (x0 + x1) >> 1;
            center_y = (y0 + y1) >> 1;

            /* 计算出椭圆的半径，x轴半径和y轴半径 */
            if (x0 > x1)
            {
                radius_x = (x0 - x1) >> 1;
            }
            else
            {
                radius_x = (x1 - x0) >> 1;
            }
            if (y0 > y1)
            {
                radius_y = (y0 - y1) >> 1;
            }
            else
            {
                radius_y = (y1 - y0) >> 1;
            }

            /* 计算半径平方值 */
            radius_xx = radius_x * radius_x;
            radius_yy = radius_y * radius_y;

            /* 计算半径平方值乘2值 */
            radius_xx2 = radius_xx << 1;
            radius_yy2 = radius_yy << 1;

            /* 初始化画图变量 */
            xx = 0;
            yy = radius_y;

            di = radius_yy2 + radius_xx - radius_xx2 * radius_y;    // 初始化决策变量 

            /* 计算出椭圆y轴上的两个端点坐标，作为作图起点 */
            draw_x0 = draw_x1 = draw_x2 = draw_x3 = center_x;
            draw_y0 = draw_y1 = center_y + radius_y;
            draw_y2 = draw_y3 = center_y - radius_y;


            GUI_Point(draw_x0, draw_y0, color);                 // 画y轴上的两个端点 
            GUI_Point(draw_x2, draw_y2, color);

            while ((radius_yy * xx) < (radius_xx * yy))
            {
                if (di < 0)
                {
                    di += radius_yy2 * (2 * xx + 3);
                }
                else
                {
                    di += radius_yy2 * (2 * xx + 3) + 4 * radius_xx - 4 * radius_xx * yy;

                    yy--;
                    draw_y0--;
                    draw_y1--;
                    draw_y2++;
                    draw_y3++;
                }

                xx++;                       // x轴加1

                draw_x0++;
                draw_x1--;
                draw_x2++;
                draw_x3--;

                GUI_Point(draw_x0, draw_y0, color);
                GUI_Point(draw_x1, draw_y1, color);
                GUI_Point(draw_x2, draw_y2, color);
                GUI_Point(draw_x3, draw_y3, color);
            }

            di = radius_xx2 * (yy - 1) * (yy - 1) + radius_yy2 * xx * xx + radius_yy + radius_yy2 * xx - radius_xx2 * radius_yy;
            while (yy >= 0)
            {
                if (di < 0)
                {
                    di += radius_xx2 * 3 + 4 * radius_yy * xx + 4 * radius_yy - 2 * radius_xx2 * yy;

                    xx++;                       // x轴加1	 		
                    draw_x0++;
                    draw_x1--;
                    draw_x2++;
                    draw_x3--;
                }
                else
                {
                    di += radius_xx2 * 3 - 2 * radius_xx2 * yy;
                }

                yy--;
                draw_y0--;
                draw_y1--;
                draw_y2++;
                draw_y3++;

                GUI_Point(draw_x0, draw_y0, color);
                GUI_Point(draw_x1, draw_y1, color);
                GUI_Point(draw_x2, draw_y2, color);
                GUI_Point(draw_x3, draw_y3, color);
            }
        }


        /// <summary>
        ///画正椭圆，并填充。给定椭圆的四个点的参数，最左、最右点的x轴坐标值为x0、x1，最上、最下点
        ///的y轴坐标为y0、y1。 
        /// </summary>
        /// <param name="x0">最左点的x坐标值</param>
        /// <param name="x1">最右点的x坐标值</param>
        /// <param name="y0">最上点的y坐标值</param>
        /// <param name="y1">最下点的y坐标值</param>
        /// <param name="color">显示颜色</param>
        public static void GUI_EllipseFill(uint32 x0, uint32 x1, uint32 y0, uint32 y1, TCOLOR color)
        {
            int32 draw_x0, draw_y0;         // 刽图点坐标变量
            int32 draw_x1, draw_y1;
            int32 draw_x2, draw_y2;
            int32 draw_x3, draw_y3;
            int32 xx, yy;                   // 画图控制变量

            int32 center_x, center_y;       // 椭圆中心点坐标变量
            int32 radius_x, radius_y;       // 椭圆的半径，x轴半径和y轴半径
            int32 radius_xx, radius_yy;     // 半径乘平方值
            int32 radius_xx2, radius_yy2;   // 半径乘平方值的两倍
            int32 di;                       // 定义决策变量

            /* 参数过滤 */
            if ((x0 == x1) || (y0 == y1)) return;

            /* 计算出椭圆中心点坐标 */
            center_x = (x0 + x1) >> 1;
            center_y = (y0 + y1) >> 1;

            /* 计算出椭圆的半径，x轴半径和y轴半径 */
            if (x0 > x1)
            {
                radius_x = (x0 - x1) >> 1;
            }
            else
            {
                radius_x = (x1 - x0) >> 1;
            }
            if (y0 > y1)
            {
                radius_y = (y0 - y1) >> 1;
            }
            else
            {
                radius_y = (y1 - y0) >> 1;
            }

            /* 计算半径乘平方值 */
            radius_xx = radius_x * radius_x;
            radius_yy = radius_y * radius_y;

            /* 计算半径乘4值 */
            radius_xx2 = radius_xx << 1;
            radius_yy2 = radius_yy << 1;

            /* 初始化画图变量 */
            xx = 0;
            yy = radius_y;

            di = radius_yy2 + radius_xx - radius_xx2 * radius_y;    // 初始化决策变量 

            /* 计算出椭圆y轴上的两个端点坐标，作为作图起点 */
            draw_x0 = draw_x1 = draw_x2 = draw_x3 = center_x;
            draw_y0 = draw_y1 = center_y + radius_y;
            draw_y2 = draw_y3 = center_y - radius_y;


            GUI_Point(draw_x0, draw_y0, color);                 // 画y轴上的两个端点
            GUI_Point(draw_x2, draw_y2, color);

            while ((radius_yy * xx) < (radius_xx * yy))
            {
                if (di < 0)
                {
                    di += radius_yy2 * (2 * xx + 3);
                }
                else
                {
                    di += radius_yy2 * (2 * xx + 3) + 4 * radius_xx - 4 * radius_xx * yy;

                    yy--;
                    draw_y0--;
                    draw_y1--;
                    draw_y2++;
                    draw_y3++;
                }

                xx++;                       // x轴加1

                draw_x0++;
                draw_x1--;
                draw_x2++;
                draw_x3--;

                GUI_Point(draw_x0, draw_y0, color);
                GUI_Point(draw_x1, draw_y1, color);
                GUI_Point(draw_x2, draw_y2, color);
                GUI_Point(draw_x3, draw_y3, color);

                /* 若y轴已变化，进行填充 */
                if (di >= 0)
                {
                    GUI_HLine(draw_x0, draw_y0, draw_x1, color);
                    GUI_HLine(draw_x2, draw_y2, draw_x3, color);
                }
            }

            di = radius_xx2 * (yy - 1) * (yy - 1) + radius_yy2 * xx * xx + radius_yy + radius_yy2 * xx - radius_xx2 * radius_yy;
            while (yy >= 0)
            {
                if (di < 0)
                {
                    di += radius_xx2 * 3 + 4 * radius_yy * xx + 4 * radius_yy - 2 * radius_xx2 * yy;

                    xx++;                       // x轴加1	 		
                    draw_x0++;
                    draw_x1--;
                    draw_x2++;
                    draw_x3--;
                }
                else
                {
                    di += radius_xx2 * 3 - 2 * radius_xx2 * yy;
                }

                yy--;
                draw_y0--;
                draw_y1--;
                draw_y2++;
                draw_y3++;

                GUI_Point(draw_x0, draw_y0, color);
                GUI_Point(draw_x1, draw_y1, color);
                GUI_Point(draw_x2, draw_y2, color);
                GUI_Point(draw_x3, draw_y3, color);

                /* y轴已变化，进行填充 */
                GUI_HLine(draw_x0, draw_y0, draw_x1, color);
                GUI_HLine(draw_x2, draw_y2, draw_x3, color);
            }
        }

        //////////////////////////////////////////////////////////////////////////////////////////////////////////

        /// <summary>
        /// 判断颜色值是否一致。
        /// </summary>
        /// <param name="color1">颜色值1</param>
        /// <param name="color2">颜色值2</param>
        /// <returns>返回1表示相同，返回0表示不相同</returns>
        public static  bool  GUI_CmpColor(TCOLOR color1, TCOLOR color2)
        {
            if (color1 == color2) return true;
            else                 return false;
        }


        /// <summary>
        ///找出指定点左边最近的非color点。 
        /// </summary>
        /// <param name="x0">指定点的x坐标值</param>
        /// <param name="y0">指定点的y坐标值</param>
        /// <param name="color">指定颜色值</param>
        /// <returns>返回该点的x轴坐标值。</returns>
        public static uint32 GUI_ReadLeftPoint(uint32 x0, uint32 y0, TCOLOR color)
        {
            uint32 i;
            TCOLOR bakc;
            for (i = x0 - 1; i > 0; i--)
            {
                GUI_ReadPoint(i, y0, out bakc);
                if (GUI_CmpColor(bakc, color) == false) return (i + 1); // 若找到，则返回
            }
            GUI_ReadPoint(i, y0, out bakc);
            if (GUI_CmpColor(bakc, color) == false) return (1);     // 若找到，则返回
            return (0);
        }

        /// <summary>
        /// 找出指定点右边最近的非color点。
        /// </summary>
        /// <param name="x0">指定点的x轴坐标值</param>
        /// <param name="y0">指定点的y轴坐标值</param>
        /// <param name="color">指定颜色值</param>
        /// <returns></returns>
        public static uint32 GUI_ReadRightPoint(uint32 x0, uint32 y0, TCOLOR color)
        {
            uint32 i;
            TCOLOR bakc;

            for (i = x0 + 1; i < GUI_LCM_XMAX; i++)
            {
                GUI_ReadPoint(i, y0, out bakc);
                if (GUI_CmpColor(bakc, color) == false) return (i - 1); // 若找到，则返回
            }
            return (GUI_LCM_XMAX);
        }

        /// <summary>
        /// 判断指定点上的颜色是否为某种颜色。
        /// </summary>
        /// <param name="x">指定点的x轴坐标值</param>
        /// <param name="y">指定点的y轴坐标值</param>
        /// <param name="color">颜色值</param>
        /// <returns>返回1表示相同，返回0表示不相同。</returns>
        public static bool GUI_CmpPointColor(uint32 x, uint32 y, TCOLOR color)
        {
            TCOLOR bakc;
            GUI_ReadPoint(x, y, out bakc);
            return (GUI_CmpColor(bakc, color));
        }

        public static int DOWNP_N = 20;
        public static int UPP_N = 20;
        /// <summary>
        /// 图形填充，将指定点内的封闭图形进行填充。对指定点的颜色区域进行填充，即不是该颜色
        /// 的像素为边界(如，指定点上的颜色为红色，则其它颜色像素均为边界)。
        /// </summary>
        /// <param name="x0">指定点的x坐标值</param>
        /// <param name="y0">指定点的y坐标值</param>
        /// <param name="color">填充颜色</param>
        public static void GUI_FloodFill(uint32 x0, uint32 y0, TCOLOR color)
        {
            PointXY[] down_point = new PointXY[DOWNP_N];    // 定义向下填充转折点缓冲区
            uint8 down_no;              // 向下折点个数
            PointXY[] up_point= new PointXY[UPP_N];        // 定义向上填充转折点缓冲区
            uint8 up_no;                    // 向上折点个数
            TCOLOR fcolor;                  // 填充点上的颜色

            uint32 xx, yy;                  // 填充临时x，y变量 (当前填充行的中点)
            uint32 xx0;                     // 当前填充行的左x值变量
            uint32 xx1;                     // 当前填充行的右y值变量
            uint32 i;

            uint32 x0_bak, y0_bak;
            uint32 x1_bak;

            /* 参数过滤 */
            if (x0 >= GUI_LCM_XMAX) return;
            if (y0 >= GUI_LCM_YMAX) return;

            /* 判断指定点是否为填充颜色，若是则直接返回 */
            GUI_ReadPoint(x0, y0, out fcolor);                     // 取得填充点的颜色
            if (GUI_CmpColor(fcolor, color) != false) return;

            y0_bak = y0;
            x0_bak = xx0 = GUI_ReadLeftPoint(x0, y0, fcolor);               // 找出当前y坐标上的最左边的点
            x1_bak = xx1 = GUI_ReadRightPoint(x0, y0, fcolor);          // 找出当前y坐标上的最右边的点
            down_point[0].x = up_point[0].x = (xx1 + xx0) / 2;
            down_point[0].y = up_point[0].y = y0;
            down_no = 1;
            up_no = 1;

            /* 开始向上填充 */
            FILL_UP:
            if (0 == up_no) goto FILL_DOWN;                         // 若向下扫描已完成，则退出
            xx = up_point[up_no - 1].x;                         // 否则取出下一折点
            yy = up_point[up_no - 1].y;
            up_no--;
            xx0 = GUI_ReadLeftPoint(xx, yy, fcolor);
            xx1 = GUI_ReadRightPoint(xx, yy, fcolor);
            while (true)
            {
                yy += 1;                                            // 中心点向上一点

                if (GUI_CmpPointColor(xx, yy, fcolor) == false)
                {  /* 判断此点是否为终点，若是则退出此次循环 */
                    for (i = xx0; i <= xx1; i++)                        // 查找此行是否有需填充点
                    {
                        if (GUI_CmpPointColor(i, yy, fcolor) != false) break;
                    }
                    if (i > xx1) goto FILL_UP;

                    /* 找出新一行中最右边的点 */
                    xx = i;                                     // 更新xx到要填充的有效区域内
                    xx1 = GUI_ReadRightPoint(xx, yy, fcolor);
                }
                else
                {  /* 找出新一行中最右边的点 */
                    xx1 = GUI_ReadRightPoint(xx, yy, fcolor);
                }
                xx0 = GUI_ReadLeftPoint(xx, yy, fcolor);

                /* 向下折点。使用y0作为折点变量，x0作为上一折点变量 */
                if (down_no < DOWNP_N)
                {
                    y0 = xx0;
                    x0 = y0 - 1;
                    for (i = y0; i <= xx1; i++)
                    {
                        if (GUI_CmpPointColor(i, yy - 1, fcolor) == false)  // 更新折点
                        {
                            y0 = i;
                        }
                        else
                        {
                            if (x0 != y0)                               // 找到新的折点
                            {
                                x0 = y0;
                                down_point[down_no].x = i;
                                down_point[down_no].y = yy;
                                down_no++;
                            }
                        }
                        if (down_no >= DOWNP_N) break;                  // 若缓冲区已保存满，则退出
                    } // end  of for(i=y0+1; i<xx1; i++)
                } // end of if(down_no<DOWNP_N)

                xx = (xx1 + xx0) / 2;                               // 更新中心点
                GUI_HLine(xx0, yy, xx1, color);                 // 填充一行

                /* 向上折点。使用y0作为折点变量，x0作为上一折点变量 */
                if (up_no < UPP_N)
                {
                    y0 = xx0;
                    x0 = y0 - 1;
                    for (i = y0; i <= xx1; i++)
                    {
                        if (GUI_CmpPointColor(i, yy + 1, fcolor) == false)  // 更新折点
                        {
                            y0 = i;
                        }
                        else
                        {
                            if (x0 != y0)                               // 找到新的折点
                            {
                                x0 = y0;
                                up_point[up_no].x = i;
                                up_point[up_no].y = yy;
                                up_no++;
                            }
                        }
                        if (up_no >= UPP_N) break;                      // 若缓冲区已保存满，则退出
                    }
                } // end of if(up_no<UPP_N)

            } // end of while(1) 

            /* 向下填充 */
            FILL_DOWN:
            if (0 == down_no)
            {
                if (0 == up_no)
                {
                    GUI_HLine(x0_bak, y0_bak, x1_bak, color);
                    return;                             // 若向下扫描已完成，且没有发现新的向上折点，则退出
                }
                else
                {
                    goto FILL_UP;
                }
            }
            xx = down_point[down_no - 1].x;                     // 否则取出下一折点
            yy = down_point[down_no - 1].y;
            down_no--;
            xx0 = GUI_ReadLeftPoint(xx, yy, fcolor);
            xx1 = GUI_ReadRightPoint(xx, yy, fcolor);

            while (true)
            {
                yy -= 1;                                            // 中心点向上一点 
                if (GUI_CmpPointColor(xx, yy, fcolor) == false)
                {  /* 判断此点是否为终点，若是则退出此次循环 */
                    for (i = xx0; i <= xx1; i++)                        // 查找下一行是否有需填充点
                    {
                        if (GUI_CmpPointColor(i, yy, fcolor) != false) break;
                    }
                    if (i > xx1) goto FILL_DOWN;

                    /* 找出新一行中最右边的点 */
                    xx = i;
                    xx1 = GUI_ReadRightPoint(xx, yy, fcolor);
                }
                else
                {  /* 找出新一行中最右边的点 */
                    xx1 = GUI_ReadRightPoint(xx, yy, fcolor);
                }
                xx0 = GUI_ReadLeftPoint(xx, yy, fcolor);

                /* 向上折点。使用y0作为折点变量，x0作为上一折点变量 */
                if (up_no < UPP_N)
                {
                    y0 = xx0;
                    x0 = y0 - 1;
                    for (i = y0; i <= xx1; i++)
                    {
                        if (GUI_CmpPointColor(i, yy + 1, fcolor) == false)  // 更新折点
                        {
                            y0 = i;
                        }
                        else
                        {
                            if (x0 != y0)                               // 找到新的折点
                            {
                                x0 = y0;
                                up_point[up_no].x = i;
                                up_point[up_no].y = yy;
                                up_no++;
                            }
                        }
                        if (up_no >= UPP_N) break;                      // 若缓冲区已保存满，则退出
                    }
                }

                xx = (xx1 + xx0) / 2;
                GUI_HLine(xx0, yy, xx1, color);                 // 填充一行

                /* 向下折点。使用y0作为折点变量，x0作为上一折点变量 */
                if (down_no < DOWNP_N)
                {
                    y0 = xx0;
                    x0 = y0 - 1;
                    for (i = y0; i <= xx1; i++)
                    {
                        if (GUI_CmpPointColor(i, yy - 1, fcolor) == false)  // 更新折点
                        {
                            y0 = i;
                        }
                        else
                        {
                            if (x0 != y0)                               // 找到新的折点
                            {
                                x0 = y0;
                                down_point[down_no].x = i;
                                down_point[down_no].y = yy;
                                down_no++;
                            }
                        }
                        if (down_no >= DOWNP_N) break;                  // 若缓冲区已保存满，则退出
                    }
                } // end of if(down_no<DOWNP_N)

            } // end of while(1) 
        }

        /// <summary>
        /// 画弧。起点及终点只能为0度-90度、90度-180度、180度-270度、270度-0度等。即分别 为第1-4像限的90度弧。
        /// </summary>
        /// <param name="x">圆心的x坐标值</param>
        /// <param name="y">圆心的y坐标值</param>
        /// <param name="r">圆弧的半径</param>
        /// <param name="angle">画弧的像限(1-4)</param>
        /// <param name="color">显示颜色</param>
        public static void GUI_Arc4(uint32 x, uint32 y, uint32 r, uint8 angle, TCOLOR color)
        {
            int32 draw_x, draw_y;

            int32 op_x, op_y;
            int32 op_2rr;
            angle = 5 - angle;
            if (r == 0) return;

            op_2rr = 2 * r * r;                                     // 计算r平方乖以2

            switch (angle)
            {
                case 1:
                    draw_x = x + r;
                    draw_y = y;

                    op_x = r;
                    op_y = 0;

                    while (true)
                    {
                        GUI_Point(draw_x, draw_y, color);       // 开始画图

                        /* 计算下一点 */
                        op_y++;
                        draw_y++;
                        if ((2 * op_x * op_x + 2 * op_y * op_y - op_2rr - 2 * op_x + 1) > 0)    // 使用逐点比较法实现画圆弧
                        {
                            op_x--;
                            draw_x--;
                        }
                        if (op_y >= op_x) break;
                    }
                    while (true)
                    {
                        GUI_Point(draw_x, draw_y, color);       // 开始画图

                        /* 计算下一点 */
                        op_x--;
                        draw_x--;
                        if ((2 * op_x * op_x + 2 * op_y * op_y - op_2rr + 2 * op_y + 1) <= 0)   // 使用逐点比较法实现画圆弧
                        {
                            op_y++;
                            draw_y++;
                        }
                        if (op_x <= 0)
                        {
                            GUI_Point(draw_x, draw_y, color);       // 开始画图
                            break;
                        }
                    }

                    break;

                case 2:
                    draw_x = x - r;
                    draw_y = y;

                    op_x = r;
                    op_y = 0;

                    while (true)
                    {
                        GUI_Point(draw_x, draw_y, color);       // 开始画图

                        /* 计算下一点 */
                        op_y++;
                        draw_y++;
                        if ((2 * op_x * op_x + 2 * op_y * op_y - op_2rr - 2 * op_x + 1) > 0)    // 使用逐点比较法实现画圆弧
                        {
                            op_x--;
                            draw_x++;
                        }
                        if (op_y >= op_x) break;
                    }
                    while (true)
                    {
                        GUI_Point(draw_x, draw_y, color);       // 开始画图

                        /* 计算下一点 */
                        op_x--;
                        draw_x++;
                        if ((2 * op_x * op_x + 2 * op_y * op_y - op_2rr + 2 * op_y + 1) <= 0)   // 使用逐点比较法实现画圆弧
                        {
                            op_y++;
                            draw_y++;
                        }
                        if (op_x <= 0)
                        {
                            GUI_Point(draw_x, draw_y, color);       // 开始画图
                            break;
                        }
                    }

                    break;

                case 3:
                    draw_x = x - r;
                    draw_y = y;

                    op_x = r;
                    op_y = 0;

                    while (true)
                    {
                        GUI_Point(draw_x, draw_y, color);       // 开始画图

                        /* 计算下一点 */
                        op_y++;
                        draw_y--;
                        if ((2 * op_x * op_x + 2 * op_y * op_y - op_2rr - 2 * op_x + 1) > 0)    // 使用逐点比较法实现画圆弧
                        {
                            op_x--;
                            draw_x++;
                        }
                        if (op_y >= op_x) break;
                    }
                    while (true)
                    {
                        GUI_Point(draw_x, draw_y, color);       // 开始画图

                        /* 计算下一点 */
                        op_x--;
                        draw_x++;
                        if ((2 * op_x * op_x + 2 * op_y * op_y - op_2rr + 2 * op_y + 1) <= 0)   // 使用逐点比较法实现画圆弧
                        {
                            op_y++;
                            draw_y--;
                        }
                        if (op_x <= 0)
                        {
                            GUI_Point(draw_x, draw_y, color);       // 开始画图
                            break;
                        }
                    }

                    break;

                case 4:
                    draw_x = x + r;
                    draw_y = y;

                    op_x = r;
                    op_y = 0;

                    while (true)
                    {
                        GUI_Point(draw_x, draw_y, color);       // 开始画图

                        /* 计算下一点 */
                        op_y++;
                        draw_y--;
                        if ((2 * op_x * op_x + 2 * op_y * op_y - op_2rr - 2 * op_x + 1) > 0)    // 使用逐点比较法实现画圆弧
                        {
                            op_x--;
                            draw_x--;
                        }
                        if (op_y >= op_x) break;
                    }
                    while (true)
                    {
                        GUI_Point(draw_x, draw_y, color);       // 开始画图

                        /* 计算下一点 */
                        op_x--;
                        draw_x--;
                        if ((2 * op_x * op_x + 2 * op_y * op_y - op_2rr + 2 * op_y + 1) <= 0)   // 使用逐点比较法实现画圆弧
                        {
                            op_y++;
                            draw_y--;
                        }
                        if (op_x <= 0)
                        {
                            GUI_Point(draw_x, draw_y, color);       // 开始画图
                            break;
                        }
                    }
                    break;

                default:
                    break;

            }

        }

       
        /// <summary>
        /// 指定起点、终点及半径画弧(不能画圆)。
        /// </summary>
        /// <param name="x">圆心的x轴坐标值</param>
        /// <param name="y">圆心的y轴坐标值</param>
        /// <param name="r">起始角度(0-359度)</param>
        /// <param name="stangle">终止角度(0-359度)</param>
        /// <param name="endangle">圆的半径终点</param>
        /// <param name="color">显示颜色</param>
        public static void GUI_Arc(uint32 x, uint32 y, uint32 r, uint32 stangle, uint32 endangle, TCOLOR color)
        {
            int32 draw_x, draw_y;                   // 画图坐标变量
            int32 op_x, op_y;                       // 操作坐标
            int32 op_2rr;                           // 2*r*r值变量

            int32 pno_angle;                        // 度角点的个数
            uint8 draw_on;                          // 画点开关，为1时画点，为0时不画

            stangle = 360 - stangle;
            endangle = 360 - endangle;

            /* 参数过滤 */
            if (r == 0) return;                         // 半径为0则直接退出
            if (stangle == endangle) return;            // 起始角度与终止角度相同，退出
            if ((stangle >= 360) || (endangle >= 360)) return;

            op_2rr = 2 * r * r;                         // 计算r平方乖以2
            pno_angle = 0;
            /* 先计算出在此半径下的45度的圆弧的点数 */
            op_x = r;
            op_y = 0;
            while (true)
            {
                pno_angle++;                            // 画点计数         
                                                        /* 计算下一点 */
                op_y++;
                if ((2 * op_x * op_x + 2 * op_y * op_y - op_2rr - 2 * op_x + 1) > 0)    // 使用逐点比较法实现画圆弧
                {
                    op_x--;
                }
                if (op_y >= op_x) break;
            }

            draw_on = 0;                                // 最开始关画点开关
                                                        /* 设置起始点及终点 */
            if (endangle > stangle) draw_on = 1;        // 若终点大于起点，则从一开始即画点(359)
            stangle = (360 - stangle) * pno_angle / 45;
            endangle = (360 - endangle) * pno_angle / 45;
            if (stangle == 0) stangle = 1;
            if (endangle == 0) endangle = 1;

            /* 开始顺时针画弧，从359度开始(第4像限) */
            pno_angle = 0;

            draw_x = x + r;
            draw_y = y;
            op_x = r;
            op_y = 0;
            while (true)
            {  /* 计算下一点 */
                op_y++;
                draw_y--;
                if ((2 * op_x * op_x + 2 * op_y * op_y - op_2rr - 2 * op_x + 1) > 0)    // 使用逐点比较法实现画圆弧
                {
                    op_x--;
                    draw_x--;
                }
                if (draw_on == 1) GUI_Point(draw_x, draw_y, color);         // 开始画图
                pno_angle++;
                if ((pno_angle == stangle) || (pno_angle == endangle))          // 若遇到起点或终点，画点开关取反
                {
                    draw_on = 1 - draw_on;
                    if (draw_on == 1) GUI_Point(draw_x, draw_y, color);
                }
                if (op_y >= op_x)
                {
                    if (draw_on == 1) GUI_Point(draw_x, draw_y, color);
                    break;
                }
            }

            while (true)
            {  /* 计算下一点 */
                op_x--;
                draw_x--;
                if ((2 * op_x * op_x + 2 * op_y * op_y - op_2rr + 2 * op_y + 1) <= 0) // 使用逐点比较法实现画圆弧
                {
                    op_y++;
                    draw_y--;
                }
                if (draw_on == 1) GUI_Point(draw_x, draw_y, color);         // 开始画图
                pno_angle++;
                if ((pno_angle == stangle) || (pno_angle == endangle))          // 若遇到起点或终点，画点开关取反
                {
                    draw_on = 1 - draw_on;
                    if (draw_on == 1) GUI_Point(draw_x, draw_y, color);
                }

                if (op_x <= 0)
                {
                    if (draw_on == 1) GUI_Point(draw_x, draw_y, color);     // 开始画图
                    break;
                }
            }


            /* 开始顺时针画弧，从269度开始(第3像限) */
            draw_y = y - r;
            draw_x = x;
            op_y = r;
            op_x = 0;
            while (true)
            {  /* 计算下一点 */
                op_x++;
                draw_x--;
                if ((2 * op_x * op_x + 2 * op_y * op_y - op_2rr - 2 * op_y + 1) > 0) // 使用逐点比较法实现画圆弧
                {
                    op_y--;
                    draw_y++;
                }
                if (draw_on == 1) GUI_Point(draw_x, draw_y, color);         // 开始画图
                pno_angle++;
                if ((pno_angle == stangle) || (pno_angle == endangle))          // 若遇到起点或终点，画点开关取反
                {
                    draw_on = 1 - draw_on;
                    if (draw_on == 1) GUI_Point(draw_x, draw_y, color);
                }

                if (op_x >= op_y)
                {
                    if (draw_on == 1) GUI_Point(draw_x, draw_y, color);     // 开始画图
                    break;
                }
            }

            while (true)
            {  /* 计算下一点 */
                op_y--;
                draw_y++;
                if ((2 * op_x * op_x + 2 * op_y * op_y - op_2rr + 2 * op_x + 1) <= 0) // 使用逐点比较法实现画圆弧
                {
                    op_x++;
                    draw_x--;
                }
                if (draw_on == 1) GUI_Point(draw_x, draw_y, color);         // 开始画图
                pno_angle++;
                if ((pno_angle == stangle) || (pno_angle == endangle))          // 若遇到起点或终点，画点开关取反
                {
                    draw_on = 1 - draw_on;
                    if (draw_on == 1) GUI_Point(draw_x, draw_y, color);
                }
                if (op_y <= 0)
                {
                    if (draw_on == 1) GUI_Point(draw_x, draw_y, color);
                    break;
                }
            }


            /* 开始顺时针画弧，从179度开始(第2像限) */
            draw_x = x - r;
            draw_y = y;
            op_x = r;
            op_y = 0;
            while (true)
            {  /* 计算下一点 */
                op_y++;
                draw_y++;
                if ((2 * op_x * op_x + 2 * op_y * op_y - op_2rr - 2 * op_x + 1) > 0)    // 使用逐点比较法实现画圆弧
                {
                    op_x--;
                    draw_x++;
                }
                if (draw_on == 1) GUI_Point(draw_x, draw_y, color);         // 开始画图
                pno_angle++;
                if ((pno_angle == stangle) || (pno_angle == endangle))          // 若遇到起点或终点，画点开关取反
                {
                    draw_on = 1 - draw_on;
                    if (draw_on == 1) GUI_Point(draw_x, draw_y, color);
                }
                if (op_y >= op_x)
                {
                    if (draw_on == 1) GUI_Point(draw_x, draw_y, color);
                    break;
                }
            }

            while (true)
            {  /* 计算下一点 */
                op_x--;
                draw_x++;
                if ((2 * op_x * op_x + 2 * op_y * op_y - op_2rr + 2 * op_y + 1) <= 0) // 使用逐点比较法实现画圆弧
                {
                    op_y++;
                    draw_y++;
                }
                if (draw_on == 1) GUI_Point(draw_x, draw_y, color);         // 开始画图
                pno_angle++;
                if ((pno_angle == stangle) || (pno_angle == endangle))          // 若遇到起点或终点，画点开关取反
                {
                    draw_on = 1 - draw_on;
                    if (draw_on == 1) GUI_Point(draw_x, draw_y, color);
                }

                if (op_x <= 0)
                {
                    if (draw_on == 1) GUI_Point(draw_x, draw_y, color);     // 开始画图
                    break;
                }
            }


            /* 开始顺时针画弧，从89度开始(第1像限) */
            draw_y = y + r;
            draw_x = x;
            op_y = r;
            op_x = 0;
            while (true)
            {  /* 计算下一点 */
                op_x++;
                draw_x++;
                if ((2 * op_x * op_x + 2 * op_y * op_y - op_2rr - 2 * op_y + 1) > 0) // 使用逐点比较法实现画圆弧
                {
                    op_y--;
                    draw_y--;
                }
                if (draw_on == 1) GUI_Point(draw_x, draw_y, color);         // 开始画图
                pno_angle++;
                if ((pno_angle == stangle) || (pno_angle == endangle))          // 若遇到起点或终点，画点开关取反
                {
                    draw_on = 1 - draw_on;
                    if (draw_on == 1) GUI_Point(draw_x, draw_y, color);
                }

                if (op_x >= op_y)
                {
                    if (draw_on == 1) GUI_Point(draw_x, draw_y, color);     // 开始画图
                    break;
                }
            }

            while (true)
            {  /* 计算下一点 */
                op_y--;
                draw_y--;
                if ((2 * op_x * op_x + 2 * op_y * op_y - op_2rr + 2 * op_x + 1) <= 0) // 使用逐点比较法实现画圆弧
                {
                    op_x++;
                    draw_x++;
                }
                if (draw_on == 1) GUI_Point(draw_x, draw_y, color);         // 开始画图
                pno_angle++;
                if ((pno_angle == stangle) || (pno_angle == endangle))          // 若遇到起点或终点，画点开关取反
                {
                    draw_on = 1 - draw_on;
                    if (draw_on == 1) GUI_Point(draw_x, draw_y, color);
                }
                if (op_y <= 0)
                {
                    if (draw_on == 1) GUI_Point(draw_x, draw_y, color);
                    break;
                }
            }

        }


        /// <summary>
        /// 指定起点、终点及半径扇形(不能画圆)。
        /// </summary>
        /// <param name="x">圆心的x轴坐标值</param>
        /// <param name="y">圆心的y轴坐标值</param>
        /// <param name="r">圆的半径终点</param>
        /// <param name="stangle">起始角度(0-359度)</param>
        /// <param name="endangle">终止角度(0-359度)</param>
        /// <param name="color">显示颜色</param>
        public static void GUI_Pieslice(uint32 x, uint32 y, uint32 r, uint32 stangle, uint32 endangle, TCOLOR color)
        {
            int32 draw_x, draw_y;                   // 画图坐标变量
            int32 op_x, op_y;                       // 操作坐标
            int32 op_2rr;                           // 2*r*r值变量
            int32 pno_angle;                        // 度角点的个数
            uint8 draw_on;                          // 画点开关，为1时画点，为0时不画
            stangle = 360 - stangle;
            endangle = 360 - endangle;
            /* 参数过滤 */
            if (r == 0) return;                         // 半径为0则直接退出
            if (stangle == endangle) return;            // 起始角度与终止角度相同，退出
            if ((stangle >= 360) || (endangle >= 360)) return;

            op_2rr = 2 * r * r;                         // 计算r平方乖以2
            pno_angle = 0;
            /* 先计算出在此半径下的45度的圆弧的点数 */
            op_x = r;
            op_y = 0;
            while (true)
            {
                pno_angle++;                            // 画点计数         
                                                        /* 计算下一点 */
                op_y++;
                if ((2 * op_x * op_x + 2 * op_y * op_y - op_2rr - 2 * op_x + 1) > 0)    // 使用逐点比较法实现画圆弧
                {
                    op_x--;
                }
                if (op_y >= op_x) break;
            }

            draw_on = 0;                                // 最开始关画点开关
                                                        /* 设置起始点及终点 */
            if (endangle > stangle) draw_on = 1;        // 若终点大于起点，则从一开始即画点(359)
            stangle = (360 - stangle) * pno_angle / 45;
            endangle = (360 - endangle) * pno_angle / 45;
            if (stangle == 0) stangle = 1;
            if (endangle == 0) endangle = 1;

            /* 开始顺时针画弧，从359度开始(第4像限) */
            pno_angle = 0;

            draw_x = x + r;
            draw_y = y;
            op_x = r;
            op_y = 0;
            while (true)
            {  /* 计算下一点 */
                op_y++;
                draw_y--;
                if ((2 * op_x * op_x + 2 * op_y * op_y - op_2rr - 2 * op_x + 1) > 0)    // 使用逐点比较法实现画圆弧
                {
                    op_x--;
                    draw_x--;
                }
                if (draw_on == 1) GUI_Point(draw_x, draw_y, color);         // 开始画图
                pno_angle++;
                if ((pno_angle == stangle) || (pno_angle == endangle))          // 若遇到起点或终点，画点开关取反
                {
                    draw_on = 1 - draw_on;
                    if (draw_on == 1) GUI_Point(draw_x, draw_y, color);
                    GUI_Line(x, y, draw_x, draw_y, color);
                }
                if (op_y >= op_x)
                {
                    if (draw_on == 1) GUI_Point(draw_x, draw_y, color);
                    break;
                }
            }

            while (true)
            {  /* 计算下一点 */
                op_x--;
                draw_x--;
                if ((2 * op_x * op_x + 2 * op_y * op_y - op_2rr + 2 * op_y + 1) <= 0) // 使用逐点比较法实现画圆弧
                {
                    op_y++;
                    draw_y--;
                }
                if (draw_on == 1) GUI_Point(draw_x, draw_y, color);         // 开始画图
                pno_angle++;
                if ((pno_angle == stangle) || (pno_angle == endangle))          // 若遇到起点或终点，画点开关取反
                {
                    draw_on = 1 - draw_on;
                    if (draw_on == 1) GUI_Point(draw_x, draw_y, color);
                    GUI_Line(x, y, draw_x, draw_y, color);
                }

                if (op_x <= 0)
                {
                    if (draw_on == 1) GUI_Point(draw_x, draw_y, color);     // 开始画图
                    break;
                }
            }


            /* 开始顺时针画弧，从269度开始(第3像限) */
            draw_y = y - r;
            draw_x = x;
            op_y = r;
            op_x = 0;
            while (true)
            {  /* 计算下一点 */
                op_x++;
                draw_x--;
                if ((2 * op_x * op_x + 2 * op_y * op_y - op_2rr - 2 * op_y + 1) > 0) // 使用逐点比较法实现画圆弧
                {
                    op_y--;
                    draw_y++;
                }
                if (draw_on == 1) GUI_Point(draw_x, draw_y, color);         // 开始画图
                pno_angle++;
                if ((pno_angle == stangle) || (pno_angle == endangle))          // 若遇到起点或终点，画点开关取反
                {
                    draw_on = 1 - draw_on;
                    if (draw_on == 1) GUI_Point(draw_x, draw_y, color);
                    GUI_Line(x, y, draw_x, draw_y, color);
                }

                if (op_x >= op_y)
                {
                    if (draw_on == 1) GUI_Point(draw_x, draw_y, color);     // 开始画图
                    break;
                }
            }

            while (true)
            {  /* 计算下一点 */
                op_y--;
                draw_y++;
                if ((2 * op_x * op_x + 2 * op_y * op_y - op_2rr + 2 * op_x + 1) <= 0) // 使用逐点比较法实现画圆弧
                {
                    op_x++;
                    draw_x--;
                }
                if (draw_on == 1) GUI_Point(draw_x, draw_y, color);         // 开始画图
                pno_angle++;
                if ((pno_angle == stangle) || (pno_angle == endangle))          // 若遇到起点或终点，画点开关取反
                {
                    draw_on = 1 - draw_on;
                    if (draw_on == 1) GUI_Point(draw_x, draw_y, color);
                    GUI_Line(x, y, draw_x, draw_y, color);
                }
                if (op_y <= 0)
                {
                    if (draw_on == 1) GUI_Point(draw_x, draw_y, color);
                    break;
                }
            }


            /* 开始顺时针画弧，从179度开始(第2像限) */
            draw_x = x - r;
            draw_y = y;
            op_x = r;
            op_y = 0;
            while (true)
            {  /* 计算下一点 */
                op_y++;
                draw_y++;
                if ((2 * op_x * op_x + 2 * op_y * op_y - op_2rr - 2 * op_x + 1) > 0)    // 使用逐点比较法实现画圆弧
                {
                    op_x--;
                    draw_x++;
                }
                if (draw_on == 1) GUI_Point(draw_x, draw_y, color);         // 开始画图
                pno_angle++;
                if ((pno_angle == stangle) || (pno_angle == endangle))          // 若遇到起点或终点，画点开关取反
                {
                    draw_on = 1 - draw_on;
                    if (draw_on == 1) GUI_Point(draw_x, draw_y, color);
                    GUI_Line(x, y, draw_x, draw_y, color);
                }
                if (op_y >= op_x)
                {
                    if (draw_on == 1) GUI_Point(draw_x, draw_y, color);
                    break;
                }
            }

            while (true)
            {  /* 计算下一点 */
                op_x--;
                draw_x++;
                if ((2 * op_x * op_x + 2 * op_y * op_y - op_2rr + 2 * op_y + 1) <= 0) // 使用逐点比较法实现画圆弧
                {
                    op_y++;
                    draw_y++;
                }
                if (draw_on == 1) GUI_Point(draw_x, draw_y, color);         // 开始画图
                pno_angle++;
                if ((pno_angle == stangle) || (pno_angle == endangle))          // 若遇到起点或终点，画点开关取反
                {
                    draw_on = 1 - draw_on;
                    if (draw_on == 1) GUI_Point(draw_x, draw_y, color);
                    GUI_Line(x, y, draw_x, draw_y, color);
                }

                if (op_x <= 0)
                {
                    if (draw_on == 1) GUI_Point(draw_x, draw_y, color);     // 开始画图
                    break;
                }
            }


            /* 开始顺时针画弧，从89度开始(第1像限) */
            draw_y = y + r;
            draw_x = x;
            op_y = r;
            op_x = 0;
            while (true)
            {  /* 计算下一点 */
                op_x++;
                draw_x++;
                if ((2 * op_x * op_x + 2 * op_y * op_y - op_2rr - 2 * op_y + 1) > 0) // 使用逐点比较法实现画圆弧
                {
                    op_y--;
                    draw_y--;
                }
                if (draw_on == 1) GUI_Point(draw_x, draw_y, color);         // 开始画图
                pno_angle++;
                if ((pno_angle == stangle) || (pno_angle == endangle))          // 若遇到起点或终点，画点开关取反
                {
                    draw_on = 1 - draw_on;
                    if (draw_on == 1) GUI_Point(draw_x, draw_y, color);
                    GUI_Line(x, y, draw_x, draw_y, color);
                }

                if (op_x >= op_y)
                {
                    if (draw_on == 1) GUI_Point(draw_x, draw_y, color);     // 开始画图
                    break;
                }
            }

            while (true)
            {  /* 计算下一点 */
                op_y--;
                draw_y--;
                if ((2 * op_x * op_x + 2 * op_y * op_y - op_2rr + 2 * op_x + 1) <= 0) // 使用逐点比较法实现画圆弧
                {
                    op_x++;
                    draw_x++;
                }
                if (draw_on == 1) GUI_Point(draw_x, draw_y, color);         // 开始画图
                pno_angle++;
                if ((pno_angle == stangle) || (pno_angle == endangle))          // 若遇到起点或终点，画点开关取反
                {
                    draw_on = 1 - draw_on;
                    if (draw_on == 1) GUI_Point(draw_x, draw_y, color);
                    GUI_Line(x, y, draw_x, draw_y, color);
                }
                if (op_y <= 0)
                {
                    if (draw_on == 1) GUI_Point(draw_x, draw_y, color);
                    break;
                }
            }
        }
        #endregion



        #region GUI_STOCKC.C   // 定义前景色及背景色变量，用于ASCII码、汉字、窗口、单色位图显示 
       public static  TCOLOR disp_color=true;
       public static TCOLOR back_color=false;
       private static readonly byte[] DCB2HEX_TAB = new byte[]
       {
           0x80, 0x40, 0x20, 0x10, 0x08, 0x04, 0x02, 0x01,
       };
        /// <summary>
        /// 颜色值复制。
        /// </summary>
        /// <param name="bakc">目标颜色变量</param>
        /// <param name="back_color">源颜色变量</param>
        private static  void GUI_CopyColor(out bool color1, bool color2)
        {
            color1 = color2;
        }

        /// <summary>
        /// 设置显示色及背景色。用于ASCII字符显示及汉字显示。
        /// </summary>
        /// <param name="color1">color1	显示色的值</param>
        /// <param name="color2">color2	背景色的值</param>
        private static void GUI_SetColor(TCOLOR color1, TCOLOR color2)
        {
            GUI_CopyColor(out disp_color, color1);
            GUI_CopyColor(out back_color, color2);
        }


        /// <summary>
        /// 最得当前背景色。
        /// </summary>
        /// <param name="bakc">bakc	保存颜色的变量地址</param>
        private static void GUI_GetBackColor(out TCOLOR bakc)
        {
            GUI_CopyColor(out bakc, back_color);
        }

        /// <summary>
        /// 最得当前前景色。
        /// </summary>
        /// <param name="bakc">保存颜色的变量地址</param>
        private static void GUI_GetDispColor(out TCOLOR bakc)
        {
            GUI_CopyColor(out bakc, disp_color);
        }

        /// <summary>
        ///交换前景色与背景色。用于反相显示。 
        /// </summary>
        public static void GUI_ExchangeColor()
        {
            TCOLOR bakc;

            GUI_CopyColor(out bakc, disp_color);
            GUI_CopyColor(out disp_color, back_color);
            GUI_CopyColor(out back_color, bakc);
        }

        #endregion


        #region  FONT5_7.C
        /// <summary>
        ///显示ASCII码，显示值为20H-7FH(若为其它值，则显示' ')。 
        /// </summary>
        /// <param name="x">指定显示位置，x坐标</param>
        /// <param name="y">指定显示位置，y坐标</param>
        /// <param name="ch">要显示的ASCII码值。</param>
        /// <returns></returns>
        public static uint8 GUI_PutChar5_7(uint32 x, uint32 y, uint8 ch)
        {
            uint8 font_dat;
            uint8 i, j;
            TCOLOR bakc;
            /* 参数过滤 */
            if (x >= (GUI_LCM_XMAX - 8)) return (0);
            if (y >= (GUI_LCM_YMAX - 8)) return (0);
            if ((ch < 0x20) || (ch > 0x7f)) ch = 0x20;

            ch -= 0x20;
            for (i = 0; i < 8; i++)
            {  /* 读取点阵数据 */
                font_dat = FONT5x7ASCII[ch, i];

                for (j = 0; j < 6; j++)
                {  /* 设置相应的点为color或为back_color */
                    if ((font_dat & DCB2HEX_TAB[j]) == 0) GUI_CopyColor(out bakc, back_color);
                    else GUI_CopyColor(out bakc, disp_color);
                    GUI_Point(x, y, bakc);
                    x++;
                }

                y++;                                    // 指向下一行
                x -= 6;                             // 恢复x值
            }

            return (1);
        }


        /// <summary>
        ///输出显示字符串(没有自动换行功能)。 
        /// </summary>
        /// <param name="x">指定显示位置，x坐标</param>
        /// <param name="y">指定显示位置，y坐标</param>
        /// <param name="str">要显示的ASCII码字符串</param>
        public static void GUI_PutString5_7(uint32 x, uint32 y, string str)
        {
            Int32 str_pos = 0;
            while (true)
            {
                if (str_pos < str.Length)
                {
                    if ((str[str_pos]) == '\0') break;
                    if (GUI_PutChar5_7(x, y, str[str_pos++]) == 0) break;
                    // 下一个字符显示位置，y不变(即不换行)
                     x += 6;
                }
                else break;
            }
        }


        /// <summary>
        /// 输出显示字符串(没有自动换行功能)，若显示的字符个数大于指定个数，则直接退出。
        /// </summary>
        /// <param name="x">指定显示位置，x坐标</param>
        /// <param name="y">指定显示位置，y坐标</param>
        /// <param name="str">要显示的ASCII码字符串。</param>
        /// <param name="no">最大显示字符的个数</param>
        public static void GUI_PutNoStr5_7(uint32 x, uint32 y, string str, uint8 no)
        {
            Int32 str_pos = 0;
            if (no == 0) return;
            for (; no > 0; no--)
            {
                if (str_pos < str.Length)
                {
                    if ((str[str_pos]) == '\0') break;
                    if (GUI_PutChar5_7(x, y, str[str_pos++]) == 0) break;
                    // 下一个字符显示位置，y不变(即不换行)
                    x += 6;
                }
                else break;
            }
        }










        #endregion


        #region  FONT8_8.C

        /// <summary>
        /// 
        /// </summary>
        /// <param name="x">显示ASCII码(8*8字体)，显示值为20H-7FH(若为其它值，则显示' ')。</param>
        /// <param name="y">指定显示位置，x坐标</param>
        /// <param name="ch">指定显示位置，y坐标</param>
        /// <returns>返回值为1时表示操作成功，为0时表示操作失败。</returns>
        public static uint8 GUI_PutChar8_8(uint32 x, uint32 y, uint8 ch)
        {
            uint8 font_dat;
            uint8 i, j;
            TCOLOR bakc;

            /* 参数过滤 */
            if (x > (GUI_LCM_XMAX - 8)) return (0);
            if (y > (GUI_LCM_YMAX - 8)) return (0);
            if ((ch < 0x20) || (ch > 0x7f)) ch = 0x20;

            ch -= 0x20;
            for (i = 0; i < 8; i++)
            {  /* 读取点阵数据 */
                font_dat = FONT8x8ASCII[ch,i];

                for (j = 0; j < 8; j++)
                {  /* 设置相应的点为color或为back_color */
                    if ((font_dat & DCB2HEX_TAB[j]) == 0) GUI_CopyColor(out bakc, back_color);
                    else GUI_CopyColor(out bakc, disp_color);
                    GUI_Point(x, y, bakc);
                    x++;
                }

                y++;                                    // 指向下一行
                x -= 8;                             // 恢复x值
            }

            return (1);
        }

        /// <summary>
        /// 输出显示字符串((8*8字体，没有自动换行功能)。
        /// </summary>
        /// <param name="x">指定显示位置，x坐标</param>
        /// <param name="y">指定显示位置，y坐标</param>
        /// <param name="str">要显示的ASCII码字符串</param>
        public static void GUI_PutString8_8(uint32 x, uint32 y, string str)
        {
            Int32 str_pos = 0;
            while (true)
            {
                if (str_pos < str.Length)
                {
                    if ((str[str_pos]) == '\0') break;
                    if (GUI_PutChar8_8(x, y, str[str_pos++]) == 0) break;
                    // 下一个字符显示位置，y不变(即不换行)
                    x += 8;
                }
                else break;
            }
        }
        #endregion


        #region  FONT8_16.C

        /// <summary>
        /// 
        /// </summary>
        /// <param name="x">显示ASCII码(8*8字体)，显示值为20H-7FH(若为其它值，则显示' ')。</param>
        /// <param name="y">指定显示位置，x坐标</param>
        /// <param name="ch">指定显示位置，y坐标</param>
        /// <returns>返回值为1时表示操作成功，为0时表示操作失败。</returns>
        public static uint8 GUI_PutChar8_16(uint32 x, uint32 y, uint8 ch)
        {
            uint8 font_dat;
            uint8 i, j;
            TCOLOR bakc;

            /* 参数过滤 */
            if (x > (GUI_LCM_XMAX - 16)) return (0);
            if (y > (GUI_LCM_YMAX - 16)) return (0);
            if ((ch < 0x20) || (ch > 0x7f)) ch = 0x20;
            ch -= 0x20;
            for (i = 0; i < 16; i++)
            {  /* 读取点阵数据 */
                font_dat = FONT8x16ASCII[ch, i];

                for (j = 0; j < 8; j++)
                {  /* 设置相应的点为color或为back_color */
                    if ((font_dat & DCB2HEX_TAB[j]) == 0) GUI_CopyColor(out bakc, back_color);
                    else GUI_CopyColor(out bakc, disp_color);
                    GUI_Point(x, y, bakc);
                    x++;
                }

                y++;                                    // 指向下一行
                x -= 8;                             // 恢复x值
            }

            return (1);
        }

        /// <summary>
        /// 输出显示字符串((8*16字体，没有自动换行功能)。
        /// </summary>
        /// <param name="x">指定显示位置，x坐标</param>
        /// <param name="y">指定显示位置，y坐标</param>
        /// <param name="str">要显示的ASCII码字符串</param>
        public static void GUI_PutString8_16(uint32 x, uint32 y, string str)
        {
            Int32 str_pos = 0;
            while (true)
            {
                if (str_pos < str.Length)
                {
                    if ((str[str_pos]) == '\0') break;
                    if (GUI_PutChar8_16(x, y, str[str_pos++]) == 0) break;
                    // 下一个字符显示位置，y不变(即不换行)
                    x += 8;
                }
                else break;
            }
        }
        #endregion
        #region  FONT24_32.C
        /// <summary>
        /// 显示ASCII码(24*32字体)，显示值为'0'-'9'、'.'、'+'、'-'及':'(若为其它值，则显示' ')。
        /// </summary>
        /// <param name="x">指定显示位置，x坐标</param>
        /// <param name="y">指定显示位置，y坐标</param>
        /// <param name="ch">要显示的ASCII码值。</param>
        /// <returns>返回值为1时表示操作成功，为0时表示操作失败。</returns>
       /* ASCII码字符字模检索表 */
        public static string FONT24x32_TAB = "0123456789.+-: ";
        public static uint8 GUI_PutChar24_32(uint32 x, uint32 y, uint8 ch)
        {
            uint8 font_dat;
            uint8 i, j, k;
            TCOLOR bakc;
            /* 参数过滤 */
            if (x > (GUI_LCM_XMAX - 32)) return (0);
            if (y > (GUI_LCM_YMAX - 32)) return (0);
            for (i = 0; i < 14; i++)
            {
                if (FONT24x32_TAB[i] == ch) break;
            }
            ch = i;

            for (i = 0; i < 32; i++)      // 显示共32行
            {
                for (j = 0; j < 3; j++)     // 每行共3字节 
                {
                    font_dat = FONT24x32[ch,i * 3 + j];
                    /* 设置相应的点为color或为back_color */
                    for (k = 0; k < 8; k++)
                    {
                        if ((font_dat & DCB2HEX_TAB[k]) == 0)
                            GUI_CopyColor(out bakc, back_color);
                        else
                            GUI_CopyColor(out bakc, disp_color);
                        GUI_Point(x, y, bakc);
                        x++;
                    }
                }
                y++;
                // 指向下一行
                x -= 24;
                // 恢复x值
            }

            return (1);
        }
        #endregion



        #region LOADBIT.C
       
        /// <summary>
        /// 输出单色图形的一行数据。
        /// </summary>
        /// <param name="x">指定显示位置，x坐标</param>
        /// <param name="y">指定显示位置，y坐标</param>
        /// <param name="dat">要输出显示的数据。</param>
        /// <param name="no">要显示此行的点个数</param>
        /// <returns></returns>
        public static uint8 GUI_LoadLine(uint32 x, uint32 y, Byte[]  dat, uint32 no)
        {
            uint8 bit_dat = 0;
            uint8 i;
            TCOLOR bakc;
            uint8 dat_pos=0;
            /* 参数过滤 */
            if (x >= GUI_LCM_XMAX) return (0);
            if (y >= GUI_LCM_YMAX) return (0);

            for (i = 0; i < no; i++)
            {  /* 判断是否要读取点阵数据 */
                if ((i % 8) == 0 && dat_pos< dat.Length) bit_dat = dat[dat_pos++];

                /* 设置相应的点为color或为back_color */
                if ((bit_dat & DCB2HEX_TAB[i & 0x07]) == 0) GUI_CopyColor(out bakc, back_color);
                else GUI_CopyColor(out bakc, disp_color);
                GUI_Point(x, y, bakc);

                if ((++x) >= GUI_LCM_XMAX) return (0);
            }

            return (1);
        }




        /// <summary>
        /// 删除数组左边的index个元素，然后左移
        /// </summary>
        /// <typeparam name="T">数组类型</typeparam>
        /// <param name="arr">数组名</param>
        /// <param name="index">删除个数</param>
        public static void DeleteInArray<T>(ref T[] arr, int index)
        {
            if (arr == null)
                throw new ArgumentNullException("arr");
            if (index < 0 || (arr.Length - 1) < index)
                throw new IndexOutOfRangeException();
            for (int i = 0; i < arr.Length - index; i++)
            {
                arr[i] = arr[i + index];
            }
            arr = arr.Take<T>(arr.Length - index).ToArray<T>();
        }

        /// <summary>
        /// 输出单色图形数据。
        /// </summary>
        /// <param name="x">指定显示位置，x坐标</param>
        /// <param name="y">指定显示位置，y坐标</param>
        /// <param name="dat">要输出显示的数据</param>
        /// <param name="hno">要显示此行的点个数</param>
        /// <param name="lno">要显示此列的点个数</param>
        public static void GUI_LoadPic(uint32 x, uint32 y, Byte[] dat, uint32 hno, uint32 lno)
        {
            uint32 i;
            byte[] dat1 = new byte[dat.Length];//默认值为0; 
            dat.CopyTo(dat1, 0);
            for (i = 0; i < lno; i++)
            {
                GUI_LoadLine(x, y, dat1, hno);               // 输出一行数据
                y++;                                        // 显示下一行
                //dat += (hno >> 3);                          // 计算下一行的数据
                if (dat1.Length > hno >> 3) DeleteInArray(ref dat1, hno >> 3);
                if ((hno & 0x07) != 0 && dat1.Length>1) DeleteInArray(ref dat1, 1);
            }
        }



        /// <summary>
        /// 输出单色图形数据，反相显示。
        /// </summary>
        /// <param name="x">指定显示位置，x坐标</param>
        /// <param name="y">指定显示位置，y坐标</param>
        /// <param name="dat">要输出显示的数据。</param>
        /// <param name="hno">要显示此行的点个数</param>
        /// <param name="lno">要显示此列的点个数</param>
        public static void GUI_LoadPic1(uint32 x, uint32 y, Byte[] dat, uint32 hno, uint32 lno)
        {
            GUI_ExchangeColor();                                    // 显示色与背景色交换
            GUI_LoadPic(x, y, dat, hno, lno);
            GUI_ExchangeColor();

        }
        /// <summary>
        /// 显示汉字。
        /// </summary>
        /// <param name="x">指定显示位置，x坐标</param>
        /// <param name="y">指定显示位置，y坐标</param>
        /// <param name="dat">要输出显示的汉字点阵数据</param>
        /// <param name="hno">要显示此行的点个数</param>
        /// <param name="lno">要显示此列的点个数</param>
        public static void GUI_PutHZ(uint32 x, uint32 y, Byte[] dat, uint8 hno, uint8 lno)
        {
            GUI_LoadPic(x, y, dat, hno, lno);
        }
        #endregion



        #region WINDOW.C

        /// <summary>
        ///显示窗口。根据提供的窗口参数进行画窗口。 
        /// </summary>
        /// <param name="win">窗口句柄</param>
        /// <returns>返回0表示操作失败，返回1表示操作成功</returns>
        public static uint8 GUI_WindowsDraw(ref WINDOWS win)
        {
            string str;
            int32 str_pos = 0;
            int32 bak, bak1, bak2;
            /* 参数过滤，若窗口起出范围，则返回0 */
            if (((win.with) < 20) || ((win.hight) < 20)) return (0);      // 宽度、高度检查，限制最小窗口
            if ((win.x + win.with) > GUI_LCM_XMAX) return (0);            // 窗口宽度是否溢出
            if ((win.y + win.hight) > GUI_LCM_YMAX) return (0);           // 窗口高度是否溢出
            /* 开始画窗口 */
            GUI_RectangleFill(win.x, win.y, win.x + win.with - 1, win.y + win.hight - 1, back_color);
            GUI_Rectangle(win.x, win.y, win.x + win.with - 1, win.y + win.hight - 1, disp_color); // 画窗口
            GUI_HLine(win.x, win.y + 12, win.x + win.with - 1, disp_color);                         // 画标题目栏
            GUI_RLine(win.x + 12, win.y, win.y + 12, disp_color);                                        // 画关闭窗号按钮
            GUI_Line(win.x, win.y, win.x + 12, win.y + 12, disp_color);
            GUI_Line(win.x + 12, win.y, win.x, win.y + 12, disp_color);
            /* 写标题 */
            if (win.title != null)
            {
                str_pos = 0;
                str = win.title;
                bak = win.x + 15;
                bak1 = win.y + 3;
                bak2 = win.x + win.with - 1;


                while (true)
                {
                    if ((bak + 8) > bak2) break;                                // 判断标题是否溢出
                    if (str_pos < str.Length)
                    {
                        if ((str[str_pos]) == '\0') break;                                        // 判断字符串是否结束
                        GUI_PutChar5_7(bak, bak1, str[str_pos++]);                         // 显示标题
                        bak += 6;
                    }
                    else break;
                  }
            }

            /* 写状态栏 */
            if (win.state != null)
            {
                if (win.hight < 60) return (0);                                // 判断是否可以画状态栏
                                                                                /* 画状态栏 */
                GUI_HLine(win.x, win.y + win.hight - 11, win.x + win.with - 1, disp_color);
                str_pos = 0;
                str = win.state;
                bak = win.x + 3;
                bak1 = win.y + win.hight - 9;
                bak2 = win.x + win.with - 1;

                while (true)
                {
                    if ((bak + 8) > bak2) break;                                // 判断标题是否溢出
                    if (str_pos < str.Length)
                    {
                        if ((str[str_pos]) == '\0') break;                                        // 判断字符串是否结束
                        GUI_PutChar5_7(bak, bak1, str[str_pos++]);                         // 显示标题
                        bak += 6;
                    }
                    else break;
                }
            }

            return (1);

        }

        /// <summary>
        ///消隐窗口。 
        /// </summary>
        /// <param name="win">窗口句柄</param>
        /// <returns>返回0表示操作失败，返回1表示操作成功</returns>
        public static uint8 GUI_WindowsHide(ref WINDOWS win)
        {  /* 参数过滤，若窗口起出范围，则返回0 */
            if (((win.with) < 20) || ((win.hight) < 20)) return (0);      // 宽度、高度检查，限制最小窗口
            if ((win.x + win.with) > GUI_LCM_XMAX) return (0);            // 窗口宽度是否溢出
            if ((win.y + win.hight) > GUI_LCM_YMAX) return (0);           // 窗口高度是否溢出

            /* 消隐窗口 */
            GUI_RectangleFill(win.x, win.y, win.x + win.with - 1, win.y + win.hight - 1, back_color);
            return (1);
        }

        /// <summary>
        /// 清屏窗口,使用此函数前要先使用GUI_WindowsDraw()将窗口画出。。
        /// </summary>
        /// <param name="win">窗口句柄</param>
        public static void GUI_WindowsClr(ref WINDOWS win)
        {
            uint8 x0, y0;
            uint8 x1, y1;

            /* 设置要清屏的区域 */
            x0 = win.x + 1;
            x1 = win.x + win.with - 2;
            y0 = win.y + 13;
            y1 = win.y + win.hight - 2;
            if (win.state != null)         // 判断是否有状态栏				
            {
                if (win.hight >= 60)
                {
                    y1 = win.y + win.hight - 12;
                }
            }
            /* 使用填充矩形实现清屏 */
            GUI_RectangleFill(x0, y0, x1, y1, back_color);
        }
        #endregion


        #region    MENU.C

        /* 定义主菜单宽度，及最大菜单个数 */
        public static readonly int MMENU_WIDTH = 32;
        public static readonly int MMENU_NO = 5;
        /* 定义菜单的宽度(下拉菜单)，及最大子菜单个数 */
        public static readonly int SMENU_WIDTH = 66;
        public static readonly int SMENU_NO = 8;


      
        /// <summary>
        ///显示主菜单，加上边框。 
        /// </summary>
        /// <param name="men">主菜单句柄</param>
        /// <returns></returns>
        public static uint8 GUI_MMenuDraw(ref MMENU men)
        {
            WINDOWS  mwin;
            uint8 i;
            uint8 xx;

            /* 参数过滤 */
            if ((men.no) == 0) return (0);

            mwin = men.win;                        // 取得窗口句柄
                                                    /* 判断是否可以显示主菜单 */
            if ((mwin.hight) < 50) return (0);
            if ((mwin.with) < 50) return (0);

            /* 画菜单条，并显示菜主单 */
            GUI_HLine(mwin.x, mwin.y + 22, mwin.x + mwin.with - 1, disp_color);

            xx = mwin.x;
            for (i = 0; i < (men.no); i++)
            {
                if ((xx + MMENU_WIDTH) > (mwin.x + mwin.with)) return (0);

                GUI_PutNoStr5_7(xx + 2, mwin.y + 14, men.str, 4);         // 书写主菜单文字
                xx += MMENU_WIDTH;
                GUI_RLine(xx, mwin.y + 12, mwin.y + 22, disp_color);  // 显示主菜单分界线      
            }

            return (1);
        }


        /// <summary>
        /// 当前主菜单，加下划线，表示当前主菜单。
        /// </summary>
        /// <param name="men">主菜单句柄</param>
        /// <param name="no">所选的主菜单项</param>
        public static void GUI_MMenuSelect(MMENU men, uint8 no)
        {
            WINDOWS mwin;
            uint8 xx;

            /* 参数过滤 */
            if ((men.no) == 0) return;
            if (no > (men.no)) return;

            mwin = men.win;                        // 取得窗口句柄
                                                    /* 判断是否可以显示主菜单 */
            if ((mwin.hight) < 50) return;
            if ((mwin.with) < 50) return;

            /* 显示下划线 */
            xx = mwin.x + no * MMENU_WIDTH;
            GUI_HLine(xx + 1, mwin.y + 22 - 1, xx + MMENU_WIDTH - 1, disp_color);
        }

        /// <summary>
        ///取消当前主菜单，去除下划线。 
        /// </summary>
        /// <param name="men">主菜单句柄</param>
        /// <param name="no">所选的主菜单项</param>
        public static void GUI_MMenuNSelect(MMENU men, uint8 no)
        {
            WINDOWS mwin;
            uint8 xx;

            /* 参数过滤 */
            if ((men.no) == 0) return;
            if (no > (men.no)) return;

            mwin = men.win;                        // 取得窗口句柄
                                                    /* 判断是否可以显示主菜单 */
            if ((mwin.hight) < 50) return;
            if ((mwin.with) < 50) return;

            /* 显示下划线 */
            xx = mwin.x + no * MMENU_WIDTH;
            GUI_HLine(xx + 1, mwin.y + 22 - 1, xx + MMENU_WIDTH - 1, back_color);
        }


    
        /// <summary>
        /// 消隐子菜单项。
        /// </summary>
        /// <param name="men">子菜单句柄</param>
        /// <returns>返回0表示操作失败，返回1表示操作成功</returns>
        public static uint8 GUI_SMenuHide(SMENU men)
        {
            WINDOWS mwin;
            uint8 xx, yy;

            mwin = men.win;
            /* 判断是否可以显示主菜单 */
            if ((mwin.hight) < 50) return (0);
            if ((mwin.with) < 50) return (0);

            /* 画菜子单项。下拉子菜单，以向左下拉为原则，若右边溢出则以右下拉显示 */
            xx = mwin.x;
            xx += (men.mmenu_no) * MMENU_WIDTH;
            yy = mwin.y + 22;
            yy += (men.no) * 11 + 2;
            if ((xx + SMENU_WIDTH) <= (mwin.x + mwin.with - 1))
            {  /* 以左下拉为原则显示子菜单 */
                if ((men.mmenu_no) == 0)
                {
                    GUI_RectangleFill(xx + 1, mwin.y + 22 + 1, xx + SMENU_WIDTH, yy, back_color);
                }
                else
                {
                    GUI_RectangleFill(xx, mwin.y + 22 + 1, xx + SMENU_WIDTH, yy, back_color);
                }
                GUI_HLine(xx + 1, mwin.y + 22, xx + MMENU_WIDTH - 1, disp_color);
            }
            else
            {  /* 以右下拉为原则 */
                if ((xx + MMENU_WIDTH) == (mwin.x + mwin.with - 1))
                {
                    GUI_RectangleFill(xx - (SMENU_WIDTH - MMENU_WIDTH), mwin.y + 22 + 1, xx + MMENU_WIDTH - 1, yy, back_color);
                }
                else
                {
                    GUI_RectangleFill(xx - (SMENU_WIDTH - MMENU_WIDTH), mwin.y + 22 + 1, xx + MMENU_WIDTH, yy, back_color);
                }
                GUI_HLine(xx + 1, mwin.y + 22, xx + MMENU_WIDTH - 1, disp_color);
            }

            return (1);
        }



        /// <summary>
        ///显示49*14按钮 
        /// </summary>
        /// <param name="x">指定显示位置，x坐标</param>
        /// <param name="y">指定显示位置，y坐标</param>
        /// <param name="dat">显示的数据地址</param>
        public static void GUI_Button49x14(uint32 x, uint32 y, Byte[] dat)
        {
            GUI_LoadPic(x, y, dat, 49, 14);
        }


        /// <summary>
        ///显示49*14按钮"OK" 
        /// </summary>
        /// <param name="x">指定显示位置，x坐标</param>
        /// <param name="y">指定显示位置，y坐标</param>
        public static void GUI_Button_OK(uint32 x, uint32 y)
        {
            GUI_LoadPic(x, y, button_ok, 49, 14);
        }

        /// <summary>
        ///显示49*14按钮，选择状态的"OK"。 
        /// </summary>
        /// <param name="x">指定显示位置，x坐标</param>
        /// <param name="y">指定显示位置，y坐标</param>
        public static void GUI_Button_OK1(uint32 x, uint32 y)
        {
            GUI_LoadPic(x, y, button_ok1, 49, 14);
        }

        /// <summary>
        ///显示49*14按钮"Cancle"。 
        /// </summary>
        /// <param name="x">指定显示位置，x坐标</param>
        /// <param name="y">指定显示位置，y坐标</param>
        public static  void GUI_Button_Cancle(uint32 x, uint32 y)
        {
            GUI_LoadPic(x, y, button_cancle, 49, 14);
        }


        /// <summary>
        /// 显示49*14按钮，选择状态的"Cancle"
        /// </summary>
        /// <param name="x">指定显示位置，x坐标</param>
        /// <param name="y">指定显示位置，x坐标</param>
        public static void GUI_Button_Cancle1(uint32 x, uint32 y)
        {
            GUI_LoadPic(x, y, button_cancle1, 49, 14);
        }


        /// <summary>
        /// 显示图标菜单。
        /// </summary>
        /// <param name="ico">图标菜单句柄</param>
        /// <returns>返回0表示操作失败，返回1表示操作成功</returns>
        public static  uint8 GUI_MenuIcoDraw(ref MENUICO ico)
        {
            /* 参数过滤 */
            if (((ico.x) < 5) || ((ico.x) > (GUI_LCM_XMAX - 37))) return (0); // 显示起始地址判断
            if (((ico.icodat) == null) || ((ico.title) == null)) return (0);  // 显示数据内容判断

            GUI_LoadPic(ico.x, ico.y, ico.icodat, 32, 32);           // 显示ICO图
            GUI_HLine(ico.x - 5, ico.y + 32, ico.x + 37, back_color);                // 显示一空行
            if ((ico.state) == 0)
            {
                GUI_LoadPic(ico.x - 5, ico.y + 33, ico.title, 42, 13);
            }
            else
            {
                GUI_LoadPic1(ico.x - 5, ico.y + 33, ico.title, 42, 13);
            }
            return (1);
        }

        #endregion















    }


}

