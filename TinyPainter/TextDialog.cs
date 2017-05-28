using System;
using System.Drawing;
using System.Drawing.Text;
using System.Drawing.Drawing2D;
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
    public partial class TextDialog : Form
    {
        public TextDialog()
        {
            InitializeComponent();
        }

        private void FontBtn_Click(object sender, EventArgs e)
        {
            FontDialog fontnavi = new FontDialog();
            fontnavi.Font = EditArea.Font;

            if (fontnavi.ShowDialog() == DialogResult.OK)
                EditArea.Font = fontnavi.Font;
        }

        public Font curFont
        {
            get
            {
                return EditArea.Font;
            }
        }

        public string Texts
        {
            get
            {
                return EditArea.Text;
            }
        }
    }
}
