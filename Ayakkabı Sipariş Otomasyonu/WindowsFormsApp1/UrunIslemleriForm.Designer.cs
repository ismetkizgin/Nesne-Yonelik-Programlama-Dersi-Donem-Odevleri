namespace WindowsFormsApp1
{
    partial class UrunIslemleriForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnGrpUrunEkle = new System.Windows.Forms.Button();
            this.txtEUrunAgirlik = new System.Windows.Forms.TextBox();
            this.txtEUrunFiyat = new System.Windows.Forms.TextBox();
            this.txtEUrunTuru = new System.Windows.Forms.TextBox();
            this.btnUrunEkle = new System.Windows.Forms.Button();
            this.btnUrunGuncelle = new System.Windows.Forms.Button();
            this.btnUrunSil = new System.Windows.Forms.Button();
            this.lstVwUrunBilgisi = new System.Windows.Forms.ListView();
            this.UrunAdi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.UrunFiyati = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.UrunAgirlik = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnGrpUrunGuncelle = new System.Windows.Forms.Button();
            this.txtGUrunAgirlik = new System.Windows.Forms.TextBox();
            this.txtGUrunFiyat = new System.Windows.Forms.TextBox();
            this.txtGUrunTuru = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnGrpUrunEkle);
            this.groupBox1.Controls.Add(this.txtEUrunAgirlik);
            this.groupBox1.Controls.Add(this.txtEUrunFiyat);
            this.groupBox1.Controls.Add(this.txtEUrunTuru);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(331, 147);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ürün Ekleme";
            this.groupBox1.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Ürün Ağırlığı (KG)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Ürün Fiyatı (TL)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Ürün Türü";
            // 
            // btnGrpUrunEkle
            // 
            this.btnGrpUrunEkle.Location = new System.Drawing.Point(250, 96);
            this.btnGrpUrunEkle.Name = "btnGrpUrunEkle";
            this.btnGrpUrunEkle.Size = new System.Drawing.Size(75, 45);
            this.btnGrpUrunEkle.TabIndex = 6;
            this.btnGrpUrunEkle.Text = "Ekle";
            this.btnGrpUrunEkle.UseVisualStyleBackColor = true;
            this.btnGrpUrunEkle.Click += new System.EventHandler(this.btnGrpUrunEkle_Click);
            // 
            // txtEUrunAgirlik
            // 
            this.txtEUrunAgirlik.Location = new System.Drawing.Point(97, 73);
            this.txtEUrunAgirlik.Name = "txtEUrunAgirlik";
            this.txtEUrunAgirlik.Size = new System.Drawing.Size(172, 20);
            this.txtEUrunAgirlik.TabIndex = 2;
            // 
            // txtEUrunFiyat
            // 
            this.txtEUrunFiyat.Location = new System.Drawing.Point(97, 47);
            this.txtEUrunFiyat.Name = "txtEUrunFiyat";
            this.txtEUrunFiyat.Size = new System.Drawing.Size(172, 20);
            this.txtEUrunFiyat.TabIndex = 1;
            // 
            // txtEUrunTuru
            // 
            this.txtEUrunTuru.Location = new System.Drawing.Point(97, 19);
            this.txtEUrunTuru.Name = "txtEUrunTuru";
            this.txtEUrunTuru.Size = new System.Drawing.Size(172, 20);
            this.txtEUrunTuru.TabIndex = 0;
            // 
            // btnUrunEkle
            // 
            this.btnUrunEkle.Location = new System.Drawing.Point(349, 12);
            this.btnUrunEkle.Name = "btnUrunEkle";
            this.btnUrunEkle.Size = new System.Drawing.Size(75, 45);
            this.btnUrunEkle.TabIndex = 0;
            this.btnUrunEkle.Text = "Ürün Ekle";
            this.btnUrunEkle.UseVisualStyleBackColor = true;
            this.btnUrunEkle.Click += new System.EventHandler(this.btnUrunEkle_Click);
            // 
            // btnUrunGuncelle
            // 
            this.btnUrunGuncelle.Location = new System.Drawing.Point(349, 63);
            this.btnUrunGuncelle.Name = "btnUrunGuncelle";
            this.btnUrunGuncelle.Size = new System.Drawing.Size(75, 45);
            this.btnUrunGuncelle.TabIndex = 3;
            this.btnUrunGuncelle.Text = "Ürün Güncelle";
            this.btnUrunGuncelle.UseVisualStyleBackColor = true;
            this.btnUrunGuncelle.Click += new System.EventHandler(this.btnUrunGuncelle_Click);
            // 
            // btnUrunSil
            // 
            this.btnUrunSil.Location = new System.Drawing.Point(349, 114);
            this.btnUrunSil.Name = "btnUrunSil";
            this.btnUrunSil.Size = new System.Drawing.Size(75, 45);
            this.btnUrunSil.TabIndex = 4;
            this.btnUrunSil.Text = "Ürün Sil";
            this.btnUrunSil.UseVisualStyleBackColor = true;
            this.btnUrunSil.Click += new System.EventHandler(this.btnUrunSil_Click);
            // 
            // lstVwUrunBilgisi
            // 
            this.lstVwUrunBilgisi.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.UrunAdi,
            this.UrunFiyati,
            this.UrunAgirlik});
            this.lstVwUrunBilgisi.FullRowSelect = true;
            this.lstVwUrunBilgisi.Location = new System.Drawing.Point(430, 12);
            this.lstVwUrunBilgisi.Name = "lstVwUrunBilgisi";
            this.lstVwUrunBilgisi.Size = new System.Drawing.Size(364, 403);
            this.lstVwUrunBilgisi.TabIndex = 5;
            this.lstVwUrunBilgisi.UseCompatibleStateImageBehavior = false;
            this.lstVwUrunBilgisi.View = System.Windows.Forms.View.Details;
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
            this.UrunAgirlik.Width = 94;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.btnGrpUrunGuncelle);
            this.groupBox2.Controls.Add(this.txtGUrunAgirlik);
            this.groupBox2.Controls.Add(this.txtGUrunFiyat);
            this.groupBox2.Controls.Add(this.txtGUrunTuru);
            this.groupBox2.Location = new System.Drawing.Point(12, 175);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(331, 147);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ürün Güncelle";
            this.groupBox2.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Ürün Ağırlığı (KG)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 48);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Ürün Fiyatı (TL)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Ürün Türü";
            // 
            // btnGrpUrunGuncelle
            // 
            this.btnGrpUrunGuncelle.Location = new System.Drawing.Point(250, 96);
            this.btnGrpUrunGuncelle.Name = "btnGrpUrunGuncelle";
            this.btnGrpUrunGuncelle.Size = new System.Drawing.Size(75, 45);
            this.btnGrpUrunGuncelle.TabIndex = 6;
            this.btnGrpUrunGuncelle.Text = "Güncelle";
            this.btnGrpUrunGuncelle.UseVisualStyleBackColor = true;
            this.btnGrpUrunGuncelle.Click += new System.EventHandler(this.btnGrpUrunGuncelle_Click);
            // 
            // txtGUrunAgirlik
            // 
            this.txtGUrunAgirlik.Location = new System.Drawing.Point(97, 67);
            this.txtGUrunAgirlik.Name = "txtGUrunAgirlik";
            this.txtGUrunAgirlik.Size = new System.Drawing.Size(172, 20);
            this.txtGUrunAgirlik.TabIndex = 2;
            // 
            // txtGUrunFiyat
            // 
            this.txtGUrunFiyat.Location = new System.Drawing.Point(97, 41);
            this.txtGUrunFiyat.Name = "txtGUrunFiyat";
            this.txtGUrunFiyat.Size = new System.Drawing.Size(172, 20);
            this.txtGUrunFiyat.TabIndex = 1;
            // 
            // txtGUrunTuru
            // 
            this.txtGUrunTuru.Location = new System.Drawing.Point(97, 13);
            this.txtGUrunTuru.Name = "txtGUrunTuru";
            this.txtGUrunTuru.Size = new System.Drawing.Size(172, 20);
            this.txtGUrunTuru.TabIndex = 0;
            // 
            // UrunIslemleriForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(806, 427);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.lstVwUrunBilgisi);
            this.Controls.Add(this.btnUrunSil);
            this.Controls.Add(this.btnUrunGuncelle);
            this.Controls.Add(this.btnUrunEkle);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.Name = "UrunIslemleriForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UrunIslem";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.UrunIslem_FormClosed);
            this.Load += new System.EventHandler(this.UrunIslem_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnGrpUrunEkle;
        private System.Windows.Forms.TextBox txtEUrunAgirlik;
        private System.Windows.Forms.TextBox txtEUrunFiyat;
        private System.Windows.Forms.TextBox txtEUrunTuru;
        private System.Windows.Forms.Button btnUrunEkle;
        private System.Windows.Forms.Button btnUrunGuncelle;
        private System.Windows.Forms.Button btnUrunSil;
        private System.Windows.Forms.ListView lstVwUrunBilgisi;
        private System.Windows.Forms.ColumnHeader UrunAdi;
        private System.Windows.Forms.ColumnHeader UrunFiyati;
        private System.Windows.Forms.ColumnHeader UrunAgirlik;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnGrpUrunGuncelle;
        private System.Windows.Forms.TextBox txtGUrunAgirlik;
        private System.Windows.Forms.TextBox txtGUrunFiyat;
        private System.Windows.Forms.TextBox txtGUrunTuru;
    }
}