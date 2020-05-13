namespace KütüphaneAnaMenü
{
    partial class Anamenu
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Anamenu));
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btn_KitapEkle = new System.Windows.Forms.ToolStripButton();
            this.btn_okuyucuKayit = new System.Windows.Forms.ToolStripButton();
            this.btn_okuyucular = new System.Windows.Forms.ToolStripButton();
            this.btn_kitapListesi = new System.Windows.Forms.ToolStripButton();
            this.btn_EmanetListesi = new System.Windows.Forms.ToolStripButton();
            this.btn_Cikis = new System.Windows.Forms.ToolStripButton();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.hakkındaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kitap_listesi_cmbbx = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Okuyucu_listesi_cmbbx = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.btn_UpdateFormData = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.ÇıktıAlKitap = new System.Windows.Forms.Button();
            this.Ödünc_Ver_Bttn = new System.Windows.Forms.Button();
            this.toolStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "Kitap ekle.jpg");
            this.ımageList1.Images.SetKeyName(1, "kişi ekle.jpg");
            this.ımageList1.Images.SetKeyName(2, "Okuyucular.png");
            this.ımageList1.Images.SetKeyName(3, "Kitaplar.png");
            this.ımageList1.Images.SetKeyName(4, "Ödünçler.ico");
            this.ımageList1.Images.SetKeyName(5, "kitaplistele.png");
            this.ımageList1.Images.SetKeyName(6, "kitaplistele.png");
            this.ımageList1.Images.SetKeyName(7, "okuyuculistele.png");
            this.ımageList1.Images.SetKeyName(8, "books.png");
            this.ımageList1.Images.SetKeyName(9, "refresh.png");
            this.ımageList1.Images.SetKeyName(10, "team.png");
            this.ımageList1.Images.SetKeyName(11, "plus.png");
            this.ımageList1.Images.SetKeyName(12, "users.png");
            // 
            // toolStrip1
            // 
            this.toolStrip1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.toolStrip1.BackColor = System.Drawing.SystemColors.Control;
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(60, 60);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_KitapEkle,
            this.btn_okuyucuKayit,
            this.btn_okuyucular,
            this.btn_kitapListesi,
            this.btn_EmanetListesi,
            this.btn_Cikis});
            this.toolStrip1.Location = new System.Drawing.Point(0, 28);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(879, 67);
            this.toolStrip1.TabIndex = 5;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btn_KitapEkle
            // 
            this.btn_KitapEkle.Image = global::KütüphaneAnaMenü.Properties.Resources.plus;
            this.btn_KitapEkle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_KitapEkle.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_KitapEkle.Name = "btn_KitapEkle";
            this.btn_KitapEkle.Size = new System.Drawing.Size(145, 64);
            this.btn_KitapEkle.Text = "Kitap Kayıt";
            this.btn_KitapEkle.Click += new System.EventHandler(this.ButonKitapEkleClick);
            // 
            // btn_okuyucuKayit
            // 
            this.btn_okuyucuKayit.Image = global::KütüphaneAnaMenü.Properties.Resources.users;
            this.btn_okuyucuKayit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_okuyucuKayit.Name = "btn_okuyucuKayit";
            this.btn_okuyucuKayit.Size = new System.Drawing.Size(166, 64);
            this.btn_okuyucuKayit.Text = "Okuyucu Kayıt";
            this.btn_okuyucuKayit.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            this.btn_okuyucuKayit.Click += new System.EventHandler(this.ButonOkuyucuKayitClick);
            // 
            // btn_okuyucular
            // 
            this.btn_okuyucular.Image = global::KütüphaneAnaMenü.Properties.Resources.team__1_;
            this.btn_okuyucular.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_okuyucular.Name = "btn_okuyucular";
            this.btn_okuyucular.Size = new System.Drawing.Size(173, 64);
            this.btn_okuyucular.Text = "Okuyucu Listesi";
            this.btn_okuyucular.Click += new System.EventHandler(this.ButonOkuyucularClick);
            // 
            // btn_kitapListesi
            // 
            this.btn_kitapListesi.Image = global::KütüphaneAnaMenü.Properties.Resources.books__1_;
            this.btn_kitapListesi.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_kitapListesi.Name = "btn_kitapListesi";
            this.btn_kitapListesi.Size = new System.Drawing.Size(152, 64);
            this.btn_kitapListesi.Text = "Kitap Listesi";
            this.btn_kitapListesi.Click += new System.EventHandler(this.ButonKitapListesiClick);
            // 
            // btn_EmanetListesi
            // 
            this.btn_EmanetListesi.Image = global::KütüphaneAnaMenü.Properties.Resources.emanet;
            this.btn_EmanetListesi.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_EmanetListesi.Name = "btn_EmanetListesi";
            this.btn_EmanetListesi.Size = new System.Drawing.Size(167, 64);
            this.btn_EmanetListesi.Text = "Emanet Listesi";
            this.btn_EmanetListesi.Click += new System.EventHandler(this.ButonOduncListesiClick);
            // 
            // btn_Cikis
            // 
            this.btn_Cikis.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_Cikis.Image = global::KütüphaneAnaMenü.Properties.Resources.icon;
            this.btn_Cikis.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_Cikis.Name = "btn_Cikis";
            this.btn_Cikis.Size = new System.Drawing.Size(64, 64);
            this.btn_Cikis.Text = "Çıkış";
            this.btn_Cikis.Click += new System.EventHandler(this.ButonCikisClick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.Control;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hakkındaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1215, 28);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // hakkındaToolStripMenuItem
            // 
            this.hakkındaToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.hakkındaToolStripMenuItem.Image = global::KütüphaneAnaMenü.Properties.Resources.Actions_help_about_icon__1_;
            this.hakkındaToolStripMenuItem.Name = "hakkındaToolStripMenuItem";
            this.hakkındaToolStripMenuItem.Size = new System.Drawing.Size(103, 24);
            this.hakkındaToolStripMenuItem.Text = "Hakkında";
            this.hakkındaToolStripMenuItem.Click += new System.EventHandler(this.HakkındaToolStripMenuItem_Click);
            // 
            // kitap_listesi_cmbbx
            // 
            this.kitap_listesi_cmbbx.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.kitap_listesi_cmbbx.FormattingEnabled = true;
            this.kitap_listesi_cmbbx.Location = new System.Drawing.Point(215, 266);
            this.kitap_listesi_cmbbx.Name = "kitap_listesi_cmbbx";
            this.kitap_listesi_cmbbx.Size = new System.Drawing.Size(674, 24);
            this.kitap_listesi_cmbbx.TabIndex = 10;
            this.kitap_listesi_cmbbx.SelectedIndexChanged += new System.EventHandler(this.Kitap_listesi_cmbbx_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(42, 270);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Seçilen Kitap Adı:";
            // 
            // Okuyucu_listesi_cmbbx
            // 
            this.Okuyucu_listesi_cmbbx.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Okuyucu_listesi_cmbbx.FormattingEnabled = true;
            this.Okuyucu_listesi_cmbbx.Location = new System.Drawing.Point(592, 218);
            this.Okuyucu_listesi_cmbbx.Name = "Okuyucu_listesi_cmbbx";
            this.Okuyucu_listesi_cmbbx.Size = new System.Drawing.Size(297, 24);
            this.Okuyucu_listesi_cmbbx.TabIndex = 8;
            this.Okuyucu_listesi_cmbbx.SelectedIndexChanged += new System.EventHandler(this.ComboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(367, 218);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(207, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Ödünç Verilecek Okuyucu:";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(42, 221);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "Başlangıç Tarihi:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dateTimePicker1.Location = new System.Drawing.Point(215, 218);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(146, 22);
            this.dateTimePicker1.TabIndex = 12;
            // 
            // btn_UpdateFormData
            // 
            this.btn_UpdateFormData.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_UpdateFormData.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_UpdateFormData.ImageKey = "refresh.png";
            this.btn_UpdateFormData.ImageList = this.ımageList1;
            this.btn_UpdateFormData.Location = new System.Drawing.Point(478, 316);
            this.btn_UpdateFormData.Name = "btn_UpdateFormData";
            this.btn_UpdateFormData.Size = new System.Drawing.Size(96, 103);
            this.btn_UpdateFormData.TabIndex = 16;
            this.btn_UpdateFormData.Text = "Güncelle";
            this.btn_UpdateFormData.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_UpdateFormData.UseVisualStyleBackColor = true;
            this.btn_UpdateFormData.Click += new System.EventHandler(this.ButonUpdateFormDataClick);
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button1.ImageKey = "team.png";
            this.button1.ImageList = this.ımageList1;
            this.button1.Location = new System.Drawing.Point(151, 461);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(93, 120);
            this.button1.TabIndex = 15;
            this.button1.Text = "Okuyucular Çıktı Al";
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // ÇıktıAlKitap
            // 
            this.ÇıktıAlKitap.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ÇıktıAlKitap.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.ÇıktıAlKitap.ImageIndex = 8;
            this.ÇıktıAlKitap.ImageList = this.ımageList1;
            this.ÇıktıAlKitap.Location = new System.Drawing.Point(28, 461);
            this.ÇıktıAlKitap.Name = "ÇıktıAlKitap";
            this.ÇıktıAlKitap.Size = new System.Drawing.Size(97, 120);
            this.ÇıktıAlKitap.TabIndex = 14;
            this.ÇıktıAlKitap.Text = "Kitaplar Çıktı Al";
            this.ÇıktıAlKitap.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.ÇıktıAlKitap.UseVisualStyleBackColor = true;
            this.ÇıktıAlKitap.Click += new System.EventHandler(this.ÇıktıAlKitap_Click);
            // 
            // Ödünc_Ver_Bttn
            // 
            this.Ödünc_Ver_Bttn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Ödünc_Ver_Bttn.Image = global::KütüphaneAnaMenü.Properties.Resources.save_disk;
            this.Ödünc_Ver_Bttn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Ödünc_Ver_Bttn.Location = new System.Drawing.Point(931, 218);
            this.Ödünc_Ver_Bttn.Name = "Ödünc_Ver_Bttn";
            this.Ödünc_Ver_Bttn.Size = new System.Drawing.Size(147, 72);
            this.Ödünc_Ver_Bttn.TabIndex = 13;
            this.Ödünc_Ver_Bttn.Text = "Ödünç Ver";
            this.Ödünc_Ver_Bttn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Ödünc_Ver_Bttn.UseVisualStyleBackColor = true;
            this.Ödünc_Ver_Bttn.Click += new System.EventHandler(this.ÖdüncVerButtonClick);
            // 
            // Anamenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1215, 637);
            this.Controls.Add(this.btn_UpdateFormData);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ÇıktıAlKitap);
            this.Controls.Add(this.Ödünc_Ver_Bttn);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.kitap_listesi_cmbbx);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Okuyucu_listesi_cmbbx);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Anamenu";
            this.Text = "Kütüphane";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Anamenu_FormClosing);
            this.Load += new System.EventHandler(this.Anamenu_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btn_KitapEkle;
        private System.Windows.Forms.ToolStripButton btn_okuyucuKayit;
        private System.Windows.Forms.ToolStripButton btn_kitapListesi;
        private System.Windows.Forms.ToolStripButton btn_okuyucular;
        private System.Windows.Forms.ToolStripButton btn_Cikis;
        private System.Windows.Forms.ToolStripButton btn_EmanetListesi;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem hakkındaToolStripMenuItem;
        private System.Windows.Forms.ComboBox kitap_listesi_cmbbx;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox Okuyucu_listesi_cmbbx;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button Ödünc_Ver_Bttn;
        private System.Windows.Forms.Button ÇıktıAlKitap;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_UpdateFormData;
    }
}

