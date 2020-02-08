using BankWebApplication;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Services;
using System.Windows.Forms;

namespace BankWindowsFormsApp
{
    public partial class Yonetici : Form
    {
        public Yonetici()
        {
            InitializeComponent();
        }

        BankWebService ws = new BankWebService();

        [Obsolete]
        private void btnEkle_Click(object sender, EventArgs e)
        {
            if(textBoxAdi.Text != "" & textBoxSoyadi.Text != "" & textBoxKullaniciAdi.Text != "" &  textBoxSifre.Text != "")
            {
                int sifre = Convert.ToInt32(textBoxSifre.Text);
                ws.PersonalEkle(textBoxAdi.Text, textBoxSoyadi.Text, textBoxKullaniciAdi.Text, sifre);
                MessageBox.Show("Personal Başarıyla Eklendi", "Bilgilendirme");
            }
            else
            {
                MessageBox.Show("Lütfen Boş Alanları Doldurunuz!", "Hata");
            }
            
        }

        [Obsolete]
        private void btnCikar_Click(object sender, EventArgs e)
        {
            if (textBoxKulAdi.Text != "")
            {
                ws.PersonalSil(textBoxKulAdi.Text);
                MessageBox.Show("Personal Başarıyla Çıkarıldı", "Bilgilendirme");
                textBoxKulAdi.Clear();
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
