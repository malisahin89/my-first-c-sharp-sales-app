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
    public partial class satisForm : MetroForm
    {
        public satisForm()
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
            musteriOku();
            personelOku();
            urunOku();

            dataGridView1.ColumnCount = 11;
            dataGridView1.Columns[0].Name = "Ürün";
            dataGridView1.Columns[1].Name = "Fiyat";
            dataGridView1.Columns[2].Name = "Miktar";
            dataGridView1.Columns[3].Name = "Tutar";
            dataGridView1.Columns[4].Name = "MüşteriId";
            dataGridView1.Columns[5].Name = "PersonelId";
            dataGridView1.Columns[6].Name = "Tarih";
            dataGridView1.Columns[7].Name = "UrunId";
            dataGridView1.Columns[8].Name = "KDV Dahil";
            dataGridView1.Columns[9].Name = "Müşteri";
            dataGridView1.Columns[10].Name = "Personel";
            dataGridView1.Columns["MüşteriId"].Visible = false;
            dataGridView1.Columns["PersonelId"].Visible = false;
            dataGridView1.Columns["Tarih"].Visible = false;
            dataGridView1.Columns["UrunId"].Visible = false;
        }
        void urunOku()
        {
            gridUrun.DataSource = (new urunService()).urunOku();
            if (gridUrun.RowCount.ToString() == "0")
            {
                gridUrun.DataSource = (new urunService()).urunOku();
            }
            else
            {
                gridUrun.DataSource = (new urunService()).urunOku();
                gridUrun.Columns["UrunId"].Visible = false;
                gridUrun.Columns["Miktar"].Visible = false;
                gridUrun.Columns["Tutar"].Visible = false;
                gridUrun.Columns["UrunAd"].HeaderText = "Ad";
                gridUrun.Columns["UrunFiyat"].HeaderText = "Fiyat";
                gridUrun.Columns["UrunAd"].Width = 90;
                gridUrun.Columns["UrunFiyat"].Width = 49;
            }
        }
        void musteriOku()
        {
            foreach (Musteri a in (new musteriService()).musteriOku())
            {
                cboxMusteri.Items.Add(a);
            }
        }
        void personelOku()
        {
            foreach (Personel b in (new personelService()).personelleriOku())
            {
                cboxPersonel.Items.Add(b);
            }
        }
        private void satisForm_Load(object sender, EventArgs e)
        {
            label4.Text = DateTime.Now.ToShortDateString();
        }
        int urunsay = 0;
        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (cboxMusteri.Text == "" || cboxPersonel.Text == "" || txtAdet.Text == "" || gridUrun.SelectedRows.ToString() == "")
            {
                MetroMessageBox.Show(this, "Müşteri, Personel ve Adet Alanı Boş Bırakılamaz.", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Stop, 150);
            }
            else
            {
                urunsay++;
                label5.Text = urunsay.ToString();
                int fiyat = Convert.ToInt32(((urun)gridUrun.CurrentRow.DataBoundItem).UrunFiyat);

                dataGridView1.Rows.Add(
                    ((urun)gridUrun.CurrentRow.DataBoundItem).UrunAd,
                    ((urun)gridUrun.CurrentRow.DataBoundItem).UrunFiyat,
                    txtAdet.Text,
                    (Convert.ToInt32(((urun)gridUrun.CurrentRow.DataBoundItem).UrunFiyat) * Convert.ToInt32(txtAdet.Text)).ToString(),
                    ((Musteri)cboxMusteri.SelectedItem).Id,
                    ((Personel)cboxPersonel.SelectedItem).Id,
                    label4.Text.ToString(),
                    ((urun)gridUrun.CurrentRow.DataBoundItem).UrunId,
                    ((fiyat * Convert.ToInt32(txtAdet.Text)) * 1 + (fiyat * Convert.ToInt32(txtAdet.Text))).ToString(),
                    ((Musteri)cboxMusteri.SelectedItem).Ad,
                    ((Personel)cboxPersonel.SelectedItem).Ad
                );
                int hesap = 0;
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    hesap = hesap + Convert.ToInt32(row.Cells[3].Value);
                }
                label1.Text = hesap + "";
                double ss = Convert.ToInt32(label1.Text) * 0.18;
                int kdv = Convert.ToInt32(ss);
                label2.Text = kdv.ToString();
                int toplam = 0;
                toplam = Convert.ToInt32(label1.Text) + Convert.ToInt32(label2.Text);
                label3.Text = toplam.ToString();
            }
        }

        private void btnOnay_Click(object sender, EventArgs e)
        {
            if (dataGridView1.RowCount.ToString() == "0")
            {
                MetroMessageBox.Show(this, "Sepete Ürün Ekleyiniz.", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Stop, 150);

            }
            else
            {
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    (new satisService()).satisKaydet(
                    Convert.ToInt32(row.Cells[5].Value),
                    Convert.ToInt32(row.Cells[4].Value),
                    Convert.ToInt32(row.Cells[7].Value),
                    Convert.ToInt32(row.Cells[2].Value),
                    Convert.ToInt32(row.Cells[8].Value),
                    Convert.ToString(row.Cells[6].Value));
                }
                dataGridView1.Rows.Clear();
                MetroMessageBox.Show(this, "\nSiparişiniz Alınmıştır.", "BAŞARILI", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, 150);
                label1.Text = "0";
                label2.Text = "0";
                label3.Text = "0";
                label5.Text = "0";
            }
        }

        private void txtAdet_KeyPress(object sender, KeyPressEventArgs e)
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

        private void metroButton1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count.ToString() == "0")
            {
                MetroMessageBox.Show(this, "Listede Ürün Yok.", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Stop, 150);
            }
            else
            {
                int selectedIndex = dataGridView1.CurrentCell.RowIndex;
                if (selectedIndex > -1)
                {
                    dataGridView1.Rows.RemoveAt(selectedIndex);
                    dataGridView1.Refresh();
                }
                int hesap = 0;
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    hesap = hesap + Convert.ToInt32(row.Cells[3].Value);
                }
                label1.Text = hesap + "";
                double kdv = Convert.ToInt32(label1.Text) * 0.18;
                label2.Text = kdv.ToString();
                double toplam = Convert.ToInt32(label1.Text) + Convert.ToDouble(label2.Text);
                label3.Text = toplam.ToString();
            }
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count.ToString() == "0")
            {
                MetroMessageBox.Show(this, "Listede Ürün Yok.", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Warning, 150);
            }
            else
            {
                dataGridView1.Rows.Clear();
                label1.Text = "0";
                label2.Text = "0";
                label3.Text = "0";
                label5.Text = "0";
            }
        }

        private void metroButton3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
