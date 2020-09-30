using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ming_LCD
{
    class ZLG_GUI_Arg
    {
        public byte Command { get; set; }
        public byte x0 { get; set; }
        public byte y0 { get; set; }
        public byte x1 { get; set; }
        public byte y1 { get; set; }

        public byte r { get; set; }
        public byte color { get; set; }

        public byte with { get; set; }

        public byte picdat { get; set; }

        public byte check
        {
            get
            {
                return (byte)((UInt16)Command ^ ((UInt16)x0 ^ (UInt16)y0 ^ (UInt16)x1 ^ (UInt16)y1 ^ (UInt16)r ^ (UInt16)color ^ (UInt16)with ^ (UInt16)picdat));
            }
        }

        public void Clear()
        {
            this.Command = 0;
            this.x0 = 0;
            this.y0 = 0;
            this.x1 = 0;
            this.y1 = 0;
            this.r = 0;
            this.color = 0;
            this.with = 0;
            this.picdat = 0;

        }

    }
}
