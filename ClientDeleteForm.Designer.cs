
namespace WypożyczalniaVideo
{
    partial class ClientDeleteForm
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
            this.ClientDeleteBTN = new System.Windows.Forms.Button();
            this.ClientDeleteFirstTB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ClientDeleteLastTB = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ClientDeletePeselTB = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // ClientDeleteBTN
            // 
            this.ClientDeleteBTN.Location = new System.Drawing.Point(69, 136);
            this.ClientDeleteBTN.Name = "ClientDeleteBTN";
            this.ClientDeleteBTN.Size = new System.Drawing.Size(169, 45);
            this.ClientDeleteBTN.TabIndex = 17;
            this.ClientDeleteBTN.Text = "Usuń";
            this.ClientDeleteBTN.UseVisualStyleBackColor = true;
            this.ClientDeleteBTN.Click += new System.EventHandler(this.ClientDeleteBTN_Click);
            // 
            // ClientDeleteFirstTB
            // 
            this.ClientDeleteFirstTB.Location = new System.Drawing.Point(109, 34);
            this.ClientDeleteFirstTB.Name = "ClientDeleteFirstTB";
            this.ClientDeleteFirstTB.Size = new System.Drawing.Size(142, 23);
            this.ClientDeleteFirstTB.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 15);
            this.label2.TabIndex = 18;
            this.label2.Text = "Imię:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 15);
            this.label1.TabIndex = 18;
            this.label1.Text = "Nazwisko:";
            // 
            // ClientDeleteLastTB
            // 
            this.ClientDeleteLastTB.Location = new System.Drawing.Point(109, 63);
            this.ClientDeleteLastTB.Name = "ClientDeleteLastTB";
            this.ClientDeleteLastTB.Size = new System.Drawing.Size(142, 23);
            this.ClientDeleteLastTB.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 15);
            this.label3.TabIndex = 18;
            this.label3.Text = "Pesel:";
            // 
            // ClientDeletePeselTB
            // 
            this.ClientDeletePeselTB.Location = new System.Drawing.Point(109, 92);
            this.ClientDeletePeselTB.Name = "ClientDeletePeselTB";
            this.ClientDeletePeselTB.Size = new System.Drawing.Size(142, 23);
            this.ClientDeletePeselTB.TabIndex = 14;
            // 
            // ClientDeleteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(340, 208);
            this.Controls.Add(this.ClientDeleteBTN);
            this.Controls.Add(this.ClientDeletePeselTB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ClientDeleteLastTB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ClientDeleteFirstTB);
            this.Controls.Add(this.label2);
            this.Name = "ClientDeleteForm";
            this.Text = "Usuwanie kontrahenta";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ClientDeleteBTN;
        private System.Windows.Forms.TextBox ClientDeleteFirstTB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ClientDeleteLastTB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox ClientDeletePeselTB;
    }
}