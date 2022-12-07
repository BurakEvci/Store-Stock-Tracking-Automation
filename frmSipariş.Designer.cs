
namespace magaza1
{
    partial class frmSipariş
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
            this.txtTedarikçiNO = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSiparişBarkodNo = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSiparişAlışFiyatı = new System.Windows.Forms.TextBox();
            this.txtSiparişMiktarı = new System.Windows.Forms.TextBox();
            this.txtSiparişÜrünAdı = new System.Windows.Forms.TextBox();
            this.lblGenelToplam = new System.Windows.Forms.Label();
            this.btnSatınAl = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label91 = new System.Windows.Forms.Label();
            this.txtTedarikciAdı = new System.Windows.Forms.TextBox();
            this.label90 = new System.Windows.Forms.Label();
            this.txtTedarikciTelefonu = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtTedarikçiNO
            // 
            this.txtTedarikçiNO.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtTedarikçiNO.FormattingEnabled = true;
            this.txtTedarikçiNO.Location = new System.Drawing.Point(146, 32);
            this.txtTedarikçiNO.Name = "txtTedarikçiNO";
            this.txtTedarikçiNO.Size = new System.Drawing.Size(121, 23);
            this.txtTedarikçiNO.TabIndex = 0;
            this.txtTedarikçiNO.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tedarikçi No Seçiniz";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ürün Barkod Numarası";
            // 
            // txtSiparişBarkodNo
            // 
            this.txtSiparişBarkodNo.Location = new System.Drawing.Point(146, 120);
            this.txtSiparişBarkodNo.Name = "txtSiparişBarkodNo";
            this.txtSiparişBarkodNo.Size = new System.Drawing.Size(121, 23);
            this.txtSiparişBarkodNo.TabIndex = 3;
            this.txtSiparişBarkodNo.TextChanged += new System.EventHandler(this.txtSiparişBarkodNo_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 213);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 15);
            this.label7.TabIndex = 18;
            this.label7.Text = "Alış Fiyatı";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 183);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 15);
            this.label6.TabIndex = 17;
            this.label6.Text = "Miktarı";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 153);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 15);
            this.label5.TabIndex = 16;
            this.label5.Text = "Ürün Adı";
            // 
            // txtSiparişAlışFiyatı
            // 
            this.txtSiparişAlışFiyatı.Location = new System.Drawing.Point(146, 210);
            this.txtSiparişAlışFiyatı.Name = "txtSiparişAlışFiyatı";
            this.txtSiparişAlışFiyatı.ReadOnly = true;
            this.txtSiparişAlışFiyatı.Size = new System.Drawing.Size(121, 23);
            this.txtSiparişAlışFiyatı.TabIndex = 13;
            // 
            // txtSiparişMiktarı
            // 
            this.txtSiparişMiktarı.Location = new System.Drawing.Point(146, 180);
            this.txtSiparişMiktarı.Name = "txtSiparişMiktarı";
            this.txtSiparişMiktarı.Size = new System.Drawing.Size(121, 23);
            this.txtSiparişMiktarı.TabIndex = 12;
            this.txtSiparişMiktarı.Text = "1";
            this.txtSiparişMiktarı.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtSiparişÜrünAdı
            // 
            this.txtSiparişÜrünAdı.Location = new System.Drawing.Point(146, 150);
            this.txtSiparişÜrünAdı.Name = "txtSiparişÜrünAdı";
            this.txtSiparişÜrünAdı.ReadOnly = true;
            this.txtSiparişÜrünAdı.Size = new System.Drawing.Size(121, 23);
            this.txtSiparişÜrünAdı.TabIndex = 11;
            // 
            // lblGenelToplam
            // 
            this.lblGenelToplam.AutoSize = true;
            this.lblGenelToplam.Location = new System.Drawing.Point(187, 295);
            this.lblGenelToplam.Name = "lblGenelToplam";
            this.lblGenelToplam.Size = new System.Drawing.Size(0, 15);
            this.lblGenelToplam.TabIndex = 20;
            // 
            // btnSatınAl
            // 
            this.btnSatınAl.Location = new System.Drawing.Point(146, 269);
            this.btnSatınAl.Name = "btnSatınAl";
            this.btnSatınAl.Size = new System.Drawing.Size(121, 23);
            this.btnSatınAl.TabIndex = 21;
            this.btnSatınAl.Text = "Satın Al";
            this.btnSatınAl.UseVisualStyleBackColor = true;
            this.btnSatınAl.Click += new System.EventHandler(this.btnSatınAl_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label91);
            this.groupBox1.Controls.Add(this.txtTedarikciAdı);
            this.groupBox1.Controls.Add(this.label90);
            this.groupBox1.Controls.Add(this.txtTedarikciTelefonu);
            this.groupBox1.Controls.Add(this.txtTedarikçiNO);
            this.groupBox1.Controls.Add(this.btnSatınAl);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lblGenelToplam);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtSiparişBarkodNo);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtSiparişÜrünAdı);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtSiparişMiktarı);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtSiparişAlışFiyatı);
            this.groupBox1.Location = new System.Drawing.Point(28, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(286, 299);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sipariş Et";
            // 
            // label91
            // 
            this.label91.AutoSize = true;
            this.label91.Location = new System.Drawing.Point(8, 65);
            this.label91.Name = "label91";
            this.label91.Size = new System.Drawing.Size(74, 15);
            this.label91.TabIndex = 24;
            this.label91.Text = "Tedarikçi Adı";
            // 
            // txtTedarikciAdı
            // 
            this.txtTedarikciAdı.Location = new System.Drawing.Point(146, 62);
            this.txtTedarikciAdı.Name = "txtTedarikciAdı";
            this.txtTedarikciAdı.ReadOnly = true;
            this.txtTedarikciAdı.Size = new System.Drawing.Size(121, 23);
            this.txtTedarikciAdı.TabIndex = 25;
            // 
            // label90
            // 
            this.label90.AutoSize = true;
            this.label90.Location = new System.Drawing.Point(8, 94);
            this.label90.Name = "label90";
            this.label90.Size = new System.Drawing.Size(101, 15);
            this.label90.TabIndex = 22;
            this.label90.Text = "Tedarikçi Telefonu";
            // 
            // txtTedarikciTelefonu
            // 
            this.txtTedarikciTelefonu.Location = new System.Drawing.Point(146, 91);
            this.txtTedarikciTelefonu.Name = "txtTedarikciTelefonu";
            this.txtTedarikciTelefonu.ReadOnly = true;
            this.txtTedarikciTelefonu.Size = new System.Drawing.Size(121, 23);
            this.txtTedarikciTelefonu.TabIndex = 23;
            // 
            // frmSipariş
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(715, 357);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmSipariş";
            this.Text = "frmSipariş";
            this.Load += new System.EventHandler(this.frmSipariş_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox txtTedarikçiNO;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSiparişBarkodNo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSiparişAlışFiyatı;
        private System.Windows.Forms.TextBox txtSiparişMiktarı;
        private System.Windows.Forms.TextBox txtSiparişÜrünAdı;
        private System.Windows.Forms.Label lblGenelToplam;
        private System.Windows.Forms.Button btnSatınAl;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label91;
        private System.Windows.Forms.TextBox txtTedarikciAdı;
        private System.Windows.Forms.Label label90;
        private System.Windows.Forms.TextBox txtTedarikciTelefonu;
    }
}