namespace WindowsFormsApp1
{
    partial class SiparisVerForm
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
            this.lstVwUrunBilgisi = new System.Windows.Forms.ListView();
            this.UrunAdi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.UrunFiyati = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.UrunAgirlik = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lstVwSiparisListesi = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtAdres = new System.Windows.Forms.TextBox();
            this.txtTel = new System.Windows.Forms.TextBox();
            this.txtAdSoyad = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSiparisVer = new System.Windows.Forms.Button();
            this.btnSprTemizle = new System.Windows.Forms.Button();
            this.btnAzalt = new System.Windows.Forms.Button();
            this.btnArtir = new System.Windows.Forms.Button();
            this.btnCikar = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtBankaAdi = new System.Windows.Forms.TextBox();
            this.drpTaksit = new System.Windows.Forms.ComboBox();
            this.lblSKTarihANDBankaAdi = new System.Windows.Forms.Label();
            this.lblTaksit = new System.Windows.Forms.Label();
            this.txtKardNumarasıANDCekSahibi = new System.Windows.Forms.TextBox();
            this.lblKardNumarasıANDCekSahibi = new System.Windows.Forms.Label();
            this.rdnBtnKartNumarasi = new System.Windows.Forms.RadioButton();
            this.rdnBtnNakit = new System.Windows.Forms.RadioButton();
            this.rdnBtnCek = new System.Windows.Forms.RadioButton();
            this.drpAy = new System.Windows.Forms.ComboBox();
            this.drpYil = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstVwUrunBilgisi
            // 
            this.lstVwUrunBilgisi.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.UrunAdi,
            this.UrunFiyati,
            this.UrunAgirlik});
            this.lstVwUrunBilgisi.FullRowSelect = true;
            this.lstVwUrunBilgisi.Location = new System.Drawing.Point(12, 37);
            this.lstVwUrunBilgisi.Name = "lstVwUrunBilgisi";
            this.lstVwUrunBilgisi.Size = new System.Drawing.Size(364, 378);
            this.lstVwUrunBilgisi.TabIndex = 6;
            this.lstVwUrunBilgisi.Tag = "";
            this.lstVwUrunBilgisi.UseCompatibleStateImageBehavior = false;
            this.lstVwUrunBilgisi.View = System.Windows.Forms.View.Details;
            this.lstVwUrunBilgisi.DoubleClick += new System.EventHandler(this.lstVwUrunBilgisi_DoubleClick);
            // 
            // UrunAdi
            // 
            this.UrunAdi.Text = "Ürün Adı";
            this.UrunAdi.Width = 204;
            // 
            // UrunFiyati
            // 
            this.UrunFiyati.Text = "Ürün Fiyati (TL)";
            this.UrunFiyati.Width = 84;
            // 
            // UrunAgirlik
            // 
            this.UrunAgirlik.Text = "Ürün Ağırlığı (KG)";
            this.UrunAgirlik.Width = 93;
            // 
            // lstVwSiparisListesi
            // 
            this.lstVwSiparisListesi.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader5});
            this.lstVwSiparisListesi.FullRowSelect = true;
            this.lstVwSiparisListesi.Location = new System.Drawing.Point(382, 37);
            this.lstVwSiparisListesi.Name = "lstVwSiparisListesi";
            this.lstVwSiparisListesi.Size = new System.Drawing.Size(474, 332);
            this.lstVwSiparisListesi.TabIndex = 7;
            this.lstVwSiparisListesi.UseCompatibleStateImageBehavior = false;
            this.lstVwSiparisListesi.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Ürün Adı";
            this.columnHeader1.Width = 254;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Ürün Fiyati (TL)";
            this.columnHeader2.Width = 84;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Ürün Ağırlığı (KG)";
            this.columnHeader3.Width = 104;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Adet";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtAdres);
            this.groupBox1.Controls.Add(this.txtTel);
            this.groupBox1.Controls.Add(this.txtAdSoyad);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 421);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(844, 65);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sipariş Bilgileri";
            // 
            // txtAdres
            // 
            this.txtAdres.Location = new System.Drawing.Point(505, 19);
            this.txtAdres.Multiline = true;
            this.txtAdres.Name = "txtAdres";
            this.txtAdres.Size = new System.Drawing.Size(333, 36);
            this.txtAdres.TabIndex = 15;
            // 
            // txtTel
            // 
            this.txtTel.Location = new System.Drawing.Point(294, 27);
            this.txtTel.Name = "txtTel";
            this.txtTel.Size = new System.Drawing.Size(165, 20);
            this.txtTel.TabIndex = 14;
            // 
            // txtAdSoyad
            // 
            this.txtAdSoyad.Location = new System.Drawing.Point(74, 27);
            this.txtAdSoyad.Name = "txtAdSoyad";
            this.txtAdSoyad.Size = new System.Drawing.Size(165, 20);
            this.txtAdSoyad.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(465, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Adres";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(245, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Telefon";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Ad Soyad";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(125, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 25);
            this.label1.TabIndex = 9;
            this.label1.Text = "Ürün Listesi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(559, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(147, 25);
            this.label3.TabIndex = 10;
            this.label3.Text = "Sipariş Listesi";
            // 
            // btnSiparisVer
            // 
            this.btnSiparisVer.Location = new System.Drawing.Point(12, 563);
            this.btnSiparisVer.Name = "btnSiparisVer";
            this.btnSiparisVer.Size = new System.Drawing.Size(844, 31);
            this.btnSiparisVer.TabIndex = 11;
            this.btnSiparisVer.Text = "Sipariş Ver";
            this.btnSiparisVer.UseVisualStyleBackColor = true;
            this.btnSiparisVer.Click += new System.EventHandler(this.btnSiparisVer_Click);
            // 
            // btnSprTemizle
            // 
            this.btnSprTemizle.Location = new System.Drawing.Point(382, 371);
            this.btnSprTemizle.Name = "btnSprTemizle";
            this.btnSprTemizle.Size = new System.Drawing.Size(115, 44);
            this.btnSprTemizle.TabIndex = 12;
            this.btnSprTemizle.Text = "Sipariş Listesini Temizle";
            this.btnSprTemizle.UseVisualStyleBackColor = true;
            this.btnSprTemizle.Click += new System.EventHandler(this.btnSprTemizle_Click);
            // 
            // btnAzalt
            // 
            this.btnAzalt.Location = new System.Drawing.Point(503, 371);
            this.btnAzalt.Name = "btnAzalt";
            this.btnAzalt.Size = new System.Drawing.Size(115, 44);
            this.btnAzalt.TabIndex = 13;
            this.btnAzalt.Text = "Seçili Ürün Adedini Azalt";
            this.btnAzalt.UseVisualStyleBackColor = true;
            this.btnAzalt.Click += new System.EventHandler(this.btnAzalt_Click);
            // 
            // btnArtir
            // 
            this.btnArtir.Location = new System.Drawing.Point(624, 371);
            this.btnArtir.Name = "btnArtir";
            this.btnArtir.Size = new System.Drawing.Size(115, 44);
            this.btnArtir.TabIndex = 14;
            this.btnArtir.Text = "Seçili Ürün Adedini Artır";
            this.btnArtir.UseVisualStyleBackColor = true;
            this.btnArtir.Click += new System.EventHandler(this.btnArtir_Click);
            // 
            // btnCikar
            // 
            this.btnCikar.Location = new System.Drawing.Point(745, 371);
            this.btnCikar.Name = "btnCikar";
            this.btnCikar.Size = new System.Drawing.Size(111, 44);
            this.btnCikar.TabIndex = 15;
            this.btnCikar.Text = "Seçili Ürünü Listeden Çıkar";
            this.btnCikar.UseVisualStyleBackColor = true;
            this.btnCikar.Click += new System.EventHandler(this.btnCikar_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.drpYil);
            this.groupBox2.Controls.Add(this.drpAy);
            this.groupBox2.Controls.Add(this.txtBankaAdi);
            this.groupBox2.Controls.Add(this.drpTaksit);
            this.groupBox2.Controls.Add(this.lblSKTarihANDBankaAdi);
            this.groupBox2.Controls.Add(this.lblTaksit);
            this.groupBox2.Controls.Add(this.txtKardNumarasıANDCekSahibi);
            this.groupBox2.Controls.Add(this.lblKardNumarasıANDCekSahibi);
            this.groupBox2.Controls.Add(this.rdnBtnKartNumarasi);
            this.groupBox2.Controls.Add(this.rdnBtnNakit);
            this.groupBox2.Controls.Add(this.rdnBtnCek);
            this.groupBox2.Location = new System.Drawing.Point(13, 493);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(843, 64);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ödeme Tipi";
            // 
            // txtBankaAdi
            // 
            this.txtBankaAdi.Location = new System.Drawing.Point(527, 29);
            this.txtBankaAdi.Name = "txtBankaAdi";
            this.txtBankaAdi.Size = new System.Drawing.Size(141, 20);
            this.txtBankaAdi.TabIndex = 11;
            this.txtBankaAdi.Visible = false;
            // 
            // drpTaksit
            // 
            this.drpTaksit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.drpTaksit.FormattingEnabled = true;
            this.drpTaksit.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.drpTaksit.Location = new System.Drawing.Point(716, 29);
            this.drpTaksit.Name = "drpTaksit";
            this.drpTaksit.Size = new System.Drawing.Size(121, 21);
            this.drpTaksit.TabIndex = 9;
            this.drpTaksit.Visible = false;
            // 
            // lblSKTarihANDBankaAdi
            // 
            this.lblSKTarihANDBankaAdi.AutoSize = true;
            this.lblSKTarihANDBankaAdi.Location = new System.Drawing.Point(468, 32);
            this.lblSKTarihANDBankaAdi.Name = "lblSKTarihANDBankaAdi";
            this.lblSKTarihANDBankaAdi.Size = new System.Drawing.Size(53, 13);
            this.lblSKTarihANDBankaAdi.TabIndex = 7;
            this.lblSKTarihANDBankaAdi.Text = "S.K Tarihi";
            this.lblSKTarihANDBankaAdi.Visible = false;
            // 
            // lblTaksit
            // 
            this.lblTaksit.AutoSize = true;
            this.lblTaksit.Location = new System.Drawing.Point(674, 32);
            this.lblTaksit.Name = "lblTaksit";
            this.lblTaksit.Size = new System.Drawing.Size(36, 13);
            this.lblTaksit.TabIndex = 5;
            this.lblTaksit.Text = "Taksit";
            this.lblTaksit.Visible = false;
            // 
            // txtKardNumarasıANDCekSahibi
            // 
            this.txtKardNumarasıANDCekSahibi.Location = new System.Drawing.Point(306, 29);
            this.txtKardNumarasıANDCekSahibi.Name = "txtKardNumarasıANDCekSahibi";
            this.txtKardNumarasıANDCekSahibi.Size = new System.Drawing.Size(152, 20);
            this.txtKardNumarasıANDCekSahibi.TabIndex = 4;
            this.txtKardNumarasıANDCekSahibi.Visible = false;
            // 
            // lblKardNumarasıANDCekSahibi
            // 
            this.lblKardNumarasıANDCekSahibi.AutoSize = true;
            this.lblKardNumarasıANDCekSahibi.Location = new System.Drawing.Point(198, 32);
            this.lblKardNumarasıANDCekSahibi.Name = "lblKardNumarasıANDCekSahibi";
            this.lblKardNumarasıANDCekSahibi.Size = new System.Drawing.Size(102, 13);
            this.lblKardNumarasıANDCekSahibi.TabIndex = 3;
            this.lblKardNumarasıANDCekSahibi.Text = "Kredi Kartı Numarası";
            this.lblKardNumarasıANDCekSahibi.Visible = false;
            // 
            // rdnBtnKartNumarasi
            // 
            this.rdnBtnKartNumarasi.AutoSize = true;
            this.rdnBtnKartNumarasi.Location = new System.Drawing.Point(112, 30);
            this.rdnBtnKartNumarasi.Name = "rdnBtnKartNumarasi";
            this.rdnBtnKartNumarasi.Size = new System.Drawing.Size(73, 17);
            this.rdnBtnKartNumarasi.TabIndex = 1;
            this.rdnBtnKartNumarasi.Text = "Kredi Kartı";
            this.rdnBtnKartNumarasi.UseVisualStyleBackColor = true;
            this.rdnBtnKartNumarasi.CheckedChanged += new System.EventHandler(this.rdnBtnKartNumarasi_CheckedChanged);
            // 
            // rdnBtnNakit
            // 
            this.rdnBtnNakit.AutoSize = true;
            this.rdnBtnNakit.Checked = true;
            this.rdnBtnNakit.Location = new System.Drawing.Point(6, 30);
            this.rdnBtnNakit.Name = "rdnBtnNakit";
            this.rdnBtnNakit.Size = new System.Drawing.Size(50, 17);
            this.rdnBtnNakit.TabIndex = 0;
            this.rdnBtnNakit.TabStop = true;
            this.rdnBtnNakit.Text = "Nakit";
            this.rdnBtnNakit.UseVisualStyleBackColor = true;
            this.rdnBtnNakit.CheckedChanged += new System.EventHandler(this.rdnBtnNakit_CheckedChanged);
            // 
            // rdnBtnCek
            // 
            this.rdnBtnCek.AutoSize = true;
            this.rdnBtnCek.Location = new System.Drawing.Point(62, 30);
            this.rdnBtnCek.Name = "rdnBtnCek";
            this.rdnBtnCek.Size = new System.Drawing.Size(44, 17);
            this.rdnBtnCek.TabIndex = 2;
            this.rdnBtnCek.Text = "Çek";
            this.rdnBtnCek.UseVisualStyleBackColor = true;
            this.rdnBtnCek.CheckedChanged += new System.EventHandler(this.rdnBtnCek_CheckedChanged);
            // 
            // drpAy
            // 
            this.drpAy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.drpAy.FormattingEnabled = true;
            this.drpAy.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.drpAy.Location = new System.Drawing.Point(527, 28);
            this.drpAy.Name = "drpAy";
            this.drpAy.Size = new System.Drawing.Size(61, 21);
            this.drpAy.TabIndex = 12;
            this.drpAy.Visible = false;
            // 
            // drpYil
            // 
            this.drpYil.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.drpYil.FormattingEnabled = true;
            this.drpYil.Items.AddRange(new object[] {
            "2018",
            "2019",
            "2020",
            "2021",
            "2022",
            "2023",
            "2024",
            "2025"});
            this.drpYil.Location = new System.Drawing.Point(594, 29);
            this.drpYil.Name = "drpYil";
            this.drpYil.Size = new System.Drawing.Size(74, 21);
            this.drpYil.TabIndex = 13;
            this.drpYil.Visible = false;
            // 
            // SiparisVerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(868, 606);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnCikar);
            this.Controls.Add(this.btnArtir);
            this.Controls.Add(this.btnAzalt);
            this.Controls.Add(this.btnSprTemizle);
            this.Controls.Add(this.btnSiparisVer);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lstVwSiparisListesi);
            this.Controls.Add(this.lstVwUrunBilgisi);
            this.MaximizeBox = false;
            this.Name = "SiparisVerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "KullaniciIslemleri";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.KullaniciIslemleri_FormClosed);
            this.Load += new System.EventHandler(this.KullaniciIslemleri_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lstVwUrunBilgisi;
        private System.Windows.Forms.ColumnHeader UrunAdi;
        private System.Windows.Forms.ColumnHeader UrunFiyati;
        private System.Windows.Forms.ColumnHeader UrunAgirlik;
        private System.Windows.Forms.ListView lstVwSiparisListesi;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtAdSoyad;
        private System.Windows.Forms.TextBox txtAdres;
        private System.Windows.Forms.TextBox txtTel;
        private System.Windows.Forms.Button btnSiparisVer;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.Button btnSprTemizle;
        private System.Windows.Forms.Button btnAzalt;
        private System.Windows.Forms.Button btnArtir;
        private System.Windows.Forms.Button btnCikar;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rdnBtnCek;
        private System.Windows.Forms.RadioButton rdnBtnKartNumarasi;
        private System.Windows.Forms.RadioButton rdnBtnNakit;
        private System.Windows.Forms.Label lblKardNumarasıANDCekSahibi;
        private System.Windows.Forms.Label lblSKTarihANDBankaAdi;
        private System.Windows.Forms.Label lblTaksit;
        private System.Windows.Forms.TextBox txtKardNumarasıANDCekSahibi;
        private System.Windows.Forms.ComboBox drpTaksit;
        private System.Windows.Forms.TextBox txtBankaAdi;
        private System.Windows.Forms.ComboBox drpYil;
        private System.Windows.Forms.ComboBox drpAy;
    }
}