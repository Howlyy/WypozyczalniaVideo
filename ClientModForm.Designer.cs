
namespace WypożyczalniaVideo
{
    partial class ClientModForm
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
            this.ClientModBTN = new System.Windows.Forms.Button();
            this.ClientModPeselTB = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ClientModLastTB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ClientModFirstTB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ClientModTelTB = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // ClientModBTN
            // 
            this.ClientModBTN.Location = new System.Drawing.Point(42, 151);
            this.ClientModBTN.Name = "ClientModBTN";
            this.ClientModBTN.Size = new System.Drawing.Size(169, 45);
            this.ClientModBTN.TabIndex = 22;
            this.ClientModBTN.Text = "Modyfikuj";
            this.ClientModBTN.UseVisualStyleBackColor = true;
            // 
            // ClientModPeselTB
            // 
            this.ClientModPeselTB.Location = new System.Drawing.Point(93, 82);
            this.ClientModPeselTB.Name = "ClientModPeselTB";
            this.ClientModPeselTB.Size = new System.Drawing.Size(142, 23);
            this.ClientModPeselTB.TabIndex = 19;
            this.ClientModPeselTB.Text = ClientForm.client_pesel;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 15);
            this.label3.TabIndex = 23;
            this.label3.Text = "Pesel:";
            // 
            // ClientModLastTB
            // 
            this.ClientModLastTB.Location = new System.Drawing.Point(93, 53);
            this.ClientModLastTB.Name = "ClientModLastTB";
            this.ClientModLastTB.Size = new System.Drawing.Size(142, 23);
            this.ClientModLastTB.TabIndex = 20;
            this.ClientModLastTB.Text = ClientForm.client_lastname;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 15);
            this.label1.TabIndex = 24;
            this.label1.Text = "Nazwisko:";
            // 
            // ClientModFirstTB
            // 
            this.ClientModFirstTB.Location = new System.Drawing.Point(93, 24);
            this.ClientModFirstTB.Name = "ClientModFirstTB";
            this.ClientModFirstTB.Size = new System.Drawing.Size(142, 23);
            this.ClientModFirstTB.TabIndex = 21;
            this.ClientModFirstTB.Text = ClientForm.client_firstname;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 15);
            this.label2.TabIndex = 25;
            this.label2.Text = "Imię:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 15);
            this.label4.TabIndex = 23;
            this.label4.Text = "Nr Tel:";
            // 
            // ClientModTelTB
            // 
            this.ClientModTelTB.Location = new System.Drawing.Point(93, 111);
            this.ClientModTelTB.Name = "ClientModTelTB";
            this.ClientModTelTB.Size = new System.Drawing.Size(142, 23);
            this.ClientModTelTB.TabIndex = 19;
            this.ClientModTelTB.Text = ClientForm.client_nrtel;
            // 
            // ClientModForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(291, 234);
            this.Controls.Add(this.ClientModBTN);
            this.Controls.Add(this.ClientModTelTB);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ClientModPeselTB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ClientModLastTB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ClientModFirstTB);
            this.Controls.Add(this.label2);
            this.Name = "ClientModForm";
            this.Text = "ClientModForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ClientModBTN;
        private System.Windows.Forms.TextBox ClientModPeselTB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox ClientModLastTB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ClientModFirstTB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox ClientModTelTB;
    }
}