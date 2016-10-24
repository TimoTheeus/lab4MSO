using System;
using System.Drawing;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class Circle : Shape
{

    private int x;
	private int y;
	private int size;

    public Circle(int x, int y, int size)
    {
		this.x = x;
		this.y = y;
		this.size = size;
    }
    // waar beslis je in het programma of je svg file maakt of dat je t op t scherm tekent
    //waar geef je Graphics door 
    public override void Draw(Graphics Canvas, Bridge brug)
    {
	//	Pen pen = new Pen(Color.Black);
     //   Canvas.DrawEllipse(pen, this.x, this.y, this.size, this.size);
        brug.DrawEllipse(Canvas, this.x, this.y, this.size, this.size);
    }

}
