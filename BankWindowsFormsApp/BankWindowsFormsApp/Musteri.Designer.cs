namespace BankWindowsFormsApp
{
    partial class Musteri
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Musteri));
            this.labelTc = new System.Windows.Forms.Label();
            this.labelSifre = new System.Windows.Forms.Label();
            this.textBoxTc = new System.Windows.Forms.TextBox();
            this.textBoxSifre = new System.Windows.Forms.TextBox();
            this.btnGiris = new System.Windows.Forms.Button();
            this.labelGirisBilgileri = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelTc
            // 
            this.labelTc.AutoSize = true;
            this.labelTc.Location = new System.Drawing.Point(212, 184);
            this.labelTc.Name = "labelTc";
            this.labelTc.Size = new System.Drawing.Size(77, 13);
            this.labelTc.TabIndex = 0;
            this.labelTc.Text = "T.C. Kimlik No:";
            // 
            // labelSifre
            // 
            this.labelSifre.AutoSize = true;
            this.labelSifre.Location = new System.Drawing.Point(212, 214);
            this.labelSifre.Name = "labelSifre";
            this.labelSifre.Size = new System.Drawing.Size(31, 13);
            this.labelSifre.TabIndex = 1;
            this.labelSifre.Text = "Şifre:";
            // 
            // textBoxTc
            // 
            this.textBoxTc.Location = new System.Drawing.Point(326, 181);
            this.textBoxTc.Name = "textBoxTc";
            this.textBoxTc.Size = new System.Drawing.Size(230, 20);
            this.textBoxTc.TabIndex = 2;
            // 
            // textBoxSifre
            // 
            this.textBoxSifre.Location = new System.Drawing.Point(326, 211);
            this.textBoxSifre.Name = "textBoxSifre";
            this.textBoxSifre.Size = new System.Drawing.Size(230, 20);
            this.textBoxSifre.TabIndex = 3;
            // 
            // btnGiris
            // 
            this.btnGiris.Location = new System.Drawing.Point(481, 256);
            this.btnGiris.Name = "btnGiris";
            this.btnGiris.Size = new System.Drawing.Size(75, 45);
            this.btnGiris.TabIndex = 4;
            this.btnGiris.Text = "Giriş";
            this.btnGiris.UseVisualStyleBackColor = true;
            this.btnGiris.Click += new System.EventHandler(this.btnGiris_Click);
            // 
            // labelGirisBilgileri
            // 
            this.labelGirisBilgileri.AutoSize = true;
            this.labelGirisBilgileri.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelGirisBilgileri.Location = new System.Drawing.Point(322, 101);
            this.labelGirisBilgileri.Name = "labelGirisBilgileri";
            this.labelGirisBilgileri.Size = new System.Drawing.Size(127, 24);
            this.labelGirisBilgileri.TabIndex = 5;
            this.labelGirisBilgileri.Text = "Giriş Bilgileri";
            // 
            // Musteri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelGirisBilgileri);
            this.Controls.Add(this.btnGiris);
            this.Controls.Add(this.textBoxSifre);
            this.Controls.Add(this.textBoxTc);
            this.Controls.Add(this.labelSifre);
            this.Controls.Add(this.labelTc);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Musteri";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Banka Hesap Yönetimi (Müşteri)";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTc;
        private System.Windows.Forms.Label labelSifre;
        private System.Windows.Forms.TextBox textBoxTc;
        private System.Windows.Forms.TextBox textBoxSifre;
        private System.Windows.Forms.Button btnGiris;
        private System.Windows.Forms.Label labelGirisBilgileri;
    }
}