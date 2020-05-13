using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace KütüphaneAnaMenü
{
    public partial class Anamenu : Form
    {
        public Anamenu()
        {
            InitializeComponent();
        }

        public dynamic KitapListele()
        {
            //burada kitapların listelenmesi için veritabanından çekilmesi işlemi yapılmıştır.
            using (kutuphaneEntities veritabani = new kutuphaneEntities())
            {
                var kitaplar = veritabani.Kitap.Where(x => x.stok_sayisi > 0).Select(kitap => kitap.kitap_adi).ToList();
                if (kitaplar != null) return kitaplar;
                else return null;
            }
        }

        public dynamic Okuyuculistele()
        {
            //burada okuyucuların listelenmesi için veritabanından çekilmesi işlemi yapılmıştır.
            using (kutuphaneEntities veritabani = new kutuphaneEntities())
            {
                var okuyucular = veritabani.OkuyucuBilgisi.Select(okuyucu => okuyucu.Adi_Soyadi).ToList();
                if (okuyucular != null) return okuyucular;
                else return null;
            }
        }

        private void ButonKitapEkleClick(object sender, EventArgs e)
        {
            Kitapkayit kitapKayit = new Kitapkayit();
            kitapKayit.Show();
        }

        private void ButonOkuyucuKayitClick(object sender, EventArgs e)
        {
            Okuyucukayit okuyucuKayit = new Okuyucukayit();
            okuyucuKayit.Show();
        }

        private void ButonCikisClick(object sender, EventArgs e)
        {
               Application.Exit();
        }

        private void ButonOkuyucularClick(object sender, EventArgs e)
        {
            form_Okuyucular frm = new form_Okuyucular();
            frm.Show();
        }

        private void ButonKitapListesiClick(object sender, EventArgs e)
        {
            Form_kitapListesi yeni = new Form_kitapListesi();
            yeni.Show();

        }
        private void Anamenu_Load(object sender, EventArgs e)
        {
            //burada formumuz yüklenirken araçlarımıza veri getirilme işlemi yapılmıştır.
            kitap_listesi_cmbbx.DataSource = KitapListele();
            Okuyucu_listesi_cmbbx.DataSource = Okuyuculistele();
            Okuyucu_listesi_cmbbx.Text =String.Empty;
            kitap_listesi_cmbbx.Text =String.Empty;
        }
        private void HakkındaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Kütüphane 1.0 Emrecan Güzelaydın");
        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ButonOduncListesiClick(object sender, EventArgs e)
        {
            Ödünç_Listesi ödünç_Listesi = new Ödünç_Listesi();
            ödünç_Listesi.Show();
        }

        private void ÖdüncVerButtonClick(object sender, EventArgs e)
        {
            DialogResult dialogResult = DialogResult.Yes;
            // !true => false  / !false => true 
            if (!String.IsNullOrEmpty(Okuyucu_listesi_cmbbx.Text) // Alanları Kontrol ettik
                && !String.IsNullOrEmpty(kitap_listesi_cmbbx.Text)
                    && !String.IsNullOrEmpty(dateTimePicker1.Text))
            {
                //burada da okuyucuya kitap verme işlemi yapılmıştır ancak okuyucunun emanet durumları da
                //kontol edilmiştir.
                using (kutuphaneEntities veritabani = new kutuphaneEntities())
                {
                    var kitapBilgisi = veritabani.Kitap.Where(x => x.kitap_adi == kitap_listesi_cmbbx.Text).FirstOrDefault();
                    var okuyucuBilgisi = veritabani.OkuyucuBilgisi.Where(x => x.Adi_Soyadi == Okuyucu_listesi_cmbbx.Text).FirstOrDefault();
                    var emanetExist = veritabani.Emanet.Any(x => x.isim == Okuyucu_listesi_cmbbx.Text && x.kitap_adi == kitap_listesi_cmbbx.Text);
                    if (emanetExist) // Emanet kitap varmı kontrol et
                    {
                        dialogResult = MessageBox.Show("Bu okuyucunun emanet listesinde adı var veya aynı kitapdan birden fazla kez almaya çalışıyor", "Bilgilendirme", MessageBoxButtons.YesNoCancel);
                        //Emanet kitap varsa yes derse kayıt et no derse kayıt etme
                    }
                    if(dialogResult == DialogResult.Yes) // varsayınal herzaman kayıt edecek
                    { 
                    if (kitapBilgisi != null && okuyucuBilgisi != null)
                        {
                            //burada da emanet verilmek istenen kitabın stok sayısı kontrolü yapılmıştır.
                            if (kitapBilgisi.stok_sayisi > 0)
                            {
                                try
                                {                           
                                    Emanet emanetVerilecek = new Emanet
                                    {
                                        isim = okuyucuBilgisi.Adi_Soyadi,
                                        kitap_adi = kitapBilgisi.kitap_adi,
                                        kitap_yazari = kitapBilgisi.yazar_adi,
                                        barkod_no = kitapBilgisi.barkod_id,
                                        baslangic_tarihi = DateTime.Parse(dateTimePicker1.Text),
                                        numara = int.Parse(okuyucuBilgisi.Nosu),
                                    };
                                    veritabani.Emanet.Add(emanetVerilecek);
                                    kitapBilgisi.stok_sayisi -= 1;
                                    okuyucuBilgisi.Emanet_Sayisi += 1;
                                    veritabani.SaveChanges();
                                    MessageBox.Show("Kitabınız başarıyla okuyucuya verildi");
                                    Okuyucu_listesi_cmbbx.Text = string.Empty;
                                    kitap_listesi_cmbbx.Text = string.Empty;
                                }
                                catch (Exception ex)
                                {
                                    MessageBox.Show(ex.Message);
                                }
                            }
                            else
                            {
                                MessageBox.Show("Kitaba ait stok sayısı sıfırdır");
                            }
                        }
                    }

                    else
                    {
                        MessageBox.Show("Kitap kayıt işlemi iptal edildi");
                    }
                }
            }
            else
            {
                MessageBox.Show("Veri alanları boş bırakılmamalıdır");
            }
        }
        private void ÇıktıAlKitap_Click(object sender, EventArgs e)
        {
            Kitaplistesi_ciktial ciktial = new Kitaplistesi_ciktial();
            ciktial.Show();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Okuyuculistesi_ciktial okuyucuciktialma = new Okuyuculistesi_ciktial();
            okuyucuciktialma.Show();
        }

        private void Kitap_listesi_cmbbx_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ButonUpdateFormDataClick(object sender, EventArgs e)
        {
            //burada da veri alanlarımızın güncelleme işlemi yapılmıştır.
            kitap_listesi_cmbbx.DataSource = KitapListele();
            Okuyucu_listesi_cmbbx.DataSource = Okuyuculistele();
            kitap_listesi_cmbbx.Text = String.Empty;
            Okuyucu_listesi_cmbbx.Text = String.Empty;
        }

        private void Anamenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult sonuc = MessageBox.Show("Çıkmak İstediğinizden Emin misiniz ?", "Çıkış", MessageBoxButtons.YesNo, MessageBoxIcon.  Question
                ,MessageBoxDefaultButton.Button2);
            if (sonuc == DialogResult.Yes)
            {
                e.Cancel = false;
            }
            else
            {
                e.Cancel = true;
            }
        }
    }
}
 