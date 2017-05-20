//==============================================================
//  Create by Yuchen Wang at 5/19/2017 11:14:47 AM.
//  Version 1.0
//  Yuchen Wang [mail: wyc8094@gmail.com]
//==============================================================


using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TinyPainter
{
    class ImageFile
    {
        private string filename;
        private Bitmap bitmap;

        //initialize the image with origin color
        public ImageFile(int width,int height,Color backcolor)
        {
            filename = "Untitled";
            bitmap = new Bitmap(width, height);
            Graphics g = Graphics.FromImage(bitmap);
            g.Clear(backcolor);
            g.Dispose();
            return;
        }

        //properties used to read the file name
        // and the actual picture.
        public string FileName
        {
            get
            {
                return this.filename;
            }
        }

        public Bitmap Bitmap
        {
            get
            {
                return this.bitmap;
            }
        }

        //using this function to open a new file
        public bool open(string newfileName)
        {
            try
            {
                bitmap = new Bitmap(newfileName);
                filename = newfileName;
                return true;
            }
            catch(Exception e)
            {
                return false;
            }
        }

        //using this function to save our current image file
        public bool save(string targetfile)
        {
            try
            {
                bitmap.Save(targetfile);
                filename = targetfile;
                return true;
            }
            catch(Exception e)
            {
                return false;
            }
        }
    }
}
