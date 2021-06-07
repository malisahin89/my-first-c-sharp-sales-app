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
    public partial class departmanForm : MetroForm
    {
        public departmanForm()
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

        private void departmanForm_Load(object sender, EventArgs e)
        {
            bolumOku();
            
        }
        void bolumOku()
        {
            gridDepartman.DataSource = (new bolumService()).bolumleriGetir();
            if (gridDepartman.RowCount.ToString() == "0")
            {
                gridDepartman.DataSource = (new bolumService()).bolumleriGetir();
            }
            else
            {
                gridDepartman.DataSource = (new bolumService()).bolumleriGetir();
                gridDepartman.Columns[0].HeaderText = "ID";
                gridDepartman.Columns[1].HeaderText = "Ad";
                gridDepartman.Columns[2].HeaderText = "Telefon";
                gridDepartman.Columns[0].Width = 30;
                gridDepartman.Columns[1].Width = 150;
                gridDepartman.Columns[2].Width = 97;
            }
                               }

        private void btnDepartmanKaydet_Click(object sender, EventArgs e)
        {
            if (txtDepartmanAd.Text == "" || txtDepartmanTel.Text == "")
            {
                MetroMessageBox.Show(this, "Departman Ad ve Telefon Alanı Boş Bırakılamaz.", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Stop, 150);
            }
            else
            {
            (new bolumService()).bolumKaydet(txtDepartmanAd.Text, txtDepartmanTel.Text);
            txtDepartmanAd.Clear();
            txtDepartmanTel.Clear();
            bolumOku();
            }
        }

        private void btnDepartmanSil_Click(object sender, EventArgs e)
        {
            if (gridDepartman.RowCount.ToString() == "0")
            {
                MetroMessageBox.Show(this, "Silinecek Ürün Bulunmuyor.", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Stop, 150);
            }
            else
            {
                (new bolumService()).bolumSil(((Bolum)gridDepartman.CurrentRow.DataBoundItem).Id);
                bolumOku();
            }
        }

        private void btnDepartmanDuzenle_Click(object sender, EventArgs e)
        {
            btnDepartmanDuzenle.Visible=false;
            btnDepartmanSil.Visible=false;
            if (gridDepartman.RowCount.ToString() == "0")
            {
                MetroMessageBox.Show(this, "Düzenlenecek Ürün Bulunmuyor.", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Stop, 150);
            }
            else
            {
                panel1.Visible = true;
                txtDepartmanAd.Text = ((Bolum)gridDepartman.CurrentRow.DataBoundItem).Adi;
                txtDepartmanTel.Text = ((Bolum)gridDepartman.CurrentRow.DataBoundItem).Tel;
            }
        }

        private void btnDuzenle_Click(object sender, EventArgs e)
        {
            if (txtDepartmanAd.Text == "" || txtDepartmanTel.Text == "")
            {
                MetroMessageBox.Show(this, "Departman Ad ve Telefon Alanı Boş Bırakılamaz.", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Stop, 150);
            }
            else
            {
                (new bolumService()).bolumGuncelle(Convert.ToInt32(((Bolum)gridDepartman.CurrentRow.DataBoundItem).Id), txtDepartmanAd.Text, txtDepartmanTel.Text);
                txtDepartmanAd.Clear();
                txtDepartmanTel.Clear();
                panel1.Visible = false;
                bolumOku();
            }
            btnDepartmanDuzenle.Visible=true;
            btnDepartmanSil.Visible=true;
        }

        private void btnIptal_Click(object sender, EventArgs e)
        {
            txtDepartmanAd.Clear();
            txtDepartmanTel.Clear();
            panel1.Visible = false;
            bolumOku();
            btnDepartmanDuzenle.Visible=true;
            btnDepartmanSil.Visible=true;
        }

        private void txtDepartmanTel_KeyPress(object sender, KeyPressEventArgs e)
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
