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
    public partial class frmDoktorEkle : Form
    {
        OleDbConnection baglan = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + Application.StartupPath.ToString() + "\\hastaneOtomasyonu.mdb");
        
        public frmDoktorEkle()
        {
            InitializeComponent();
        }

        public int pol_id;

        public void pol_oku()
        {
            cmbPOLIKLINIKLER.Items.Clear();
            if (baglan.State == ConnectionState.Closed) baglan.Open();
            OleDbCommand komut = new OleDbCommand("SELECT id,poliklinik_adi FROM poliklinikler", baglan);
            OleDbDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                pol_id = oku.GetInt32(0);
                cmbPOLIKLINIKLER.Items.Add(oku.GetString(1));

            }


            baglan.Close();

        }

        public int polnum;

        public void veri_oku()
        {
            try
            {

                if (baglan.State == ConnectionState.Closed) baglan.Open();
                OleDbCommand komut = new OleDbCommand("SELECT * FROM doktorlar WHERE drtckimlikno='" + txtTCKIMLIKNO.Text + "'", baglan);
                OleDbDataReader oku = komut.ExecuteReader();
                while (oku.Read())
                {
                    txtTCKIMLIKNO.Text = oku.GetString(1);
                    txtADI.Text = oku.GetString(2);
                    txtSOYADI.Text = oku.GetString(3);
                    cmbCINSIYET.Text = oku.GetString(4);
                    txtDOGUMYERI.Text = oku.GetString(5);
                    txtDOGUMTARIHI.Text = oku.GetString(6);
                    txtCEPTEL.Text = oku.GetString(7);
                    txtEVTEL.Text = oku.GetString(8);
                    txtEPOSTA.Text = oku.GetString(9);
                    polnum = oku.GetInt32(10);

                }

                baglan.Close();

                cmbPOLIKLINIKLER.SelectedIndex = polnum - 1;
            }

            catch
            {



            }

        }
        private void frmDoktorEkle_Load(object sender, EventArgs e)
        {
            pol_oku();
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
                    OleDbCommand ekle = new OleDbCommand("INSERT INTO doktorlar (drtckimlikno,adi,soyadi,cinsiyet,dyeri,dtarihi,ceptel,evtel,eposta,polid) VALUES ('" + txtTCKIMLIKNO.Text + "','" + txtADI.Text + "','" + txtSOYADI.Text + "','" + cmbCINSIYET.Text + "' , '" + txtDOGUMYERI.Text + "','" + txtDOGUMTARIHI.Text + "','" + txtCEPTEL.Text + "','" + txtEVTEL.Text + "','" + txtEPOSTA.Text + "', " + pol_id + ")", baglan);
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
            OleDbCommand guncelle = new OleDbCommand("UPDATE doktorlar SET drtckimlikno='" + txtTCKIMLIKNO.Text + "',adi='" + txtADI.Text + "',soyadi='" + txtSOYADI.Text + "',cinsiyet='" + cmbCINSIYET.Text + "',dyeri='" + txtDOGUMYERI.Text + "',dtarihi='" + txtDOGUMTARIHI.Text + "',ceptel='" + txtCEPTEL.Text + "',evtel='" + txtEVTEL.Text + "',eposta='" + txtEPOSTA.Text + "',polid=" + pol_id + " WHERE drtckimlikno='" + txtTCKIMLIKNO.Text + "'", baglan);
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
            OleDbCommand sil = new OleDbCommand("DELETE FROM doktorlar WHERE drtckimlikno ='" + txtTCKIMLIKNO.Text + "'", baglan);
            baglan.Open();
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
            txtCEPTEL.Text = "";
            txtEVTEL.Text = "";
            txtEPOSTA.Text = "";
            cmbCINSIYET.Text = "";
            cmbPOLIKLINIKLER.Text = "";
        }

        private void btnKAPAT_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public string doktor_tc;

        private void btnVERIGETIR_Click(object sender, EventArgs e)
        {
            if (baglan.State == ConnectionState.Closed) baglan.Open();
            OleDbCommand veri = new OleDbCommand("SELECT drtckimlikno FROM doktorlar WHERE drtckimlikno = '" + txtTCKIMLIKNO.Text + "'", baglan);
            OleDbDataReader oku = null;

            oku = veri.ExecuteReader();

            while (oku.Read())
            {

                doktor_tc = oku["drtckimlikno"].ToString();

            }
            oku.Close();
            baglan.Close();

            if (doktor_tc != txtTCKIMLIKNO.Text)
            {

                MessageBox.Show("Böyle bir Doktor Kaydı Yoktur.", "Hastane Otomasyonu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
