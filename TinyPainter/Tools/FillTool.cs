//==============================================================
//  Create by Yuchen Wang at 5/27/2017 9:34:27 PM.
//  Version 1.0
//  Yuchen Wang [mail: wyc8094@gmail.com]
//==============================================================


using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TinyPainter.Algorithm;

namespace TinyPainter.Tools
{
    class FillTool:ITools
    {
        protected bool isDrawing;
        protected bool[,] isVisited;
        protected Color oldColor;
        int tongji;

        public FillTool(PaintSettings settings, ImageFile file, PictureBox operatorbox):
            base(settings,file,operatorbox)
        {
            tongji = 0;
            this.isDrawing = false;
            isVisited = new bool[swapImage.Bitmap.Width,swapImage.Bitmap.Height];
            FlushVis();
        }

        public void FlushVis()
        {
            for (int i = 0; i < swapImage.Bitmap.Width; i++)
                for (int j = 0; j < swapImage.Bitmap.Height; j++)
                    isVisited[i, j] = false;
        }

        public override void MouseDown(object sender, MouseEventArgs e)
        {
            this.isDrawing = true;
            startPoint = new Point(e.Location.X, e.Location.Y);
        }

        public override void MouseMove(object sender, MouseEventArgs e)
        {
            return;
        }

        public override void MouseUp(object sender, MouseEventArgs e)
        {
            if (this.isDrawing)
            {
                oldColor = swapImage.Bitmap.GetPixel(startPoint.X, startPoint.Y);
                FloodFill(startPoint);
                operatorBox.Invalidate();
                this.isDrawing = false;
                updateMaingraph();
            }
            return;
        }

        public bool Comp(Color aa,Color bb)
        {
            if (aa.R == bb.R && bb.G == aa.G && aa.B == bb.B)
                return false;
            else return true;
        }

        public bool isPaintable(Point cur)
        {
            tongji++;
            int x = cur.X;
            int y = cur.Y;

            if (x < 0 || y < 0 || x >= swapImage.Bitmap.Width || y >= swapImage.Bitmap.Height)
                return false;
            else if (this.isVisited[x, y]) return false;
            else if (Comp(oldColor, swapImage.Bitmap.GetPixel(x,y)))
                return false;
            
            return true;
        }

        public void FloodFill(Point cur)
        {
            Stack<Point> S = new Stack<Point>(1000000);
            S.Push(cur);
            Point curPoint = new Point();

            while (!S.isEmpty())
            {
                S.Pop(ref curPoint);
                if (!isPaintable(curPoint)) continue;
                swapImage.Bitmap.SetPixel(curPoint.X, curPoint.Y, settings.PrimaryColor);

                S.Push(new Point(curPoint.X + 1, curPoint.Y));
                S.Push(new Point(curPoint.X, curPoint.Y + 1));
                S.Push(new Point(curPoint.X - 1, curPoint.Y));
                S.Push(new Point(curPoint.X, curPoint.Y - 1));
            }

        }
    }
}
