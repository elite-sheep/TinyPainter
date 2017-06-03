using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TinyPainter
{
    public partial class NewForm : Form
    {
        public NewForm()
        {
            InitializeComponent();
            InitOther();
        }

        private void InitOther()
        {
            this.WidthBox.Text = "600";
            this.HeightBox.Text = "450";
        }


        public int widthres
        {
            get
            {
                return int.Parse(this.WidthBox.Text);
            }
        }

        public int heightres
        {
            get
            {
                return int.Parse(this.HeightBox.Text);
            }
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            int wid, hei;
            if (int.TryParse(WidthBox.Text, out wid) == false || int.TryParse(HeightBox.Text, out hei) == false)
            {
                MessageBox.Show("Invalid Width and Height!!");
                return;
            }
            return;
        }
    }
}
