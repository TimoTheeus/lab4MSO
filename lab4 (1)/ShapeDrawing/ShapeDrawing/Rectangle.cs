using System;
using System.Drawing;
using System.Collections.Generic;
using System.Linq;
using System.Text;


class Rectangle : Shape
{

    private int x;
	private int y;
	private int width;
	private int height;

    public Rectangle(int x, int y, int width, int height)
    {
		this.x = x;
		this.y = y;
		this.width = width;
		this.height = height;
    }
    
	public override void Draw(Graphics Canvas,Bridge brug)
    {
		brug.DrawLine(Canvas,x,y,x + width,y);
        brug.DrawLine(Canvas,x + width,y,x+width,y+height);
        brug.DrawLine(Canvas,x + width,y+height,x,y+height);
        brug.DrawLine(Canvas, x,y+height,x,y);
    }
}

