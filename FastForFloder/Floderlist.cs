using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO; 


namespace FastForFloder
{
    public partial class Floderlist : Form
    {
        public Floderlist()
        {
            InitializeComponent();
        }

   

      public void LoadAllFiels(string path, TreeNodeCollection nodes)
        {
            string[] dirs = Directory.GetDirectories(path);//获取指定目录下的所有文件夹
            foreach (var dir in dirs)
            {
                TreeNode node = nodes.Add(Path.GetFileName(dir));
                LoadAllFiels(dir, node.Nodes);
            }

            string[] files = Directory.GetFiles(path);//获取指定目录下的所有文件
            foreach (var file in files)
            {
                nodes.Add(Path.GetFileName(file));
            }
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            Win32.ReleaseCapture();
            Win32.SendMessage(this.Handle, Win32.WM_SYSCOMMAND, Win32.SC_MOVE + Win32.HTCAPTION, 0);
        }

        private void panel1_MouseLeave(object sender, EventArgs e)
        {

        }

        private void Floderlist_MouseLeave(object sender, EventArgs e)
        {
            
        }
        public void FrmClickMeanstwo(Form Frm_tem, int n)
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

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            FrmClickMeanstwo(this, Convert.ToInt16(((PictureBox)sender).Tag.ToString()));
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            FrmClickMeanstwo(this, Convert.ToInt16(((PictureBox)sender).Tag.ToString()));
        }

        private void treeView2_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            try
            {
                string listopen = Frm_Main.openpath + "/" + treeView2.SelectedNode.FullPath;
                System.Diagnostics.Process.Start(listopen);
            }
            catch (Exception)
            {
            }
         }
    }
}
