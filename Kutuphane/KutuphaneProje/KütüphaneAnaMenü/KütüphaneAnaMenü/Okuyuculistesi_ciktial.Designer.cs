namespace KütüphaneAnaMenü
{
    partial class Okuyuculistesi_ciktial
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Okuyuculistesi_ciktial));
            this.labelsayfasayisi = new System.Windows.Forms.Label();
            this.lbl_sayfasayisi = new System.Windows.Forms.Label();
            this.btn_ileri = new System.Windows.Forms.Button();
            this.btn_geri = new System.Windows.Forms.Button();
            this.dataGridView1_okuyuculist = new System.Windows.Forms.DataGridView();
            this.okuyucuRefnoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tckimlikDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adiSoyadiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sinifiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nosuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dogumTarihiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dogumYeriDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.epostaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uyelikTarihiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cinsiyetDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adresDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emanetSayisiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.okuyucuBilgisiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.Btn_yazdir_okuyuculist = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1_okuyuculist)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.okuyucuBilgisiBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // labelsayfasayisi
            // 
            this.labelsayfasayisi.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelsayfasayisi.AutoSize = true;
            this.labelsayfasayisi.Location = new System.Drawing.Point(822, 694);
            this.labelsayfasayisi.Name = "labelsayfasayisi";
            this.labelsayfasayisi.Size = new System.Drawing.Size(46, 17);
            this.labelsayfasayisi.TabIndex = 11;
            this.labelsayfasayisi.Text = "label1";
            // 
            // lbl_sayfasayisi
            // 
            this.lbl_sayfasayisi.AutoSize = true;
            this.lbl_sayfasayisi.Location = new System.Drawing.Point(561, 473);
            this.lbl_sayfasayisi.Name = "lbl_sayfasayisi";
            this.lbl_sayfasayisi.Size = new System.Drawing.Size(0, 17);
            this.lbl_sayfasayisi.TabIndex = 10;
            // 
            // btn_ileri
            // 
            this.btn_ileri.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_ileri.Location = new System.Drawing.Point(912, 687);
            this.btn_ileri.Name = "btn_ileri";
            this.btn_ileri.Size = new System.Drawing.Size(95, 30);
            this.btn_ileri.TabIndex = 9;
            this.btn_ileri.Text = ">";
            this.btn_ileri.UseVisualStyleBackColor = true;
            this.btn_ileri.Click += new System.EventHandler(this.ButonIleriClick);
            // 
            // btn_geri
            // 
            this.btn_geri.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_geri.Location = new System.Drawing.Point(692, 687);
            this.btn_geri.Name = "btn_geri";
            this.btn_geri.Size = new System.Drawing.Size(92, 30);
            this.btn_geri.TabIndex = 8;
            this.btn_geri.Text = "<";
            this.btn_geri.UseVisualStyleBackColor = true;
            this.btn_geri.Click += new System.EventHandler(this.ButonGeriClick);
            // 
            // dataGridView1_okuyuculist
            // 
            this.dataGridView1_okuyuculist.AllowUserToAddRows = false;
            this.dataGridView1_okuyuculist.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1_okuyuculist.AutoGenerateColumns = false;
            this.dataGridView1_okuyuculist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1_okuyuculist.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.okuyucuRefnoDataGridViewTextBoxColumn,
            this.tckimlikDataGridViewTextBoxColumn,
            this.adiSoyadiDataGridViewTextBoxColumn,
            this.sinifiDataGridViewTextBoxColumn,
            this.nosuDataGridViewTextBoxColumn,
            this.dogumTarihiDataGridViewTextBoxColumn,
            this.dogumYeriDataGridViewTextBoxColumn,
            this.telefonDataGridViewTextBoxColumn,
            this.epostaDataGridViewTextBoxColumn,
            this.uyelikTarihiDataGridViewTextBoxColumn,
            this.cinsiyetDataGridViewTextBoxColumn,
            this.adresDataGridViewTextBoxColumn,
            this.emanetSayisiDataGridViewTextBoxColumn});
            this.dataGridView1_okuyuculist.DataSource = this.okuyucuBilgisiBindingSource;
            this.dataGridView1_okuyuculist.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1_okuyuculist.Name = "dataGridView1_okuyuculist";
            this.dataGridView1_okuyuculist.ReadOnly = true;
            this.dataGridView1_okuyuculist.RowTemplate.Height = 24;
            this.dataGridView1_okuyuculist.Size = new System.Drawing.Size(1160, 647);
            this.dataGridView1_okuyuculist.TabIndex = 6;
            this.dataGridView1_okuyuculist.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_okuyuculist_CellContentClick);
            // 
            // okuyucuRefnoDataGridViewTextBoxColumn
            // 
            this.okuyucuRefnoDataGridViewTextBoxColumn.DataPropertyName = "Okuyucu_Refno";
            this.okuyucuRefnoDataGridViewTextBoxColumn.HeaderText = "OkuyucuRefNo";
            this.okuyucuRefnoDataGridViewTextBoxColumn.Name = "okuyucuRefnoDataGridViewTextBoxColumn";
            this.okuyucuRefnoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tckimlikDataGridViewTextBoxColumn
            // 
            this.tckimlikDataGridViewTextBoxColumn.DataPropertyName = "Tckimlik";
            this.tckimlikDataGridViewTextBoxColumn.HeaderText = "TC Kimlik";
            this.tckimlikDataGridViewTextBoxColumn.Name = "tckimlikDataGridViewTextBoxColumn";
            this.tckimlikDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // adiSoyadiDataGridViewTextBoxColumn
            // 
            this.adiSoyadiDataGridViewTextBoxColumn.DataPropertyName = "Adi_Soyadi";
            this.adiSoyadiDataGridViewTextBoxColumn.HeaderText = "Adı Soyadı";
            this.adiSoyadiDataGridViewTextBoxColumn.Name = "adiSoyadiDataGridViewTextBoxColumn";
            this.adiSoyadiDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sinifiDataGridViewTextBoxColumn
            // 
            this.sinifiDataGridViewTextBoxColumn.DataPropertyName = "Sinifi";
            this.sinifiDataGridViewTextBoxColumn.HeaderText = "Sınıfı";
            this.sinifiDataGridViewTextBoxColumn.Name = "sinifiDataGridViewTextBoxColumn";
            this.sinifiDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nosuDataGridViewTextBoxColumn
            // 
            this.nosuDataGridViewTextBoxColumn.DataPropertyName = "Nosu";
            this.nosuDataGridViewTextBoxColumn.HeaderText = "No";
            this.nosuDataGridViewTextBoxColumn.Name = "nosuDataGridViewTextBoxColumn";
            this.nosuDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dogumTarihiDataGridViewTextBoxColumn
            // 
            this.dogumTarihiDataGridViewTextBoxColumn.DataPropertyName = "Dogum_Tarihi";
            this.dogumTarihiDataGridViewTextBoxColumn.HeaderText = "Doğum Tarihi";
            this.dogumTarihiDataGridViewTextBoxColumn.Name = "dogumTarihiDataGridViewTextBoxColumn";
            this.dogumTarihiDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dogumYeriDataGridViewTextBoxColumn
            // 
            this.dogumYeriDataGridViewTextBoxColumn.DataPropertyName = "Dogum_Yeri";
            this.dogumYeriDataGridViewTextBoxColumn.HeaderText = "Doğum Yeri";
            this.dogumYeriDataGridViewTextBoxColumn.Name = "dogumYeriDataGridViewTextBoxColumn";
            this.dogumYeriDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // telefonDataGridViewTextBoxColumn
            // 
            this.telefonDataGridViewTextBoxColumn.DataPropertyName = "Telefon";
            this.telefonDataGridViewTextBoxColumn.HeaderText = "Telefon";
            this.telefonDataGridViewTextBoxColumn.Name = "telefonDataGridViewTextBoxColumn";
            this.telefonDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // epostaDataGridViewTextBoxColumn
            // 
            this.epostaDataGridViewTextBoxColumn.DataPropertyName = "Eposta";
            this.epostaDataGridViewTextBoxColumn.HeaderText = "Eposta";
            this.epostaDataGridViewTextBoxColumn.Name = "epostaDataGridViewTextBoxColumn";
            this.epostaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // uyelikTarihiDataGridViewTextBoxColumn
            // 
            this.uyelikTarihiDataGridViewTextBoxColumn.DataPropertyName = "uyelik_Tarihi";
            this.uyelikTarihiDataGridViewTextBoxColumn.HeaderText = "Üyelik Tarihi";
            this.uyelikTarihiDataGridViewTextBoxColumn.Name = "uyelikTarihiDataGridViewTextBoxColumn";
            this.uyelikTarihiDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cinsiyetDataGridViewTextBoxColumn
            // 
            this.cinsiyetDataGridViewTextBoxColumn.DataPropertyName = "Cinsiyet";
            this.cinsiyetDataGridViewTextBoxColumn.HeaderText = "Cinsiyet";
            this.cinsiyetDataGridViewTextBoxColumn.Name = "cinsiyetDataGridViewTextBoxColumn";
            this.cinsiyetDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // adresDataGridViewTextBoxColumn
            // 
            this.adresDataGridViewTextBoxColumn.DataPropertyName = "Adres";
            this.adresDataGridViewTextBoxColumn.HeaderText = "Adres";
            this.adresDataGridViewTextBoxColumn.Name = "adresDataGridViewTextBoxColumn";
            this.adresDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // emanetSayisiDataGridViewTextBoxColumn
            // 
            this.emanetSayisiDataGridViewTextBoxColumn.DataPropertyName = "Emanet_Sayisi";
            this.emanetSayisiDataGridViewTextBoxColumn.HeaderText = "Emanet Sayısı";
            this.emanetSayisiDataGridViewTextBoxColumn.Name = "emanetSayisiDataGridViewTextBoxColumn";
            this.emanetSayisiDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // okuyucuBilgisiBindingSource
            // 
            this.okuyucuBilgisiBindingSource.DataSource = typeof(KütüphaneAnaMenü.OkuyucuBilgisi);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Text = "Baskı önizleme";
            this.printPreviewDialog1.Visible = false;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // Btn_yazdir_okuyuculist
            // 
            this.Btn_yazdir_okuyuculist.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Btn_yazdir_okuyuculist.Image = global::KütüphaneAnaMenü.Properties.Resources.printer;
            this.Btn_yazdir_okuyuculist.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Btn_yazdir_okuyuculist.Location = new System.Drawing.Point(1049, 679);
            this.Btn_yazdir_okuyuculist.Name = "Btn_yazdir_okuyuculist";
            this.Btn_yazdir_okuyuculist.Size = new System.Drawing.Size(85, 75);
            this.Btn_yazdir_okuyuculist.TabIndex = 7;
            this.Btn_yazdir_okuyuculist.Text = "Yazdır";
            this.Btn_yazdir_okuyuculist.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_yazdir_okuyuculist.UseVisualStyleBackColor = true;
            this.Btn_yazdir_okuyuculist.Click += new System.EventHandler(this.ButonYazdirOkuyucuListClick);
            // 
            // Okuyuculistesi_ciktial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1189, 799);
            this.Controls.Add(this.labelsayfasayisi);
            this.Controls.Add(this.lbl_sayfasayisi);
            this.Controls.Add(this.btn_ileri);
            this.Controls.Add(this.btn_geri);
            this.Controls.Add(this.Btn_yazdir_okuyuculist);
            this.Controls.Add(this.dataGridView1_okuyuculist);
            this.Name = "Okuyuculistesi_ciktial";
            this.Text = "Okuyucu Listesi Çıktı Al";
            this.Load += new System.EventHandler(this.OkuyucuListesiCiktiAlLoad);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1_okuyuculist)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.okuyucuBilgisiBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelsayfasayisi;
        private System.Windows.Forms.Label lbl_sayfasayisi;
        private System.Windows.Forms.Button btn_ileri;
        private System.Windows.Forms.Button btn_geri;
        private System.Windows.Forms.Button Btn_yazdir_okuyuculist;
        private System.Windows.Forms.DataGridView dataGridView1_okuyuculist;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.BindingSource okuyucuBilgisiBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn okuyucuRefnoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tckimlikDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adiSoyadiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sinifiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nosuDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dogumTarihiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dogumYeriDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefonDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn epostaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn uyelikTarihiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cinsiyetDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adresDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emanetSayisiDataGridViewTextBoxColumn;
    }
}