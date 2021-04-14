
namespace WypożyczalniaVideo
{
    partial class BorrowForm
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
            this.SearchBorrowDG = new System.Windows.Forms.DataGridView();
            this.Wyszukajlb = new System.Windows.Forms.Label();
            this.SearchborrowTB = new System.Windows.Forms.TextBox();
            this.SearchTypeCB = new System.Windows.Forms.ComboBox();
            this.SearchBorrowBTN = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.SearchBorrowDG)).BeginInit();
            this.SuspendLayout();
            // 
            // SearchBorrowDG
            // 
            this.SearchBorrowDG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SearchBorrowDG.Location = new System.Drawing.Point(12, 30);
            this.SearchBorrowDG.Name = "SearchBorrowDG";
            this.SearchBorrowDG.Size = new System.Drawing.Size(335, 328);
            this.SearchBorrowDG.TabIndex = 0;
            // 
            // Wyszukajlb
            // 
            this.Wyszukajlb.AutoSize = true;
            this.Wyszukajlb.Location = new System.Drawing.Point(359, 33);
            this.Wyszukajlb.Name = "Wyszukajlb";
            this.Wyszukajlb.Size = new System.Drawing.Size(76, 15);
            this.Wyszukajlb.TabIndex = 1;
            this.Wyszukajlb.Text = "Wyszukaj po:";
            // 
            // SearchborrowTB
            // 
            this.SearchborrowTB.Location = new System.Drawing.Point(558, 30);
            this.SearchborrowTB.Name = "SearchborrowTB";
            this.SearchborrowTB.Size = new System.Drawing.Size(171, 23);
            this.SearchborrowTB.TabIndex = 2;
            // 
            // SearchTypeCB
            // 
            this.SearchTypeCB.FormattingEnabled = true;
            this.SearchTypeCB.Items.AddRange(new object[] {
            "Kategoria",
            "Tytuł"});
            this.SearchTypeCB.Location = new System.Drawing.Point(441, 30);
            this.SearchTypeCB.Name = "SearchTypeCB";
            this.SearchTypeCB.Size = new System.Drawing.Size(111, 23);
            this.SearchTypeCB.TabIndex = 3;
            // 
            // SearchBorrowBTN
            // 
            this.SearchBorrowBTN.Location = new System.Drawing.Point(472, 71);
            this.SearchBorrowBTN.Name = "SearchBorrowBTN";
            this.SearchBorrowBTN.Size = new System.Drawing.Size(129, 33);
            this.SearchBorrowBTN.TabIndex = 5;
            this.SearchBorrowBTN.Text = "Wyszukaj";
            this.SearchBorrowBTN.UseVisualStyleBackColor = true;
            this.SearchBorrowBTN.Click += new System.EventHandler(this.button2_Click);
            // 
            // BorrowForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.SearchBorrowBTN);
            this.Controls.Add(this.SearchTypeCB);
            this.Controls.Add(this.SearchborrowTB);
            this.Controls.Add(this.Wyszukajlb);
            this.Controls.Add(this.SearchBorrowDG);
            this.Name = "BorrowForm";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.SearchBorrowDG)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView SearchBorrowDG;
        private System.Windows.Forms.Label Wyszukajlb;
        private System.Windows.Forms.TextBox SearchborrowTB;
        private System.Windows.Forms.ComboBox SearchTypeCB;
        private System.Windows.Forms.Button SearchBorrowBTN;
        
    }
}