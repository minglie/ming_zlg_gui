/****************************************************************************
* 文件名：LCMDRV.C
* 功能：MG12864图形液晶模块驱动程序。使用LPC2131的GPIO口控制操作。
*       用于ZLG/GUI用户图形界面。
* 液晶模块与LPC2131的连接如下所示：
*	D0 (7)	--		P0.4
*	.		--		.
*	.		--		.
*	.		--		.
*	D7 (14)	--		P0.11
*
*  	CS1		--		P0.12
*	CS2		--		P0.13
*	
*   RST     --      P0.14
*	D/I		--		P0.15
*	R/W		--		GND
*	E		--		P0.16
*
*  R/W为0进行写操作，为1时进行读操作；
*  D/I为1表示数据传送， 为0表示命令传送；
*  E读写脉冲；
*  CS1和CS2为左右半屏选择，高电平选中；
*  RST为复位控制，低电平复位。
*  
*  作者：黄绍斌
*  日期：2005/3/7
****************************************************************************/
#include 	"config.h"
#define		LCM_BUS     P1                                             
#define  	LCM_DI 		P3_0                                        
#define    	LCM_RW     	P3_1                                         
#define   	LCM_E      	P3_2                                         
#define    	LCM_CS1   	P3_4                                           
#define   	LCM_CS2   	P3_3                                        
#define  	LCM_RST     P3_5       
//================================================================
//  KS0108指令代码定义
//================================================================
//#define  Set_Disp_On 	0x3F
//#define  Set_Disp_Off 	0x3E
//#define  Set_Column  	0x40
//#define  Set_Page  		0xB8
//#define  Set_Start_Line 0xC0




/* 定义显示缓冲区 */
TCOLOR  gui_disp_buf[GUI_LCM_YMAX/8][GUI_LCM_XMAX];


/* 定义总线起始的GPIO，即D0对应的GPIO值(P0.4) */
#define  BUS_NO		4

/* 输出总线数据宏定义 */
#define	 OutData(dat)	LCM_BUS= dat


/* 定义CS1控制 */
#define  SCS1()		LCM_CS1=1
#define  CCS1()		LCM_CS1=0

/* 定义CS2控制 */
#define  SCS2()		LCM_CS2=1
#define  CCS2()		LCM_CS2=0

/* 定义RST控制 */

#define  SRST()		LCM_RST=1
#define  CRST()		LCM_RST=0


/* 定义DI控制 */
#define  SDI()		LCM_DI=1
#define  CDI()		LCM_DI=0


/* 定义E控制 */

#define  SE()		LCM_E=1
#define  CE()		LCM_E=0

/*定义RW控制*/
#define  SRW()		LCM_RW=1;
#define  CRW()		LCM_RW=0;
/* 定义LCM操作的命令字 */
#define	LCM_DISPON			0x3F	/* 打开LCM显示												 	*/
#define	LCM_DISPOFF			0x3E	/* 关闭LCM显示										    		*/
#define LCM_STARTROW		0xc0	/* 显示起始行0，可以用LCM_STARTROW+x设置起始行。(x<64) 	    	*/
#define	LCM_ADDRSTRX		0xb8	/* 页起始地址，可以用LCM_ADDRSTRX+x设置当前页(即X)。(x<8)		*/
#define	LCM_ADDRSTRY		0x40	/* 列起始地址，可以用LCM_ADDRSTRY+x设置当前列(即Y)。(y<64)		*/	


/*********************************************************************************
* 名称：DELAY5()
* 功能：软件延时函数。用于LCM显示输出时序控制。
* 入口参数：无
* 出口参数：无
**********************************************************************************/
void DELAY5(void)
{ int i;

  for(i=0; i<10; i++);
}


/***********************************************************************
* 名称：LCM_WrCommand()
* 功能：写命令子程序
* 入口参数：command  	要写入LCM的命令字
* 注：数据口为P0口(作IO口)
***********************************************************************/
void LCM_WrCommand(uint8 command) 
{ 
	CE();				// 先将E置为低					
  	CDI();			// DI=0，表示发送命令
	CRW();				
          
  	OutData(command);           
  //	DELAY5();     
  	SE();
  //	DELAY5();     
  	CE();
  //	DELAY5();
	 
}


/***********************************************************************
* 名称：LCM_WrData()
* 功能：写数据子程序
* 入口参数：wrdata  	要写入LCM的数据
***********************************************************************/
void LCM_WrData(uint8 wrdata) 
{ 
	CE();			// 先将E置为低	
  	SDI();		// DI=1，表示发送数据	
    CRW();     
  	OutData(wrdata);       
  	//DELAY5();     
  	SE();
  	//DELAY5();     
  	CE();     
  	//DELAY5(); 
       
}


