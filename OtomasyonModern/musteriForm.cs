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
using MetroFramework;
using OtomasyonModern.DAL;

namespace OtomasyonModern
{
    public partial class musteriForm : MetroForm
    {
        public musteriForm()
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
            oku();

        }
        void oku()
        {
            gridMusteri.DataSource = (new musteriService()).musteriOku();
        }

        private void musteriForm_Load(object sender, EventArgs e)
        {
        }

        private void btnMusteriDuzenle_Click(object sender, EventArgs e)
        {
            btnMusteriDuzenle.Visible=false;
            btnMusteriSil.Visible=false;
            if (gridMusteri.RowCount.ToString() == "0")
            {
                MetroMessageBox.Show(this, "Düzenlenecek Müşteri Bulunmuyor.", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Stop, 150);
            }
            else
            {
                panel1.Visible = true;
                txtMusteriAd.Text = ((Musteri)gridMusteri.CurrentRow.DataBoundItem).Ad;
                txtMusteriAdres.Text = ((Musteri)gridMusteri.CurrentRow.DataBoundItem).Adres;
                txtMusteriTel.Text = ((Musteri)gridMusteri.CurrentRow.DataBoundItem).Tel;
            }
        }

        private void btnDuzenle_Click(object sender, EventArgs e)
        {
            if (txtMusteriAd.Text == "" || txtMusteriAdres.Text == "" || txtMusteriTel.Text == "")
            {
                MetroMessageBox.Show(this, "Ad, Soyad ve Telefon Alanı Boş Bırakılamaz.", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Stop, 150);
            }
            else
            {
                (new musteriService()).musteriGuncelle(((Musteri)gridMusteri.CurrentRow.DataBoundItem).Id, txtMusteriAd.Text, txtMusteriTel.Text, txtMusteriAdres.Text);
                panel1.Visible = false;
                txtMusteriAd.Clear();
                txtMusteriAdres.Clear();
                txtMusteriTel.Clear();
                oku();
            }
            btnMusteriDuzenle.Visible = true;
            btnMusteriSil.Visible = true;
        }

        private void btnIptal_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            txtMusteriAd.Clear();
            txtMusteriAdres.Clear();
            txtMusteriTel.Clear();
            oku();
            btnMusteriDuzenle.Visible = true;
            btnMusteriSil.Visible = true;
        }

        private void btnMusteriKaydet_Click(object sender, EventArgs e)
        {
            if (txtMusteriAd.Text == "" || txtMusteriAdres.Text == "" || txtMusteriTel.Text == "")
            {
                MetroMessageBox.Show(this, "Ad, Soyad ve Telefon Alanı Boş Bırakılamaz.", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Stop, 150);

            }
            else
            {
                (new musteriService()).musteriKaydet(txtMusteriAd.Text, txtMusteriTel.Text, txtMusteriAdres.Text);
                txtMusteriAd.Clear();
                txtMusteriAdres.Clear();
                txtMusteriTel.Clear();
                oku();
            }
        }

        private void btnMusteriSil_Click(object sender, EventArgs e)
        {
            if (gridMusteri.RowCount.ToString() == "0")
            {
                MetroMessageBox.Show(this, "Silinecek Müşteri Bulunmuyor.", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Stop, 150);
            }
            else
            {
                (new musteriService()).musteriSil(((Musteri)gridMusteri.CurrentRow.DataBoundItem).Id);
                txtMusteriAd.Clear();
                txtMusteriAdres.Clear();
                txtMusteriTel.Clear();
                oku();
            }
        }

        private void txtMusteriTel_KeyPress(object sender, KeyPressEventArgs e)
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
