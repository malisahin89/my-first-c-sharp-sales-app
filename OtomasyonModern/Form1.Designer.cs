namespace OtomasyonModern
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnRaporlar = new MetroFramework.Controls.MetroTile();
            this.btnSatislar = new MetroFramework.Controls.MetroTile();
            this.btnUrunler = new MetroFramework.Controls.MetroTile();
            this.btnPersonel = new MetroFramework.Controls.MetroTile();
            this.btnMusteriler = new MetroFramework.Controls.MetroTile();
            this.btnDepartman = new MetroFramework.Controls.MetroTile();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.metroButton2 = new MetroFramework.Controls.MetroButton();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnRaporlar
            // 
            this.btnRaporlar.ActiveControl = null;
            this.btnRaporlar.Location = new System.Drawing.Point(293, 179);
            this.btnRaporlar.Name = "btnRaporlar";
            this.btnRaporlar.Size = new System.Drawing.Size(110, 110);
            this.btnRaporlar.TabIndex = 5;
            this.btnRaporlar.Text = "Raporlar";
            this.btnRaporlar.TileImage = global::OtomasyonModern.Properties.Resources.rapor;
            this.btnRaporlar.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnRaporlar.UseSelectable = true;
            this.btnRaporlar.UseTileImage = true;
            this.btnRaporlar.Click += new System.EventHandler(this.btnRaporlar_Click);
            // 
            // btnSatislar
            // 
            this.btnSatislar.ActiveControl = null;
            this.btnSatislar.Location = new System.Drawing.Point(293, 63);
            this.btnSatislar.Name = "btnSatislar";
            this.btnSatislar.Size = new System.Drawing.Size(110, 110);
            this.btnSatislar.Style = MetroFramework.MetroColorStyle.Teal;
            this.btnSatislar.TabIndex = 4;
            this.btnSatislar.Text = "Satış Yap";
            this.btnSatislar.TileImage = global::OtomasyonModern.Properties.Resources.siparis;
            this.btnSatislar.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSatislar.UseSelectable = true;
            this.btnSatislar.UseTileImage = true;
            this.btnSatislar.Click += new System.EventHandler(this.btnSatislar_Click);
            // 
            // btnUrunler
            // 
            this.btnUrunler.ActiveControl = null;
            this.btnUrunler.Location = new System.Drawing.Point(139, 179);
            this.btnUrunler.Name = "btnUrunler";
            this.btnUrunler.Size = new System.Drawing.Size(110, 110);
            this.btnUrunler.Style = MetroFramework.MetroColorStyle.Magenta;
            this.btnUrunler.TabIndex = 3;
            this.btnUrunler.Text = "Ürünler";
            this.btnUrunler.TileImage = global::OtomasyonModern.Properties.Resources.urun;
            this.btnUrunler.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnUrunler.UseSelectable = true;
            this.btnUrunler.UseTileImage = true;
            this.btnUrunler.Click += new System.EventHandler(this.metroTile3_Click);
            // 
            // btnPersonel
            // 
            this.btnPersonel.ActiveControl = null;
            this.btnPersonel.Location = new System.Drawing.Point(139, 63);
            this.btnPersonel.Name = "btnPersonel";
            this.btnPersonel.Size = new System.Drawing.Size(110, 110);
            this.btnPersonel.Style = MetroFramework.MetroColorStyle.Red;
            this.btnPersonel.TabIndex = 2;
            this.btnPersonel.Text = "Personel";
            this.btnPersonel.TileImage = global::OtomasyonModern.Properties.Resources.personel;
            this.btnPersonel.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnPersonel.UseSelectable = true;
            this.btnPersonel.UseTileImage = true;
            this.btnPersonel.Click += new System.EventHandler(this.metroTile4_Click);
            // 
            // btnMusteriler
            // 
            this.btnMusteriler.ActiveControl = null;
            this.btnMusteriler.Location = new System.Drawing.Point(23, 179);
            this.btnMusteriler.Name = "btnMusteriler";
            this.btnMusteriler.Size = new System.Drawing.Size(110, 110);
            this.btnMusteriler.Style = MetroFramework.MetroColorStyle.Purple;
            this.btnMusteriler.TabIndex = 1;
            this.btnMusteriler.Text = "Müşteriler";
            this.btnMusteriler.TileImage = global::OtomasyonModern.Properties.Resources.musteri;
            this.btnMusteriler.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnMusteriler.UseSelectable = true;
            this.btnMusteriler.UseTileImage = true;
            this.btnMusteriler.Click += new System.EventHandler(this.metroTile2_Click);
            // 
            // btnDepartman
            // 
            this.btnDepartman.ActiveControl = null;
            this.btnDepartman.BackColor = System.Drawing.Color.White;
            this.btnDepartman.Location = new System.Drawing.Point(23, 63);
            this.btnDepartman.Name = "btnDepartman";
            this.btnDepartman.Size = new System.Drawing.Size(110, 110);
            this.btnDepartman.Style = MetroFramework.MetroColorStyle.Yellow;
            this.btnDepartman.TabIndex = 0;
            this.btnDepartman.Text = "Departman";
            this.btnDepartman.TileImage = global::OtomasyonModern.Properties.Resources.departmant;
            this.btnDepartman.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnDepartman.UseSelectable = true;
            this.btnDepartman.UseTileImage = true;
            this.btnDepartman.Click += new System.EventHandler(this.metroTile1_Click);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(248, 292);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(81, 19);
            this.metroLabel1.TabIndex = 7;
            this.metroLabel1.Text = "metroLabel1";
            // 
            // metroButton1
            // 
            this.metroButton1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.metroButton1.ForeColor = System.Drawing.Color.White;
            this.metroButton1.Location = new System.Drawing.Point(23, 292);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(226, 23);
            this.metroButton1.TabIndex = 8;
            this.metroButton1.Text = "HAKKIMDA ve İLETİŞİM";
            this.metroButton1.UseCustomBackColor = true;
            this.metroButton1.UseCustomForeColor = true;
            this.metroButton1.UseSelectable = true;
            this.metroButton1.UseStyleColors = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Red;
            this.panel1.Controls.Add(this.metroButton2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(23, 63);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(380, 227);
            this.panel1.TabIndex = 9;
            this.panel1.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(3, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(366, 120);
            this.label1.TabIndex = 10;
            this.label1.Text = "Veri Tabanına Erişim Sağlanamadığından\r\n               Bu Yazıyı Görmektesiniz\r\n\r" +
    "\nÇözüm Önerileri;\r\n~ İnternet Bağlantınızı Kontrol edin\r\n~ Veri Tabanı Erişim ve" +
    " Tabloları Kontrol edin";
            // 
            // metroButton2
            // 
            this.metroButton2.Location = new System.Drawing.Point(116, 186);
            this.metroButton2.Name = "metroButton2";
            this.metroButton2.Size = new System.Drawing.Size(140, 23);
            this.metroButton2.TabIndex = 11;
            this.metroButton2.Text = "Uygulamayı Kapat";
            this.metroButton2.UseSelectable = true;
            this.metroButton2.Click += new System.EventHandler(this.metroButton2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(423, 320);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.btnRaporlar);
            this.Controls.Add(this.btnSatislar);
            this.Controls.Add(this.btnUrunler);
            this.Controls.Add(this.btnPersonel);
            this.Controls.Add(this.btnMusteriler);
            this.Controls.Add(this.btnDepartman);
            this.Name = "Form1";
            this.Style = MetroFramework.MetroColorStyle.Lime;
            this.Text = "Ana Sayfa";
            this.TransparencyKey = System.Drawing.Color.DeepSkyBlue;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTile btnDepartman;
        private MetroFramework.Controls.MetroTile btnMusteriler;
        private MetroFramework.Controls.MetroTile btnUrunler;
        private MetroFramework.Controls.MetroTile btnPersonel;
        private MetroFramework.Controls.MetroTile btnRaporlar;
        private MetroFramework.Controls.MetroTile btnSatislar;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private System.Windows.Forms.Timer timer1;
        private MetroFramework.Controls.MetroButton metroButton1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private MetroFramework.Controls.MetroButton metroButton2;


    }
}

