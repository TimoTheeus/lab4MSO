using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;


public abstract class Bridge
    {
        public Bridge()
        {

        }
        public abstract void DrawEllipse(Graphics Canvas,int x, int y, int width, int height);

        public abstract void DrawLine(Graphics Canvas, int x, int y, int x2, int y2);

    }
public class ScreenDrawer:Bridge
{
    Pen pen;
    public ScreenDrawer()
    {
        pen = new Pen(Color.Black);
    }
    public override void DrawLine(Graphics Canvas, int x, int y, int x2, int y2)
    {
        Canvas.DrawLine(pen, x, y, x2, y2);
    }
    public override void DrawEllipse(Graphics Canvas, int x, int y, int width, int height)
    {
        Canvas.DrawEllipse(pen,x, y, width, height);
    }
}

public class SVGWriter : Bridge
{
    public SVGWriter()
    {
    }
    public override void DrawLine(Graphics Canvas, int x, int y, int x2, int y2)
    {

    }
    public override void DrawEllipse(Graphics Canvas, int x, int y, int width, int height)
    {
    }
}


