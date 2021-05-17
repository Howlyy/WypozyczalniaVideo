
namespace WypożyczalniaVideo
{
    partial class ModModForm
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
            this.ModModQuantityNUD = new System.Windows.Forms.NumericUpDown();
            this.ModModVideoBTN = new System.Windows.Forms.Button();
            this.ModModTitleTB = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ModModCategoryCB = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ModModQuantityNUD)).BeginInit();
            this.SuspendLayout();
            // 
            // ModModQuantityNUD
            // 
            this.ModModQuantityNUD.Location = new System.Drawing.Point(119, 73);
            this.ModModQuantityNUD.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.ModModQuantityNUD.Name = "ModModQuantityNUD";
            this.ModModQuantityNUD.Size = new System.Drawing.Size(39, 23);
            this.ModModQuantityNUD.TabIndex = 2;
            // 
            // ModModVideoBTN
            // 
            this.ModModVideoBTN.Location = new System.Drawing.Point(71, 156);
            this.ModModVideoBTN.Name = "ModModVideoBTN";
            this.ModModVideoBTN.Size = new System.Drawing.Size(169, 45);
            this.ModModVideoBTN.TabIndex = 4;
            this.ModModVideoBTN.Text = "Modyfikuj";
            this.ModModVideoBTN.UseVisualStyleBackColor = true;
            this.ModModVideoBTN.Click += new System.EventHandler(this.ModModVideoBTN_Click);
            // 
            // ModModTitleTB
            // 
            this.ModModTitleTB.Location = new System.Drawing.Point(119, 44);
            this.ModModTitleTB.Name = "ModModTitleTB";
            this.ModModTitleTB.Size = new System.Drawing.Size(142, 23);
            this.ModModTitleTB.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(53, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 15);
            this.label3.TabIndex = 11;
            this.label3.Text = "Ilość:";
            // 
            // ModModCategoryCB
            // 
            this.ModModCategoryCB.FormattingEnabled = true;
            this.ModModCategoryCB.Items.AddRange(new object[] {
            "Akcja",
            "Komedia",
            "Horror",
            "Thriller",
            "Romans",
            "Sci-fi",
            "Dramat"});
            this.ModModCategoryCB.Location = new System.Drawing.Point(119, 102);
            this.ModModCategoryCB.Name = "ModModCategoryCB";
            this.ModModCategoryCB.Size = new System.Drawing.Size(142, 23);
            this.ModModCategoryCB.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(53, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 15);
            this.label4.TabIndex = 12;
            this.label4.Text = "Kategoria:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(53, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 15);
            this.label2.TabIndex = 13;
            this.label2.Text = "Tytuł:";
            // 
            // ModModForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(321, 237);
            this.Controls.Add(this.ModModQuantityNUD);
            this.Controls.Add(this.ModModVideoBTN);
            this.Controls.Add(this.ModModTitleTB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ModModCategoryCB);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Name = "ModModForm";
            this.Text = "Modyfikacja Video";
            ((System.ComponentModel.ISupportInitialize)(this.ModModQuantityNUD)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown ModModQuantityNUD;
        private System.Windows.Forms.Button ModModVideoBTN;
        private System.Windows.Forms.TextBox ModModTitleTB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox ModModCategoryCB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
    }
}