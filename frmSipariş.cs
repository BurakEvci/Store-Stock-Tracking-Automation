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
    public partial class frmSipariş : Form
    {
        public frmSipariş()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-H8CJICS;Initial Catalog=Stok_Takip;Integrated Security=True");


        //private void Temizle()
        //{
        //    if (txtTedarikçiNO.Text == "")
        //    {
        //        foreach (Control item in groupBox1.Controls)
        //        {
        //            if (item is TextBox)
        //            {
        //                if (item != txtSiparişMiktarı)
        //                {
        //                    item.Text = "";
        //                }
        //            }
        //        }
        //    }
        //}

        private void tedarikcigetir()
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select *from tedarikci ", baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                txtTedarikçiNO.Items.Add(read["no"].ToString());
            }
            baglanti.Close();
        }

        private void frmSipariş_Load(object sender, EventArgs e)
        {
            tedarikcigetir();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            if (txtTedarikçiNO.Text == "")
            {
                txtTedarikciAdı.Text = "";
                txtTedarikciTelefonu.Text = "";
            }
            

            baglanti.Open();
            SqlCommand komut = new SqlCommand("select *from tedarikci where no='" + txtTedarikçiNO.SelectedItem + "'", baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                txtTedarikciAdı.Text = read["ad"].ToString();
                txtTedarikciTelefonu.Text = read["telefon"].ToString();
            }
            baglanti.Close();

        }

        private void txtSiparişBarkodNo_TextChanged(object sender, EventArgs e)
        {
            if (txtSiparişBarkodNo.Text == "")
            {
                txtSiparişÜrünAdı.Text = "";
                
                txtSiparişAlışFiyatı.Text = "";

            }
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select *from urun where barkodno like '" + txtSiparişBarkodNo.Text + "'", baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                txtSiparişÜrünAdı.Text = read["urunadi"].ToString();
                txtSiparişAlışFiyatı.Text = read["alisfiyati"].ToString();

            }
            baglanti.Close();

        }

        private void btnSatınAl_Click(object sender, EventArgs e)
        {

                baglanti.Open();
    
                SqlCommand komut = new SqlCommand("insert into siparis(TedarikciNo,TedarikciAdı,TedarikciTelefonu,barkodno,urunadi,miktari,alisfiyati,tarih) values(@TedarikciNo,@TedarikciAdı,@TedarikciTelefonu,@barkodno,@urunadi,@miktari,@alisfiyati,@tarih) ", baglanti);
                komut.Parameters.AddWithValue("@TedarikciNo", txtTedarikçiNO.Text);
                komut.Parameters.AddWithValue("@TedarikciAdı", txtTedarikciAdı.Text);
                komut.Parameters.AddWithValue("@TedarikciTelefonu", txtTedarikciTelefonu.Text);
                komut.Parameters.AddWithValue("@barkodno", txtSiparişBarkodNo.Text);
                komut.Parameters.AddWithValue("@urunadi", txtSiparişÜrünAdı.Text);
                komut.Parameters.AddWithValue("@miktari", int.Parse(txtSiparişMiktarı.Text));
                komut.Parameters.AddWithValue("@alisfiyati", double.Parse(txtSiparişAlışFiyatı.Text));
                komut.Parameters.AddWithValue("@tarih", DateTime.Now.ToString());
                komut.ExecuteNonQuery();


                SqlCommand komut2 = new SqlCommand("update urun set miktari=miktari+'" + int.Parse(txtSiparişMiktarı.Text) + "' where barkodno='" + txtSiparişBarkodNo.Text + "'", baglanti);
                komut2.ExecuteNonQuery();
                baglanti.Close();
                foreach (Control item in groupBox1.Controls)
                {
                    if (item is TextBox)
                    {
                        item.Text = "";
                    }
                }
                MessageBox.Show("Ürünler Sipariş Edildi.");


            

        }
    }
}
