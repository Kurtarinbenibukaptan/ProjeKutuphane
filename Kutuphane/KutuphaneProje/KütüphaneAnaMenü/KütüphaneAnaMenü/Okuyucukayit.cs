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
    public partial class Okuyucukayit : Form
    {
        public Okuyucukayit()
        {
            InitializeComponent();
        }

        private void TextBox4_TextChanged(object sender, EventArgs e)
        {

        }
        public dynamic TcKimlikListele()
        {
            kutuphaneEntities kutuphane = new kutuphaneEntities();
            //burada tckimlik numarasına erişerek listeleme işlemi yapılmıştır.
            var liste = kutuphane.OkuyucuBilgisi.Select(tcno=>tcno.Tckimlik).ToList();
            if (liste != null)
            {
                return liste;
            }
            else
            {
                return null;
            }
        }
        private void GuncelleOkuyucubil()
        {
            //burada datagridview'in verilerinin güncellenmesi işlemi yapılmıştır.
            using (kutuphaneEntities kutuphane = new kutuphaneEntities())
            {
                dataGridView1.DataSource = kutuphane.OkuyucuBilgisi.ToList() ?? null;
            }
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }
        private void Temizle()
        {
            //burada veri girdiğimiz alanların temizlenme işlemi yapılmıştır.
            txt_adi_soyadi.Text = String.Empty;
            txt_adres.Text = String.Empty;
            txt_dogum_yeri.Text = String.Empty;
            txt_eposta.Text = String.Empty;
            txt_no.Text = String.Empty;
            txt_tckimlik.Text = String.Empty;
            txt_telefon.Text = String.Empty;

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txt_adi_soyadi.Text) &&
                 !String.IsNullOrEmpty(txt_adres.Text) &&
                 !String.IsNullOrEmpty(txt_dogum_yeri.Text) &&
                 !String.IsNullOrEmpty(txt_eposta.Text) &&
                 !String.IsNullOrEmpty(txt_no.Text) &&
                 !String.IsNullOrEmpty(txt_tckimlik.Text) &&
                 !String.IsNullOrEmpty(txt_telefon.Text) &&
                 !String.IsNullOrEmpty(cmbbx_sinif.Text) &&
                 !String.IsNullOrEmpty(dateTimePicker1.Text) &&
                 !String.IsNullOrEmpty(dateTimePicker2.Text) )

                 
                 //burada veri alanları kontrolü yapılmıştır.
            {

                //burada da verilerimizin veritabanına kayıt işlemi yapılmıştır. 
                using (kutuphaneEntities kutuphane = new kutuphaneEntities())
                {
                    try
                    {
                        OkuyucuBilgisi okuyucubil = new OkuyucuBilgisi
                        {
                            Tckimlik = txt_tckimlik.Text,
                            Adi_Soyadi = txt_adi_soyadi.Text,
                            Nosu = txt_no.Text,
                            Dogum_Tarihi = dateTimePicker1.Text,
                            Dogum_Yeri = txt_dogum_yeri.Text,
                            Telefon = txt_telefon.Text,
                            Eposta = txt_eposta.Text,
                            Cinsiyet = cmbbx_cins.Text,
                            Adres = txt_adres.Text,
                            uyelik_Tarihi = DateTime.Now,
                            Sinifi = cmbbx_sinif.Text,
                            Emanet_Sayisi = 0
                        };

                        kutuphane.OkuyucuBilgisi.Add(okuyucubil);
                        kutuphane.SaveChanges();
                        MessageBox.Show(string.Format("{0} adlı okuyucu veritabanına kayıt edildi", okuyucubil.Adi_Soyadi));
                        GuncelleOkuyucubil();
                        cmb_tckimlik.DataSource = TcKimlikListele();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
                else
            {
                MessageBox.Show("Veri alanları boş bırakılmamalıdır");
            }
        }

        private void Okuyucukayit_Load(object sender, EventArgs e)
        {
            //burada da formumuz yüklenirken araçlarımıza verilerin getirilme işlemi yapılmıştır.
            GuncelleOkuyucubil();
            cmb_tckimlik.DataSource = TcKimlikListele();
        }

        private void Verigetirbuton_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(cmb_tckimlik.Text))
            {
                //burada da veritabanına erişerek okuyucuların tc kimlik numaraları ile, ilgili verierin
                //araçlarımıza getirilme işlemi yapılmıştır.
                kutuphaneEntities kutuphane = new kutuphaneEntities();
                var tcvarmi = kutuphane.OkuyucuBilgisi.Where(tc => tc.Tckimlik == cmb_tckimlik.Text).FirstOrDefault();
                if (tcvarmi != null)
                {
                    txt_adi_soyadi.Text = tcvarmi.Adi_Soyadi;
                    txt_adres.Text = tcvarmi.Adres;
                    cmbbx_cins.Text = tcvarmi.Cinsiyet;
                    dateTimePicker1.Text = tcvarmi.Dogum_Tarihi;
                    txt_dogum_yeri.Text = tcvarmi.Dogum_Yeri;
                    txt_eposta.Text = tcvarmi.Eposta;
                    txt_no.Text = tcvarmi.Nosu;
                    cmbbx_sinif.Text = tcvarmi.Sinifi;
                    txt_telefon.Text = tcvarmi.Telefon;
                    txt_tckimlik.Text = tcvarmi.Tckimlik;
                    dateTimePicker2.Text = (tcvarmi.uyelik_Tarihi).ToString();

                }
            }
        }

        private void GuncelleButonClick(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txt_adi_soyadi.Text) &&
                 !String.IsNullOrEmpty(txt_adres.Text) &&
                 !String.IsNullOrEmpty(txt_dogum_yeri.Text) &&
                 !String.IsNullOrEmpty(txt_eposta.Text) &&
                 !String.IsNullOrEmpty(txt_no.Text) &&
                 !String.IsNullOrEmpty(txt_tckimlik.Text) &&
                 !String.IsNullOrEmpty(txt_telefon.Text) &&
                 !String.IsNullOrEmpty(cmbbx_sinif.Text) &&
                 !String.IsNullOrEmpty(dateTimePicker1.Text) &&
                 !String.IsNullOrEmpty(dateTimePicker2.Text))
                 //burada araçlarımızın kontrolü sağlanıp
            {
                //tc kimlik numarasına göre araçlarımıza getirdiğimiz bilgilerin güncelleme işlemi yapıldıktan
                //sonra kayıt işlemi yapılması amaçlanmıştır.
                kutuphaneEntities kutuphane = new kutuphaneEntities();
                var tcvarmi = kutuphane.OkuyucuBilgisi.Where(tc => tc.Tckimlik == cmb_tckimlik.Text).FirstOrDefault();
                if (tcvarmi != null)
                {
                    tcvarmi.Adi_Soyadi = txt_adi_soyadi.Text;
                    tcvarmi.Adres = txt_adres.Text;
                    tcvarmi.Cinsiyet = cmbbx_cins.Text;
                    tcvarmi.Dogum_Tarihi = dateTimePicker1.Text;
                    tcvarmi.Dogum_Yeri = txt_dogum_yeri.Text;
                    tcvarmi.Eposta = txt_eposta.Text;
                    tcvarmi.Nosu = txt_no.Text;
                    tcvarmi.Sinifi = cmbbx_sinif.Text;
                    tcvarmi.Telefon = txt_telefon.Text;
                    tcvarmi.uyelik_Tarihi = DateTime.Parse(dateTimePicker2.Text);
                    kutuphane.SaveChanges();
                    GuncelleOkuyucubil();
                    MessageBox.Show("Veriler başarı ile güncellenmiştir");
                    Temizle();
                    cmb_tckimlik.Text = String.Empty;
                }
            }
        }

        private void CmbTcLimlikSelectedIndexChanged(object sender, EventArgs e)
        {
            cmb_tckimlik.Text = String.Empty;
        }
    }
}
