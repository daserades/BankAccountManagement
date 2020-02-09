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
    public partial class Anasayfa : Form
    {
        public Anasayfa()
        {
            InitializeComponent();
        }

        private void btnYonetici_Click(object sender, EventArgs e)
        {
            Yonetici yonetici = new Yonetici();
            yonetici.Show();
            this.Hide();
        }

        private void btnPersonalGirisi_Click(object sender, EventArgs e)
        {
            Personal personal = new Personal();
            personal.Show();
            this.Hide();
        }

        private void btnMusteriGirisi_Click(object sender, EventArgs e)
        {
            Musteri musteri = new Musteri();
            musteri.Show();
            this.Hide();
        }
    }
}
