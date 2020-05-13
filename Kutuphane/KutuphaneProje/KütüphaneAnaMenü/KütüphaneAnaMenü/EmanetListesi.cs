/****************************************************************************
**                            SAKARYA ÜNİVERSİTESİ
**                  BİLGİSAYAR VE BİLİŞİM BİLİMLERİ FAKÜLTESİ
**                   BİLİŞİM SİSTEMLERİ MÜHENDİSLİĞİ BÖLÜMÜ
**                      NESNEYE DAYALI PROGRAMLAMA DERSİ
**                          2019-2020 BAHAR DÖNEMİ
**
**           ÖDEV NUMARASI..........: 2
**           ÖĞRENCİ ADI............: Emrecan Güzelaydın    
**           ÖĞRENCİ NUMARASI.......: B191200301
**           DERSİN ALINDIĞI GRUP...: A
****************************************************************************/
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
    public partial class Ödünç_Listesi : Form
    {
        public Ödünç_Listesi()
        {
            InitializeComponent();
        }
        public dynamic KitapListele()
        {
            
            using (kutuphaneEntities veritabani = new kutuphaneEntities())
            {
                //burada combobox3'te seçtiğimiz isime göre o isime ait emanet kitapların listelenmesi için veritabanına başvurulmuştur.
                var kitaplar = veritabani.Emanet.Where(x => x.isim == comboBox3.Text).Select(x => x.kitap_adi).ToList();
                if (kitaplar != null) return kitaplar;
                else return null;
            }
        }

        public dynamic OkuyucuListele()
        {
            using (kutuphaneEntities veritabani = new kutuphaneEntities())
            {
                // burada da emanet tablomuzdaki okuyucuların listelenmesi için veritabanına başvurulmuştur.
                var okuyucular = veritabani.Emanet.Select(okuyucu => okuyucu.isim).ToList();
                if (okuyucular != null) return okuyucular;
                else return null;
            }
        }
        private void EmanetListesi()
        {
            //burada da emanet tablomuzun içindeki verilerin datagridview datasource na aktarımı gerçekleşmiştir.
            kutuphaneEntities veritabanı = new kutuphaneEntities();
            var liste = veritabanı.Emanet.ToList();
            dataGridView1.DataSource = liste;
        }
        private void UpdateComponent()
        {
            //burada araçlarımızın  güncellenmesi sağlanmıştır.
            EmanetListesi();
            comboBox3.DataSource = OkuyucuListele();

        }
        private void Ödünç_Listesi_Load(object sender, EventArgs e)
        {
            //burada formumuz yüklenirken okuyucu isimlerinin bulunduğu
            //combobox3'e okuyucuların gelmesi için UpdateComponent metodumuz çağrılmıştır.
            UpdateComponent();
            comboBox1.Text =String.Empty;
            comboBox2.Text =String.Empty;
            comboBox3.Text =String.Empty;

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            
            using (kutuphaneEntities veritabani = new kutuphaneEntities())
            {
                //burada üzerinde emanet bulunan okuyucu seçildikten sonra ona karşılık gelen kitaplardan
                //herhangi birinin emanet alınması için veritabanına başvurulmuştur.
                var silinecekEmanet = veritabani.Emanet.Where(x => x.isim == comboBox3.Text && x.kitap_adi == comboBox2.Text).FirstOrDefault();
                var kitap = veritabani.Kitap.Where(x => x.kitap_adi == comboBox2.Text).FirstOrDefault();

                if (silinecekEmanet != null)
                {
                    Teslim teslim = new Teslim
                    {
                        //burada teslim alınan kitap için gerekli bilgiler veritabanına işlenmiştir.
                        hasar_durumu = comboBox1.Text,
                        kitap_adi = silinecekEmanet.kitap_adi,
                        okuyucu = silinecekEmanet.isim,
                        teslim_tarihi = DateTime.Parse(dateTimePicker1.Text)
                    };

                    try
                    {
                        //burada da teslim alınan kitap hakkında guncellemeler yapılmıştır.
                        //Teslim alınan kitap ve okuyucusu emanet tablosundan kaldırılmıştır.
                        kitap.stok_sayisi += 1;
                        veritabani.Teslim.Add(teslim);
                        veritabani.Emanet.Remove(silinecekEmanet);
                        veritabani.SaveChanges();
                        MessageBox.Show("Kitap teslim Alındı");
                        UpdateComponent();
                        comboBox3.Text = string.Empty;
                        comboBox2.Text = string.Empty;
                        comboBox1.Text = string.Empty;
                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show(ex.Message);
                    }
                }
                else
                {
                    MessageBox.Show("Bu okuyucuyla ilişkilendirilmiş herhangi bir kitap bulunamadı");
                }
            }
        }

        private void ComboBox3_TextChanged(object sender, EventArgs e)
        {
            //burada da comboBox'ımızın datasource'una seçilen okuyucuya ait kitapların gelmesi sağlanmıştr.
            comboBox2.DataSource = KitapListele();

        }
    }
}
