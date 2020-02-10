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
    public partial class Musteri : Form
    {
        BankWebService ws = new BankWebService();

        public Musteri()
        {
            InitializeComponent();
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            var dc = ws.MusteriKontrol(Convert.ToInt64(textBoxTc.Text));
            Array array = dc.ToArray();
            foreach (BsonDocument i in array)
            {
                string ad = i["Ad"].ToString();
                string soyad = i["Soyad"].ToString();
                var kimlikNo = i["TC No"].ToString();
                var sifreGiris = i["Şifre"].ToString();
                if (textBoxTc.Text == kimlikNo & textBoxSifre.Text == sifreGiris)
                {
                    MusteriDetay musteriDetay = new MusteriDetay();
                    musteriDetay.Show();
                    this.Hide();
                    MessageBox.Show("Hoşgeldiniz " + ad + "" + soyad + ". Giriş Başarılı!", "Bilgilendirme");
                }
                else
                {
                    MessageBox.Show("T.C. Kimlik Numarası ya da Şifre Hatalı!", "Hata");
                }
            }
        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            Anasayfa anasayfa = new Anasayfa();
            anasayfa.Show();
            this.Hide();
        }
    }
}
