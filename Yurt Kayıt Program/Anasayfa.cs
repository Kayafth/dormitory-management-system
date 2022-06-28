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
    public partial class Anasayfa : Form
    {
        public Anasayfa()
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
        private void simpleButton3_Click(object sender, EventArgs e)
        {
            verilerigoster("select idd,odano,kayittarih,adi,soyadi,veliad,veligsm,gsm,okul,aciklama,resim from bilgiler");
            
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            ogrenciislem frm = new ogrenciislem();
            frm.Show();
        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            

            

        }
        private void temizle()
        {
            Txtno.Clear();
            textBox1.Clear();
            Dtdogumtarih.Text = "";
            Txtad.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            textBox7.Clear();
        }

        private void Anasayfa_Load(object sender, EventArgs e)
        {
            

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
       
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select idd,odano,kayittarih,adi,soyadi,veliad,veligsm,gsm,okul,aciklama,resim from bilgiler where adi like '%" + textBox2.Text.ToString() + "%'", baglanti);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            baglanti.Close();

            textBox2.Clear();


        }

        private void button3_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            
            SqlCommand komut = new SqlCommand("delete from bilgiler where idd=@id", baglanti);
            komut.Parameters.AddWithValue("id", Txtno.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();

            verilerigoster("select idd,odano,kayittarih,adi,soyadi,veliad,veligsm,gsm,okul,aciklama,resim from bilgiler");
            temizle();
            baglanti.Open();
            SqlCommand komut2 = new SqlCommand("delete from borclar where ogrid=@bid", baglanti);
            komut2.Parameters.AddWithValue("bid", Txtno.Text);
            komut2.ExecuteNonQuery();
            baglanti.Close();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            Txtno.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            textBox1.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            Dtdogumtarih.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            Txtad.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString() +" "+ dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            textBox4.Text = dataGridView1.Rows[secilen].Cells[5].Value.ToString();
            textBox5.Text = dataGridView1.Rows[secilen].Cells[6].Value.ToString();
            textBox3.Text = dataGridView1.Rows[secilen].Cells[7].Value.ToString();
            textBox6.Text = dataGridView1.Rows[secilen].Cells[8].Value.ToString();
            textBox7.Text = dataGridView1.Rows[secilen].Cells[9].Value.ToString();
            pictureBox1.ImageLocation = dataGridView1.Rows[secilen].Cells[10].Value.ToString();


            label12.Text = Txtad.Text;
            label11.Visible = true;
            label12.Visible = true;


        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(Txtno.Text);

            string sqll = "Select toplamborc,kalanborc from borclar where ogrid=@id ";

            SqlCommand cmdd = new SqlCommand(sqll, baglanti);
            cmdd.Parameters.AddWithValue("id", a);

            SqlDataAdapter adaptorr = new SqlDataAdapter();
            adaptorr.SelectCommand = cmdd;
            DataTable dtt = new DataTable();
            adaptorr.Fill(dtt);

            ogrenciislem ogr = new ogrenciislem();
            ogr.textBox3.Text = dtt.Rows[0]["toplamborc"].ToString();
            ogr.txtborckalan.Text = dtt.Rows[0]["kalanborc"].ToString();

            int aa = Convert.ToInt32(Txtno.Text);

            string sql = "Select * from bilgiler where idd=@id";

            SqlCommand cmd = new SqlCommand(sql, baglanti);
            cmd.Parameters.AddWithValue("id", aa);

            SqlDataAdapter adaptor = new SqlDataAdapter();
            adaptor.SelectCommand = cmd;
            DataTable dt = new DataTable();
            adaptor.Fill(dt);

            ogr.simpleButton11.Enabled = true;
            //ogr.Txttcno.Text = dt.Rows[0]["tckimlikno"].ToString();
            //ogr.Txtad.Text = dt.Rows[0]["adi"].ToString();
            ogr.veriListele(dt);
            ogr.Show();

            ogr.Show();




        }

        private void button4_Click(object sender, EventArgs e)
        {
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
           int a = Convert.ToInt32(Txtno.Text);

            string sqll = "Select toplamborc,kalanborc from borclar where ogrid=@id ";
            
            SqlCommand cmdd = new SqlCommand(sqll, baglanti);
            cmdd.Parameters.AddWithValue("id", a);

            SqlDataAdapter adaptorr = new SqlDataAdapter();
            adaptorr.SelectCommand = cmdd;
            DataTable dtt = new DataTable();
            adaptorr.Fill(dtt);

            ogrenciislem ogr = new ogrenciislem();
            ogr.textBox3.Text = dtt.Rows[0]["toplamborc"].ToString();
            ogr.txtborckalan.Text = dtt.Rows[0]["kalanborc"].ToString();

            int aa = Convert.ToInt32(Txtno.Text);

            string sql = "Select * from bilgiler where idd=@id";

            SqlCommand cmd = new SqlCommand(sql, baglanti);
            cmd.Parameters.AddWithValue("id", aa);

            SqlDataAdapter adaptor = new SqlDataAdapter();
            adaptor.SelectCommand = cmd;
            DataTable dt = new DataTable();
            adaptor.Fill(dt);

            
            //ogr.Txttcno.Text = dt.Rows[0]["tckimlikno"].ToString();
            //ogr.Txtad.Text = dt.Rows[0]["adi"].ToString();
            ogr.veriListele(dt);
            ogr.Show();

            ogr.Show();







        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            borc frm = new borc();
            frm.Show();
        }

        private void simpleButton5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Demo Sürüm Yurt Kayıt Programı, C# Dersleri Proje Örnek. Designed FATİH KAYA");
        }
    }
}
