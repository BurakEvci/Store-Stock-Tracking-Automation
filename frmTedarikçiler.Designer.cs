
namespace magaza1
{
    partial class frmTedarikçiler
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
            this.btnSil = new System.Windows.Forms.Button();
            this.txtTedarikçiNoAra = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnGüncelle = new System.Windows.Forms.Button();
            this.txtTedarikçiTel = new System.Windows.Forms.TextBox();
            this.txtTedarikçiEmail = new System.Windows.Forms.TextBox();
            this.txtTedarikçiAdres = new System.Windows.Forms.TextBox();
            this.txtTedarikçiAdı = new System.Windows.Forms.TextBox();
            this.txtTedarikçiNo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(701, 74);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(48, 24);
            this.btnSil.TabIndex = 39;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // txtTedarikçiNoAra
            // 
            this.txtTedarikçiNoAra.Location = new System.Drawing.Point(550, 43);
            this.txtTedarikçiNoAra.Name = "txtTedarikçiNoAra";
            this.txtTedarikçiNoAra.Size = new System.Drawing.Size(100, 23);
            this.txtTedarikçiNoAra.TabIndex = 38;
            this.txtTedarikçiNoAra.TextChanged += new System.EventHandler(this.txtTedarikçiNoAra_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(451, 46);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 15);
            this.label6.TabIndex = 37;
            this.label6.Text = "Tedarikçi No Ara";
            // 
            // btnGüncelle
            // 
            this.btnGüncelle.Location = new System.Drawing.Point(142, 281);
            this.btnGüncelle.Name = "btnGüncelle";
            this.btnGüncelle.Size = new System.Drawing.Size(79, 25);
            this.btnGüncelle.TabIndex = 36;
            this.btnGüncelle.Text = "Güncelle";
            this.btnGüncelle.UseVisualStyleBackColor = true;
            this.btnGüncelle.Click += new System.EventHandler(this.btnGüncelle_Click);
            // 
            // txtTedarikçiTel
            // 
            this.txtTedarikçiTel.Location = new System.Drawing.Point(121, 162);
            this.txtTedarikçiTel.Name = "txtTedarikçiTel";
            this.txtTedarikçiTel.Size = new System.Drawing.Size(100, 23);
            this.txtTedarikçiTel.TabIndex = 33;
            // 
            // txtTedarikçiEmail
            // 
            this.txtTedarikçiEmail.Location = new System.Drawing.Point(121, 243);
            this.txtTedarikçiEmail.Name = "txtTedarikçiEmail";
            this.txtTedarikçiEmail.Size = new System.Drawing.Size(100, 23);
            this.txtTedarikçiEmail.TabIndex = 35;
            // 
            // txtTedarikçiAdres
            // 
            this.txtTedarikçiAdres.Location = new System.Drawing.Point(121, 201);
            this.txtTedarikçiAdres.Name = "txtTedarikçiAdres";
            this.txtTedarikçiAdres.Size = new System.Drawing.Size(100, 23);
            this.txtTedarikçiAdres.TabIndex = 34;
            // 
            // txtTedarikçiAdı
            // 
            this.txtTedarikçiAdı.Location = new System.Drawing.Point(121, 117);
            this.txtTedarikçiAdı.Name = "txtTedarikçiAdı";
            this.txtTedarikçiAdı.Size = new System.Drawing.Size(100, 23);
            this.txtTedarikçiAdı.TabIndex = 32;
            // 
            // txtTedarikçiNo
            // 
            this.txtTedarikçiNo.Location = new System.Drawing.Point(121, 75);
            this.txtTedarikçiNo.Name = "txtTedarikçiNo";
            this.txtTedarikçiNo.Size = new System.Drawing.Size(100, 23);
            this.txtTedarikçiNo.TabIndex = 31;
            this.txtTedarikçiNo.TextChanged += new System.EventHandler(this.txtTedarikçiNo_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 246);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 15);
            this.label5.TabIndex = 30;
            this.label5.Text = "Tedarikçi E-mail";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 204);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 15);
            this.label4.TabIndex = 29;
            this.label4.Text = "Tedarikçi Adresi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 15);
            this.label3.TabIndex = 28;
            this.label3.Text = "Tedarikçi Telefonu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 15);
            this.label2.TabIndex = 27;
            this.label2.Text = "Tedarikçi Adı";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 15);
            this.label1.TabIndex = 26;
            this.label1.Text = "Tedarikçi Numarası";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(227, 72);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(468, 243);
            this.dataGridView1.TabIndex = 25;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // frmTedarikçiler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(751, 370);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.txtTedarikçiNoAra);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnGüncelle);
            this.Controls.Add(this.txtTedarikçiTel);
            this.Controls.Add(this.txtTedarikçiEmail);
            this.Controls.Add(this.txtTedarikçiAdres);
            this.Controls.Add(this.txtTedarikçiAdı);
            this.Controls.Add(this.txtTedarikçiNo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "frmTedarikçiler";
            this.Text = "frmTedarikçiler";
            this.Load += new System.EventHandler(this.frmTedarikçiler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.TextBox txtTedarikçiNoAra;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnGüncelle;
        private System.Windows.Forms.TextBox txtTedarikçiTel;
        private System.Windows.Forms.TextBox txtTedarikçiEmail;
        private System.Windows.Forms.TextBox txtTedarikçiAdres;
        private System.Windows.Forms.TextBox txtTedarikçiAdı;
        private System.Windows.Forms.TextBox txtTedarikçiNo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}