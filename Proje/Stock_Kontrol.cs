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
    public partial class Stock_Kontrol : Form
    {
        public Stock_Kontrol()
        {
            InitializeComponent();
        }
        OleDbConnection con;
        OleDbCommand cmd;
        OleDbDataReader dr;
        

        private void Stock_Kontrol_Load(object sender, EventArgs e)
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
            kapa();
         

        }
        public void kapa()
        {
            comboBox1.Enabled = false;
            comboBox2.Enabled = false;
            textBox1.Enabled = false;
            textBox2.Enabled = false;
            button1.Enabled = false;
            button2.Enabled = false;
        }
        public void ac()
        {
            comboBox1.Enabled = true;
            comboBox2.Enabled = true;
            textBox2.Enabled = true;
            button1.Enabled = true;
            button2.Enabled = true;
        }

        private void comboBox1_TextChanged(object sender, EventArgs e)
        {
            string ad = comboBox1.Text;

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
            comboBox2.Text = "";
            textBox1.Clear();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            string ad = textBox3.Text;
            
            con = new OleDbConnection("Provider=Microsoft.ACE.Oledb.12.0;Data Source=Veri.accdb");
            cmd = new OleDbCommand();
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "SELECT * FROM Login where sifre='" + textBox3.Text + "'";
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {

                ac();
            }
            else
            {
                kapa();
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
                textBox1.Clear();
                textBox1.Text=(dr["adet"].ToString());
            }

            con.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string ad = comboBox2.Text;
            int say1, say2, top;
            say1 = Convert.ToInt32(textBox1.Text);
            say2 = Convert.ToInt32(textBox2.Text);
            top = say1 + say2;
           
            string vtyolu = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Veri.accdb;Persist Security Info=True";
            OleDbConnection baglanti = new OleDbConnection(vtyolu);
            baglanti.Open();
            string sorgu = "Update Urun_Grubu Set adet=@adet where urun_adi='"+ad+"'";
            cmd = new OleDbCommand(sorgu, baglanti);
            cmd.Parameters.AddWithValue("@adet", top);
            cmd.ExecuteNonQuery();
            baglanti.Close();
            comboBox1.Text = "";
            comboBox2.Text = "";
            textBox1.Clear();
            textBox2.Clear();
            MessageBox.Show("Veriniz Güncellendi");
           


        }

        private void button2_Click(object sender, EventArgs e)
        {
            Stok n = new Stok();
            n.Show();
        }
    }
}
