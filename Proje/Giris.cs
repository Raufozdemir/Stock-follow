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
    public partial class Giris : Form

    {
      
        public Giris()
        {
            InitializeComponent();
        }
        OleDbConnection con;
        OleDbCommand cmd;
        OleDbDataReader dr;
      

        private void Button1_Click_1(object sender, EventArgs e)
        {
            string ad = TextBox1.Text;
            string sifre = TextBox2.Text;
            con = new OleDbConnection("Provider=Microsoft.ACE.Oledb.12.0;Data Source=Veri.accdb");
            cmd = new OleDbCommand();
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "SELECT * FROM Login where Kadi='" + TextBox1.Text + "' AND sifre='" + TextBox2.Text + "'";
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {

                Anasayfa f2 = new Anasayfa();
                f2.Show();
                this.Hide();


            }
            else if (TextBox1.Text == "" || TextBox2.Text == "")
            {
                MessageBox.Show("Kullanıcı Veya Şifre Boş Bırakılamaz");
            }
            else
            {
                MessageBox.Show("Kullanıcı Adı Veya Şifre Hatalıdır");
            }

            con.Close();
        }
    }
}
