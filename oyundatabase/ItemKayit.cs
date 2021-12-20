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
    public partial class ItemKayit : Form
    {
        public ItemKayit()
        {
            InitializeComponent();
        }
        NpgsqlConnection baglanti = new NpgsqlConnection("server=localhost; port=5432; Database=game1; user ID=postgres; password=furkan5634");


        private void label_Click(object sender, EventArgs e)
        {

        }

        private void textItemid_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnlistele_Click(object sender, EventArgs e)
        {
            string sorgu = "select * from items";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sorgu, baglanti);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void btnekle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlCommand komut1 = new NpgsqlCommand("insert into items(item_name, item_rank, item_power, item_price) values(@p2,@p3,@p4,@p5)", baglanti);
            komut1.Parameters.AddWithValue("@p2", textitemname.Text);
            komut1.Parameters.AddWithValue("@p3", textitemrank.Text);
            komut1.Parameters.AddWithValue("@p4", int.Parse(textitempower.Text));
            komut1.Parameters.AddWithValue("@p5", int.Parse(textitemprice.Text));
            komut1.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("İtem kaydı tamamlanmıştır.");
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlCommand komut2 = new NpgsqlCommand("Delete from items where item_name= @p1", baglanti);
            komut2.Parameters.AddWithValue("@p1", textitemname.Text);
            komut2.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("İtem silme işlemi tamamlanmıştır.");
        }

        private void btnguncelle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlCommand komut3 = new NpgsqlCommand("update items set item_rank= @p2 ,item_power=@p3 ,item_price= @p4 where item_name= @p1", baglanti);
            komut3.Parameters.AddWithValue("@p2", textitemrank.Text);
            komut3.Parameters.AddWithValue("@p3", int.Parse(textitempower.Text));
            komut3.Parameters.AddWithValue("@p4", int.Parse(textitemprice.Text));
            komut3.Parameters.AddWithValue("@p1", textitemname.Text);
            komut3.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("İtem güncelleme işlemi tamamlanmıştır.");
        }
    }
}
