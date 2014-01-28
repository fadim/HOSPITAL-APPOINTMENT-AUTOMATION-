namespace Hastane_Otomasyonu
{
    partial class frmKullanıcıEkle
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
            this.btnVERIGETIR = new System.Windows.Forms.Button();
            this.btnSIL = new System.Windows.Forms.Button();
            this.btnKAPAT = new System.Windows.Forms.Button();
            this.btnTEMIZLE = new System.Windows.Forms.Button();
            this.btnGUNCELLE = new System.Windows.Forms.Button();
            this.btnEKLE = new System.Windows.Forms.Button();
            this.txtSIFRE = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSIFRESI = new System.Windows.Forms.TextBox();
            this.txtKULLANICIADI = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnVERIGETIR);
            this.groupBox1.Controls.Add(this.btnSIL);
            this.groupBox1.Controls.Add(this.btnKAPAT);
            this.groupBox1.Controls.Add(this.btnTEMIZLE);
            this.groupBox1.Controls.Add(this.btnGUNCELLE);
            this.groupBox1.Controls.Add(this.btnEKLE);
            this.groupBox1.Controls.Add(this.txtSIFRE);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtSIFRESI);
            this.groupBox1.Controls.Add(this.txtKULLANICIADI);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(277, 201);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kullanıcı İşlemleri";
            // 
            // btnVERIGETIR
            // 
            this.btnVERIGETIR.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btnVERIGETIR.ForeColor = System.Drawing.Color.Black;
            this.btnVERIGETIR.Location = new System.Drawing.Point(241, 28);
            this.btnVERIGETIR.Name = "btnVERIGETIR";
            this.btnVERIGETIR.Size = new System.Drawing.Size(30, 23);
            this.btnVERIGETIR.TabIndex = 80;
            this.btnVERIGETIR.Text = ">>";
            this.btnVERIGETIR.UseVisualStyleBackColor = true;
            this.btnVERIGETIR.Click += new System.EventHandler(this.btnVERIGETIR_Click);
            // 
            // btnSIL
            // 
            this.btnSIL.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSIL.Enabled = false;
            this.btnSIL.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btnSIL.ForeColor = System.Drawing.Color.Black;
            this.btnSIL.Location = new System.Drawing.Point(170, 94);
            this.btnSIL.Name = "btnSIL";
            this.btnSIL.Size = new System.Drawing.Size(70, 43);
            this.btnSIL.TabIndex = 79;
            this.btnSIL.Text = "Sil";
            this.btnSIL.UseVisualStyleBackColor = true;
            this.btnSIL.Click += new System.EventHandler(this.btnSIL_Click);
            // 
            // btnKAPAT
            // 
            this.btnKAPAT.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnKAPAT.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKAPAT.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnKAPAT.Location = new System.Drawing.Point(134, 144);
            this.btnKAPAT.Name = "btnKAPAT";
            this.btnKAPAT.Size = new System.Drawing.Size(106, 36);
            this.btnKAPAT.TabIndex = 78;
            this.btnKAPAT.Text = "İptal";
            this.btnKAPAT.UseVisualStyleBackColor = true;
            this.btnKAPAT.Click += new System.EventHandler(this.btnKAPAT_Click);
            // 
            // btnTEMIZLE
            // 
            this.btnTEMIZLE.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTEMIZLE.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnTEMIZLE.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTEMIZLE.Location = new System.Drawing.Point(18, 144);
            this.btnTEMIZLE.Name = "btnTEMIZLE";
            this.btnTEMIZLE.Size = new System.Drawing.Size(106, 36);
            this.btnTEMIZLE.TabIndex = 77;
            this.btnTEMIZLE.Text = "Temizle";
            this.btnTEMIZLE.UseVisualStyleBackColor = true;
            this.btnTEMIZLE.Click += new System.EventHandler(this.btnTEMIZLE_Click);
            // 
            // btnGUNCELLE
            // 
            this.btnGUNCELLE.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGUNCELLE.Enabled = false;
            this.btnGUNCELLE.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btnGUNCELLE.ForeColor = System.Drawing.Color.Black;
            this.btnGUNCELLE.Location = new System.Drawing.Point(94, 94);
            this.btnGUNCELLE.Name = "btnGUNCELLE";
            this.btnGUNCELLE.Size = new System.Drawing.Size(70, 43);
            this.btnGUNCELLE.TabIndex = 76;
            this.btnGUNCELLE.Text = "Güncelle";
            this.btnGUNCELLE.UseVisualStyleBackColor = true;
            this.btnGUNCELLE.Click += new System.EventHandler(this.btnGUNCELLE_Click);
            // 
            // btnEKLE
            // 
            this.btnEKLE.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEKLE.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btnEKLE.ForeColor = System.Drawing.Color.Black;
            this.btnEKLE.Location = new System.Drawing.Point(18, 94);
            this.btnEKLE.Name = "btnEKLE";
            this.btnEKLE.Size = new System.Drawing.Size(70, 43);
            this.btnEKLE.TabIndex = 75;
            this.btnEKLE.Text = "Ekle";
            this.btnEKLE.UseVisualStyleBackColor = true;
            this.btnEKLE.Click += new System.EventHandler(this.btnEKLE_Click);
            // 
            // txtSIFRE
            // 
            this.txtSIFRE.AutoSize = true;
            this.txtSIFRE.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSIFRE.Location = new System.Drawing.Point(43, 57);
            this.txtSIFRE.Name = "txtSIFRE";
            this.txtSIFRE.Size = new System.Drawing.Size(53, 15);
            this.txtSIFRE.TabIndex = 62;
            this.txtSIFRE.Text = "Şifre      :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(15, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 15);
            this.label2.TabIndex = 61;
            this.label2.Text = "Kullanıcı Adı :";
            // 
            // txtSIFRESI
            // 
            this.txtSIFRESI.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.txtSIFRESI.Location = new System.Drawing.Point(99, 54);
            this.txtSIFRESI.Name = "txtSIFRESI";
            this.txtSIFRESI.Size = new System.Drawing.Size(142, 20);
            this.txtSIFRESI.TabIndex = 59;
            // 
            // txtKULLANICIADI
            // 
            this.txtKULLANICIADI.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.txtKULLANICIADI.Location = new System.Drawing.Point(99, 28);
            this.txtKULLANICIADI.Name = "txtKULLANICIADI";
            this.txtKULLANICIADI.Size = new System.Drawing.Size(142, 20);
            this.txtKULLANICIADI.TabIndex = 58;
            // 
            // frmKullanıcıEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(301, 227);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmKullanıcıEkle";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label txtSIFRE;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSIFRESI;
        private System.Windows.Forms.TextBox txtKULLANICIADI;
        private System.Windows.Forms.Button btnKAPAT;
        private System.Windows.Forms.Button btnTEMIZLE;
        public System.Windows.Forms.Button btnGUNCELLE;
        private System.Windows.Forms.Button btnEKLE;
        public System.Windows.Forms.Button btnSIL;
        private System.Windows.Forms.Button btnVERIGETIR;
    }
}