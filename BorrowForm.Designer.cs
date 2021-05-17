
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
            this.BookBorrowLB = new System.Windows.Forms.Label();
            this.FirstnameBorrowLB = new System.Windows.Forms.Label();
            this.LastnameBorrowLB = new System.Windows.Forms.Label();
            this.TitleBorrowTB = new System.Windows.Forms.TextBox();
            this.FirstnameBorrowTB = new System.Windows.Forms.TextBox();
            this.LastnameBorrowTB = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
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
            this.Wyszukajlb.Location = new System.Drawing.Point(390, 81);
            this.Wyszukajlb.Name = "Wyszukajlb";
            this.Wyszukajlb.Size = new System.Drawing.Size(76, 15);
            this.Wyszukajlb.TabIndex = 1;
            this.Wyszukajlb.Text = "Wyszukaj po:";
            // 
            // SearchborrowTB
            // 
            this.SearchborrowTB.Location = new System.Drawing.Point(589, 78);
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
            this.SearchTypeCB.Location = new System.Drawing.Point(472, 78);
            this.SearchTypeCB.Name = "SearchTypeCB";
            this.SearchTypeCB.Size = new System.Drawing.Size(111, 23);
            this.SearchTypeCB.TabIndex = 1;
            // 
            // SearchBorrowBTN
            // 
            this.SearchBorrowBTN.Location = new System.Drawing.Point(503, 119);
            this.SearchBorrowBTN.Name = "SearchBorrowBTN";
            this.SearchBorrowBTN.Size = new System.Drawing.Size(129, 33);
            this.SearchBorrowBTN.TabIndex = 3;
            this.SearchBorrowBTN.Text = "Wyszukaj";
            this.SearchBorrowBTN.UseVisualStyleBackColor = true;
            this.SearchBorrowBTN.Click += new System.EventHandler(this.button2_Click);
            // 
            // BookBorrowLB
            // 
            this.BookBorrowLB.AutoSize = true;
            this.BookBorrowLB.Location = new System.Drawing.Point(431, 214);
            this.BookBorrowLB.Name = "BookBorrowLB";
            this.BookBorrowLB.Size = new System.Drawing.Size(35, 15);
            this.BookBorrowLB.TabIndex = 1;
            this.BookBorrowLB.Text = "Tytuł:";
            // 
            // FirstnameBorrowLB
            // 
            this.FirstnameBorrowLB.AutoSize = true;
            this.FirstnameBorrowLB.Location = new System.Drawing.Point(431, 250);
            this.FirstnameBorrowLB.Name = "FirstnameBorrowLB";
            this.FirstnameBorrowLB.Size = new System.Drawing.Size(33, 15);
            this.FirstnameBorrowLB.TabIndex = 1;
            this.FirstnameBorrowLB.Text = "Imię:";
            // 
            // LastnameBorrowLB
            // 
            this.LastnameBorrowLB.AutoSize = true;
            this.LastnameBorrowLB.Location = new System.Drawing.Point(431, 283);
            this.LastnameBorrowLB.Name = "LastnameBorrowLB";
            this.LastnameBorrowLB.Size = new System.Drawing.Size(60, 15);
            this.LastnameBorrowLB.TabIndex = 1;
            this.LastnameBorrowLB.Text = "Nazwisko:";
            // 
            // TitleBorrowTB
            // 
            this.TitleBorrowTB.Location = new System.Drawing.Point(503, 211);
            this.TitleBorrowTB.Name = "TitleBorrowTB";
            this.TitleBorrowTB.Size = new System.Drawing.Size(171, 23);
            this.TitleBorrowTB.TabIndex = 4;
            // 
            // FirstnameBorrowTB
            // 
            this.FirstnameBorrowTB.Location = new System.Drawing.Point(503, 247);
            this.FirstnameBorrowTB.Name = "FirstnameBorrowTB";
            this.FirstnameBorrowTB.Size = new System.Drawing.Size(171, 23);
            this.FirstnameBorrowTB.TabIndex = 5;
            // 
            // LastnameBorrowTB
            // 
            this.LastnameBorrowTB.Location = new System.Drawing.Point(503, 280);
            this.LastnameBorrowTB.Name = "LastnameBorrowTB";
            this.LastnameBorrowTB.Size = new System.Drawing.Size(171, 23);
            this.LastnameBorrowTB.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(488, 340);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(143, 51);
            this.button1.TabIndex = 7;
            this.button1.Text = "Wypożycz";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // BorrowForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.SearchBorrowBTN);
            this.Controls.Add(this.SearchTypeCB);
            this.Controls.Add(this.LastnameBorrowTB);
            this.Controls.Add(this.FirstnameBorrowTB);
            this.Controls.Add(this.TitleBorrowTB);
            this.Controls.Add(this.SearchborrowTB);
            this.Controls.Add(this.LastnameBorrowLB);
            this.Controls.Add(this.FirstnameBorrowLB);
            this.Controls.Add(this.BookBorrowLB);
            this.Controls.Add(this.Wyszukajlb);
            this.Controls.Add(this.SearchBorrowDG);
            this.Name = "BorrowForm";
            this.Text = "Wypozyczanie video";
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
        private System.Windows.Forms.Label BookBorrowLB;
        private System.Windows.Forms.Label FirstnameBorrowLB;
        private System.Windows.Forms.Label LastnameBorrowLB;
        private System.Windows.Forms.TextBox TitleBorrowTB;
        private System.Windows.Forms.TextBox FirstnameBorrowTB;
        private System.Windows.Forms.TextBox LastnameBorrowTB;
        private System.Windows.Forms.Button button1;
    }
}