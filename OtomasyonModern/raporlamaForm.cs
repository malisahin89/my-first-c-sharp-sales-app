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
using MetroFramework;
using OtomasyonModern.DAL;
using OtomasyonModern.SERVICE;
using MySql.Data.MySqlClient;
using OtomasyonModern.DOMAIN;

namespace OtomasyonModern
{
    public partial class raporlamaForm : MetroForm
    {
        public raporlamaForm()
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
            fiyatOku();
        }
        void fiyatOku()
        {
            gridUrun.DataSource = (new urunService()).urunOku();
            gridMusteri.DataSource = (new musteriService()).musteriOku();
            gridPersonel.DataSource = (new personelService()).personelleriOku();
            gridRapor.DataSource = (new raporService()).fiyatOku();
            if (gridRapor.RowCount.ToString() == "0")
            {
                gridRapor.DataSource = (new raporService()).fiyatOku();
            }
            else
            {
                gridRapor.DataSource = (new raporService()).fiyatOku();
                gridRapor.Columns[0].HeaderText = "ID";
                gridRapor.Columns[1].HeaderText = "Personel";
                gridRapor.Columns[2].HeaderText = "Müşteri";
                gridRapor.Columns[3].HeaderText = "Tarih";
                gridRapor.Columns[4].HeaderText = "Urun";
                gridRapor.Columns[5].HeaderText = "Adet";
                gridRapor.Columns[6].HeaderText = "Tutar";
                gridRapor.Columns[0].Width = 30;
                gridRapor.Columns[1].Width = 100;
                gridRapor.Columns[2].Width = 100;
                gridRapor.Columns[3].Width = 55;
                gridRapor.Columns[4].Width = 80;
                gridRapor.Columns[5].Width = 50;
                gridRapor.Columns[6].Width = 50;
                gridRapor.Columns[7].Visible=false;

            }
        }
        private void raporlamaForm_Load(object sender, EventArgs e)
        {
            int hesap = 0;
            int adet = 0;

            foreach (DataGridViewRow row in gridRapor.Rows)
            {
                hesap = hesap + Convert.ToInt32(row.Cells[6].Value);
                adet = adet + Convert.ToInt32(row.Cells[5].Value);
            }
            label2.Text = hesap.ToString()+"  TL";
            label3.Text = adet.ToString()+"  Adet";
            label5.Text = gridUrun.RowCount.ToString() + "  Adet";
            label7.Text = gridPersonel.RowCount.ToString() + "  Adet";
            label9.Text = gridMusteri.RowCount.ToString() + "  Adet";

        }

        private void metroButton3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


    }
}
