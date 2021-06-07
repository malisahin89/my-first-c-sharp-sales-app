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
    public partial class urunForm : MetroForm
    {
        public urunForm()
        {
            InitializeComponent();
            urunOku();
        }
        void urunOku()
        {
            gridUrunler.DataSource = (new urunService()).urunOku();
            if (gridUrunler.RowCount.ToString() == "0")
            {
                gridUrunler.DataSource = (new urunService()).urunOku();
            }
            else
            {
                gridUrunler.DataSource = (new urunService()).urunOku();
                gridUrunler.Columns[3].Visible = false;
                gridUrunler.Columns[4].Visible = false;
                gridUrunler.Columns[0].HeaderText = "ID";
                gridUrunler.Columns[1].HeaderText = "Ad";
                gridUrunler.Columns[2].HeaderText = "Fiyat";
                gridUrunler.Columns[0].Width = 30;
                gridUrunler.Columns[1].Width = 151;
                gridUrunler.Columns[2].Width = 60;
            }
        }
        private void btnUrunDuzenle_Click(object sender, EventArgs e)
        {
            btnUrunDuzenle.Visible = false;
            btnUrunSil.Visible = false;
            if (gridUrunler.RowCount.ToString() == "0")
            {
                MetroMessageBox.Show(this, "Düzenlenecek Ürün BuLunmuyor.", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Stop, 150);
            }
            else
            {
                panel1.Visible = true;
                txtUrunAd.Text = ((urun)gridUrunler.CurrentRow.DataBoundItem).UrunAd;
                txtUrunFiyat.Text = ((urun)gridUrunler.CurrentRow.DataBoundItem).UrunFiyat.ToString();
            }
        }

        private void btnUrunSil_Click(object sender, EventArgs e)
        {
            if (gridUrunler.RowCount.ToString() == "0")
            {
                
                MetroMessageBox.Show(this, "Silinecek Ürün BuLunmuyor.", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Stop, 150);
            }
            else
            {
                (new urunService()).urunSil(((urun)gridUrunler.CurrentRow.DataBoundItem).UrunId);
                urunOku();
            }
        }
        private void btnDuzenle_Click(object sender, EventArgs e)
        {
            btnUrunDuzenle.Visible = true;
            btnUrunSil.Visible = true;
            if (txtUrunAd.Text == "" || txtUrunFiyat.Text == "")
            {
                
                MetroMessageBox.Show(this, "Ürün Ad ve Fiyat Alanı Boş Bırakılamaz.", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Stop, 150);
            }
            else
            {
                (new urunService()).urunGuncelle(Convert.ToInt32(((urun)gridUrunler.CurrentRow.DataBoundItem).UrunId), txtUrunAd.Text, Convert.ToInt32(txtUrunFiyat.Text));
                txtUrunAd.Clear();
                txtUrunFiyat.Clear();
                panel1.Visible = false;
                urunOku();
            }
        }

        private void btnIptal_Click(object sender, EventArgs e)
        {
            txtUrunAd.Clear();
            txtUrunFiyat.Clear();
            panel1.Visible = false;
            urunOku();
            btnUrunDuzenle.Visible = true;
            btnUrunSil.Visible = true;
        }

        private void urunForm_Load(object sender, EventArgs e)
        {
            try
            {
                (new dbBaglanti()).baglantiGetir();
            }
            catch
            {
                panel2.Visible = true;
            }
        }

        private void btnUrunKaydet_Click(object sender, EventArgs e)
        {
            if (txtUrunAd.Text == "" || txtUrunFiyat.Text == "")
            {
                MetroMessageBox.Show(this, "Ürün Ad ve Fiyat Alanı Boş Bırakılamaz.", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Stop, 150);
            }
            else
            {
                (new urunService()).urunKaydet(txtUrunAd.Text, Convert.ToInt32(txtUrunFiyat.Text));
                txtUrunAd.Clear();
                txtUrunFiyat.Clear();
                urunOku();
            }
        }

        private void txtUrunFiyat_KeyPress(object sender, KeyPressEventArgs e)
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

        private void metroButton2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
