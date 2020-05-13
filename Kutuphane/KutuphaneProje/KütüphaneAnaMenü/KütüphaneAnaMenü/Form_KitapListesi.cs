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
    public partial class Form_kitapListesi : Form
    {
        public Form_kitapListesi()
        {
            InitializeComponent();
        }
         private void KitapListesi()
        {
            //burada datagridview'in datasource'una veritabanından veri çekme işlemi yapılmıştır.
            kutuphaneEntities veritabanı = new kutuphaneEntities();
            var liste = veritabanı.Kitap.ToList();
            dataGridView1.DataSource = liste;
        }
        private void UpdateComponent()
        {
            //burada kitaplistesinin güncellenmesi ve cmbbx_Kitapların datasource'unun güncellenmesi sağlanmıştır.
            KitapListesi();
            cmbbx_kitaplar.DataSource = KitapListele();
        }
        public dynamic KitapListele()
        {
            //burada da veritabanımızdan kitaplarımızın listelenmesi için metot oluşturulmuştur.
            using (kutuphaneEntities veritabani = new kutuphaneEntities())
            {
                var kitaplar = veritabani.Kitap.Select(kitap => kitap.kitap_adi).ToList();
                if (kitaplar != null) return kitaplar;
                else return null;
            }
        }
        private void Form_kitapListesi_Load(object sender, EventArgs e)
        {
            //burada formumuz yüklediğinde araçlarımızın datasource'ları için işlemler yapıldı.
            KitapListesi();
            cmbbx_kitaplar.DataSource = KitapListele();
            cmbbx_kitaplar.Text =String.Empty;
        }
        private void ButtonAra_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(textBox1.Text))
            {
                using (kutuphaneEntities veritabanı = new kutuphaneEntities())
                {
                    //burada veritabanımızda kitap adına göre arama işlemi yapılmıştır ve datagridview
                    //bu duruma göre güncellenmiştir.
                    var liste = veritabanı.Kitap.SqlQuery("SELECT * FROM Kitap WHERE kitap_adi LIKE '%" + textBox1.Text.ToUpper() + "%'").ToList();
                    dataGridView1.DataSource = liste;
                    textBox1.Text = String.Empty;
                }
            }
        }
        private void Button1_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(cmbbx_kitaplar.Text))
            {
                using (kutuphaneEntities veritabani = new kutuphaneEntities())
                {
                    //burada da kitap silme işlemi ile ilgili işlemler yapılmıştır.
                    var query = veritabani.Kitap.Where(x => x.kitap_adi == cmbbx_kitaplar.Text).FirstOrDefault();
                    if (query != null)
                    {
                        var dialog = MessageBox.Show("Siliniyor", "Emin misiniz?", MessageBoxButtons.YesNo);
                        if (dialog == DialogResult.Yes)
                        {
                            try
                            {
                                veritabani.Kitap.Remove(query);
                                veritabani.SaveChanges();
                                KitapListesi();
                                
                                cmbbx_kitaplar.DataSource = KitapListele();
                                cmbbx_kitaplar.Text = String.Empty;

                            }
                            catch (Exception ex)
                            {

                                MessageBox.Show(ex.Message);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Kitap Silme İşlemi İptal edildi");
                        }
                    }
                }
            }
        }
    }
}
