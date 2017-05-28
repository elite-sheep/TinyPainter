﻿using System;
using System.Windows.Forms;
using System.Drawing.Imaging;
using System.Drawing;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Imaging;

namespace TinyPainter
{
    public partial class mainPainter : Form
    {
        private const int initwidth = 380;
        private const int initheight = 240;

        protected ToolStripItem curbutton;
        protected bool isSaved;
        Tools curTools;
        PaintSettings cursettings;

        //operatormap is used to store the runtime image
        //while maingraph is used to store the whole image
        ImageFile operatormap;
        ImageFile maingraph;
        ImageFile clipboard;

        public mainPainter()
        {
            InitializeComponent();
            InitOthers();
        }

        /// <summary>
        /// initialize other elements in the current form
        /// </summary>
        public void InitOthers()
        {
            this.isSaved = true;
            this.WidthBox.Text = "5";
            cursettings = new PaintSettings();
            operatormap = new ImageFile(initwidth, initheight, Color.White);
            maingraph = operatormap.CloneImage();
            curTools = new ArrowTool(cursettings,operatormap,operatebox);
            curbutton = Arrow;
            curstate.Image = curbutton.Image;
            colors.BackColor = Color.Black;
        }

        /// <summary>
        /// handle events happened in tool bar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Tool_Pressed(object sender, ToolStripItemClickedEventArgs e)
        {

            this.isSaved = false;

            //if the clicked item is color change or line 
            // width change, we do not need to unload and reload
            // current button
            if (e.ClickedItem == colors)
            {
                changecolor();
                return;
            }
            else if (e.ClickedItem == LineWidth)
                return;

            operatormap = curTools.maingraphics.CloneImage();
            curTools.UnloadTool();
            

            curbutton = e.ClickedItem;
            curstate.Image = curbutton.Image;


            if (curbutton == Eclipse)
                curTools = new EclipseTool(cursettings, operatormap, operatebox);
            else if (curbutton == Line)
                curTools = new LineTool(cursettings, operatormap, operatebox);
            else if (curbutton == Arrow)
                curTools = new ArrowTool(cursettings, operatormap, operatebox);
            else if (curbutton == Rectangle)
                curTools = new RectangleTool(cursettings, operatormap, operatebox);
            else if (curbutton == Pencil)
                curTools = new PencilTool(cursettings, operatormap, operatebox);
            else if (curbutton == Eraser)
                curTools = new EraseTool(cursettings, operatormap, operatebox);
            else if (curbutton == magicPencil)
                curTools = new MagicPencilTool(cursettings, operatormap, operatebox);
            else if (curbutton == Fill)
                curTools = new FillTool(cursettings, operatormap, operatebox);
            else if (curbutton == Text)
                curTools = new TextTool(cursettings, operatormap, operatebox);
        }


        /// <summary>
        /// change current primary color
        /// </summary>
        protected void changecolor()
        {
            ColorDialog colornavigator = new ColorDialog();
            if(colornavigator.ShowDialog() == DialogResult.OK)
            {
                Color nextColor = colornavigator.Color;
                this.cursettings.PrimaryColor = nextColor;
                colors.BackColor = nextColor;
            }
            return;
        }

        ///<summary>
        /// used to show basic information of this application
        ///    </summary>
        protected void About_App(object sender, EventArgs e)
        {
            AboutTinyPainter painterInfo = new AboutTinyPainter();
            painterInfo.ShowDialog();
            return;
        }

        protected void new_pic(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// used to open an image from a existing file
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void open_pic(object sender, EventArgs e)
        {
            OpenFileDialog FileNavigator = new OpenFileDialog();
            FileNavigator.Filter = "*.bmp|*.jpg|*.png|*.jpeg";
            if (FileNavigator.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show(FileNavigator.ToString());

                if (operatormap.open(FileNavigator.FileName))
                {
                    ShowImage();
                }
                else
                {
                    MessageBox.Show("Load Image Error!!!");
                }
            }
            return;
        }

        /// <summary>
        /// save current file to the memory
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void save_pic(object sender, EventArgs e)
        {
            if(isSaved == false)
            {
                maingraph = operatormap.CloneImage();
                isSaved = true;
            }
        }

        protected void saveas_pic(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// copy image into clipboard
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void copy_pic(object sender, EventArgs e)
        {
            clipboard = operatormap.CloneImage();
            return;
        }

        protected void paste_pic(object sender, EventArgs e)
        {
            operatormap = clipboard.CloneImage();
            curTools.flushSwap();
            operatebox.Invalidate();
        }

        protected void cut_pic(object sender, EventArgs e)
        {
            clipboard = operatormap.CloneImage();
            Graphics.FromImage(operatormap.Bitmap).Clear(Color.White);
            curTools.flushSwap();
            this.operatebox.Invalidate();
        }

        protected void clear_pic(object sender, EventArgs e)
        {
            this.isSaved = false;
            Graphics.FromImage(curTools.swapgraphics).Clear(Color.White);
            curTools.updateMaingraph();
            this.operatebox.Invalidate();
        }

        //exit this application when exit option is pressed
        protected void Exit_App(object sender, EventArgs e)
        {
            Application.Exit();
            return;
        }

        // the status bar on the bottom of this application


        protected void pos_display(object sender, MouseEventArgs e)
        {
            cursorPos.Text = e.Location.ToString();
            return;
        }

        /// <summary>
        /// show the image from a existing image file
        /// </summary>
        protected void ShowImage()
        {
            string newfile = operatormap.FileName;
            base.Text = string.Format("TinyPainter - [{0}]", newfile == null ? "Untitled" : new FileInfo(newfile).Name);

            curTools.flushSwap();

            operatebox.ClientSize = operatormap.Bitmap.Size;
            operatebox.Invalidate();
        }

        /// <summary>
        /// handle paint event happened in the screen
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void paintOnBox(object sender, PaintEventArgs e)
        {
            Rectangle rec = e.ClipRectangle;
            Bitmap tmp = curTools.swapgraphics.Clone(rec,curTools.swapgraphics.PixelFormat);
            e.Graphics.DrawImageUnscaledAndClipped(tmp,rec);
            tmp.Dispose();
            return;
        }

        /// <summary>
        /// set new width of drawing pen
        /// </summary>
        /// <param name="newwidth"></param>
        protected void setLineWidth(int newwidth)
        {
            if(this.cursettings != null)
            {
                this.cursettings.Width = newwidth;
            }
        }

        /// <summary>
        /// set slim size of line width
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void slimWidth(object sender, EventArgs e)
        {
            this.setLineWidth(1);
        }

        /// <summary>
        /// set medium size of width
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void mediumWidthe(object sender, EventArgs e)
        {
            this.setLineWidth(5);
        }

        /// <summary>
        /// set large line width
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void largeWidth(object sender, EventArgs e)
        {
            this.setLineWidth(10);
        }

        /// <summary>
        /// flush the text when text box is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void flushBox(object sender, EventArgs e)
        {
            this.WidthBox.Text = "";
        }

        /// <summary>
        /// set the width of line by users
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void selfmadeWidth(object sender, EventArgs e)
        {
            string res = WidthBox.Text;
            int newwidth = 0;
            if (int.TryParse(res, out newwidth) == true)
                this.setLineWidth(newwidth);
            else
            {
                MessageBox.Show("Invalid Value!!");
                WidthBox.Text = cursettings.Width.ToString();
            }
            return;
        }
    }
}
