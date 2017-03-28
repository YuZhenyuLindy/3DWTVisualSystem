using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace _3dtest1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
        }

        public static bool isAnimation = false;

        Thread thread = null;

        private void Form1_Load(object sender, EventArgs e)
        {
            //首次加载示例数据
            //调试路径
            string filePath = "..\\..\\data\\LST150.3dd";
            axGlobeControl1.Load3dFile(filePath);
            axTOCControl1.SetBuddyControl(axGlobeControl1);
            //打包后的使用路径
            //System.Reflection.Assembly asm = System.Reflection.Assembly.GetExecutingAssembly();
            //string filePath = asm.Location.Remove(asm.Location.LastIndexOf("\\")) + "\\" + "\\data\\LST150.3dd";
            //axGlobeControl1.Load3dFile(filePath);
            //axTOCControl1.SetBuddyControl(axGlobeControl1);
        }

        private void axGlobeControl1_SizeChanged(object sender, EventArgs e)
        {
            //窗口自适应
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

        private void axGlobeControl1_OnMouseDown(object sender, ESRI.ArcGIS.Controls.IGlobeControlEvents_OnMouseDownEvent e)
        {
            //首次加载示例数据
            //string filePath = @"../../data/LST150.3dd";
            //axGlobeControl1.Load3dFile(filePath);
            //axTOCControl1.SetBuddyControl(axGlobeControl1);
        }

        private void axGlobeControl1_OnMouseDown_1(object sender, ESRI.ArcGIS.Controls.IGlobeControlEvents_OnMouseDownEvent e)
        {

        }

        private void btnAnimation_Click(object sender, EventArgs e)
        {
            string filePath = null;
            Timer t = new Timer();
            //isAnimation = !isAnimation;
            Console.WriteLine(isAnimation);

            if (isAnimation == false)//没有在播放动画
            {
                isAnimation = true;
                filePath = @"../../data/LST150.3dd";
                axGlobeControl1.Load3dFile(filePath);
                axTOCControl1.SetBuddyControl(axGlobeControl1);
                //System.Threading.Thread.Sleep(5000); 
                //threadTimer.Change(-1, -1);
                //Timer.timer(5000);
                thread = new Thread(new ThreadStart(t.timer));
                thread.Start();
                Thread.Sleep(6000);                //Timer.timer();
                isAnimation = false;
            }

            if (isAnimation == false)//没有在播放动画
            {
                isAnimation = true;
                filePath = @"../../data/LST200.3dd";
                axGlobeControl1.Load3dFile(filePath);
                axTOCControl1.SetBuddyControl(axGlobeControl1);
                //System.Threading.Thread.Sleep(5000); 
                //threadTimer.Change(-1, -1);
                //Timer.timer(5000);
                thread = new Thread(new ThreadStart(t.timer));
                thread.Start();
                Thread.Sleep(6000);                //t.timer();
                isAnimation = false;
            }

            if (isAnimation == false)//没有在播放动画
            {
                isAnimation = true;
                filePath = @"../../data/LST300.3dd";
                axGlobeControl1.Load3dFile(filePath);
                axTOCControl1.SetBuddyControl(axGlobeControl1);
                //System.Threading.Thread.Sleep(5000); 
                //threadTimer.Change(-1, -1);
                //Timer.timer(5000);
                isAnimation = false;
            }

            if (isAnimation == true)
            {
                return;
            }
        }

    }
}




 