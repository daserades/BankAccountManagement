using BankWebApplication;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankWindowsFormsApp
{
    public partial class Personal : Form
    {
        public Personal()
        {
            InitializeComponent();
        }

        BankWebService ws = new BankWebService();

        [Obsolete]
        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (textBoxAdi.Text != "" & textBoxSoyadi.Text != "" & textBoxMusteriNo.Text != "" & textBoxSifre.Text != "")
            {
                int musteriNo = Convert.ToInt32(textBoxMusteriNo.Text);
                int sifre = Convert.ToInt32(textBoxSifre.Text);
                ws.MusteriEkle(textBoxAdi.Text, textBoxSoyadi.Text, dateTimePicker.Value, musteriNo, sifre);
                MessageBox.Show("Müşteri Başarıyla Eklendi", "Bilgilendirme");
            }
            else
            {
                MessageBox.Show("Lütfen Boş Alanları Doldurunuz!", "Hata");
            }
            
        }

        [Obsolete]
        private void btnAc_Click(object sender, EventArgs e)
        {
            if (textBoxMusteriNumarasi.Text != "" & textBoxLimit.Text != "")
            {
                int musteriNo = Convert.ToInt32(textBoxMusteriNumarasi.Text);
                int limit = Convert.ToInt32(textBoxLimit.Text);
                ws.HesapAc(musteriNo, limit);
                MessageBox.Show("Hesap Başarıyla Açıldı", "Bilgilendirme");
            }
            else
            {
                MessageBox.Show("Lütfen Boş Alanları Doldurunuz!", "Hata");
            }


        }

        [Obsolete]
        private void btnSil_Click(object sender, EventArgs e)
        {
            if (textBoxMusNo.Text != "")
            {
                int musteriNo = Convert.ToInt32(textBoxMusNo.Text);
                ws.HesapSil(musteriNo);
                MessageBox.Show("Hesap Başarıyla Kapatıldı", "Bilgilendirme");
            }
            else
            {
                MessageBox.Show("Lütfen Boş Alanları Doldurunuz!", "Hata");
            }
            
        }

        private void btnCıkıs_Click(object sender, EventArgs e)
        {
            Anasayfa anasayfa = new Anasayfa();
            anasayfa.Show();
            this.Hide();
        }

    }
}
