//==============================================================
//  Create by Yuchen Wang at 5/20/2017 2:04:27 PM.
//  Version 1.0
//  Yuchen Wang [mail: wyc8094@gmail.com]
//==============================================================


using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TinyPainter
{
    class EclipseTool:Tools
    {
        private bool isDrawing;
        private Pen DrawingPen;
        private Point endPoint;

        public EclipseTool(PaintSettings setting, Bitmap map, PictureBox operatorBox)
            : base(setting, map, operatorBox)
        {
            this.isDrawing = false;
            return;
        }

        public override void MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isDrawing = true;
                DrawingPen = new Pen(settings.PrimaryColor, (float)settings.Width);
                startPoint = new Point(e.Location.X, e.Location.Y);
                g = Graphics.FromImage(swapgraphics);
            }
            return;
        }

        public override void MouseUp(object sender, MouseEventArgs e)
        {
            if (isDrawing)
            {
                //delete old ellipse
                swapgraphics = maingraphics;
                g.DrawEllipse(DrawingPen, getRectangle(endPoint));
                // save the objects we have drawn
                maingraphics = swapgraphics;

                DrawingPen.Dispose();
                isDrawing = false;
            }
            return;
        }

        public override void MouseMove(object sender, MouseEventArgs e)
        {
            if (isDrawing)
            {
                swapgraphics = maingraphics;
                g.DrawEllipse(DrawingPen, getRectangle(endPoint));
            }
            return;
        }
    }
}
