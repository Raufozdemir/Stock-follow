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
    public partial class Urun_Grubu : Form
    {
        public Urun_Grubu()
        {
            InitializeComponent();
        }
        OleDbConnection con;
        OleDbCommand cmd;
        OleDbDataReader dr;
        private void button1_Click(object sender, EventArgs e)
        {

            string ad = textBox1.Text;
            
            con = new OleDbConnection("Provider=Microsoft.ACE.Oledb.12.0;Data Source=Veri.accdb");
            cmd = new OleDbCommand();
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "SELECT * FROM Urun_Grubu where urun_grubu='" + textBox1.Text + "'";
            dr = cmd.ExecuteReader();
            if (textBox1.Text==""|| textBox2.Text == "")
            {
                MessageBox.Show("Lütfen Boş Bırakmayınız");
            }

          else  if (dr.Read())
            {

                MessageBox.Show("Böyle Bir Ürün Grubu Bulunmaktadır Lütfen Kontrol Ediniz");

            }
            
            else
            {
                string vtyolu = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Veri.accdb;Persist Security Info=True";
                OleDbConnection baglanti = new OleDbConnection(vtyolu);
                baglanti.Open();
                string ekle = "insert into Urun_Grubu(urun_grubu,urun_adi) values (?,?)";
                OleDbCommand komut = new OleDbCommand(ekle, baglanti);
                komut.Parameters.AddWithValue("urun_grubu", textBox1.Text);
                komut.Parameters.AddWithValue("urun_adi", textBox2.Text);
                komut.ExecuteNonQuery();
               
                MessageBox.Show("Ürün Grubu Eklendi");
                textBox1.Clear();
                textBox2.Clear();
                textBox1.Focus();
            }

            con.Close();







            
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            string kelime,dene;

            kelime = textBox1.Text;
            dene = kelime.ToUpper();
            textBox1.Text = dene.ToString();
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            string kelime, dene;

            kelime = textBox2.Text;
            dene = kelime.ToUpper();
            textBox2.Text = dene.ToString();
        }

       
    }
}
