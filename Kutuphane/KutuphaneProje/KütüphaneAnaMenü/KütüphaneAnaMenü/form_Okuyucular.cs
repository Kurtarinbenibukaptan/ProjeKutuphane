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
    public partial class form_Okuyucular : Form
    {
        public form_Okuyucular()
        {
            InitializeComponent();
        }
        public dynamic OkuyucListele()
        {
            //burada veritabanımıza erişilip okuyucuların listelenmesi için işlem yapılmıştır.
            using (kutuphaneEntities veritabani = new kutuphaneEntities())
            {
                var okuyucular = veritabani.OkuyucuBilgisi.Select(okuyucu => okuyucu.Adi_Soyadi).ToList();
                if (okuyucular != null) return okuyucular;
                else return null;
            }
        }

        private void OkuyucuListesi()
        {
            //burada okuyucuların datagridview datasource'una aktarımı yapılmıştır.
            using (kutuphaneEntities veritabanı = new kutuphaneEntities())
            {
                var liste = veritabanı.OkuyucuBilgisi.ToList();
                dataGridView1.DataSource = liste;
            }
        }
        private void Form_Okuyucular_Load(object sender, EventArgs e)
        {
            //formumuz yüklenirken gerçekleşecek iişlemler yapılmıştır.
            // datagridview'imize veriler çekilmiş, combobox'ımıza da veriler çekilmiştir.
            OkuyucuListesi();
            cmbbx_okuyucular.DataSource = OkuyucListele();
            cmbbx_okuyucular.Text = String.Empty;
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ButtonAra_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(textBox1.Text))
            {
                kutuphaneEntities veritabanı = new kutuphaneEntities();
                {
                    //burada da okuyucuların tc kimlik numaraları ile aranıp datagridview'de gösterilme işlemi
                    //yapılmıştır.
                    var liste = veritabanı.OkuyucuBilgisi.Where(x =>
                            (x.Tckimlik == textBox1.Text)).ToList();
                    dataGridView1.DataSource = liste;
                    textBox1.Text = String.Empty;
                }
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(cmbbx_okuyucular.Text))
            {
                using (kutuphaneEntities veritabani = new kutuphaneEntities())
                {
                    //burada da okuyucu silme işlemi öncesi okuyucuya ait emanet olma durumu kontrol edilip
                    //silme işlemi gerçekleştirilmiştir.
                    var query = veritabani.OkuyucuBilgisi.Where(x => x.Adi_Soyadi == cmbbx_okuyucular.Text).FirstOrDefault();
                    var kontrolOkuyucuEmanet = veritabani.Emanet.Where(x => x.isim == cmbbx_okuyucular.Text).FirstOrDefault();

                    if (kontrolOkuyucuEmanet != null) // Emanet varsa 
                    {
                        MessageBox.Show("Silmek istenen okuyucuya emanet kitap vardır");
                    }
                    if (query != null)
                    {
                        var dialog = MessageBox.Show("Siliniyor", "Emin misiniz?", MessageBoxButtons.YesNo);
                        if (dialog == DialogResult.Yes)
                        {
                            try
                            {
                                veritabani.OkuyucuBilgisi.Remove(query);
                                veritabani.SaveChanges();
                                OkuyucuListesi();
                                
                                cmbbx_okuyucular.DataSource = OkuyucListele();
                                cmbbx_okuyucular.Text = String.Empty;
                            }
                            catch (Exception ex)
                            {

                                MessageBox.Show(ex.Message);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Okuyucu Silme İşlemi İptal edildi");
                        }
                    }

                }
            }
        }
    }
}
