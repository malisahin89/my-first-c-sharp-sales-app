namespace OtomasyonModern
{
    partial class urunForm
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
            this.btnUrunKaydet = new MetroFramework.Controls.MetroButton();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.gridUrunler = new System.Windows.Forms.DataGridView();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.txtUrunFiyat = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.txtUrunAd = new MetroFramework.Controls.MetroTextBox();
            this.btnUrunSil = new MetroFramework.Controls.MetroTile();
            this.btnUrunDuzenle = new MetroFramework.Controls.MetroTile();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnIptal = new MetroFramework.Controls.MetroButton();
            this.btnDuzenle = new MetroFramework.Controls.MetroButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.metroButton2 = new MetroFramework.Controls.MetroButton();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gridUrunler)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnUrunKaydet
            // 
            this.btnUrunKaydet.Location = new System.Drawing.Point(22, 193);
            this.btnUrunKaydet.Name = "btnUrunKaydet";
            this.btnUrunKaydet.Size = new System.Drawing.Size(121, 37);
            this.btnUrunKaydet.TabIndex = 24;
            this.btnUrunKaydet.Text = "KAYDET";
            this.btnUrunKaydet.UseSelectable = true;
            this.btnUrunKaydet.Click += new System.EventHandler(this.btnUrunKaydet_Click);
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(194, 60);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(270, 19);
            this.metroLabel6.TabIndex = 31;
            this.metroLabel6.Text = "Düzenlemek için sol alttaki butona tıklayınız!!!";
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel5.ForeColor = System.Drawing.Color.Red;
            this.metroLabel5.Location = new System.Drawing.Point(157, 60);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(42, 19);
            this.metroLabel5.Style = MetroFramework.MetroColorStyle.Pink;
            this.metroLabel5.TabIndex = 30;
            this.metroLabel5.Text = "NOT:";
            this.metroLabel5.UseCustomBackColor = true;
            this.metroLabel5.UseCustomForeColor = true;
            // 
            // gridUrunler
            // 
            this.gridUrunler.AllowUserToAddRows = false;
            this.gridUrunler.AllowUserToDeleteRows = false;
            this.gridUrunler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridUrunler.GridColor = System.Drawing.Color.Red;
            this.gridUrunler.Location = new System.Drawing.Point(164, 82);
            this.gridUrunler.MultiSelect = false;
            this.gridUrunler.Name = "gridUrunler";
            this.gridUrunler.ReadOnly = true;
            this.gridUrunler.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridUrunler.Size = new System.Drawing.Size(284, 216);
            this.gridUrunler.TabIndex = 29;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(10, 142);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(68, 19);
            this.metroLabel3.TabIndex = 28;
            this.metroLabel3.Text = "Ürün Fiyat";
            // 
            // txtUrunFiyat
            // 
            // 
            // 
            // 
            this.txtUrunFiyat.CustomButton.Image = null;
            this.txtUrunFiyat.CustomButton.Location = new System.Drawing.Point(99, 1);
            this.txtUrunFiyat.CustomButton.Name = "";
            this.txtUrunFiyat.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtUrunFiyat.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtUrunFiyat.CustomButton.TabIndex = 1;
            this.txtUrunFiyat.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtUrunFiyat.CustomButton.UseSelectable = true;
            this.txtUrunFiyat.CustomButton.Visible = false;
            this.txtUrunFiyat.Lines = new string[0];
            this.txtUrunFiyat.Location = new System.Drawing.Point(22, 164);
            this.txtUrunFiyat.MaxLength = 32767;
            this.txtUrunFiyat.Name = "txtUrunFiyat";
            this.txtUrunFiyat.PasswordChar = '\0';
            this.txtUrunFiyat.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtUrunFiyat.SelectedText = "";
            this.txtUrunFiyat.SelectionLength = 0;
            this.txtUrunFiyat.SelectionStart = 0;
            this.txtUrunFiyat.ShortcutsEnabled = true;
            this.txtUrunFiyat.Size = new System.Drawing.Size(121, 23);
            this.txtUrunFiyat.TabIndex = 27;
            this.txtUrunFiyat.UseSelectable = true;
            this.txtUrunFiyat.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtUrunFiyat.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtUrunFiyat.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUrunFiyat_KeyPress);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(10, 82);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(61, 19);
            this.metroLabel2.TabIndex = 26;
            this.metroLabel2.Text = "Ürün Adı";
            // 
            // txtUrunAd
            // 
            // 
            // 
            // 
            this.txtUrunAd.CustomButton.Image = null;
            this.txtUrunAd.CustomButton.Location = new System.Drawing.Point(99, 1);
            this.txtUrunAd.CustomButton.Name = "";
            this.txtUrunAd.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtUrunAd.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtUrunAd.CustomButton.TabIndex = 1;
            this.txtUrunAd.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtUrunAd.CustomButton.UseSelectable = true;
            this.txtUrunAd.CustomButton.Visible = false;
            this.txtUrunAd.Lines = new string[0];
            this.txtUrunAd.Location = new System.Drawing.Point(22, 104);
            this.txtUrunAd.MaxLength = 32767;
            this.txtUrunAd.Name = "txtUrunAd";
            this.txtUrunAd.PasswordChar = '\0';
            this.txtUrunAd.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtUrunAd.SelectedText = "";
            this.txtUrunAd.SelectionLength = 0;
            this.txtUrunAd.SelectionStart = 0;
            this.txtUrunAd.ShortcutsEnabled = true;
            this.txtUrunAd.Size = new System.Drawing.Size(121, 23);
            this.txtUrunAd.TabIndex = 25;
            this.txtUrunAd.UseSelectable = true;
            this.txtUrunAd.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtUrunAd.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btnUrunSil
            // 
            this.btnUrunSil.ActiveControl = null;
            this.btnUrunSil.BackColor = System.Drawing.Color.Red;
            this.btnUrunSil.Location = new System.Drawing.Point(88, 235);
            this.btnUrunSil.Name = "btnUrunSil";
            this.btnUrunSil.Size = new System.Drawing.Size(55, 55);
            this.btnUrunSil.TabIndex = 33;
            this.btnUrunSil.TileImage = global::OtomasyonModern.Properties.Resources.sil;
            this.btnUrunSil.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnUrunSil.UseCustomBackColor = true;
            this.btnUrunSil.UseSelectable = true;
            this.btnUrunSil.UseTileImage = true;
            this.btnUrunSil.Click += new System.EventHandler(this.btnUrunSil_Click);
            // 
            // btnUrunDuzenle
            // 
            this.btnUrunDuzenle.ActiveControl = null;
            this.btnUrunDuzenle.BackColor = System.Drawing.Color.Cyan;
            this.btnUrunDuzenle.Location = new System.Drawing.Point(22, 235);
            this.btnUrunDuzenle.Name = "btnUrunDuzenle";
            this.btnUrunDuzenle.Size = new System.Drawing.Size(55, 55);
            this.btnUrunDuzenle.TabIndex = 32;
            this.btnUrunDuzenle.TileImage = global::OtomasyonModern.Properties.Resources.duzenle;
            this.btnUrunDuzenle.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnUrunDuzenle.UseCustomBackColor = true;
            this.btnUrunDuzenle.UseSelectable = true;
            this.btnUrunDuzenle.UseTileImage = true;
            this.btnUrunDuzenle.Click += new System.EventHandler(this.btnUrunDuzenle_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnIptal);
            this.panel1.Controls.Add(this.btnDuzenle);
            this.panel1.Location = new System.Drawing.Point(0, 193);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(162, 38);
            this.panel1.TabIndex = 41;
            this.panel1.Visible = false;
            // 
            // btnIptal
            // 
            this.btnIptal.BackColor = System.Drawing.Color.Red;
            this.btnIptal.Location = new System.Drawing.Point(104, 0);
            this.btnIptal.Name = "btnIptal";
            this.btnIptal.Size = new System.Drawing.Size(58, 37);
            this.btnIptal.TabIndex = 28;
            this.btnIptal.Text = "İptal";
            this.btnIptal.UseCustomBackColor = true;
            this.btnIptal.UseSelectable = true;
            this.btnIptal.Click += new System.EventHandler(this.btnIptal_Click);
            // 
            // btnDuzenle
            // 
            this.btnDuzenle.BackColor = System.Drawing.Color.Lime;
            this.btnDuzenle.Location = new System.Drawing.Point(3, 0);
            this.btnDuzenle.Name = "btnDuzenle";
            this.btnDuzenle.Size = new System.Drawing.Size(85, 37);
            this.btnDuzenle.TabIndex = 27;
            this.btnDuzenle.Text = "Düzenle";
            this.btnDuzenle.UseCustomBackColor = true;
            this.btnDuzenle.UseSelectable = true;
            this.btnDuzenle.Click += new System.EventHandler(this.btnDuzenle_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Red;
            this.panel2.Controls.Add(this.metroButton2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(0, 60);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(464, 253);
            this.panel2.TabIndex = 42;
            this.panel2.Visible = false;
            // 
            // metroButton2
            // 
            this.metroButton2.Location = new System.Drawing.Point(149, 207);
            this.metroButton2.Name = "metroButton2";
            this.metroButton2.Size = new System.Drawing.Size(140, 23);
            this.metroButton2.TabIndex = 11;
            this.metroButton2.Text = "Uygulamayı Kapat";
            this.metroButton2.UseSelectable = true;
            this.metroButton2.Click += new System.EventHandler(this.metroButton2_Click);
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
            // urunForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(461, 313);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnUrunKaydet);
            this.Controls.Add(this.btnUrunSil);
            this.Controls.Add(this.btnUrunDuzenle);
            this.Controls.Add(this.metroLabel6);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.gridUrunler);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.txtUrunFiyat);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.txtUrunAd);
            this.Name = "urunForm";
            this.Style = MetroFramework.MetroColorStyle.Magenta;
            this.Text = "Ürünler";
            this.Load += new System.EventHandler(this.urunForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridUrunler)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroButton btnUrunKaydet;
        private MetroFramework.Controls.MetroTile btnUrunSil;
        private MetroFramework.Controls.MetroTile btnUrunDuzenle;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private System.Windows.Forms.DataGridView gridUrunler;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroTextBox txtUrunFiyat;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox txtUrunAd;
        private System.Windows.Forms.Panel panel1;
        private MetroFramework.Controls.MetroButton btnIptal;
        private MetroFramework.Controls.MetroButton btnDuzenle;
        private System.Windows.Forms.Panel panel2;
        private MetroFramework.Controls.MetroButton metroButton2;
        private System.Windows.Forms.Label label1;
    }
}