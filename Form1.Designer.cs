
namespace magaza1
{
    partial class frmSatis
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTelefon = new System.Windows.Forms.TextBox();
            this.txtAdSoyad = new System.Windows.Forms.TextBox();
            this.txtTc = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtToplamFiyatı = new System.Windows.Forms.TextBox();
            this.txtSatışFiyatı = new System.Windows.Forms.TextBox();
            this.txtMiktarı = new System.Windows.Forms.TextBox();
            this.txtStokAdet = new System.Windows.Forms.TextBox();
            this.txtÜrünAdı = new System.Windows.Forms.TextBox();
            this.txtBarkodNo = new System.Windows.Forms.TextBox();
            this.btnEkle = new System.Windows.Forms.Button();
            this.btnSatışYap = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnSatışİptal = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.lblGenelToplam = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnKar = new System.Windows.Forms.Button();
            this.btnSiparişleriListele = new System.Windows.Forms.Button();
            this.btnSiparişEt = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnSatışListele = new System.Windows.Forms.Button();
            this.btnTedarikçiler = new System.Windows.Forms.Button();
            this.btnTedarikçiEkle = new System.Windows.Forms.Button();
            this.btnÜrünler = new System.Windows.Forms.Button();
            this.btnÜrünEkle = new System.Windows.Forms.Button();
            this.btnMüşteriler = new System.Windows.Forms.Button();
            this.btnMüşteriEkleme = new System.Windows.Forms.Button();
            this.btnMagazaGiderleri = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(208, 113);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(440, 228);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtTelefon);
            this.groupBox1.Controls.Add(this.txtAdSoyad);
            this.groupBox1.Controls.Add(this.txtTc);
            this.groupBox1.Location = new System.Drawing.Point(2, 113);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 101);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Müşteri Bilgileri";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Telefon";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Ad Soyad";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "TC";
            // 
            // txtTelefon
            // 
            this.txtTelefon.Location = new System.Drawing.Point(94, 72);
            this.txtTelefon.Name = "txtTelefon";
            this.txtTelefon.ReadOnly = true;
            this.txtTelefon.Size = new System.Drawing.Size(100, 23);
            this.txtTelefon.TabIndex = 2;
            // 
            // txtAdSoyad
            // 
            this.txtAdSoyad.Location = new System.Drawing.Point(94, 45);
            this.txtAdSoyad.Name = "txtAdSoyad";
            this.txtAdSoyad.ReadOnly = true;
            this.txtAdSoyad.Size = new System.Drawing.Size(100, 23);
            this.txtAdSoyad.TabIndex = 1;
            // 
            // txtTc
            // 
            this.txtTc.Location = new System.Drawing.Point(94, 17);
            this.txtTc.Name = "txtTc";
            this.txtTc.Size = new System.Drawing.Size(100, 23);
            this.txtTc.TabIndex = 0;
            this.txtTc.TextChanged += new System.EventHandler(this.txtTc_TextChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtToplamFiyatı);
            this.groupBox2.Controls.Add(this.txtSatışFiyatı);
            this.groupBox2.Controls.Add(this.txtMiktarı);
            this.groupBox2.Controls.Add(this.txtStokAdet);
            this.groupBox2.Controls.Add(this.txtÜrünAdı);
            this.groupBox2.Controls.Add(this.txtBarkodNo);
            this.groupBox2.Location = new System.Drawing.Point(2, 220);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 186);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ürün Bilgileri";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(10, 155);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 15);
            this.label8.TabIndex = 9;
            this.label8.Text = "Toplam Fiyatı";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(11, 129);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 15);
            this.label7.TabIndex = 8;
            this.label7.Text = "Satış Fiyatı";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 103);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 15);
            this.label6.TabIndex = 7;
            this.label6.Text = "Miktarı";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(10, 77);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(61, 15);
            this.label10.TabIndex = 6;
            this.label10.Text = "Stok Adeti";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 51);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 15);
            this.label5.TabIndex = 6;
            this.label5.Text = "Ürün Adı";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 15);
            this.label4.TabIndex = 5;
            this.label4.Text = "BarkodNo";
            // 
            // txtToplamFiyatı
            // 
            this.txtToplamFiyatı.Location = new System.Drawing.Point(94, 152);
            this.txtToplamFiyatı.Name = "txtToplamFiyatı";
            this.txtToplamFiyatı.ReadOnly = true;
            this.txtToplamFiyatı.Size = new System.Drawing.Size(100, 23);
            this.txtToplamFiyatı.TabIndex = 4;
            this.txtToplamFiyatı.TextChanged += new System.EventHandler(this.txtToplamFiyatı_TextChanged);
            // 
            // txtSatışFiyatı
            // 
            this.txtSatışFiyatı.Location = new System.Drawing.Point(94, 126);
            this.txtSatışFiyatı.Name = "txtSatışFiyatı";
            this.txtSatışFiyatı.ReadOnly = true;
            this.txtSatışFiyatı.Size = new System.Drawing.Size(100, 23);
            this.txtSatışFiyatı.TabIndex = 3;
            this.txtSatışFiyatı.TextChanged += new System.EventHandler(this.txtSatışFiyatı_TextChanged);
            // 
            // txtMiktarı
            // 
            this.txtMiktarı.Location = new System.Drawing.Point(94, 100);
            this.txtMiktarı.Name = "txtMiktarı";
            this.txtMiktarı.Size = new System.Drawing.Size(100, 23);
            this.txtMiktarı.TabIndex = 2;
            this.txtMiktarı.Text = "1";
            this.txtMiktarı.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtMiktarı.TextChanged += new System.EventHandler(this.txtMiktarı_TextChanged);
            // 
            // txtStokAdet
            // 
            this.txtStokAdet.Location = new System.Drawing.Point(94, 74);
            this.txtStokAdet.Name = "txtStokAdet";
            this.txtStokAdet.ReadOnly = true;
            this.txtStokAdet.Size = new System.Drawing.Size(100, 23);
            this.txtStokAdet.TabIndex = 1;
            // 
            // txtÜrünAdı
            // 
            this.txtÜrünAdı.Location = new System.Drawing.Point(94, 48);
            this.txtÜrünAdı.Name = "txtÜrünAdı";
            this.txtÜrünAdı.ReadOnly = true;
            this.txtÜrünAdı.Size = new System.Drawing.Size(100, 23);
            this.txtÜrünAdı.TabIndex = 1;
            // 
            // txtBarkodNo
            // 
            this.txtBarkodNo.Location = new System.Drawing.Point(94, 22);
            this.txtBarkodNo.Name = "txtBarkodNo";
            this.txtBarkodNo.Size = new System.Drawing.Size(100, 23);
            this.txtBarkodNo.TabIndex = 0;
            this.txtBarkodNo.TextChanged += new System.EventHandler(this.txtBarkodNo_TextChanged);
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(208, 353);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(75, 23);
            this.btnEkle.TabIndex = 3;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // btnSatışYap
            // 
            this.btnSatışYap.Location = new System.Drawing.Point(585, 353);
            this.btnSatışYap.Name = "btnSatışYap";
            this.btnSatışYap.Size = new System.Drawing.Size(75, 23);
            this.btnSatışYap.TabIndex = 4;
            this.btnSatışYap.Text = "Satış Yap";
            this.btnSatışYap.UseVisualStyleBackColor = true;
            this.btnSatışYap.Click += new System.EventHandler(this.btnSatışYap_Click);
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(655, 113);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(75, 23);
            this.btnSil.TabIndex = 5;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnSatışİptal
            // 
            this.btnSatışİptal.Location = new System.Drawing.Point(655, 143);
            this.btnSatışİptal.Name = "btnSatışİptal";
            this.btnSatışİptal.Size = new System.Drawing.Size(75, 23);
            this.btnSatışİptal.TabIndex = 6;
            this.btnSatışİptal.Text = "Satış İptal";
            this.btnSatışİptal.UseVisualStyleBackColor = true;
            this.btnSatışİptal.Click += new System.EventHandler(this.btnSatışİptal_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(405, 361);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(79, 15);
            this.label9.TabIndex = 7;
            this.label9.Text = "Genel Toplam";
            // 
            // lblGenelToplam
            // 
            this.lblGenelToplam.AutoSize = true;
            this.lblGenelToplam.Location = new System.Drawing.Point(509, 360);
            this.lblGenelToplam.Name = "lblGenelToplam";
            this.lblGenelToplam.Size = new System.Drawing.Size(0, 15);
            this.lblGenelToplam.TabIndex = 8;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnKar);
            this.panel1.Controls.Add(this.btnSiparişleriListele);
            this.panel1.Controls.Add(this.btnSiparişEt);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.btnSatışListele);
            this.panel1.Controls.Add(this.btnTedarikçiler);
            this.panel1.Controls.Add(this.btnTedarikçiEkle);
            this.panel1.Controls.Add(this.btnÜrünler);
            this.panel1.Controls.Add(this.btnÜrünEkle);
            this.panel1.Controls.Add(this.btnMüşteriler);
            this.panel1.Controls.Add(this.btnMüşteriEkleme);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(740, 107);
            this.panel1.TabIndex = 9;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btnKar
            // 
            this.btnKar.BackColor = System.Drawing.Color.Lime;
            this.btnKar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKar.Location = new System.Drawing.Point(14, 54);
            this.btnKar.Name = "btnKar";
            this.btnKar.Size = new System.Drawing.Size(79, 40);
            this.btnKar.TabIndex = 12;
            this.btnKar.Text = "Gelir-Gider";
            this.btnKar.UseVisualStyleBackColor = false;
            this.btnKar.Click += new System.EventHandler(this.btnKar_Click);
            // 
            // btnSiparişleriListele
            // 
            this.btnSiparişleriListele.BackColor = System.Drawing.Color.Yellow;
            this.btnSiparişleriListele.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSiparişleriListele.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSiparişleriListele.Location = new System.Drawing.Point(501, 7);
            this.btnSiparişleriListele.Name = "btnSiparişleriListele";
            this.btnSiparişleriListele.Size = new System.Drawing.Size(114, 39);
            this.btnSiparişleriListele.TabIndex = 11;
            this.btnSiparişleriListele.Text = "Siparişleri Listele";
            this.btnSiparişleriListele.UseVisualStyleBackColor = false;
            this.btnSiparişleriListele.Click += new System.EventHandler(this.btnSiparişleriListele_Click);
            // 
            // btnSiparişEt
            // 
            this.btnSiparişEt.BackColor = System.Drawing.Color.Yellow;
            this.btnSiparişEt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSiparişEt.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSiparişEt.Location = new System.Drawing.Point(13, 7);
            this.btnSiparişEt.Name = "btnSiparişEt";
            this.btnSiparişEt.Size = new System.Drawing.Size(80, 39);
            this.btnSiparişEt.TabIndex = 10;
            this.btnSiparişEt.Text = "Sipariş Et";
            this.btnSiparişEt.UseVisualStyleBackColor = false;
            this.btnSiparişEt.Click += new System.EventHandler(this.btnSiparişEt_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button2.Location = new System.Drawing.Point(626, 53);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(114, 40);
            this.button2.TabIndex = 9;
            this.button2.Text = "Kategori";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button1.Location = new System.Drawing.Point(626, 7);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(114, 40);
            this.button1.TabIndex = 8;
            this.button1.Text = "Marka";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnSatışListele
            // 
            this.btnSatışListele.BackColor = System.Drawing.Color.Lime;
            this.btnSatışListele.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSatışListele.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSatışListele.Location = new System.Drawing.Point(501, 54);
            this.btnSatışListele.Name = "btnSatışListele";
            this.btnSatışListele.Size = new System.Drawing.Size(114, 40);
            this.btnSatışListele.TabIndex = 7;
            this.btnSatışListele.Text = "Satışları Listele";
            this.btnSatışListele.UseVisualStyleBackColor = false;
            this.btnSatışListele.Click += new System.EventHandler(this.btnKazanç_Click);
            // 
            // btnTedarikçiler
            // 
            this.btnTedarikçiler.BackColor = System.Drawing.Color.Lime;
            this.btnTedarikçiler.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTedarikçiler.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnTedarikçiler.Location = new System.Drawing.Point(370, 54);
            this.btnTedarikçiler.Name = "btnTedarikçiler";
            this.btnTedarikçiler.Size = new System.Drawing.Size(114, 40);
            this.btnTedarikçiler.TabIndex = 6;
            this.btnTedarikçiler.Text = "Tedarikçiler";
            this.btnTedarikçiler.UseVisualStyleBackColor = false;
            this.btnTedarikçiler.Click += new System.EventHandler(this.btnTedarikçiler_Click);
            // 
            // btnTedarikçiEkle
            // 
            this.btnTedarikçiEkle.BackColor = System.Drawing.Color.Yellow;
            this.btnTedarikçiEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTedarikçiEkle.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnTedarikçiEkle.Location = new System.Drawing.Point(370, 7);
            this.btnTedarikçiEkle.Name = "btnTedarikçiEkle";
            this.btnTedarikçiEkle.Size = new System.Drawing.Size(114, 40);
            this.btnTedarikçiEkle.TabIndex = 5;
            this.btnTedarikçiEkle.Text = "Tedarikçi Ekle";
            this.btnTedarikçiEkle.UseVisualStyleBackColor = false;
            this.btnTedarikçiEkle.Click += new System.EventHandler(this.btnTedarikçiEkle_Click);
            // 
            // btnÜrünler
            // 
            this.btnÜrünler.BackColor = System.Drawing.Color.Lime;
            this.btnÜrünler.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnÜrünler.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnÜrünler.Location = new System.Drawing.Point(110, 54);
            this.btnÜrünler.Name = "btnÜrünler";
            this.btnÜrünler.Size = new System.Drawing.Size(114, 40);
            this.btnÜrünler.TabIndex = 3;
            this.btnÜrünler.Text = "Ürünler";
            this.btnÜrünler.UseVisualStyleBackColor = false;
            this.btnÜrünler.Click += new System.EventHandler(this.btnÜrünler_Click);
            // 
            // btnÜrünEkle
            // 
            this.btnÜrünEkle.BackColor = System.Drawing.Color.Yellow;
            this.btnÜrünEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnÜrünEkle.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnÜrünEkle.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnÜrünEkle.Location = new System.Drawing.Point(110, 7);
            this.btnÜrünEkle.Name = "btnÜrünEkle";
            this.btnÜrünEkle.Size = new System.Drawing.Size(114, 40);
            this.btnÜrünEkle.TabIndex = 2;
            this.btnÜrünEkle.Text = "Ürün Ekle";
            this.btnÜrünEkle.UseVisualStyleBackColor = false;
            this.btnÜrünEkle.Click += new System.EventHandler(this.btnÜrünEkle_Click);
            // 
            // btnMüşteriler
            // 
            this.btnMüşteriler.BackColor = System.Drawing.Color.Lime;
            this.btnMüşteriler.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMüşteriler.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnMüşteriler.Location = new System.Drawing.Point(239, 54);
            this.btnMüşteriler.Name = "btnMüşteriler";
            this.btnMüşteriler.Size = new System.Drawing.Size(114, 40);
            this.btnMüşteriler.TabIndex = 1;
            this.btnMüşteriler.Text = "Müşteriler";
            this.btnMüşteriler.UseVisualStyleBackColor = false;
            this.btnMüşteriler.Click += new System.EventHandler(this.btnMüşteriler_Click);
            // 
            // btnMüşteriEkleme
            // 
            this.btnMüşteriEkleme.BackColor = System.Drawing.Color.Yellow;
            this.btnMüşteriEkleme.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMüşteriEkleme.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnMüşteriEkleme.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnMüşteriEkleme.Location = new System.Drawing.Point(239, 7);
            this.btnMüşteriEkleme.Name = "btnMüşteriEkleme";
            this.btnMüşteriEkleme.Size = new System.Drawing.Size(114, 40);
            this.btnMüşteriEkleme.TabIndex = 0;
            this.btnMüşteriEkleme.Text = "Müşteri Ekle";
            this.btnMüşteriEkleme.UseVisualStyleBackColor = false;
            this.btnMüşteriEkleme.Click += new System.EventHandler(this.btnMüşteriEkleme_Click);
            // 
            // btnMagazaGiderleri
            // 
            this.btnMagazaGiderleri.BackColor = System.Drawing.Color.Fuchsia;
            this.btnMagazaGiderleri.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMagazaGiderleri.Location = new System.Drawing.Point(662, 201);
            this.btnMagazaGiderleri.Name = "btnMagazaGiderleri";
            this.btnMagazaGiderleri.Size = new System.Drawing.Size(66, 52);
            this.btnMagazaGiderleri.TabIndex = 10;
            this.btnMagazaGiderleri.Text = "Mağaza Giderleri";
            this.btnMagazaGiderleri.UseVisualStyleBackColor = false;
            this.btnMagazaGiderleri.Click += new System.EventHandler(this.btnMagazaGiderleri_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Fuchsia;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(659, 259);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(72, 74);
            this.button3.TabIndex = 11;
            this.button3.Text = "Mağaza Giderlerini Listele";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // frmSatis
            // 
            this.AcceptButton = this.btnEkle;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(740, 418);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnMagazaGiderleri);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblGenelToplam);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnSatışİptal);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnSatışYap);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "frmSatis";
            this.Text = "Magaza Uygulaması";
            this.Load += new System.EventHandler(this.frmSatis_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTelefon;
        private System.Windows.Forms.TextBox txtAdSoyad;
        private System.Windows.Forms.TextBox txtTc;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtToplamFiyatı;
        private System.Windows.Forms.TextBox txtSatışFiyatı;
        private System.Windows.Forms.TextBox txtMiktarı;
        private System.Windows.Forms.TextBox txtÜrünAdı;
        private System.Windows.Forms.TextBox txtBarkodNo;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Button btnSatışYap;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnSatışİptal;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblGenelToplam;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSatışListele;
        private System.Windows.Forms.Button btnTedarikçiler;
        private System.Windows.Forms.Button btnTedarikçiEkle;
        private System.Windows.Forms.Button btnÜrünler;
        private System.Windows.Forms.Button btnÜrünEkle;
        private System.Windows.Forms.Button btnMüşteriler;
        private System.Windows.Forms.Button btnMüşteriEkleme;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtStokAdet;
        private System.Windows.Forms.Button btnSiparişEt;
        private System.Windows.Forms.Button btnSiparişleriListele;
        private System.Windows.Forms.Button btnKar;
        private System.Windows.Forms.Button btnMagazaGiderleri;
        private System.Windows.Forms.Button button3;
    }
}

