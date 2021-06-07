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
using OtomasyonModern.resim;
using MetroFramework;
using OtomasyonModern.DAL;

namespace OtomasyonModern
{
    public partial class Form1 : MetroForm

    {
        public Form1()
        {
            InitializeComponent();
            try
            {
                (new dbBaglanti()).baglantiGetir();
            }
            catch
            {
                //MetroMessageBox.Show(this,"\n\nVERİ TABANINA ERİŞİLEMİYOR","BAĞLANTI HATASI",MessageBoxButtons.OK,MessageBoxIcon.Error);
                panel1.Visible=true;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            metroLabel1.Text ="Giriş Zamanı: " + DateTime.Now.ToShortDateString() + "-" + DateTime.Now.ToShortTimeString();
        }

        private void metroTile4_Click(object sender, EventArgs e)
        {
            (new personelForm()).Show();
        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            (new departmanForm()).Show();
        }

        private void metroTile2_Click(object sender, EventArgs e)
        {
            (new musteriForm()).Show();
        }

        private void metroTile3_Click(object sender, EventArgs e)
        {
            (new urunForm()).Show();
        }

        private void btnSatislar_Click(object sender, EventArgs e)
        {
            (new satisForm()).Show();
        }
        private void btnRaporlar_Click(object sender, EventArgs e)
        {
            (new raporlamaForm()).Show();

        }
        private void metroButton1_Click(object sender, EventArgs e)
        {
            MetroMessageBox.Show(this,"\nMuhammet Ali ŞAHİN\nİNEGÖL İŞLETME FAKÜLTESİ - YÖNETİM BİLİŞİM SİSTEMLERİ\nNO:131730028\nKULLANILAN FRAMEWORK:MetroUİ Framework","HAKKIMDA ve İLETİŞİM",MessageBoxButtons.OK,MessageBoxIcon.Asterisk);
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        
        

    }
}
