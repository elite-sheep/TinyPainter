//==============================================================
//  Create by Yuchen Wang at 5/23/2017 10:30:49 PM.
//  Version 1.0
//  Yuchen Wang [mail: wyc8094@gmail.com]
//==============================================================


using System;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TinyPainter.Algorithm;

namespace TinyPainter.Tools
{
    class EraseTool : ITools
    {
        protected bool isDrawing;
        protected Pen DrawingPen;
        protected Point curPoint;

        public EraseTool(PaintSettings settings, ImageFile newfile, PictureBox mainpic)
            : base(settings, newfile, mainpic)
        {
            this.isDrawing = false;
        }

        public override void MouseUp(object sender, MouseEventArgs e)
        {
            if (isDrawing)
            {
                isDrawing = false;
                swapgraphics.DrawLine(DrawingPen, startPoint, curPoint);
                this.updateMaingraph();
            }
        }

        public override void MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.isDrawing = true;
                this.DrawingPen = new Pen(Color.White, settings.Width);
                this.curPoint = new Point(e.Location.X, e.Location.Y);
            }

        }

        public override void MouseMove(object sender, MouseEventArgs e)
        {
            if (isDrawing)
            {
                this.startPoint = this.curPoint;
                this.curPoint = new Point(e.Location.X, e.Location.Y);

                g.DrawLine(DrawingPen, startPoint, curPoint);
                swapgraphics.DrawLine(DrawingPen, startPoint, curPoint);
            }
        }
    }
}

