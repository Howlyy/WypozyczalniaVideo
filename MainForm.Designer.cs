
namespace WypożyczalniaVideo
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.VideoTSM = new System.Windows.Forms.ToolStripMenuItem();
            this.VideoBorrowCMS = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.VideoBorrowTSM = new System.Windows.Forms.ToolStripMenuItem();
            this.BorrowCMS = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.VideoReturnTSM = new System.Windows.Forms.ToolStripMenuItem();
            this.ReturnCMS = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.VideoModTMS = new System.Windows.Forms.ToolStripMenuItem();
            this.ModVideoCMS = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ClientTSM = new System.Windows.Forms.ToolStripMenuItem();
            this.ClientCMS = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.CalculatorTSM = new System.Windows.Forms.ToolStripMenuItem();
            this.CalculatorCMS = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuStrip1.SuspendLayout();
            this.VideoBorrowCMS.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.VideoTSM,
            this.ClientTSM,
            this.CalculatorTSM});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(984, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // VideoTSM
            // 
            this.VideoTSM.DropDown = this.VideoBorrowCMS;
            this.VideoTSM.Name = "VideoTSM";
            this.VideoTSM.Size = new System.Drawing.Size(49, 20);
            this.VideoTSM.Text = "Video";
            // 
            // VideoBorrowCMS
            // 
            this.VideoBorrowCMS.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.VideoBorrowTSM,
            this.VideoReturnTSM,
            this.VideoModTMS});
            this.VideoBorrowCMS.Name = "VideoBorrowCMS";
            this.VideoBorrowCMS.OwnerItem = this.VideoTSM;
            this.VideoBorrowCMS.Size = new System.Drawing.Size(172, 70);
            this.VideoBorrowCMS.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // VideoBorrowTSM
            // 
            this.VideoBorrowTSM.DropDown = this.BorrowCMS;
            this.VideoBorrowTSM.Name = "VideoBorrowTSM";
            this.VideoBorrowTSM.Size = new System.Drawing.Size(171, 22);
            this.VideoBorrowTSM.Text = "Wypożycz";
            // 
            // BorrowCMS
            // 
            this.BorrowCMS.Name = "contextMenuStrip1";
            this.BorrowCMS.OwnerItem = this.VideoBorrowTSM;
            this.BorrowCMS.Size = new System.Drawing.Size(61, 4);
            this.BorrowCMS.Text = "Wypozycz";
            this.BorrowCMS.Opening += new System.ComponentModel.CancelEventHandler(this.BorrowCMS_Opening);
            this.BorrowCMS.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // VideoReturnTSM
            // 
            this.VideoReturnTSM.DropDown = this.ReturnCMS;
            this.VideoReturnTSM.Name = "VideoReturnTSM";
            this.VideoReturnTSM.Size = new System.Drawing.Size(171, 22);
            this.VideoReturnTSM.Text = "Zwróć";
            // 
            // ReturnCMS
            // 
            this.ReturnCMS.Name = "ReturnCMS";
            this.ReturnCMS.OwnerItem = this.VideoReturnTSM;
            this.ReturnCMS.Size = new System.Drawing.Size(61, 4);
            this.ReturnCMS.Text = "Zwróć";
            this.ReturnCMS.Opening += new System.ComponentModel.CancelEventHandler(this.ReturnCMS_Opening);
            this.ReturnCMS.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // VideoModTMS
            // 
            this.VideoModTMS.DropDown = this.ModVideoCMS;
            this.VideoModTMS.Name = "VideoModTMS";
            this.VideoModTMS.Size = new System.Drawing.Size(171, 22);
            this.VideoModTMS.Text = "Modyfikacja video";
            // 
            // ModVideoCMS
            // 
            this.ModVideoCMS.Name = "ModVideoCMS";
            this.ModVideoCMS.OwnerItem = this.VideoModTMS;
            this.ModVideoCMS.Size = new System.Drawing.Size(61, 4);
            this.ModVideoCMS.Opening += new System.ComponentModel.CancelEventHandler(this.ModVideoCMS_Opening);
            this.ModVideoCMS.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // ClientTSM
            // 
            this.ClientTSM.DropDown = this.ClientCMS;
            this.ClientTSM.Name = "ClientTSM";
            this.ClientTSM.Size = new System.Drawing.Size(83, 20);
            this.ClientTSM.Text = "Kontrahenci";
            // 
            // ClientCMS
            // 
            this.ClientCMS.Name = "ClientCMS";
            this.ClientCMS.OwnerItem = this.ClientTSM;
            this.ClientCMS.Size = new System.Drawing.Size(61, 4);
            this.ClientCMS.Opening += new System.ComponentModel.CancelEventHandler(this.ClientCMS_Opening);
            this.ClientCMS.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // CalculatorTSM
            // 
            this.CalculatorTSM.DropDown = this.CalculatorCMS;
            this.CalculatorTSM.Name = "CalculatorTSM";
            this.CalculatorTSM.Size = new System.Drawing.Size(72, 20);
            this.CalculatorTSM.Text = "Kalkulator";
            // 
            // CalculatorCMS
            // 
            this.CalculatorCMS.Name = "CalculatorCMS";
            this.CalculatorCMS.Size = new System.Drawing.Size(61, 4);
            this.CalculatorCMS.Opening += new System.ComponentModel.CancelEventHandler(this.CalculatorCMS_Opening);
            this.CalculatorCMS.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 761);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.Name = "MainForm";
            this.Text = "Wypożyczalnia Video";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.VideoBorrowCMS.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem VideoTSM;
        private System.Windows.Forms.ContextMenuStrip BorrowCMS;
        private System.Windows.Forms.ContextMenuStrip ReturnCMS;
        private System.Windows.Forms.ContextMenuStrip VideoBorrowCMS;
        private System.Windows.Forms.ToolStripMenuItem VideoBorrowTSM;
        private System.Windows.Forms.ToolStripMenuItem VideoReturnTSM;
        private System.Windows.Forms.ContextMenuStrip ModVideoCMS;
        private System.Windows.Forms.ToolStripMenuItem VideoModTMS;
        private System.Windows.Forms.ToolStripMenuItem ClientTSM;
        private System.Windows.Forms.ContextMenuStrip ClientCMS;
        private System.Windows.Forms.ToolStripMenuItem CalculatorTSM;
        private System.Windows.Forms.ContextMenuStrip CalculatorCMS;
    }
}