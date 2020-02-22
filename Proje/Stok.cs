using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Proje
{
    public partial class Stok : Form
    {
        public Stok()
        {
            InitializeComponent();
        }
        OleDbConnection con;
        OleDbDataAdapter da;

        DataSet ds;

        private void Stok_Load(object sender, EventArgs e)
        {
            con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Veri.accdb;Persist Security Info=True");
            da = new OleDbDataAdapter("Select * from Urun_Grubu", con);
            ds = new DataSet();
            con.Open();
            da.Fill(ds, "Urun_Grubu");
            dataGridView1.DataSource = ds.Tables["Urun_Grubu"];
            con.Close();
        }
    }
}
