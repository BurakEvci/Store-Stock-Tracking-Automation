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
    public partial class frmTedarikçiler : Form
    {
        public frmTedarikçiler()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source = DESKTOP-H8CJICS; Initial Catalog = Stok_Takip; Integrated Security = True");
        DataSet daset = new DataSet();
        private void frmTedarikçiler_Load(object sender, EventArgs e)
        {
            Kayıt_Göster();
        }

        private void Kayıt_Göster()
        {
            baglanti.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select *from tedarikci", baglanti);
            adtr.Fill(daset, "tedarikci");
            dataGridView1.DataSource = daset.Tables["tedarikci"];
            baglanti.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtTedarikçiNo.Text = dataGridView1.CurrentRow.Cells["no"].Value.ToString();
            txtTedarikçiAdı.Text = dataGridView1.CurrentRow.Cells["ad"].Value.ToString();
            txtTedarikçiTel.Text = dataGridView1.CurrentRow.Cells["telefon"].Value.ToString();
            txtTedarikçiAdres.Text = dataGridView1.CurrentRow.Cells["adres"].Value.ToString();
            txtTedarikçiEmail.Text = dataGridView1.CurrentRow.Cells["email"].Value.ToString();

        }

        private void btnGüncelle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("update tedarikci set ad=@ad,telefon=@telefon,adres=@adres,email=@email where no=@no", baglanti);

            komut.Parameters.AddWithValue("@tc", txtTedarikçiNo.Text);
            komut.Parameters.AddWithValue("@adsoyad", txtTedarikçiAdı.Text);
            komut.Parameters.AddWithValue("@telefon", txtTedarikçiTel.Text);
            komut.Parameters.AddWithValue("@adres", txtTedarikçiAdres.Text);
            komut.Parameters.AddWithValue("@email", txtTedarikçiEmail.Text);
            komut.ExecuteNonQuery(); //onaylama
            baglanti.Close();
            daset.Tables["tedarikci"].Clear();
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
            SqlCommand komut = new SqlCommand("delete from tedarikci where no='" + dataGridView1.CurrentRow.Cells["no"].Value.ToString() + "' ", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            daset.Tables["tedarikci"].Clear();
            Kayıt_Göster();
            MessageBox.Show("Kayıt başarıyla Silindi.");

        }

        private void txtTedarikçiNoAra_TextChanged(object sender, EventArgs e)
        {
            DataTable tablo = new DataTable();
            baglanti.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select *from tedarikci where no like '%" + txtTedarikçiNoAra.Text + "%'", baglanti); //% ile karakteri bulup listeleme yapıyor
            adtr.Fill(tablo);
            dataGridView1.DataSource = tablo;
            baglanti.Close();
        }

        private void txtTedarikçiNo_TextChanged(object sender, EventArgs e)
        {
            if (txtTedarikçiNo.Text == "")
            {
                txtTedarikçiAdı.Text = "";
                txtTedarikçiTel.Text = "";
                txtTedarikçiAdres.Text = "";
                txtTedarikçiEmail.Text = "";
            }
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select *from tedarikci where no like '" + txtTedarikçiNo.Text + "'", baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                txtTedarikçiAdı.Text = read["ad"].ToString();
                txtTedarikçiTel.Text = read["telefon"].ToString();
                txtTedarikçiAdres.Text = read["adres"].ToString();
                txtTedarikçiEmail.Text = read["email"].ToString();
              
            }
            baglanti.Close();
        }
    }
}
