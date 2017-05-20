using System;
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
        ToolStripItem curbutton;
        Tools curTools;
        PaintSettings cursettings;
        ImageFile operatormap;

        public mainPainter()
        {
            InitializeComponent();
            InitOthers();
        }

        protected void InitOthers()
        {
            cursettings = new PaintSettings();
            operatormap = new ImageFile(600, 450, Color.Black);
            curTools = new ArrowTool(cursettings,operatormap.Bitmap,operatebox);
            curbutton = Arrow;
            curstate.Image = curbutton.Image;
            colors.BackColor = Color.Black;
        }

        protected void Tool_Pressed(object sender, ToolStripItemClickedEventArgs e)
        {

            if(e.ClickedItem == colors)
            {
                changecolor();
                return;
            }

            curTools.UnloadTool();
            

            curbutton = e.ClickedItem;
            curstate.Image = curbutton.Image;


            if (curbutton == Eclipse)
                curTools = new EclipseTool(cursettings, operatormap.Bitmap, operatebox);
            else if(curbutton == Line)
                curTools = new LineTool(cursettings, operatormap.Bitmap, operatebox);
            else if(curbutton == Arrow)
                curTools = new ArrowTool(cursettings, operatormap.Bitmap, operatebox);
            else if(curbutton == Rectangle)
                curTools = new RectangleTool(cursettings, operatormap.Bitmap, operatebox);

        }

        //change the primary color
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

        protected void About_App(object sender, EventArgs e)
        {

        }

        protected void new_pic(object sender, EventArgs e)
        {

        }

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

        protected void save_pic(object sender, EventArgs e)
        {

        }

        protected void saveas_pic(object sender, EventArgs e)
        {

        }

        protected void copy_pic(object sender, EventArgs e)
        {

        }

        protected void paste_pic(object sender, EventArgs e)
        {

        }

        protected void cut_pic(object sender, EventArgs e)
        {

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

        protected void ShowImage()
        {
            string newfile = operatormap.FileName;
            base.Text = string.Format("TinyPainter - [{0}]", newfile == null ? "Untitled" : new FileInfo(newfile).Name);

            operatebox.ClientSize = operatormap.Bitmap.Size;
            operatebox.Invalidate();
        }
    }
}
