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
    public partial class Satıs_Islemi : Form
    {
        public Satıs_Islemi()
        {
            InitializeComponent();
        }
        OleDbConnection con;
        OleDbCommand cmd,cmd2,cmd3;
        OleDbDataReader dr;
        public void temizle()
        {
            listView1.Items.Clear();
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();

            con = new OleDbConnection("Provider=Microsoft.ACE.Oledb.12.0;Data Source=Veri.accdb");
            cmd = new OleDbCommand();
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "SELECT barkod_no,musteri,urun_adi,fiyat,siparis_adeti,s_tarih,t_tarih FROM Urun_Girisi";
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {

                ListViewItem ekle = new ListViewItem();

                ekle.Text = (dr["barkod_no"].ToString());
                ekle.SubItems.Add(dr["musteri"].ToString());

                ekle.SubItems.Add(dr["urun_adi"].ToString());

                ekle.SubItems.Add(dr["fiyat"].ToString());

                ekle.SubItems.Add(dr["siparis_adeti"].ToString());

                ekle.SubItems.Add(dr["s_tarih"].ToString());

                ekle.SubItems.Add(dr["t_tarih"].ToString());

                listView1.Items.Add(ekle);

            }
            con.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string ad = Convert.ToString(textBox5.Text);
            string ad2 = Convert.ToString(textBox1.Text);
            int say1, say2, top;
            say1 = Convert.ToInt32(textBox4.Text);
            say2 = Convert.ToInt32(textBox2.Text);
            top = say1 - say2;
            if (top < 0)
            {
                MessageBox.Show("Stokta Bu Kadar Malzemeye Sahip Değilsiniz Lütfen Sipariş Girişi Yapınız");
            }
            else
            {

                string vtyolu = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Veri.accdb;Persist Security Info=True";
                OleDbConnection baglanti = new OleDbConnection(vtyolu);
                baglanti.Open();
                string sorgu = "Update Urun_Grubu Set adet=@adet where urun_adi='" + ad + "'";
                cmd = new OleDbCommand(sorgu, baglanti);
                cmd.Parameters.AddWithValue("@adet", top);
                cmd.ExecuteNonQuery();
               
                

               
                cmd2 = new OleDbCommand();
               
                cmd2.Connection = baglanti;
                cmd2.CommandText = "DELETE FROM Urun_Girisi where barkod_no='" + ad2 + "'"; 
                cmd2.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Veriniz Güncellendi");
                temizle();
            }
            

        }

        private void Satıs_Islemi_Load(object sender, EventArgs e)
        {
            con = new OleDbConnection("Provider=Microsoft.ACE.Oledb.12.0;Data Source=Veri.accdb");
            cmd = new OleDbCommand();
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "SELECT barkod_no,musteri,urun_adi,fiyat,siparis_adeti,s_tarih,t_tarih FROM Urun_Girisi";
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {

                ListViewItem ekle = new ListViewItem();
              
                ekle.Text=(dr["barkod_no"].ToString());
                ekle.SubItems.Add(dr["musteri"].ToString());
               
                ekle.SubItems.Add(dr["urun_adi"].ToString());
             
                ekle.SubItems.Add(dr["fiyat"].ToString());

                ekle.SubItems.Add(dr["siparis_adeti"].ToString());

                ekle.SubItems.Add(dr["s_tarih"].ToString());

                ekle.SubItems.Add(dr["t_tarih"].ToString());
               
                listView1.Items.Add(ekle);

            }
            con.Close();
            
        }

        private void listView1_ColumnClick(object sender, ColumnClickEventArgs e)
        {
           
        }

        private void listView1_DoubleClick(object sender, EventArgs e)
        {

        }

        private void listView1_Click(object sender, EventArgs e)
        {
            textBox1.Text = listView1.SelectedItems[0].SubItems[0].Text;
            string ad = textBox1.Text;
            string ad2 = "";
            con = new OleDbConnection("Provider=Microsoft.ACE.Oledb.12.0;Data Source=Veri.accdb");
            cmd = new OleDbCommand();
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "SELECT * FROM Urun_Girisi where barkod_no='" + ad + "'";
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                textBox2.Clear();
                textBox2.Text=(dr["siparis_adeti"].ToString());
                textBox3.Clear();
                textBox3.Text = (dr["musteri"].ToString());
                textBox5.Clear();
                textBox5.Text = (dr["urun_adi"].ToString());
                ad2 = textBox5.Text;
            }
            cmd2 = new OleDbCommand();
            cmd2.Connection = con;
            cmd2.CommandText = "SELECT * FROM Urun_Grubu where urun_adi='" + ad2 + "'";
            dr = cmd2.ExecuteReader();
            if (dr.Read())
            {
                textBox4.Clear();
                textBox4.Text = (dr["adet"].ToString());
             
            }
           
            con.Close();
        }
    }
}
