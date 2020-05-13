namespace KütüphaneAnaMenü
{
    partial class form_Okuyucular
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_Okuyucular));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Okuyucu_Refno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tckimlik = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Adi_Soyadi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sinifi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nosu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dogum_Tarihi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dogum_Yeri = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Telefon = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Eposta = new System.Windows.Forms.DataGridViewButtonColumn();
            this.uyelik_Tarihi = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Cinsiyet = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Adres = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Emanet_Sayisi = new System.Windows.Forms.DataGridViewButtonColumn();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Lbl_ara = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbbx_okuyucular = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.buttonArama = new System.Windows.Forms.Button();
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
            this.Okuyucu_Refno,
            this.Tckimlik,
            this.Adi_Soyadi,
            this.Sinifi,
            this.Nosu,
            this.Dogum_Tarihi,
            this.Dogum_Yeri,
            this.Telefon,
            this.Eposta,
            this.uyelik_Tarihi,
            this.Cinsiyet,
            this.Adres,
            this.Emanet_Sayisi});
            this.dataGridView1.Location = new System.Drawing.Point(0, 205);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1233, 275);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellContentClick_1);
            // 
            // Okuyucu_Refno
            // 
            this.Okuyucu_Refno.DataPropertyName = "Okuyucu_Refno";
            this.Okuyucu_Refno.HeaderText = "OkuyucuRefNo";
            this.Okuyucu_Refno.Name = "Okuyucu_Refno";
            this.Okuyucu_Refno.Width = 133;
            // 
            // Tckimlik
            // 
            this.Tckimlik.DataPropertyName = "Tckimlik";
            this.Tckimlik.HeaderText = "TC Kimlik";
            this.Tckimlik.Name = "Tckimlik";
            this.Tckimlik.Width = 95;
            // 
            // Adi_Soyadi
            // 
            this.Adi_Soyadi.DataPropertyName = "Adi_Soyadi";
            this.Adi_Soyadi.HeaderText = "Adı Soyadı";
            this.Adi_Soyadi.Name = "Adi_Soyadi";
            this.Adi_Soyadi.Width = 104;
            // 
            // Sinifi
            // 
            this.Sinifi.DataPropertyName = "Sinifi";
            this.Sinifi.HeaderText = "Sınıf";
            this.Sinifi.Name = "Sinifi";
            this.Sinifi.Width = 64;
            // 
            // Nosu
            // 
            this.Nosu.DataPropertyName = "Nosu";
            this.Nosu.HeaderText = "No";
            this.Nosu.Name = "Nosu";
            this.Nosu.Width = 55;
            // 
            // Dogum_Tarihi
            // 
            this.Dogum_Tarihi.DataPropertyName = "Dogum_Tarihi";
            this.Dogum_Tarihi.HeaderText = "Doğum Tarihi";
            this.Dogum_Tarihi.Name = "Dogum_Tarihi";
            this.Dogum_Tarihi.Width = 122;
            // 
            // Dogum_Yeri
            // 
            this.Dogum_Yeri.DataPropertyName = "Dogum_Yeri";
            this.Dogum_Yeri.HeaderText = "Doğum Yeri";
            this.Dogum_Yeri.Name = "Dogum_Yeri";
            this.Dogum_Yeri.Width = 88;
            // 
            // Telefon
            // 
            this.Telefon.DataPropertyName = "Telefon";
            this.Telefon.HeaderText = "Telefon";
            this.Telefon.Name = "Telefon";
            this.Telefon.Width = 62;
            // 
            // Eposta
            // 
            this.Eposta.DataPropertyName = "Eposta";
            this.Eposta.HeaderText = "E Posta";
            this.Eposta.Name = "Eposta";
            this.Eposta.Width = 63;
            // 
            // uyelik_Tarihi
            // 
            this.uyelik_Tarihi.DataPropertyName = "uyelik_Tarihi";
            this.uyelik_Tarihi.HeaderText = "Üyelik Tarihi";
            this.uyelik_Tarihi.Name = "uyelik_Tarihi";
            this.uyelik_Tarihi.Width = 92;
            // 
            // Cinsiyet
            // 
            this.Cinsiyet.DataPropertyName = "Cinsiyet";
            this.Cinsiyet.HeaderText = "Cinsiyet";
            this.Cinsiyet.Name = "Cinsiyet";
            this.Cinsiyet.Width = 63;
            // 
            // Adres
            // 
            this.Adres.DataPropertyName = "Adres";
            this.Adres.HeaderText = "Adres";
            this.Adres.Name = "Adres";
            this.Adres.Width = 51;
            // 
            // Emanet_Sayisi
            // 
            this.Emanet_Sayisi.DataPropertyName = "Emanet_Sayisi";
            this.Emanet_Sayisi.HeaderText = "Emanet Sayısı";
            this.Emanet_Sayisi.Name = "Emanet_Sayisi";
            this.Emanet_Sayisi.Width = 103;
            // 
            // textBox1
            // 
            this.textBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBox1.Location = new System.Drawing.Point(304, 52);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(269, 22);
            this.textBox1.TabIndex = 5;
            // 
            // Lbl_ara
            // 
            this.Lbl_ara.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Lbl_ara.AutoSize = true;
            this.Lbl_ara.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Lbl_ara.Location = new System.Drawing.Point(198, 45);
            this.Lbl_ara.Name = "Lbl_ara";
            this.Lbl_ara.Size = new System.Drawing.Size(73, 29);
            this.Lbl_ara.TabIndex = 4;
            this.Lbl_ara.Text = "Ara : ";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(674, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 29);
            this.label1.TabIndex = 7;
            this.label1.Text = "Sil: ";
            // 
            // cmbbx_okuyucular
            // 
            this.cmbbx_okuyucular.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cmbbx_okuyucular.FormattingEnabled = true;
            this.cmbbx_okuyucular.Location = new System.Drawing.Point(751, 48);
            this.cmbbx_okuyucular.Name = "cmbbx_okuyucular";
            this.cmbbx_okuyucular.Size = new System.Drawing.Size(274, 24);
            this.cmbbx_okuyucular.TabIndex = 10;
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button1.ImageKey = "garbage (1).png";
            this.button1.ImageList = this.ımageList1;
            this.button1.Location = new System.Drawing.Point(930, 78);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(95, 86);
            this.button1.TabIndex = 9;
            this.button1.Text = "Sil";
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "garbage (1).png");
            // 
            // buttonArama
            // 
            this.buttonArama.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonArama.BackColor = System.Drawing.SystemColors.Highlight;
            this.buttonArama.Image = global::KütüphaneAnaMenü.Properties.Resources.search;
            this.buttonArama.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonArama.Location = new System.Drawing.Point(484, 84);
            this.buttonArama.Name = "buttonArama";
            this.buttonArama.Size = new System.Drawing.Size(89, 55);
            this.buttonArama.TabIndex = 6;
            this.buttonArama.Text = "Ara";
            this.buttonArama.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonArama.UseVisualStyleBackColor = true;
            this.buttonArama.Click += new System.EventHandler(this.ButtonAra_Click);
            // 
            // form_Okuyucular
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1233, 502);
            this.Controls.Add(this.cmbbx_okuyucular);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonArama);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Lbl_ara);
            this.Controls.Add(this.dataGridView1);
            this.Name = "form_Okuyucular";
            this.Text = "Okuyucu Listesi";
            this.Load += new System.EventHandler(this.Form_Okuyucular_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonArama;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label Lbl_ara;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbbx_okuyucular;
        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Okuyucu_Refno;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tckimlik;
        private System.Windows.Forms.DataGridViewTextBoxColumn Adi_Soyadi;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sinifi;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nosu;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dogum_Tarihi;
        private System.Windows.Forms.DataGridViewButtonColumn Dogum_Yeri;
        private System.Windows.Forms.DataGridViewButtonColumn Telefon;
        private System.Windows.Forms.DataGridViewButtonColumn Eposta;
        private System.Windows.Forms.DataGridViewButtonColumn uyelik_Tarihi;
        private System.Windows.Forms.DataGridViewButtonColumn Cinsiyet;
        private System.Windows.Forms.DataGridViewButtonColumn Adres;
        private System.Windows.Forms.DataGridViewButtonColumn Emanet_Sayisi;
    }
}