
namespace WypożyczalniaVideo
{
    partial class VideoModForm
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
            this.ModSearchDG = new System.Windows.Forms.DataGridView();
            this.ModSearchBTN = new System.Windows.Forms.Button();
            this.ModAddBTN = new System.Windows.Forms.Button();
            this.ModDeleteBTN = new System.Windows.Forms.Button();
            this.ModModifyBTN = new System.Windows.Forms.Button();
            this.ModSearchLB = new System.Windows.Forms.Label();
            this.ModSearchCB = new System.Windows.Forms.ComboBox();
            this.ModSearchTB = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.ModSearchDG)).BeginInit();
            this.SuspendLayout();
            // 
            // ModSearchDG
            // 
            this.ModSearchDG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ModSearchDG.Location = new System.Drawing.Point(63, 90);
            this.ModSearchDG.Name = "ModSearchDG";
            this.ModSearchDG.Size = new System.Drawing.Size(673, 276);
            this.ModSearchDG.TabIndex = 0;
            // 
            // ModSearchBTN
            // 
            this.ModSearchBTN.Location = new System.Drawing.Point(311, 50);
            this.ModSearchBTN.Name = "ModSearchBTN";
            this.ModSearchBTN.Size = new System.Drawing.Size(155, 31);
            this.ModSearchBTN.TabIndex = 3;
            this.ModSearchBTN.Text = "Wyszukaj";
            this.ModSearchBTN.UseVisualStyleBackColor = true;
            this.ModSearchBTN.Click += new System.EventHandler(this.ModSearchBTN_Click);
            // 
            // ModAddBTN
            // 
            this.ModAddBTN.Location = new System.Drawing.Point(114, 387);
            this.ModAddBTN.Name = "ModAddBTN";
            this.ModAddBTN.Size = new System.Drawing.Size(155, 31);
            this.ModAddBTN.TabIndex = 4;
            this.ModAddBTN.Text = "Dodaj Video";
            this.ModAddBTN.UseVisualStyleBackColor = true;
            this.ModAddBTN.Click += new System.EventHandler(this.ModAddBTN_Click);
            // 
            // ModDeleteBTN
            // 
            this.ModDeleteBTN.Location = new System.Drawing.Point(311, 387);
            this.ModDeleteBTN.Name = "ModDeleteBTN";
            this.ModDeleteBTN.Size = new System.Drawing.Size(155, 31);
            this.ModDeleteBTN.TabIndex = 5;
            this.ModDeleteBTN.Text = "Usuń Video";
            this.ModDeleteBTN.UseVisualStyleBackColor = true;
            this.ModDeleteBTN.Click += new System.EventHandler(this.ModDeleteBTN_Click);
            // 
            // ModModifyBTN
            // 
            this.ModModifyBTN.Location = new System.Drawing.Point(519, 387);
            this.ModModifyBTN.Name = "ModModifyBTN";
            this.ModModifyBTN.Size = new System.Drawing.Size(155, 31);
            this.ModModifyBTN.TabIndex = 6;
            this.ModModifyBTN.Text = "Modyfikuj Video";
            this.ModModifyBTN.UseVisualStyleBackColor = true;
            this.ModModifyBTN.Click += new System.EventHandler(this.ModModifyBTN_Click);
            // 
            // ModSearchLB
            // 
            this.ModSearchLB.AutoSize = true;
            this.ModSearchLB.Location = new System.Drawing.Point(187, 14);
            this.ModSearchLB.Name = "ModSearchLB";
            this.ModSearchLB.Size = new System.Drawing.Size(59, 15);
            this.ModSearchLB.TabIndex = 2;
            this.ModSearchLB.Text = "Wyszukaj:";
            // 
            // ModSearchCB
            // 
            this.ModSearchCB.FormattingEnabled = true;
            this.ModSearchCB.Items.AddRange(new object[] {
            "Tytuł",
            "Kategoria"});
            this.ModSearchCB.Location = new System.Drawing.Point(267, 11);
            this.ModSearchCB.Name = "ModSearchCB";
            this.ModSearchCB.Size = new System.Drawing.Size(131, 23);
            this.ModSearchCB.TabIndex = 1;
            // 
            // ModSearchTB
            // 
            this.ModSearchTB.Location = new System.Drawing.Point(416, 11);
            this.ModSearchTB.Name = "ModSearchTB";
            this.ModSearchTB.Size = new System.Drawing.Size(154, 23);
            this.ModSearchTB.TabIndex = 2;
            // 
            // VideoModForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ModSearchTB);
            this.Controls.Add(this.ModSearchCB);
            this.Controls.Add(this.ModSearchLB);
            this.Controls.Add(this.ModModifyBTN);
            this.Controls.Add(this.ModDeleteBTN);
            this.Controls.Add(this.ModAddBTN);
            this.Controls.Add(this.ModSearchBTN);
            this.Controls.Add(this.ModSearchDG);
            this.Name = "VideoModForm";
            this.Text = "Modyfikacja Video";
            ((System.ComponentModel.ISupportInitialize)(this.ModSearchDG)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button ModSearchBTN;
        private System.Windows.Forms.Button ModAddBTN;
        private System.Windows.Forms.Button ModDeleteBTN;
        private System.Windows.Forms.Button ModModifyBTN;
        private System.Windows.Forms.Label ModSearchLB;
        private System.Windows.Forms.ComboBox ModSearchCB;
        private System.Windows.Forms.TextBox ModSearchTB;
        public System.Windows.Forms.DataGridView ModSearchDG;
    }
}