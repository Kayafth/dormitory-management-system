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
    public partial class ogrenciislem : Form
    {
        public ogrenciislem()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=ASUS\\SQLEXPRESS;Initial Catalog=yurttakip;Integrated Security=True");
        public void verileritemizle()
        {
            Txttcno.Clear();
            Txtad.Clear();
            Txtsoyad.Clear();
            Txtbabaadi.Clear();
            Txtanneadi.Clear();
            Txtdogumyeri.Clear();
            Cbcinsiyet.Text = "";
            Cbmedenihal.Text = "";
            Txtil.Clear();
            Txtilce.Clear();
            Txtmahalle.Clear();
            Txttelefon.Clear();
            Txtgsm.Clear();
            Txtemail.Clear();
            Richadres.Clear();
            Txtodano.Text = "";
            txtveliad.Clear();
            txtyakinlik.Clear();
            txtvelitel.Clear();
            txtveligsm.Clear();
            txtveliemail.Clear();
            ricveliadres.Clear();
            txtokulno.Clear();
            txtokul.Clear();
            txtfakulte.Clear();
            txtbolum.Clear();
            cbsinif.Text = "";
            Cbogrencitipi.Text = "";
            Dtdogumtarih.Text = "";
            Txtgelistarih.Text = "";
            textBox3.Text = "0.00";
            txtborckalan.Text = "0.00";
            Txtodenenborc.Text = "0.00";
            comboBox2.Text = "";
            dateTimePicker2.Text = "";
            comboBox3.Text = "";
            comboBox4.Text = "";
            comboBox5.Text = "";
            dateTimePicker3.Text = "";

            Txttcno.Enabled = true;
            Txtad.Enabled = true;
            Txtsoyad.Enabled = true;
            Txtbabaadi.Enabled = true;
            Txtanneadi.Enabled = true;
            Txtdogumyeri.Enabled = true;
            Cbcinsiyet.Enabled = true;
            Cbmedenihal.Enabled = true;
            Txtil.Enabled = true;
            Txtilce.Enabled = true;
            Txtmahalle.Enabled = true;
            Txttelefon.Enabled = true;
            Txtgsm.Enabled = true;
            Txtemail.Enabled = true;
            Richadres.Enabled = true;
            Txtodano.Enabled = true;
            txtveliad.Enabled = true;
            txtyakinlik.Enabled = true;
            txtvelitel.Enabled = true;
            txtveligsm.Enabled = true;
            txtveliemail.Enabled = true;
            ricveliadres.Enabled = true;
            txtokulno.Enabled = true;
            txtokul.Enabled = true;
            txtfakulte.Enabled = true;
            txtbolum.Enabled = true;
            cbsinif.Enabled = true;
            Cbogrencitipi.Enabled = true;
            Dtdogumtarih.Enabled = true;
            Txtgelistarih.Enabled = true;
            ricaciklama.Enabled = true;

        }
        
        
        
        
        private void ogrenciislem_Load(object sender, EventArgs e)
        {
            for(int i=1;i<51;i++)
            {
                Txtodano.Items.Add(i);
            }

        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {
            

            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into bilgiler (tckimlikno,adi,soyadi,babaadi,anneadi,dyeri,dtarih," +
                "cinsiyet,medenihali,il,ilce,mahalle,kayittarih,telefon,gsm,email,adres,odano,veliad,veliyakinlik,velitel," +
                "veligsm,veliemail,veliadres,okulno,okul,fakulte,bolum,sinif,ogrencitip,aciklama,resim) values('" + Txttcno.Text.ToString() + "'," +
                "'" + Txtad.Text.ToString() + "','" + Txtsoyad.Text.ToString() + "','" + Txtbabaadi.Text.ToString() + "'," +
                "'" + Txtanneadi.Text.ToString() + "','" + Txtdogumyeri.Text.ToString() + "','" + Dtdogumtarih.Text.ToString() + "'," +
                "'" + Cbcinsiyet.Text.ToString() + "','" + Cbmedenihal.Text.ToString() + "','" + Txtil.Text.ToString() + "'," +
                "'" + Txtilce.Text.ToString() + "','" + Txtmahalle.Text.ToString() + "','" + Txtgelistarih.Text.ToString() + "'," +
                "'" + Txttelefon.Text.ToString() + "','" + Txtgsm.Text.ToString() + "','" + Txtemail.Text.ToString() + "'," +
                "'" + Richadres.Text.ToString() + "','" + Txtodano.Text.ToString() + "','" + txtveliad.Text.ToString() + "'," +
                "'" + txtyakinlik.Text.ToString() + "','" + txtvelitel.Text.ToString() + "','" + txtveligsm.Text.ToString() + "'," +
                "'" + txtveliemail.Text.ToString() + "','" + ricveliadres.Text.ToString() + "','" + txtokulno.Text.ToString() + "'," +
                "'" + txtokul.Text.ToString() + "','" + txtfakulte.Text.ToString() + "','" + txtbolum.Text.ToString() + "'," +
                "'" + cbsinif.Text.ToString() + "','" + Cbogrencitipi.Text.ToString() + "','"+ricaciklama.Text.ToString()+"','"+textBox2.Text+"')", baglanti);
            
            komut.ExecuteNonQuery();
            
            MessageBox.Show("Kayıt başarıyla eklendi");
            baglanti.Close();


            baglanti.Open();
            SqlCommand komut2 = new SqlCommand("select idd from bilgiler", baglanti);
            SqlDataReader oku = komut2.ExecuteReader();
            while(oku.Read())
            {
                label22.Text = oku[0].ToString();
            }
            baglanti.Close();




            baglanti.Open();
            SqlCommand komut3 = new SqlCommand("insert into borclar (ogrid,ogradsoyad,toplamborc,kalanborc) values(@b1,@b2,@b3,@b4)", baglanti);
            komut3.Parameters.AddWithValue("@b1", label22.Text);
            komut3.Parameters.AddWithValue("@b2", Txtad.Text+" "+Txtsoyad.Text);
            komut3.Parameters.AddWithValue("@b3", textBox3.Text.ToString());
            komut3.Parameters.AddWithValue("@b4", txtborckalan.Text.ToString());
            komut3.ExecuteNonQuery();
            baglanti.Close();


        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            verileritemizle();
            simpleButton4.Enabled = true;
            simpleButton5.Enabled = true;
            simpleButton11.Enabled = false;
            simpleButton3.Enabled = true;
            simpleButton6.Enabled = true;
        }

        private void Cbcinsiyet_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            

        }
        public void veriListele(DataTable dt) {
            Txttcno.Text= dt.Rows[0]["tckimlikno"].ToString();
            Txtad.Text= dt.Rows[0]["adi"].ToString();
            Txtsoyad.Text = dt.Rows[0]["soyadi"].ToString();
            Txtbabaadi.Text = dt.Rows[0]["babaadi"].ToString();
            Txtanneadi.Text = dt.Rows[0]["anneadi"].ToString();
            Txtdogumyeri.Text = dt.Rows[0]["dyeri"].ToString();
            Dtdogumtarih.Text = dt.Rows[0]["dtarih"].ToString();
            Cbcinsiyet.Text = dt.Rows[0]["cinsiyet"].ToString();
            Cbmedenihal.Text = dt.Rows[0]["medenihali"].ToString();
            Txtil.Text = dt.Rows[0]["il"].ToString();
            Txtilce.Text = dt.Rows[0]["ilce"].ToString();
            Txtmahalle.Text = dt.Rows[0]["mahalle"].ToString();
            Txtgelistarih.Text = dt.Rows[0]["kayittarih"].ToString();
            Txttelefon.Text = dt.Rows[0]["telefon"].ToString();
            Txtgsm.Text = dt.Rows[0]["gsm"].ToString();
            Txtemail.Text = dt.Rows[0]["email"].ToString();
            Richadres.Text = dt.Rows[0]["adres"].ToString();
            Txtodano.Text = dt.Rows[0]["odano"].ToString();
            txtveliad.Text = dt.Rows[0]["veliad"].ToString();
            txtyakinlik.Text = dt.Rows[0]["veliyakinlik"].ToString();
            txtvelitel.Text = dt.Rows[0]["velitel"].ToString();
            txtokulno.Text = dt.Rows[0]["okulno"].ToString();
            txtokul.Text = dt.Rows[0]["okul"].ToString();
            txtfakulte.Text = dt.Rows[0]["fakulte"].ToString();
            txtbolum.Text = dt.Rows[0]["bolum"].ToString();
            cbsinif.Text = dt.Rows[0]["sinif"].ToString();
            Cbogrencitipi.Text = dt.Rows[0]["ogrencitip"].ToString();
            txtveligsm.Text = dt.Rows[0]["veligsm"].ToString();
            txtveliemail.Text = dt.Rows[0]["veliemail"].ToString();
            ricveliadres.Text = dt.Rows[0]["veliadres"].ToString();
            Txttcno.Text = dt.Rows[0]["tckimlikno"].ToString();
            ricaciklama.Text = dt.Rows[0]["aciklama"].ToString();
            textBox2.Text = dt.Rows[0]["resim"].ToString();
    
            textBox1.Text = dt.Rows[0]["idd"].ToString();
            picres1.ImageLocation = dt.Rows[0]["resim"].ToString();
            label49.Text = dt.Rows[0]["adi"].ToString() +" "+ dt.Rows[0]["soyadi"].ToString();
            label41.Text= dt.Rows[0]["adi"].ToString() + " " + dt.Rows[0]["soyadi"].ToString();
            label45.Text= dt.Rows[0]["adi"].ToString() + " " + dt.Rows[0]["soyadi"].ToString();

            comboBox2.Text= dt.Rows[0]["ogrencitip"].ToString();
            dateTimePicker2.Text= dt.Rows[0]["kayittarih"].ToString();
            comboBox3.Text= dt.Rows[0]["odano"].ToString();
            textBox6.Text= dt.Rows[0]["idd"].ToString();

            comboBox4.Text= dt.Rows[0]["ogrencitip"].ToString();
            dateTimePicker3.Text= dt.Rows[0]["kayittarih"].ToString();
            comboBox5.Text= dt.Rows[0]["odano"].ToString();
            textBox8.Text= dt.Rows[0]["idd"].ToString();

            pictureBox1.ImageLocation= dt.Rows[0]["resim"].ToString();
            pictureBox2.ImageLocation= dt.Rows[0]["resim"].ToString();






        }

        private void simpleButton6_Click(object sender, EventArgs e)
        {
            
            
        }

        private void listView2_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }
        
        private void listView2_DoubleClick(object sender, EventArgs e)
        {
            Txtad.Text = listView1.SelectedItems[0].SubItems[0].Text;
            Txtsoyad.Text = listView1.SelectedItems[0].SubItems[1].Text;
        }

        private void xtraTabPage3_Paint(object sender, PaintEventArgs e)
        {
            
           
        }

        private void simpleButton5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }
        private void simpleButton2_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("update bilgiler set adi='" + Txtad.Text + "',soyadi='" + Txtsoyad.Text + "',babaadi='" + Txtbabaadi.Text + "',anneadi='" + Txtanneadi.Text + "',dyeri='" + Txtdogumyeri.Text + "',dtarih='" + Dtdogumtarih.Text.ToString() + "',cinsiyet='" + Cbcinsiyet.Text.ToString() + "',medenihali='" + Cbmedenihal.Text.ToString() + "',il='" + Txtil.Text.ToString() + "',ilce='" + Txtilce.Text.ToString() + "',mahalle='" + Txtmahalle.Text.ToString() + "',kayittarih='" + Txtgelistarih.Text.ToString() + "',telefon='" + Txttelefon.Text.ToString() + "',gsm='" + Txtgsm.Text.ToString() + "',email='" + Txtemail.Text.ToString() + "',adres='" + Richadres.Text.ToString() + "',odano='" + Txtodano.Text.ToString() + "',veliad='" + txtveliad.Text.ToString() + "',veliyakinlik='" + txtyakinlik.Text.ToString() + "',velitel='" + txtvelitel.Text.ToString() + "',okulno='" + txtokulno.Text.ToString() + "',okul='" + txtokul.Text.ToString() + "',fakulte='" + txtfakulte.Text.ToString() + "',bolum='" + txtbolum.Text.ToString() + "',sinif='" + cbsinif.Text.ToString() + "',ogrencitip='" + Cbogrencitipi.Text.ToString() + "',veligsm='" + txtveligsm.Text.ToString() + "',veliemail='" + txtveliemail.Text.ToString() + "',veliadres='" + ricveliadres.Text.ToString() + "',tckimlikno='" + Txttcno.Text.ToString() + "',aciklama='" + ricaciklama.Text.ToString() + "',resim='"+textBox2.Text+"' where idd='" + textBox1.Text + "'", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Güncelleme İşlemi Başarıyla Gerçekleşmiştir");

            


            
        }
        
        private void button1_Click_1(object sender, EventArgs e)
        {
            
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            
            openFileDialog1.ShowDialog();
            picres1.ImageLocation = openFileDialog1.FileName;
            textBox2.Text = openFileDialog1.FileName;
            
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {

        }

        private void simpleButton3_SizeChanged(object sender, EventArgs e)
        {
            
        }

        private void simpleButton7_Click(object sender, EventArgs e)
        {
            double odenen, kalan, yeniborc;
            odenen = Convert.ToDouble(textBox4.Text);
            kalan = Convert.ToDouble(txtborckalan.Text);
            yeniborc = kalan - odenen;
            Txtodenenborc.Text = odenen.ToString();
            txtborckalan.Text = yeniborc.ToString();

            baglanti.Open();
            SqlCommand komut = new SqlCommand("update borclar set kalanborc='" + txtborckalan.Text.ToString() + "' where ogrid='" + textBox8.Text.ToString() + "'",baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Tahsilat İşlemi Gerçekleşti");
            textBox4.Clear();
        }

        private void Txtodenenborc_TextChanged(object sender, EventArgs e)
        {
            double borc, odenenborc, kalanborc;
            borc = Convert.ToDouble(textBox3.Text.ToString());
            odenenborc = Convert.ToDouble(Txtodenenborc.Text.ToString());
            kalanborc = borc - odenenborc;
            txtborckalan.Text = kalanborc.ToString();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void simpleButton6_Click_1(object sender, EventArgs e)
        {
            groupBox6.Visible = true;
            grpborcgiris.Visible = false;
        }

        private void simpleButton3_Click_1(object sender, EventArgs e)
        {
            grpborcgiris.Visible = true;
            groupBox6.Visible = false;
        }

        private void simpleButton10_Click(object sender, EventArgs e)
        {
            double borc, eklenenborc, toplamborc, kalanborc;
            borc = Convert.ToDouble(textBox3.Text);
            eklenenborc = Convert.ToDouble(textBox9.Text);
            toplamborc = borc + eklenenborc;
            textBox3.Text = toplamborc.ToString();
            kalanborc = Convert.ToDouble(txtborckalan.Text);
            kalanborc += eklenenborc;
            txtborckalan.Text = kalanborc.ToString();
            baglanti.Open();
            SqlCommand komut = new SqlCommand("update borclar set toplamborc='" + textBox3.Text.ToString() + "',kalanborc='"+txtborckalan.Text.ToString()+"' where ogrid='" + textBox8.Text.ToString() + "'", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Borç Eklendi");
            textBox9.Clear();
        }

        private void simpleButton11_Click(object sender, EventArgs e)
        {
            simpleButton2.Enabled = true;
            simpleButton3.Enabled = true;
            simpleButton6.Enabled = true;
            Txttcno.Enabled = true;
            Txtad.Enabled = true;
            Txtsoyad.Enabled = true;
            Txtbabaadi.Enabled = true;
            Txtanneadi.Enabled = true;
            Txtdogumyeri.Enabled = true;
            Cbcinsiyet.Enabled = true;
            Cbmedenihal.Enabled = true;
            Txtil.Enabled = true;
            Txtilce.Enabled = true;
            Txtmahalle.Enabled = true;
            Txttelefon.Enabled = true;
            Txtgsm.Enabled = true;
            Txtemail.Enabled = true;
            Richadres.Enabled = true;
            Txtodano.Enabled = true;
            txtveliad.Enabled = true;
            txtyakinlik.Enabled = true;
            txtvelitel.Enabled = true;
            txtveligsm.Enabled = true;
            txtveliemail.Enabled = true;
            ricveliadres.Enabled = true;
            txtokulno.Enabled = true;
            txtokul.Enabled = true;
            txtfakulte.Enabled = true;
            txtbolum.Enabled = true;
            cbsinif.Enabled = true;
            Cbogrencitipi.Enabled = true;
            Dtdogumtarih.Enabled = true;
            Txtgelistarih.Enabled = true;
            ricaciklama.Enabled = true;
            button1.Visible = true;
        }
    }
}
