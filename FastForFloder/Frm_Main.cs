using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace FastForFloder
{
    public partial class Frm_Main : Form
    {
      
        static string app_path= System.IO.Directory.GetCurrentDirectory();
        private string openpath3, openpath5, openpath6,openpath7, openpath8, openpath9,openpath10,openpath11;
        private string inipath;
        public static string openpath;
        static Floderlist tv = new Floderlist();
       

        public Frm_Main()
        {
            InitializeComponent();
           
           StringBuilder configpath = new StringBuilder(app_path);
            configpath.Append(@"\config.ini");
            inipath = Convert.ToString(configpath);
            iniFile config = new iniFile(inipath);
            label1.Text = config.iniReadValue("section1", "foldertext");
            openpath3 = config.iniReadValue("section1", "folderpath");

            label2.Text = config.iniReadValue("section2", "foldertext");
            openpath5 = config.iniReadValue("section2", "folderpath");

            label3.Text = config.iniReadValue("section3", "foldertext");
            openpath6 = config.iniReadValue("section3", "folderpath");

            label4.Text = config.iniReadValue("section4", "foldertext");
            openpath7 = config.iniReadValue("section4", "folderpath");

            label5.Text = config.iniReadValue("section5", "foldertext");
            openpath8 = config.iniReadValue("section5", "folderpath");

            label6.Text = config.iniReadValue("section6", "foldertext");
            openpath9 = config.iniReadValue("section6", "folderpath");

            label7.Text = config.iniReadValue("section7", "foldertext");
            openpath10 = config.iniReadValue("section7", "folderpath");

            label8.Text = config.iniReadValue("section8", "foldertext");
            openpath11 = config.iniReadValue("section8", "folderpath");

        }
        
        public static PictureBox temp = new PictureBox();
        public void ImageSwitch(object sender, int n, int ns)
        {
            temp =(PictureBox) sender;
            switch (n)
            {
                case 0:
                    {
                        temp.Image = null;
                        if (ns == 0)
                            temp.Image = Properties.Resources.min2;
                            temp.SizeMode = PictureBoxSizeMode.StretchImage;
                        if (ns == 1)
                            temp.Image = Properties.Resources.min1;
                            temp.SizeMode = PictureBoxSizeMode.StretchImage;
                        break;
                    }
                case 1:
                    {
                        temp.Image = null;
                        if (ns == 0)
                            temp.Image = Properties.Resources.close2;
                            temp.SizeMode = PictureBoxSizeMode.StretchImage;
                        if (ns == 1)
                            temp.Image = Properties.Resources.close1;
                            temp.SizeMode = PictureBoxSizeMode.StretchImage;
                        break;
                    }
                case 2:
                    {
                        temp.BackgroundImage = null;
                        temp.Image = null;
                        //temp.Dispose();
                        //temp.Invalidate();
                        if (ns == 0)
                          temp.Image = Properties.Resources._1187339;
                          temp.SizeMode = PictureBoxSizeMode.StretchImage;
                       if (ns == 1)
                          temp.Image = Properties.Resources._1186194;
                          temp.SizeMode = PictureBoxSizeMode.StretchImage;
                        break;
                    }
                case 3:
                    {
                        temp.BackgroundImage = null;
                        temp.Image = null;
                        //temp.Dispose();
                        //temp.Invalidate();
                        if (ns == 0)
                            temp.Image = Properties.Resources.internet3;
                        temp.SizeMode = PictureBoxSizeMode.StretchImage;
                        if (ns == 1)
                            temp.Image = Properties.Resources.internet2;
                        temp.SizeMode = PictureBoxSizeMode.StretchImage;
                        break;
                    }

                case 4:
                    {
                        temp.BackgroundImage = null;
                        temp.Image = null;
                        //temp.Dispose();
                        //temp.Invalidate();
                        if (ns == 0)
                           temp.Image = Properties.Resources.Gear;
                        temp.SizeMode = PictureBoxSizeMode.StretchImage;
                        if (ns == 1)
                            temp.Image = Properties.Resources.gear01;
                        temp.SizeMode = PictureBoxSizeMode.StretchImage;
                        break;
                    }
                case 5:
                    {
                        temp.BackgroundImage = null;
                        temp.Image = null;
                        //temp.Dispose();
                        //temp.Invalidate();
                        if (ns == 0)
                            temp.Image = Properties.Resources.updated3;
                        temp.SizeMode = PictureBoxSizeMode.StretchImage;
                        if (ns == 1)
                            temp.Image = Properties.Resources.update2;
                        temp.SizeMode = PictureBoxSizeMode.StretchImage;
                        break;
                    }
            }
        }

        public void pathSwitch( int n)
        {
            
            switch (n)
            {
                case 3:
                    {
                        openpath = openpath3;
                      break;
                    }
                case 5:
                    {
                        openpath = openpath5;
                        break;
                    }
                case 6:
                    {
                        openpath = openpath6;
                        break;
                    }
                case 7:
                    {
                        openpath = openpath7;
                        break;
                    }
                case 8:
                    {
                        openpath = openpath8;
                        break;
                    }
                case 9:
                    {
                        openpath = openpath9;
                        break;
                    }
            }
            if (System.IO.Directory.Exists(openpath))
            {
                tv.treeView2.Nodes.Clear();
                tv.LoadAllFiels(openpath, tv.treeView2.Nodes);

                tv.WindowState = FormWindowState.Normal;
                tv.Visible = true;
                tv.Location = new Point(MousePosition.X, MousePosition.Y+5);
                tv.TopMost = true;
                tv.TopMost = false;
            }
            }

        public void FrmClickMeans(Form Frm_tem, int n)
        {
            switch (n)
            {
                case 0:
                    Frm_tem.WindowState = FormWindowState.Minimized;
                break;
                case 1:
                    this.WindowState = FormWindowState.Minimized;
                break;
            }

        }

        private void Frm_Main_Load(object sender, EventArgs e)
        {
            pictureBox1.Image = null;
            pictureBox1.Image = Properties.Resources.min1;
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.Image = null;
            pictureBox2.Image = Properties.Resources.close1;
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.Image = null;
            pictureBox3.Image = Properties.Resources._1223212;
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
           
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(inipath);
        }

        private void pictureBox2_MouseEnter(object sender, EventArgs e)
        {
            ImageSwitch(sender, Convert.ToInt16(((PictureBox)sender).Tag.ToString()),0);
        }

        private void pictureBox2_MouseLeave(object sender, EventArgs e)
        {
            ImageSwitch(sender, Convert.ToInt16(((PictureBox)sender).Tag.ToString()),1);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            FrmClickMeans(this, Convert.ToInt16(((PictureBox)sender).Tag.ToString()));
            tv.WindowState = FormWindowState.Minimized;
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            Win32.ReleaseCapture();
            Win32.SendMessage(this.Handle,Win32.WM_SYSCOMMAND,Win32.SC_MOVE+Win32.HTCAPTION,0);
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start(openpath5);
            }
            catch (Exception)
            {

            }
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start(openpath6);
            }
            catch (Exception)
            {

            }
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start(openpath7);
            }
            catch (Exception)
            {

            }
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start(openpath8);
            }
            catch (Exception)
            {

            }
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start(openpath9);
            }
            catch (Exception)
            {
                
            }
            }

        private void pictureBox4_Click_1(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(inipath);
        }

        private void panel2_SizeChanged(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
                Fast.Visible = false;
            else if (this.WindowState == FormWindowState.Minimized)
                this.Hide();
                Fast.Visible = true;
                      
         }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                this.Show();
                this.WindowState = FormWindowState.Normal;
            }
         }

        private void 显示主页面ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            notifyIcon1_MouseDoubleClick(null,null);
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(openpath10);
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(openpath11);
        }

        private void Frm_Main_Activated(object sender, EventArgs e)
        {
            //注册热键Shift+Z，Id号为100。HotKey.KeyModifiers.Shift也可以直接使用数字4来表示。
            HotKey.RegisterHotKey(Handle, 100, HotKey.KeyModifiers.Shift, Keys.Z);
            //注册热键Ctrl+B，Id号为101。HotKey.KeyModifiers.Ctrl也可以直接使用数字2来表示。
            HotKey.RegisterHotKey(Handle, 101, HotKey.KeyModifiers.Ctrl, Keys.B);
            //注册热键Alt+D，Id号为102。HotKey.KeyModifiers.Alt也可以直接使用数字1来表示。
            HotKey.RegisterHotKey(Handle, 102, HotKey.KeyModifiers.Alt, Keys.A);

        }

        private void Frm_Main_Leave(object sender, EventArgs e)
        {
            //注销Id号为100的热键设定
            HotKey.UnregisterHotKey(Handle, 100);
            //注销Id号为101的热键设定
            HotKey.UnregisterHotKey(Handle, 101);
            //注销Id号为102的热键设定
            HotKey.UnregisterHotKey(Handle, 102);
        }

        protected override void WndProc(ref Message m)
        {
            const int WM_HOTKEY = 0x0312;
            //按快捷键
            switch (m.Msg)
            {
                case WM_HOTKEY:
                    switch (m.WParam.ToInt32())
                    {
                        case 100:     //按下的是Shift+Z
                                      //此处填写快捷键响应代码        
                         break;
                        case 101:     //按下的是Ctrl+B
                                      //此处填写快捷键响应代码
                            break;
                        case 102:     //按下的是win+A
                            //此处填写快捷键响应代码

                            this.Visible = true;
                            this.WindowState = FormWindowState.Normal;
                            this.TopMost = true;
                            this.TopMost = false;

                            break;
                    }
                    break;
            }
            base.WndProc(ref m);
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            StringBuilder configpath = new StringBuilder(app_path);
            configpath.Append(@"\config.ini");
            inipath = Convert.ToString(configpath);
            iniFile config = new iniFile(inipath);
            label1.Text = config.iniReadValue("section1", "foldertext");
            openpath3 = config.iniReadValue("section1", "folderpath");

            label2.Text = config.iniReadValue("section2", "foldertext");
            openpath5 = config.iniReadValue("section2", "folderpath");

            label3.Text = config.iniReadValue("section3", "foldertext");
            openpath6 = config.iniReadValue("section3", "folderpath");

            label4.Text = config.iniReadValue("section4", "foldertext");
            openpath7 = config.iniReadValue("section4", "folderpath");

            label5.Text = config.iniReadValue("section5", "foldertext");
            openpath8 = config.iniReadValue("section5", "folderpath");

            label6.Text = config.iniReadValue("section6", "foldertext");
            openpath9 = config.iniReadValue("section6", "folderpath");

            label7.Text = config.iniReadValue("section7", "foldertext");
            openpath10 = config.iniReadValue("section7", "folderpath");

            label8.Text = config.iniReadValue("section8", "foldertext");
            openpath11 = config.iniReadValue("section8", "folderpath");
        }

        private void pictureBox3_MouseEnter(object sender, EventArgs e)
        {
            ImageSwitch(sender, Convert.ToInt16(((PictureBox)sender).Tag.ToString()), 0);
            //Floderlist tv = new Floderlist();
         
        }

        private void pictureBox3_MouseLeave(object sender, EventArgs e)
        {
            ImageSwitch(sender, Convert.ToInt16(((PictureBox)sender).Tag.ToString()), 1);
        }

        private void pictureBox3_MouseHover(object sender, EventArgs e)
        {
            try
            {
                temp = (PictureBox)sender;
                int n = Convert.ToInt16(temp.Name.Substring(temp.Name.Length - 1));
                pathSwitch(n);
            }
            catch (Exception)
            {
            }
        }

        private void 退出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("确定要退出吗","退出",
                MessageBoxButtons.OKCancel,MessageBoxIcon.Question);
            if (result == DialogResult.OK)
                Application.ExitThread();
            else
                this.WindowState = FormWindowState.Minimized;
        }

        private void notifyIcon1_Click(object sender, EventArgs e)
        {
            //contextMenuStrip1.Show();
            this.contextMenuStrip1.Show(MousePosition.X , MousePosition.Y-60);
            
        }

        private void pictureBox3_MouseDown(object sender, MouseEventArgs e)
        {
            //Frm_Modfy modfy = new Frm_Modfy();

            //if (e.Button==MouseButtons.Right)
            //   modfy.Show();       
        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.label1.Text = Datapass.pstring;
        }

        private void label1_Enter(object sender, EventArgs e)
        {
            
        }

        private void label1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start(openpath3);
            }
            catch (Exception)
            {

            }
        }
    }
}
