
namespace magaza1
{
    partial class frmMagazaGiderleri
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnHesapla = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDigerGider = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtElektrikFatura = new System.Windows.Forms.TextBox();
            this.txtElemanMaas = new System.Windows.Forms.TextBox();
            this.txtElemanSayısı = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnHesapla);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtDigerGider);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.txtElektrikFatura);
            this.groupBox1.Controls.Add(this.txtElemanMaas);
            this.groupBox1.Controls.Add(this.txtElemanSayısı);
            this.groupBox1.Location = new System.Drawing.Point(22, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(311, 281);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Mağaza Giderleri";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btnHesapla
            // 
            this.btnHesapla.Location = new System.Drawing.Point(155, 179);
            this.btnHesapla.Name = "btnHesapla";
            this.btnHesapla.Size = new System.Drawing.Size(96, 26);
            this.btnHesapla.TabIndex = 21;
            this.btnHesapla.Text = "Ekle";
            this.btnHesapla.UseVisualStyleBackColor = true;
            this.btnHesapla.Click += new System.EventHandler(this.btnHesapla_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 15);
            this.label3.TabIndex = 19;
            this.label3.Text = "Diğer Giderleri Giriniz";
            // 
            // txtDigerGider
            // 
            this.txtDigerGider.Location = new System.Drawing.Point(152, 110);
            this.txtDigerGider.Name = "txtDigerGider";
            this.txtDigerGider.Size = new System.Drawing.Size(100, 23);
            this.txtDigerGider.TabIndex = 3;
            this.txtDigerGider.Text = "0";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 84);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(118, 15);
            this.label9.TabIndex = 18;
            this.label9.Text = "Aylık Elektrik Faturası";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(12, 56);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(126, 15);
            this.label11.TabIndex = 17;
            this.label11.Text = "Eleman Maaşını Giriniz";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(12, 26);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(124, 15);
            this.label12.TabIndex = 16;
            this.label12.Text = "Eleman Sayısını Giriniz";
            // 
            // txtElektrikFatura
            // 
            this.txtElektrikFatura.Location = new System.Drawing.Point(152, 82);
            this.txtElektrikFatura.Name = "txtElektrikFatura";
            this.txtElektrikFatura.Size = new System.Drawing.Size(100, 23);
            this.txtElektrikFatura.TabIndex = 0;
            this.txtElektrikFatura.Text = "0";
            // 
            // txtElemanMaas
            // 
            this.txtElemanMaas.Location = new System.Drawing.Point(152, 53);
            this.txtElemanMaas.Name = "txtElemanMaas";
            this.txtElemanMaas.Size = new System.Drawing.Size(100, 23);
            this.txtElemanMaas.TabIndex = 0;
            this.txtElemanMaas.Text = "0";
            // 
            // txtElemanSayısı
            // 
            this.txtElemanSayısı.Location = new System.Drawing.Point(152, 23);
            this.txtElemanSayısı.Name = "txtElemanSayısı";
            this.txtElemanSayısı.Size = new System.Drawing.Size(100, 23);
            this.txtElemanSayısı.TabIndex = 0;
            this.txtElemanSayısı.Text = "0";
            // 
            // frmMagazaGiderleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(458, 355);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmMagazaGiderleri";
            this.Text = "frmMagazaGiderleri";
            this.Load += new System.EventHandler(this.frmMagazaGiderleri_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDigerGider;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtElektrikFatura;
        private System.Windows.Forms.TextBox txtElemanMaas;
        private System.Windows.Forms.TextBox txtElemanSayısı;
        private System.Windows.Forms.Button btnHesapla;
    }
}