/***********************************************************************
* 名称：LCM_WriteByte()
* 功能：向指定点写数据(一字节)。
* 入口参数：x 		x坐标值(0-127)
*	    	y       y坐标值(0-63)
*           wrdata	所要写的数据
* 说明：会重新设置CS1/CS2，及其内部指针
***********************************************************************/
void LCM_WriteByte(uint8 x, uint8 y, uint8 wrdata) 
{ 
	x = x&0x7f;				// 参数过滤
  y = y&0x3f;
  CCS1();
  CCS2();
  //更新显示缓冲区
  y = y>>3;
  gui_disp_buf[y][x] = wrdata;
   
  // 更新LCD显示
  if(x<64)					// 选择液晶控制芯片(即CS1--控制前64个点，CS2--控制后64个点)
  { SCS1();  
  }
  else
  { SCS2();
    x = x-64;
  }
  LCM_WrCommand(LCM_ADDRSTRY+x);	// 设置当前列地址，即x坐标
  LCM_WrCommand(LCM_ADDRSTRX+y);	// 设置当前页地址，即y坐标

  LCM_WrData(wrdata);
}


/***********************************************************************
* 名称：LCM_ReadByte()
* 功能：读取指定点上的数据。
* 入口参数：x 	  x坐标值(0-127)
*	   	    y     y坐标值(0-63)
* 出口参数：返回该点上的字节数据。
***********************************************************************/
uint8  LCM_ReadByte(uint8 x, uint8 y)
{ x = x&0x7f;				// 参数过滤
  y = y&0x3f;

  y = y>>3;
  return(gui_disp_buf[y][x]);
}



/////////////////////////////////////////////////////////////////////////


/***********************************************************************
* 名称：LCM_DispFill()
* 功能：向显示缓冲区填充数据
* 入口参数：filldata  	要写入LCM的填充数据
* 注：此函数会设置显示起始行为0，且会自动选中CS1有效
***********************************************************************/
void LCM_DispFill(uint8 filldata)
{ uint8  x,y;

  SCS1();			// 选中两个控制芯片	
  CCS2();
	
  LCM_WrCommand(LCM_STARTROW);		// 设置显示起始行为0

  for(x=0; x<8; x++)
  { LCM_WrCommand(LCM_ADDRSTRX+x);	// 设置页地址，即X
  	LCM_WrCommand(LCM_ADDRSTRY);	// 设置列地址，即Y
    for(y=0; y<64; y++)
    { LCM_WrData(filldata);
	}	
  }

  SCS2();
  CCS1();
  LCM_WrCommand(LCM_STARTROW);		// 设置显示起始行为0

  for(x=0; x<8; x++)
  { LCM_WrCommand(LCM_ADDRSTRX+x);	// 设置页地址，即X
  	LCM_WrCommand(LCM_ADDRSTRY);	// 设置列地址，即Y
    for(y=0; y<64; y++)
    { LCM_WrData(filldata);
	}	
  }
}

    
/***********************************************************************
* 名称：LCM_DispIni()
* 功能：LCM显示初始化
* 入口参数：无
* 出口参数：无
* 注：初化显示后，清屏并设置显示起始行为0
*     会复位LCM_DISPCX，LCM_DISPCY.(并会只选中CS1)
***********************************************************************/
void LCM_DispIni(void)
{ uint32  i;

    // 设置引脚连接模块

  // 复位LCM
//  CRST();				
//  for(i=0; i<5000; i++);
//  SRST();   
//  for(i=0; i<5000; i++); 

 // SCS1();					// 选中两个控制芯片	
  //SCS2();  

  LCM_WrCommand(LCM_DISPOFF);	// 打开显示	
  LCM_WrCommand(LCM_STARTROW);	// 设置显示起始行为0
        
  LCM_WrCommand(LCM_ADDRSTRX);	// 设置页地址，即X	
  LCM_WrCommand(LCM_ADDRSTRY);	// 设置列地址，即Y
  LCM_WrCommand(LCM_DISPON);	// 打开显示		
}



/////////////////////////////////////////////////////////////////////////////


/****************************************************************************
* 名称：GUI_FillSCR()
* 功能：全屏填充。直接使用数据填充显示缓冲区。
* 入口参数：dat		填充的数据
* 出口参数：无
* 说明：用户根据LCM的实际情况编写此函数。
****************************************************************************/
void  GUI_FillSCR(TCOLOR dat)
{  uint32 i,j;
  
   // 填充缓冲区
   for(i=0; i<(GUI_LCM_YMAX/8); i++)
   {  for(j=0; j<GUI_LCM_XMAX; j++)
      {  gui_disp_buf[i][j] = dat;
      }
   }
   
   // 填充LCM
   LCM_DispFill(dat);
}


/****************************************************************************
* 名称：GUI_Initialize()
* 功能：初始化GUI，包括初始化显示缓冲区，初始化LCM并清屏。
* 入口参数：无
* 出口参数：无
* 说明：用户根据LCM的实际情况编写此函数。
****************************************************************************/
void  GUI_Initialize(void)
{  LCM_DispIni();					// 初始化LCM模块工作模式，纯图形模式
   GUI_FillSCR(0x00);				// 初始化缓冲区为0x00，并输出屏幕(清屏)
}


