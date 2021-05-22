
namespace WypożyczalniaVideo
{
    partial class ClientForm
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
            this.ClientSearchTB = new System.Windows.Forms.TextBox();
            this.ClientSearchCB = new System.Windows.Forms.ComboBox();
            this.ClientSearchLB = new System.Windows.Forms.Label();
            this.ClientModBTN = new System.Windows.Forms.Button();
            this.ClientDeleteBTN = new System.Windows.Forms.Button();
            this.ClientAddBTN = new System.Windows.Forms.Button();
            this.ClientSearchBTN = new System.Windows.Forms.Button();
            this.ClientSearchDG = new System.Windows.Forms.DataGridView();
            this.ClientSearchLastTB = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.ClientSearchDG)).BeginInit();
            this.SuspendLayout();
            // 
            // ClientSearchTB
            // 
            this.ClientSearchTB.Location = new System.Drawing.Point(417, 22);
            this.ClientSearchTB.Name = "ClientSearchTB";
            this.ClientSearchTB.Size = new System.Drawing.Size(154, 23);
            this.ClientSearchTB.TabIndex = 2;
            // 
            // ClientSearchCB
            // 
            this.ClientSearchCB.FormattingEnabled = true;
            this.ClientSearchCB.Items.AddRange(new object[] {
            "Imię i nazwisko",
            "Pesel",
            "Nrtel"});
            this.ClientSearchCB.Location = new System.Drawing.Point(268, 22);
            this.ClientSearchCB.Name = "ClientSearchCB";
            this.ClientSearchCB.Size = new System.Drawing.Size(131, 23);
            this.ClientSearchCB.TabIndex = 1;
            this.ClientSearchCB.SelectedIndexChanged += new System.EventHandler(this.ClientSearchCB_SelectedIndexChanged);
            // 
            // ClientSearchLB
            // 
            this.ClientSearchLB.AutoSize = true;
            this.ClientSearchLB.Location = new System.Drawing.Point(119, 25);
            this.ClientSearchLB.Name = "ClientSearchLB";
            this.ClientSearchLB.Size = new System.Drawing.Size(143, 15);
            this.ClientSearchLB.TabIndex = 10;
            this.ClientSearchLB.Text = "Wyszukaj kontrahenta po:";
            // 
            // ClientModBTN
            // 
            this.ClientModBTN.Location = new System.Drawing.Point(520, 398);
            this.ClientModBTN.Name = "ClientModBTN";
            this.ClientModBTN.Size = new System.Drawing.Size(155, 31);
            this.ClientModBTN.TabIndex = 7;
            this.ClientModBTN.Text = "Modyfikuj kontrahenta";
            this.ClientModBTN.UseVisualStyleBackColor = true;
            this.ClientModBTN.Click += new System.EventHandler(this.ClientModBTN_Click);
            // 
            // ClientDeleteBTN
            // 
            this.ClientDeleteBTN.Location = new System.Drawing.Point(312, 398);
            this.ClientDeleteBTN.Name = "ClientDeleteBTN";
            this.ClientDeleteBTN.Size = new System.Drawing.Size(155, 31);
            this.ClientDeleteBTN.TabIndex = 6;
            this.ClientDeleteBTN.Text = "Usuń kontrahenta";
            this.ClientDeleteBTN.UseVisualStyleBackColor = true;
            this.ClientDeleteBTN.Click += new System.EventHandler(this.ClientDeleteBTN_Click);
            // 
            // ClientAddBTN
            // 
            this.ClientAddBTN.Location = new System.Drawing.Point(115, 398);
            this.ClientAddBTN.Name = "ClientAddBTN";
            this.ClientAddBTN.Size = new System.Drawing.Size(155, 31);
            this.ClientAddBTN.TabIndex = 5;
            this.ClientAddBTN.Text = "Dodaj konrahenta";
            this.ClientAddBTN.UseVisualStyleBackColor = true;
            this.ClientAddBTN.Click += new System.EventHandler(this.ClientAddBTN_Click);
            // 
            // ClientSearchBTN
            // 
            this.ClientSearchBTN.Location = new System.Drawing.Point(312, 61);
            this.ClientSearchBTN.Name = "ClientSearchBTN";
            this.ClientSearchBTN.Size = new System.Drawing.Size(155, 31);
            this.ClientSearchBTN.TabIndex = 4;
            this.ClientSearchBTN.Text = "Wyszukaj";
            this.ClientSearchBTN.UseVisualStyleBackColor = true;
            this.ClientSearchBTN.Click += new System.EventHandler(this.ClientSearchBTN_Click);
            // 
            // ClientSearchDG
            // 
            this.ClientSearchDG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ClientSearchDG.Location = new System.Drawing.Point(64, 101);
            this.ClientSearchDG.Name = "ClientSearchDG";
            this.ClientSearchDG.Size = new System.Drawing.Size(673, 276);
            this.ClientSearchDG.TabIndex = 5;
            // 
            // ClientSearchLastTB
            // 
            this.ClientSearchLastTB.Location = new System.Drawing.Point(583, 22);
            this.ClientSearchLastTB.Name = "ClientSearchLastTB";
            this.ClientSearchLastTB.Size = new System.Drawing.Size(154, 23);
            this.ClientSearchLastTB.TabIndex = 3;
            this.ClientSearchLastTB.Visible = false;
            // 
            // ClientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ClientSearchLastTB);
            this.Controls.Add(this.ClientSearchTB);
            this.Controls.Add(this.ClientSearchCB);
            this.Controls.Add(this.ClientSearchLB);
            this.Controls.Add(this.ClientModBTN);
            this.Controls.Add(this.ClientDeleteBTN);
            this.Controls.Add(this.ClientAddBTN);
            this.Controls.Add(this.ClientSearchBTN);
            this.Controls.Add(this.ClientSearchDG);
            this.Name = "ClientForm";
            this.Text = "Kontrahent";
            ((System.ComponentModel.ISupportInitialize)(this.ClientSearchDG)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ClientSearchTB;
        private System.Windows.Forms.ComboBox ClientSearchCB;
        private System.Windows.Forms.Label ClientSearchLB;
        private System.Windows.Forms.Button ClientModBTN;
        private System.Windows.Forms.Button ClientDeleteBTN;
        private System.Windows.Forms.Button ClientAddBTN;
        private System.Windows.Forms.Button ClientSearchBTN;
        public System.Windows.Forms.DataGridView ClientSearchDG;
        private System.Windows.Forms.TextBox ClientSearchLastTB;
    }
}