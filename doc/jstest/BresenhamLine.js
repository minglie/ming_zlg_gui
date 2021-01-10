//https://blog.csdn.net/u010429424/article/details/77834046

//https://blog.csdn.net/weixin_43751983/article/details/106504492


//https://blog.csdn.net/cjw_soledad/article/details/78886117
function line1( x0,  y0,  x1,  y1) {
    let dx =Math.abs(x1-x0);
    let sx = x0<x1 ? 1 : -1;
    let dy = Math.abs(y1-y0);
    let sy = y0<y1 ? 1 : -1; 
    let err = (dx>dy ? dx : -dy)/2
    let e2;
    console.log("dx="+dx,"dy="+dy);
    while(1){
      console.log(x0,y0,err,e2);
      if (x0==x1 && y0==y1) break;
      e2 = err;
      if (e2 >-dx) { err -= dy; x0 += sx; console.log("A")}
      if (e2 < dy) { err += dx; y0 += sy;  console.log("B")}
    }
  }


// https://www.cnblogs.com/LiveForGame/p/11706904.html
function Bresenham( x0,  y0,  x1,  y1)
{
    let dx, dy, e, x=x0, y=y0;
    dx = x1 - x0; dy = y1 - y0;
    e = 2 * dy - dx;
    while (x<=x1)
    {
       console.log(x,y)
        if (e >= 0)//选右上方像素
        {
            e = e + 2 * dy - 2 * dx;
            y++;
        }
        else//选右方像素
        {
            e = e + 2 * dy;
        }
        x++;
    }
}
  

  
line1(5,9,10,15)
//line2(0,0,100,100)