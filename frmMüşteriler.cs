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
    public partial class frmMüşteriler : Form
    {
        public frmMüşteriler()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection(@"Data Source = DESKTOP-H8CJICS; Initial Catalog = Stok_Takip; Integrated Security = True");
        DataSet daset = new DataSet();
        private void frmMüşteriler_Load(object sender, EventArgs e)
        {
            Kayıt_Göster();

        }

        private void Kayıt_Göster()
        {
            baglanti.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select *from Müşteri", baglanti);
            adtr.Fill(daset, "Müşteri");
            dataGridView1.DataSource = daset.Tables["Müşteri"];
            baglanti.Close();
        }

        

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtTc.Text = dataGridView1.CurrentRow.Cells["tc"].Value.ToString();
            txtAdSoyad.Text = dataGridView1.CurrentRow.Cells["adsoyad"].Value.ToString();
            txtTelefon.Text = dataGridView1.CurrentRow.Cells["telefon"].Value.ToString();
            txtAdres.Text = dataGridView1.CurrentRow.Cells["adres"].Value.ToString();
            txtEmail.Text = dataGridView1.CurrentRow.Cells["email"].Value.ToString();

        }

        private void btnGüncelle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("update Müşteri set adsoyad=@adsoyad,telefon=@telefon,adres=@adres,email=@email where tc=@tc",baglanti);

            komut.Parameters.AddWithValue("@tc", txtTc.Text);
            komut.Parameters.AddWithValue("@adsoyad", txtAdSoyad.Text);
            komut.Parameters.AddWithValue("@telefon", txtTelefon.Text);
            komut.Parameters.AddWithValue("@adres", txtAdres.Text);
            komut.Parameters.AddWithValue("@email", txtEmail.Text);
            komut.ExecuteNonQuery(); //onaylama
            baglanti.Close();
            daset.Tables["Müşteri"].Clear();
            Kayıt_Göster();
            MessageBox.Show("Müşteri kaydı başarıyla güncellendi.");
            foreach (Control item in this.Controls)
            {
                if (item is TextBox) //textboxların içini silmek için 
                {
                    item.Text = "";
                }
            }

        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("delete from Müşteri where tc='" + dataGridView1.CurrentRow.Cells["tc"].Value.ToString() + "' ",baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            daset.Tables["Müşteri"].Clear();
            Kayıt_Göster();
            MessageBox.Show("Kayıt başarıyla Silindi.");
        
        }

        private void txtTcAra_TextChanged(object sender, EventArgs e)
        {
            DataTable tablo = new DataTable();
            baglanti.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select *from Müşteri where tc like '%"+txtTcAra.Text+"%'",baglanti); //% ile karakteri bulup listeleme yapıyor
            adtr.Fill(tablo);
            dataGridView1.DataSource = tablo;
            baglanti.Close();
        }

        private void txtTc_TextChanged(object sender, EventArgs e)
        {
            
                if (txtTc.Text == "")
                {
                    txtAdSoyad.Text = "";
                    txtTelefon.Text = "";
                    txtAdres.Text = "";
                    txtEmail.Text = "";
                }
                baglanti.Open();
                SqlCommand komut = new SqlCommand("select *from Müşteri where tc like '" + txtTc.Text + "'", baglanti);
                SqlDataReader read = komut.ExecuteReader();
                while (read.Read())
                {
                    txtAdSoyad.Text = read["adsoyad"].ToString();
                    txtTelefon.Text = read["telefon"].ToString();
                txtAdres.Text = read["adres"].ToString();
                    txtEmail.Text = read["email"].ToString();
                }
                baglanti.Close();
            
        }
    }
}
