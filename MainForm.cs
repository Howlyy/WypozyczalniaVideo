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

        /// <summary>
        /// Metoda uzycia(otwarcia) przycisku w menustripsie "Wypożycz". Otwiera nowe okno BorrowForm w MdiContenerze(MAinForm).
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BorrowCMS_Opening(object sender, CancelEventArgs e)
        {

            Form BorrowForm = new BorrowForm();
            BorrowForm.MdiParent = this;
            BorrowForm.Show();
        }
        /// <summary>
        /// Metoda uzycia(otwarcia) przycisku w menustripsie "Zwróć". Otwiera nowe okno ReturnForm w MdiContenerze(MAinForm).
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ReturnCMS_Opening(object sender, CancelEventArgs e)
        {
            Form ReturnForm = new ReturnForm();
            ReturnForm.MdiParent = this;
            ReturnForm.Show();
        }

        /// <summary>
        /// Metoda uzycia(otwarcia) przycisku w menustripsie "Modyfikuj video". Otwiera nowe okno VideoModForm w MdiContenerze(MAinForm).
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ModVideoCMS_Opening(object sender, CancelEventArgs e)
        {
            Form VideoModForm = new VideoModForm();
            VideoModForm.MdiParent = this;
            VideoModForm.Show();

        }

        /// <summary>
        /// Metoda uzycia(otwarcia) przycisku w menustripsie "Kontrahent". Otwiera nowe okno ClientForm w MdiContenerze(MAinForm).
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ClientCMS_Opening(object sender, CancelEventArgs e)
        {
            Form ClientForm = new ClientForm();
            ClientForm.MdiParent = this;
            ClientForm.Show();

        }

       
    }  
}
