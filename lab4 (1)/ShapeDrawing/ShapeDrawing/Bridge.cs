using System;
using System.IO;
using System.Text;
using System.Windows.Forms;
using System.Drawing;
using System.Collections.Generic;


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
    Stream stream;
    SaveFileDialog saveFileDialog;
    List<string> attributeDrawer;

    public SVGWriter(object sender, EventArgs e)
    {
        attributeDrawer = new List<string>();
    }

    public override void DrawLine(Graphics Canvas, int x, int y, int x2, int y2)
    {
        
    }
    public override void DrawEllipse(Graphics Canvas, int x, int y, int width, int height)
    {
        attributeDrawer.Add("<circle cx=\"" + x + "\" cy=\"" + y + "\" r=\"" + width + "\" stroke-width=\"1\" fill = \"none\" stroke = \"red\" /> ");
    }

    public void MakeFile(object sender, EventArgs e)
    {

        saveFileDialog = new SaveFileDialog();

        saveFileDialog.Filter = "TeX files|(*.svg";
        saveFileDialog.RestoreDirectory = true;

        if (saveFileDialog.ShowDialog() == DialogResult.OK)
        {
            if ((stream = saveFileDialog.OpenFile()) != null)
            {

                using (StreamWriter writer = new StreamWriter(stream))
                {
                    writer.WriteLine("<?xml version=\"1.0\" standalone=\"no\"?> ");
                    writer.WriteLine("<!DOCTYPE svg PUBLIC \"-//W3C//DTD SVG 1.1//EN\"");
                    writer.WriteLine("\"http://www.w3.org/Graphics/SVG/1.1/DTD/svg11.dtd\" >");
                    writer.WriteLine("<svg xmlns = \"http://www.w3.org/2000/svg\" version = \"1.1\" >");
                    foreach (string s in attributeDrawer)
                    {
                        writer.WriteLine(s);
                    }
                    writer.WriteLine("</svg>");
                }
            }
        }
    }
}


