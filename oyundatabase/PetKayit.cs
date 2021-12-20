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
    public partial class PetKayit : Form
    {
        public PetKayit()
        {
            InitializeComponent();
        }
        NpgsqlConnection baglanti = new NpgsqlConnection("server=localhost; port=5432; Database=game1; user ID=postgres; password=furkan5634");

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void btnlistele_Click(object sender, EventArgs e)
        {
            string sorgu = "select * from pet";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sorgu, baglanti);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void btnekle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlCommand komut1 = new NpgsqlCommand("insert into pet(pet_name, pet_power) values(@p1,@p2)", baglanti);
            komut1.Parameters.AddWithValue("@p1", textpetname.Text);
            komut1.Parameters.AddWithValue("@p2", int.Parse(textpetpower.Text));
            komut1.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Pet kaydı tamamlanmıştır.");
        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlCommand komut2 = new NpgsqlCommand("Delete from pet where pet_name= @p1", baglanti);
            komut2.Parameters.AddWithValue("@p1", textpetname.Text);
            komut2.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Pet silme işlemi tamamlanmıştır.");
        }

        private void btnguncelle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlCommand komut3 = new NpgsqlCommand("update pet set pet_power=@p2 where pet_name= @p1", baglanti);
            komut3.Parameters.AddWithValue("@p1", textpetname.Text);
            komut3.Parameters.AddWithValue("@p2", int.Parse(textpetpower.Text));
            komut3.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("İtem güncelleme işlemi tamamlanmıştır.");
        }
    }
}
