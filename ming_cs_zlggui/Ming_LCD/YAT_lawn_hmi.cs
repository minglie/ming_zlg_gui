using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ming_LCD
{
    public static   class YAT_lawn_hmi
    {

        /// <summary>
        /// 画欢迎界面
        /// </summary>
        public static void Draw_welcome()
        {
            ZLG_GUI.GUI_PutChar24_32(100, 100, '8');
        }

        public static void Draw_swk()
        {
            ZLG_GUI.GUI_LoadPic(0, 0, YAT_lawn_pic.pic_swk_240_144, 240,160);
        }
        public static void Draw_meinv()
        {
            ZLG_GUI.GUI_LoadPic(0, 0, YAT_lawn_pic.pic_meinv_152_160, 152, 160);
        }

        public static void Draw_zxc()
        {
            ZLG_GUI.GUI_LoadPic(0, 0, YAT_lawn_pic.pic_zxc_160_160, 160, 160);
        }



    }

}
