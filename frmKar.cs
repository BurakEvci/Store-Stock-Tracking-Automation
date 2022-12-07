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
    public partial class frmKar : Form
    {
        public frmKar()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-H8CJICS;Initial Catalog=Stok_Takip;Integrated Security=True");
        DataSet daset = new DataSet();

        private void giderlistele()
        {


            baglanti.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select barkodno, urunadi, miktari*alisfiyati as toplamfiyat from siparis", baglanti);
            adtr.Fill(daset, "gider");
            dataGridView1.DataSource = daset.Tables["gider"];

            baglanti.Close();

        }

        private void gelirlistele()
        {
            baglanti.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select barkodno, urunadi, toplamfiyati from satis", baglanti);
            adtr.Fill(daset, "gelir");
            dataGridView2.DataSource = daset.Tables["gelir"];

            baglanti.Close();
        }

        private void gelirtoplamı()
        {
            baglanti.Open();
            //SqlDataAdapter adtr = new SqlDataAdapter("select barkodno, urunadi, toplamfiyati from satis", baglanti);
            //adtr.Fill(daset, "satis");
            //dataGridView2.DataSource = daset.Tables["satis"];


            //SqlDataAdapter adtr = new SqlDataAdapter("select p.urunadi, (-p.miktari * p.alisfiyati) + d.toplamfiyati as toplamfiyat from siparis p join satis d on d.barkodno = p.barkodno", baglanti);
            //adtr.Fill(daset, "siparis");
            //dataGridView3.DataSource = daset.Tables["siparis"];


            SqlDataAdapter adtr = new SqlDataAdapter("select sum(toplamfiyati) as toplamgelir from satis", baglanti);
            adtr.Fill(daset, "satis");
            dataGridView3.DataSource = daset.Tables["satis"];

            //SELECT p.urunadi,
            //p.price* p.quantity * (100 - d.value) / 100  AS total_price
            //FROM purchase p
            //JOIN discount d ON d.id = p.discount_id;




            baglanti.Close();
        }

        private void gidertoplamı()
        {
            baglanti.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select sum(miktari*alisfiyati) as toplamgider from siparis", baglanti);
            adtr.Fill(daset, "siparis");
            dataGridView4.DataSource = daset.Tables["siparis"];

            baglanti.Close();
        }

        //private void kar()
        //{
            


        //    //select barkodno, urunadi, miktari*alisfiyati as toplamfiyat from siparis
        //    baglanti.Open();
        //    SqlDataAdapter adtr = new SqlDataAdapter("select p.urunadi, (-p.miktari * p.alisfiyati) + d.toplamfiyati as toplamfiyat from siparis p join satis d on d.barkodno = p.barkodno", baglanti);
        //    //SqlDataAdapter adtr = new SqlDataAdapter("select p.urunadi, sum(-p.miktari * p.alisfiyati) + sum(d.toplamfiyati) as toplamfiyat from siparis p join satis d on d.barkodno = p.barkodno", baglanti);
        //    adtr.Fill(daset, "kar");
        //    dataGridView5.DataSource = daset.Tables["kar"];

        //    baglanti.Close();
        //}
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frmKar_Load(object sender, EventArgs e)
        {
            giderlistele();
            gelirlistele();
            gelirtoplamı();
            gidertoplamı();
            //kar();
        }

        //private void dataGridView5_CellContentClick(object sender, DataGridViewCellEventArgs e)
        //{

        //}
    }
}
