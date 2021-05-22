
namespace WypożyczalniaVideo
{
    partial class ReturnForm

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
            this.SearchReturnDG = new System.Windows.Forms.DataGridView();
            this.SearchBorrowBTN = new System.Windows.Forms.Button();
            this.SearchTypeReturnCB = new System.Windows.Forms.ComboBox();
            this.SearchreturnTB = new System.Windows.Forms.TextBox();
            this.Wyszukajlb = new System.Windows.Forms.Label();
            this.ReturnBTN = new System.Windows.Forms.Button();
            this.LastnameReturnTB = new System.Windows.Forms.TextBox();
            this.FirstnameReturnTB = new System.Windows.Forms.TextBox();
            this.TitleReturnTB = new System.Windows.Forms.TextBox();
            this.LastnameBorrowLB = new System.Windows.Forms.Label();
            this.FirstnameBorrowLB = new System.Windows.Forms.Label();
            this.BookBorrowLB = new System.Windows.Forms.Label();
            this.ReturnSearchLastnameTB = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.SearchReturnDG)).BeginInit();
            this.SuspendLayout();
            // 
            // SearchReturnDG
            // 
            this.SearchReturnDG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SearchReturnDG.Location = new System.Drawing.Point(12, 12);
            this.SearchReturnDG.Name = "SearchReturnDG";
            this.SearchReturnDG.Size = new System.Drawing.Size(341, 426);
            this.SearchReturnDG.TabIndex = 0;
            // 
            // SearchBorrowBTN
            // 
            this.SearchBorrowBTN.Location = new System.Drawing.Point(504, 52);
            this.SearchBorrowBTN.Name = "SearchBorrowBTN";
            this.SearchBorrowBTN.Size = new System.Drawing.Size(129, 33);
            this.SearchBorrowBTN.TabIndex = 4;
            this.SearchBorrowBTN.Text = "Wyszukaj";
            this.SearchBorrowBTN.UseVisualStyleBackColor = true;
            this.SearchBorrowBTN.Click += new System.EventHandler(this.SearchReturnBTN_Click);
            // 
            // SearchTypeReturnCB
            // 
            this.SearchTypeReturnCB.FormattingEnabled = true;
            this.SearchTypeReturnCB.Items.AddRange(new object[] {
            "Tytuł",
            "Imię i nazwisko"});
            this.SearchTypeReturnCB.Location = new System.Drawing.Point(448, 23);
            this.SearchTypeReturnCB.Name = "SearchTypeReturnCB";
            this.SearchTypeReturnCB.Size = new System.Drawing.Size(111, 23);
            this.SearchTypeReturnCB.TabIndex = 1;
            this.SearchTypeReturnCB.SelectedIndexChanged += new System.EventHandler(this.SearchTypeReturnCB_SelectedIndexChanged);
            // 
            // SearchreturnTB
            // 
            this.SearchreturnTB.Location = new System.Drawing.Point(565, 23);
            this.SearchreturnTB.Name = "SearchreturnTB";
            this.SearchreturnTB.Size = new System.Drawing.Size(111, 23);
            this.SearchreturnTB.TabIndex = 2;
            // 
            // Wyszukajlb
            // 
            this.Wyszukajlb.AutoSize = true;
            this.Wyszukajlb.Location = new System.Drawing.Point(366, 26);
            this.Wyszukajlb.Name = "Wyszukajlb";
            this.Wyszukajlb.Size = new System.Drawing.Size(76, 15);
            this.Wyszukajlb.TabIndex = 6;
            this.Wyszukajlb.Text = "Wyszukaj po:";
            // 
            // ReturnBTN
            // 
            this.ReturnBTN.Location = new System.Drawing.Point(490, 321);
            this.ReturnBTN.Name = "ReturnBTN";
            this.ReturnBTN.Size = new System.Drawing.Size(143, 51);
            this.ReturnBTN.TabIndex = 8;
            this.ReturnBTN.Text = "Zwróć";
            this.ReturnBTN.UseVisualStyleBackColor = true;
            this.ReturnBTN.Click += new System.EventHandler(this.ReturnBTN_Click);
            // 
            // LastnameReturnTB
            // 
            this.LastnameReturnTB.Location = new System.Drawing.Point(505, 261);
            this.LastnameReturnTB.Name = "LastnameReturnTB";
            this.LastnameReturnTB.Size = new System.Drawing.Size(171, 23);
            this.LastnameReturnTB.TabIndex = 7;
            // 
            // FirstnameReturnTB
            // 
            this.FirstnameReturnTB.Location = new System.Drawing.Point(505, 228);
            this.FirstnameReturnTB.Name = "FirstnameReturnTB";
            this.FirstnameReturnTB.Size = new System.Drawing.Size(171, 23);
            this.FirstnameReturnTB.TabIndex = 6;
            // 
            // TitleReturnTB
            // 
            this.TitleReturnTB.Location = new System.Drawing.Point(505, 192);
            this.TitleReturnTB.Name = "TitleReturnTB";
            this.TitleReturnTB.Size = new System.Drawing.Size(171, 23);
            this.TitleReturnTB.TabIndex = 5;
            // 
            // LastnameBorrowLB
            // 
            this.LastnameBorrowLB.AutoSize = true;
            this.LastnameBorrowLB.Location = new System.Drawing.Point(433, 264);
            this.LastnameBorrowLB.Name = "LastnameBorrowLB";
            this.LastnameBorrowLB.Size = new System.Drawing.Size(60, 15);
            this.LastnameBorrowLB.TabIndex = 10;
            this.LastnameBorrowLB.Text = "Nazwisko:";
            // 
            // FirstnameBorrowLB
            // 
            this.FirstnameBorrowLB.AutoSize = true;
            this.FirstnameBorrowLB.Location = new System.Drawing.Point(433, 231);
            this.FirstnameBorrowLB.Name = "FirstnameBorrowLB";
            this.FirstnameBorrowLB.Size = new System.Drawing.Size(33, 15);
            this.FirstnameBorrowLB.TabIndex = 11;
            this.FirstnameBorrowLB.Text = "Imię:";
            // 
            // BookBorrowLB
            // 
            this.BookBorrowLB.AutoSize = true;
            this.BookBorrowLB.Location = new System.Drawing.Point(433, 195);
            this.BookBorrowLB.Name = "BookBorrowLB";
            this.BookBorrowLB.Size = new System.Drawing.Size(35, 15);
            this.BookBorrowLB.TabIndex = 12;
            this.BookBorrowLB.Text = "Tytuł:";
            // 
            // ReturnSearchLastnameTB
            // 
            this.ReturnSearchLastnameTB.Location = new System.Drawing.Point(682, 23);
            this.ReturnSearchLastnameTB.Name = "ReturnSearchLastnameTB";
            this.ReturnSearchLastnameTB.Size = new System.Drawing.Size(111, 23);
            this.ReturnSearchLastnameTB.TabIndex = 3;
            this.ReturnSearchLastnameTB.Visible = false;
            // 
            // ReturnForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ReturnBTN);
            this.Controls.Add(this.LastnameReturnTB);
            this.Controls.Add(this.FirstnameReturnTB);
            this.Controls.Add(this.TitleReturnTB);
            this.Controls.Add(this.LastnameBorrowLB);
            this.Controls.Add(this.FirstnameBorrowLB);
            this.Controls.Add(this.BookBorrowLB);
            this.Controls.Add(this.SearchBorrowBTN);
            this.Controls.Add(this.SearchTypeReturnCB);
            this.Controls.Add(this.ReturnSearchLastnameTB);
            this.Controls.Add(this.SearchreturnTB);
            this.Controls.Add(this.Wyszukajlb);
            this.Controls.Add(this.SearchReturnDG);
            this.Name = "ReturnForm";
            this.Text = "Zwracanie Video";
            ((System.ComponentModel.ISupportInitialize)(this.SearchReturnDG)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView SearchReturnDG;
        private System.Windows.Forms.Button SearchBorrowBTN;
        private System.Windows.Forms.ComboBox SearchTypeReturnCB;
        private System.Windows.Forms.TextBox SearchreturnTB;
        private System.Windows.Forms.Label Wyszukajlb;
        private System.Windows.Forms.Button ReturnBTN;
        private System.Windows.Forms.TextBox LastnameReturnTB;
        private System.Windows.Forms.TextBox FirstnameReturnTB;
        private System.Windows.Forms.TextBox TitleReturnTB;
        private System.Windows.Forms.Label LastnameBorrowLB;
        private System.Windows.Forms.Label FirstnameBorrowLB;
        private System.Windows.Forms.Label BookBorrowLB;
        private System.Windows.Forms.TextBox ReturnSearchLastnameTB;
    }
}