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
    public partial class MusteriDetay : Form
    {
        public MusteriDetay()
        {
            InitializeComponent();
        }

        BankWebService ws = new BankWebService();

        private void btnCek_Click(object sender, EventArgs e)
        {
            var dc = ws.HesapListele(textBoxHn.Text);
            Array array = dc.ToArray();
            foreach (BsonDocument i in array)
            {
                string hesapNo = i["Hesap No"].ToString();
                int deger = Convert.ToInt32(i["Limit"]);
                int miktar = Convert.ToInt32(textBoxM.Text);
                deger -= miktar;
                ws.Guncelle(hesapNo, deger);
                textBoxHn.Clear();
                textBoxM.Clear();
            }
        }

        private void btnYatir_Click(object sender, EventArgs e)
        {
            var dc = ws.HesapListele(textBoxHesN.Text);
            Array array = dc.ToArray();
            foreach (BsonDocument i in array)
            {
                string hesapNo = i["Hesap No"].ToString();
                int deger = Convert.ToInt32(i["Limit"]);
                int miktar = Convert.ToInt32(textBoxMik.Text);
                deger += miktar;
                ws.Guncelle(hesapNo, deger);
                textBoxHesN.Clear();
                textBoxMik.Clear();
            }
        }
    }
}
