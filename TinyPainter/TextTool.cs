//==============================================================
//  Create by Yuchen Wang at 5/28/2017 4:36:36 PM.
//  Version 1.0
//  Yuchen Wang [mail: wyc8094@gmail.com]
//==============================================================


using System;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Text;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TinyPainter
{
    class TextTool:Tools
    {
        protected Brush DrawingBrush;

        public TextTool(PaintSettings settings,ImageFile file,PictureBox operatebox)
            : base(settings, file, operatebox)
        {
            operatorBox.MouseClick += new MouseEventHandler(MouseClick);
            DrawingBrush = new SolidBrush(settings.PrimaryColor);
        }

        public override void MouseDown(object sender, MouseEventArgs e)
        {
            return;
        }

        public override void MouseMove(object sender, MouseEventArgs e)
        {
            return;
        }

        public override void MouseUp(object sender, MouseEventArgs e)
        {
            return;
        }

        public void MouseClick(object sender, MouseEventArgs e)
        {
            startPoint = new Point(e.Location.X, e.Location.Y);
            TextDialog newdig = new TextDialog();

            if(newdig.ShowDialog() == DialogResult.OK)
            {
                this.g = Graphics.FromImage(swapgraphics);
                String paintstr = newdig.Texts;
                g.DrawString(paintstr, newdig.curFont,DrawingBrush, startPoint);
                operatorBox.Invalidate();
                updateMaingraph();
            }
            return;
        }

        public override void UnloadTool()
        {
            base.UnloadTool();
            operatorBox.MouseClick -= new MouseEventHandler(this.MouseClick);
        }
    }
}
