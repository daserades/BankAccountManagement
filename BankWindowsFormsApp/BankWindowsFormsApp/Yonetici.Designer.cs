namespace BankWindowsFormsApp
{
    partial class Yonetici
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Yonetici));
            this.tabControlYönetici = new System.Windows.Forms.TabControl();
            this.tabPagePersonalEkle = new System.Windows.Forms.TabPage();
            this.btnEkle = new System.Windows.Forms.Button();
            this.textBoxSifre = new System.Windows.Forms.TextBox();
            this.textBoxKullaniciAdi = new System.Windows.Forms.TextBox();
            this.textBoxSoyadi = new System.Windows.Forms.TextBox();
            this.textBoxAdi = new System.Windows.Forms.TextBox();
            this.labelSifre = new System.Windows.Forms.Label();
            this.labelKullaniciAdi = new System.Windows.Forms.Label();
            this.labelSoyadi = new System.Windows.Forms.Label();
            this.labelAdi = new System.Windows.Forms.Label();
            this.labelPersonalBilgileri = new System.Windows.Forms.Label();
            this.tabPagePersonalCikar = new System.Windows.Forms.TabPage();
            this.btnCikar = new System.Windows.Forms.Button();
            this.textBoxKulAdi = new System.Windows.Forms.TextBox();
            this.labelKulAdi = new System.Windows.Forms.Label();
            this.labelPersonalBilgisi = new System.Windows.Forms.Label();
            this.tabPagePersonalListele = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnCıkıs = new System.Windows.Forms.Button();
            this.tabControlYönetici.SuspendLayout();
            this.tabPagePersonalEkle.SuspendLayout();
            this.tabPagePersonalCikar.SuspendLayout();
            this.tabPagePersonalListele.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControlYönetici
            // 
            this.tabControlYönetici.Controls.Add(this.tabPagePersonalEkle);
            this.tabControlYönetici.Controls.Add(this.tabPagePersonalCikar);
            this.tabControlYönetici.Controls.Add(this.tabPagePersonalListele);
            this.tabControlYönetici.Location = new System.Drawing.Point(12, 12);
            this.tabControlYönetici.Name = "tabControlYönetici";
            this.tabControlYönetici.SelectedIndex = 0;
            this.tabControlYönetici.Size = new System.Drawing.Size(776, 388);
            this.tabControlYönetici.TabIndex = 0;
            // 
            // tabPagePersonalEkle
            // 
            this.tabPagePersonalEkle.BackColor = System.Drawing.Color.White;
            this.tabPagePersonalEkle.Controls.Add(this.btnEkle);
            this.tabPagePersonalEkle.Controls.Add(this.textBoxSifre);
            this.tabPagePersonalEkle.Controls.Add(this.textBoxKullaniciAdi);
            this.tabPagePersonalEkle.Controls.Add(this.textBoxSoyadi);
            this.tabPagePersonalEkle.Controls.Add(this.textBoxAdi);
            this.tabPagePersonalEkle.Controls.Add(this.labelSifre);
            this.tabPagePersonalEkle.Controls.Add(this.labelKullaniciAdi);
            this.tabPagePersonalEkle.Controls.Add(this.labelSoyadi);
            this.tabPagePersonalEkle.Controls.Add(this.labelAdi);
            this.tabPagePersonalEkle.Controls.Add(this.labelPersonalBilgileri);
            this.tabPagePersonalEkle.Location = new System.Drawing.Point(4, 22);
            this.tabPagePersonalEkle.Name = "tabPagePersonalEkle";
            this.tabPagePersonalEkle.Padding = new System.Windows.Forms.Padding(3);
            this.tabPagePersonalEkle.Size = new System.Drawing.Size(768, 362);
            this.tabPagePersonalEkle.TabIndex = 0;
            this.tabPagePersonalEkle.Text = "Personal Ekle";
            // 
            // btnEkle
            // 
            this.btnEkle.BackColor = System.Drawing.Color.Transparent;
            this.btnEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnEkle.Location = new System.Drawing.Point(420, 260);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(75, 35);
            this.btnEkle.TabIndex = 9;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = false;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // textBoxSifre
            // 
            this.textBoxSifre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBoxSifre.Location = new System.Drawing.Point(355, 214);
            this.textBoxSifre.Name = "textBoxSifre";
            this.textBoxSifre.Size = new System.Drawing.Size(140, 22);
            this.textBoxSifre.TabIndex = 8;
            // 
            // textBoxKullaniciAdi
            // 
            this.textBoxKullaniciAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBoxKullaniciAdi.Location = new System.Drawing.Point(355, 186);
            this.textBoxKullaniciAdi.Name = "textBoxKullaniciAdi";
            this.textBoxKullaniciAdi.Size = new System.Drawing.Size(140, 22);
            this.textBoxKullaniciAdi.TabIndex = 7;
            // 
            // textBoxSoyadi
            // 
            this.textBoxSoyadi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBoxSoyadi.Location = new System.Drawing.Point(355, 158);
            this.textBoxSoyadi.Name = "textBoxSoyadi";
            this.textBoxSoyadi.Size = new System.Drawing.Size(140, 22);
            this.textBoxSoyadi.TabIndex = 6;
            // 
            // textBoxAdi
            // 
            this.textBoxAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBoxAdi.Location = new System.Drawing.Point(355, 130);
            this.textBoxAdi.Name = "textBoxAdi";
            this.textBoxAdi.Size = new System.Drawing.Size(140, 22);
            this.textBoxAdi.TabIndex = 5;
            // 
            // labelSifre
            // 
            this.labelSifre.AutoSize = true;
            this.labelSifre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelSifre.Location = new System.Drawing.Point(260, 217);
            this.labelSifre.Name = "labelSifre";
            this.labelSifre.Size = new System.Drawing.Size(38, 16);
            this.labelSifre.TabIndex = 4;
            this.labelSifre.Text = "Şifre:";
            // 
            // labelKullaniciAdi
            // 
            this.labelKullaniciAdi.AutoSize = true;
            this.labelKullaniciAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelKullaniciAdi.Location = new System.Drawing.Point(260, 189);
            this.labelKullaniciAdi.Name = "labelKullaniciAdi";
            this.labelKullaniciAdi.Size = new System.Drawing.Size(83, 16);
            this.labelKullaniciAdi.TabIndex = 3;
            this.labelKullaniciAdi.Text = "Kullanıcı Adı:";
            // 
            // labelSoyadi
            // 
            this.labelSoyadi.AutoSize = true;
            this.labelSoyadi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelSoyadi.Location = new System.Drawing.Point(260, 161);
            this.labelSoyadi.Name = "labelSoyadi";
            this.labelSoyadi.Size = new System.Drawing.Size(54, 16);
            this.labelSoyadi.TabIndex = 2;
            this.labelSoyadi.Text = "Soyadı:";
            // 
            // labelAdi
            // 
            this.labelAdi.AutoSize = true;
            this.labelAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelAdi.Location = new System.Drawing.Point(260, 133);
            this.labelAdi.Name = "labelAdi";
            this.labelAdi.Size = new System.Drawing.Size(31, 16);
            this.labelAdi.TabIndex = 1;
            this.labelAdi.Text = "Adı:";
            // 
            // labelPersonalBilgileri
            // 
            this.labelPersonalBilgileri.AutoSize = true;
            this.labelPersonalBilgileri.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelPersonalBilgileri.ForeColor = System.Drawing.Color.Black;
            this.labelPersonalBilgileri.Location = new System.Drawing.Point(295, 65);
            this.labelPersonalBilgileri.Name = "labelPersonalBilgileri";
            this.labelPersonalBilgileri.Size = new System.Drawing.Size(167, 24);
            this.labelPersonalBilgileri.TabIndex = 0;
            this.labelPersonalBilgileri.Text = "Personal Bilgileri";
            // 
            // tabPagePersonalCikar
            // 
            this.tabPagePersonalCikar.BackColor = System.Drawing.Color.White;
            this.tabPagePersonalCikar.Controls.Add(this.btnCikar);
            this.tabPagePersonalCikar.Controls.Add(this.textBoxKulAdi);
            this.tabPagePersonalCikar.Controls.Add(this.labelKulAdi);
            this.tabPagePersonalCikar.Controls.Add(this.labelPersonalBilgisi);
            this.tabPagePersonalCikar.Location = new System.Drawing.Point(4, 22);
            this.tabPagePersonalCikar.Name = "tabPagePersonalCikar";
            this.tabPagePersonalCikar.Padding = new System.Windows.Forms.Padding(3);
            this.tabPagePersonalCikar.Size = new System.Drawing.Size(768, 362);
            this.tabPagePersonalCikar.TabIndex = 1;
            this.tabPagePersonalCikar.Text = "Personal Sil";
            // 
            // btnCikar
            // 
            this.btnCikar.BackColor = System.Drawing.Color.Transparent;
            this.btnCikar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCikar.Location = new System.Drawing.Point(419, 199);
            this.btnCikar.Name = "btnCikar";
            this.btnCikar.Size = new System.Drawing.Size(75, 36);
            this.btnCikar.TabIndex = 10;
            this.btnCikar.Text = "Çıkar";
            this.btnCikar.UseVisualStyleBackColor = false;
            this.btnCikar.Click += new System.EventHandler(this.btnCikar_Click);
            // 
            // textBoxKulAdi
            // 
            this.textBoxKulAdi.Location = new System.Drawing.Point(354, 155);
            this.textBoxKulAdi.Name = "textBoxKulAdi";
            this.textBoxKulAdi.Size = new System.Drawing.Size(140, 20);
            this.textBoxKulAdi.TabIndex = 3;
            // 
            // labelKulAdi
            // 
            this.labelKulAdi.AutoSize = true;
            this.labelKulAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelKulAdi.Location = new System.Drawing.Point(260, 156);
            this.labelKulAdi.Name = "labelKulAdi";
            this.labelKulAdi.Size = new System.Drawing.Size(83, 16);
            this.labelKulAdi.TabIndex = 2;
            this.labelKulAdi.Text = "Kullanıcı Adı:";
            // 
            // labelPersonalBilgisi
            // 
            this.labelPersonalBilgisi.AutoSize = true;
            this.labelPersonalBilgisi.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelPersonalBilgisi.ForeColor = System.Drawing.Color.Black;
            this.labelPersonalBilgisi.Location = new System.Drawing.Point(295, 91);
            this.labelPersonalBilgisi.Name = "labelPersonalBilgisi";
            this.labelPersonalBilgisi.Size = new System.Drawing.Size(153, 24);
            this.labelPersonalBilgisi.TabIndex = 1;
            this.labelPersonalBilgisi.Text = "Personal Bilgisi";
            // 
            // tabPagePersonalListele
            // 
            this.tabPagePersonalListele.Controls.Add(this.dataGridView1);
            this.tabPagePersonalListele.Location = new System.Drawing.Point(4, 22);
            this.tabPagePersonalListele.Name = "tabPagePersonalListele";
            this.tabPagePersonalListele.Size = new System.Drawing.Size(768, 362);
            this.tabPagePersonalListele.TabIndex = 2;
            this.tabPagePersonalListele.Text = "Personal Listele";
            this.tabPagePersonalListele.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column2,
            this.Column3,
            this.Column1,
            this.Column4});
            this.dataGridView1.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(768, 362);
            this.dataGridView1.TabIndex = 3;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Column2.DefaultCellStyle = dataGridViewCellStyle2;
            this.Column2.HeaderText = "Ad";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Column3.DefaultCellStyle = dataGridViewCellStyle3;
            this.Column3.HeaderText = "Soyad";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Column1.DefaultCellStyle = dataGridViewCellStyle4;
            this.Column1.HeaderText = "Kullanıcı Adı";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Column4.DefaultCellStyle = dataGridViewCellStyle5;
            this.Column4.HeaderText = "Şifre";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // btnCıkıs
            // 
            this.btnCıkıs.Location = new System.Drawing.Point(12, 406);
            this.btnCıkıs.Name = "btnCıkıs";
            this.btnCıkıs.Size = new System.Drawing.Size(75, 35);
            this.btnCıkıs.TabIndex = 1;
            this.btnCıkıs.Text = "Çıkış";
            this.btnCıkıs.UseVisualStyleBackColor = true;
            this.btnCıkıs.Click += new System.EventHandler(this.btnCıkıs_Click);
            // 
            // Yonetici
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCıkıs);
            this.Controls.Add(this.tabControlYönetici);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Yonetici";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Banka Hesap Yönetimi (Yönetici)";
            this.tabControlYönetici.ResumeLayout(false);
            this.tabPagePersonalEkle.ResumeLayout(false);
            this.tabPagePersonalEkle.PerformLayout();
            this.tabPagePersonalCikar.ResumeLayout(false);
            this.tabPagePersonalCikar.PerformLayout();
            this.tabPagePersonalListele.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlYönetici;
        private System.Windows.Forms.TabPage tabPagePersonalEkle;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.TextBox textBoxSifre;
        private System.Windows.Forms.TextBox textBoxKullaniciAdi;
        private System.Windows.Forms.TextBox textBoxSoyadi;
        private System.Windows.Forms.TextBox textBoxAdi;
        private System.Windows.Forms.Label labelSifre;
        private System.Windows.Forms.Label labelKullaniciAdi;
        private System.Windows.Forms.Label labelSoyadi;
        private System.Windows.Forms.Label labelAdi;
        private System.Windows.Forms.Label labelPersonalBilgileri;
        private System.Windows.Forms.TabPage tabPagePersonalCikar;
        private System.Windows.Forms.TextBox textBoxKulAdi;
        private System.Windows.Forms.Label labelKulAdi;
        private System.Windows.Forms.Label labelPersonalBilgisi;
        private System.Windows.Forms.Button btnCikar;
        private System.Windows.Forms.Button btnCıkıs;
        private System.Windows.Forms.TabPage tabPagePersonalListele;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
    }
}