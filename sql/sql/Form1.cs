using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sql
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'kitaplıkDataSet.Kitap3' table. You can move, or remove it, as needed.
            this.kitap3TableAdapter.Fill(this.kitaplıkDataSet.Kitap3);


        }
        SqlConnection baglantim = new SqlConnection("Data Source=103A-10;Initial Catalog=Kitaplık;Integrated Security=True");

        private void button1_Click(object sender, EventArgs e)
        {
            //dk ile adapter oluşturuyoruz. 
            SqlDataAdapter dk = new SqlDataAdapter
                ("select*from Kitap3", baglantim);
            DataSet ds = new DataSet();
            dk.Fill(ds, "Kitap3");
            //Fill sayesinde adapterin içi dolar.
            //dk adapteriyle ds nesnesini (setini) çağırıyoruz. 

            dataGridView1.DataSource = ds.Tables["Kitap3"];
            //disconnection mimari
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //connection mimari= açıp anlık veriyi alıyoru ve kapatıyoruz.

            baglantim.Open();
            SqlCommand kayitekle = new SqlCommand
               ("insert into Kitap3(KitapNo,KitapAd,KitapYazar,KitapTur, KitapFiyat,Vergi)" +
                "values(@k1,@k2,@k3,@k4,@k5,@k6)", baglantim);
            //tytbox veri çekme yöntemi 2 tanedir.
            //a.txtbox1.text
            //b.parametre ile karışıklık önledik biz aşağıda


            kayitekle.Parameters.AddWithValue("@k1", textBox1.Text);
            kayitekle.Parameters.AddWithValue("@k2", textBox2.Text);
            kayitekle.Parameters.AddWithValue("@k3", textBox3.Text);
            kayitekle.Parameters.AddWithValue("@k4", textBox4.Text);
            kayitekle.Parameters.AddWithValue("@k5", textBox5.Text);
            kayitekle.Parameters.AddWithValue("@k6", textBox6.Text);



            kayitekle.ExecuteNonQuery();//sql e kayıt etmek için bu metot gereklidir.command sınıfının adamı
            MessageBox.Show("Kayıt Eklendi");// parametre üzerinde değişiklik yapmak için kullanılır.
            baglantim.Close();


        }

        private void button3_Click(object sender, EventArgs e)
        {
            baglantim.Open();
            SqlCommand kayitsil = new SqlCommand
                ("delete from Kitap3 where KitapAd=@ad", baglantim);
            kayitsil.Parameters.AddWithValue("ad", textBox2.Text);
            kayitsil.ExecuteNonQuery();
            MessageBox.Show("Kayıt Silindi");
            baglantim.Close();

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secim = dataGridView1.SelectedCells[0].RowIndex;
            //seçilen satırı hafızaya aldı
            string kitapno = dataGridView1.Rows[secim].Cells[0].Value.ToString();
            string kitapad = dataGridView1.Rows[secim].Cells[1].Value.ToString();
            string kitapyazar = dataGridView1.Rows[secim].Cells[2].Value.ToString();
            string kitaptur = dataGridView1.Rows[secim].Cells[3].Value.ToString();
            string kitapfiyat = dataGridView1.Rows[secim].Cells[4].Value.ToString();
            string vergi = dataGridView1.Rows[secim].Cells[5].Value.ToString();

            //hafızaya sırayla her sütunu yazdık yani indeksleri yazdık
            textBox1.Text = kitapno;
            textBox2.Text = kitapad;
            textBox3.Text = kitapyazar;
            textBox4.Text = kitaptur;
            textBox5.Text = kitapfiyat;
            textBox6.Text = vergi;


        }

        private void button4_Click(object sender, EventArgs e)
        {
            baglantim.Open();
            SqlCommand kayitgüncelle = new SqlCommand("update Kitap3 set KitapAd=@m2,KitapYazar=@m3,KitapTur=@m4,KitapFiyat=@m5,Vergi=@m6 where KitapNo=@m1", baglantim);
            kayitgüncelle.Parameters.AddWithValue("@m1", textBox1.Text);
            kayitgüncelle.Parameters.AddWithValue("@m2", textBox2.Text);
            kayitgüncelle.Parameters.AddWithValue("@m3", textBox3.Text);
            kayitgüncelle.Parameters.AddWithValue("@m4", textBox4.Text);
            kayitgüncelle.Parameters.AddWithValue("@m5", textBox5.Text);
            kayitgüncelle.Parameters.AddWithValue("@m6", textBox6.Text);

            kayitgüncelle.ExecuteNonQuery();
            MessageBox.Show("Güncelleme Gerçekleşti");
            baglantim.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            baglantim.Open();
            SqlCommand hesapla1 = new SqlCommand("select count(KitapNo) from Kitap3", baglantim);
            SqlDataReader okuma1 = hesapla1.ExecuteReader();
            while(okuma1.Read())    
            {
                label14.Text = okuma1[0].ToString();
            }
            baglantim.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            baglantim.Open();
            SqlCommand hesapla = new SqlCommand("select max(KitapFiyat) from Kitap3", baglantim);
            SqlDataReader okuma = hesapla.ExecuteReader();
            while (okuma.Read())
            {
                label13.Text = okuma[0].ToString();
            }
            baglantim.Close();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            SqlDataAdapter db=new SqlDataAdapter("select*from Kitap3 where KitapAd='"+textBox9.Text+"'",baglantim);
            DataSet ds= new DataSet();
            db.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            textBox9.Clear();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            baglantim.Open();
            SqlCommand hesapla2 = new SqlCommand("select sum(KitapFiyat) from Kitap3", baglantim);
            SqlDataReader okuma2 = hesapla2.ExecuteReader();
            while (okuma2.Read())
            {
                label15.Text = okuma2[0].ToString();
            }
            baglantim.Close();

        }

        private void button8_Click(object sender, EventArgs e)
        {
            baglantim.Open();
            SqlCommand hesapla3 = new SqlCommand("select avg(KitapFiyat) from Kitap3", baglantim);
            SqlDataReader okuma3 = hesapla3.ExecuteReader();
            while (okuma3.Read())
            {
                label16.Text = okuma3[0].ToString();
            }
            baglantim.Close();
        }
    }
}
