namespace KütüphaneAnaMenü
{
    partial class Kitaplistesi_ciktial
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Kitaplistesi_ciktial));
            this.dataGridView1_KitapListesi = new System.Windows.Forms.DataGridView();
            this.barkodidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kitapadiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yazaradiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yayineviDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kitapturuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yayinyiliDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.olusturulmatarihiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stoksayisiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kitapBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.btn_geri = new System.Windows.Forms.Button();
            this.btn_ileri = new System.Windows.Forms.Button();
            this.lbl_sayfasayisi = new System.Windows.Forms.Label();
            this.labelsayfasayisi = new System.Windows.Forms.Label();
            this.Btn_yazdir_kitaplist = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1_KitapListesi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kitapBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1_KitapListesi
            // 
            this.dataGridView1_KitapListesi.AllowUserToAddRows = false;
            this.dataGridView1_KitapListesi.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1_KitapListesi.AutoGenerateColumns = false;
            this.dataGridView1_KitapListesi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1_KitapListesi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.barkodidDataGridViewTextBoxColumn,
            this.kitapadiDataGridViewTextBoxColumn,
            this.yazaradiDataGridViewTextBoxColumn,
            this.yayineviDataGridViewTextBoxColumn,
            this.kitapturuDataGridViewTextBoxColumn,
            this.yayinyiliDataGridViewTextBoxColumn,
            this.olusturulmatarihiDataGridViewTextBoxColumn,
            this.stoksayisiDataGridViewTextBoxColumn});
            this.dataGridView1_KitapListesi.DataSource = this.kitapBindingSource;
            this.dataGridView1_KitapListesi.Location = new System.Drawing.Point(2, 12);
            this.dataGridView1_KitapListesi.Name = "dataGridView1_KitapListesi";
            this.dataGridView1_KitapListesi.RowHeadersWidth = 51;
            this.dataGridView1_KitapListesi.RowTemplate.Height = 24;
            this.dataGridView1_KitapListesi.Size = new System.Drawing.Size(1088, 660);
            this.dataGridView1_KitapListesi.TabIndex = 0;
            this.dataGridView1_KitapListesi.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_KitapListesi_CellContentClick);
            // 
            // barkodidDataGridViewTextBoxColumn
            // 
            this.barkodidDataGridViewTextBoxColumn.DataPropertyName = "barkod_id";
            this.barkodidDataGridViewTextBoxColumn.HeaderText = "Barkod İd";
            this.barkodidDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.barkodidDataGridViewTextBoxColumn.Name = "barkodidDataGridViewTextBoxColumn";
            this.barkodidDataGridViewTextBoxColumn.Width = 125;
            // 
            // kitapadiDataGridViewTextBoxColumn
            // 
            this.kitapadiDataGridViewTextBoxColumn.DataPropertyName = "kitap_adi";
            this.kitapadiDataGridViewTextBoxColumn.HeaderText = "Kitap Adı";
            this.kitapadiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.kitapadiDataGridViewTextBoxColumn.Name = "kitapadiDataGridViewTextBoxColumn";
            this.kitapadiDataGridViewTextBoxColumn.Width = 125;
            // 
            // yazaradiDataGridViewTextBoxColumn
            // 
            this.yazaradiDataGridViewTextBoxColumn.DataPropertyName = "yazar_adi";
            this.yazaradiDataGridViewTextBoxColumn.HeaderText = "Yazar Adı";
            this.yazaradiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.yazaradiDataGridViewTextBoxColumn.Name = "yazaradiDataGridViewTextBoxColumn";
            this.yazaradiDataGridViewTextBoxColumn.Width = 125;
            // 
            // yayineviDataGridViewTextBoxColumn
            // 
            this.yayineviDataGridViewTextBoxColumn.DataPropertyName = "yayin_evi";
            this.yayineviDataGridViewTextBoxColumn.HeaderText = "Yayın Evi";
            this.yayineviDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.yayineviDataGridViewTextBoxColumn.Name = "yayineviDataGridViewTextBoxColumn";
            this.yayineviDataGridViewTextBoxColumn.Width = 125;
            // 
            // kitapturuDataGridViewTextBoxColumn
            // 
            this.kitapturuDataGridViewTextBoxColumn.DataPropertyName = "kitap_turu";
            this.kitapturuDataGridViewTextBoxColumn.HeaderText = "Kitap Türü";
            this.kitapturuDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.kitapturuDataGridViewTextBoxColumn.Name = "kitapturuDataGridViewTextBoxColumn";
            this.kitapturuDataGridViewTextBoxColumn.Width = 125;
            // 
            // yayinyiliDataGridViewTextBoxColumn
            // 
            this.yayinyiliDataGridViewTextBoxColumn.DataPropertyName = "yayin_yili";
            this.yayinyiliDataGridViewTextBoxColumn.HeaderText = "Yayın Yılı";
            this.yayinyiliDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.yayinyiliDataGridViewTextBoxColumn.Name = "yayinyiliDataGridViewTextBoxColumn";
            this.yayinyiliDataGridViewTextBoxColumn.Width = 125;
            // 
            // olusturulmatarihiDataGridViewTextBoxColumn
            // 
            this.olusturulmatarihiDataGridViewTextBoxColumn.DataPropertyName = "olusturulma_tarihi";
            this.olusturulmatarihiDataGridViewTextBoxColumn.HeaderText = "Oluşturulma Tarihi";
            this.olusturulmatarihiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.olusturulmatarihiDataGridViewTextBoxColumn.Name = "olusturulmatarihiDataGridViewTextBoxColumn";
            this.olusturulmatarihiDataGridViewTextBoxColumn.Width = 125;
            // 
            // stoksayisiDataGridViewTextBoxColumn
            // 
            this.stoksayisiDataGridViewTextBoxColumn.DataPropertyName = "stok_sayisi";
            this.stoksayisiDataGridViewTextBoxColumn.HeaderText = "Stok Sayısı";
            this.stoksayisiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.stoksayisiDataGridViewTextBoxColumn.Name = "stoksayisiDataGridViewTextBoxColumn";
            this.stoksayisiDataGridViewTextBoxColumn.Width = 125;
            // 
            // kitapBindingSource
            // 
            this.kitapBindingSource.DataSource = typeof(KütüphaneAnaMenü.Kitap);
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.PrintDocument1_PrintPage);
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
            // btn_geri
            // 
            this.btn_geri.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_geri.Location = new System.Drawing.Point(619, 678);
            this.btn_geri.Name = "btn_geri";
            this.btn_geri.Size = new System.Drawing.Size(92, 30);
            this.btn_geri.TabIndex = 2;
            this.btn_geri.Text = "<";
            this.btn_geri.UseVisualStyleBackColor = true;
            this.btn_geri.Click += new System.EventHandler(this.ButonGeriClick);
            // 
            // btn_ileri
            // 
            this.btn_ileri.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_ileri.Location = new System.Drawing.Point(839, 678);
            this.btn_ileri.Name = "btn_ileri";
            this.btn_ileri.Size = new System.Drawing.Size(95, 30);
            this.btn_ileri.TabIndex = 3;
            this.btn_ileri.Text = ">";
            this.btn_ileri.UseVisualStyleBackColor = true;
            this.btn_ileri.Click += new System.EventHandler(this.ButonIleriClick);
            // 
            // lbl_sayfasayisi
            // 
            this.lbl_sayfasayisi.AutoSize = true;
            this.lbl_sayfasayisi.Location = new System.Drawing.Point(651, 500);
            this.lbl_sayfasayisi.Name = "lbl_sayfasayisi";
            this.lbl_sayfasayisi.Size = new System.Drawing.Size(0, 17);
            this.lbl_sayfasayisi.TabIndex = 4;
            // 
            // labelsayfasayisi
            // 
            this.labelsayfasayisi.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelsayfasayisi.AutoSize = true;
            this.labelsayfasayisi.Location = new System.Drawing.Point(749, 685);
            this.labelsayfasayisi.Name = "labelsayfasayisi";
            this.labelsayfasayisi.Size = new System.Drawing.Size(46, 17);
            this.labelsayfasayisi.TabIndex = 5;
            this.labelsayfasayisi.Text = "label1";
            // 
            // Btn_yazdir_kitaplist
            // 
            this.Btn_yazdir_kitaplist.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Btn_yazdir_kitaplist.Image = global::KütüphaneAnaMenü.Properties.Resources.printer;
            this.Btn_yazdir_kitaplist.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Btn_yazdir_kitaplist.Location = new System.Drawing.Point(979, 678);
            this.Btn_yazdir_kitaplist.Name = "Btn_yazdir_kitaplist";
            this.Btn_yazdir_kitaplist.Size = new System.Drawing.Size(83, 77);
            this.Btn_yazdir_kitaplist.TabIndex = 1;
            this.Btn_yazdir_kitaplist.Text = "Yazdır";
            this.Btn_yazdir_kitaplist.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_yazdir_kitaplist.UseVisualStyleBackColor = true;
            this.Btn_yazdir_kitaplist.Click += new System.EventHandler(this.ButonYazdirKitaplistClick);
            // 
            // Kitaplistesi_ciktial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1153, 782);
            this.Controls.Add(this.labelsayfasayisi);
            this.Controls.Add(this.lbl_sayfasayisi);
            this.Controls.Add(this.btn_ileri);
            this.Controls.Add(this.btn_geri);
            this.Controls.Add(this.Btn_yazdir_kitaplist);
            this.Controls.Add(this.dataGridView1_KitapListesi);
            this.Name = "Kitaplistesi_ciktial";
            this.Text = "Kitap Listesi Çıktı Al";
            this.Load += new System.EventHandler(this.CiktiAlFormLoad);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1_KitapListesi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kitapBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1_KitapListesi;
        private System.Windows.Forms.Button Btn_yazdir_kitaplist;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.BindingSource kitapBindingSource;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.Button btn_geri;
        private System.Windows.Forms.Button btn_ileri;
        private System.Windows.Forms.Label lbl_sayfasayisi;
        private System.Windows.Forms.Label labelsayfasayisi;
        private System.Windows.Forms.DataGridViewTextBoxColumn barkodidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kitapadiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yazaradiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yayineviDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kitapturuDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yayinyiliDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn olusturulmatarihiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stoksayisiDataGridViewTextBoxColumn;
    }
}