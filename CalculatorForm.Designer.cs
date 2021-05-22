
namespace WypożyczalniaVideo
{
    partial class CalculatorForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.NBNettoTB = new System.Windows.Forms.TextBox();
            this.NBCalculateBTN = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.NBVatCB = new System.Windows.Forms.ComboBox();
            this.NBBruttoTB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.BNVatCB = new System.Windows.Forms.ComboBox();
            this.BNCalculateBTN = new System.Windows.Forms.Button();
            this.BNNettoTB = new System.Windows.Forms.TextBox();
            this.BNBruttoTB = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.NKMarzaCB = new System.Windows.Forms.ComboBox();
            this.NKVatCB = new System.Windows.Forms.ComboBox();
            this.NKCalculateBTN = new System.Windows.Forms.Button();
            this.NKEndPriceTB = new System.Windows.Forms.TextBox();
            this.NKNettoTB = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.KOOdsetkiCB = new System.Windows.Forms.ComboBox();
            this.KOMarzaCB = new System.Windows.Forms.ComboBox();
            this.KOVatCB = new System.Windows.Forms.ComboBox();
            this.KOCalculateBTN = new System.Windows.Forms.Button();
            this.KOEndpriceTB = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.KONettoTB = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kwota netto:";
            // 
            // NBNettoTB
            // 
            this.NBNettoTB.Location = new System.Drawing.Point(98, 34);
            this.NBNettoTB.Name = "NBNettoTB";
            this.NBNettoTB.Size = new System.Drawing.Size(99, 23);
            this.NBNettoTB.TabIndex = 1;
            // 
            // NBCalculateBTN
            // 
            this.NBCalculateBTN.Location = new System.Drawing.Point(83, 118);
            this.NBCalculateBTN.Name = "NBCalculateBTN";
            this.NBCalculateBTN.Size = new System.Drawing.Size(128, 28);
            this.NBCalculateBTN.TabIndex = 2;
            this.NBCalculateBTN.Text = "Wylicz";
            this.NBCalculateBTN.UseVisualStyleBackColor = true;
            this.NBCalculateBTN.Click += new System.EventHandler(this.NBCalculateBTN_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.NBVatCB);
            this.groupBox1.Controls.Add(this.NBCalculateBTN);
            this.groupBox1.Controls.Add(this.NBBruttoTB);
            this.groupBox1.Controls.Add(this.NBNettoTB);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(26, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(284, 152);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Netto na brutto";
            // 
            // NBVatCB
            // 
            this.NBVatCB.FormattingEnabled = true;
            this.NBVatCB.Items.AddRange(new object[] {
            "23%",
            "8%"});
            this.NBVatCB.Location = new System.Drawing.Point(232, 34);
            this.NBVatCB.Name = "NBVatCB";
            this.NBVatCB.Size = new System.Drawing.Size(46, 23);
            this.NBVatCB.TabIndex = 4;
            // 
            // NBBruttoTB
            // 
            this.NBBruttoTB.Enabled = false;
            this.NBBruttoTB.Location = new System.Drawing.Point(98, 74);
            this.NBBruttoTB.Name = "NBBruttoTB";
            this.NBBruttoTB.Size = new System.Drawing.Size(128, 23);
            this.NBBruttoTB.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(203, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Vat:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "Kwota brutto:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.BNVatCB);
            this.groupBox2.Controls.Add(this.BNCalculateBTN);
            this.groupBox2.Controls.Add(this.BNNettoTB);
            this.groupBox2.Controls.Add(this.BNBruttoTB);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(383, 25);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(284, 152);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Brutto na netto";
            // 
            // BNVatCB
            // 
            this.BNVatCB.FormattingEnabled = true;
            this.BNVatCB.Items.AddRange(new object[] {
            "23%",
            "8%"});
            this.BNVatCB.Location = new System.Drawing.Point(232, 34);
            this.BNVatCB.Name = "BNVatCB";
            this.BNVatCB.Size = new System.Drawing.Size(46, 23);
            this.BNVatCB.TabIndex = 4;
            // 
            // BNCalculateBTN
            // 
            this.BNCalculateBTN.Location = new System.Drawing.Point(83, 118);
            this.BNCalculateBTN.Name = "BNCalculateBTN";
            this.BNCalculateBTN.Size = new System.Drawing.Size(128, 28);
            this.BNCalculateBTN.TabIndex = 2;
            this.BNCalculateBTN.Text = "Wylicz";
            this.BNCalculateBTN.UseVisualStyleBackColor = true;
            this.BNCalculateBTN.Click += new System.EventHandler(this.BNCalculateBTN_Click);
            // 
            // BNNettoTB
            // 
            this.BNNettoTB.Enabled = false;
            this.BNNettoTB.Location = new System.Drawing.Point(98, 74);
            this.BNNettoTB.Name = "BNNettoTB";
            this.BNNettoTB.Size = new System.Drawing.Size(128, 23);
            this.BNNettoTB.TabIndex = 1;
            // 
            // BNBruttoTB
            // 
            this.BNBruttoTB.Location = new System.Drawing.Point(98, 34);
            this.BNBruttoTB.Name = "BNBruttoTB";
            this.BNBruttoTB.Size = new System.Drawing.Size(99, 23);
            this.BNBruttoTB.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(203, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 15);
            this.label4.TabIndex = 0;
            this.label4.Text = "Vat:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 77);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 15);
            this.label5.TabIndex = 0;
            this.label5.Text = "Kwota netto:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 37);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 15);
            this.label6.TabIndex = 0;
            this.label6.Text = "Kwota brutto:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.NKMarzaCB);
            this.groupBox3.Controls.Add(this.NKVatCB);
            this.groupBox3.Controls.Add(this.NKCalculateBTN);
            this.groupBox3.Controls.Add(this.NKEndPriceTB);
            this.groupBox3.Controls.Add(this.NKNettoTB);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Location = new System.Drawing.Point(26, 205);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(284, 208);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Netto na kwotę końcową";
            // 
            // NKMarzaCB
            // 
            this.NKMarzaCB.FormattingEnabled = true;
            this.NKMarzaCB.Items.AddRange(new object[] {
            "10%",
            "20%",
            "30%",
            "40%"});
            this.NKMarzaCB.Location = new System.Drawing.Point(180, 74);
            this.NKMarzaCB.Name = "NKMarzaCB";
            this.NKMarzaCB.Size = new System.Drawing.Size(46, 23);
            this.NKMarzaCB.TabIndex = 4;
            // 
            // NKVatCB
            // 
            this.NKVatCB.FormattingEnabled = true;
            this.NKVatCB.Items.AddRange(new object[] {
            "23%",
            "8%"});
            this.NKVatCB.Location = new System.Drawing.Point(71, 74);
            this.NKVatCB.Name = "NKVatCB";
            this.NKVatCB.Size = new System.Drawing.Size(46, 23);
            this.NKVatCB.TabIndex = 4;
            // 
            // NKCalculateBTN
            // 
            this.NKCalculateBTN.Location = new System.Drawing.Point(83, 160);
            this.NKCalculateBTN.Name = "NKCalculateBTN";
            this.NKCalculateBTN.Size = new System.Drawing.Size(128, 28);
            this.NKCalculateBTN.TabIndex = 2;
            this.NKCalculateBTN.Text = "Wylicz";
            this.NKCalculateBTN.UseVisualStyleBackColor = true;
            this.NKCalculateBTN.Click += new System.EventHandler(this.NKCalculateBTN_Click);
            // 
            // NKEndPriceTB
            // 
            this.NKEndPriceTB.Enabled = false;
            this.NKEndPriceTB.Location = new System.Drawing.Point(127, 115);
            this.NKEndPriceTB.Name = "NKEndPriceTB";
            this.NKEndPriceTB.Size = new System.Drawing.Size(128, 23);
            this.NKEndPriceTB.TabIndex = 1;
            // 
            // NKNettoTB
            // 
            this.NKNettoTB.Location = new System.Drawing.Point(127, 34);
            this.NKNettoTB.Name = "NKNettoTB";
            this.NKNettoTB.Size = new System.Drawing.Size(128, 23);
            this.NKNettoTB.TabIndex = 1;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(132, 77);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(42, 15);
            this.label10.TabIndex = 0;
            this.label10.Text = "Marża:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(42, 77);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(26, 15);
            this.label7.TabIndex = 0;
            this.label7.Text = "Vat:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(27, 118);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(94, 15);
            this.label8.TabIndex = 0;
            this.label8.Text = "Kwota końcowa:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(47, 37);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(74, 15);
            this.label9.TabIndex = 0;
            this.label9.Text = "Kwota netto:";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.KOOdsetkiCB);
            this.groupBox4.Controls.Add(this.KOMarzaCB);
            this.groupBox4.Controls.Add(this.KOVatCB);
            this.groupBox4.Controls.Add(this.KOCalculateBTN);
            this.groupBox4.Controls.Add(this.KOEndpriceTB);
            this.groupBox4.Controls.Add(this.label15);
            this.groupBox4.Controls.Add(this.KONettoTB);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Controls.Add(this.label12);
            this.groupBox4.Controls.Add(this.label13);
            this.groupBox4.Controls.Add(this.label14);
            this.groupBox4.Location = new System.Drawing.Point(383, 205);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(356, 208);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Kwota po odsetkach";
            // 
            // KOOdsetkiCB
            // 
            this.KOOdsetkiCB.FormattingEnabled = true;
            this.KOOdsetkiCB.Items.AddRange(new object[] {
            "12%",
            "24%",
            "36%"});
            this.KOOdsetkiCB.Location = new System.Drawing.Point(288, 74);
            this.KOOdsetkiCB.Name = "KOOdsetkiCB";
            this.KOOdsetkiCB.Size = new System.Drawing.Size(46, 23);
            this.KOOdsetkiCB.TabIndex = 4;
            // 
            // KOMarzaCB
            // 
            this.KOMarzaCB.FormattingEnabled = true;
            this.KOMarzaCB.Items.AddRange(new object[] {
            "10%",
            "20%",
            "30%",
            "40%"});
            this.KOMarzaCB.Location = new System.Drawing.Point(165, 74);
            this.KOMarzaCB.Name = "KOMarzaCB";
            this.KOMarzaCB.Size = new System.Drawing.Size(46, 23);
            this.KOMarzaCB.TabIndex = 4;
            // 
            // KOVatCB
            // 
            this.KOVatCB.FormattingEnabled = true;
            this.KOVatCB.Items.AddRange(new object[] {
            "23%",
            "8%"});
            this.KOVatCB.Location = new System.Drawing.Point(42, 74);
            this.KOVatCB.Name = "KOVatCB";
            this.KOVatCB.Size = new System.Drawing.Size(46, 23);
            this.KOVatCB.TabIndex = 4;
            // 
            // KOCalculateBTN
            // 
            this.KOCalculateBTN.Location = new System.Drawing.Point(83, 160);
            this.KOCalculateBTN.Name = "KOCalculateBTN";
            this.KOCalculateBTN.Size = new System.Drawing.Size(128, 28);
            this.KOCalculateBTN.TabIndex = 2;
            this.KOCalculateBTN.Text = "Wylicz";
            this.KOCalculateBTN.UseVisualStyleBackColor = true;
            this.KOCalculateBTN.Click += new System.EventHandler(this.KOCalculateBTN_Click);
            // 
            // KOEndpriceTB
            // 
            this.KOEndpriceTB.Enabled = false;
            this.KOEndpriceTB.Location = new System.Drawing.Point(201, 115);
            this.KOEndpriceTB.Name = "KOEndpriceTB";
            this.KOEndpriceTB.Size = new System.Drawing.Size(128, 23);
            this.KOEndpriceTB.TabIndex = 1;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(232, 77);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(50, 15);
            this.label15.TabIndex = 0;
            this.label15.Text = "Odsetki:";
            // 
            // KONettoTB
            // 
            this.KONettoTB.Location = new System.Drawing.Point(127, 34);
            this.KONettoTB.Name = "KONettoTB";
            this.KONettoTB.Size = new System.Drawing.Size(128, 23);
            this.KONettoTB.TabIndex = 1;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(117, 77);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(42, 15);
            this.label11.TabIndex = 0;
            this.label11.Text = "Marża:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(13, 77);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(26, 15);
            this.label12.TabIndex = 0;
            this.label12.Text = "Vat:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(27, 118);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(168, 15);
            this.label13.TabIndex = 0;
            this.label13.Text = "Kwota końcowa po odsetkach:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(47, 37);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(74, 15);
            this.label14.TabIndex = 0;
            this.label14.Text = "Kwota netto:";
            // 
            // CalculatorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Name = "CalculatorForm";
            this.Text = "CalculatorForm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox NBNettoTB;
        private System.Windows.Forms.Button NBCalculateBTN;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox NBVatCB;
        private System.Windows.Forms.TextBox NBBruttoTB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox BNVatCB;
        private System.Windows.Forms.Button BNCalculateBTN;
        private System.Windows.Forms.TextBox BNNettoTB;
        private System.Windows.Forms.TextBox BNBruttoTB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox NKMarzaCB;
        private System.Windows.Forms.ComboBox NKVatCB;
        private System.Windows.Forms.Button NKCalculateBTN;
        private System.Windows.Forms.TextBox NKEndPriceTB;
        private System.Windows.Forms.TextBox NKNettoTB;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ComboBox KOOdsetkiCB;
        private System.Windows.Forms.ComboBox KOMarzaCB;
        private System.Windows.Forms.ComboBox KOVatCB;
        private System.Windows.Forms.Button KOCalculateBTN;
        private System.Windows.Forms.TextBox KOEndpriceTB;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox KONettoTB;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
    }
}