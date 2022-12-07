/****************************************************************************
**					SAKARYA ÜNİVERSİTESİ
**				BİLGİSAYAR VE BİLİŞİM BİLİMLERİ FAKÜLTESİ
**				    BİLGİSAYAR MÜHENDİSLİĞİ BÖLÜMÜ
**				   NESNEYE DAYALI PROGRAMLAMA DERSİ
**					2014-2015 BAHAR DÖNEMİ
**	
**				ÖDEV NUMARASI..........: Proje
**				ÖĞRENCİ ADI............: Burak Can Evci
**				ÖĞRENCİ NUMARASI.......: G211210091
**                         DERSİN ALINDIĞI GRUP...: B
****************************************************************************/

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

namespace magaza1
{
    public partial class frmÜrünler : Form
    {
        public frmÜrünler()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-H8CJICS;Initial Catalog=Stok_Takip;Integrated Security=True");
        DataSet daset = new DataSet();
        private void kategorigetir()
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select *from kategoribilgileri", baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                comboKategori.Items.Add(read["kategori"].ToString());
            }
            baglanti.Close();
        }

        private void frmÜrünler_Load(object sender, EventArgs e)
        {
            Ürünler();
            kategorigetir();
            BulunduguYertxt.Items.Add("Depo");
            BulunduguYertxt.Items.Add("Raf");
            comboYerAra.Items.Add("Depo");
            comboYerAra.Items.Add("Raf");
        }

        private void Ürünler()
        {
            baglanti.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select *from urun", baglanti);
            adtr.Fill(daset, "urun");
            dataGridView1.DataSource = daset.Tables["urun"];
            baglanti.Close();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            BarkodNotxt.Text = dataGridView1.CurrentRow.Cells["barkodno"].Value.ToString();
            Kategoritxt.Text = dataGridView1.CurrentRow.Cells["kategori"].Value.ToString();
            Markatxt.Text = dataGridView1.CurrentRow.Cells["marka"].Value.ToString();
            ÜrünAdıtxt.Text = dataGridView1.CurrentRow.Cells["urunadi"].Value.ToString();
            Miktarıtxt.Text = dataGridView1.CurrentRow.Cells["miktari"].Value.ToString();
            AlışFiyatıtxt.Text = dataGridView1.CurrentRow.Cells["alisfiyati"].Value.ToString();
            SatışFiyatıtxt.Text = dataGridView1.CurrentRow.Cells["satisfiyati"].Value.ToString();
            BulunduguYertxt.Text = dataGridView1.CurrentRow.Cells["yer"].Value.ToString();
            
        }

        private void btnGüncelle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("update urun set urunadi=@urunadi,miktari=@miktari,alisfiyati=@alisfiyati,satisfiyati=@satisfiyati,yer=@yer where barkodno=@barkodno", baglanti);
            komut.Parameters.AddWithValue("@barkodno", BarkodNotxt.Text);
            komut.Parameters.AddWithValue("@urunadi", ÜrünAdıtxt.Text);
            komut.Parameters.AddWithValue("@miktari", int.Parse(Miktarıtxt.Text));
            komut.Parameters.AddWithValue("@alisfiyati", double.Parse(AlışFiyatıtxt.Text));
            komut.Parameters.AddWithValue("@satisfiyati", double.Parse(SatışFiyatıtxt.Text));
            komut.Parameters.AddWithValue("@yer", BulunduguYertxt.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            daset.Tables["urun"].Clear(); //ürün güncelledikten sonra tablodaki veri silinip yeni veri yazdırılıyor. 
            Ürünler();
            MessageBox.Show("Güncelleme yapıldı");
            foreach (Control item in this.Controls)
            {
                if (item is TextBox)
                {
                    item.Text = "";
                }
            }
        }

        private void btnMarkaGuncelle_Click(object sender, EventArgs e)
        {
            if (BarkodNotxt.Text!="")
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("update urun set kategori=@kategori,marka=@marka,yer=@yer where barkodno=@barkodno", baglanti);
                komut.Parameters.AddWithValue("@barkodno", BarkodNotxt.Text);
                komut.Parameters.AddWithValue("@kategori", comboKategori.Text);
                komut.Parameters.AddWithValue("@marka", comboMarka.Text);
                komut.Parameters.AddWithValue("@yer", BulunduguYertxt.Text);

                komut.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Güncelleme yapıldı"); // güncelledikten sonra tablodaki veri silinip yeni veri yazdırılıyor.
                daset.Tables["urun"].Clear();
                Ürünler();
            }
            else
            {
                MessageBox.Show("Barkodno yazılı değil");
            }

            foreach (Control item in this.Controls)
            {
                if (item is ComboBox)
                {
                    item.Text = "";
                }
            }
        }

        private void comboKategori_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboMarka.Items.Clear();
            comboMarka.Text = "";
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select *from markabilgileri where kategori='" + comboKategori.SelectedItem + "'", baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                comboMarka.Items.Add(read["marka"].ToString());
            }
            baglanti.Close();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("delete from urun where barkodno='" + dataGridView1.CurrentRow.Cells["barkodno"].Value.ToString() + "' ", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            daset.Tables["urun"].Clear();
            Ürünler(); 
            MessageBox.Show("Kayıt başarıyla Silindi.");
        }

        private void txtBarkodNoAra_TextChanged(object sender, EventArgs e)
        {
            DataTable tablo = new DataTable();
            baglanti.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select *from urun where barkodno like '%" + txtBarkodNoAra.Text + "%'", baglanti); //% ile karakteri bulup listeleme yapıyor
            adtr.Fill(tablo);
            dataGridView1.DataSource = tablo;
            baglanti.Close();
        }


        private void BarkodNotxt_TextChanged(object sender, EventArgs e)
        {
            if (BarkodNotxt.Text == "")
            {
                Kategoritxt.Text = "";
                Markatxt.Text = "";
                ÜrünAdıtxt.Text = "";
                Miktarıtxt.Text = "";
                AlışFiyatıtxt.Text = "";
                SatışFiyatıtxt.Text = "";
                BulunduguYertxt.Text = "";
            }

            baglanti.Open();
            SqlCommand komut = new SqlCommand("select *from urun where barkodno like '" + BarkodNotxt.Text + "'", baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                Kategoritxt.Text = read["kategori"].ToString();
                Markatxt.Text = read["marka"].ToString();
                ÜrünAdıtxt.Text = read["urunadi"].ToString();
                Miktarıtxt.Text = read["miktari"].ToString();
                AlışFiyatıtxt.Text = read["alisfiyati"].ToString();
                SatışFiyatıtxt.Text = read["satisfiyati"].ToString();
                BulunduguYertxt.Text = read["yer"].ToString();
            }
            baglanti.Close();
        }

        private void label14_Click(object sender, EventArgs e)
        {
            
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }


        private void comboYerAra_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            DataTable tablo = new DataTable();
            baglanti.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select *from urun where yer like '%" + comboYerAra.Text + "%'", baglanti); //% ile karakteri bulup listeleme yapıyor
            adtr.Fill(tablo);
            dataGridView1.DataSource = tablo;
            baglanti.Close();
        }
    }
}
