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
using System.Windows.Forms;

namespace BankWindowsFormsApp
{
    public partial class Personal : Form
    {
        BankWebService ws = new BankWebService();

        public Personal()
        {
            InitializeComponent();

            var dc = ws.MusteriListele();
            Array array = dc.ToArray();
            foreach (BsonDocument i in array)
            {
                dataGridView1.Rows.Add(i["Ad"].ToString(), i["Soyad"].ToString(), i["TC No"].ToString(), i["Müşteri No"].ToString(), i["Şifre"].ToString());
            }
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (textBoxAdi.Text != "" & textBoxSoyadi.Text != "" & textBoxTc.Text != "" & textBoxSifre.Text != "")
            {
                long tc = Convert.ToInt64(textBoxTc.Text);
                int sifre = Convert.ToInt32(textBoxSifre.Text);
                ws.MusteriEkle(textBoxAdi.Text, textBoxSoyadi.Text, tc, sifre, dateTimePicker.Value);
                textBoxAdi.Clear();
                textBoxSoyadi.Clear();
                textBoxTc.Clear();
                textBoxSifre.Clear();
                MessageBox.Show("Müşteri Başarıyla Eklendi", "Bilgilendirme");
            }
            else
            {
                MessageBox.Show("Lütfen Boş Alanları Doldurunuz!", "Hata");
            }
        }

        private void btnAc_Click(object sender, EventArgs e)
        {
            if (textBoxMusteriNumarasi.Text != "" & textBoxLimit.Text != "")
            {
                int musteriNo = Convert.ToInt32(textBoxMusteriNumarasi.Text);
                int limit = Convert.ToInt32(textBoxLimit.Text);
                ws.HesapAc(musteriNo, limit);
                textBoxMusteriNumarasi.Clear();
                textBoxLimit.Clear();
                MessageBox.Show("Hesap Başarıyla Açıldı", "Bilgilendirme");
            }
            else
            {
                MessageBox.Show("Lütfen Boş Alanları Doldurunuz!", "Hata");
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            var dc = ws.HesapListele(textBoxHesapNo.Text);
            Array array = dc.ToArray();
            foreach (BsonDocument i in array)
            {
                int deger = Convert.ToInt32(i["Limit"]);
                if (deger == 0)
                {
                    if (textBoxHesapNo.Text != "")
                    {
                        string hesapNo = textBoxHesapNo.Text;
                        ws.HesapSil(hesapNo);
                        textBoxHesapNo.Clear();
                        MessageBox.Show("Hesap Başarıyla Kapatıldı", "Bilgilendirme");
                    }
                    else
                    {
                        MessageBox.Show("Lütfen Boş Alanları Doldurunuz!", "Hata");
                    }
                }
                else
                {
                    MessageBox.Show("Hesabın kapatılması için bakiye 0 olmalıdır!", "Hata");
                }
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
