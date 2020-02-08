namespace BankWindowsFormsApp
{
    partial class Anasayfa
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Anasayfa));
            this.btnYonetici = new System.Windows.Forms.Button();
            this.btnPersonalGirisi = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label = new System.Windows.Forms.Label();
            this.btnMusteriGirisi = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnYonetici
            // 
            this.btnYonetici.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.btnYonetici, "btnYonetici");
            this.btnYonetici.Name = "btnYonetici";
            this.btnYonetici.UseVisualStyleBackColor = true;
            this.btnYonetici.Click += new System.EventHandler(this.btnYonetici_Click);
            // 
            // btnPersonalGirisi
            // 
            this.btnPersonalGirisi.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.btnPersonalGirisi, "btnPersonalGirisi");
            this.btnPersonalGirisi.Name = "btnPersonalGirisi";
            this.btnPersonalGirisi.UseVisualStyleBackColor = true;
            this.btnPersonalGirisi.Click += new System.EventHandler(this.btnPersonalGirisi_Click);
            // 
            // pictureBox1
            // 
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // label
            // 
            resources.ApplyResources(this.label, "label");
            this.label.Name = "label";
            // 
            // btnMusteriGirisi
            // 
            this.btnMusteriGirisi.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.btnMusteriGirisi, "btnMusteriGirisi");
            this.btnMusteriGirisi.Name = "btnMusteriGirisi";
            this.btnMusteriGirisi.UseVisualStyleBackColor = true;
            // 
            // Anasayfa
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.btnMusteriGirisi);
            this.Controls.Add(this.label);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnPersonalGirisi);
            this.Controls.Add(this.btnYonetici);
            this.Name = "Anasayfa";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnYonetici;
        private System.Windows.Forms.Button btnPersonalGirisi;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Button btnMusteriGirisi;
    }
}

