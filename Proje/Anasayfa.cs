using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Proje
{
    public partial class Anasayfa : Form
    {
        public Anasayfa()
        {
            InitializeComponent();
        }

        private void Musteri_Click(object sender, EventArgs e)
        {
            Musteriler f = new Musteriler();
            f.Show();

        }

        private void Siparis_Click(object sender, EventArgs e)
        {
            Urun_Girisi f = new Urun_Girisi();
            f.Show();
        }

        private void Stoklar_Click(object sender, EventArgs e)
        {
            Stock_Kontrol f = new Stock_Kontrol();
            f.Show();
        }

        private void Satis_Click(object sender, EventArgs e)
        {
            Satıs_Islemi f = new Satıs_Islemi();
            f.Show();
        }

        private void Barkod_Click(object sender, EventArgs e)
        {

        }

        private void PROGRAMDANÇIKToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
