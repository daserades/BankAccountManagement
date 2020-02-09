namespace BankWindowsFormsApp
{
    partial class MusteriDetay
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MusteriDetay));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageParaCekme = new System.Windows.Forms.TabPage();
            this.tabPageParaYatırma = new System.Windows.Forms.TabPage();
            this.labelHesapNumarası = new System.Windows.Forms.Label();
            this.labelMiktar = new System.Windows.Forms.Label();
            this.textBoxHn = new System.Windows.Forms.TextBox();
            this.textBoxM = new System.Windows.Forms.TextBox();
            this.btnCek = new System.Windows.Forms.Button();
            this.btnYatir = new System.Windows.Forms.Button();
            this.textBoxMik = new System.Windows.Forms.TextBox();
            this.textBoxHesN = new System.Windows.Forms.TextBox();
            this.labelMik = new System.Windows.Forms.Label();
            this.labelHesN = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPageParaCekme.SuspendLayout();
            this.tabPageParaYatırma.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageParaCekme);
            this.tabControl1.Controls.Add(this.tabPageParaYatırma);
            this.tabControl1.Location = new System.Drawing.Point(13, 13);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(775, 425);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPageParaCekme
            // 
            this.tabPageParaCekme.Controls.Add(this.btnCek);
            this.tabPageParaCekme.Controls.Add(this.textBoxM);
            this.tabPageParaCekme.Controls.Add(this.textBoxHn);
            this.tabPageParaCekme.Controls.Add(this.labelMiktar);
            this.tabPageParaCekme.Controls.Add(this.labelHesapNumarası);
            this.tabPageParaCekme.Location = new System.Drawing.Point(4, 22);
            this.tabPageParaCekme.Name = "tabPageParaCekme";
            this.tabPageParaCekme.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageParaCekme.Size = new System.Drawing.Size(767, 399);
            this.tabPageParaCekme.TabIndex = 0;
            this.tabPageParaCekme.Text = "Para Çekme";
            this.tabPageParaCekme.UseVisualStyleBackColor = true;
            // 
            // tabPageParaYatırma
            // 
            this.tabPageParaYatırma.Controls.Add(this.btnYatir);
            this.tabPageParaYatırma.Controls.Add(this.textBoxMik);
            this.tabPageParaYatırma.Controls.Add(this.textBoxHesN);
            this.tabPageParaYatırma.Controls.Add(this.labelMik);
            this.tabPageParaYatırma.Controls.Add(this.labelHesN);
            this.tabPageParaYatırma.Location = new System.Drawing.Point(4, 22);
            this.tabPageParaYatırma.Name = "tabPageParaYatırma";
            this.tabPageParaYatırma.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageParaYatırma.Size = new System.Drawing.Size(767, 399);
            this.tabPageParaYatırma.TabIndex = 1;
            this.tabPageParaYatırma.Text = "Para Yatırma";
            this.tabPageParaYatırma.UseVisualStyleBackColor = true;
            // 
            // labelHesapNumarası
            // 
            this.labelHesapNumarası.AutoSize = true;
            this.labelHesapNumarası.Location = new System.Drawing.Point(242, 163);
            this.labelHesapNumarası.Name = "labelHesapNumarası";
            this.labelHesapNumarası.Size = new System.Drawing.Size(85, 13);
            this.labelHesapNumarası.TabIndex = 0;
            this.labelHesapNumarası.Text = "Hesap Numarası";
            // 
            // labelMiktar
            // 
            this.labelMiktar.AutoSize = true;
            this.labelMiktar.Location = new System.Drawing.Point(242, 189);
            this.labelMiktar.Name = "labelMiktar";
            this.labelMiktar.Size = new System.Drawing.Size(36, 13);
            this.labelMiktar.TabIndex = 1;
            this.labelMiktar.Text = "Miktar";
            // 
            // textBoxHn
            // 
            this.textBoxHn.Location = new System.Drawing.Point(351, 160);
            this.textBoxHn.Name = "textBoxHn";
            this.textBoxHn.Size = new System.Drawing.Size(147, 20);
            this.textBoxHn.TabIndex = 2;
            // 
            // textBoxM
            // 
            this.textBoxM.Location = new System.Drawing.Point(351, 186);
            this.textBoxM.Name = "textBoxM";
            this.textBoxM.Size = new System.Drawing.Size(147, 20);
            this.textBoxM.TabIndex = 3;
            // 
            // btnCek
            // 
            this.btnCek.Location = new System.Drawing.Point(423, 226);
            this.btnCek.Name = "btnCek";
            this.btnCek.Size = new System.Drawing.Size(75, 43);
            this.btnCek.TabIndex = 4;
            this.btnCek.Text = "Çek";
            this.btnCek.UseVisualStyleBackColor = true;
            this.btnCek.Click += new System.EventHandler(this.btnCek_Click);
            // 
            // btnYatir
            // 
            this.btnYatir.Location = new System.Drawing.Point(436, 211);
            this.btnYatir.Name = "btnYatir";
            this.btnYatir.Size = new System.Drawing.Size(75, 43);
            this.btnYatir.TabIndex = 9;
            this.btnYatir.Text = "Yatır";
            this.btnYatir.UseVisualStyleBackColor = true;
            this.btnYatir.Click += new System.EventHandler(this.btnYatir_Click);
            // 
            // textBoxMik
            // 
            this.textBoxMik.Location = new System.Drawing.Point(364, 171);
            this.textBoxMik.Name = "textBoxMik";
            this.textBoxMik.Size = new System.Drawing.Size(147, 20);
            this.textBoxMik.TabIndex = 8;
            // 
            // textBoxHesN
            // 
            this.textBoxHesN.Location = new System.Drawing.Point(364, 145);
            this.textBoxHesN.Name = "textBoxHesN";
            this.textBoxHesN.Size = new System.Drawing.Size(147, 20);
            this.textBoxHesN.TabIndex = 7;
            // 
            // labelMik
            // 
            this.labelMik.AutoSize = true;
            this.labelMik.Location = new System.Drawing.Point(255, 174);
            this.labelMik.Name = "labelMik";
            this.labelMik.Size = new System.Drawing.Size(36, 13);
            this.labelMik.TabIndex = 6;
            this.labelMik.Text = "Miktar";
            // 
            // labelHesN
            // 
            this.labelHesN.AutoSize = true;
            this.labelHesN.Location = new System.Drawing.Point(255, 148);
            this.labelHesN.Name = "labelHesN";
            this.labelHesN.Size = new System.Drawing.Size(85, 13);
            this.labelHesN.TabIndex = 5;
            this.labelHesN.Text = "Hesap Numarası";
            // 
            // MusteriDetay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MusteriDetay";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Banka Hesap Yönetimi (Müşteri)";
            this.tabControl1.ResumeLayout(false);
            this.tabPageParaCekme.ResumeLayout(false);
            this.tabPageParaCekme.PerformLayout();
            this.tabPageParaYatırma.ResumeLayout(false);
            this.tabPageParaYatırma.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageParaCekme;
        private System.Windows.Forms.Button btnCek;
        private System.Windows.Forms.TextBox textBoxM;
        private System.Windows.Forms.TextBox textBoxHn;
        private System.Windows.Forms.Label labelMiktar;
        private System.Windows.Forms.Label labelHesapNumarası;
        private System.Windows.Forms.TabPage tabPageParaYatırma;
        private System.Windows.Forms.Button btnYatir;
        private System.Windows.Forms.TextBox textBoxMik;
        private System.Windows.Forms.TextBox textBoxHesN;
        private System.Windows.Forms.Label labelMik;
        private System.Windows.Forms.Label labelHesN;
    }
}