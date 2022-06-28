using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Yurt_Kayıt_Program
{
    public partial class borc : Form
    {
        public borc()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=ASUS\\SQLEXPRESS;Initial Catalog=yurttakip;Integrated Security=True");
        private void verilerigoster(string veriler)
        {
            SqlDataAdapter da = new SqlDataAdapter(veriler, baglanti);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }
        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void borc_Load(object sender, EventArgs e)
        {
            verilerigoster("select borclar.ogrid, odano,ogradsoyad,toplamborc,kalanborc from borclar join bilgiler on borclar.ogrid=bilgiler.idd");
        }
    }
}
