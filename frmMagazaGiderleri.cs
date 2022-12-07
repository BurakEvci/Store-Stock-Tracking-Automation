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
    public partial class frmMagazaGiderleri : Form
    {
        public frmMagazaGiderleri()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-H8CJICS;Initial Catalog=Stok_Takip;Integrated Security=True");
        DataSet daset = new DataSet();


        
        private void giderkaydet()
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into magazagider(elemansayisi,elemanmaasi,elektrikfatura,digergider,toplamgider) values(@elemansayisi,@elemanmaasi,@elektrikfatura,@digergider,@toplamgider)", baglanti);
            komut.Parameters.AddWithValue("@elemansayisi", txtElemanSayısı.Text);
            komut.Parameters.AddWithValue("@elemanmaasi", txtElemanMaas.Text);
            komut.Parameters.AddWithValue("@elektrikfatura", txtElektrikFatura.Text);
            komut.Parameters.AddWithValue("@digergider", txtDigerGider.Text);
           

            komut.ExecuteNonQuery();
            baglanti.Close();
        }

        private void gidergoster()
        {
            baglanti.Open();
           
            SqlCommand komut = new SqlCommand("select *from magazagider", baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                txtElemanSayısı.Text = read["elemansayisi"].ToString();
                txtElemanMaas.Text = read["elemanmaasi"].ToString();
                txtElektrikFatura.Text = read["elektrikfatura"].ToString();
                txtDigerGider.Text = read["digergider"].ToString();

                
            }
           
            baglanti.Close();
            
        }



        




        private void btnHesapla_Click(object sender, EventArgs e)
        {
            giderkaydet();
            gidergoster();

        }
        

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            
        }

        private void frmMagazaGiderleri_Load(object sender, EventArgs e)
        {
            
        }
    }
}
