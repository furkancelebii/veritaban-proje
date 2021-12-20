using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace oyundatabase
{
    public partial class Kullanicikaydi : Form
    {
        public Kullanicikaydi()
        {
            InitializeComponent();

        }
        NpgsqlConnection baglanti = new NpgsqlConnection("server=localhost; port=5432; Database=game1; user ID=postgres; password=furkan5634");

        private void kategorid_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }
        private void btnlistele_Click(object sender, EventArgs e)
        {
            string sorgu = "select * from users";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sorgu, baglanti);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void btnekle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlCommand komut1 = new NpgsqlCommand("insert into users(k_adi, pass, email) values(@p1,@p2,@p3)", baglanti);
            komut1.Parameters.AddWithValue("@p1", textkullaniciadi.Text);
            komut1.Parameters.AddWithValue("@p2", textsifre.Text);
            komut1.Parameters.AddWithValue("@p3", textemail.Text);
            komut1.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Kullanıcı kaydı tamamlanmıştır.");

        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlCommand komut2 = new NpgsqlCommand("Delete from users where k_adi= @p1", baglanti);
            komut2.Parameters.AddWithValue("@p1", textkullaniciadi.Text);
            komut2.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Kullanıcı silme işlemi tamamlanmıştır.");

        }

        private void btnara_Click(object sender, EventArgs e)
        {

        }

        private void buttonguncelle(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlCommand komut3 = new NpgsqlCommand("update users set pass= @p1, email= @p2 where k_adi= @p3", baglanti);
            komut3.Parameters.AddWithValue("@p1", textsifre.Text);
            komut3.Parameters.AddWithValue("@p2", textemail.Text);
            komut3.Parameters.AddWithValue("@p3", textkullaniciadi.Text);
            komut3.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Kullanıcı güncelleme işlemi tamamlanmıştır.");
        }
    }
}
