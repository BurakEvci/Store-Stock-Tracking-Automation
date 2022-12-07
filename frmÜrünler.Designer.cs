
namespace magaza1
{
    partial class frmÜrünler
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.SatışFiyatıtxt = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnGüncelle = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.BarkodNotxt = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.AlışFiyatıtxt = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.Kategoritxt = new System.Windows.Forms.TextBox();
            this.Miktarıtxt = new System.Windows.Forms.TextBox();
            this.Markatxt = new System.Windows.Forms.TextBox();
            this.ÜrünAdıtxt = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnSil = new System.Windows.Forms.Button();
            this.txtBarkodNoAra = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboKategori = new System.Windows.Forms.ComboBox();
            this.comboMarka = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnMarkaGuncelle = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.BulunduguYertxt = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.comboYerAra = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(186, 41);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(456, 249);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // SatışFiyatıtxt
            // 
            this.SatışFiyatıtxt.Location = new System.Drawing.Point(80, 216);
            this.SatışFiyatıtxt.Name = "SatışFiyatıtxt";
            this.SatışFiyatıtxt.Size = new System.Drawing.Size(100, 23);
            this.SatışFiyatıtxt.TabIndex = 31;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(5, 217);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(62, 15);
            this.label14.TabIndex = 30;
            this.label14.Text = "Satış Fiyatı";
            this.label14.Click += new System.EventHandler(this.label14_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(10, 189);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(57, 15);
            this.label11.TabIndex = 29;
            this.label11.Text = "Alış Fiyatı";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 160);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 15);
            this.label6.TabIndex = 28;
            this.label6.Text = "Miktarı";
            // 
            // btnGüncelle
            // 
            this.btnGüncelle.Location = new System.Drawing.Point(105, 289);
            this.btnGüncelle.Name = "btnGüncelle";
            this.btnGüncelle.Size = new System.Drawing.Size(75, 36);
            this.btnGüncelle.TabIndex = 18;
            this.btnGüncelle.Text = "Güncelle";
            this.btnGüncelle.UseVisualStyleBackColor = true;
            this.btnGüncelle.Click += new System.EventHandler(this.btnGüncelle_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(10, 131);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 15);
            this.label7.TabIndex = 27;
            this.label7.Text = "Ürün Adı";
            // 
            // BarkodNotxt
            // 
            this.BarkodNotxt.Location = new System.Drawing.Point(80, 41);
            this.BarkodNotxt.Name = "BarkodNotxt";
            this.BarkodNotxt.Size = new System.Drawing.Size(100, 23);
            this.BarkodNotxt.TabIndex = 19;
            this.BarkodNotxt.TextChanged += new System.EventHandler(this.BarkodNotxt_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(10, 73);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(51, 15);
            this.label9.TabIndex = 26;
            this.label9.Text = "Kategori";
            // 
            // AlışFiyatıtxt
            // 
            this.AlışFiyatıtxt.Location = new System.Drawing.Point(80, 186);
            this.AlışFiyatıtxt.Name = "AlışFiyatıtxt";
            this.AlışFiyatıtxt.Size = new System.Drawing.Size(100, 23);
            this.AlışFiyatıtxt.TabIndex = 24;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(4, 44);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(63, 15);
            this.label10.TabIndex = 25;
            this.label10.Text = "Barkod No";
            // 
            // Kategoritxt
            // 
            this.Kategoritxt.Location = new System.Drawing.Point(80, 70);
            this.Kategoritxt.Name = "Kategoritxt";
            this.Kategoritxt.ReadOnly = true;
            this.Kategoritxt.Size = new System.Drawing.Size(100, 23);
            this.Kategoritxt.TabIndex = 20;
            // 
            // Miktarıtxt
            // 
            this.Miktarıtxt.Location = new System.Drawing.Point(80, 157);
            this.Miktarıtxt.Name = "Miktarıtxt";
            this.Miktarıtxt.Size = new System.Drawing.Size(100, 23);
            this.Miktarıtxt.TabIndex = 23;
            // 
            // Markatxt
            // 
            this.Markatxt.Location = new System.Drawing.Point(80, 99);
            this.Markatxt.Name = "Markatxt";
            this.Markatxt.ReadOnly = true;
            this.Markatxt.Size = new System.Drawing.Size(100, 23);
            this.Markatxt.TabIndex = 21;
            // 
            // ÜrünAdıtxt
            // 
            this.ÜrünAdıtxt.Location = new System.Drawing.Point(80, 128);
            this.ÜrünAdıtxt.Name = "ÜrünAdıtxt";
            this.ÜrünAdıtxt.Size = new System.Drawing.Size(100, 23);
            this.ÜrünAdıtxt.TabIndex = 22;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(10, 102);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 15);
            this.label8.TabIndex = 32;
            this.label8.Text = "Marka";
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(648, 40);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(68, 23);
            this.btnSil.TabIndex = 33;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // txtBarkodNoAra
            // 
            this.txtBarkodNoAra.Location = new System.Drawing.Point(512, 13);
            this.txtBarkodNoAra.Name = "txtBarkodNoAra";
            this.txtBarkodNoAra.Size = new System.Drawing.Size(100, 23);
            this.txtBarkodNoAra.TabIndex = 34;
            this.txtBarkodNoAra.TextChanged += new System.EventHandler(this.txtBarkodNoAra_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(382, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 15);
            this.label1.TabIndex = 35;
            this.label1.Text = "BarkodNo ya Göre Ara";
            // 
            // comboKategori
            // 
            this.comboKategori.FormattingEnabled = true;
            this.comboKategori.Location = new System.Drawing.Point(278, 297);
            this.comboKategori.Name = "comboKategori";
            this.comboKategori.Size = new System.Drawing.Size(121, 23);
            this.comboKategori.TabIndex = 36;
            this.comboKategori.SelectedIndexChanged += new System.EventHandler(this.comboKategori_SelectedIndexChanged);
            // 
            // comboMarka
            // 
            this.comboMarka.FormattingEnabled = true;
            this.comboMarka.Location = new System.Drawing.Point(278, 327);
            this.comboMarka.Name = "comboMarka";
            this.comboMarka.Size = new System.Drawing.Size(121, 23);
            this.comboMarka.TabIndex = 37;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(212, 329);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 15);
            this.label2.TabIndex = 39;
            this.label2.Text = "Marka";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(212, 300);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 15);
            this.label3.TabIndex = 38;
            this.label3.Text = "Kategori";
            // 
            // btnMarkaGuncelle
            // 
            this.btnMarkaGuncelle.Location = new System.Drawing.Point(416, 300);
            this.btnMarkaGuncelle.Name = "btnMarkaGuncelle";
            this.btnMarkaGuncelle.Size = new System.Drawing.Size(112, 44);
            this.btnMarkaGuncelle.TabIndex = 40;
            this.btnMarkaGuncelle.Text = "Kategori-Marka Güncelle";
            this.btnMarkaGuncelle.UseVisualStyleBackColor = true;
            this.btnMarkaGuncelle.Click += new System.EventHandler(this.btnMarkaGuncelle_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(2, 248);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 15);
            this.label4.TabIndex = 30;
            this.label4.Text = "Bulunduğu Yer";
            this.label4.Click += new System.EventHandler(this.label14_Click);
            // 
            // BulunduguYertxt
            // 
            this.BulunduguYertxt.FormattingEnabled = true;
            this.BulunduguYertxt.Location = new System.Drawing.Point(105, 245);
            this.BulunduguYertxt.Name = "BulunduguYertxt";
            this.BulunduguYertxt.Size = new System.Drawing.Size(74, 23);
            this.BulunduguYertxt.TabIndex = 41;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(210, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 15);
            this.label5.TabIndex = 43;
            this.label5.Text = "Yere Göre Ara";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // comboYerAra
            // 
            this.comboYerAra.FormattingEnabled = true;
            this.comboYerAra.Location = new System.Drawing.Point(294, 13);
            this.comboYerAra.Name = "comboYerAra";
            this.comboYerAra.Size = new System.Drawing.Size(80, 23);
            this.comboYerAra.TabIndex = 44;
            this.comboYerAra.SelectedIndexChanged += new System.EventHandler(this.comboYerAra_SelectedIndexChanged_1);
            // 
            // frmÜrünler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(728, 377);
            this.Controls.Add(this.comboYerAra);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.BulunduguYertxt);
            this.Controls.Add(this.btnMarkaGuncelle);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboMarka);
            this.Controls.Add(this.comboKategori);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBarkodNoAra);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.SatışFiyatıtxt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnGüncelle);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.BarkodNotxt);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.AlışFiyatıtxt);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.Kategoritxt);
            this.Controls.Add(this.Miktarıtxt);
            this.Controls.Add(this.Markatxt);
            this.Controls.Add(this.ÜrünAdıtxt);
            this.Controls.Add(this.dataGridView1);
            this.Name = "frmÜrünler";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ürünler";
            this.Load += new System.EventHandler(this.frmÜrünler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox SatışFiyatıtxt;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnGüncelle;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox BarkodNotxt;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox AlışFiyatıtxt;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox Kategoritxt;
        private System.Windows.Forms.TextBox Miktarıtxt;
        private System.Windows.Forms.TextBox Markatxt;
        private System.Windows.Forms.TextBox ÜrünAdıtxt;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.TextBox txtBarkodNoAra;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboKategori;
        private System.Windows.Forms.ComboBox comboMarka;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnMarkaGuncelle;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox BulunduguYertxt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboYerAra;
    }
}