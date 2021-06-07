using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;
using OtomasyonModern.SERVICE;
using OtomasyonModern.DOMAIN;
using OtomasyonModern.DAL;
using MySql.Data.MySqlClient;
using System.Collections;
using MetroFramework;

namespace OtomasyonModern.resim
{
    public partial class personelForm : MetroForm
    {
        public personelForm()
        {
            InitializeComponent();
            try
            {
                (new dbBaglanti()).baglantiGetir();
            }
            catch
            {
                panel2.Visible = true;
            }
        }

        private void personelForm_Load(object sender, EventArgs e)
        {
            oku();
        }
        void oku()
        {
            cboxPersonelDepartman.Items.Clear();
            foreach (Bolum b in (new bolumService()).bolumleriGetir())
            {
                cboxPersonelDepartman.Items.Add(b);
            }
            gridPersonel.DataSource = (new personelService()).personelleriOku();
        }

        private void btnPersonelKaydet_Click(object sender, EventArgs e)
        {
            if (txtPersonelAd.Text == "" || txtPersonelAdres.Text == "" || txtPersonelTel.Text == "" || cboxPersonelDepartman.Text == "")
            {
                MetroMessageBox.Show(this, "Ad, Soyad, Departman ve Telefon Alanı Boş Bırakılamaz.", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Stop, 150);
            }
            else
            {
                (new personelService()).personelKaydet(txtPersonelAd.Text, txtPersonelTel.Text, txtPersonelAdres.Text, Convert.ToInt32(((Bolum)cboxPersonelDepartman.SelectedItem).Id));
                txtPersonelAd.Clear();
                txtPersonelAdres.Clear();
                txtPersonelTel.Clear();
                oku();
            }
        }

        private void btnPersonelDuzenle_Click(object sender, EventArgs e)
        {
            btnPersonelDuzenle.Visible = false;
            btnPersonelSil.Visible = false;
            if (gridPersonel.RowCount.ToString() == "0")
            {
                MetroMessageBox.Show(this, "Düzenlenecek Alam Bulunmuyor.", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Stop, 150);

            }
            else
            {
                perGuncelle((Personel)gridPersonel.CurrentRow.DataBoundItem);
                panel1.Visible = true;
            }
        }

        private void btnPersonelSil_Click(object sender, EventArgs e)
        {
            if (gridPersonel.RowCount.ToString() == "0")
            {
                MetroMessageBox.Show(this, "Silinecek Personel Bulunmuyor.", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Stop, 150);

            }
            else
            {
                (new personelService()).personelSil(((Personel)gridPersonel.CurrentRow.DataBoundItem).Id);
                txtPersonelAd.Clear();
                txtPersonelAdres.Clear();
                txtPersonelTel.Clear();
                oku();
            }
        }
        void perGuncelle(Personel per)
        {
            MySqlCommand komut = new MySqlCommand("SELECT bolumAd FROM bolum WHERE bolumId = " + per.BolumNo, (new dbBaglanti()).baglantiGetir());
            MySqlDataReader oku = komut.ExecuteReader();
            while(oku.Read())
            {
               cboxPersonelDepartman.Text = oku[0].ToString();
            }
            txtPersonelAd.Text = per.Ad;
            txtPersonelAdres.Text = per.Adres;
            txtPersonelTel.Text = per.Tel;
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            if (txtPersonelAd.Text == "" || txtPersonelAdres.Text == "" || txtPersonelTel.Text == "" || cboxPersonelDepartman.Text == "")
            {
                MetroMessageBox.Show(this, "Ad, Soyad, Departman ve Telefon Alanı Boş Bırakılamaz.", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Stop, 150);
            }
            else
            {
                (new personelService()).personelGuncelle(txtPersonelAd.Text, txtPersonelTel.Text, txtPersonelAdres.Text, Convert.ToInt32(((Bolum)cboxPersonelDepartman.SelectedItem).Id), Convert.ToInt32(((Personel)gridPersonel.CurrentRow.DataBoundItem).Id));
                panel1.Visible = false;
                txtPersonelAd.Clear();
                txtPersonelAdres.Clear();
                txtPersonelTel.Clear();
                oku();
            }
            btnPersonelDuzenle.Visible = true;
            btnPersonelSil.Visible = true;
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            txtPersonelAd.Clear();
            txtPersonelAdres.Clear();
            txtPersonelTel.Clear();
            oku();
            btnPersonelDuzenle.Visible = true;
            btnPersonelSil.Visible = true;
        }

        private void txtPersonelTel_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar >= 48 && (int)e.KeyChar <= 57)
            {
                e.Handled = false;
            }
            else if ((int)e.KeyChar == 8)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void metroButton3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
