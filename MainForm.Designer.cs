
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.VideoTSM = new System.Windows.Forms.ToolStripMenuItem();
            this.VideoBorrowTSM = new System.Windows.Forms.ToolStripMenuItem();
            this.VideoBackTSM = new System.Windows.Forms.ToolStripMenuItem();
            this.VideoModTSM = new System.Windows.Forms.ToolStripMenuItem();
            this.CategoryModTSM = new System.Windows.Forms.ToolStripMenuItem();
            this.ClientTSM = new System.Windows.Forms.ToolStripMenuItem();
            this.ClientModTSM = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.VideoTSM,
            this.ClientTSM});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(984, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // VideoTSM
            // 
            this.VideoTSM.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.VideoBorrowTSM,
            this.VideoBackTSM,
            this.VideoModTSM,
            this.CategoryModTSM});
            this.VideoTSM.Name = "VideoTSM";
            this.VideoTSM.Size = new System.Drawing.Size(49, 20);
            this.VideoTSM.Text = "Video";
            // 
            // VideoBorrowTSM
            // 
            this.VideoBorrowTSM.Name = "VideoBorrowTSM";
            this.VideoBorrowTSM.Size = new System.Drawing.Size(232, 22);
            this.VideoBorrowTSM.Text = "Wypożycz ";
            // 
            // VideoBackTSM
            // 
            this.VideoBackTSM.Name = "VideoBackTSM";
            this.VideoBackTSM.Size = new System.Drawing.Size(232, 22);
            this.VideoBackTSM.Text = "Zwrot";
            // 
            // VideoModTSM
            // 
            this.VideoModTSM.Name = "VideoModTSM";
            this.VideoModTSM.Size = new System.Drawing.Size(232, 22);
            this.VideoModTSM.Text = "Panel zarzadzania Video";
            // 
            // CategoryModTSM
            // 
            this.CategoryModTSM.Name = "CategoryModTSM";
            this.CategoryModTSM.Size = new System.Drawing.Size(232, 22);
            this.CategoryModTSM.Text = "Panel zarządzania kategoriami";
            // 
            // ClientTSM
            // 
            this.ClientTSM.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ClientModTSM});
            this.ClientTSM.Name = "ClientTSM";
            this.ClientTSM.Size = new System.Drawing.Size(78, 20);
            this.ClientTSM.Text = "Kontrahent";
            // 
            // ClientModTSM
            // 
            this.ClientModTSM.Name = "ClientModTSM";
            this.ClientModTSM.Size = new System.Drawing.Size(163, 22);
            this.ClientModTSM.Text = "Panel zarządzana";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 761);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Wypożyczalnia Video";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem VideoTSM;
        private System.Windows.Forms.ToolStripMenuItem ClientTSM;
        private System.Windows.Forms.ToolStripMenuItem VideoBorrowTSM;
        private System.Windows.Forms.ToolStripMenuItem VideoBackTSM;
        private System.Windows.Forms.ToolStripMenuItem VideoModTSM;
        private System.Windows.Forms.ToolStripMenuItem ClientModTSM;
        private System.Windows.Forms.ToolStripMenuItem CategoryModTSM;
    }
}