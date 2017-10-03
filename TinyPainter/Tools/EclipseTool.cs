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
using TinyPainter.Algorithm;

namespace TinyPainter.Tools
{
    // the ITools used to draw a ellipse on the screen 
    class EclipseTool:ITools
    {
        private bool isDrawing;
        private Pen DrawingPen;
        private Point endPoint;

        public EclipseTool(PaintSettings setting, ImageFile map, PictureBox operatorBox)
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
                g = Graphics.FromImage(this.swapgraphics);
            }
            return;
        }

        public override void MouseUp(object sender, MouseEventArgs e)
        {
            if (isDrawing)
            {
                this.operatorBox.Invalidate();
                this.updateMaingraph();

                if (g != null)
                    g.Dispose();

                if (DrawingPen != null)
                    DrawingPen.Dispose();

                this.isDrawing = false;
            }
            return;
        }

        public override void MouseMove(object sender, MouseEventArgs e)
        {
            if (isDrawing)
            {
                //update information of current image
                endPoint = new Point(e.Location.X, e.Location.Y);
                flushSwap();

                using (g = Graphics.FromImage(this.swapgraphics))
                {
                    g.DrawEllipse(DrawingPen, getRectangle(endPoint));
                    this.operatorBox.Invalidate();
                }
            }
            return;
        }
    }
}
