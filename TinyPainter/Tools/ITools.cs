//==============================================================
//  Create by Yuchen Wang at 5/20/2017 12:50:41 PM.
//  Version 1.0
//  Yuchen Wang [mail: wyc8094@gmail.com]
//==============================================================


using System;
using System.Windows.Forms;
using System.Drawing;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TinyPainter.Algorithm;

namespace TinyPainter.Tools
{
    // this object is used to standard other object painting ITools
    abstract class ITools: IDisposable
    {
        protected PaintSettings settings;
        public ImageFile maingraphics;
        public Bitmap swapgraphics;
        protected PictureBox operatorBox;
        protected Graphics g;
        protected Point startPoint;
        private bool disposed = false;

        public ITools(PaintSettings setting, ImageFile graphFile, PictureBox newbox)
        {
            this.settings = setting;
            this.maingraphics = graphFile;
            this.operatorBox = newbox;
            this.swapgraphics = (Bitmap)maingraphics.Bitmap.Clone();
            this.startPoint = new Point();

            //add these event handlers to the view
            operatorBox.Cursor = Cursors.Cross;
            operatorBox.MouseDown += new MouseEventHandler(MouseDown);
            operatorBox.MouseMove += new MouseEventHandler(MouseMove);
            operatorBox.MouseUp += new MouseEventHandler(MouseUp);


            return;
        }

        public abstract void MouseDown(object sender, MouseEventArgs e);
        public abstract void MouseMove(object sender, MouseEventArgs e);
        public abstract void MouseUp(object sender, MouseEventArgs e);

        public virtual void UnloadTool()
        {
            // unload the ITools and event handlers
            operatorBox.Cursor = Cursors.Arrow;
            operatorBox.MouseDown -= new MouseEventHandler(MouseDown);
            operatorBox.MouseMove -= new MouseEventHandler(MouseMove);
            operatorBox.MouseUp -= new MouseEventHandler(MouseUp);

            // Destroy our paint ITools.
            if (g != null)
            {
                g.Dispose();
            }
            if(this.swapgraphics != null)
            {
                this.swapgraphics.Dispose();
            }
            return;
        }

        public Rectangle getRectangle(Point endPoint)
        {
            return new Rectangle(Math.Min(startPoint.X, endPoint.X), Math.Min(startPoint.Y, endPoint.Y),
                Math.Abs(startPoint.X - endPoint.X), Math.Abs(startPoint.Y - endPoint.Y));
        }

        public void flushSwap()
        {
            if(swapgraphics != null)
                swapgraphics.Dispose();
            swapgraphics = (Bitmap)maingraphics.Bitmap.Clone();
        }

        public void updateMaingraph()
        {
            maingraphics.Bitmap = (Bitmap)swapgraphics.Clone();
        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposed) return;

            if (disposing)
            {
            }

            if (g != null)
            {
                g.Dispose();
            }
            if (swapgraphics != null)
            {
                swapgraphics.Dispose();
            }
            operatorBox = null;
            maingraphics = null;
            disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        ~ITools()
        {
            Dispose(false);
        }
    }
}
