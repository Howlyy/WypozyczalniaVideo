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
            new BorrowForm().Show();
        }

        private void ReturnCMS_Opening(object sender, CancelEventArgs e)
        {
            new ReturnForm().Show();
        }

        private void ModVideoCMS_Opening(object sender, CancelEventArgs e)
        {
            new VideoModForm().Show();
        }

        private void ClientCMS_Opening(object sender, CancelEventArgs e)
        {
            new ClientForm().Show();
        }
    }  
}
