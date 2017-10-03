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

namespace TinyPainter.Algorithm
{
    class ImageFile:IDisposable
    {
        private string filename;
        private Bitmap bitmap;
        private bool disposed = false;

        //initialize the image with origin color
        public ImageFile(int width,int height,Color backcolor)
        {
            filename = "Untitled";
            bitmap = new Bitmap(width, height, System.Drawing.Imaging.PixelFormat.Format32bppRgb);
            Graphics g = Graphics.FromImage(bitmap);
            g.Clear(backcolor);
            g.Dispose();
            return;
        }

        public ImageFile(ImageFile mirror)
        {
            this.filename = mirror.filename;
            this.bitmap = (Bitmap)mirror.bitmap.Clone();
        }

        //properties used to read the file name
        // and the actual picture.
        public string FileName
        {
            get
            {
                return this.filename;
            }
            set
            {
                this.filename = value;
            }
        }

        public Bitmap Bitmap
        {
            get
            {
                return this.bitmap;
            }
            set
            {
                this.bitmap = value;
            }
        }

        //using this function to open a new file
        public bool Open(string newfileName)
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
        public bool Save(string targetfile)
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

        public ImageFile CloneImage()
        {
            return new ImageFile(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposed) return;

            if (disposing)
            {
            }

            this.Bitmap.Dispose();
            disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        ~ImageFile()
        {
            Dispose(false);
        }
    }
}
