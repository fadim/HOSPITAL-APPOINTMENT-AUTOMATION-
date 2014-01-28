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
    public partial class frmHastaEkle : Form
    {
        OleDbConnection baglan = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + Application.StartupPath.ToString() + "\\hastaneOtomasyonu.mdb");
        
        public frmHastaEkle()
        {
            InitializeComponent();
        }

      
        public void veri_oku()
        {
          try
            {
                if (baglan.State == ConnectionState.Closed) baglan.Open();
                OleDbCommand komut = new OleDbCommand("SELECT * FROM hastalar WHERE tckimlikno='" + txtTCKIMLIKNO.Text + "'", baglan);
                OleDbDataReader oku = komut.ExecuteReader();
                while (oku.Read())
                {
                    txtTCKIMLIKNO.Text = oku.GetString(1);
                    txtADI.Text = oku.GetString(2);
                    txtSOYADI.Text = oku.GetString(3);
                    cmbCINSIYET.Text = oku.GetString(4);
                    txtDOGUMYERI.Text = oku.GetString(5);
                    txtDOGUMTARIHI.Text = oku.GetString(6);
                    txtBABAADI.Text = oku.GetString(7);
                    txtANNEADI.Text = oku.GetString(8);
                    txtCEPTEL.Text = oku.GetString(9);
                    txtEVTEL.Text = oku.GetString(10);
                    txtEPOSTA.Text = oku.GetString(11);
                 

                }

                baglan.Close();

            }

            catch
            {

            }

        }

        private void btnEKLE_Click(object sender, EventArgs e)
        {
            if (txtTCKIMLIKNO.TextLength < 11)
                MessageBox.Show("Lütfen Tc Kimlik Numarasını 11 haneli giriniz.");
            else
            {
                try
                {
                    if (baglan.State == ConnectionState.Closed) baglan.Open();

                    OleDbCommand ekle = new OleDbCommand("INSERT INTO hastalar (tckimlikno,adi,soyadi,cinsiyet,dyeri,dtarihi,babaadi,anneadi,ceptel,evtel,eposta) VALUES ('" + txtTCKIMLIKNO.Text + "','" + txtADI.Text + "','" + txtSOYADI.Text + "','" + cmbCINSIYET.Text + "' , '" + txtDOGUMYERI.Text + "','" + txtDOGUMTARIHI.Text + "','" + txtBABAADI.Text + "','" + txtANNEADI.Text + "','" + txtCEPTEL.Text + "','" + txtEVTEL.Text + "','" + txtEPOSTA.Text + "')", baglan);


                    ekle.ExecuteNonQuery();
                    MessageBox.Show("Kayıt Başarılı Bir Şekilde Eklendi", "Hastane Otomasyonu", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                    baglan.Close();
                }
                catch
                {

                    MessageBox.Show("Lütfen Bilgilerinizi Kontrol Ediniz.");

                }
            }
        }

        private void btnGUNCELLE_Click(object sender, EventArgs e)
        {
            OleDbCommand guncelle = new OleDbCommand("UPDATE hastalar SET tckimlikno='" + txtTCKIMLIKNO.Text + "',adi='" + txtADI.Text + "',soyadi='" + txtSOYADI.Text + "',cinsiyet='" + cmbCINSIYET.Text + "',dyeri='" + txtDOGUMYERI.Text + "',dtarihi='" + txtDOGUMTARIHI.Text + "',babaadi='" + txtBABAADI.Text + "',anneadi='" + txtANNEADI.Text + "',ceptel='" + txtCEPTEL.Text + "',evtel='" + txtEVTEL.Text + "', eposta= '" + txtEPOSTA.Text + "' WHERE tckimlikno='" + txtTCKIMLIKNO.Text + "'", baglan);
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
            OleDbCommand sil = new OleDbCommand("DELETE FROM hastalar WHERE tckimlikno ='" + txtTCKIMLIKNO.Text + "'", baglan);

            sil.ExecuteNonQuery();
            MessageBox.Show("Kayıt Başarılı Bir Şekilde Silindi", "Hastane Otomasyonu", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

            baglan.Close();
        }

        private void btnTEMIZLE_Click(object sender, EventArgs e)
        {
            txtTCKIMLIKNO.Text = "";
            txtADI.Text = "";
            txtSOYADI.Text = "";
            txtDOGUMYERI.Text = "";
            txtDOGUMTARIHI.Text = "";
            txtBABAADI.Text = "";
            txtANNEADI.Text = "";
            txtCEPTEL.Text = "";
            txtEVTEL.Text = "";
            txtEPOSTA.Text = "";
            cmbCINSIYET.Text = "";
        }

        private void btnKAPAT_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public string hasta_tc;
        private void btnVERIGETIR_Click(object sender, EventArgs e)
        {
            if (baglan.State == ConnectionState.Closed) baglan.Open();
            OleDbCommand veri = new OleDbCommand("SELECT tckimlikno FROM hastalar WHERE tckimlikno = '" + txtTCKIMLIKNO.Text + "'", baglan);
            OleDbDataReader oku = null;

            oku = veri.ExecuteReader();

            while (oku.Read())
            {

                hasta_tc = oku["tckimlikno"].ToString();

            }
            oku.Close();
            baglan.Close();

            if (hasta_tc != txtTCKIMLIKNO.Text)
            {

                MessageBox.Show("Böyle bir Hasta Kaydı Yoktur.", "Hastane Otomasyonu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
        }

    }
}
