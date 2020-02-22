using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Proje
{
    public partial class Urun_Girisi : Form
    {
        public Urun_Girisi()
        {
            InitializeComponent();
        }
           OleDbConnection con;
        OleDbCommand cmd;
        OleDbDataReader dr;
        private void button1_Click(object sender, EventArgs e)
        {
            Random rastgele = new Random();
            int sayi = rastgele.Next(1000000,10000000);
            textBox11.Text = sayi.ToString();
        }

        private void Urun_Girisi_Load(object sender, EventArgs e)
        {
            comboBox3.Items.Clear();
            con = new OleDbConnection("Provider=Microsoft.ACE.Oledb.12.0;Data Source=Veri.accdb");
            cmd = new OleDbCommand();
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "SELECT * FROM Musteri";
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                
                comboBox3.Items.Add(dr["fadi"]);
            }

            con.Close();
            textBox11.Enabled = false;
            comboBox1.Items.Clear();
            con = new OleDbConnection("Provider=Microsoft.ACE.Oledb.12.0;Data Source=Veri.accdb");
            cmd = new OleDbCommand();
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "SELECT * FROM Urun_Grubu";
            dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                comboBox1.Items.Add(dr["urun_grubu"]);

            }
            con.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Urun_Grubu deneme = new Urun_Grubu();
            deneme.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string vtyolu = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Veri.accdb;Persist Security Info=True";
            OleDbConnection baglanti = new OleDbConnection(vtyolu);
            baglanti.Open();
            string ekle = "insert into Urun_Girisi(barkod_no,urun_grubu,urun_adi,urun_kodu,musteri,fiyat,siparis_adeti,birim,odeme_sekil,t_tarih,s_tarih) values (?,?,?,?,?,?,?,?,?,?,?)";
            OleDbCommand komut = new OleDbCommand(ekle, baglanti);
            komut.Parameters.AddWithValue("barkod_no", textBox11.Text);
            komut.Parameters.AddWithValue("urun_grubu", comboBox1.Text.ToString());
            komut.Parameters.AddWithValue("urun_adi", comboBox2.Text.ToString());
            komut.Parameters.AddWithValue("urun_kodu", textBox12.Text);
            komut.Parameters.AddWithValue("musteri", comboBox3.Text.ToString());
            komut.Parameters.AddWithValue("fiyat", textBox14.Text);
            komut.Parameters.AddWithValue("siparis_adeti", textBox2.Text);
            komut.Parameters.AddWithValue("birim", textBox16.Text);
            komut.Parameters.AddWithValue("odeme_sekil", textBox17.Text);
            komut.Parameters.AddWithValue("t_tarih", dateTimePicker2.Text);
            komut.Parameters.AddWithValue("s_tarih", dateTimePicker1.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Ürün Başarılı Bir Şeklide Kaydedilmiştir");
            temizle();
            textBox11.Focus();
        }
        public void temizle()
        {
            textBox2.Clear();
            textBox11.Clear();
            comboBox1.Text="";
            comboBox2.Text="";
            comboBox2.Items.Clear();
            comboBox3.Text="";
            textBox12.Clear();
            
            textBox14.Clear();
            textBox15.Clear();
            textBox16.Clear();
            textBox17.Clear();

        }

       

        private void comboBox1_Click(object sender, EventArgs e)
        {
            comboBox1.Items.Clear();
            con = new OleDbConnection("Provider=Microsoft.ACE.Oledb.12.0;Data Source=Veri.accdb");
            cmd = new OleDbCommand();
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "SELECT * FROM Urun_Grubu";
            dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                comboBox1.Items.Add(dr["urun_grubu"]);

            }
            con.Close();
        }

        private void comboBox1_TextChanged(object sender, EventArgs e)
        {
            string ad =comboBox1.Text;
            comboBox2.Text = "";
            textBox15.Clear();
            con = new OleDbConnection("Provider=Microsoft.ACE.Oledb.12.0;Data Source=Veri.accdb");
            cmd = new OleDbCommand();
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "SELECT urun_adi FROM Urun_Grubu where urun_grubu='" + ad + "'";
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                comboBox2.Items.Clear();
                comboBox2.Items.Add(dr["urun_adi"].ToString());
            }

            con.Close();
        }

        private void comboBox2_TextChanged(object sender, EventArgs e)
        {
            string ad = comboBox2.Text;

            con = new OleDbConnection("Provider=Microsoft.ACE.Oledb.12.0;Data Source=Veri.accdb");
            cmd = new OleDbCommand();
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "SELECT adet FROM Urun_Grubu where urun_adi='" + ad + "'";
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                textBox15.Clear();
               textBox15.Text=(dr["adet"].ToString()).ToString();
            }

            con.Close();
        }
    }
}
