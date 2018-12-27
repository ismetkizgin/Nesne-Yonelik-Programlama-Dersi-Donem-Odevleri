namespace WindowsFormsApp1
{
    partial class PanelForm
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
            this.btnUrunIslemleri = new System.Windows.Forms.Button();
            this.btnSiparisVer = new System.Windows.Forms.Button();
            this.btnSiparisListesi = new System.Windows.Forms.Button();
            this.btnYoneticiEkle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnUrunIslemleri
            // 
            this.btnUrunIslemleri.Location = new System.Drawing.Point(216, 12);
            this.btnUrunIslemleri.Name = "btnUrunIslemleri";
            this.btnUrunIslemleri.Size = new System.Drawing.Size(96, 78);
            this.btnUrunIslemleri.TabIndex = 2;
            this.btnUrunIslemleri.Text = "Ürün İşlemleri";
            this.btnUrunIslemleri.UseVisualStyleBackColor = true;
            this.btnUrunIslemleri.Click += new System.EventHandler(this.btnUrunIslemleri_Click);
            // 
            // btnSiparisVer
            // 
            this.btnSiparisVer.Location = new System.Drawing.Point(12, 12);
            this.btnSiparisVer.Name = "btnSiparisVer";
            this.btnSiparisVer.Size = new System.Drawing.Size(96, 78);
            this.btnSiparisVer.TabIndex = 3;
            this.btnSiparisVer.Text = "Sipariş Ver";
            this.btnSiparisVer.UseVisualStyleBackColor = true;
            this.btnSiparisVer.Click += new System.EventHandler(this.btnSiparisVer_Click);
            // 
            // btnSiparisListesi
            // 
            this.btnSiparisListesi.Location = new System.Drawing.Point(114, 12);
            this.btnSiparisListesi.Name = "btnSiparisListesi";
            this.btnSiparisListesi.Size = new System.Drawing.Size(96, 78);
            this.btnSiparisListesi.TabIndex = 4;
            this.btnSiparisListesi.Text = "Sipariş Listesi";
            this.btnSiparisListesi.UseVisualStyleBackColor = true;
            this.btnSiparisListesi.Click += new System.EventHandler(this.btnSiparisListesi_Click);
            // 
            // btnYoneticiEkle
            // 
            this.btnYoneticiEkle.Location = new System.Drawing.Point(318, 12);
            this.btnYoneticiEkle.Name = "btnYoneticiEkle";
            this.btnYoneticiEkle.Size = new System.Drawing.Size(96, 78);
            this.btnYoneticiEkle.TabIndex = 5;
            this.btnYoneticiEkle.Text = "Yönetici Ekle";
            this.btnYoneticiEkle.UseVisualStyleBackColor = true;
            this.btnYoneticiEkle.Click += new System.EventHandler(this.btnYoneticiEkle_Click);
            // 
            // PanelForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 103);
            this.Controls.Add(this.btnYoneticiEkle);
            this.Controls.Add(this.btnSiparisListesi);
            this.Controls.Add(this.btnSiparisVer);
            this.Controls.Add(this.btnUrunIslemleri);
            this.MaximizeBox = false;
            this.Name = "PanelForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Panel";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.PanelForm_FormClosed);
            this.Load += new System.EventHandler(this.PanelForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnUrunIslemleri;
        private System.Windows.Forms.Button btnSiparisVer;
        private System.Windows.Forms.Button btnSiparisListesi;
        private System.Windows.Forms.Button btnYoneticiEkle;
    }
}