uint8 const  DEC_HEX_TAB[8] = {0x01, 0x02, 0x04, 0x08, 0x10, 0x20, 0x40, 0x80};
/****************************************************************************
* 名称：GUI_Point()
* 功能：在指定位置上画点。
* 入口参数：x		指定点所在列的位置
*           y		指定点所在行的位置
*           color	显示颜色(对于黑白色LCM，为0时灭，为1时显示)
* 出口参数：返回值为1时表示操作成功，为0时表示操作失败。
* 说明：操作失败原因是指定地址超出缓冲区范围。
****************************************************************************/
uint8  GUI_Point(uint8 x, uint8 y, TCOLOR color)
{  uint8   bak;
   
   // 参数过滤 
   if(x>=GUI_LCM_XMAX) return(0);
   if(y>=GUI_LCM_YMAX) return(0);
   
   // 设置相应的点为1或0 
   bak = LCM_ReadByte(x,y);
   if(0==color)
   {  bak &= (~DEC_HEX_TAB[y&0x07]);
   }
   else
   {  bak |= DEC_HEX_TAB[y&0x07];
   }
  
   // 刷新显示 
   LCM_WriteByte(x, y, bak);
   return(1);
}


/****************************************************************************
* 名称：GUI_ReadPoint()
* 功能：读取指定点的颜色。
* 入口参数：x		指定点所在列的位置
*           y		指定点所在行的位置
*           ret     保存颜色值的指针
* 出口参数：返回0表示指定地址超出缓冲区范围
* 说明：对于单色，设置ret的d0位为1或0，4级灰度则为d0、d1有效，8位RGB0--d则d7有效，
*      RGB结构则R、G、B变量有效。
****************************************************************************/
/*uint8  GUI_ReadPoint(uint8 x, uint8 y, TCOLOR *ret)
{  uint8  bak;

   // 参数过滤
   if(x>=GUI_LCM_XMAX) return(0);
   if(y>=GUI_LCM_YMAX) return(0);
  
   bak = LCM_ReadByte(x,y);
   if( (bak & (DEC_HEX_TAB[y&0x07])) == 0 ) *ret = 0x00;
     else  *ret = 0x01;
   
   return(1);
}


/****************************************************************************
* 名称：GUI_HLine()
* 功能：画水平线。
* 入口参数：x0		水平线起点所在列的位置
*           y0		水平线起点所在行的位置
*           x1      水平线终点所在列的位置
*           color	显示颜色(对于黑白色LCM，为0时灭，为1时显示)
* 出口参数：无
* 说明：操作失败原因是指定地址超出缓冲区范围。
****************************************************************************/
void  GUI_HLine(uint8 x0, uint8 y0, uint8 x1, TCOLOR color) 
{  uint8  bak;

   if(x0>x1) 						// 对x0、x1大小进行排列，以便画图
   {  bak = x1;
      x1 = x0;
      x0 = bak;
   }
   
   do
   {  GUI_Point(x0, y0, color);		// 逐点显示，描出垂直线
      x0++;
   }while(x1>=x0);
}


/***********************************************************************
* 名称：GUI_RLine()
* 功能：画竖直线。根据硬件特点，实现加速。
* 入口参数：x0		垂直线起点所在列的位置
*           y0		垂直线起点所在行的位置
*           y1      垂直线终点所在行的位置
*           color	显示颜色(对于黑白色LCM，为0时灭，为1时显示)
* 出口参数：	无
* 说明：操作失败原因是指定地址超出缓冲区范围。
***********************************************************************/
void  GUI_RLine(uint8 x0, uint8 y0, uint8 y1, TCOLOR color) 
{  uint8  bak;
   uint8  wr_dat;
  
   if(y0>y1) 		// 对y0、y1大小进行排列，以便画图
   {  bak = y1;
      y1 = y0;
      y0 = bak;
   }
   
   do
   {  // 先读取当前点的字节数据
      bak = LCM_ReadByte(x0,y0);	
      
      // 进行'与'/'或'操作后，将正确的数据写回LCM
      // 若y0和y1不是同一字节，则y0--当前字节结束，即(y0+8)&0x38，全写1，或者0。
      // 若y0和y1是同一字节，则y0--y1，要全写1，或者0。
      // 方法：dat=0xff，然后按y0清零dat低位，按y1清零高位。
      if((y0>>3) != (y1>>3))		// 竖直线是否跨越两个字节(或以上)
      {  wr_dat = 0xFF << (y0&0x07);// 清0低位
      
         if(color)					
         {  wr_dat = bak | wr_dat;	// 若color不为0，则显示
         }
         else
         {  wr_dat = ~wr_dat;		// 若color为0，则清除显示
            wr_dat = bak & wr_dat;
         }
         LCM_WriteByte(x0,y0, wr_dat);
         y0 = (y0+8)&0x38;
      }
      else
      {  wr_dat = 0xFF << (y0&0x07);
         wr_dat = wr_dat &  ( 0xFF >> (7-(y1&0x07)) );
              
         if(color)					
         {  wr_dat = bak | wr_dat;	// 若color不为0，则显示
         }
         else
         {  wr_dat = ~wr_dat;		// 若color为0，则清除显示
            wr_dat = bak & wr_dat;
         }
         LCM_WriteByte(x0,y0, wr_dat);
         return;
      } // end of if((y0>>3) != (y1>>3))... else...
   }while(y1>=y0);

}	 