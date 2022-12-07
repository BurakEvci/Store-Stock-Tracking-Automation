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
    public partial class frmmagazagiderlistele : Form
    {
        public frmmagazagiderlistele()
        {
            InitializeComponent();
        }



        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-H8CJICS;Initial Catalog=Stok_Takip;Integrated Security=True");
        DataSet daset = new DataSet();

        private void magazagiderlistele()
        {
            baglanti.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select elemansayisi,elemanmaasi,elektrikfatura,digergider, elemansayisi*elemanmaasi+elektrikfatura+digergider as toplamgider from magazagider", baglanti);
            adtr.Fill(daset, "magazagider");
            dataGridView1.DataSource = daset.Tables["magazagider"];

            baglanti.Close();
        }

        private void frmmagazagiderlistele_Load(object sender, EventArgs e)
        {
            magazagiderlistele();
        }


        //private void giderlistele()
        //{


        //    baglanti.Open();
        //    SqlDataAdapter adtr = new SqlDataAdapter("select elemansayisi*elemanmaasi+elektrikfatura+digergider as toplamgider from magazagider", baglanti);
        //    adtr.Fill(daset, "magazagider");
        //    dataGridView1.DataSource = daset.Tables["magazagider"];

        //    baglanti.Close();

        //}


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
