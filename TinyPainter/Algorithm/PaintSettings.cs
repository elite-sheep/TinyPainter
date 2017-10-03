//==============================================================
//  Create by Yuchen Wang at 5/20/2017 12:46:33 PM.
//  Version 1.0
//  Yuchen Wang [mail: wyc8094@gmail.com]
//==============================================================


using System;
using System.Drawing;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TinyPainter.Algorithm
{
    // the setting of paintings, this class is used to control
    // the color and line width of objects we paint
    class PaintSettings
    {
        private int width;
        private Color primaryColor;
        public Graphics g;

        public PaintSettings()
        {
            this.Width = 5;
            this.PrimaryColor = Color.Black;
        }

        public PaintSettings(PaintSettings mirror)
        {
            width = mirror.width;
            primaryColor = mirror.primaryColor;
        }

        public int Width{
            get
            {
                return width;
            }
            set
            {
                width = value;
            }
        }

        public Color PrimaryColor
        {
            get
            {
                return primaryColor;
            }
            set
            {
                primaryColor = value;
            }
        }
    }
}
