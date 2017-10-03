//==============================================================
//  Create by Yuchen Wang at 5/24/2017 6:53:54 PM.
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
    class MagicPencilTool : ITools
    {
        protected bool isDrawing;
        protected Pen DrawingPen;
        protected Point curPoint;
        protected Color FirstColor;
        protected bool is_dec;

        public MagicPencilTool(PaintSettings settings, ImageFile newfile, PictureBox mainpic)
            : base(settings, newfile, mainpic)
        {
       
            Random randomInt = new Random();
            this.isDrawing = false;
            this.is_dec = false;
            this.g = Graphics.FromImage(swapgraphics);
            this.FirstColor = Color.FromArgb(randomInt.Next(0xff), randomInt.Next(0xff), randomInt.Next(0xff));
        }

        public override void MouseUp(object sender, MouseEventArgs e)
        {
            if (isDrawing)
            {
                isDrawing = false;
                this.updateMaingraph();
                this.operatorBox.Invalidate();
                if (this.DrawingPen != null)
                    this.DrawingPen.Dispose();
            }
        }

        public override void MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.isDrawing = true;
                this.DrawingPen = new Pen(this.FirstColor, settings.Width);
                this.curPoint = new Point(e.Location.X, e.Location.Y);
            }

        }

        public override void MouseMove(object sender, MouseEventArgs e)
        {
            if (isDrawing)
            {
                this.startPoint = this.curPoint;
                this.curPoint = new Point(e.Location.X, e.Location.Y);
                this.DrawingPen.Color = getNextColor(DrawingPen.Color);

                g.DrawLine(DrawingPen, startPoint, curPoint);
                this.operatorBox.Invalidate();

            }
        }

        /// <summary>
        /// to get the next color from the current color
        /// </summary>
        /// <param name="curColor"></param>
        /// <returns></returns>
        public Color getNextColor(Color curColor)
        {
            int[] t = new int[] { curColor.R, curColor.G, curColor.B };
            int rancol = new Random().Next(3);
            if (this.is_dec)
            {
                t[rancol] --;
                if (t[rancol] < 0)
                {
                    t[rancol] = 1;
                    is_dec = false;
                }
            }
            else
            {
                t[rancol] ++;
                if (t[rancol] >= 0xff)
                {
                    t[rancol] -= 2;
                    is_dec = true;
                }
            }
            return Color.FromArgb(t[0], t[1], t[2]);
        }
    }
}

