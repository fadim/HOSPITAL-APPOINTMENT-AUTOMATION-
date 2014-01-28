using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Hastane_Otomasyonu
{
    public partial class frmKullanıcıEkle : Form
    {
        OleDbConnection baglan = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + Application.StartupPath.ToString() + "\\hastaneOtomasyonu.mdb");
        public frmKullanıcıEkle()
        {
            InitializeComponent();
        }

        public void veri_oku()
        {
            try
            {
                if (baglan.State == ConnectionState.Closed) baglan.Open();
                OleDbCommand komut = new OleDbCommand("SELECT * FROM kullanici WHERE kullanici_adi='" + txtKULLANICIADI.Text + "'", baglan);
                OleDbDataReader oku = komut.ExecuteReader(); //ileri doğru salt okuma yapan bir satır döndürür.
                while (oku.Read())
                {
                    txtKULLANICIADI.Text = oku.GetString(1);
                    txtSIFRESI.Text = oku.GetString(2);

                }

                baglan.Close();

            }

            catch
            {

            }

        }
        public string kullaniciAdi;
        private void btnVERIGETIR_Click(object sender, EventArgs e)
        {
            if (baglan.State == ConnectionState.Closed) baglan.Open();
            OleDbCommand veri = new OleDbCommand("SELECT kullanici_adi FROM kullanici WHERE kullanici_adi = '" + txtKULLANICIADI.Text + "'", baglan);
            OleDbDataReader oku = null;

            oku = veri.ExecuteReader();

            while (oku.Read())
            {

                kullaniciAdi = oku["kullanici_adi"].ToString();

            }
            oku.Close();
            baglan.Close();

            if (kullaniciAdi != txtKULLANICIADI.Text)
            {

                MessageBox.Show("Böyle bir Kullanıcı Yoktur.", "Hastane Otomasyonu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                btnEKLE.Enabled = true;
                btnGUNCELLE.Enabled = false;
                btnSIL.Enabled = false;

            }

            else
            {


                veri_oku();
                btnEKLE.Enabled = false;
                btnGUNCELLE.Enabled = true;
                btnSIL.Enabled = true;
            }

            kullaniciAdi = txtKULLANICIADI.Text.ToString();
        
        }

        private void btnEKLE_Click(object sender, EventArgs e)
        {
            try
            {
                if (baglan.State == ConnectionState.Closed) baglan.Open();
                OleDbCommand ekle = new OleDbCommand("INSERT INTO kullanici (kullanici_adi,sifresi) VALUES ('" + txtKULLANICIADI.Text + "','" + txtSIFRESI.Text +"')", baglan);
                ekle.ExecuteNonQuery();
                MessageBox.Show("Kayıt Başarılı Bir Şekilde Eklendi", "Hastane Otomasyonu", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                baglan.Close();
            }
            catch
            {

                MessageBox.Show("Lütfen Bilgilerinizi Kontrol Ediniz.");

            }
        }

        
        private void btnGUNCELLE_Click(object sender, EventArgs e)
        {
            
            OleDbCommand guncelle = new OleDbCommand("UPDATE kullanici SET kullanici_adi='" + txtKULLANICIADI.Text + "',sifresi='" + txtSIFRESI.Text + "' WHERE kullanici_adi='" + kullaniciAdi + "'", baglan);
            baglan.Open();
            guncelle.ExecuteNonQuery();
            MessageBox.Show("Kayıt Başarılı Bir Şekilde Güncellendi", "Hastane Otomasyonu", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

            baglan.Close();

            btnEKLE.Enabled = true;
            btnGUNCELLE.Enabled = false;
            btnSIL.Enabled = false;
        }

        private void btnSIL_Click(object sender, EventArgs e)
        {
            if (baglan.State == ConnectionState.Closed) baglan.Open();
            OleDbCommand sil = new OleDbCommand("DELETE FROM kullanici WHERE kullanici_adi ='" + txtKULLANICIADI.Text + "'", baglan);

            sil.ExecuteNonQuery();
            MessageBox.Show("Kayıt Başarılı Bir Şekilde Silindi", "Hastane Otomasyonu", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

            baglan.Close();
        }

        private void btnTEMIZLE_Click(object sender, EventArgs e)
        {
            txtKULLANICIADI.Text = "";
            txtSIFRESI.Text = "";
        }

        private void btnKAPAT_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
