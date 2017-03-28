using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _3dtest1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void axGlobeControl1_SizeChanged(object sender, EventArgs e)
        {
           /* Form1 form = new Form1();
            int height = form.Size.Height;
            int width = form.Size.Width;
            axGlobeControl1.Height = height;*/
            //axGlobeControl1.Top = 
        }

        //窗口自适应
        private void Form1_Resize(object sender, EventArgs e)
        {
            int height = this.Height;
            int width = this.Width;
            axGlobeControl1.Height = height - axToolbarControl1.Height - 100;
            axGlobeControl1.Width = width - axTOCControl1.Width - 50;
            //axGlobeControl1.Right = axGlobeControl1.Width - 20;
            axTOCControl1.Height = height - axToolbarControl1.Height - 100;
        }
    }
}
