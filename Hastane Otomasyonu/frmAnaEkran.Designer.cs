namespace Hastane_Otomasyonu
{
    partial class frmAnaEkran
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
            this.btnKullaniciEkle = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnHastaEkle = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnDoktorEkle = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnRandevuEkle = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnKullaniciEkle);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(173, 100);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kullanıcı İşlemleri";
            // 
            // btnKullaniciEkle
            // 
            this.btnKullaniciEkle.Location = new System.Drawing.Point(16, 36);
            this.btnKullaniciEkle.Name = "btnKullaniciEkle";
            this.btnKullaniciEkle.Size = new System.Drawing.Size(142, 23);
            this.btnKullaniciEkle.TabIndex = 0;
            this.btnKullaniciEkle.Text = "Kullanıcı Ekle/İptal";
            this.btnKullaniciEkle.UseVisualStyleBackColor = true;
            this.btnKullaniciEkle.Click += new System.EventHandler(this.btnKullaniciEkle_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnHastaEkle);
            this.groupBox2.Location = new System.Drawing.Point(12, 136);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(173, 104);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Hasta Kabul İşlemleri";
            // 
            // btnHastaEkle
            // 
            this.btnHastaEkle.Location = new System.Drawing.Point(16, 36);
            this.btnHastaEkle.Name = "btnHastaEkle";
            this.btnHastaEkle.Size = new System.Drawing.Size(142, 23);
            this.btnHastaEkle.TabIndex = 0;
            this.btnHastaEkle.Text = "Hasta Girişi";
            this.btnHastaEkle.UseVisualStyleBackColor = true;
            this.btnHastaEkle.Click += new System.EventHandler(this.btnHastaEkle_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnDoktorEkle);
            this.groupBox3.Location = new System.Drawing.Point(253, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(173, 100);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Doktor İşlemleri";
            // 
            // btnDoktorEkle
            // 
            this.btnDoktorEkle.Location = new System.Drawing.Point(16, 36);
            this.btnDoktorEkle.Name = "btnDoktorEkle";
            this.btnDoktorEkle.Size = new System.Drawing.Size(142, 23);
            this.btnDoktorEkle.TabIndex = 0;
            this.btnDoktorEkle.Text = "Doktor Ekle";
            this.btnDoktorEkle.UseVisualStyleBackColor = true;
            this.btnDoktorEkle.Click += new System.EventHandler(this.btnDoktorEkle_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.button1);
            this.groupBox4.Controls.Add(this.btnRandevuEkle);
            this.groupBox4.Location = new System.Drawing.Point(253, 136);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(173, 104);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Randevu İşlemleri";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(16, 65);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(142, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Alınan Randevular";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnRandevuEkle
            // 
            this.btnRandevuEkle.Location = new System.Drawing.Point(16, 36);
            this.btnRandevuEkle.Name = "btnRandevuEkle";
            this.btnRandevuEkle.Size = new System.Drawing.Size(142, 23);
            this.btnRandevuEkle.TabIndex = 0;
            this.btnRandevuEkle.Text = "Randevu Ekle";
            this.btnRandevuEkle.UseVisualStyleBackColor = true;
            this.btnRandevuEkle.Click += new System.EventHandler(this.btnRandevuEkle_Click);
            // 
            // frmAnaEkran
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 259);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmAnaEkran";
            this.Text = "Hastane Otomasyonu";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnKullaniciEkle;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnHastaEkle;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnDoktorEkle;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnRandevuEkle;
        private System.Windows.Forms.Button button1;
    }
}

