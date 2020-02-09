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
        public Musteri()
        {
            InitializeComponent();
        }

        BankWebService ws = new BankWebService();

        private void btnGiris_Click(object sender, EventArgs e)
        {
            var dc = ws.MusteriListele();
            Array array = dc.ToArray();
            foreach (BsonDocument i in array)
            {
                var kimlikNo = i["TC No"].ToString();
                var sifreGiris = i["Şifre"].ToString();
                if (textBoxTc.Text == kimlikNo & textBoxSifre.Text == sifreGiris)
                {
                    MusteriDetay musteriDetay = new MusteriDetay();
                    musteriDetay.Show();
                    this.Hide();
                }
                else
                {
                    //MessageBox.Show("T.C. Kimlik Numarası ya da Şifre Hatalı!", "Hata");
                }
                
            }
        }
    }
}
