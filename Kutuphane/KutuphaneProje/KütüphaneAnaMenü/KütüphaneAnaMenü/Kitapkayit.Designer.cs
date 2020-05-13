namespace KütüphaneAnaMenü
{
    partial class Kitapkayit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Kitapkayit));
            this.label1 = new System.Windows.Forms.Label();
            this.txt_barkodNo = new System.Windows.Forms.TextBox();
            this.txt_KitapAdi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_YazarAdi = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_YayinEvi = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cmb_Kitaptürü = new System.Windows.Forms.ComboBox();
            this.txt_YayinYili = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dateOfCreated = new System.Windows.Forms.DateTimePicker();
            this.txt_StokSayisi = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.label9 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.barkod_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kitap_adi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yazar_adi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yayin_evi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kitap_turu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yayin_yili = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.olusturulma_tarihi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stok_sayisi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.btn_Kaydet = new System.Windows.Forms.Button();
            this.verigetir = new System.Windows.Forms.Button();
            this.güncelle = new System.Windows.Forms.Button();
            this.ombo_BarkodNo = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.kitapBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kitapBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(86, 123);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Barkod No: *";
            // 
            // txt_barkodNo
            // 
            this.txt_barkodNo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_barkodNo.Location = new System.Drawing.Point(220, 126);
            this.txt_barkodNo.Name = "txt_barkodNo";
            this.txt_barkodNo.Size = new System.Drawing.Size(200, 22);
            this.txt_barkodNo.TabIndex = 1;
            // 
            // txt_KitapAdi
            // 
            this.txt_KitapAdi.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_KitapAdi.Location = new System.Drawing.Point(220, 170);
            this.txt_KitapAdi.Name = "txt_KitapAdi";
            this.txt_KitapAdi.Size = new System.Drawing.Size(200, 22);
            this.txt_KitapAdi.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(86, 167);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Kitap Adı: *";
            // 
            // txt_YazarAdi
            // 
            this.txt_YazarAdi.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_YazarAdi.Location = new System.Drawing.Point(220, 210);
            this.txt_YazarAdi.Name = "txt_YazarAdi";
            this.txt_YazarAdi.Size = new System.Drawing.Size(200, 22);
            this.txt_YazarAdi.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(86, 210);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Yazar Adı: *";
            // 
            // txt_YayinEvi
            // 
            this.txt_YayinEvi.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_YayinEvi.Location = new System.Drawing.Point(220, 256);
            this.txt_YayinEvi.Name = "txt_YayinEvi";
            this.txt_YayinEvi.Size = new System.Drawing.Size(200, 22);
            this.txt_YayinEvi.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(86, 252);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 25);
            this.label4.TabIndex = 6;
            this.label4.Text = "Yayınevi: *";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(86, 297);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(122, 25);
            this.label5.TabIndex = 8;
            this.label5.Text = "Kitap Türü: *";
            // 
            // cmb_Kitaptürü
            // 
            this.cmb_Kitaptürü.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cmb_Kitaptürü.FormattingEnabled = true;
            this.cmb_Kitaptürü.Location = new System.Drawing.Point(220, 297);
            this.cmb_Kitaptürü.Name = "cmb_Kitaptürü";
            this.cmb_Kitaptürü.Size = new System.Drawing.Size(200, 24);
            this.cmb_Kitaptürü.TabIndex = 9;
            this.cmb_Kitaptürü.SelectedIndexChanged += new System.EventHandler(this.Cmb_Kitaptürü_SelectedIndexChanged);
            // 
            // txt_YayinYili
            // 
            this.txt_YayinYili.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_YayinYili.Location = new System.Drawing.Point(220, 350);
            this.txt_YayinYili.Name = "txt_YayinYili";
            this.txt_YayinYili.Size = new System.Drawing.Size(200, 22);
            this.txt_YayinYili.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(86, 347);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 25);
            this.label6.TabIndex = 10;
            this.label6.Text = "Yayın Yılı:";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(86, 399);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(127, 25);
            this.label7.TabIndex = 12;
            this.label7.Text = "Temin Tarihi:";
            // 
            // dateOfCreated
            // 
            this.dateOfCreated.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dateOfCreated.Location = new System.Drawing.Point(220, 401);
            this.dateOfCreated.Name = "dateOfCreated";
            this.dateOfCreated.Size = new System.Drawing.Size(200, 22);
            this.dateOfCreated.TabIndex = 13;
            // 
            // txt_StokSayisi
            // 
            this.txt_StokSayisi.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_StokSayisi.Location = new System.Drawing.Point(220, 452);
            this.txt_StokSayisi.Name = "txt_StokSayisi";
            this.txt_StokSayisi.Size = new System.Drawing.Size(200, 22);
            this.txt_StokSayisi.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(91, 449);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(129, 25);
            this.label8.TabIndex = 14;
            this.label8.Text = "Stok Sayısı: *";
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "Kaydet.jpg");
            this.ımageList1.Images.SetKeyName(1, "Çıkış.png");
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(217, 502);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(193, 17);
            this.label9.TabIndex = 18;
            this.label9.Text = "* Alanlar boş geçilemez...";
            // 
            // linkLabel1
            // 
            this.linkLabel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.BackColor = System.Drawing.SystemColors.Info;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.linkLabel1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.linkLabel1.LinkColor = System.Drawing.Color.DarkBlue;
            this.linkLabel1.Location = new System.Drawing.Point(201, 77);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(135, 29);
            this.linkLabel1.TabIndex = 19;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Kitap Kayıt";
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.barkod_id,
            this.kitap_adi,
            this.yazar_adi,
            this.yayin_evi,
            this.kitap_turu,
            this.yayin_yili,
            this.olusturulma_tarihi,
            this.stok_sayisi});
            this.dataGridView1.Location = new System.Drawing.Point(442, 77);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(748, 473);
            this.dataGridView1.TabIndex = 20;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellContentClick);
            // 
            // barkod_id
            // 
            this.barkod_id.DataPropertyName = "barkod_id";
            this.barkod_id.HeaderText = "Barkod İd";
            this.barkod_id.Name = "barkod_id";
            // 
            // kitap_adi
            // 
            this.kitap_adi.DataPropertyName = "kitap_adi";
            this.kitap_adi.HeaderText = "Kitap Adı";
            this.kitap_adi.Name = "kitap_adi";
            // 
            // yazar_adi
            // 
            this.yazar_adi.DataPropertyName = "yazar_adi";
            this.yazar_adi.HeaderText = "Yazar Adı";
            this.yazar_adi.Name = "yazar_adi";
            // 
            // yayin_evi
            // 
            this.yayin_evi.DataPropertyName = "yayin_evi";
            this.yayin_evi.HeaderText = "Yayın Evi";
            this.yayin_evi.Name = "yayin_evi";
            // 
            // kitap_turu
            // 
            this.kitap_turu.DataPropertyName = "kitap_turu";
            this.kitap_turu.HeaderText = "Kitap Türü";
            this.kitap_turu.Name = "kitap_turu";
            // 
            // yayin_yili
            // 
            this.yayin_yili.DataPropertyName = "yayin_yili";
            this.yayin_yili.HeaderText = "Yayın Yılı";
            this.yayin_yili.Name = "yayin_yili";
            // 
            // olusturulma_tarihi
            // 
            this.olusturulma_tarihi.DataPropertyName = "olusturulma_tarihi";
            this.olusturulma_tarihi.HeaderText = "Oluşturulma Tarihi";
            this.olusturulma_tarihi.Name = "olusturulma_tarihi";
            // 
            // stok_sayisi
            // 
            this.stok_sayisi.DataPropertyName = "stok_sayisi";
            this.stok_sayisi.HeaderText = "Stok Sayısı";
            this.stok_sayisi.Name = "stok_sayisi";
            // 
            // btn_Exit
            // 
            this.btn_Exit.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_Exit.Image = global::KütüphaneAnaMenü.Properties.Resources.icon;
            this.btn_Exit.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_Exit.Location = new System.Drawing.Point(326, 595);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(94, 67);
            this.btn_Exit.TabIndex = 17;
            this.btn_Exit.Text = "Çıkış";
            this.btn_Exit.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_Exit.UseVisualStyleBackColor = true;
            this.btn_Exit.Click += new System.EventHandler(this.ButonCikisClick);
            // 
            // btn_Kaydet
            // 
            this.btn_Kaydet.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_Kaydet.Image = global::KütüphaneAnaMenü.Properties.Resources.save_disk;
            this.btn_Kaydet.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_Kaydet.Location = new System.Drawing.Point(163, 595);
            this.btn_Kaydet.Name = "btn_Kaydet";
            this.btn_Kaydet.Size = new System.Drawing.Size(94, 67);
            this.btn_Kaydet.TabIndex = 16;
            this.btn_Kaydet.Text = "Kaydet";
            this.btn_Kaydet.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_Kaydet.UseVisualStyleBackColor = true;
            this.btn_Kaydet.Click += new System.EventHandler(this.ButonKaydetClick);
            // 
            // verigetir
            // 
            this.verigetir.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.verigetir.Location = new System.Drawing.Point(163, 724);
            this.verigetir.Name = "verigetir";
            this.verigetir.Size = new System.Drawing.Size(92, 57);
            this.verigetir.TabIndex = 21;
            this.verigetir.Text = "Verileri Getir";
            this.verigetir.UseVisualStyleBackColor = true;
            this.verigetir.Click += new System.EventHandler(this.Button1_Click);
            // 
            // güncelle
            // 
            this.güncelle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.güncelle.Location = new System.Drawing.Point(325, 724);
            this.güncelle.Name = "güncelle";
            this.güncelle.Size = new System.Drawing.Size(94, 57);
            this.güncelle.TabIndex = 23;
            this.güncelle.Text = "Güncelle";
            this.güncelle.UseVisualStyleBackColor = true;
            this.güncelle.Click += new System.EventHandler(this.Button2_Click);
            // 
            // ombo_BarkodNo
            // 
            this.ombo_BarkodNo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ombo_BarkodNo.FormattingEnabled = true;
            this.ombo_BarkodNo.Location = new System.Drawing.Point(162, 684);
            this.ombo_BarkodNo.Name = "ombo_BarkodNo";
            this.ombo_BarkodNo.Size = new System.Drawing.Size(257, 24);
            this.ombo_BarkodNo.TabIndex = 24;
            this.ombo_BarkodNo.SelectedIndexChanged += new System.EventHandler(this.Ombo_BarkodNo_SelectedIndexChanged);
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(165, 565);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(254, 17);
            this.label10.TabIndex = 25;
            this.label10.Text = "Barkod Numarası Yanlış Girilemez";
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(66, 687);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(79, 17);
            this.label11.TabIndex = 26;
            this.label11.Text = "Barkod No:";
            // 
            // kitapBindingSource
            // 
            this.kitapBindingSource.DataSource = typeof(KütüphaneAnaMenü.Kitap);
            // 
            // Kitapkayit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1228, 817);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.ombo_BarkodNo);
            this.Controls.Add(this.güncelle);
            this.Controls.Add(this.verigetir);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btn_Exit);
            this.Controls.Add(this.btn_Kaydet);
            this.Controls.Add(this.txt_StokSayisi);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dateOfCreated);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txt_YayinYili);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cmb_Kitaptürü);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_YayinEvi);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_YazarAdi);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_KitapAdi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_barkodNo);
            this.Controls.Add(this.label1);
            this.Name = "Kitapkayit";
            this.Text = "Kitap Kayıt";
            this.Load += new System.EventHandler(this.KitapKayitLoad);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kitapBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_barkodNo;
        private System.Windows.Forms.TextBox txt_KitapAdi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_YazarAdi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_YayinEvi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmb_Kitaptürü;
        private System.Windows.Forms.TextBox txt_YayinYili;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dateOfCreated;
        private System.Windows.Forms.TextBox txt_StokSayisi;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btn_Kaydet;
        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.Button btn_Exit;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn barkod_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn kitap_adi;
        private System.Windows.Forms.DataGridViewTextBoxColumn yazar_adi;
        private System.Windows.Forms.DataGridViewTextBoxColumn yayin_evi;
        private System.Windows.Forms.DataGridViewTextBoxColumn kitap_turu;
        private System.Windows.Forms.DataGridViewTextBoxColumn yayin_yili;
        private System.Windows.Forms.DataGridViewTextBoxColumn olusturulma_tarihi;
        private System.Windows.Forms.DataGridViewTextBoxColumn stok_sayisi;
        private System.Windows.Forms.BindingSource kitapBindingSource;
        private System.Windows.Forms.Button verigetir;
        private System.Windows.Forms.Button güncelle;
        private System.Windows.Forms.ComboBox ombo_BarkodNo;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
    }
}