using BankWebApplication;
using MongoDB.Bson;
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
        BankWebService ws = new BankWebService();

        public Yonetici()
        {
            InitializeComponent();

            var dc = ws.PersonalListele();
            Array array = dc.ToArray();
            foreach (BsonDocument i in array)
            {
                dataGridView1.Rows.Add(i["Ad"].ToString(), i["Soyad"].ToString(), i["Kullanıcı Adı"].ToString(), i["Şifre"].ToString());
            }
        }
        
        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (textBoxAdi.Text != "" & textBoxSoyadi.Text != "" & textBoxKullaniciAdi.Text != "" & textBoxSifre.Text != "")
            {
                int sifre = Convert.ToInt32(textBoxSifre.Text);
                ws.PersonalEkle(textBoxAdi.Text, textBoxSoyadi.Text, textBoxKullaniciAdi.Text, sifre);
                textBoxAdi.Clear();
                textBoxSoyadi.Clear();
                textBoxKullaniciAdi.Clear();
                textBoxSifre.Clear();
                MessageBox.Show("Personal Başarıyla Eklendi", "Bilgilendirme");
            }
            else
            {
                MessageBox.Show("Lütfen Boş Alanları Doldurunuz!", "Hata");
            }
        }

        private void btnCikar_Click(object sender, EventArgs e)
        {
            if (textBoxKulAdi.Text != "")
            {
                ws.PersonalSil(textBoxKulAdi.Text);
                textBoxKulAdi.Clear();
                MessageBox.Show("Personal Başarıyla Silindi", "Bilgilendirme");
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
