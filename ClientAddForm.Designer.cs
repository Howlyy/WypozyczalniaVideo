
namespace WypożyczalniaVideo
{
    partial class ClientAddForm
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
            this.ClientAddBTN = new System.Windows.Forms.Button();
            this.ClientAddPeselTB = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ClientAddLastTB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ClientAddFirstTB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ClientAddTelTB = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // ClientAddBTN
            // 
            this.ClientAddBTN.Location = new System.Drawing.Point(64, 165);
            this.ClientAddBTN.Name = "ClientAddBTN";
            this.ClientAddBTN.Size = new System.Drawing.Size(169, 45);
            this.ClientAddBTN.TabIndex = 5;
            this.ClientAddBTN.Text = "Dodaj";
            this.ClientAddBTN.UseVisualStyleBackColor = true;
            this.ClientAddBTN.Click += new System.EventHandler(this.ClientAddBTN_Click);
            // 
            // ClientAddPeselTB
            // 
            this.ClientAddPeselTB.Location = new System.Drawing.Point(102, 85);
            this.ClientAddPeselTB.MaxLength = 11;
            this.ClientAddPeselTB.Name = "ClientAddPeselTB";
            this.ClientAddPeselTB.Size = new System.Drawing.Size(142, 23);
            this.ClientAddPeselTB.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 15);
            this.label3.TabIndex = 23;
            this.label3.Text = "Pesel:";
            // 
            // ClientAddLastTB
            // 
            this.ClientAddLastTB.Location = new System.Drawing.Point(102, 56);
            this.ClientAddLastTB.Name = "ClientAddLastTB";
            this.ClientAddLastTB.Size = new System.Drawing.Size(142, 23);
            this.ClientAddLastTB.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 15);
            this.label1.TabIndex = 24;
            this.label1.Text = "Nazwisko:";
            // 
            // ClientAddFirstTB
            // 
            this.ClientAddFirstTB.Location = new System.Drawing.Point(102, 27);
            this.ClientAddFirstTB.Name = "ClientAddFirstTB";
            this.ClientAddFirstTB.Size = new System.Drawing.Size(142, 23);
            this.ClientAddFirstTB.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 15);
            this.label2.TabIndex = 25;
            this.label2.Text = "Imię:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 15);
            this.label4.TabIndex = 23;
            this.label4.Text = "Nr Tel:";
            // 
            // ClientAddTelTB
            // 
            this.ClientAddTelTB.Location = new System.Drawing.Point(102, 114);
            this.ClientAddTelTB.MaxLength = 9;
            this.ClientAddTelTB.Name = "ClientAddTelTB";
            this.ClientAddTelTB.Size = new System.Drawing.Size(142, 23);
            this.ClientAddTelTB.TabIndex = 4;
            // 
            // ClientAddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(305, 222);
            this.Controls.Add(this.ClientAddBTN);
            this.Controls.Add(this.ClientAddTelTB);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ClientAddPeselTB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ClientAddLastTB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ClientAddFirstTB);
            this.Controls.Add(this.label2);
            this.Name = "ClientAddForm";
            this.Text = "Dodawanie kontrahenta";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ClientAddBTN;
        private System.Windows.Forms.TextBox ClientAddPeselTB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox ClientAddLastTB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ClientAddFirstTB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox ClientAddTelTB;
    }
}