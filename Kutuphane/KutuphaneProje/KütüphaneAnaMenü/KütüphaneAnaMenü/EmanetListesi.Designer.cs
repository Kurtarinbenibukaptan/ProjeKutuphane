namespace KütüphaneAnaMenü
{
    partial class Ödünç_Listesi
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.emanet_refno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isim = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numara = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.barkod_no = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kitap_adi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kitap_yazari = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.baslangic_tarihi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.teslim_tarihi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hasar_durumu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(165, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Adı Soyadı:";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(524, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Teslim Tarihi:";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(366, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Kitap Adı:";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(706, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Hasar Durumu:";
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button1.AutoSize = true;
            this.button1.Image = global::KütüphaneAnaMenü.Properties.Resources.save_disk;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button1.Location = new System.Drawing.Point(941, 119);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(115, 66);
            this.button1.TabIndex = 8;
            this.button1.Text = "Teslim AL";
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
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
            this.emanet_refno,
            this.isim,
            this.numara,
            this.barkod_no,
            this.kitap_adi,
            this.kitap_yazari,
            this.baslangic_tarihi,
            this.teslim_tarihi,
            this.hasar_durumu});
            this.dataGridView1.Location = new System.Drawing.Point(12, 274);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1203, 333);
            this.dataGridView1.TabIndex = 9;
            // 
            // emanet_refno
            // 
            this.emanet_refno.DataPropertyName = "emanet_refno";
            this.emanet_refno.HeaderText = "EmanetRefNo";
            this.emanet_refno.Name = "emanet_refno";
            this.emanet_refno.Width = 125;
            // 
            // isim
            // 
            this.isim.DataPropertyName = "isim";
            this.isim.HeaderText = "İsim";
            this.isim.Name = "isim";
            this.isim.Width = 61;
            // 
            // numara
            // 
            this.numara.DataPropertyName = "numara";
            this.numara.HeaderText = "Numara";
            this.numara.Name = "numara";
            this.numara.Width = 87;
            // 
            // barkod_no
            // 
            this.barkod_no.DataPropertyName = "barkod_no";
            this.barkod_no.HeaderText = "Barkod No";
            this.barkod_no.Name = "barkod_no";
            this.barkod_no.Width = 96;
            // 
            // kitap_adi
            // 
            this.kitap_adi.DataPropertyName = "kitap_adi";
            this.kitap_adi.HeaderText = "Kitap Adı";
            this.kitap_adi.Name = "kitap_adi";
            this.kitap_adi.Width = 86;
            // 
            // kitap_yazari
            // 
            this.kitap_yazari.DataPropertyName = "kitap_yazari";
            this.kitap_yazari.HeaderText = "Kitap Yazarı";
            this.kitap_yazari.Name = "kitap_yazari";
            this.kitap_yazari.Width = 104;
            // 
            // baslangic_tarihi
            // 
            this.baslangic_tarihi.DataPropertyName = "baslangic_tarihi";
            this.baslangic_tarihi.HeaderText = "Başlangıç Tarihi";
            this.baslangic_tarihi.Name = "baslangic_tarihi";
            this.baslangic_tarihi.Width = 127;
            // 
            // teslim_tarihi
            // 
            this.teslim_tarihi.DataPropertyName = "teslim_tarihi";
            this.teslim_tarihi.HeaderText = "Teslim Tarihi";
            this.teslim_tarihi.Name = "teslim_tarihi";
            this.teslim_tarihi.Width = 109;
            // 
            // hasar_durumu
            // 
            this.hasar_durumu.DataPropertyName = "hasar_durumu";
            this.hasar_durumu.HeaderText = "Hasar Durumu";
            this.hasar_durumu.Name = "hasar_durumu";
            this.hasar_durumu.Width = 118;
            // 
            // comboBox1
            // 
            this.comboBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Hasarlı",
            "Hasarsız",
            "Kayıp"});
            this.comboBox1.Location = new System.Drawing.Point(709, 148);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 10;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.dateTimePicker1.Location = new System.Drawing.Point(527, 146);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(134, 22);
            this.dateTimePicker1.TabIndex = 11;
            // 
            // comboBox2
            // 
            this.comboBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(369, 148);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 24);
            this.comboBox2.TabIndex = 12;
            // 
            // comboBox3
            // 
            this.comboBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(168, 149);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(159, 24);
            this.comboBox3.TabIndex = 13;
            this.comboBox3.TextChanged += new System.EventHandler(this.ComboBox3_TextChanged);
            // 
            // Ödünç_Listesi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1227, 672);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Ödünç_Listesi";
            this.Text = "Emanet Listesi";
            this.Load += new System.EventHandler(this.Ödünç_Listesi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.DataGridViewTextBoxColumn emanet_refno;
        private System.Windows.Forms.DataGridViewTextBoxColumn isim;
        private System.Windows.Forms.DataGridViewTextBoxColumn numara;
        private System.Windows.Forms.DataGridViewTextBoxColumn barkod_no;
        private System.Windows.Forms.DataGridViewTextBoxColumn kitap_adi;
        private System.Windows.Forms.DataGridViewTextBoxColumn kitap_yazari;
        private System.Windows.Forms.DataGridViewTextBoxColumn baslangic_tarihi;
        private System.Windows.Forms.DataGridViewTextBoxColumn teslim_tarihi;
        private System.Windows.Forms.DataGridViewTextBoxColumn hasar_durumu;
    }
}