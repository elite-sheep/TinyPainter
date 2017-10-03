//==============================================================
//  Create by Yuchen Wang at 5/20/2017 1:08:54 PM.
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
    // The tool for painting rectangle designed by me
    class RectangleTool: ITools
    {
        private bool isDrawing;
        private Pen DrawingPen;
        private Point endPoint;

        public RectangleTool(PaintSettings setting, ImageFile map, PictureBox operatorBox)
            : base(setting, map, operatorBox)
        {
            this.isDrawing = false;
            this.endPoint = new Point();
            return;
        }


        // Draw a rectangle with given width and color
        public override void MouseDown(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                isDrawing = true;
                DrawingPen = new Pen(settings.PrimaryColor, settings.Width);
                startPoint = new Point(e.Location.X, e.Location.Y);
            }
            return;
        }

        public override void MouseUp(object sender, MouseEventArgs e)
        {
            if (isDrawing)
            {
                swapgraphics.DrawRectangle(DrawingPen, getRectangle(endPoint));
                updateMaingraph();
                isDrawing = false;
            }
            return;
        }


        public override void MouseMove(object sender, MouseEventArgs e)
        {
            if (isDrawing)
            {
                //update the information of current map and flush swap image
                endPoint = new Point(e.Location.X, e.Location.Y);
                flushSwap();
                g.DrawRectangle(DrawingPen, getRectangle(endPoint));
            }
            return;
        }
    }
}
