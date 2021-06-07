namespace OtomasyonModern
{
    partial class musteriForm
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
            this.btnMusteriSil = new MetroFramework.Controls.MetroTile();
            this.btnMusteriDuzenle = new MetroFramework.Controls.MetroTile();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.btnMusteriKaydet = new MetroFramework.Controls.MetroButton();
            this.gridMusteri = new System.Windows.Forms.DataGridView();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.txtMusteriAdres = new MetroFramework.Controls.MetroTextBox();
            this.Telefon = new MetroFramework.Controls.MetroLabel();
            this.txtMusteriTel = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.txtMusteriAd = new MetroFramework.Controls.MetroTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnIptal = new MetroFramework.Controls.MetroButton();
            this.btnDuzenle = new MetroFramework.Controls.MetroButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.metroButton3 = new MetroFramework.Controls.MetroButton();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gridMusteri)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnMusteriSil
            // 
            this.btnMusteriSil.ActiveControl = null;
            this.btnMusteriSil.BackColor = System.Drawing.Color.Red;
            this.btnMusteriSil.Location = new System.Drawing.Point(85, 310);
            this.btnMusteriSil.Name = "btnMusteriSil";
            this.btnMusteriSil.Size = new System.Drawing.Size(55, 55);
            this.btnMusteriSil.TabIndex = 39;
            this.btnMusteriSil.TileImage = global::OtomasyonModern.Properties.Resources.sil;
            this.btnMusteriSil.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnMusteriSil.UseCustomBackColor = true;
            this.btnMusteriSil.UseSelectable = true;
            this.btnMusteriSil.UseTileImage = true;
            this.btnMusteriSil.Click += new System.EventHandler(this.btnMusteriSil_Click);
            // 
            // btnMusteriDuzenle
            // 
            this.btnMusteriDuzenle.ActiveControl = null;
            this.btnMusteriDuzenle.BackColor = System.Drawing.Color.Cyan;
            this.btnMusteriDuzenle.Location = new System.Drawing.Point(19, 310);
            this.btnMusteriDuzenle.Name = "btnMusteriDuzenle";
            this.btnMusteriDuzenle.Size = new System.Drawing.Size(55, 55);
            this.btnMusteriDuzenle.TabIndex = 38;
            this.btnMusteriDuzenle.TileImage = global::OtomasyonModern.Properties.Resources.duzenle;
            this.btnMusteriDuzenle.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnMusteriDuzenle.UseCustomBackColor = true;
            this.btnMusteriDuzenle.UseSelectable = true;
            this.btnMusteriDuzenle.UseTileImage = true;
            this.btnMusteriDuzenle.Click += new System.EventHandler(this.btnMusteriDuzenle_Click);
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(202, 83);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(270, 19);
            this.metroLabel6.TabIndex = 37;
            this.metroLabel6.Text = "Düzenlemek için sol alttaki butona tıklayınız!!!";
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel5.ForeColor = System.Drawing.Color.Red;
            this.metroLabel5.Location = new System.Drawing.Point(165, 83);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(42, 19);
            this.metroLabel5.Style = MetroFramework.MetroColorStyle.Pink;
            this.metroLabel5.TabIndex = 36;
            this.metroLabel5.Text = "NOT:";
            this.metroLabel5.UseCustomBackColor = true;
            this.metroLabel5.UseCustomForeColor = true;
            // 
            // btnMusteriKaydet
            // 
            this.btnMusteriKaydet.Location = new System.Drawing.Point(18, 267);
            this.btnMusteriKaydet.Name = "btnMusteriKaydet";
            this.btnMusteriKaydet.Size = new System.Drawing.Size(121, 37);
            this.btnMusteriKaydet.TabIndex = 35;
            this.btnMusteriKaydet.Text = "KAYDET";
            this.btnMusteriKaydet.UseSelectable = true;
            this.btnMusteriKaydet.Click += new System.EventHandler(this.btnMusteriKaydet_Click);
            // 
            // gridMusteri
            // 
            this.gridMusteri.AllowUserToAddRows = false;
            this.gridMusteri.AllowUserToDeleteRows = false;
            this.gridMusteri.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridMusteri.GridColor = System.Drawing.Color.Red;
            this.gridMusteri.Location = new System.Drawing.Point(165, 105);
            this.gridMusteri.MultiSelect = false;
            this.gridMusteri.Name = "gridMusteri";
            this.gridMusteri.ReadOnly = true;
            this.gridMusteri.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridMusteri.Size = new System.Drawing.Size(448, 260);
            this.gridMusteri.TabIndex = 34;
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(8, 180);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(43, 19);
            this.metroLabel4.TabIndex = 33;
            this.metroLabel4.Text = "Adres";
            // 
            // txtMusteriAdres
            // 
            // 
            // 
            // 
            this.txtMusteriAdres.CustomButton.Image = null;
            this.txtMusteriAdres.CustomButton.Location = new System.Drawing.Point(63, 1);
            this.txtMusteriAdres.CustomButton.Name = "";
            this.txtMusteriAdres.CustomButton.Size = new System.Drawing.Size(57, 57);
            this.txtMusteriAdres.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtMusteriAdres.CustomButton.TabIndex = 1;
            this.txtMusteriAdres.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtMusteriAdres.CustomButton.UseSelectable = true;
            this.txtMusteriAdres.CustomButton.Visible = false;
            this.txtMusteriAdres.Lines = new string[0];
            this.txtMusteriAdres.Location = new System.Drawing.Point(18, 202);
            this.txtMusteriAdres.MaxLength = 32767;
            this.txtMusteriAdres.Multiline = true;
            this.txtMusteriAdres.Name = "txtMusteriAdres";
            this.txtMusteriAdres.PasswordChar = '\0';
            this.txtMusteriAdres.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtMusteriAdres.SelectedText = "";
            this.txtMusteriAdres.SelectionLength = 0;
            this.txtMusteriAdres.SelectionStart = 0;
            this.txtMusteriAdres.ShortcutsEnabled = true;
            this.txtMusteriAdres.Size = new System.Drawing.Size(121, 59);
            this.txtMusteriAdres.TabIndex = 32;
            this.txtMusteriAdres.UseSelectable = true;
            this.txtMusteriAdres.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtMusteriAdres.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // Telefon
            // 
            this.Telefon.AutoSize = true;
            this.Telefon.Location = new System.Drawing.Point(8, 132);
            this.Telefon.Name = "Telefon";
            this.Telefon.Size = new System.Drawing.Size(50, 19);
            this.Telefon.TabIndex = 31;
            this.Telefon.Text = "Telefon";
            // 
            // txtMusteriTel
            // 
            // 
            // 
            // 
            this.txtMusteriTel.CustomButton.Image = null;
            this.txtMusteriTel.CustomButton.Location = new System.Drawing.Point(99, 1);
            this.txtMusteriTel.CustomButton.Name = "";
            this.txtMusteriTel.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtMusteriTel.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtMusteriTel.CustomButton.TabIndex = 1;
            this.txtMusteriTel.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtMusteriTel.CustomButton.UseSelectable = true;
            this.txtMusteriTel.CustomButton.Visible = false;
            this.txtMusteriTel.Lines = new string[0];
            this.txtMusteriTel.Location = new System.Drawing.Point(18, 154);
            this.txtMusteriTel.MaxLength = 32767;
            this.txtMusteriTel.Name = "txtMusteriTel";
            this.txtMusteriTel.PasswordChar = '\0';
            this.txtMusteriTel.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtMusteriTel.SelectedText = "";
            this.txtMusteriTel.SelectionLength = 0;
            this.txtMusteriTel.SelectionStart = 0;
            this.txtMusteriTel.ShortcutsEnabled = true;
            this.txtMusteriTel.Size = new System.Drawing.Size(121, 23);
            this.txtMusteriTel.TabIndex = 30;
            this.txtMusteriTel.UseSelectable = true;
            this.txtMusteriTel.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtMusteriTel.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtMusteriTel.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMusteriTel_KeyPress);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(8, 84);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(26, 19);
            this.metroLabel2.TabIndex = 29;
            this.metroLabel2.Text = "Ad";
            // 
            // txtMusteriAd
            // 
            // 
            // 
            // 
            this.txtMusteriAd.CustomButton.Image = null;
            this.txtMusteriAd.CustomButton.Location = new System.Drawing.Point(99, 1);
            this.txtMusteriAd.CustomButton.Name = "";
            this.txtMusteriAd.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtMusteriAd.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtMusteriAd.CustomButton.TabIndex = 1;
            this.txtMusteriAd.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtMusteriAd.CustomButton.UseSelectable = true;
            this.txtMusteriAd.CustomButton.Visible = false;
            this.txtMusteriAd.Lines = new string[0];
            this.txtMusteriAd.Location = new System.Drawing.Point(18, 106);
            this.txtMusteriAd.MaxLength = 32767;
            this.txtMusteriAd.Name = "txtMusteriAd";
            this.txtMusteriAd.PasswordChar = '\0';
            this.txtMusteriAd.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtMusteriAd.SelectedText = "";
            this.txtMusteriAd.SelectionLength = 0;
            this.txtMusteriAd.SelectionStart = 0;
            this.txtMusteriAd.ShortcutsEnabled = true;
            this.txtMusteriAd.Size = new System.Drawing.Size(121, 23);
            this.txtMusteriAd.TabIndex = 28;
            this.txtMusteriAd.UseSelectable = true;
            this.txtMusteriAd.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtMusteriAd.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnIptal);
            this.panel1.Controls.Add(this.btnDuzenle);
            this.panel1.Location = new System.Drawing.Point(2, 267);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(162, 37);
            this.panel1.TabIndex = 40;
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
            this.panel2.Controls.Add(this.metroButton3);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Location = new System.Drawing.Point(1, 70);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(627, 311);
            this.panel2.TabIndex = 45;
            this.panel2.Visible = false;
            // 
            // metroButton3
            // 
            this.metroButton3.Location = new System.Drawing.Point(243, 240);
            this.metroButton3.Name = "metroButton3";
            this.metroButton3.Size = new System.Drawing.Size(140, 23);
            this.metroButton3.TabIndex = 11;
            this.metroButton3.Text = "Uygulamayı Kapat";
            this.metroButton3.UseSelectable = true;
            this.metroButton3.Click += new System.EventHandler(this.metroButton3_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(3, 40);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(366, 120);
            this.label6.TabIndex = 10;
            this.label6.Text = "Veri Tabanına Erişim Sağlanamadığından\r\n               Bu Yazıyı Görmektesiniz\r\n\r" +
    "\nÇözüm Önerileri;\r\n~ İnternet Bağlantınızı Kontrol edin\r\n~ Veri Tabanı Erişim ve" +
    " Tabloları Kontrol edin";
            // 
            // musteriForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(630, 382);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnMusteriSil);
            this.Controls.Add(this.btnMusteriDuzenle);
            this.Controls.Add(this.metroLabel6);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.btnMusteriKaydet);
            this.Controls.Add(this.gridMusteri);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.txtMusteriAdres);
            this.Controls.Add(this.Telefon);
            this.Controls.Add(this.txtMusteriTel);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.txtMusteriAd);
            this.Name = "musteriForm";
            this.Style = MetroFramework.MetroColorStyle.Purple;
            this.Text = "Müşteriler";
            this.Load += new System.EventHandler(this.musteriForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridMusteri)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTile btnMusteriSil;
        private MetroFramework.Controls.MetroTile btnMusteriDuzenle;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroButton btnMusteriKaydet;
        private System.Windows.Forms.DataGridView gridMusteri;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroTextBox txtMusteriAdres;
        private MetroFramework.Controls.MetroLabel Telefon;
        private MetroFramework.Controls.MetroTextBox txtMusteriTel;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox txtMusteriAd;
        private System.Windows.Forms.Panel panel1;
        private MetroFramework.Controls.MetroButton btnIptal;
        private MetroFramework.Controls.MetroButton btnDuzenle;
        private System.Windows.Forms.Panel panel2;
        private MetroFramework.Controls.MetroButton metroButton3;
        private System.Windows.Forms.Label label6;
    }
}