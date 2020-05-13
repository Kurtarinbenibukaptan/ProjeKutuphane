using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KütüphaneAnaMenü
{
    public partial class Kitapkayit : Form
    {
        public Kitapkayit()
        {
            InitializeComponent();
        }

        private dynamic GetKitapTuru()
        {
            //burada kategori tablosundaki veriler çekilmiştir. ancak kaydettiğimizde türler değil türlere ait
            // numaralar kaydedilecektir.
            using (kutuphaneEntities veritabani = new kutuphaneEntities())
            {
                var kategori = veritabani.Kategori.Select(x => new { x.kategori_id, x.kategori1 }).ToList();
                if (kategori != null) // Kategori tablosundaki veriler boş değilse
                {
                    return kategori; // Kategori verileri gönderilecek
                }
                else
                {
                    return null; // Eğer boş ise geriye boş bir değer gönderecek.
                }
            }
        }

        public dynamic  BarkodListele()
        {
            kutuphaneEntities kutuphane = new kutuphaneEntities();
            //burada barkod_id ye göre listeleme işlemi yapılmıştır.
            var liste = kutuphane.Kitap.Select(barkodno => barkodno.barkod_id).ToList();
            if (liste != null)
            {
                return liste;
            }
            else
            {
                return null;
            }
        }
        public dynamic KitapListele()
        {
            //burada da kitap adına göre listeleme işlemi yapılmıştır.
            using (kutuphaneEntities veritabani = new kutuphaneEntities())
            {
                var kitaplar = veritabani.Kitap.Select(kitap => kitap.kitap_adi).ToList();
                if (kitaplar != null) return kitaplar;
                else return null;
            }
        }
        private void ButonKaydetClick(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txt_barkodNo.Text) &&
                 !String.IsNullOrEmpty(txt_KitapAdi.Text) &&
                 !String.IsNullOrEmpty(txt_StokSayisi.Text) &&
                 !String.IsNullOrEmpty(txt_YayinEvi.Text) &&
                 !String.IsNullOrEmpty(txt_YayinYili.Text) &&
                 !String.IsNullOrEmpty(txt_YazarAdi.Text) &&
                 !String.IsNullOrEmpty(cmb_Kitaptürü.Text)
                 )
        //burada da textbox'ların kontrolü yapıldıktan sonra verilerin veritabanına kaydedilme işlemi
        //yapılmıştır.

            using (kutuphaneEntities kutuphane = new kutuphaneEntities())
            {
                
                Kitap kitap = new Kitap
                {
                    barkod_id = txt_barkodNo.Text,
                    kitap_adi = txt_KitapAdi.Text.ToUpper(),
                    yazar_adi = txt_YazarAdi.Text.ToUpper(),
                    yayin_evi = txt_YayinEvi.Text.ToUpper(),
                    kitap_turu = Convert.ToInt32(cmb_Kitaptürü.SelectedValue),
                    yayin_yili = txt_YayinYili.Text.ToUpper(),
                    olusturulma_tarihi = DateTime.Now,
                    stok_sayisi = Convert.ToInt32(txt_StokSayisi.Text),
                };
                //burada da eklemek istediğimiz kitabın barkod_id'si ve adı daha önceden kaydedilmiş
                //bir kitap ile aynıysa stok adedinde güncelleme yapılmıştır.
                var kitapExists = kutuphane.Kitap.Where(x => x.kitap_adi == kitap.kitap_adi && 
                x.barkod_id == kitap.barkod_id && x.yazar_adi == kitap.yazar_adi).FirstOrDefault();
                if (kitapExists == null)
                {
                    try
                    {
                        kutuphane.Kitap.Add(kitap);
                        
                        GuncelleKitap();
                        Temizle();
                        kutuphane.SaveChanges();
                        MessageBox.Show(String.Format("{0} adlı kitap veritabanına kayıt edildi", kitap.kitap_adi));
                        UpdateComponent();
                        ombo_BarkodNo.DataSource = BarkodListele();
                        }
                    catch (Exception ex)
                    {

                        MessageBox.Show(ex.Message);
                    }
                }
                else
                {
                    MessageBox.Show("Böyle bir kitap veritabanında zaten var. Stok sayısı üzerine veri eklendi");
                    kitapExists.stok_sayisi += 1;
                    kutuphane.SaveChanges();
                }

            }
            else
            {
                //burada da boş kalan veriler için uyarı mesajı verilmiştir.
                MessageBox.Show("Veri alanları boş bırakılmamalıdır");
            }
        }
        private void UpdateComponent()
        {
            //güncelleme işlemi için kullanılmıştır.
            GuncelleKitap();
        }

    private void KitapKayitLoad(object sender, EventArgs e)
        {
            cmb_Kitaptürü.DataSource = GetKitapTuru();
            cmb_Kitaptürü.ValueMember = "kategori_id";
            cmb_Kitaptürü.DisplayMember = "kategori1";
            GuncelleKitap();
            ombo_BarkodNo.DataSource = BarkodListele();
        }

        private void GuncelleKitap()
        {
            //burada datagridview'in datasource'una güncelleme amaçlı veriler çekilmiştir.
            using (kutuphaneEntities kutuphane = new kutuphaneEntities())
            {
                dataGridView1.DataSource = kutuphane.Kitap.ToList();
            }
        }

        private void ButonCikisClick(object sender, EventArgs e)
        {
            this.Close();
        }
        public void Temizle()
        {
            //burada verilerimizi gireceğimiz araçlarımızın temizlenmesi sağlanmıştır.
            txt_barkodNo.Text =String.Empty;
            txt_KitapAdi.Text =String.Empty;
            txt_StokSayisi.Text =String.Empty;
            txt_YayinEvi.Text =String.Empty;
            txt_YayinYili.Text =String.Empty;
            txt_YazarAdi.Text =String.Empty;
        }
        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            
            if (!String.IsNullOrEmpty(txt_barkodNo.Text) &&
                !String.IsNullOrEmpty(txt_KitapAdi.Text) &&
                !String.IsNullOrEmpty(txt_StokSayisi.Text) &&
                !String.IsNullOrEmpty(txt_YayinEvi.Text) &&
                !String.IsNullOrEmpty(txt_YayinYili.Text) &&
                !String.IsNullOrEmpty(txt_YazarAdi.Text) &&
                !String.IsNullOrEmpty(cmb_Kitaptürü.Text)
                )
                //burada da veri alanlarımız kontrol edilmiştir ve aynı zamanda
                // verileri güncelleme işlemi yapıldıktan sonra veritabanının güncelleme işlemi yapılmıştır.
            {
                kutuphaneEntities kutuphane = new kutuphaneEntities();
                var kitapVarmi = kutuphane.Kitap.Where(barkod => barkod.barkod_id == ombo_BarkodNo.Text).FirstOrDefault();
                if (kitapVarmi != null)
                {
                    kitapVarmi.kitap_adi = txt_KitapAdi.Text;
                    kitapVarmi.kitap_turu = Convert.ToInt32(cmb_Kitaptürü.SelectedValue);
                    kitapVarmi.olusturulma_tarihi = DateTime.Parse(dateOfCreated.Text);
                    kitapVarmi.stok_sayisi = Convert.ToInt32(txt_StokSayisi.Text);
                    kitapVarmi.yayin_evi = txt_YayinEvi.Text;
                    kitapVarmi.yayin_yili = txt_YayinYili.Text;
                    kitapVarmi.yazar_adi = txt_YazarAdi.Text;
                    kutuphane.SaveChanges();
                    GuncelleKitap();
                    MessageBox.Show("Veriler başarı ile güncellenmiştir");
                    Temizle();
                    ombo_BarkodNo.Text = String.Empty;
                }
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(ombo_BarkodNo.Text))
            {
                //burada da comboboxtan seçilen barkod_id ye göre kitaplara ait verilerin güncelleme amacı ile 
                //araçlarımıza getirilmesi sağlanmıştır.
                kutuphaneEntities kutuphane = new kutuphaneEntities();
                var kitapVarmi = kutuphane.Kitap.Where(barkod => barkod.barkod_id == ombo_BarkodNo.Text).FirstOrDefault();
                if (kitapVarmi != null)
                {
                    txt_KitapAdi.Text = kitapVarmi.kitap_adi;
                    txt_barkodNo.Text=kitapVarmi.barkod_id ;
                    cmb_Kitaptürü.SelectedValue = kitapVarmi.kitap_turu ;
                    dateOfCreated.Text = (kitapVarmi.olusturulma_tarihi).ToString();
                    txt_StokSayisi.Text=(kitapVarmi.stok_sayisi).ToString();
                    txt_YayinEvi.Text = kitapVarmi.yayin_evi;
                    txt_YayinYili.Text = kitapVarmi.yayin_yili;
                    txt_YazarAdi.Text = kitapVarmi.yazar_adi;

                }
            }
        }

        private void Ombo_BarkodNo_SelectedIndexChanged(object sender, EventArgs e)
        {
            ombo_BarkodNo.Text = String.Empty;
        }

        private void Cmb_Kitaptürü_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
