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
    public partial class frmTedarikçiEkle : Form
    {
        public frmTedarikçiEkle()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-H8CJICS;Initial Catalog=Stok_Takip;Integrated Security=True");
        private void frmTedarikçiEkle_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into tedarikci(no,ad,telefon,adres,email) values(@no,@ad,@telefon,@adres,@email)", baglanti);
            komut.Parameters.AddWithValue("@no", txtTedarikçiNo.Text);
            komut.Parameters.AddWithValue("@ad", txtTedarikçiAdı.Text);
            komut.Parameters.AddWithValue("@telefon", txtTedarikçiTel.Text);
            komut.Parameters.AddWithValue("@adres", txtTedarikçiAdres.Text);
            komut.Parameters.AddWithValue("@email", txtTedarikçiEmail.Text);
            komut.ExecuteNonQuery(); //onaylama
            baglanti.Close();
            MessageBox.Show("Tedarikçi başarıyla eklendi.");
            foreach (Control item in this.Controls)
            {
                if (item is TextBox) //textboxların içini silmek için 
                {
                    item.Text = "";
                }

            }
        }


    }
}
