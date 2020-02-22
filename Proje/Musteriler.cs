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
    public partial class Musteriler : Form
    {
        public Musteriler()
        {
            InitializeComponent();
        }
        OleDbConnection con;
        OleDbDataAdapter da;
        
        DataSet ds;
        public void temizle()
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            textBox7.Clear();


        }

        private void button1_Click(object sender, EventArgs e)
        {
            string vtyolu = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Veri.accdb;Persist Security Info=True";
            OleDbConnection baglanti = new OleDbConnection(vtyolu);
            baglanti.Open();
            string ekle = "insert into Musteri(fadi,tel_bir,tel_iki,eposta,adres,notee) values (?,?,?,?,?,?)";
            OleDbCommand komut = new OleDbCommand(ekle, baglanti);
            komut.Parameters.AddWithValue("fadi", textBox1.Text);
            komut.Parameters.AddWithValue("tel_bir", textBox2.Text);
            komut.Parameters.AddWithValue("tel_iki", textBox3.Text);
            komut.Parameters.AddWithValue("eposta", textBox4.Text);
            komut.Parameters.AddWithValue("adres", textBox5.Text);
            komut.Parameters.AddWithValue("notee", textBox6.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Müşteri Bilgileriniz Eklenmiştir");
            temizle();
            textBox1.Focus();

        }

        private void Musteriler_Load(object sender, EventArgs e)
        {
            con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Veri.accdb;Persist Security Info=True");
            da = new OleDbDataAdapter("Select fadi from Musteri", con);
            ds = new DataSet();
            con.Open();
            da.Fill(ds, "Musteri");
            dataGridView1.DataSource = ds.Tables["Musteri"];
            con.Close();
        }
    }
}
