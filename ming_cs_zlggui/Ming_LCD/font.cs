using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ming_LCD
{
    public partial class ZLG_GUI
    {
        #region FONT_MACRO.H
        public static byte ________ = 0x00;
        public static byte _______X = 0x01;
        public static byte ______X_ = 0x02;
        public static byte ______XX = 0x03;
        public static byte _____X__ = 0x04;
        public static byte _____X_X = 0x05;
        public static byte _____XX_ = 0x06;
        public static byte _____XXX = 0x07;
        public static byte ____X___ = 0x08;
        public static byte ____X__X = 0x09;
        public static byte ____X_X_ = 0x0a;
        public static byte ____X_XX = 0x0b;
        public static byte ____XX__ = 0x0c;
        public static byte ____XX_X = 0x0d;
        public static byte ____XXX_ = 0x0e;
        public static byte ____XXXX = 0x0f;
        public static byte ___X____ = 0x10;
        public static byte ___X___X = 0x11;
        public static byte ___X__X_ = 0x12;
        public static byte ___X__XX = 0x13;
        public static byte ___X_X__ = 0x14;
        public static byte ___X_X_X = 0x15;
        public static byte ___X_XX_ = 0x16;
        public static byte ___X_XXX = 0x17;
        public static byte ___XX___ = 0x18;
        public static byte ___XX__X = 0x19;
        public static byte ___XX_X_ = 0x1a;
        public static byte ___XX_XX = 0x1b;
        public static byte ___XXX__ = 0x1c;
        public static byte ___XXX_X = 0x1d;
        public static byte ___XXXX_ = 0x1e;
        public static byte ___XXXXX = 0x1f;
        public static byte __X_____ = 0x20;
        public static byte __X____X = 0x21;
        public static byte __X___X_ = 0x22;
        public static byte __X___XX = 0x23;
        public static byte __X__X__ = 0x24;
        public static byte __X__X_X = 0x25;
        public static byte __X__XX_ = 0x26;
        public static byte __X__XXX = 0x27;
        public static byte __X_X___ = 0x28;
        public static byte __X_X__X = 0x29;
        public static byte __X_X_X_ = 0x2a;
        public static byte __X_X_XX = 0x2b;
        public static byte __X_XX__ = 0x2c;
        public static byte __X_XX_X = 0x2d;
        public static byte __X_XXX_ = 0x2e;
        public static byte __X_XXXX = 0x2f;
        public static byte __XX____ = 0x30;
        public static byte __XX___X = 0x31;
        public static byte __XX__X_ = 0x32;
        public static byte __XX__XX = 0x33;
        public static byte __XX_X__ = 0x34;
        public static byte __XX_X_X = 0x35;
        public static byte __XX_XX_ = 0x36;
        public static byte __XX_XXX = 0x37;
        public static byte __XXX___ = 0x38;
        public static byte __XXX__X = 0x39;
        public static byte __XXX_X_ = 0x3a;
        public static byte __XXX_XX = 0x3b;
        public static byte __XXXX__ = 0x3c;
        public static byte __XXXX_X = 0x3d;
        public static byte __XXXXX_ = 0x3e;
        public static byte __XXXXXX = 0x3f;
        public static byte _X______ = 0x40;
        public static byte _X_____X = 0x41;
        public static byte _X____X_ = 0x42;
        public static byte _X____XX = 0x43;
        public static byte _X___X__ = 0x44;
        public static byte _X___X_X = 0x45;
        public static byte _X___XX_ = 0x46;
        public static byte _X___XXX = 0x47;
        public static byte _X__X___ = 0x48;
        public static byte _X__X__X = 0x49;
        public static byte _X__X_X_ = 0x4a;
        public static byte _X__X_XX = 0x4b;
        public static byte _X__XX__ = 0x4c;
        public static byte _X__XX_X = 0x4d;
        public static byte _X__XXX_ = 0x4e;
        public static byte _X__XXXX = 0x4f;
        public static byte _X_X____ = 0x50;
        public static byte _X_X___X = 0x51;
        public static byte _X_X__X_ = 0x52;
        public static byte _X_X__XX = 0x53;
        public static byte _X_X_X__ = 0x54;
        public static byte _X_X_X_X = 0x55;
        public static byte _X_X_XX_ = 0x56;
        public static byte _X_X_XXX = 0x57;
        public static byte _X_XX___ = 0x58;
        public static byte _X_XX__X = 0x59;
        public static byte _X_XX_X_ = 0x5a;
        public static byte _X_XX_XX = 0x5b;
        public static byte _X_XXX__ = 0x5c;
        public static byte _X_XXX_X = 0x5d;
        public static byte _X_XXXX_ = 0x5e;
        public static byte _X_XXXXX = 0x5f;
        public static byte _XX_____ = 0x60;
        public static byte _XX____X = 0x61;
        public static byte _XX___X_ = 0x62;
        public static byte _XX___XX = 0x63;
        public static byte _XX__X__ = 0x64;
        public static byte _XX__X_X = 0x65;
        public static byte _XX__XX_ = 0x66;
        public static byte _XX__XXX = 0x67;
        public static byte _XX_X___ = 0x68;
        public static byte _XX_X__X = 0x69;
        public static byte _XX_X_X_ = 0x6a;
        public static byte _XX_X_XX = 0x6b;
        public static byte _XX_XX__ = 0x6c;
        public static byte _XX_XX_X = 0x6d;
        public static byte _XX_XXX_ = 0x6e;
        public static byte _XX_XXXX = 0x6f;
        public static byte _XXX____ = 0x70;
        public static byte _XXX___X = 0x71;
        public static byte _XXX__X_ = 0x72;
        public static byte _XXX__XX = 0x73;
        public static byte _XXX_X__ = 0x74;
        public static byte _XXX_X_X = 0x75;
        public static byte _XXX_XX_ = 0x76;
        public static byte _XXX_XXX = 0x77;
        public static byte _XXXX___ = 0x78;
        public static byte _XXXX__X = 0x79;
        public static byte _XXXX_X_ = 0x7a;
        public static byte _XXXX_XX = 0x7b;
        public static byte _XXXXX__ = 0x7c;
        public static byte _XXXXX_X = 0x7d;
        public static byte _XXXXXX_ = 0x7e;
        public static byte _XXXXXXX = 0x7f;
        public static byte X_______ = 0x80;
        public static byte X______X = 0x81;
        public static byte X_____X_ = 0x82;
        public static byte X_____XX = 0x83;
        public static byte X____X__ = 0x84;
        public static byte X____X_X = 0x85;
        public static byte X____XX_ = 0x86;
        public static byte X____XXX = 0x87;
        public static byte X___X___ = 0x88;
        public static byte X___X__X = 0x89;
        public static byte X___X_X_ = 0x8a;
        public static byte X___X_XX = 0x8b;
        public static byte X___XX__ = 0x8c;
        public static byte X___XX_X = 0x8d;
        public static byte X___XXX_ = 0x8e;
        public static byte X___XXXX = 0x8f;
        public static byte X__X____ = 0x90;
        public static byte X__X___X = 0x91;
        public static byte X__X__X_ = 0x92;
        public static byte X__X__XX = 0x93;
        public static byte X__X_X__ = 0x94;
        public static byte X__X_X_X = 0x95;
        public static byte X__X_XX_ = 0x96;
        public static byte X__X_XXX = 0x97;
        public static byte X__XX___ = 0x98;
        public static byte X__XX__X = 0x99;
        public static byte X__XX_X_ = 0x9a;
        public static byte X__XX_XX = 0x9b;
        public static byte X__XXX__ = 0x9c;
        public static byte X__XXX_X = 0x9d;
        public static byte X__XXXX_ = 0x9e;
        public static byte X__XXXXX = 0x9f;
        public static byte X_X_____ = 0xa0;
        public static byte X_X____X = 0xa1;
        public static byte X_X___X_ = 0xa2;
        public static byte X_X___XX = 0xa3;
        public static byte X_X__X__ = 0xa4;
        public static byte X_X__X_X = 0xa5;
        public static byte X_X__XX_ = 0xa6;
        public static byte X_X__XXX = 0xa7;
        public static byte X_X_X___ = 0xa8;
        public static byte X_X_X__X = 0xa9;
        public static byte X_X_X_X_ = 0xaa;
        public static byte X_X_X_XX = 0xab;
        public static byte X_X_XX__ = 0xac;
        public static byte X_X_XX_X = 0xad;
        public static byte X_X_XXX_ = 0xae;
        public static byte X_X_XXXX = 0xaf;
        public static byte X_XX____ = 0xb0;
        public static byte X_XX___X = 0xb1;
        public static byte X_XX__X_ = 0xb2;
        public static byte X_XX__XX = 0xb3;
        public static byte X_XX_X__ = 0xb4;
        public static byte X_XX_X_X = 0xb5;
        public static byte X_XX_XX_ = 0xb6;
        public static byte X_XX_XXX = 0xb7;
        public static byte X_XXX___ = 0xb8;
        public static byte X_XXX__X = 0xb9;
        public static byte X_XXX_X_ = 0xba;
        public static byte X_XXX_XX = 0xbb;
        public static byte X_XXXX__ = 0xbc;
        public static byte X_XXXX_X = 0xbd;
        public static byte X_XXXXX_ = 0xbe;
        public static byte X_XXXXXX = 0xbf;
        public static byte XX______ = 0xc0;
        public static byte XX_____X = 0xc1;
        public static byte XX____X_ = 0xc2;
        public static byte XX____XX = 0xc3;
        public static byte XX___X__ = 0xc4;
        public static byte XX___X_X = 0xc5;
        public static byte XX___XX_ = 0xc6;
        public static byte XX___XXX = 0xc7;
        public static byte XX__X___ = 0xc8;
        public static byte XX__X__X = 0xc9;
        public static byte XX__X_X_ = 0xca;
        public static byte XX__X_XX = 0xcb;
        public static byte XX__XX__ = 0xcc;
        public static byte XX__XX_X = 0xcd;
        public static byte XX__XXX_ = 0xce;
        public static byte XX__XXXX = 0xcf;
        public static byte XX_X____ = 0xd0;
        public static byte XX_X___X = 0xd1;
        public static byte XX_X__X_ = 0xd2;
        public static byte XX_X__XX = 0xd3;
        public static byte XX_X_X__ = 0xd4;
        public static byte XX_X_X_X = 0xd5;
        public static byte XX_X_XX_ = 0xd6;
        public static byte XX_X_XXX = 0xd7;
        public static byte XX_XX___ = 0xd8;
        public static byte XX_XX__X = 0xd9;
        public static byte XX_XX_X_ = 0xda;
        public static byte XX_XX_XX = 0xdb;
        public static byte XX_XXX__ = 0xdc;
        public static byte XX_XXX_X = 0xdd;
        public static byte XX_XXXX_ = 0xde;
        public static byte XX_XXXXX = 0xdf;
        public static byte XXX_____ = 0xe0;
        public static byte XXX____X = 0xe1;
        public static byte XXX___X_ = 0xe2;
        public static byte XXX___XX = 0xe3;
        public static byte XXX__X__ = 0xe4;
        public static byte XXX__X_X = 0xe5;
        public static byte XXX__XX_ = 0xe6;
        public static byte XXX__XXX = 0xe7;
        public static byte XXX_X___ = 0xe8;
        public static byte XXX_X__X = 0xe9;
        public static byte XXX_X_X_ = 0xea;
        public static byte XXX_X_XX = 0xeb;
        public static byte XXX_XX__ = 0xec;
        public static byte XXX_XX_X = 0xed;
        public static byte XXX_XXX_ = 0xee;
        public static byte XXX_XXXX = 0xef;
        public static byte XXXX____ = 0xf0;
        public static byte XXXX___X = 0xf1;
        public static byte XXXX__X_ = 0xf2;
        public static byte XXXX__XX = 0xf3;
        public static byte XXXX_X__ = 0xf4;
        public static byte XXXX_X_X = 0xf5;
        public static byte XXXX_XX_ = 0xf6;
        public static byte XXXX_XXX = 0xf7;
        public static byte XXXXX___ = 0xf8;
        public static byte XXXXX__X = 0xf9;
        public static byte XXXXX_X_ = 0xfa;
        public static byte XXXXX_XX = 0xfb;
        public static byte XXXXXX__ = 0xfc;
        public static byte XXXXXX_X = 0xfd;
        public static byte XXXXXXX_ = 0xfe;
        public static byte XXXXXXXX = 0xff;
        #endregion


        #region FONT5_7.C
        private static readonly byte[,] FONT5x7ASCII = new byte[,]
        {

            /* 空格 */  
  {
   ________,
   ________,
   ________,
   ________,
   ________,
   ________,
   ________,
   ________}

/*  !  */
 ,{
   X_______,
   X_______,
   X_______,
   X_______,
   X_______,
   ________,
   X_______,
   ________}


/*  "  */
 ,{
   X_X_____,
   X_X_____,
   X_X_____,
   ________,
   ________,
   ________,
   ________,
   ________}

/* #  */
 ,{
   _X_X____,
   _X_X____,
   XXXXX___,
   _X_X____,
   XXXXX___,
   _X_X____,
   _X_X____,
   ________}

/*  $  */
 ,{
   __X_____,
   _XXXX___,
   X_X_____,
   _XXX____,
   __X_X___,
   XXXX____,
   __X_____,
  ________ }

/*  %  */
 ,{
   XX______,
   XX__X___,
   ___X____,
   __X_____,
   _X______,
   X__XX___,
   ___XX___,
   ________}

/*  &  */
 ,{
   _XX_____,
   X__X____,
   X_X_____,
   _X______,
   X_X_X___,
   X__X____,
   _XX_X___,
   ________}

/*  '  */
 ,{
   XX______,
   _X______,
   X_______,
   ________,
   ________,
   ________,
   ________,
   ________}

/*  (  */
 ,{
   __X_____,
   _X______,
   X_______,
   X_______,
   X_______,
   _X______,
   __X_____,
   ________}

/*  )  */
 ,{
   X_______,
   _X______,
   __X_____,
   __X_____,
   __X_____,
   _X______,
   X_______,
   ________}

/*  *  */
 ,{
   ________,
   _X_X____,
   __X_____,
   XXXXX___,
   __X_____,
   _X_X____,
   ________,
   ________}

 ,{
   ________,
   __X_____,
   __X_____,
   XXXXX___,
   __X_____,
   __X_____,
   ________,
   ________}

 ,{
   ________,
   ________,
   ________,
   ________,
   ________,
   XX______,
   _X______,
   X_______}

 ,{
   ________,
   ________,
   ________,
   XXXXX___,
   ________,
   ________,
   ________,
   ________}

 ,{
   ________,
   ________,
   ________,
   ________,
   ________,
   XX______,
   XX______,
   ________}

 ,{
   ________,
   ____X___,
   ___X____,
   __X_____,
   _X______,
   X_______,
   ________,
   ________}

/* 0 */
 ,{
   _XXX____,
   X___X___,
   X__XX___,
   X_X_X___,
   XX__X___,
   X___X___,
   _XXX____,
   ________}

/* 1 */
 ,{
   __X_____,
   _XX_____,
   __X_____,
   __X_____,
   __X_____,
   __X_____,
   _XXX____,
   ________}

/* 2 */
 ,{
   _XXX____,
   X___X___,
   ____X___,
   __XX____,
   _X______,
   X_______,
   XXXXX___,
   ________}

/* 3 */
 ,{
   _XXX____,
   X___X___,
   ____X___,
   __XX____,
   ____X___,
   X___X___,
   _XXX____,
   ________}

/* 4 */
 ,{
   ___X____,
   __XX____,
   _X_X____,
   X__X____,
   XXXXX___,
   ___X____,
   ___X____,
   ________}

/* 5 */
 ,{
   XXXXX___,
   X_______,
   XXXX____,
   ____X___,
   ____X___,
   X___X___,
   _XXX____,
   ________}

/* 6 */
 ,{
   __XX____,
   _X______,
   X_______,
   XXXX____,
   X___X___,
   X___X___,
   _XXX____,
   ________}

/* 7 */
 ,{
   XXXXX___,
   ____X___,
   ___X____,
   __X_____,
   _X______,
   _X______,
   _X______,
   ________}

/* 8 */
 ,{
   _XXX____,
   X___X___,
   X___X___,
   _XXX____,
   X___X___,
   X___X___,
   _XXX____,
   ________}

/* 9 */
 ,{
   _XXX____,
   X___X___,
   X___X___,
   _XXXX___,
   ____X___,
   ___X____,
   _XX_____,
   ________}

/* ':' 3a */
 ,{
   ________,
   XX______,
   XX______,
   ________,
   XX______,
   XX______,
   ________,
   ________}

/* ';' 3b */
 ,{
   ________,
   ________,
   XX______,
   XX______,
   ________,
   XX______,
   _X______,
   X_______}


/* '<' 3c */
 ,{
   ___X____,
   __X_____,
   _X______,
   X_______,
   _X______,
   __X_____,
   ___X____,
   ________}

/* '=' 3d */
 ,{
   ________,
   ________,
   XXXXX___,
   ________,
   XXXXX___,
   ________,
   ________,
   ________}

/* '>' */
 ,{
   X_______,
   _X______,
   __X_____,
   ___X____,
   __X_____,
   _X______,
   X_______,
   ________}

/* '?' */
 ,{
   _XXX____,
   X___X___,
   ____X___,
   ___X____,
   __X_____,
   ________,
   __X_____,
   ________}

/* @ */
 ,{
   _XXX____,
   X___X___,
   ____X___,
   _XX_X___,
   X_X_X___,
   X_X_X___,
   _XXX____,
   ________}

/* A */
 ,{
   _XXX____,
   X___X___,
   X___X___,
   XXXXX___,
   X___X___,
   X___X___,
   X___X___,
   ________}

/* B */
 ,{
   XXXX____,
   X___X___,
   X___X___,
   XXXX____,
   X___X___,
   X___X___,
   XXXX____,
   ________}

/* C */
 ,{
   _XXX____,
   X___X___,
   X_______,
   X_______,
   X_______,
   X___X___,
   _XXX____,
   ________}

/* D */
 ,{
   XXX_____,
   X__X____,
   X___X___,
   X___X___,
   X___X___,
   X__X____,
   XXX_____,
   ________}

/* E */
 ,{
   XXXXX___,
   X_______,
   X_______,
   XXXX____,
   X_______,
   X_______,
   XXXXX___,
   ________}

/* F */
 ,{
   XXXXX___,
   X_______,
   X_______,
   XXXX____,
   X_______,
   X_______,
   X_______,
   ________}

/* G */
 ,{
   _XXX____,
   X___X___,
   X_______,
   X_______,
   X__XX___,
   X___X___,
   _XXXX___,
   ________}

/* H */
 ,{
   X___X___,
   X___X___,
   X___X___,
   XXXXX___,
   X___X___,
   X___X___,
   X___X___,
   ________}

/* I */
 ,{
   XXX_____,
   _X______,
   _X______,
   _X______,
   _X______,
   _X______,
   XXX_____,
   ________}

/* J */
 ,{
   __XXX___,
   ___X____,
   ___X____,
   ___X____,
   ___X____,
   X__X____,
   _XX_____,
   ________}

/* K */
 ,{
   X___X___,
   X__X____,
   X_X_____,
   XX______,
   X_X_____,
   X__X____,
   X___X___,
   ________}

/* L */
 ,{
   X_______,
   X_______,
   X_______,
   X_______,
   X_______,
   X_______,
   XXXXX___,
   ________}

/* M */
 ,{
   X___X___,
   XX_XX___,
   X_X_X___,
   X_X_X___,
   X___X___,
   X___X___,
   X___X___,
   ________}

/* N */
 ,{
   X___X___,
   X___X___,
   XX__X___,
   X_X_X___,
   X__XX___,
   X___X___,
   X___X___,
   ________}

/* O */
 ,{
   _XXX____,
   X___X___,
   X___X___,
   X___X___,
   X___X___,
   X___X___,
   _XXX____,
   ________}

/* P */
 ,{
   XXXX____,
   X___X___,
   X___X___,
   XXXX____,
   X_______,
   X_______,
   X_______,
   ________}

/* Q */
 ,{
   _XXX____,
   X___X___,
   X___X___,
   X___X___,
   X_X_X___,
   X__X____,
   _XX_X___,
   ________}

/* R */
 ,{
   XXXX____,
   X___X___,
   X___X___,
   XXXX____,
   X_X_____,
   X__X____,
   X___X___,
   ________}

/* S */
 ,{
   _XXX____,
   X___X___,
   X_______,
   _XXX____,
   ____X___,
   X___X___,
   _XXX____,
   ________}

/* T */
 ,{
   XXXXX___,
   __X_____,
   __X_____,
   __X_____,
   __X_____,
   __X_____,
   __X_____,
   ________}

/* U */
 ,{
   X___X___,
   X___X___,
   X___X___,
   X___X___,
   X___X___,
   X___X___,
   _XXX____,
   ________}

/* V */
 ,{
   X___X___,
   X___X___,
   X___X___,
   X___X___,
   X___X___,
   _X_X____,
   __X_____,
   ________}

/* W */
 ,{
   X___X___,
   X___X___,
   X___X___,
   X_X_X___,
   X_X_X___,
   X_X_X___,
   _X_X____,
   ________}

/* X */
 ,{
   X___X___,
   X___X___,
   _X_X____,
   __X_____,
   _X_X____,
   X___X___,
   X___X___,
   ________}

/* Y */
 ,{
   X___X___,
   X___X___,
   _X_X____,
   __X_____,
   __X_____,
   __X_____,
   __X_____,
   ________}

/* Z */
 ,{
   XXXXX___,
   ____X___,
   ___X____,
   __X_____,
   _X______,
   X_______,
   XXXXX___,
   ________}

/* 5b */
 ,{
   XXX_____,
   X_______,
   X_______,
   X_______,
   X_______,
   X_______,
   XXX_____,
   ________}

/* 5c */
 ,{
   ________,
   X_______,
   _X______,
   __X_____,
   ___X____,
   ____X___,
   ________,
   ________}

/* 5d */
 ,{
   XXX_____,
   __X_____,
   __X_____,
   __X_____,
   __X_____,
   __X_____,
   XXX_____,
   ________}

/* 5e */
 ,{
   __X_____,
   _X_X____,
   X___X___,
   ________,
   ________,
   ________,
   ________,
   ________}

/* 5f */
 ,{
   ________,
   ________,
   ________,
   ________,
   ________,
   ________,
   ________,
   XXXXX___}

/* 60 */
 ,{
   X_______,
   _X______,
   __X_____,
   ________,
   ________,
   ________,
   ________,
   ________}

/* a */
 ,{
   ________,
   ________,
   _XXX____,
   ____X___,
   _XXXX___,
   X___X___,
   _XXXX___,
   ________}

/* b */
 ,{
   X_______,
   X_______,
   X_XX____,
   XX__X___,
   X___X___,
   X___X___,
   XXXX____,
   ________}

/* c */
 ,{
   ________,
   ________,
   _XX_____,
   X__X____,
   X_______,
   X__X____,
   _XX_____,
   ________}

/* d */
 ,{
   ____X___,
   ____X___,
   _XX_X___,
   X__XX___,
   X___X___,
   X___X___,
   _XXXX___,
   ________}

/* e */
 ,{
   ________,
   ________,
   _XXX____,
   X___X___,
   XXXXX___,
   X_______,
   _XXX____,
   ________}

/* f */
 ,{
   __X_____,
   _X_X____,
   _X______,
   XXX_____,
   _X______,
   _X______,
   _X______,
   ________}

/* g */
 ,{
   ________,
   ________,
   _XXXX___,
   X___X___,
   X___X___,
   _XXXX___,
   ____X___,
   _XXX____}

/* h */
 ,{
   X_______,
   X_______,
   X_XX____,
   XX__X___,
   X___X___,
   X___X___,
   X___X___,
   ________}

/* i */
 ,{
   _X______,
   ________,
   _X______,
   _X______,
   _X______,
   _X______,
   _X______,
   ________}

/* j */
 ,{
   __X_____,
   ________,
   _XX_____,
   __X_____,
   __X_____,
   __X_____,
   __X_____,
   XX______}

/* k */
 ,{
   X_______,
   X_______,
   X__X____,
   X_X_____,
   XX______,
   X_X_____,
   X__X____,
   ________}

/* l */
 ,{
   XX______,
   _X______,
   _X______,
   _X______,
   _X______,
   _X______,
   XXX_____,
   ________}

/* m */
 ,{
   ________,
   ________,
   XX_X____,
   X_X_X___,
   X_X_X___,
   X___X___,
   X___X___,
   ________}

/* n */
 ,{
   ________,
   ________,
   X_XX____,
   XX_X____,
   X__X____,
   X__X____,
   X__X____,
   ________}

/* o */
 ,{
   ________,
   ________,
   _XX_____,
   X__X____,
   X__X____,
   X__X____,
   _XX_____,
   ________}

/* p */
 ,{
   ________,
   ________,
   XXX_____,
   X__X____,
   X__X____,
   XXX_____,
   X_______,
   X_______}

/* q */
 ,{
   ________,
   ________,
   _XXX____,
   X__X____,
   X__X____,
   _XXX____,
   ___X____,
   ___X____}

/* r */
 ,{
   ________,
   ________,
   _X_X____,
   _XX_____,
   _X______,
   _X______,
   _X______,
   ________}

/* s */
 ,{
   ________,
   ________,
   _XXX____,
   X_______,
   _XX_____,
   ___X____,
   XXX_____,
   ________}

/* t */
 ,{
   _X______,
   _X______,
   XXX_____,
   _X______,
   _X______,
   _X______,
   _XX_____,
   ________}

/* u */
 ,{
   ________,
   ________,
   X__X____,
   X__X____,
   X__X____,
   X__X____,
   _XXX____,
   ________}

/* v */
 ,{
   ________,
   ________,
   X___X___,
   X___X___,
   X___X___,
   _X_X____,
   __X_____,
   ________}

/* w */
 ,{
   ________,
   ________,
   X___X___,
   X___X___,
   X_X_X___,
   X_X_X___,
   _X_X____,
   ________}

/* X */
 ,{
   ________,
   ________,
   X___X___,
   _X_X____,
   __X_____,
   _X_X____,
   X___X___,
   ________}

/* y */
 ,{
   ________,
   ________,
   X__X____,
   X__X____,
   X__X____,
   _XXX____,
   ___X____,
   _XX_____}

/* z */
 ,{
   ________,
   ________,
   XXXXX___,
   ___X____,
   __X_____,
   _X______,
   XXXXX___,
   ________}

/* 0x7b */
 ,{
   __X_____,
   _X______,
   _X______,
   X_______,
   _X______,
   _X______,
   __X_____,
   ________}

/* 0x7c */
 ,{
   _X______,
   _X______,
   _X______,
   _X______,
   _X______,
   _X______,
   _X______,
   ________}

/* 0x7d */
 ,{
   X_______,
   _X______,
   _X______,
   __X_____,
   _X______,
   _X______,
   X_______,
   ________}

/* 0x7e */
 ,{
   _XX_X___,
   X__X____,
   ________,
   ________,
   ________,
   ________,
   ________,
   ________}
   
/* 0x7f */
 ,{
   XXXXX___,
   XXXXX___,
   XXXXX___,
   XXXXX___,
   XXXXX___,
   XXXXX___,
   XXXXX___,
   ________}


        };

        #endregion



        public static readonly byte[,] FONT8x8ASCII = new byte[,]
       {
           /* 空格 */
  {
   ________,
   ________,
   ________,
   ________,
   ________,
   ________,
   ________,
   ________} 
    
/*  !  */   
 ,{
   ___XX___,
   __XXXX__,
   __XXXX__,
   ___XX___,
   ___XX___,
   ________,
   ___XX___,
   ________}  

/*  "  */
 ,{
   _XX__XX_,
   _XX__XX_,
   __X__X__,
   ________,
   ________,
   ________,
   ________,
   ________}  
/*  #  */
 ,{
   _XX_XX__,
   _XX_XX__,
   XXXXXXX_,
   _XX_XX__,
   XXXXXXX_,
   _XX_XX__,
   _XX_XX__,
   ________}  

/*  $  */
 ,{
   ___XX___,
   __XXXXX_,
   _XX_____,
   __XXXX__,
   _____XX_,
   _XXXXX__,
   ___XX___,
   ________}  

/*  %  */
 ,{
   ________,
   XX___XX_,
   XX__XX__,
   ___XX___,
   __XX____,
   _XX__XX_,
   XX___XX_,
   ________}  

/*  &  */
 ,{
   __XXX___,
   _XX_XX__,
   __XXX___,
   _XXX_XX_,
   XX_XXX__,
   XX__XX__,
   _XXX_XX_,
   ________}  

/*  '  */
 ,{
   ___XX___,
   ___XX___,
   __XX____,
   ________,
   ________,
   ________,
   ________,
   ________}  

/*  (  */
 ,{
   ____XX__,
   ___XX___,
   __XX____,
   __XX____,
   __XX____,
   ___XX___,
   ____XX__,
   ________}  

/*  )  */
 ,{
   __XX____,
   ___XX___,
   ____XX__,
   ____XX__,
   ____XX__,
   ___XX___,
   __XX____,
   ________}  

/*  *  */
 ,{
   ________,
   _XX__XX_,
   __XXXX__,
   XXXXXXXX,
   __XXXX__,
   _XX__XX_,
   ________,
   ________}  

/*  +  */
 ,{
   ________,
   ___XX___,
   ___XX___,
   _XXXXXX_,
   ___XX___,
   ___XX___,
   ________,
   ________}  

/*  ,  */
 ,{
   ________,
   ________,
   ________,
   ________,
   ________,
   ___XX___,
   ___XX___,
   __XX____}  

/*  -  */
 ,{
   ________,
   ________,
   ________,
   _XXXXXX_,
   ________,
   ________,
   ________,
   ________}  

/*  .  */
 ,{
   ________,
   ________,
   ________,
   ________,
   ________,
   ___XX___,
   ___XX___,
   ________}  

/*  /  */
 ,{
   _____XX_,
   ____XX__,
   ___XX___,
   __XX____,
   _XX_____,
   XX______,
   X_______,
   ________}  

/*  0  */
 ,{
   __XXX___,
   _XX_XX__,
   XX___XX_,
   XX___XX_,
   XX___XX_,
   _XX_XX__,
   __XXX___,
   ________}  

/*  1  */
 ,{
   ___XX___,
   __XXX___,
   ___XX___,
   ___XX___,
   ___XX___,
   ___XX___,
   _XXXXXX_,
   ________}  

/*  2  */
 ,{
   _XXXXX__,
   XX___XX_,
   _____XX_,
   ___XXX__,
   __XX____,
   _XX__XX_,
   XXXXXXX_,
   ________}  

/*  3  */
 ,{
   _XXXXX__,
   XX___XX_,
   _____XX_,
   __XXXX__,
   _____XX_,
   XX___XX_,
   _XXXXX__,
   ________}  

/*  4  */
 ,{
   ___XXX__,
   __XXXX__,
   _XX_XX__,
   XX__XX__,
   XXXXXXX_,
   ____XX__,
   ___XXXX_,
   ________}  

/*  5  */
 ,{
   XXXXXXX_,
   XX______,
   XX______,
   XXXXXX__,
   _____XX_,
   XX___XX_,
   _XXXXX__,
   ________}  

/*  6  */
 ,{
   __XXX___,
   _XX_____,
   XX______,
   XXXXXX__,
   XX___XX_,
   XX___XX_,
   _XXXXX__,
   ________}  

/*  7  */
 ,{
   XXXXXXX_,
   XX___XX_,
   ____XX__,
   ___XX___,
   __XX____,
   __XX____,
   __XX____,
   ________}  

/*  8  */
 ,{
   _XXXXX__,
   XX___XX_,
   XX___XX_,
   _XXXXX__,
   XX___XX_,
   XX___XX_,
   _XXXXX__,
   ________}  

/*  9  */
 ,{
   _XXXXX__,
   XX___XX_,
   XX___XX_,
   _XXXXXX_,
   _____XX_,
   ____XX__,
   _XXXX___,
   ________}  

/*  :  */
 ,{
   ________,
   ___XX___,
   ___XX___,
   ________,
   ________,
   ___XX___,
   ___XX___,
   ________}  

/*  ;  */
 ,{
   ________,
   ___XX___,
   ___XX___,
   ________,
   ________,
   ___XX___,
   ___XX___,
   __XX____}  

/*  <  */
 ,{
   _____XX_,
   ____XX__,
   ___XX___,
   __XX____,
   ___XX___,
   ____XX__,
   _____XX_,
   ________}  

/*  =  */
 ,{
   ________,
   ________,
   _XXXXXX_,
   ________,
   ________,
   _XXXXXX_,
   ________,
   ________}  

/*  >  */
 ,{
   _XX_____,
   __XX____,
   ___XX___,
   ____XX__,
   ___XX___,
   __XX____,
   _XX_____,
   ________}  

/*  ?  */
 ,{
   _XXXXX__,
   XX___XX_,
   ____XX__,
   ___XX___,
   ___XX___,
   ________,
   ___XX___,
   ________}  

/*  @  */
 ,{
   _XXXXX__,
   XX___XX_,
   XX_XXXX_,
   XX_XXXX_,
   XX_XXXX_,
   XX______,
   _XXXX___,
   ________}  

/*  A  */
 ,{
   __XXX___,
   _XX_XX__,
   XX___XX_,
   XXXXXXX_,
   XX___XX_,
   XX___XX_,
   XX___XX_,
   ________}  

/*  B  */
 ,{
   XXXXXX__,
   _XX__XX_,
   _XX__XX_,
   _XXXXX__,
   _XX__XX_,
   _XX__XX_,
   XXXXXX__,
   ________}  

/*  C  */
 ,{
   __XXXX__,
   _XX__XX_,
   XX______,
   XX______,
   XX______,
   _XX__XX_,
   __XXXX__,
   ________}  

/*  D  */
 ,{
   XXXXX___,
   _XX_XX__,
   _XX__XX_,
   _XX__XX_,
   _XX__XX_,
   _XX_XX__,
   XXXXX___,
   ________}  

/*  E  */
 ,{
   XXXXXXX_,
   _XX___X_,
   _XX_X___,
   _XXXX___,
   _XX_X___,
   _XX___X_,
   XXXXXXX_,
   ________}  

/*  F  */
 ,{
   XXXXXXX_,
   _XX___X_,
   _XX_X___,
   _XXXX___,
   _XX_X___,
   _XX_____,
   XXXX____,
   ________}  

/*  G  */
 ,{
   __XXXX__,
   _XX__XX_,
   XX______,
   XX______,
   XX__XXX_,
   _XX__XX_,
   __XXX_X_,
   ________}  

/*  H  */
 ,{
   XX___XX_,
   XX___XX_,
   XX___XX_,
   XXXXXXX_,
   XX___XX_,
   XX___XX_,
   XX___XX_,
   ________}  

/*  I  */
 ,{
   __XXXX__,
   ___XX___,
   ___XX___,
   ___XX___,
   ___XX___,
   ___XX___,
   __XXXX__,
   ________}  

/*  J  */
 ,{
   ___XXXX_,
   ____XX__,
   ____XX__,
   ____XX__,
   XX__XX__,
   XX__XX__,
   _XXXX___,
   ________}  

/*  K  */
 ,{
   XXX__XX_,
   _XX__XX_,
   _XX_XX__,
   _XXXX___,
   _XX_XX__,
   _XX__XX_,
   XXX__XX_,
   ________}  

/*  L  */
 ,{
   XXXX____,
   _XX_____,
   _XX_____,
   _XX_____,
   _XX___X_,
   _XX__XX_,
   XXXXXXX_,
   ________}  

/*  M  */
 ,{
   XX___XX_,
   XXX_XXX_,
   XXXXXXX_,
   XXXXXXX_,
   XX_X_XX_,
   XX___XX_,
   XX___XX_,
   ________}  

/*  N  */
 ,{
   XX___XX_,
   XXX__XX_,
   XXXX_XX_,
   XX_XXXX_,
   XX__XXX_,
   XX___XX_,
   XX___XX_,
   ________}  

/*  O  */
 ,{
   _XXXXX__,
   XX___XX_,
   XX___XX_,
   XX___XX_,
   XX___XX_,
   XX___XX_,
   _XXXXX__,
   ________}  

/*  P  */
 ,{
   XXXXXX__,
   _XX__XX_,
   _XX__XX_,
   _XXXXX__,
   _XX_____,
   _XX_____,
   XXXX____,
   ________}  

/*  Q  */
 ,{
   _XXXXX__,
   XX___XX_,
   XX___XX_,
   XX___XX_,
   XX___XX_,
   XX__XXX_,
   _XXXXX__,
   ____XXX_}  

/*  R  */
 ,{
   XXXXXX__,
   _XX__XX_,
   _XX__XX_,
   _XXXXX__,
   _XX_XX__,
   _XX__XX_,
   XXX__XX_,
   ________}  

/*  S  */
 ,{
   __XXXX__,
   _XX__XX_,
   __XX____,
   ___XX___,
   ____XX__,
   _XX__XX_,
   __XXXX__,
   ________}  

/*  T  */
 ,{
   _XXXXXX_,
   _XXXXXX_,
   _X_XX_X_,
   ___XX___,
   ___XX___,
   ___XX___,
   __XXXX__,
   ________}  

/*  U  */
 ,{
   XX___XX_,
   XX___XX_,
   XX___XX_,
   XX___XX_,
   XX___XX_,
   XX___XX_,
   _XXXXX__,
   ________}  

/*  V  */
 ,{
   XX___XX_,
   XX___XX_,
   XX___XX_,
   XX___XX_,
   XX___XX_,
   _XX_XX__,
   __XXX___,
   ________}  

/*  W  */
 ,{
   XX___XX_,
   XX___XX_,
   XX___XX_,
   XX_X_XX_,
   XX_X_XX_,
   XXXXXXX_,
   _XX_XX__,
   ________}  

/*  X  */
 ,{
   XX___XX_,
   XX___XX_,
   _XX_XX__,
   __XXX___,
   _XX_XX__,
   XX___XX_,
   XX___XX_,
   ________}  

/*  Y  */
 ,{
   _XX__XX_,
   _XX__XX_,
   _XX__XX_,
   __XXXX__,
   ___XX___,
   ___XX___,
   __XXXX__,
   ________}  

/*  Z  */
 ,{
   XXXXXXX_,
   XX___XX_,
   X___XX__,
   ___XX___,
   __XX__X_,
   _XX__XX_,
   XXXXXXX_,
   ________}  

/*  [  */
 ,{
   __XXXX__,
   __XX____,
   __XX____,
   __XX____,
   __XX____,
   __XX____,
   __XXXX__,
   ________}  

/*  \  */
 ,{
   XX______,
   _XX_____,
   __XX____,
   ___XX___,
   ____XX__,
   _____XX_,
   ______X_,
   ________}  

/*  ]  */
 ,{
   __XXXX__,
   ____XX__,
   ____XX__,
   ____XX__,
   ____XX__,
   ____XX__,
   __XXXX__,
   ________}  

/*  ^  */
 ,{
   ___X____,
   __XXX___,
   _XX_XX__,
   XX___XX_,
   ________,
   ________,
   ________,
   ________}  

/*  _  */
 ,{
   ________,
   ________,
   ________,
   ________,
   ________,
   ________,
   ________,
   XXXXXXXX}  

/*  `  */
 ,{
   __XX____,
   ___XX___,
   ____XX__,
   ________,
   ________,
   ________,
   ________,
   ________}  

/*  a  */
 ,{
   ________,
   ________,
   _XXXX___,
   ____XX__,
   _XXXXX__,
   XX__XX__,
   _XXX_XX_,
   ________}  

/*  b  */
 ,{
   XXX_____,
   _XX_____,
   _XXXXX__,
   _XX__XX_,
   _XX__XX_,
   _XX__XX_,
   XX_XXX__,
   ________}  

/*  c  */
 ,{
   ________,
   ________,
   _XXXXX__,
   XX___XX_,
   XX______,
   XX___XX_,
   _XXXXX__,
   ________}  

/*  d  */
 ,{
   ___XXX__,
   ____XX__,
   _XXXXX__,
   XX__XX__,
   XX__XX__,
   XX__XX__,
   _XXX_XX_,
   ________}  

/*  e  */
 ,{
   ________,
   ________,
   _XXXXX__,
   XX___XX_,
   XXXXXXX_,
   XX______,
   _XXXXX__,
   ________}  

/*  f  */
 ,{
   __XXXX__,
   _XX__XX_,
   _XX_____,
   XXXXX___,
   _XX_____,
   _XX_____,
   XXXX____,
   ________}  

/*  g  */
 ,{
   ________,
   ________,
   _XXX_XX_,
   XX__XX__,
   XX__XX__,
   _XXXXX__,
   ____XX__,
   XXXXX___}  

/*  h  */
 ,{
   XXX_____,
   _XX_____,
   _XX_XX__,
   _XXX_XX_,
   _XX__XX_,
   _XX__XX_,
   XXX__XX_,
   ________}  

/*  i  */
 ,{
   ___XX___,
   ________,
   __XXX___,
   ___XX___,
   ___XX___,
   ___XX___,
   __XXXX__,
   ________}  

/*  j  */
 ,{
   _____XX_,
   ________,
   _____XX_,
   _____XX_,
   _____XX_,
   _XX__XX_,
   _XX__XX_,
   __XXXX__}  

/*  k  */
 ,{
   XXX_____,
   _XX_____,
   _XX__XX_,
   _XX_XX__,
   _XXXX___,
   _XX_XX__,
   XXX__XX_,
   ________}  

/*  l  */
 ,{
   __XXX___,
   ___XX___,
   ___XX___,
   ___XX___,
   ___XX___,
   ___XX___,
   __XXXX__,
   ________}  

/*  m  */
 ,{
   ________,
   ________,
   XXX_XX__,
   XXXXXXX_,
   XX_X_XX_,
   XX_X_XX_,
   XX_X_XX_,
   ________}  

/*  n  */
 ,{
   ________,
   ________,
   XX_XXX__,
   _XX__XX_,
   _XX__XX_,
   _XX__XX_,
   _XX__XX_,
   ________}  

/*  o  */
 ,{
   ________,
   ________,
   _XXXXX__,
   XX___XX_,
   XX___XX_,
   XX___XX_,
   _XXXXX__,
   ________}  

/*  p  */
 ,{
   ________,
   ________,
   XX_XXX__,
   _XX__XX_,
   _XX__XX_,
   _XXXXX__,
   _XX_____,
   XXXX____}  

/*  q  */
 ,{
   ________,
   ________,
   _XXX_XX_,
   XX__XX__,
   XX__XX__,
   _XXXXX__,
   ____XX__,
   ___XXXX_}  

/*  r  */
 ,{
   ________,
   ________,
   XX_XXX__,
   _XXX_XX_,
   _XX_____,
   _XX_____,
   XXXX____,
   ________}  

/*  s  */
 ,{
   ________,
   ________,
   _XXXXXX_,
   XX______,
   _XXXXX__,
   _____XX_,
   XXXXXX__,
   ________}  

/*  t  */
 ,{
   __XX____,
   __XX____,
   XXXXXX__,
   __XX____,
   __XX____,
   __XX_XX_,
   ___XXX__,
   ________}  

/*  u  */
 ,{
   ________,
   ________,
   XX__XX__,
   XX__XX__,
   XX__XX__,
   XX__XX__,
   _XXX_XX_,
   ________}  

/*  v  */
 ,{
   ________,
   ________,
   XX___XX_,
   XX___XX_,
   XX___XX_,
   _XX_XX__,
   __XXX___,
   ________}  

/*  w  */
 ,{
   ________,
   ________,
   XX___XX_,
   XX_X_XX_,
   XX_X_XX_,
   XXXXXXX_,
   _XX_XX__,
   ________}  

/*  x  */
 ,{
   ________,
   ________,
   XX___XX_,
   _XX_XX__,
   __XXX___,
   _XX_XX__,
   XX___XX_,
   ________}  

/*  y  */
 ,{
   ________,
   ________,
   XX___XX_,
   XX___XX_,
   XX___XX_,
   _XXXXXX_,
   _____XX_,
   XXXXXX__}  

/*  z  */
 ,{
   ________,
   ________,
   _XXXXXX_,
   _X__XX__,
   ___XX___,
   __XX__X_,
   _XXXXXX_,
   ________} 

/*  {  */
 ,{
   ____XXX_,
   ___XX___,
   ___XX___,
   _XXX____,
   ___XX___,
   ___XX___,
   ____XXX_,
   ________}  

/*  |  */
 ,{
   ___XX___,
   ___XX___,
   ___XX___,
   ___XX___,
   ___XX___,
   ___XX___,
   ___XX___,
   ________}  
   
/*  }  */
 ,{
   _XXX____,
   ___XX___,
   ___XX___,
   ____XXX_,
   ___XX___,
   ___XX___,
   _XXX____,
   ________}  

/*  ~  */
 ,{
   _XXX_XX_,
   XX_XXX__,
   ________,
   ________,
   ________,
   ________,
   ________,
   ________}   

/* 0x7f */
 ,{
   XXXXXX__,
   XXXXXX__,
   XXXXXX__,
   XXXXXX__,
   XXXXXX__,
   XXXXXX__,
   XXXXXX__,
   ________}


       };

public static readonly byte[,] FONT8x16ASCII = {
/*--  文字:     --39*/
/*--  宋体12;  此字体下对应的点阵为：宽x高=8x16   --*/
{0x00,0x00,0x00,0x00,0x00,0x00,0x00,0x00,0x00,0x00,0x00,0x00,0x00,0x00,0x00,0x00},


/*--  文字:  !  --*/
/*--  宋体12;  此字体下对应的点阵为：宽x高=8x16   --*/
{0x00,0x00,0x00,0x10,0x10,0x10,0x10,0x10,0x10,0x10,0x00,0x00,0x18,0x18,0x00,0x00},

/*--  文字:  "  --*/
/*--  宋体12;  此字体下对应的点阵为：宽x高=8x16   --*/
{0x00,0x12,0x36,0x24,0x48,0x00,0x00,0x00,0x00,0x00,0x00,0x00,0x00,0x00,0x00,0x00},

/*--  文字:  #  --*/
/*--  宋体12;  此字体下对应的点阵为：宽x高=8x16   --*/
{0x00,0x00,0x00,0x24,0x24,0x24,0xFE,0x48,0x48,0x48,0xFE,0x48,0x48,0x48,0x00,0x00},

/*--  文字:  $  --*/
/*--  宋体12;  此字体下对应的点阵为：宽x高=8x16   --*/
{0x00,0x00,0x10,0x38,0x54,0x54,0x50,0x30,0x18,0x14,0x14,0x54,0x54,0x38,0x10,0x10},

/*--  文字:  %  --*/
/*--  宋体12;  此字体下对应的点阵为：宽x高=8x16   --*/
{0x00,0x00,0x00,0x44,0xA4,0xA8,0xA8,0xA8,0x54,0x1A,0x2A,0x2A,0x2A,0x44,0x00,0x00},

/*--  文字:  &  --*/
/*--  宋体12;  此字体下对应的点阵为：宽x高=8x16   --*/
{0x00,0x00,0x00,0x30,0x48,0x48,0x48,0x50,0x6E,0xA4,0x94,0x88,0x89,0x76,0x00,0x00},

/*--  文字:  '  --*/
/*--  宋体12;  此字体下对应的点阵为：宽x高=8x16   --*/
{0x00,0x60,0x60,0x20,0xC0,0x00,0x00,0x00,0x00,0x00,0x00,0x00,0x00,0x00,0x00,0x00},

/*--  文字:  (  --*/
/*--  宋体12;  此字体下对应的点阵为：宽x高=8x16   --*/
{0x00,0x02,0x04,0x08,0x08,0x10,0x10,0x10,0x10,0x10,0x10,0x08,0x08,0x04,0x02,0x00},

/*--  文字:  )  --*/
/*--  宋体12;  此字体下对应的点阵为：宽x高=8x16   --*/
{0x00,0x40,0x20,0x10,0x10,0x08,0x08,0x08,0x08,0x08,0x08,0x10,0x10,0x20,0x40,0x00},

/*--  文字:  *  --*/
/*--  宋体12;  此字体下对应的点阵为：宽x高=8x16   --*/
{0x00,0x00,0x00,0x00,0x10,0x10,0xD6,0x38,0x38,0xD6,0x10,0x10,0x00,0x00,0x00,0x00},

/*--  文字:  +  --*/
/*--  宋体12;  此字体下对应的点阵为：宽x高=8x16   --*/
{0x00,0x00,0x00,0x00,0x10,0x10,0x10,0x10,0xFE,0x10,0x10,0x10,0x10,0x00,0x00,0x00},

/*--  文字:  ,  --*/
/*--  宋体12;  此字体下对应的点阵为：宽x高=8x16   --*/
{0x00,0x00,0x00,0x00,0x00,0x00,0x00,0x00,0x00,0x00,0x00,0x00,0x60,0x60,0x20,0xC0},

/*--  文字:  -  --*/
/*--  宋体12;  此字体下对应的点阵为：宽x高=8x16   --*/
{0x00,0x00,0x00,0x00,0x00,0x00,0x00,0x00,0x7F,0x00,0x00,0x00,0x00,0x00,0x00,0x00},

/*--  文字:  .  --*/
/*--  宋体12;  此字体下对应的点阵为：宽x高=8x16   --*/
{0x00,0x00,0x00,0x00,0x00,0x00,0x00,0x00,0x00,0x00,0x00,0x00,0x60,0x60,0x00,0x00},

/*--  文字:  /  --*/
/*--  宋体12;  此字体下对应的点阵为：宽x高=8x16   --*/
{0x00,0x00,0x01,0x02,0x02,0x04,0x04,0x08,0x08,0x10,0x10,0x20,0x20,0x40,0x40,0x00},

/*--  文字:  0  --*/
/*--  宋体12;  此字体下对应的点阵为：宽x高=8x16   --*/
{0x00,0x00,0x00,0x18,0x24,0x42,0x42,0x42,0x42,0x42,0x42,0x42,0x24,0x18,0x00,0x00},

/*--  文字:  1  --*/
/*--  宋体12;  此字体下对应的点阵为：宽x高=8x16   --*/
{0x00,0x00,0x00,0x10,0x70,0x10,0x10,0x10,0x10,0x10,0x10,0x10,0x10,0x7C,0x00,0x00},

/*--  文字:  2  --*/
/*--  宋体12;  此字体下对应的点阵为：宽x高=8x16   --*/
{0x00,0x00,0x00,0x3C,0x42,0x42,0x42,0x04,0x04,0x08,0x10,0x20,0x42,0x7E,0x00,0x00},

/*--  文字:  3  --*/
/*--  宋体12;  此字体下对应的点阵为：宽x高=8x16   --*/
{0x00,0x00,0x00,0x3C,0x42,0x42,0x04,0x18,0x04,0x02,0x02,0x42,0x44,0x38,0x00,0x00},

/*--  文字:  4  --*/
/*--  宋体12;  此字体下对应的点阵为：宽x高=8x16   --*/
{0x00,0x00,0x00,0x04,0x0C,0x14,0x24,0x24,0x44,0x44,0x7E,0x04,0x04,0x1E,0x00,0x00},

/*--  文字:  5  --*/
/*--  宋体12;  此字体下对应的点阵为：宽x高=8x16   --*/
{0x00,0x00,0x00,0x7E,0x40,0x40,0x40,0x58,0x64,0x02,0x02,0x42,0x44,0x38,0x00,0x00},

/*--  文字:  6  --*/
/*--  宋体12;  此字体下对应的点阵为：宽x高=8x16   --*/
{0x00,0x00,0x00,0x1C,0x24,0x40,0x40,0x58,0x64,0x42,0x42,0x42,0x24,0x18,0x00,0x00},

/*--  文字:  7  --*/
/*--  宋体12;  此字体下对应的点阵为：宽x高=8x16   --*/
{0x00,0x00,0x00,0x7E,0x44,0x44,0x08,0x08,0x10,0x10,0x10,0x10,0x10,0x10,0x00,0x00},

/*--  文字:  8  --*/
/*--  宋体12;  此字体下对应的点阵为：宽x高=8x16   --*/
{0x00,0x00,0x00,0x3C,0x42,0x42,0x42,0x24,0x18,0x24,0x42,0x42,0x42,0x3C,0x00,0x00},

/*--  文字:  9  --*/
/*--  宋体12;  此字体下对应的点阵为：宽x高=8x16   --*/
{0x00,0x00,0x00,0x18,0x24,0x42,0x42,0x42,0x26,0x1A,0x02,0x02,0x24,0x38,0x00,0x00},

/*--  文字:  :  --*/
/*--  宋体12;  此字体下对应的点阵为：宽x高=8x16   --*/
{0x00,0x00,0x00,0x00,0x00,0x00,0x18,0x18,0x00,0x00,0x00,0x00,0x18,0x18,0x00,0x00},

/*--  文字:  ;  --*/
/*--  宋体12;  此字体下对应的点阵为：宽x高=8x16   --*/
{0x00,0x00,0x00,0x00,0x00,0x00,0x00,0x10,0x00,0x00,0x00,0x00,0x00,0x10,0x10,0x20},

/*--  文字:  <  --*/
/*--  宋体12;  此字体下对应的点阵为：宽x高=8x16   --*/
{0x00,0x00,0x00,0x02,0x04,0x08,0x10,0x20,0x40,0x20,0x10,0x08,0x04,0x02,0x00,0x00},

/*--  文字:  =  --*/
/*--  宋体12;  此字体下对应的点阵为：宽x高=8x16   --*/
{0x00,0x00,0x00,0x00,0x00,0x00,0xFE,0x00,0x00,0x00,0xFE,0x00,0x00,0x00,0x00,0x00},

/*--  文字:  >  --*/
/*--  宋体12;  此字体下对应的点阵为：宽x高=8x16   --*/
{0x00,0x00,0x00,0x40,0x20,0x10,0x08,0x04,0x02,0x04,0x08,0x10,0x20,0x40,0x00,0x00},

/*--  文字:  ?  --*/
/*--  宋体12;  此字体下对应的点阵为：宽x高=8x16   --*/
{0x00,0x00,0x00,0x3C,0x42,0x42,0x62,0x02,0x04,0x08,0x08,0x00,0x18,0x18,0x00,0x00},

/*--  文字:  @  --*/
/*--  宋体12;  此字体下对应的点阵为：宽x高=8x16   --*/
{0x00,0x00,0x00,0x38,0x44,0x5A,0xAA,0xAA,0xAA,0xAA,0xB4,0x42,0x44,0x38,0x00,0x00},

/*--  文字:  A  --*/
/*--  宋体12;  此字体下对应的点阵为：宽x高=8x16   --*/
{0x00,0x00,0x00,0x10,0x10,0x18,0x28,0x28,0x24,0x3C,0x44,0x42,0x42,0xE7,0x00,0x00},

/*--  文字:  B  --*/
/*--  宋体12;  此字体下对应的点阵为：宽x高=8x16   --*/
{0x00,0x00,0x00,0xF8,0x44,0x44,0x44,0x78,0x44,0x42,0x42,0x42,0x44,0xF8,0x00,0x00},

/*--  文字:  C  --*/
/*--  宋体12;  此字体下对应的点阵为：宽x高=8x16   --*/
{0x00,0x00,0x00,0x3E,0x42,0x42,0x80,0x80,0x80,0x80,0x80,0x42,0x44,0x38,0x00,0x00},

/*--  文字:  D  --*/
/*--  宋体12;  此字体下对应的点阵为：宽x高=8x16   --*/
{0x00,0x00,0x00,0xF8,0x44,0x42,0x42,0x42,0x42,0x42,0x42,0x42,0x44,0xF8,0x00,0x00},

/*--  文字:  E  --*/
/*--  宋体12;  此字体下对应的点阵为：宽x高=8x16   --*/
{0x00,0x00,0x00,0xFC,0x42,0x48,0x48,0x78,0x48,0x48,0x40,0x42,0x42,0xFC,0x00,0x00},

/*--  文字:  F  --*/
/*--  宋体12;  此字体下对应的点阵为：宽x高=8x16   --*/
{0x00,0x00,0x00,0xFC,0x42,0x48,0x48,0x78,0x48,0x48,0x40,0x40,0x40,0xE0,0x00,0x00},

/*--  文字:  G  --*/
/*--  宋体12;  此字体下对应的点阵为：宽x高=8x16   --*/
{0x00,0x00,0x00,0x3C,0x44,0x44,0x80,0x80,0x80,0x8E,0x84,0x44,0x44,0x38,0x00,0x00},

/*--  文字:  H  --*/
/*--  宋体12;  此字体下对应的点阵为：宽x高=8x16   --*/
{0x00,0x00,0x00,0xE7,0x42,0x42,0x42,0x42,0x7E,0x42,0x42,0x42,0x42,0xE7,0x00,0x00},

/*--  文字:  I  --*/
/*--  宋体12;  此字体下对应的点阵为：宽x高=8x16   --*/
{0x00,0x00,0x00,0x7C,0x10,0x10,0x10,0x10,0x10,0x10,0x10,0x10,0x10,0x7C,0x00,0x00},

/*--  文字:  J  --*/
/*--  宋体12;  此字体下对应的点阵为：宽x高=8x16   --*/
{0x00,0x00,0x00,0x3E,0x08,0x08,0x08,0x08,0x08,0x08,0x08,0x08,0x08,0x08,0x88,0xF0},

/*--  文字:  K  --*/
/*--  宋体12;  此字体下对应的点阵为：宽x高=8x16   --*/
{0x00,0x00,0x00,0xEE,0x44,0x48,0x50,0x70,0x50,0x48,0x48,0x44,0x44,0xEE,0x00,0x00},

/*--  文字:  L  --*/
/*--  宋体12;  此字体下对应的点阵为：宽x高=8x16   --*/
{0x00,0x00,0x00,0xE0,0x40,0x40,0x40,0x40,0x40,0x40,0x40,0x40,0x42,0xFE,0x00,0x00},

/*--  文字:  M  --*/
/*--  宋体12;  此字体下对应的点阵为：宽x高=8x16   --*/
{0x00,0x00,0x00,0xEE,0x6C,0x6C,0x6C,0x6C,0x54,0x54,0x54,0x54,0x54,0xD6,0x00,0x00},

/*--  文字:  N  --*/
/*--  宋体12;  此字体下对应的点阵为：宽x高=8x16   --*/
{0x00,0x00,0x00,0xC7,0x62,0x62,0x52,0x52,0x4A,0x4A,0x4A,0x46,0x46,0xE2,0x00,0x00},

/*--  文字:  O  --*/
/*--  宋体12;  此字体下对应的点阵为：宽x高=8x16   --*/
{0x00,0x00,0x00,0x38,0x44,0x82,0x82,0x82,0x82,0x82,0x82,0x82,0x44,0x38,0x00,0x00},

/*--  文字:  P  --*/
/*--  宋体12;  此字体下对应的点阵为：宽x高=8x16   --*/
{0x00,0x00,0x00,0xFC,0x42,0x42,0x42,0x42,0x7C,0x40,0x40,0x40,0x40,0xE0,0x00,0x00},

/*--  文字:  Q  --*/
/*--  宋体12;  此字体下对应的点阵为：宽x高=8x16   --*/
{0x00,0x00,0x00,0x38,0x44,0x82,0x82,0x82,0x82,0x82,0xB2,0xCA,0x4C,0x38,0x06,0x00},

/*--  文字:  R  --*/
/*--  宋体12;  此字体下对应的点阵为：宽x高=8x16   --*/
{0x00,0x00,0x00,0xFC,0x42,0x42,0x42,0x7C,0x48,0x48,0x44,0x44,0x42,0xE3,0x00,0x00},

/*--  文字:  S  --*/
/*--  宋体12;  此字体下对应的点阵为：宽x高=8x16   --*/
{0x00,0x00,0x00,0x3E,0x42,0x42,0x40,0x20,0x18,0x04,0x02,0x42,0x42,0x7C,0x00,0x00},

/*--  文字:  T  --*/
/*--  宋体12;  此字体下对应的点阵为：宽x高=8x16   --*/
{0x00,0x00,0x00,0xFE,0x92,0x10,0x10,0x10,0x10,0x10,0x10,0x10,0x10,0x38,0x00,0x00},

/*--  文字:  U  --*/
/*--  宋体12;  此字体下对应的点阵为：宽x高=8x16   --*/
{0x00,0x00,0x00,0xE7,0x42,0x42,0x42,0x42,0x42,0x42,0x42,0x42,0x42,0x3C,0x00,0x00},

/*--  文字:  V  --*/
/*--  宋体12;  此字体下对应的点阵为：宽x高=8x16   --*/
{0x00,0x00,0x00,0xE7,0x42,0x42,0x44,0x24,0x24,0x28,0x28,0x18,0x10,0x10,0x00,0x00},

/*--  文字:  W  --*/
/*--  宋体12;  此字体下对应的点阵为：宽x高=8x16   --*/
{0x00,0x00,0x00,0xD6,0x92,0x92,0x92,0x92,0xAA,0xAA,0x6C,0x44,0x44,0x44,0x00,0x00},

/*--  文字:  X  --*/
/*--  宋体12;  此字体下对应的点阵为：宽x高=8x16   --*/
{0x00,0x00,0x00,0xE7,0x42,0x24,0x24,0x18,0x18,0x18,0x24,0x24,0x42,0xE7,0x00,0x00},

/*--  文字:  Y  --*/
/*--  宋体12;  此字体下对应的点阵为：宽x高=8x16   --*/
{0x00,0x00,0x00,0xEE,0x44,0x44,0x28,0x28,0x10,0x10,0x10,0x10,0x10,0x38,0x00,0x00},

/*--  文字:  Z  --*/
/*--  宋体12;  此字体下对应的点阵为：宽x高=8x16   --*/
{0x00,0x00,0x00,0x7E,0x84,0x04,0x08,0x08,0x10,0x20,0x20,0x42,0x42,0xFC,0x00,0x00},

/*--  文字:  [  --*/
/*--  宋体12;  此字体下对应的点阵为：宽x高=8x16   --*/
{0x00,0x1E,0x10,0x10,0x10,0x10,0x10,0x10,0x10,0x10,0x10,0x10,0x10,0x10,0x1E,0x00},

/*--  文字:  \  --*/
/*--  宋体12;  此字体下对应的点阵为：宽x高=8x16   --*/
{0x00,0x00,0x40,0x40,0x20,0x20,0x10,0x10,0x10,0x08,0x08,0x04,0x04,0x04,0x02,0x02},

/*--  文字:  ]  --*/
/*--  宋体12;  此字体下对应的点阵为：宽x高=8x16   --*/
{0x00,0x78,0x08,0x08,0x08,0x08,0x08,0x08,0x08,0x08,0x08,0x08,0x08,0x08,0x78,0x00},

/*--  文字:  ^  --*/
/*--  宋体12;  此字体下对应的点阵为：宽x高=8x16   --*/
{0x00,0x1C,0x22,0x00,0x00,0x00,0x00,0x00,0x00,0x00,0x00,0x00,0x00,0x00,0x00,0x00},

/*--  文字:  _  --*/
/*--  宋体12;  此字体下对应的点阵为：宽x高=8x16   --*/
{0x00,0x00,0x00,0x00,0x00,0x00,0x00,0x00,0x00,0x00,0x00,0x00,0x00,0x00,0x00,0xFF},

/*--  文字:  `  --*/
/*--  宋体12;  此字体下对应的点阵为：宽x高=8x16   --*/
{0x00,0x60,0x10,0x00,0x00,0x00,0x00,0x00,0x00,0x00,0x00,0x00,0x00,0x00,0x00,0x00},

/*--  文字:  a  --*/
/*--  宋体12;  此字体下对应的点阵为：宽x高=8x16   --*/
{0x00,0x00,0x00,0x00,0x00,0x00,0x00,0x3C,0x42,0x1E,0x22,0x42,0x42,0x3F,0x00,0x00},

/*--  文字:  b  --*/
/*--  宋体12;  此字体下对应的点阵为：宽x高=8x16   --*/
{0x00,0x00,0x00,0xC0,0x40,0x40,0x40,0x58,0x64,0x42,0x42,0x42,0x64,0x58,0x00,0x00},

/*--  文字:  c  --*/
/*--  宋体12;  此字体下对应的点阵为：宽x高=8x16   --*/
{0x00,0x00,0x00,0x00,0x00,0x00,0x00,0x1C,0x22,0x40,0x40,0x40,0x22,0x1C,0x00,0x00},

/*--  文字:  d  --*/
/*--  宋体12;  此字体下对应的点阵为：宽x高=8x16   --*/
{0x00,0x00,0x00,0x06,0x02,0x02,0x02,0x1E,0x22,0x42,0x42,0x42,0x26,0x1B,0x00,0x00},

/*--  文字:  e  --*/
/*--  宋体12;  此字体下对应的点阵为：宽x高=8x16   --*/
{0x00,0x00,0x00,0x00,0x00,0x00,0x00,0x3C,0x42,0x7E,0x40,0x40,0x42,0x3C,0x00,0x00},

/*--  文字:  f  --*/
/*--  宋体12;  此字体下对应的点阵为：宽x高=8x16   --*/
{0x00,0x00,0x00,0x0F,0x11,0x10,0x10,0x7E,0x10,0x10,0x10,0x10,0x10,0x7C,0x00,0x00},

/*--  文字:  g  --*/
/*--  宋体12;  此字体下对应的点阵为：宽x高=8x16   --*/
{0x00,0x00,0x00,0x00,0x00,0x00,0x00,0x3E,0x44,0x44,0x38,0x40,0x3C,0x42,0x42,0x3C},

/*--  文字:  h  --*/
/*--  宋体12;  此字体下对应的点阵为：宽x高=8x16   --*/
{0x00,0x00,0x00,0xC0,0x40,0x40,0x40,0x5C,0x62,0x42,0x42,0x42,0x42,0xE7,0x00,0x00},

/*--  文字:  i  --*/
/*--  宋体12;  此字体下对应的点阵为：宽x高=8x16   --*/
{0x00,0x00,0x00,0x30,0x30,0x00,0x00,0x70,0x10,0x10,0x10,0x10,0x10,0x7C,0x00,0x00},

/*--  文字:  j  --*/
/*--  宋体12;  此字体下对应的点阵为：宽x高=8x16   --*/
{0x00,0x00,0x00,0x0C,0x0C,0x00,0x00,0x1C,0x04,0x04,0x04,0x04,0x04,0x04,0x44,0x78},

/*--  文字:  k  --*/
/*--  宋体12;  此字体下对应的点阵为：宽x高=8x16   --*/
{0x00,0x00,0x00,0xC0,0x40,0x40,0x40,0x4E,0x48,0x50,0x68,0x48,0x44,0xEE,0x00,0x00},

/*--  文字:  l  --*/
/*--  宋体12;  此字体下对应的点阵为：宽x高=8x16   --*/
{0x00,0x00,0x00,0x70,0x10,0x10,0x10,0x10,0x10,0x10,0x10,0x10,0x10,0x7C,0x00,0x00},

/*--  文字:  m  --*/
/*--  宋体12;  此字体下对应的点阵为：宽x高=8x16   --*/
{0x00,0x00,0x00,0x00,0x00,0x00,0x00,0xFE,0x49,0x49,0x49,0x49,0x49,0xED,0x00,0x00},

/*--  文字:  n  --*/
/*--  宋体12;  此字体下对应的点阵为：宽x高=8x16   --*/
{0x00,0x00,0x00,0x00,0x00,0x00,0x00,0xDC,0x62,0x42,0x42,0x42,0x42,0xE7,0x00,0x00},

/*--  文字:  o  --*/
/*--  宋体12;  此字体下对应的点阵为：宽x高=8x16   --*/
{0x00,0x00,0x00,0x00,0x00,0x00,0x00,0x3C,0x42,0x42,0x42,0x42,0x42,0x3C,0x00,0x00},

/*--  文字:  p  --*/
/*--  宋体12;  此字体下对应的点阵为：宽x高=8x16   --*/
{0x00,0x00,0x00,0x00,0x00,0x00,0x00,0xD8,0x64,0x42,0x42,0x42,0x44,0x78,0x40,0xE0},

/*--  文字:  q  --*/
/*--  宋体12;  此字体下对应的点阵为：宽x高=8x16   --*/
{0x00,0x00,0x00,0x00,0x00,0x00,0x00,0x1E,0x22,0x42,0x42,0x42,0x22,0x1E,0x02,0x07},

/*--  文字:  r  --*/
/*--  宋体12;  此字体下对应的点阵为：宽x高=8x16   --*/
{0x00,0x00,0x00,0x00,0x00,0x00,0x00,0xEE,0x32,0x20,0x20,0x20,0x20,0xF8,0x00,0x00},

/*--  文字:  s  --*/
/*--  宋体12;  此字体下对应的点阵为：宽x高=8x16   --*/
{0x00,0x00,0x00,0x00,0x00,0x00,0x00,0x3E,0x42,0x40,0x3C,0x02,0x42,0x7C,0x00,0x00},

/*--  文字:  t  --*/
/*--  宋体12;  此字体下对应的点阵为：宽x高=8x16   --*/
{0x00,0x00,0x00,0x00,0x00,0x10,0x10,0x7C,0x10,0x10,0x10,0x10,0x10,0x0C,0x00,0x00},

/*--  文字:  u  --*/
/*--  宋体12;  此字体下对应的点阵为：宽x高=8x16   --*/
{0x00,0x00,0x00,0x00,0x00,0x00,0x00,0xC6,0x42,0x42,0x42,0x42,0x46,0x3B,0x00,0x00},

/*--  文字:  v  --*/
/*--  宋体12;  此字体下对应的点阵为：宽x高=8x16   --*/
{0x00,0x00,0x00,0x00,0x00,0x00,0x00,0xE7,0x42,0x24,0x24,0x28,0x10,0x10,0x00,0x00},

/*--  文字:  w  --*/
/*--  宋体12;  此字体下对应的点阵为：宽x高=8x16   --*/
{0x00,0x00,0x00,0x00,0x00,0x00,0x00,0xD7,0x92,0x92,0xAA,0xAA,0x44,0x44,0x00,0x00},

/*--  文字:  x  --*/
/*--  宋体12;  此字体下对应的点阵为：宽x高=8x16   --*/
{0x00,0x00,0x00,0x00,0x00,0x00,0x00,0x6E,0x24,0x18,0x18,0x18,0x24,0x76,0x00,0x00},

/*--  文字:  y  --*/
/*--  宋体12;  此字体下对应的点阵为：宽x高=8x16   --*/
{0x00,0x00,0x00,0x00,0x00,0x00,0x00,0xE7,0x42,0x24,0x24,0x28,0x18,0x10,0x10,0xE0},

/*--  文字:  z  --*/
/*--  宋体12;  此字体下对应的点阵为：宽x高=8x16   --*/
{0x00,0x00,0x00,0x00,0x00,0x00,0x00,0x7E,0x44,0x08,0x10,0x10,0x22,0x7E,0x00,0x00},

/*--  文字:  {  --*/
/*--  宋体12;  此字体下对应的点阵为：宽x高=8x16   --*/
{0x00,0x03,0x04,0x04,0x04,0x04,0x04,0x08,0x04,0x04,0x04,0x04,0x04,0x04,0x03,0x00},

/*--  文字:  |  --*/
/*--  宋体12;  此字体下对应的点阵为：宽x高=8x16   --*/
{0x08,0x08,0x08,0x08,0x08,0x08,0x08,0x08,0x08,0x08,0x08,0x08,0x08,0x08,0x08,0x08},

/*--  文字:  }  --*/
/*--  宋体12;  此字体下对应的点阵为：宽x高=8x16   --*/
{0x00,0x60,0x10,0x10,0x10,0x10,0x10,0x08,0x10,0x10,0x10,0x10,0x10,0x10,0x60,0x00},

/*--  文字:  ~  --*/
/*--  宋体12;  此字体下对应的点阵为：宽x高=8x16   --*/
{0x30,0x4C,0x43,0x00,0x00,0x00,0x00,0x00,0x00,0x00,0x00,0x00,0x00,0x00,0x00,0x00},

};




private static readonly byte[,] FONT24x32 = new byte[,]
{

                /*  0  */
  {
   ________,_XXXXXXX,________,
   _______X,XXXXXXXX,XX______,
   ______XX,XXXXXXXX,XXX_____,
   _____XXX,XXXXXXXX,XXXX____,
   ____XXXX,XXX___XX,XXXXX___,
   ____XXXX,X_______,XXXXX___,
   ___XXXXX,________,_XXXXX__,
   ___XXXXX,________,_XXXXX__,
   ___XXXXX,________,_XXXXX__,
   __XXXXX_,________,__XXXXX_,
   __XXXXX_,________,__XXXXX_,
   __XXXXX_,________,__XXXXX_,
   __XXXXX_,________,__XXXXX_,
   __XXXXX_,________,__XXXXX_,
   __XXXXX_,________,__XXXXX_,
   __XXXXX_,________,__XXXXX_,
   __XXXXX_,________,__XXXXX_,
   __XXXXX_,________,__XXXXX_,
   __XXXXX_,________,__XXXXX_,
   __XXXXX_,________,__XXXXX_,
   __XXXXX_,________,__XXXXX_,
   __XXXXX_,________,__XXXXX_,
   __XXXXX_,________,__XXXXX_,
   ___XXXXX,________,_XXXXX__,
   ___XXXXX,________,_XXXXX__,
   ___XXXXX,________,_XXXXX__,
   ____XXXX,X_______,XXXXX___,
   ____XXXX,XXX___XX,XXXXX___,
   _____XXX,XXXXXXXX,XXXX____,
   ______XX,XXXXXXXX,XXX_____,
   _______X,XXXXXXXX,XX______,
   ________,_XXXXXXX,________}

/*  1  */
 ,{
   ________,______XX,XX______,
   ________,______XX,XX______,
   ________,_____XXX,XX______,
   ________,_____XXX,XX______,
   ________,____XXXX,XX______,
   ________,__XXXXXX,XX______,
   ______XX,XXXXXXXX,XX______,
   ______XX,XXXXXXXX,XX______,
   ______XX,XXXXXXXX,XX______,
   ______XX,XXXXXXXX,XX______,
   ________,_____XXX,XX______,
   ________,_____XXX,XX______,
   ________,_____XXX,XX______,
   ________,_____XXX,XX______,
   ________,_____XXX,XX______,
   ________,_____XXX,XX______,
   ________,_____XXX,XX______,
   ________,_____XXX,XX______,
   ________,_____XXX,XX______,
   ________,_____XXX,XX______,
   ________,_____XXX,XX______,
   ________,_____XXX,XX______,
   ________,_____XXX,XX______,
   ________,_____XXX,XX______,
   ________,_____XXX,XX______,
   ________,_____XXX,XX______,
   ________,_____XXX,XX______,
   ________,_____XXX,XX______,
   ________,_____XXX,XX______,
   ________,_____XXX,XX______,
   ________,_____XXX,XX______,
   ________,_____XXX,XX______}

/*  2  */
 ,{
   ________,_XXXXXXX,X_______,
   _______X,XXXXXXXX,XXX_____,
   ______XX,XXXXXXXX,XXXX____,
   _____XXX,XXXXXXXX,XXXXX___,
   ____XXXX,XXX____X,XXXXXX__,
   ___XXXXX,X_______,XXXXXX__,
   ___XXXXX,________,_XXXXXX_,
   __XXXXX_,________,__XXXXX_,
   __XXXXX_,________,__XXXXX_,
   __XXXXX_,________,__XXXXX_,
   ________,________,__XXXXX_,
   ________,________,__XXXXX_,
   ________,________,__XXXXX_,
   ________,________,_XXXXXX_,
   ________,________,XXXXXX__,
   ________,_______X,XXXXXX__,
   ________,_____XXX,XXXXX___,
   ________,____XXXX,XXX_____,
   ________,__XXXXXX,XX______,
   ________,_XXXXXXX,X_______,
   _______X,XXXXXXX_,________,
   ______XX,XXXXXX__,________,
   _____XXX,XXXX____,________,
   ____XXXX,XXX_____,________,
   ____XXXX,XX______,________,
   ___XXXXX,X_______,________,
   ___XXXXX,________,________,
   __XXXXXX,XXXXXXXX,XXXXXXX_,
   __XXXXXX,XXXXXXXX,XXXXXXX_,
   __XXXXXX,XXXXXXXX,XXXXXXX_,
   __XXXXXX,XXXXXXXX,XXXXXXX_,
   __XXXXXX,XXXXXXXX,XXXXXXX_}

/*  3  */
 ,{
   ________,_XXXXXX_,________,
   ______XX,XXXXXXXX,XX______,
   _____XXX,XXXXXXXX,XXX_____,
   ____XXXX,XXXXXXXX,XXXX____,
   ___XXXXX,X______X,XXXXX___,
   ___XXXXX,________,XXXXX___,
   __XXXXX_,________,XXXXXX__,
   __XXXXX_,________,_XXXXX__,
   __XXXXX_,________,_XXXXX__,
   __XXXXX_,________,_XXXXX__,
   ________,________,XXXXX___,
   ________,________,XXXXX___,
   ________,_______X,XXXX____,
   ________,__XXXXXX,XXX_____,
   ________,__XXXXXX,XX______,
   ________,__XXXXXX,XXX_____,
   ________,__XXXXXX,XXXXX___,
   ________,_______X,XXXXXX__,
   ________,________,_XXXXX__,
   ________,________,_XXXXXX_,
   ________,________,__XXXXX_,
   ________,________,__XXXXX_,
   _XXXXX__,________,__XXXXX_,
   _XXXXX__,________,__XXXXX_,
   _XXXXX__,________,_XXXXXX_,
   __XXXXX_,________,_XXXXX__,
   __XXXXXX,________,XXXXXX__,
   ___XXXXX,X______X,XXXXX___,
   ____XXXX,XXXXXXXX,XXXX____,
   _____XXX,XXXXXXXX,XXX_____,
   ______XX,XXXXXXXX,XX______,
   ________,_XXXXXX_,________}

/*  4  */
 ,{
   ________,_______X,XXXX____,
   ________,______XX,XXXX____,
   ________,_____XXX,XXXX____,
   ________,_____XXX,XXXX____,
   ________,____XXXX,XXXX____,
   ________,___XXXXX,XXXX____,
   ________,___XXXX_,XXXX____,
   ________,__XXXXX_,XXXX____,
   ________,_XXXXX__,XXXX____,
   ________,_XXXX___,XXXX____,
   ________,XXXXX___,XXXX____,
   _______X,XXXX____,XXXX____,
   _______X,XXX_____,XXXX____,
   ______XX,XXX_____,XXXX____,
   _____XXX,XX______,XXXX____,
   _____XXX,X_______,XXXX____,
   ____XXXX,X_______,XXXX____,
   ___XXXXX,________,XXXX____,
   ___XXXX_,________,XXXX____,
   __XXXXX_,________,XXXX____,
   __XXXXXX,XXXXXXXX,XXXXXXXX,
   __XXXXXX,XXXXXXXX,XXXXXXXX,
   __XXXXXX,XXXXXXXX,XXXXXXXX,
   __XXXXXX,XXXXXXXX,XXXXXXXX,
   ________,________,XXXX____,
   ________,________,XXXX____,
   ________,________,XXXX____,
   ________,________,XXXX____,
   ________,________,XXXX____,
   ________,________,XXXX____,
   ________,________,XXXX____,
   ________,________,XXXX____}

/*  5  */
 ,{
   _____XXX,XXXXXXXX,XXXXXX__,
   _____XXX,XXXXXXXX,XXXXXX__,
   _____XXX,XXXXXXXX,XXXXXX__,
   _____XXX,XXXXXXXX,XXXXXX__,
   ____XXXX,X_______,________,
   ____XXXX,X_______,________,
   ____XXXX,X_______,________,
   ____XXXX,X_______,________,
   ____XXXX,________,________,
   ____XXXX,________,________,
   ____XXXX,___XXXXX,________,
   ____XXXX,_XXXXXXX,XXX_____,
   ____XXXX,XXXXXXXX,XXXX____,
   ___XXXXX,XXXXXXXX,XXXXX___,
   ___XXXXX,XXX____X,XXXXXX__,
   ___XXXXX,X_______,_XXXXXX_,
   ___XXXXX,________,__XXXXX_,
   ________,________,__XXXXXX,
   ________,________,___XXXXX,
   ________,________,___XXXXX,
   ________,________,___XXXXX,
   ________,________,___XXXXX,
   ________,________,___XXXXX,
   __XXXXX_,________,__XXXXXX,
   __XXXXX_,________,__XXXXX_,
   ___XXXXX,________,_XXXXXX_,
   ___XXXXX,X_______,XXXXXX__,
   ____XXXX,XX____XX,XXXXXX__,
   _____XXX,XXXXXXXX,XXXXX___,
   ______XX,XXXXXXXX,XXXX____,
   _______X,XXXXXXXX,XX______,
   ________,__XXXXX_,________}

/*  6  */
 ,{
   ________,__XXXXXX,XX______,
   ________,XXXXXXXX,XXXX____,
   _______X,XXXXXXXX,XXXXX___,
   ______XX,XXXXXXXX,XXXXXX__,
   _____XXX,XXX_____,_XXXXX__,
   ____XXXX,XX______,__XXXXX_,
   ____XXXX,X_______,___XXXX_,
   ___XXXXX,________,___XXXX_,
   ___XXXXX,________,________,
   ___XXXXX,________,________,
   __XXXXX_,________,________,
   __XXXXX_,___XXXXX,________,
   __XXXXX_,_XXXXXXX,XXX_____,
   __XXXXX_,XXXXXXXX,XXXX____,
   __XXXXXX,XXXXXXXX,XXXXX___,
   __XXXXXX,XX______,XXXXXX__,
   __XXXXXX,X_______,_XXXXXX_,
   __XXXXXX,________,__XXXXX_,
   __XXXXXX,________,___XXXXX,
   __XXXXX_,________,___XXXXX,
   __XXXXX_,________,___XXXXX,
   __XXXXX_,________,___XXXXX,
   ___XXXX_,________,___XXXXX,
   ___XXXXX,________,___XXXXX,
   ___XXXXX,________,___XXXXX,
   ____XXXX,X_______,__XXXXX_,
   ____XXXX,X_______,_XXXXXX_,
   _____XXX,XXX_____,XXXXXX__,
   ______XX,XXXXXXXX,XXXXX___,
   _______X,XXXXXXXX,XXXX____,
   ________,XXXXXXXX,XXX_____,
   ________,___XXXXX,________}

/*  7  */
 ,{
   __XXXXXX,XXXXXXXX,XXXXXXXX,
   __XXXXXX,XXXXXXXX,XXXXXXXX,
   __XXXXXX,XXXXXXXX,XXXXXXXX,
   __XXXXXX,XXXXXXXX,XXXXXXXX,
   __XXXXXX,XXXXXXXX,XXXXXXXX,
   ________,________,___XXXXX,
   ________,________,__XXXXX_,
   ________,________,_XXXXX__,
   ________,________,XXXXX___,
   ________,_______X,XXXX____,
   ________,______XX,XXX_____,
   ________,_____XXX,XXX_____,
   ________,_____XXX,XX______,
   ________,____XXXX,XX______,
   ________,___XXXXX,X_______,
   ________,___XXXXX,X_______,
   ________,__XXXXXX,________,
   ________,__XXXXXX,________,
   ________,_XXXXXX_,________,
   ________,_XXXXXX_,________,
   ________,_XXXXXX_,________,
   ________,XXXXXX__,________,
   ________,XXXXXX__,________,
   ________,XXXXXX__,________,
   _______X,XXXXX___,________,
   _______X,XXXXX___,________,
   _______X,XXXXX___,________,
   _______X,XXXXX___,________,
   ______XX,XXXX____,________,
   ______XX,XXXX____,________,
   ______XX,XXXX____,________,
   ______XX,XXXX____,________}

/*  8  */
 ,{
   ________,_XXXXXXX,X_______,
   _______X,XXXXXXXX,XXX_____,
   _____XXX,XXXXXXXX,XXXXX___,
   ____XXXX,XXXXXXXX,XXXXXX__,
   ____XXXX,XX______,XXXXXX__,
   ___XXXXX,X_______,_XXXXXX_,
   ___XXXXX,________,__XXXXX_,
   ___XXXXX,________,__XXXXX_,
   ___XXXXX,________,__XXXXX_,
   ___XXXXX,________,__XXXXX_,
   ___XXXXX,X_______,_XXXXXX_,
   ____XXXX,X_______,_XXXXX__,
   ____XXXX,XXX____X,XXXXXX__,
   _____XXX,XXXXXXXX,XXXXX___,
   _______X,XXXXXXXX,XXX_____,
   ______XX,XXXXXXXX,XXXX____,
   ____XXXX,XXXXXXXX,XXXXXX__,
   ___XXXXX,XXX____X,XXXXXXX_,
   ___XXXXX,________,__XXXXX_,
   __XXXXX_,________,___XXXXX,
   __XXXXX_,________,___XXXXX,
   __XXXXX_,________,___XXXXX,
   __XXXXX_,________,___XXXXX,
   __XXXXX_,________,___XXXXX,
   __XXXXX_,________,___XXXXX,
   __XXXXXX,________,__XXXXXX,
   ___XXXXX,________,__XXXXX_,
   ___XXXXX,XX______,XXXXXXX_,
   ____XXXX,XXXXXXXX,XXXXXX__,
   _____XXX,XXXXXXXX,XXXXX___,
   ______XX,XXXXXXXX,XXXX____,
   ________,XXXXXXXX,XX______}

/*  9  */
 ,{
   ________,_XXXXXXX,X_______,
   _______X,XXXXXXXX,XXX_____,
   ______XX,XXXXXXXX,XXXX____,
   _____XXX,XXXXXXXX,XXXXX___,
   ____XXXX,XX______,XXXXXX__,
   ___XXXXX,X_______,_XXXXX__,
   ___XXXXX,________,__XXXXX_,
   ___XXXX_,________,__XXXXX_,
   __XXXXX_,________,___XXXXX,
   __XXXXX_,________,___XXXXX,
   __XXXXX_,________,___XXXXX,
   __XXXXX_,________,___XXXXX,
   __XXXXX_,________,___XXXXX,
   ___XXXX_,________,__XXXXXX,
   ___XXXXX,________,__XXXXXX,
   ___XXXXX,X_______,_XXXXXXX,
   ____XXXX,XX_____X,XXXXXXXX,
   _____XXX,XXXXXXXX,XXXXXXXX,
   ______XX,XXXXXXXX,XX_XXXXX,
   ________,XXXXXXXX,___XXXXX,
   ________,__XXXX__,___XXXXX,
   ________,________,__XXXXXX,
   ________,________,__XXXXX_,
   ________,________,__XXXXX_,
   __XXXXX_,________,_XXXXXX_,
   __XXXXX_,________,_XXXXX__,
   ___XXXXX,________,XXXXX___,
   ___XXXXX,X______X,XXXXX___,
   ____XXXX,XXXXXXXX,XXXX____,
   _____XXX,XXXXXXXX,XXX_____,
   ______XX,XXXXXXXX,XX______,
   ________,XXXXXXXX,________}

/*  .  */
 ,{
   ________,________,________,
   ________,________,________,
   ________,________,________,
   ________,________,________,
   ________,________,________,
   ________,________,________,
   ________,________,________,
   ________,________,________,
   ________,________,________,
   ________,________,________,
   ________,________,________,
   ________,________,________,
   ________,________,________,
   ________,________,________,
   ________,________,________,
   ________,________,________,
   ________,________,________,
   ________,________,________,
   ________,________,________,
   ________,________,________,
   ________,________,________,
   ________,________,________,
   ________,________,________,
   ________,________,________,
   ________,________,________,
   ________,________,________,
   ________,________,________,
   ________,___XXX__,________,
   ________,__XXXXX_,________,
   ________,__XXXXX_,________,
   ________,__XXXXX_,________,
   ________,___XXX__,________}

/*  +  */
 ,{
   ________,________,________,
   ________,________,________,
   ________,________,________,
   ________,________,________,
   ________,________,________,
   ________,________,________,
   ________,________,________,
   ________,________,________,
   ________,__XXXX__,________,
   ________,__XXXX__,________,
   ________,__XXXX__,________,
   ________,__XXXX__,________,
   ________,__XXXX__,________,
   ________,__XXXX__,________,
   ________,__XXXX__,________,
   __XXXXXX,XXXXXXXX,XXXXXX__,
   __XXXXXX,XXXXXXXX,XXXXXX__,
   __XXXXXX,XXXXXXXX,XXXXXX__,
   __XXXXXX,XXXXXXXX,XXXXXX__,
   ________,__XXXX__,________,
   ________,__XXXX__,________,
   ________,__XXXX__,________,
   ________,__XXXX__,________,
   ________,__XXXX__,________,
   ________,__XXXX__,________,
   ________,__XXXX__,________,
   ________,________,________,
   ________,________,________,
   ________,________,________,
   ________,________,________,
   ________,________,________,
   ________,________,________}

/*  -  */
 ,{
   ________,________,________,
   ________,________,________,
   ________,________,________,
   ________,________,________,
   ________,________,________,
   ________,________,________,
   ________,________,________,
   ________,________,________,
   ________,________,________,
   ________,________,________,
   ________,________,________,
   ________,________,________,
   ________,________,________,
   ________,________,________,
   ________,________,________,
   __XXXXXX,XXXXXXXX,XXXXXX__,
   __XXXXXX,XXXXXXXX,XXXXXX__,
   __XXXXXX,XXXXXXXX,XXXXXX__,
   __XXXXXX,XXXXXXXX,XXXXXX__,
   ________,________,________,
   ________,________,________,
   ________,________,________,
   ________,________,________,
   ________,________,________,
   ________,________,________,
   ________,________,________,
   ________,________,________,
   ________,________,________,
   ________,________,________,
   ________,________,________,
   ________,________,________,
   ________,________,________}

/*  :  */
 ,{
   ________,________,________,
   ________,________,________,
   ________,________,________,
   ________,________,________,
   ________,________,________,
   ________,________,________,
   ________,________,________,
   ________,________,________,
   ________,________,________,
   ________,________,________,
   ________,________,________,
   ________,________,________,
   ________,___XXX__,________,
   ________,__XXXXX_,________,
   ________,__XXXXX_,________,
   ________,__XXXXX_,________,
   ________,___XXX__,________,
   ________,________,________,
   ________,________,________,
   ________,________,________,
   ________,___XXX__,________,
   ________,__XXXXX_,________,
   ________,__XXXXX_,________,
   ________,__XXXXX_,________,
   ________,___XXX__,________,
   ________,________,________,
   ________,________,________,
   ________,________,________,
   ________,________,________,
   ________,________,________,
   ________,________,________,
   ________,________,________}
   
/*  空格  */   
 ,{
   ________,________,________,
   ________,________,________,
   ________,________,________,
   ________,________,________,
   ________,________,________,
   ________,________,________,
   ________,________,________,
   ________,________,________,
   ________,________,________,
   ________,________,________,
   ________,________,________,
   ________,________,________,
   ________,________,________,
   ________,________,________,
   ________,________,________,
   ________,________,________,
   ________,________,________,
   ________,________,________,
   ________,________,________,
   ________,________,________,
   ________,________,________,
   ________,________,________,
   ________,________,________,
   ________,________,________,
   ________,________,________,
   ________,________,________,
   ________,________,________,
   ________,________,________,
   ________,________,________,
   ________,________,________,
   ________,________,________,
   ________,________,________}


            };

        /// <summary>
        /// *--  宽度x高度=49x14  --*
        /// </summary>
        private static readonly byte[] button_ok = new byte[]
        {
            0x07,0xFF,0xFF,0xFF,0xFF,0xF0,0x00,0x18,0x00,0x00,0x00,0x00,0x0C,0x00,0x20,0x00,
            0x00,0x00,0x00,0x02,0x00,0x40,0x00,0x0E,0x76,0x00,0x01,0x00,0x80,0x00,0x11,0x24,
            0x00,0x00,0x80,0x80,0x00,0x11,0x28,0x00,0x00,0x80,0x80,0x00,0x11,0x30,0x00,0x00,
            0x80,0x80,0x00,0x11,0x28,0x00,0x00,0x80,0x80,0x00,0x11,0x28,0x00,0x00,0x80,0x80,
            0x00,0x11,0x24,0x00,0x00,0x80,0x40,0x00,0x0E,0x76,0x00,0x01,0x00,0x20,0x00,0x00,
            0x00,0x00,0x02,0x00,0x18,0x00,0x00,0x00,0x00,0x0C,0x00,0x07,0xFF,0xFF,0xFF,0xFF,
            0xF0,0x00
        };


        /// <summary>
        ///*--  宽度x高度=49x14  --* 
        /// </summary>
        private static readonly byte[] button_ok1 = new byte[]
    {
        0x00,0x00,0x00,0x00,0x00,0x00,0x00,0x07,0xFF,0xFF,0xFF,0xFF,0xF0,0x00,0x1F,0xFF,
        0xFF,0xFF,0xFF,0xFC,0x00,0x3F,0xFF,0xF1,0x89,0xFF,0xFE,0x00,0x7F,0xFF,0xEE,0xDB,
        0xFF,0xFF,0x00,0x7F,0xFF,0xEE,0xD7,0xFF,0xFF,0x00,0x7F,0xFF,0xEE,0xCF,0xFF,0xFF,
        0x00,0x7F,0xFF,0xEE,0xD7,0xFF,0xFF,0x00,0x7F,0xFF,0xEE,0xD7,0xFF,0xFF,0x00,0x7F,
        0xFF,0xEE,0xDB,0xFF,0xFF,0x00,0x3F,0xFF,0xF1,0x89,0xFF,0xFE,0x00,0x1F,0xFF,0xFF,
        0xFF,0xFF,0xFC,0x00,0x07,0xFF,0xFF,0xFF,0xFF,0xF0,0x00,0x00,0x00,0x00,0x00,0x00,
        0x00,0x00
    };



        /// <summary>
        ///宽度x高度=49x14  --*/ 
        /// </summary>
        private static readonly byte[] button_cancle =
       {
0x07,0xFF,0xFF,0xFF,0xFF,0xF0,0x00,0x18,0x00,0x00,0x00,0x00,0x0C,0x00,0x20,0x00,
0x00,0x00,0x00,0x02,0x00,0x40,0xF0,0x00,0x00,0x07,0x01,0x00,0x81,0x10,0x00,0x00,
0x01,0x00,0x80,0x81,0x00,0x00,0x00,0x01,0x00,0x80,0x81,0x01,0x9E,0x1C,0x61,0x00,
0x80,0x81,0x02,0x49,0x24,0x91,0x00,0x80,0x81,0x01,0xC9,0x20,0xF1,0x00,0x80,0x81,
0x12,0x49,0x20,0x81,0x00,0x80,0x40,0xE1,0xFD,0x9C,0x77,0xC1,0x00,0x20,0x00,0x00,
0x00,0x00,0x02,0x00,0x18,0x00,0x00,0x00,0x00,0x0C,0x00,0x07,0xFF,0xFF,0xFF,0xFF,
0xF0,0x00
};





        /// <summary>
        ///宽度x高度=49x14 
        /// </summary>
private static readonly byte[] button_cancle1 =
{
0x00,0x00,0x00,0x00,0x00,0x00,0x00,0x07,0xFF,0xFF,0xFF,0xFF,0xF0,0x00,0x1F,0xFF,
0xFF,0xFF,0xFF,0xFC,0x00,0x3F,0x0F,0xFF,0xFF,0xF8,0xFE,0x00,0x7E,0xEF,0xFF,0xFF,
0xFE,0xFF,0x00,0x7E,0xFF,0xFF,0xFF,0xFE,0xFF,0x00,0x7E,0xFE,0x61,0xE3,0x9E,0xFF,
0x00,0x7E,0xFD,0xB6,0xDB,0x6E,0xFF,0x00,0x7E,0xFE,0x36,0xDF,0x0E,0xFF,0x00,0x7E,
0xED,0xB6,0xDF,0x7E,0xFF,0x00,0x3F,0x1E,0x02,0x63,0x88,0x3E,0x00,0x1F,0xFF,0xFF,
0xFF,0xFF,0xFC,0x00,0x07,0xFF,0xFF,0xFF,0xFF,0xF0,0x00,0x00,0x00,0x00,0x00,0x00,
0x00,0x00
};


public static readonly byte[] ICO1 =
{
    0x80,0x00,0x00,0x00,0x80,0x00,0x00,0x00,0x10,0x00,0x00,0x00,0x00,0x00,0x00,0x00,
    0x00,0x00,0x00,0x00,0x00,0x00,0x00,0x00,0x00,0x00,0x00,0x80,0x00,0x00,0x04,0x00,
    0x40,0x80,0x00,0x00,0x00,0x00,0x00,0x00,0x00,0x00,0x00,0x00,0x00,0x00,0x00,0x00,
    0x00,0x00,0x00,0x00,0x00,0x02,0x00,0x08,0x00,0x00,0x00,0x00,0x01,0x00,0x00,0x00,
    0x00,0x00,0x00,0x10,0x04,0x00,0x00,0x00,0x02,0x00,0x00,0x00,0x00,0x00,0x10,0x00,
    0x00,0x00,0x10,0x00,0x00,0x10,0x00,0x00,0x00,0x00,0x40,0x00,0x00,0x00,0x00,0x00,
    0x00,0x00,0x00,0x00,0x00,0x00,0x00,0x00,0x00,0x00,0x00,0x00,0x00,0x00,0x00,0x00,
    0x00,0x00,0x00,0x00,0x00,0x00,0x00,0x00,0x00,0x00,0x00,0x00,0x00,0x00,0x00,0x00,
};

        public static readonly byte[] Title_ICO1 =
 {               0x00,0x00,0x00,0x00,0x00,0x01,0x10,0x00,0x00,0x00,0x00,0x00,0x00,0x00,0x00,0x00,
0x00,0x00,0x00,0x00,0x00,0x00,0x00,0x08,0x00,0x00,0x00,0x40,0x00,0x00,0x00,0x00,
0x00,0x00,0x00,0x00,0x01,0x00,0x04,0x00,0x08,0x00,0x00,0x00,0x00,0x00,0x04,0x00,
0x00,0x08,0x00,0x00,0x00,0x00,0x00,0x00,0x00,0x00,0x00,0x00,0x00,0x00,0x00,0x00,
0x00,0x00,0x00,0x00,0x00,0x00,0x00,0x18,0x00,0x00,0x00,0x00,0x00,0x00,

  };




    }
}
