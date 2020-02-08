namespace BankWindowsFormsApp
{
    partial class Personal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Personal));
            this.tabControlPersonal = new System.Windows.Forms.TabControl();
            this.tabPageMusteriEkle = new System.Windows.Forms.TabPage();
            this.tabPageHesapAc = new System.Windows.Forms.TabPage();
            this.tabPageHesapSil = new System.Windows.Forms.TabPage();
            this.labelMusteriBilgileri = new System.Windows.Forms.Label();
            this.labelAdi = new System.Windows.Forms.Label();
            this.labelSoyadi = new System.Windows.Forms.Label();
            this.labelTarih = new System.Windows.Forms.Label();
            this.labelMusteriNo = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxAdi = new System.Windows.Forms.TextBox();
            this.textBoxSoyadi = new System.Windows.Forms.TextBox();
            this.textBoxMusteriNo = new System.Windows.Forms.TextBox();
            this.textBoxSifre = new System.Windows.Forms.TextBox();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.btnEkle = new System.Windows.Forms.Button();
            this.btnCıkıs = new System.Windows.Forms.Button();
            this.labelMusteriBilgisi = new System.Windows.Forms.Label();
            this.labelMusteriNumarası = new System.Windows.Forms.Label();
            this.labelLimit = new System.Windows.Forms.Label();
            this.textBoxMusteriNumarasi = new System.Windows.Forms.TextBox();
            this.textBoxLimit = new System.Windows.Forms.TextBox();
            this.btnAc = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.textBoxMusNo = new System.Windows.Forms.TextBox();
            this.labelMusNo = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tabControlPersonal.SuspendLayout();
            this.tabPageMusteriEkle.SuspendLayout();
            this.tabPageHesapAc.SuspendLayout();
            this.tabPageHesapSil.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlPersonal
            // 
            this.tabControlPersonal.Controls.Add(this.tabPageMusteriEkle);
            this.tabControlPersonal.Controls.Add(this.tabPageHesapAc);
            this.tabControlPersonal.Controls.Add(this.tabPageHesapSil);
            this.tabControlPersonal.Location = new System.Drawing.Point(12, 12);
            this.tabControlPersonal.Name = "tabControlPersonal";
            this.tabControlPersonal.SelectedIndex = 0;
            this.tabControlPersonal.Size = new System.Drawing.Size(776, 386);
            this.tabControlPersonal.TabIndex = 0;
            // 
            // tabPageMusteriEkle
            // 
            this.tabPageMusteriEkle.BackColor = System.Drawing.Color.White;
            this.tabPageMusteriEkle.Controls.Add(this.btnEkle);
            this.tabPageMusteriEkle.Controls.Add(this.dateTimePicker);
            this.tabPageMusteriEkle.Controls.Add(this.textBoxSifre);
            this.tabPageMusteriEkle.Controls.Add(this.textBoxMusteriNo);
            this.tabPageMusteriEkle.Controls.Add(this.textBoxSoyadi);
            this.tabPageMusteriEkle.Controls.Add(this.textBoxAdi);
            this.tabPageMusteriEkle.Controls.Add(this.label6);
            this.tabPageMusteriEkle.Controls.Add(this.labelMusteriNo);
            this.tabPageMusteriEkle.Controls.Add(this.labelTarih);
            this.tabPageMusteriEkle.Controls.Add(this.labelSoyadi);
            this.tabPageMusteriEkle.Controls.Add(this.labelAdi);
            this.tabPageMusteriEkle.Controls.Add(this.labelMusteriBilgileri);
            this.tabPageMusteriEkle.Location = new System.Drawing.Point(4, 22);
            this.tabPageMusteriEkle.Name = "tabPageMusteriEkle";
            this.tabPageMusteriEkle.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageMusteriEkle.Size = new System.Drawing.Size(768, 360);
            this.tabPageMusteriEkle.TabIndex = 0;
            this.tabPageMusteriEkle.Text = "Müşteri Ekle";
            // 
            // tabPageHesapAc
            // 
            this.tabPageHesapAc.BackColor = System.Drawing.Color.White;
            this.tabPageHesapAc.Controls.Add(this.btnAc);
            this.tabPageHesapAc.Controls.Add(this.textBoxLimit);
            this.tabPageHesapAc.Controls.Add(this.textBoxMusteriNumarasi);
            this.tabPageHesapAc.Controls.Add(this.labelLimit);
            this.tabPageHesapAc.Controls.Add(this.labelMusteriNumarası);
            this.tabPageHesapAc.Controls.Add(this.labelMusteriBilgisi);
            this.tabPageHesapAc.Location = new System.Drawing.Point(4, 22);
            this.tabPageHesapAc.Name = "tabPageHesapAc";
            this.tabPageHesapAc.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageHesapAc.Size = new System.Drawing.Size(768, 360);
            this.tabPageHesapAc.TabIndex = 1;
            this.tabPageHesapAc.Text = "Hesap Aç";
            // 
            // tabPageHesapSil
            // 
            this.tabPageHesapSil.BackColor = System.Drawing.Color.White;
            this.tabPageHesapSil.Controls.Add(this.btnSil);
            this.tabPageHesapSil.Controls.Add(this.textBoxMusNo);
            this.tabPageHesapSil.Controls.Add(this.labelMusNo);
            this.tabPageHesapSil.Controls.Add(this.label3);
            this.tabPageHesapSil.Location = new System.Drawing.Point(4, 22);
            this.tabPageHesapSil.Name = "tabPageHesapSil";
            this.tabPageHesapSil.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageHesapSil.Size = new System.Drawing.Size(768, 360);
            this.tabPageHesapSil.TabIndex = 2;
            this.tabPageHesapSil.Text = "Hesap Sil";
            // 
            // labelMusteriBilgileri
            // 
            this.labelMusteriBilgileri.AutoSize = true;
            this.labelMusteriBilgileri.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelMusteriBilgileri.Location = new System.Drawing.Point(307, 59);
            this.labelMusteriBilgileri.Name = "labelMusteriBilgileri";
            this.labelMusteriBilgileri.Size = new System.Drawing.Size(153, 24);
            this.labelMusteriBilgileri.TabIndex = 0;
            this.labelMusteriBilgileri.Text = "Müşteri Bilgileri";
            // 
            // labelAdi
            // 
            this.labelAdi.AutoSize = true;
            this.labelAdi.Location = new System.Drawing.Point(220, 118);
            this.labelAdi.Name = "labelAdi";
            this.labelAdi.Size = new System.Drawing.Size(25, 13);
            this.labelAdi.TabIndex = 1;
            this.labelAdi.Text = "Adı:";
            // 
            // labelSoyadi
            // 
            this.labelSoyadi.AutoSize = true;
            this.labelSoyadi.Location = new System.Drawing.Point(220, 144);
            this.labelSoyadi.Name = "labelSoyadi";
            this.labelSoyadi.Size = new System.Drawing.Size(42, 13);
            this.labelSoyadi.TabIndex = 2;
            this.labelSoyadi.Text = "Soyadı:";
            // 
            // labelTarih
            // 
            this.labelTarih.AutoSize = true;
            this.labelTarih.Location = new System.Drawing.Point(220, 173);
            this.labelTarih.Name = "labelTarih";
            this.labelTarih.Size = new System.Drawing.Size(31, 13);
            this.labelTarih.TabIndex = 3;
            this.labelTarih.Text = "Tarih";
            // 
            // labelMusteriNo
            // 
            this.labelMusteriNo.AutoSize = true;
            this.labelMusteriNo.Location = new System.Drawing.Point(220, 196);
            this.labelMusteriNo.Name = "labelMusteriNo";
            this.labelMusteriNo.Size = new System.Drawing.Size(91, 13);
            this.labelMusteriNo.TabIndex = 4;
            this.labelMusteriNo.Text = "Müşteri Numarası:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(220, 222);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(28, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Şifre";
            // 
            // textBoxAdi
            // 
            this.textBoxAdi.Location = new System.Drawing.Point(337, 115);
            this.textBoxAdi.Name = "textBoxAdi";
            this.textBoxAdi.Size = new System.Drawing.Size(200, 20);
            this.textBoxAdi.TabIndex = 6;
            // 
            // textBoxSoyadi
            // 
            this.textBoxSoyadi.Location = new System.Drawing.Point(337, 141);
            this.textBoxSoyadi.Name = "textBoxSoyadi";
            this.textBoxSoyadi.Size = new System.Drawing.Size(200, 20);
            this.textBoxSoyadi.TabIndex = 7;
            // 
            // textBoxMusteriNo
            // 
            this.textBoxMusteriNo.Location = new System.Drawing.Point(337, 193);
            this.textBoxMusteriNo.Name = "textBoxMusteriNo";
            this.textBoxMusteriNo.Size = new System.Drawing.Size(200, 20);
            this.textBoxMusteriNo.TabIndex = 8;
            // 
            // textBoxSifre
            // 
            this.textBoxSifre.Location = new System.Drawing.Point(337, 219);
            this.textBoxSifre.Name = "textBoxSifre";
            this.textBoxSifre.Size = new System.Drawing.Size(200, 20);
            this.textBoxSifre.TabIndex = 9;
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(337, 167);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker.TabIndex = 10;
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(462, 268);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(75, 35);
            this.btnEkle.TabIndex = 11;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // btnCıkıs
            // 
            this.btnCıkıs.Location = new System.Drawing.Point(12, 404);
            this.btnCıkıs.Name = "btnCıkıs";
            this.btnCıkıs.Size = new System.Drawing.Size(75, 35);
            this.btnCıkıs.TabIndex = 2;
            this.btnCıkıs.Text = "Çıkış";
            this.btnCıkıs.UseVisualStyleBackColor = true;
            this.btnCıkıs.Click += new System.EventHandler(this.btnCıkıs_Click);
            // 
            // labelMusteriBilgisi
            // 
            this.labelMusteriBilgisi.AutoSize = true;
            this.labelMusteriBilgisi.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelMusteriBilgisi.Location = new System.Drawing.Point(321, 83);
            this.labelMusteriBilgisi.Name = "labelMusteriBilgisi";
            this.labelMusteriBilgisi.Size = new System.Drawing.Size(139, 24);
            this.labelMusteriBilgisi.TabIndex = 0;
            this.labelMusteriBilgisi.Text = "Müşteri Bilgisi";
            // 
            // labelMusteriNumarası
            // 
            this.labelMusteriNumarası.AutoSize = true;
            this.labelMusteriNumarası.Location = new System.Drawing.Point(235, 149);
            this.labelMusteriNumarası.Name = "labelMusteriNumarası";
            this.labelMusteriNumarası.Size = new System.Drawing.Size(91, 13);
            this.labelMusteriNumarası.TabIndex = 1;
            this.labelMusteriNumarası.Text = "Müşteri Numarası:";
            // 
            // labelLimit
            // 
            this.labelLimit.AutoSize = true;
            this.labelLimit.Location = new System.Drawing.Point(235, 175);
            this.labelLimit.Name = "labelLimit";
            this.labelLimit.Size = new System.Drawing.Size(67, 13);
            this.labelLimit.TabIndex = 2;
            this.labelLimit.Text = "Hesap Limiti:";
            // 
            // textBoxMusteriNumarasi
            // 
            this.textBoxMusteriNumarasi.Location = new System.Drawing.Point(345, 146);
            this.textBoxMusteriNumarasi.Name = "textBoxMusteriNumarasi";
            this.textBoxMusteriNumarasi.Size = new System.Drawing.Size(200, 20);
            this.textBoxMusteriNumarasi.TabIndex = 3;
            // 
            // textBoxLimit
            // 
            this.textBoxLimit.Location = new System.Drawing.Point(345, 172);
            this.textBoxLimit.Name = "textBoxLimit";
            this.textBoxLimit.Size = new System.Drawing.Size(200, 20);
            this.textBoxLimit.TabIndex = 4;
            // 
            // btnAc
            // 
            this.btnAc.Location = new System.Drawing.Point(470, 221);
            this.btnAc.Name = "btnAc";
            this.btnAc.Size = new System.Drawing.Size(75, 35);
            this.btnAc.TabIndex = 5;
            this.btnAc.Text = "Aç";
            this.btnAc.UseVisualStyleBackColor = true;
            this.btnAc.Click += new System.EventHandler(this.btnAc_Click);
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(456, 209);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(75, 35);
            this.btnSil.TabIndex = 11;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // textBoxMusNo
            // 
            this.textBoxMusNo.Location = new System.Drawing.Point(331, 162);
            this.textBoxMusNo.Name = "textBoxMusNo";
            this.textBoxMusNo.Size = new System.Drawing.Size(200, 20);
            this.textBoxMusNo.TabIndex = 9;
            // 
            // labelMusNo
            // 
            this.labelMusNo.AutoSize = true;
            this.labelMusNo.Location = new System.Drawing.Point(221, 165);
            this.labelMusNo.Name = "labelMusNo";
            this.labelMusNo.Size = new System.Drawing.Size(91, 13);
            this.labelMusNo.TabIndex = 7;
            this.labelMusNo.Text = "Müşteri Numarası:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(305, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(139, 24);
            this.label3.TabIndex = 6;
            this.label3.Text = "Müşteri Bilgisi";
            // 
            // Personal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCıkıs);
            this.Controls.Add(this.tabControlPersonal);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Personal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Banka Hesap Yönetimi (Personal)";
            this.tabControlPersonal.ResumeLayout(false);
            this.tabPageMusteriEkle.ResumeLayout(false);
            this.tabPageMusteriEkle.PerformLayout();
            this.tabPageHesapAc.ResumeLayout(false);
            this.tabPageHesapAc.PerformLayout();
            this.tabPageHesapSil.ResumeLayout(false);
            this.tabPageHesapSil.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlPersonal;
        private System.Windows.Forms.TabPage tabPageMusteriEkle;
        private System.Windows.Forms.TabPage tabPageHesapAc;
        private System.Windows.Forms.TabPage tabPageHesapSil;
        private System.Windows.Forms.Label labelMusteriBilgileri;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label labelMusteriNo;
        private System.Windows.Forms.Label labelTarih;
        private System.Windows.Forms.Label labelSoyadi;
        private System.Windows.Forms.Label labelAdi;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.TextBox textBoxSifre;
        private System.Windows.Forms.TextBox textBoxMusteriNo;
        private System.Windows.Forms.TextBox textBoxSoyadi;
        private System.Windows.Forms.TextBox textBoxAdi;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Button btnCıkıs;
        private System.Windows.Forms.Button btnAc;
        private System.Windows.Forms.TextBox textBoxLimit;
        private System.Windows.Forms.TextBox textBoxMusteriNumarasi;
        private System.Windows.Forms.Label labelLimit;
        private System.Windows.Forms.Label labelMusteriNumarası;
        private System.Windows.Forms.Label labelMusteriBilgisi;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.TextBox textBoxMusNo;
        private System.Windows.Forms.Label labelMusNo;
        private System.Windows.Forms.Label label3;
    }
}