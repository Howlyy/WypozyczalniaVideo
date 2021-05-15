
namespace WypożyczalniaVideo
{
    partial class ModDeleteForm
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
            this.ModDeleteVideoBTN = new System.Windows.Forms.Button();
            this.ModDeleteTitleTB = new System.Windows.Forms.TextBox();
            this.ModDeleteCategoryCB = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ModDeleteVideoBTN
            // 
            this.ModDeleteVideoBTN.Location = new System.Drawing.Point(66, 120);
            this.ModDeleteVideoBTN.Name = "ModDeleteVideoBTN";
            this.ModDeleteVideoBTN.Size = new System.Drawing.Size(169, 45);
            this.ModDeleteVideoBTN.TabIndex = 4;
            this.ModDeleteVideoBTN.Text = "Usuń";
            this.ModDeleteVideoBTN.UseVisualStyleBackColor = true;
            this.ModDeleteVideoBTN.Click += new System.EventHandler(this.ModDeleteVideoBTN_Click);
            // 
            // ModDeleteTitleTB
            // 
            this.ModDeleteTitleTB.Location = new System.Drawing.Point(112, 35);
            this.ModDeleteTitleTB.Name = "ModDeleteTitleTB";
            this.ModDeleteTitleTB.Size = new System.Drawing.Size(142, 23);
            this.ModDeleteTitleTB.TabIndex = 1;
            // 
            // ModDeleteCategoryCB
            // 
            this.ModDeleteCategoryCB.FormattingEnabled = true;
            this.ModDeleteCategoryCB.Items.AddRange(new object[] {
            "Akcja",
            "Komedia",
            "Horror",
            "Thriller",
            "Romans",
            "Sci-fi",
            "Dramat"});
            this.ModDeleteCategoryCB.Location = new System.Drawing.Point(112, 76);
            this.ModDeleteCategoryCB.Name = "ModDeleteCategoryCB";
            this.ModDeleteCategoryCB.Size = new System.Drawing.Size(142, 23);
            this.ModDeleteCategoryCB.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(46, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Kategoria:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 15);
            this.label2.TabIndex = 13;
            this.label2.Text = "Tytuł:";
            // 
            // ModDeleteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(301, 199);
            this.Controls.Add(this.ModDeleteVideoBTN);
            this.Controls.Add(this.ModDeleteTitleTB);
            this.Controls.Add(this.ModDeleteCategoryCB);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Name = "ModDeleteForm";
            this.Text = "Usuwanie Video";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button ModDeleteVideoBTN;
        private System.Windows.Forms.TextBox ModDeleteTitleTB;
        private System.Windows.Forms.ComboBox ModDeleteCategoryCB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
    }
}