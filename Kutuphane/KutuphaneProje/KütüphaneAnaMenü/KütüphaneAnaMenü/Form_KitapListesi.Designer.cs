namespace KütüphaneAnaMenü
{
    partial class Form_kitapListesi
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.barkod_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kitap_adi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yazar_adi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yayin_evi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kitap_turu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yayin_yili = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.olusturulma_tarihi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stok_sayisi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ara = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.cmbbx_kitaplar = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonAra = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
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
            this.dataGridView1.Location = new System.Drawing.Point(29, 281);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1217, 222);
            this.dataGridView1.TabIndex = 0;
            // 
            // barkod_id
            // 
            this.barkod_id.DataPropertyName = "barkod_id";
            this.barkod_id.HeaderText = "Barkod İd";
            this.barkod_id.Name = "barkod_id";
            this.barkod_id.Width = 90;
            // 
            // kitap_adi
            // 
            this.kitap_adi.DataPropertyName = "kitap_adi";
            this.kitap_adi.HeaderText = "Kitap Adı";
            this.kitap_adi.Name = "kitap_adi";
            this.kitap_adi.Width = 86;
            // 
            // yazar_adi
            // 
            this.yazar_adi.DataPropertyName = "yazar_adi";
            this.yazar_adi.HeaderText = "Yazar Adı";
            this.yazar_adi.Name = "yazar_adi";
            this.yazar_adi.Width = 91;
            // 
            // yayin_evi
            // 
            this.yayin_evi.DataPropertyName = "yayin_evi";
            this.yayin_evi.HeaderText = "Yayınevi";
            this.yayin_evi.Name = "yayin_evi";
            this.yayin_evi.Width = 90;
            // 
            // kitap_turu
            // 
            this.kitap_turu.DataPropertyName = "kitap_turu";
            this.kitap_turu.HeaderText = "Kitap Türü";
            this.kitap_turu.Name = "kitap_turu";
            this.kitap_turu.Width = 95;
            // 
            // yayin_yili
            // 
            this.yayin_yili.DataPropertyName = "yayin_yili";
            this.yayin_yili.HeaderText = "Yayın Yılı";
            this.yayin_yili.Name = "yayin_yili";
            this.yayin_yili.Width = 87;
            // 
            // olusturulma_tarihi
            // 
            this.olusturulma_tarihi.DataPropertyName = "olusturulma_tarihi";
            this.olusturulma_tarihi.HeaderText = "Oluşturulma Tarihi";
            this.olusturulma_tarihi.Name = "olusturulma_tarihi";
            this.olusturulma_tarihi.Width = 140;
            // 
            // stok_sayisi
            // 
            this.stok_sayisi.DataPropertyName = "stok_sayisi";
            this.stok_sayisi.HeaderText = "Stok Sayısı";
            this.stok_sayisi.Name = "stok_sayisi";
            this.stok_sayisi.Width = 98;
            // 
            // ara
            // 
            this.ara.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.ara.AutoSize = true;
            this.ara.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ara.Location = new System.Drawing.Point(198, 97);
            this.ara.Name = "ara";
            this.ara.Size = new System.Drawing.Size(73, 29);
            this.ara.TabIndex = 1;
            this.ara.Text = "Ara : ";
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.textBox1.Location = new System.Drawing.Point(304, 101);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(269, 22);
            this.textBox1.TabIndex = 2;
            // 
            // cmbbx_kitaplar
            // 
            this.cmbbx_kitaplar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.cmbbx_kitaplar.FormattingEnabled = true;
            this.cmbbx_kitaplar.Location = new System.Drawing.Point(797, 102);
            this.cmbbx_kitaplar.Name = "cmbbx_kitaplar";
            this.cmbbx_kitaplar.Size = new System.Drawing.Size(274, 24);
            this.cmbbx_kitaplar.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(718, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 29);
            this.label1.TabIndex = 11;
            this.label1.Text = "Sil: ";
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.Image = global::KütüphaneAnaMenü.Properties.Resources.garbage;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button1.Location = new System.Drawing.Point(999, 143);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(72, 73);
            this.button1.TabIndex = 12;
            this.button1.Text = "Sil";
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // buttonAra
            // 
            this.buttonAra.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonAra.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonAra.Image = global::KütüphaneAnaMenü.Properties.Resources.search;
            this.buttonAra.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonAra.Location = new System.Drawing.Point(493, 143);
            this.buttonAra.Name = "buttonAra";
            this.buttonAra.Size = new System.Drawing.Size(80, 73);
            this.buttonAra.TabIndex = 3;
            this.buttonAra.Text = "Ara";
            this.buttonAra.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonAra.UseVisualStyleBackColor = false;
            this.buttonAra.Click += new System.EventHandler(this.ButtonAra_Click);
            // 
            // form_kitapListesi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1258, 515);
            this.Controls.Add(this.cmbbx_kitaplar);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonAra);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.ara);
            this.Controls.Add(this.dataGridView1);
            this.Name = "form_kitapListesi";
            this.Text = "Kitap Listesi";
            this.Load += new System.EventHandler(this.Form_kitapListesi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label ara;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button buttonAra;
        private System.Windows.Forms.ComboBox cmbbx_kitaplar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn barkod_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn kitap_adi;
        private System.Windows.Forms.DataGridViewTextBoxColumn yazar_adi;
        private System.Windows.Forms.DataGridViewTextBoxColumn yayin_evi;
        private System.Windows.Forms.DataGridViewTextBoxColumn kitap_turu;
        private System.Windows.Forms.DataGridViewTextBoxColumn yayin_yili;
        private System.Windows.Forms.DataGridViewTextBoxColumn olusturulma_tarihi;
        private System.Windows.Forms.DataGridViewTextBoxColumn stok_sayisi;
    }
}