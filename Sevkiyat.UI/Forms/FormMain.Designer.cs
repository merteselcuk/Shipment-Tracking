namespace Sevkiyat.UI
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.menuStripMain = new System.Windows.Forms.MenuStrip();
            this.irsaliyeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.irsaliyeOlusturToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.irsaliyeDüzenleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.irsaliyeDetayToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.urunToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.urunEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.urunListeleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aracToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aracEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aracListeleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.soforToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.soforEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.soforListeleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.muhatapToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.musteriEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.musteriListeleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayarlarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kullaniciEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kullaniciListeleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sifreDeğiştirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMain = new System.Windows.Forms.ToolStrip();
            this.tsbCikis = new System.Windows.Forms.ToolStripButton();
            this.tsbKullaniciDegistir = new System.Windows.Forms.ToolStripButton();
            this.menuStripMain.SuspendLayout();
            this.toolStripMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStripMain
            // 
            this.menuStripMain.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.irsaliyeToolStripMenuItem,
            this.urunToolStripMenuItem,
            this.aracToolStripMenuItem,
            this.soforToolStripMenuItem,
            this.muhatapToolStripMenuItem,
            this.ayarlarToolStripMenuItem});
            this.menuStripMain.Location = new System.Drawing.Point(0, 0);
            this.menuStripMain.Name = "menuStripMain";
            this.menuStripMain.Padding = new System.Windows.Forms.Padding(4, 1, 0, 1);
            this.menuStripMain.Size = new System.Drawing.Size(884, 24);
            this.menuStripMain.TabIndex = 1;
            // 
            // irsaliyeToolStripMenuItem
            // 
            this.irsaliyeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.irsaliyeOlusturToolStripMenuItem,
            this.irsaliyeDüzenleToolStripMenuItem,
            this.irsaliyeDetayToolStripMenuItem});
            this.irsaliyeToolStripMenuItem.Name = "irsaliyeToolStripMenuItem";
            this.irsaliyeToolStripMenuItem.Size = new System.Drawing.Size(55, 22);
            this.irsaliyeToolStripMenuItem.Text = "İ&rsaliye";
            // 
            // irsaliyeOlusturToolStripMenuItem
            // 
            this.irsaliyeOlusturToolStripMenuItem.Name = "irsaliyeOlusturToolStripMenuItem";
            this.irsaliyeOlusturToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.irsaliyeOlusturToolStripMenuItem.Text = "İrsaliye Oluştur";
            this.irsaliyeOlusturToolStripMenuItem.Click += new System.EventHandler(this.irsaliyeOlusturToolStripMenuItem_Click);
            // 
            // irsaliyeDüzenleToolStripMenuItem
            // 
            this.irsaliyeDüzenleToolStripMenuItem.Name = "irsaliyeDüzenleToolStripMenuItem";
            this.irsaliyeDüzenleToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.irsaliyeDüzenleToolStripMenuItem.Text = "İrsaliye Düzenle";
            this.irsaliyeDüzenleToolStripMenuItem.Click += new System.EventHandler(this.İrsaliyeDüzenleToolStripMenuItem_Click);
            // 
            // irsaliyeDetayToolStripMenuItem
            // 
            this.irsaliyeDetayToolStripMenuItem.Name = "irsaliyeDetayToolStripMenuItem";
            this.irsaliyeDetayToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.irsaliyeDetayToolStripMenuItem.Text = "İrsaliye Detay";
            this.irsaliyeDetayToolStripMenuItem.Click += new System.EventHandler(this.İrsaliyeDetayToolStripMenuItem_Click);
            // 
            // urunToolStripMenuItem
            // 
            this.urunToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.urunEkleToolStripMenuItem,
            this.urunListeleToolStripMenuItem});
            this.urunToolStripMenuItem.Name = "urunToolStripMenuItem";
            this.urunToolStripMenuItem.Size = new System.Drawing.Size(45, 22);
            this.urunToolStripMenuItem.Text = "Ürün";
            // 
            // urunEkleToolStripMenuItem
            // 
            this.urunEkleToolStripMenuItem.Name = "urunEkleToolStripMenuItem";
            this.urunEkleToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.urunEkleToolStripMenuItem.Text = "Ürün Ekle";
            this.urunEkleToolStripMenuItem.Click += new System.EventHandler(this.urunEkleToolStripMenuItem_Click);
            // 
            // urunListeleToolStripMenuItem
            // 
            this.urunListeleToolStripMenuItem.Name = "urunListeleToolStripMenuItem";
            this.urunListeleToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.urunListeleToolStripMenuItem.Text = "Ürün Listele";
            this.urunListeleToolStripMenuItem.Click += new System.EventHandler(this.UrunListeleToolStripMenuItem_Click);
            // 
            // aracToolStripMenuItem
            // 
            this.aracToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aracEkleToolStripMenuItem,
            this.aracListeleToolStripMenuItem});
            this.aracToolStripMenuItem.Name = "aracToolStripMenuItem";
            this.aracToolStripMenuItem.Size = new System.Drawing.Size(43, 22);
            this.aracToolStripMenuItem.Text = "Araç";
            // 
            // aracEkleToolStripMenuItem
            // 
            this.aracEkleToolStripMenuItem.Name = "aracEkleToolStripMenuItem";
            this.aracEkleToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.aracEkleToolStripMenuItem.Text = "Araç Ekle";
            this.aracEkleToolStripMenuItem.Click += new System.EventHandler(this.aracEkleToolStripMenuItem_Click);
            // 
            // aracListeleToolStripMenuItem
            // 
            this.aracListeleToolStripMenuItem.Name = "aracListeleToolStripMenuItem";
            this.aracListeleToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.aracListeleToolStripMenuItem.Text = "Araç Listele";
            this.aracListeleToolStripMenuItem.Click += new System.EventHandler(this.aracListeleToolStripMenuItem_Click);
            // 
            // soforToolStripMenuItem
            // 
            this.soforToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.soforEkleToolStripMenuItem,
            this.soforListeleToolStripMenuItem});
            this.soforToolStripMenuItem.Name = "soforToolStripMenuItem";
            this.soforToolStripMenuItem.Size = new System.Drawing.Size(47, 22);
            this.soforToolStripMenuItem.Text = "Şoför";
            // 
            // soforEkleToolStripMenuItem
            // 
            this.soforEkleToolStripMenuItem.Name = "soforEkleToolStripMenuItem";
            this.soforEkleToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.soforEkleToolStripMenuItem.Text = "Şoför Ekle";
            this.soforEkleToolStripMenuItem.Click += new System.EventHandler(this.soforEkleToolStripMenuItem_Click);
            // 
            // soforListeleToolStripMenuItem
            // 
            this.soforListeleToolStripMenuItem.Name = "soforListeleToolStripMenuItem";
            this.soforListeleToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.soforListeleToolStripMenuItem.Text = "Şoför Listele";
            this.soforListeleToolStripMenuItem.Click += new System.EventHandler(this.SoforListeleToolStripMenuItem_Click);
            // 
            // muhatapToolStripMenuItem
            // 
            this.muhatapToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.musteriEkleToolStripMenuItem,
            this.musteriListeleToolStripMenuItem});
            this.muhatapToolStripMenuItem.Name = "muhatapToolStripMenuItem";
            this.muhatapToolStripMenuItem.Size = new System.Drawing.Size(59, 22);
            this.muhatapToolStripMenuItem.Text = "Müşteri";
            // 
            // musteriEkleToolStripMenuItem
            // 
            this.musteriEkleToolStripMenuItem.Name = "musteriEkleToolStripMenuItem";
            this.musteriEkleToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.musteriEkleToolStripMenuItem.Text = "Müşteri Ekle";
            this.musteriEkleToolStripMenuItem.Click += new System.EventHandler(this.musteriEkleToolStripMenuItem_Click);
            // 
            // musteriListeleToolStripMenuItem
            // 
            this.musteriListeleToolStripMenuItem.Name = "musteriListeleToolStripMenuItem";
            this.musteriListeleToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.musteriListeleToolStripMenuItem.Text = "Müşteri Listele";
            this.musteriListeleToolStripMenuItem.Click += new System.EventHandler(this.musteriListeleToolStripMenuItem_Click);
            // 
            // ayarlarToolStripMenuItem
            // 
            this.ayarlarToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.ayarlarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kullaniciEkleToolStripMenuItem,
            this.kullaniciListeleToolStripMenuItem,
            this.sifreDeğiştirToolStripMenuItem});
            this.ayarlarToolStripMenuItem.Name = "ayarlarToolStripMenuItem";
            this.ayarlarToolStripMenuItem.Size = new System.Drawing.Size(56, 22);
            this.ayarlarToolStripMenuItem.Text = "Ayarlar";
            // 
            // kullaniciEkleToolStripMenuItem
            // 
            this.kullaniciEkleToolStripMenuItem.Name = "kullaniciEkleToolStripMenuItem";
            this.kullaniciEkleToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.kullaniciEkleToolStripMenuItem.Text = "Kullanici Ekle";
            this.kullaniciEkleToolStripMenuItem.Click += new System.EventHandler(this.KullaniciEkleToolStripMenuItem_Click);
            // 
            // kullaniciListeleToolStripMenuItem
            // 
            this.kullaniciListeleToolStripMenuItem.Name = "kullaniciListeleToolStripMenuItem";
            this.kullaniciListeleToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.kullaniciListeleToolStripMenuItem.Text = "Kullanici Listele";
            this.kullaniciListeleToolStripMenuItem.Click += new System.EventHandler(this.KullaniciListeleToolStripMenuItem_Click);
            // 
            // sifreDeğiştirToolStripMenuItem
            // 
            this.sifreDeğiştirToolStripMenuItem.Name = "sifreDeğiştirToolStripMenuItem";
            this.sifreDeğiştirToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.sifreDeğiştirToolStripMenuItem.Text = "Sifre Değiştir";
            this.sifreDeğiştirToolStripMenuItem.Click += new System.EventHandler(this.SifreDeğiştirToolStripMenuItem_Click);
            // 
            // toolStripMain
            // 
            this.toolStripMain.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbCikis,
            this.tsbKullaniciDegistir});
            this.toolStripMain.Location = new System.Drawing.Point(0, 24);
            this.toolStripMain.Name = "toolStripMain";
            this.toolStripMain.Size = new System.Drawing.Size(884, 25);
            this.toolStripMain.TabIndex = 2;
            this.toolStripMain.Text = "toolStrip1";
            // 
            // tsbCikis
            // 
            this.tsbCikis.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsbCikis.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tsbCikis.BackgroundImage")));
            this.tsbCikis.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tsbCikis.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbCikis.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbCikis.Name = "tsbCikis";
            this.tsbCikis.Size = new System.Drawing.Size(23, 22);
            this.tsbCikis.Text = "Çıkış";
            this.tsbCikis.Click += new System.EventHandler(this.TsbCikis_Click);
            // 
            // tsbKullaniciDegistir
            // 
            this.tsbKullaniciDegistir.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsbKullaniciDegistir.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tsbKullaniciDegistir.BackgroundImage")));
            this.tsbKullaniciDegistir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tsbKullaniciDegistir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbKullaniciDegistir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbKullaniciDegistir.Name = "tsbKullaniciDegistir";
            this.tsbKullaniciDegistir.Size = new System.Drawing.Size(23, 22);
            this.tsbKullaniciDegistir.Text = "Kullanıcı Degiştir";
            this.tsbKullaniciDegistir.Click += new System.EventHandler(this.tsbKullaniciDegistir_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 461);
            this.Controls.Add(this.toolStripMain);
            this.Controls.Add(this.menuStripMain);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStripMain;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormMain";
            this.ShowIcon = false;
            this.Text = "Sevkiyat Uygulaması";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.menuStripMain.ResumeLayout(false);
            this.menuStripMain.PerformLayout();
            this.toolStripMain.ResumeLayout(false);
            this.toolStripMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStripMain;
        private System.Windows.Forms.ToolStripMenuItem irsaliyeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem irsaliyeOlusturToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem irsaliyeDüzenleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem irsaliyeDetayToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem urunToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem urunEkleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem urunListeleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aracToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aracEkleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aracListeleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem soforToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem soforEkleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem soforListeleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem muhatapToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem musteriEkleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem musteriListeleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ayarlarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kullaniciEkleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kullaniciListeleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sifreDeğiştirToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStripMain;
        private System.Windows.Forms.ToolStripButton tsbCikis;
        private System.Windows.Forms.ToolStripButton tsbKullaniciDegistir;
    }
}