using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WypożyczalniaVideo
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            
        }

        private void BorrowCMS_Opening(object sender, CancelEventArgs e)
        {

            Form BorrowForm = new BorrowForm();
            BorrowForm.MdiParent = this;
            BorrowForm.Show();
        }

        private void ReturnCMS_Opening(object sender, CancelEventArgs e)
        {
            Form ReturnForm = new ReturnForm();
            ReturnForm.MdiParent = this;
            ReturnForm.Show();
        }

        private void ModVideoCMS_Opening(object sender, CancelEventArgs e)
        {
            Form VideoModForm = new VideoModForm();
            VideoModForm.MdiParent = this;
            VideoModForm.Show();

        }

        private void ClientCMS_Opening(object sender, CancelEventArgs e)
        {
            Form ClientForm = new ClientForm();
            ClientForm.MdiParent = this;
            ClientForm.Show();

        }

       
    }  
}
