
namespace magaza1
{
    partial class frmTedarikçiEkle
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTedarikçiAdı = new System.Windows.Forms.TextBox();
            this.txtTedarikçiAdres = new System.Windows.Forms.TextBox();
            this.txtTedarikçiEmail = new System.Windows.Forms.TextBox();
            this.txtTedarikçiTel = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txtTedarikçiNo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 15);
            this.label2.TabIndex = 12;
            this.label2.Text = "Tedarikçi Adı";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 15);
            this.label3.TabIndex = 13;
            this.label3.Text = "Tedarikçi Telefonu";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 15);
            this.label4.TabIndex = 14;
            this.label4.Text = "Tedarikçi Adresi";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(31, 171);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 15);
            this.label5.TabIndex = 15;
            this.label5.Text = "Tedarikçi E-mail";
            // 
            // txtTedarikçiAdı
            // 
            this.txtTedarikçiAdı.Location = new System.Drawing.Point(139, 54);
            this.txtTedarikçiAdı.Name = "txtTedarikçiAdı";
            this.txtTedarikçiAdı.Size = new System.Drawing.Size(100, 23);
            this.txtTedarikçiAdı.TabIndex = 17;
            // 
            // txtTedarikçiAdres
            // 
            this.txtTedarikçiAdres.Location = new System.Drawing.Point(139, 130);
            this.txtTedarikçiAdres.Name = "txtTedarikçiAdres";
            this.txtTedarikçiAdres.Size = new System.Drawing.Size(100, 23);
            this.txtTedarikçiAdres.TabIndex = 19;
            // 
            // txtTedarikçiEmail
            // 
            this.txtTedarikçiEmail.Location = new System.Drawing.Point(139, 168);
            this.txtTedarikçiEmail.Name = "txtTedarikçiEmail";
            this.txtTedarikçiEmail.Size = new System.Drawing.Size(100, 23);
            this.txtTedarikçiEmail.TabIndex = 20;
            // 
            // txtTedarikçiTel
            // 
            this.txtTedarikçiTel.Location = new System.Drawing.Point(139, 92);
            this.txtTedarikçiTel.Name = "txtTedarikçiTel";
            this.txtTedarikçiTel.Size = new System.Drawing.Size(100, 23);
            this.txtTedarikçiTel.TabIndex = 18;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(164, 209);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 21;
            this.button1.Text = "Ekle";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtTedarikçiNo
            // 
            this.txtTedarikçiNo.Location = new System.Drawing.Point(139, 15);
            this.txtTedarikçiNo.Name = "txtTedarikçiNo";
            this.txtTedarikçiNo.Size = new System.Drawing.Size(100, 23);
            this.txtTedarikçiNo.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 15);
            this.label1.TabIndex = 22;
            this.label1.Text = "Tedarikçi Numarası";
            // 
            // frmTedarikçiEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(328, 279);
            this.Controls.Add(this.txtTedarikçiNo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtTedarikçiTel);
            this.Controls.Add(this.txtTedarikçiEmail);
            this.Controls.Add(this.txtTedarikçiAdres);
            this.Controls.Add(this.txtTedarikçiAdı);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "frmTedarikçiEkle";
            this.Text = "frmTedarikçiEkle";
            this.Load += new System.EventHandler(this.frmTedarikçiEkle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTedarikçiAdı;
        private System.Windows.Forms.TextBox txtTedarikçiAdres;
        private System.Windows.Forms.TextBox txtTedarikçiEmail;
        private System.Windows.Forms.TextBox txtTedarikçiTel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtTedarikçiNo;
        private System.Windows.Forms.Label label1;
    }
}