//==============================================================
//  Create by Yuchen Wang at 5/20/2017 3:31:58 PM.
//  Version 1.0
//  Yuchen Wang [mail: wyc8094@gmail.com]
//==============================================================


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace TinyPainter
{
    class ArrowTool:Tools
    {
        public ArrowTool(PaintSettings setting, ImageFile map, PictureBox mainbox)
            :base(setting,map,mainbox)
        {
            this.operatorBox.Cursor = Cursors.Arrow;
            return;
        }

        public override void MouseDown(object sender, MouseEventArgs e)
        {
            return;
        }

        public override void MouseUp(object sender, MouseEventArgs e)
        {
            return;
        }

        public override void MouseMove(object sender, MouseEventArgs e)
        {
            return;
        }
    }
}
