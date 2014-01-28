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
    public partial class frmRandevu : Form
    {
        OleDbConnection baglan = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + Application.StartupPath.ToString() + "\\hastaneOtomasyonu.mdb");
        OleDbDataAdapter adapter = new OleDbDataAdapter();
        DataSet ds = new DataSet();
        
        public frmRandevu()
        {
            InitializeComponent();
        }

        public int pol_id;
        public int dr_id;

        public void pol_oku()
        {
            cmbPOLIKLINIKLER.Items.Clear();
            if (baglan.State == ConnectionState.Closed) baglan.Open();
            OleDbCommand komut = new OleDbCommand("SELECT id,poliklinik_adi FROM poliklinikler", baglan);
            OleDbDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                cmbPOLIKLINIKLER.Items.Add(oku.GetString(1));

                pol_id = oku.GetInt32(0);



            }


            baglan.Close();



        }

        public void bosRandevuSaati_oku()
        {
            try
            {
                if (baglan.State == ConnectionState.Closed) baglan.Open();
                OleDbCommand komut = new OleDbCommand("SELECT saat FROM randevu WHERE dr_id=" + dr_id + " and tarih='" + dtpRANDEVUTARIHI.Text + "'", baglan);
                OleDbDataReader oku = null;
                oku = komut.ExecuteReader();
                liste.Items.Clear();

                while (oku.Read())
                {
                    liste.Items.Add(oku.GetString(0).ToString());
                }
                oku.Close();
                baglan.Close();
            }
            catch
            {

            }
        }

        public void listele()
        {
            try
            {

                button1.Enabled = true; button2.Enabled = true; button3.Enabled = true; button4.Enabled = true; button5.Enabled = true;
                button6.Enabled = true; button7.Enabled = true; button8.Enabled = true; button9.Enabled = true; button10.Enabled = true;
                button11.Enabled = true; button12.Enabled = true; button13.Enabled = true; button14.Enabled = true; button15.Enabled = true; 
                button16.Enabled = true; button17.Enabled = true; button18.Enabled = true; button19.Enabled = true; button21.Enabled = true; 
                button22.Enabled = true; button23.Enabled = true; button24.Enabled = true; button25.Enabled = true; button26.Enabled = true; 
                button27.Enabled = true; button28.Enabled = true; button29.Enabled = true; button30.Enabled = true; button31.Enabled = true; 
                button32.Enabled = true; button33.Enabled = true; button34.Enabled = true; button35.Enabled = true; button36.Enabled = true; 
                button37.Enabled = true; button38.Enabled = true; button39.Enabled = true;



                button1.BackColor = Color.LimeGreen; button2.BackColor = Color.LimeGreen; button3.BackColor = Color.LimeGreen; button4.BackColor = Color.LimeGreen;
                button5.BackColor = Color.LimeGreen; button6.BackColor = Color.LimeGreen; button7.BackColor = Color.LimeGreen; button8.BackColor = Color.LimeGreen; 
                button9.BackColor = Color.LimeGreen; button10.BackColor = Color.LimeGreen; button11.BackColor = Color.LimeGreen; button12.BackColor = Color.LimeGreen; 
                button13.BackColor = Color.LimeGreen; button14.BackColor = Color.LimeGreen; button15.BackColor = Color.LimeGreen; button16.BackColor = Color.LimeGreen; 
                button17.BackColor = Color.LimeGreen; button18.BackColor = Color.LimeGreen; button19.BackColor = Color.LimeGreen; button20.BackColor = Color.LimeGreen;
                button21.BackColor = Color.LimeGreen; button22.BackColor = Color.LimeGreen; button23.BackColor = Color.LimeGreen; button24.BackColor = Color.LimeGreen; 
                button25.BackColor = Color.LimeGreen; button26.BackColor = Color.LimeGreen; button27.BackColor = Color.LimeGreen; button28.BackColor = Color.LimeGreen;
                button29.BackColor = Color.LimeGreen; button30.BackColor = Color.LimeGreen; button31.BackColor = Color.LimeGreen; button32.BackColor = Color.LimeGreen; 
                button33.BackColor = Color.LimeGreen; button34.BackColor = Color.LimeGreen; button35.BackColor = Color.LimeGreen; button36.BackColor = Color.LimeGreen;
                button37.BackColor = Color.LimeGreen; button38.BackColor = Color.LimeGreen; button39.BackColor = Color.LimeGreen;


                liste.Items.Clear();
                bosRandevuSaati_oku();
                int sayac = liste.Items.Count;
                string deger = null;
                for (int i = 0; i < sayac; i++)
                {

                    if (liste.Items[i].ToString() == button1.Text)
                    {
                        deger = liste.Items[i].ToString();
                        button1.BackColor = Color.DimGray;
                        button1.Enabled = false;

                    }

                    else if (liste.Items[i].ToString() == button2.Text)
                    {
                        deger = liste.Items[i].ToString();
                        button2.BackColor = Color.DimGray;
                        button2.Enabled = false;

                    }

                    else if (liste.Items[i].ToString() == button3.Text)
                    {
                        deger = liste.Items[i].ToString();
                        button3.BackColor = Color.DimGray;
                        button3.Enabled = false;

                    }
                    else if (liste.Items[i].ToString() == button4.Text)
                    {
                        deger = liste.Items[i].ToString();
                        button4.BackColor = Color.DimGray;
                        button4.Enabled = false;

                    }
                    else if (liste.Items[i].ToString() == button5.Text)
                    {
                        deger = liste.Items[i].ToString();
                        button5.BackColor = Color.DimGray;
                        button5.Enabled = false;
                    }
                    else if (liste.Items[i].ToString() == button6.Text)
                    {
                        deger = liste.Items[i].ToString();
                        button6.BackColor = Color.DimGray;
                        button6.Enabled = false;

                    }
                    else if (liste.Items[i].ToString() == button7.Text)
                    {
                        deger = liste.Items[i].ToString();
                        button7.BackColor = Color.DimGray;
                        button7.Enabled = false;

                    }
                    else if (liste.Items[i].ToString() == button8.Text)
                    {
                        deger = liste.Items[i].ToString();
                        button8.BackColor = Color.DimGray;
                        button8.Enabled = false;
                    }
                    else if (liste.Items[i].ToString() == button9.Text)
                    {
                        deger = liste.Items[i].ToString();
                        button9.BackColor = Color.DimGray;
                        button9.Enabled = false;

                    }
                    else if (liste.Items[i].ToString() == button10.Text)
                    {
                        deger = liste.Items[i].ToString();
                        button10.BackColor = Color.DimGray;
                        button10.Enabled = false;

                    }
                    else if (liste.Items[i].ToString() == button11.Text)
                    {
                        deger = liste.Items[i].ToString();
                        button11.BackColor = Color.DimGray;
                        button11.Enabled = false;

                    }
                    else if (liste.Items[i].ToString() == button12.Text)
                    {
                        deger = liste.Items[i].ToString();
                        button12.BackColor = Color.DimGray;
                        button12.Enabled = false;

                    }
                    else if (liste.Items[i].ToString() == button13.Text)
                    {
                        deger = liste.Items[i].ToString();
                        button13.BackColor = Color.DimGray;
                        button13.Enabled = false;

                    }
                    else if (liste.Items[i].ToString() == button14.Text)
                    {
                        deger = liste.Items[i].ToString();
                        button14.BackColor = Color.DimGray;
                        button14.Enabled = false;

                    }
                    else if (liste.Items[i].ToString() == button15.Text)
                    {
                        deger = liste.Items[i].ToString();
                        button15.BackColor = Color.DimGray;
                        button15.Enabled = false;

                    }
                    else if (liste.Items[i].ToString() == button16.Text)
                    {
                        deger = liste.Items[i].ToString();
                        button16.BackColor = Color.DimGray;
                        button16.Enabled = false;


                    }
                    else if (liste.Items[i].ToString() == button17.Text)
                    {
                        deger = liste.Items[i].ToString();
                        button17.BackColor = Color.DimGray;
                        button17.Enabled = false;

                    }
                    else if (liste.Items[i].ToString() == button18.Text)
                    {
                        deger = liste.Items[i].ToString();
                        button18.BackColor = Color.DimGray;
                        button18.Enabled = false;

                    }
                    else if (liste.Items[i].ToString() == button19.Text)
                    {
                        deger = liste.Items[i].ToString();
                        button19.BackColor = Color.DimGray;
                        button19.Enabled = false;

                    }
                    else if (liste.Items[i].ToString() == button20.Text)
                    {
                        deger = liste.Items[i].ToString();
                        button20.BackColor = Color.DimGray;
                        button20.Enabled = false;

                    }
                    else if (liste.Items[i].ToString() == button21.Text)
                    {
                        deger = liste.Items[i].ToString();
                        button21.BackColor = Color.DimGray;
                        button21.Enabled = false;

                    }
                    else if (liste.Items[i].ToString() == button22.Text)
                    {
                        deger = liste.Items[i].ToString();
                        button22.BackColor = Color.DimGray;
                        button22.Enabled = false;

                    }
                    else if (liste.Items[i].ToString() == button23.Text)
                    {
                        deger = liste.Items[i].ToString();
                        button23.BackColor = Color.DimGray;
                        button23.Enabled = false;

                    }
                    else if (liste.Items[i].ToString() == button24.Text)
                    {
                        deger = liste.Items[i].ToString();
                        button24.BackColor = Color.DimGray;
                        button24.Enabled = false;

                    }
                    else if (liste.Items[i].ToString() == button25.Text)
                    {
                        deger = liste.Items[i].ToString();
                        button25.BackColor = Color.DimGray;
                        button25.Enabled = false;

                    }
                    else if (liste.Items[i].ToString() == button26.Text)
                    {
                        deger = liste.Items[i].ToString();
                        button26.BackColor = Color.DimGray;
                        button26.Enabled = false;

                    }
                    else if (liste.Items[i].ToString() == button27.Text)
                    {
                        deger = liste.Items[i].ToString();
                        button27.BackColor = Color.DimGray;
                        button27.Enabled = false;

                    }
                    else if (liste.Items[i].ToString() == button28.Text)
                    {
                        deger = liste.Items[i].ToString();
                        button28.BackColor = Color.DimGray;
                        button28.Enabled = false;

                    }
                    else if (liste.Items[i].ToString() == button29.Text)
                    {
                        deger = liste.Items[i].ToString();
                        button29.BackColor = Color.DimGray;
                        button29.Enabled = false;

                    }
                    else if (liste.Items[i].ToString() == button30.Text)
                    {
                        deger = liste.Items[i].ToString();
                        button30.BackColor = Color.DimGray;
                        button30.Enabled = false;

                    }
                    else if (liste.Items[i].ToString() == button31.Text)
                    {
                        deger = liste.Items[i].ToString();
                        button31.BackColor = Color.DimGray;
                        button31.Enabled = false;

                    }
                    else if (liste.Items[i].ToString() == button32.Text)
                    {
                        deger = liste.Items[i].ToString();
                        button32.BackColor = Color.DimGray;
                        button32.Enabled = false;

                    }
                    else if (liste.Items[i].ToString() == button33.Text)
                    {
                        deger = liste.Items[i].ToString();
                        button33.BackColor = Color.DimGray;
                        button33.Enabled = false;

                    }
                    else if (liste.Items[i].ToString() == button34.Text)
                    {
                        deger = liste.Items[i].ToString();
                        button34.BackColor = Color.DimGray;
                        button34.Enabled = false;

                    }
                    else if (liste.Items[i].ToString() == button35.Text)
                    {
                        deger = liste.Items[i].ToString();
                        button35.BackColor = Color.DimGray;
                        button35.Enabled = false;
                    }
                    else if (liste.Items[i].ToString() == button36.Text)
                    {
                        deger = liste.Items[i].ToString();
                        button36.BackColor = Color.DimGray;
                        button36.Enabled = false;

                    }
                    else if (liste.Items[i].ToString() == button37.Text)
                    {
                        deger = liste.Items[i].ToString();
                        button37.BackColor = Color.DimGray;
                        button37.Enabled = false;

                    }
                    else if (liste.Items[i].ToString() == button38.Text)
                    {
                        deger = liste.Items[i].ToString();
                        button38.BackColor = Color.DimGray;
                        button38.Enabled = false;

                    }
                    else if (liste.Items[i].ToString() == button39.Text)
                    {
                        deger = liste.Items[i].ToString();
                        button39.BackColor = Color.DimGray;
                        button39.Enabled = false;

                    }
                }

                bosRandevuSaati_oku();
            }
            catch
            {


            }
        }

        public void randevu_oku()
        {
            string tarih;
            tarih = DateTime.Now.ToShortDateString();
            
            if (baglan.State == ConnectionState.Closed) baglan.Open();
            ds.Clear();
            adapter = new OleDbDataAdapter("SELECT randevu.id,poliklinikler.poliklinik_adi,randevu.hasta_tc,hastalar.adi,hastalar.soyadi,doktorlar.adi,doktorlar.soyadi,randevu.tarih,randevu.saat FROM hastalar,doktorlar,poliklinikler,randevu WHERE hastalar.tckimlikno=randevu.hasta_tc AND doktorlar.id=randevu.dr_id AND poliklinikler.id=randevu.pol_id AND randevu.tarih >= '" + tarih + "'", baglan);
            adapter.Fill(ds, "hastalar,doktorlar,poliklinikler,randevu");
            dgvAlinanRandevu.DataSource = ds.Tables["hastalar,doktorlar,poliklinikler,randevu"];
            baglan.Close();

            dgvAlinanRandevu.Columns[0].Visible = false;
            dgvAlinanRandevu.Columns[1].HeaderText = "Poliklinik Adı";
            dgvAlinanRandevu.Columns[2].HeaderText = "Tc Kimlik No";
            dgvAlinanRandevu.Columns[3].HeaderText = "Hasta Adı";
            dgvAlinanRandevu.Columns[4].HeaderText = "Hasta Soyadı";
            dgvAlinanRandevu.Columns[5].HeaderText = "Doktor Adı";
            dgvAlinanRandevu.Columns[6].HeaderText = "Doktor Soyadı";
            dgvAlinanRandevu.Columns[7].HeaderText = "Tarih";
            dgvAlinanRandevu.Columns[8].HeaderText = "Saat";

            dgvAlinanRandevu.Columns[1].Width = 130;
            dgvAlinanRandevu.Columns[2].Width = 110;
            dgvAlinanRandevu.Columns[3].Width = 100;
            dgvAlinanRandevu.Columns[4].Width = 110;
            dgvAlinanRandevu.Columns[5].Width = 100;
            dgvAlinanRandevu.Columns[6].Width = 120;
            dgvAlinanRandevu.Columns[7].Width = 100;
            dgvAlinanRandevu.Columns[8].Width = 75;
            

        }

        private void frmRandevu_Load(object sender, EventArgs e)
        {
            pol_oku();
            randevu_oku();
        }

        private void cmbPOLIKLINIKLER_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (baglan.State == ConnectionState.Closed) baglan.Open();
            OleDbCommand komut = new OleDbCommand("SELECT id FROM poliklinikler WHERE poliklinik_adi = '" + cmbPOLIKLINIKLER.Text + "'", baglan);
            OleDbDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {

                pol_id = oku.GetInt32(0);

            }


            baglan.Close();

           

            if (baglan.State == ConnectionState.Closed) baglan.Open();
            OleDbCommand komut2 = new OleDbCommand("SELECT adi,soyadi,id FROM doktorlar WHERE polid = " + pol_id + "", baglan);
            OleDbDataReader oku2 = komut2.ExecuteReader();
            cmbDOKTOR.Items.Clear();

            while (oku2.Read())
            {

                cmbDOKTOR.Items.Add(oku2.GetString(0) + " " + oku2.GetString(1));

            }


            baglan.Close();

        }

        private void cmbDOKTOR_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (baglan.State == ConnectionState.Closed) baglan.Open();
            OleDbCommand komut = new OleDbCommand("SELECT id FROM doktorlar WHERE adi + ' '  + soyadi  = '" + cmbDOKTOR.Text + "'", baglan);
            OleDbDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {

                dr_id = oku.GetInt32(0);

            }


            baglan.Close();
            listele();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtRANDEVUSAATI.Text = button1.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtRANDEVUSAATI.Text = button2.Text;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            txtRANDEVUSAATI.Text = button3.Text;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            txtRANDEVUSAATI.Text = button4.Text;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            txtRANDEVUSAATI.Text = button5.Text;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            txtRANDEVUSAATI.Text = button6.Text;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            txtRANDEVUSAATI.Text = button7.Text;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            txtRANDEVUSAATI.Text = button8.Text;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            txtRANDEVUSAATI.Text = button9.Text;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            txtRANDEVUSAATI.Text = button10.Text;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            txtRANDEVUSAATI.Text = button11.Text;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            txtRANDEVUSAATI.Text = button12.Text;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            txtRANDEVUSAATI.Text = button13.Text;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            txtRANDEVUSAATI.Text = button14.Text;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            txtRANDEVUSAATI.Text = button15.Text;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            txtRANDEVUSAATI.Text = button16.Text;
        }

        private void button17_Click(object sender, EventArgs e)
        {
            txtRANDEVUSAATI.Text = button17.Text;
        }

        private void button18_Click(object sender, EventArgs e)
        {
            txtRANDEVUSAATI.Text = button18.Text;
        }

        private void button19_Click(object sender, EventArgs e)
        {
            txtRANDEVUSAATI.Text = button19.Text;
        }

        private void button20_Click(object sender, EventArgs e)
        {
            txtRANDEVUSAATI.Text = button20.Text;
        }

        private void button21_Click(object sender, EventArgs e)
        {
            txtRANDEVUSAATI.Text = button21.Text;
        }

        private void button22_Click(object sender, EventArgs e)
        {
            txtRANDEVUSAATI.Text = button22.Text;
        }

        private void button23_Click(object sender, EventArgs e)
        {
            txtRANDEVUSAATI.Text = button23.Text;
        }

        private void button24_Click(object sender, EventArgs e)
        {
            txtRANDEVUSAATI.Text = button24.Text;
        }

        private void button25_Click(object sender, EventArgs e)
        {
            txtRANDEVUSAATI.Text = button25.Text;
        }

        private void button26_Click(object sender, EventArgs e)
        {
            txtRANDEVUSAATI.Text = button26.Text;
        }

        private void button27_Click(object sender, EventArgs e)
        {
            txtRANDEVUSAATI.Text = button27.Text;
        }

        private void button28_Click(object sender, EventArgs e)
        {
            txtRANDEVUSAATI.Text = button28.Text;
        }

        private void button29_Click(object sender, EventArgs e)
        {
            txtRANDEVUSAATI.Text = button29.Text;
        }

        private void button30_Click(object sender, EventArgs e)
        {
            txtRANDEVUSAATI.Text = button30.Text;
        }

        private void button31_Click(object sender, EventArgs e)
        {
            txtRANDEVUSAATI.Text = button31.Text;
        }

        private void button32_Click(object sender, EventArgs e)
        {
            txtRANDEVUSAATI.Text = button32.Text;
        }

        private void button33_Click(object sender, EventArgs e)
        {
            txtRANDEVUSAATI.Text = button33.Text;
        }

        private void button34_Click(object sender, EventArgs e)
        {
            txtRANDEVUSAATI.Text = button34.Text;
        }

        private void button35_Click(object sender, EventArgs e)
        {
            txtRANDEVUSAATI.Text = button35.Text;
        }

        private void button36_Click(object sender, EventArgs e)
        {
            txtRANDEVUSAATI.Text = button36.Text;
        }

        private void button37_Click(object sender, EventArgs e)
        {
            txtRANDEVUSAATI.Text = button37.Text;
        }

        private void button38_Click(object sender, EventArgs e)
        {
            txtRANDEVUSAATI.Text = button38.Text;
        }

        private void button39_Click(object sender, EventArgs e)
        {
            txtRANDEVUSAATI.Text = button39.Text;
        }

        private void btnTEMIZLE_Click(object sender, EventArgs e)
        {
            cmbPOLIKLINIKLER.Text = "";
            cmbDOKTOR.Text = "";
            txtTCKIMLIKNO.Text = "";
            txtRANDEVUSAATI.Text = "";

        }

        public string deger;
        private void btnKAYDET_Click(object sender, EventArgs e)
        {
            if ((txtTCKIMLIKNO.Text == "") || (txtRANDEVUSAATI.Text == ""))
            {
                MessageBox.Show("Lütfen Boş Alanları Doldurunuz.", "Hastane Otomasyonu", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else
            {
                DateTime geciciTarih = Convert.ToDateTime(dtpRANDEVUTARIHI.Text);

                string gun = string.Empty;

                gun = geciciTarih.ToString("dddd");
                if (gun != "Cumartesi" && gun != "Pazar")
                {
                    listele();



                    string hasta_tc;

                    if (baglan.State == ConnectionState.Closed) baglan.Open();
                    OleDbCommand veri = new OleDbCommand("SELECT tckimlikno FROM hastalar WHERE tckimlikno = '" + txtTCKIMLIKNO.Text + "'", baglan);

                    hasta_tc = veri.ExecuteScalar().ToString();

                    baglan.Close();

                    if (hasta_tc != txtTCKIMLIKNO.Text)
                    {

                        MessageBox.Show("Bu Tc Kimlik Numarasına Sahip Hasta Kaydı Yoktur.");

                    }

                    else
                    {

                        if (baglan.State == ConnectionState.Closed) baglan.Open();
                        OleDbCommand veri2 = new OleDbCommand("SELECT pol_id FROM randevu WHERE hasta_tc = '" + txtTCKIMLIKNO.Text + "'", baglan);

                        OleDbDataReader oku2 = null;
                        oku2 = veri2.ExecuteReader();
                        listBox1.Items.Clear();
                        while (oku2.Read())
                        {
                            listBox1.Items.Add(oku2.GetInt32(0));
                        }
                        oku2.Close();
                        baglan.Close();



                        bosRandevuSaati_oku();
                        int sayac = listBox1.Items.Count;

                        for (int i = 0; i < sayac; i++)
                        {

                            if (listBox1.Items[i].ToString() == pol_id.ToString())
                            {
                                deger = listBox1.Items[i].ToString();

                            }

                        }

                        if (deger == pol_id.ToString() && geciciTarih == DateTime.Now)
                        {
                            
                                MessageBox.Show("Bu Hastanın Kaydı Bu Tarihte Bu Polikliniğe Zaten Yapılmıştır.");
                                this.Close();

                                listBox1.Items.Clear();
                                  

                        }
                   
                   
                        else
                        {
                     
                            if (baglan.State == ConnectionState.Closed) baglan.Open();
                            OleDbCommand kaydet = new OleDbCommand("INSERT INTO randevu (dr_id,tarih,hasta_tc,saat,pol_id) VALUES (" + dr_id + ",'" + dtpRANDEVUTARIHI.Text + "','" + txtTCKIMLIKNO.Text + "','" + txtRANDEVUSAATI.Text + "', '" + pol_id + "')", baglan);
                            kaydet.ExecuteNonQuery();
                            MessageBox.Show("Randevu Başarılı Bir Şekilde Eklenmiştir", "Hastane Otomasyonu", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                            baglan.Close();
                            bosRandevuSaati_oku(); 
                            listele();

                        }




                    }

                }
                else
                {
                    MessageBox.Show("Cumartesi veya Pazar Günü Randevu Alamazsınız.");

                }

                bosRandevuSaati_oku();
            }

        }

        private void btnIPTAL_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public int gelen_id;
        private void btnRANDEVUSIL_Click(object sender, EventArgs e)
        {
            try
            {
                gelen_id = Convert.ToInt32(dgvAlinanRandevu.SelectedRows[0].Cells[0].Value);
                OleDbCommand sil = new OleDbCommand("DELETE from randevu where id =" + gelen_id + "", baglan);
                baglan.Open();
                sil.ExecuteNonQuery();
                MessageBox.Show("Randevu Silinmiştir.", "Hastane Otomasyonu", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                randevu_oku();
                baglan.Close();
            }
            catch
            {
                MessageBox.Show("Lütfen Silmek İstediğiniz Randevuyu Seçiniz.", "Hastane Otomasyonu", MessageBoxButtons.OK, MessageBoxIcon.Warning);


            }
        }

        
    }
}
