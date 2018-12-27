namespace WindowsFormsApp1
{
    partial class SiparisListesiForm
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
            this.lstVwSiparisListesi = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblTaksit = new System.Windows.Forms.Label();
            this.lblSKTarihANDBankaAdi = new System.Windows.Forms.Label();
            this.lblKartANDCekSahibi = new System.Windows.Forms.Label();
            this.lblOdeme = new System.Windows.Forms.Label();
            this.lstVwSiparisDetay = new System.Windows.Forms.ListView();
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstVwSiparisListesi
            // 
            this.lstVwSiparisListesi.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.lstVwSiparisListesi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstVwSiparisListesi.FullRowSelect = true;
            this.lstVwSiparisListesi.Location = new System.Drawing.Point(3, 16);
            this.lstVwSiparisListesi.Name = "lstVwSiparisListesi";
            this.lstVwSiparisListesi.Size = new System.Drawing.Size(754, 159);
            this.lstVwSiparisListesi.TabIndex = 0;
            this.lstVwSiparisListesi.UseCompatibleStateImageBehavior = false;
            this.lstVwSiparisListesi.View = System.Windows.Forms.View.Details;
            this.lstVwSiparisListesi.Click += new System.EventHandler(this.lstVwSiparisListesi_Click);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Sipariş Kodu";
            this.columnHeader1.Width = 76;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Ad Soyad";
            this.columnHeader2.Width = 165;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Telefon";
            this.columnHeader3.Width = 89;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Adres";
            this.columnHeader4.Width = 165;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Tag = "";
            this.columnHeader5.Text = "Toplam Tutar (TL)";
            this.columnHeader5.Width = 116;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Tag = "";
            this.columnHeader6.Text = "Tarih";
            this.columnHeader6.Width = 138;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lstVwSiparisListesi);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(760, 178);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sipariş Listesi";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Controls.Add(this.lstVwSiparisDetay);
            this.groupBox2.Location = new System.Drawing.Point(15, 196);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(760, 300);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Sipariş Detay";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lblTaksit);
            this.groupBox3.Controls.Add(this.lblSKTarihANDBankaAdi);
            this.groupBox3.Controls.Add(this.lblKartANDCekSahibi);
            this.groupBox3.Controls.Add(this.lblOdeme);
            this.groupBox3.Location = new System.Drawing.Point(7, 230);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(747, 64);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Ödeme Tipi";
            // 
            // lblTaksit
            // 
            this.lblTaksit.AutoSize = true;
            this.lblTaksit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTaksit.Location = new System.Drawing.Point(619, 31);
            this.lblTaksit.Name = "lblTaksit";
            this.lblTaksit.Size = new System.Drawing.Size(46, 13);
            this.lblTaksit.TabIndex = 3;
            this.lblTaksit.Text = "Taksit:";
            this.lblTaksit.Visible = false;
            // 
            // lblSKTarihANDBankaAdi
            // 
            this.lblSKTarihANDBankaAdi.AutoSize = true;
            this.lblSKTarihANDBankaAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSKTarihANDBankaAdi.Location = new System.Drawing.Point(403, 31);
            this.lblSKTarihANDBankaAdi.Name = "lblSKTarihANDBankaAdi";
            this.lblSKTarihANDBankaAdi.Size = new System.Drawing.Size(68, 13);
            this.lblSKTarihANDBankaAdi.TabIndex = 2;
            this.lblSKTarihANDBankaAdi.Text = "S.K. Tarih:";
            this.lblSKTarihANDBankaAdi.Visible = false;
            // 
            // lblKartANDCekSahibi
            // 
            this.lblKartANDCekSahibi.AutoSize = true;
            this.lblKartANDCekSahibi.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKartANDCekSahibi.Location = new System.Drawing.Point(185, 31);
            this.lblKartANDCekSahibi.Name = "lblKartANDCekSahibi";
            this.lblKartANDCekSahibi.Size = new System.Drawing.Size(90, 13);
            this.lblKartANDCekSahibi.TabIndex = 1;
            this.lblKartANDCekSahibi.Text = "Kart Numarası:";
            this.lblKartANDCekSahibi.Visible = false;
            // 
            // lblOdeme
            // 
            this.lblOdeme.AutoSize = true;
            this.lblOdeme.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblOdeme.Location = new System.Drawing.Point(18, 31);
            this.lblOdeme.Name = "lblOdeme";
            this.lblOdeme.Size = new System.Drawing.Size(84, 13);
            this.lblOdeme.TabIndex = 0;
            this.lblOdeme.Text = "Odeme Türü: ";
            this.lblOdeme.Visible = false;
            // 
            // lstVwSiparisDetay
            // 
            this.lstVwSiparisDetay.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader11,
            this.columnHeader9,
            this.columnHeader10});
            this.lstVwSiparisDetay.FullRowSelect = true;
            this.lstVwSiparisDetay.Location = new System.Drawing.Point(3, 16);
            this.lstVwSiparisDetay.Name = "lstVwSiparisDetay";
            this.lstVwSiparisDetay.Size = new System.Drawing.Size(754, 207);
            this.lstVwSiparisDetay.TabIndex = 0;
            this.lstVwSiparisDetay.UseCompatibleStateImageBehavior = false;
            this.lstVwSiparisDetay.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Ürün Adı";
            this.columnHeader7.Width = 302;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Ağırlık (KG)";
            this.columnHeader8.Width = 98;
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "Adet";
            this.columnHeader11.Width = 84;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Ürün Fiyatı (TL)";
            this.columnHeader9.Width = 125;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "Toplam Tutar (TL)";
            this.columnHeader10.Width = 140;
            // 
            // SiparisListesiForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 508);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "SiparisListesiForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SiparisListesi";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.SiparisListesiForm_FormClosed);
            this.Load += new System.EventHandler(this.SiparisListesi_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lstVwSiparisListesi;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListView lstVwSiparisDetay;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lblTaksit;
        private System.Windows.Forms.Label lblSKTarihANDBankaAdi;
        private System.Windows.Forms.Label lblKartANDCekSahibi;
        private System.Windows.Forms.Label lblOdeme;
    }
}