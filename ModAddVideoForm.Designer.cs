
namespace WypożyczalniaVideo
{
    partial class ModAddVideoForm
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
            this.ModAddVideoBTN = new System.Windows.Forms.Button();
            this.ModAddTitleTB = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ModAddCategoryCB = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ModAddQuantityNUD = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.ModAddQuantityNUD)).BeginInit();
            this.SuspendLayout();
            // 
            // ModAddVideoBTN
            // 
            this.ModAddVideoBTN.Location = new System.Drawing.Point(75, 148);
            this.ModAddVideoBTN.Name = "ModAddVideoBTN";
            this.ModAddVideoBTN.Size = new System.Drawing.Size(169, 45);
            this.ModAddVideoBTN.TabIndex = 4;
            this.ModAddVideoBTN.Text = "Dodaj";
            this.ModAddVideoBTN.UseVisualStyleBackColor = true;
            this.ModAddVideoBTN.Click += new System.EventHandler(this.ModAddVideoBTN_Click);
            // 
            // ModAddTitleTB
            // 
            this.ModAddTitleTB.Location = new System.Drawing.Point(123, 36);
            this.ModAddTitleTB.Name = "ModAddTitleTB";
            this.ModAddTitleTB.Size = new System.Drawing.Size(142, 23);
            this.ModAddTitleTB.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(57, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Ilość:";
            // 
            // ModAddCategoryCB
            // 
            this.ModAddCategoryCB.FormattingEnabled = true;
            this.ModAddCategoryCB.Items.AddRange(new object[] {
            "Akcja",
            "Komedia",
            "Horror",
            "Thriller",
            "Romans",
            "Sci-fi",
            "Dramat"});
            this.ModAddCategoryCB.Location = new System.Drawing.Point(123, 94);
            this.ModAddCategoryCB.Name = "ModAddCategoryCB";
            this.ModAddCategoryCB.Size = new System.Drawing.Size(142, 23);
            this.ModAddCategoryCB.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(57, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 15);
            this.label4.TabIndex = 5;
            this.label4.Text = "Kategoria:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(57, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "Tytuł:";
            // 
            // ModAddQuantityNUD
            // 
            this.ModAddQuantityNUD.Location = new System.Drawing.Point(123, 65);
            this.ModAddQuantityNUD.Name = "ModAddQuantityNUD";
            this.ModAddQuantityNUD.Size = new System.Drawing.Size(39, 23);
            this.ModAddQuantityNUD.TabIndex = 7;
            // 
            // ModAddVideoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(326, 221);
            this.Controls.Add(this.ModAddQuantityNUD);
            this.Controls.Add(this.ModAddVideoBTN);
            this.Controls.Add(this.ModAddTitleTB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ModAddCategoryCB);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Name = "ModAddVideoForm";
            this.Text = "Dodawanie Video";
            ((System.ComponentModel.ISupportInitialize)(this.ModAddQuantityNUD)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ModAddVideoBTN;
        private System.Windows.Forms.TextBox ModAddTitleTB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox ModAddCategoryCB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown ModAddQuantityNUD;
    }
}