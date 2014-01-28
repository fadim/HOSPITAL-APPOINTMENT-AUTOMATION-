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
    public partial class frmAnaEkran : Form
    {
        //Application.StartupPath uygulamanın çalışacağı dizini gösteriyor yani veritabanımızın olduğu dizini.

        OleDbConnection baglan = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + Application.StartupPath.ToString() + "\\hastaneOtomasyonu.mdb");

        public frmAnaEkran()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            this.Show();
        giris:
            frmLogin login = new frmLogin();
            DialogResult dr = login.ShowDialog();
            if (dr == System.Windows.Forms.DialogResult.OK)
            {
                if (baglan.State == ConnectionState.Closed) baglan.Open();
                OleDbCommand komut = new OleDbCommand("SELECT * FROM kullanici WHERE kullanici_adi=@P1 AND sifresi=@P2", baglan);
                komut.Parameters.AddWithValue("@P1", login.txtKullanici_adi.Text);
                komut.Parameters.AddWithValue("@P2", login.txtSifresi.Text);

                OleDbDataAdapter adapter = new OleDbDataAdapter(komut);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                if (dt.Rows.Count == 0)//kullanıcı sisteme kayıtlı değil ya da şifresi yanlış
                {
                    login.Dispose(); //hafızada birden fazla form acılıp yer kaplamasını engellemek için
                    MessageBox.Show("Kullanıcı adı veya şifresi yanlış");
                    goto giris;
                }
                else
                {
                   login.Dispose();
                }
                
            }
            else
            {
                Application.Exit();
            }
         
        }

        private void btnDoktorEkle_Click(object sender, EventArgs e)
        {
            frmDoktorEkle doktorEkle = new frmDoktorEkle();
            doktorEkle.Show();
        }

        private void btnHastaEkle_Click(object sender, EventArgs e)
        {
            frmHastaEkle hastaEkle = new frmHastaEkle();
            hastaEkle.Show();
        }

        private void btnRandevuEkle_Click(object sender, EventArgs e)
        {
            frmRandevu randevu = new frmRandevu();
            randevu.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmRandevu randevu = new frmRandevu();
            randevu.Show();
        }

        private void btnKullaniciEkle_Click(object sender, EventArgs e)
        {
            frmKullanıcıEkle kullanici = new frmKullanıcıEkle();
            kullanici.Show();
        }

        
    }
}
