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
using PagedList;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;

namespace KütüphaneAnaMenü
{
    public partial class Okuyuculistesi_ciktial : Form
    {
        //Burada itextsharp eklentisi kullanılarak çıktı alma sağlanmıştır. Kodlar internetten hazır bir
        //şekilde alınıp projeye göre düzenlenmiştir.
        public Okuyuculistesi_ciktial()
        {
            InitializeComponent();
        }
        int currentPage = 1;
        int pageSize = 40;

        private void OkuyucuListesiCiktiAlLoad(object sender, EventArgs e)
        {
            using (kutuphaneEntities ktphane = new kutuphaneEntities())
            {
                IPagedList<OkuyucuBilgisi> list = ktphane.OkuyucuBilgisi.OrderBy(x => x.Adi_Soyadi).ToPagedList(currentPage, pageSize);
                btn_ileri.Enabled = list.IsFirstPage;
                btn_geri.Enabled = list.IsLastPage;
                labelsayfasayisi.Text = string.Format("Sayfa {0}/{1}", list.PageNumber, list.PageCount);
                okuyucuBilgisiBindingSource.DataSource = list.ToList();
            }
        }

        private void ButonIleriClick(object sender, EventArgs e)
        {
            if (btn_ileri.Enabled)
            {
                using (kutuphaneEntities ktphane = new kutuphaneEntities())
                {
                    currentPage++;
                    IPagedList<OkuyucuBilgisi> list = ktphane.OkuyucuBilgisi.OrderBy(x => x.Adi_Soyadi).ToPagedList(currentPage, pageSize);
                    btn_ileri.Enabled = list.IsFirstPage;
                    btn_geri.Enabled = list.IsLastPage;
                    labelsayfasayisi.Text = string.Format("Sayfa {0}/{1}", list.PageNumber, list.PageCount);
                    okuyucuBilgisiBindingSource.DataSource = list.ToList();
                }
            }
        }

        private void ButonGeriClick(object sender, EventArgs e)
        {
            if (btn_geri.Enabled)
            {
                using (kutuphaneEntities ktphane = new kutuphaneEntities())
                {
                    if (currentPage > 1) currentPage--; 
                    IPagedList<OkuyucuBilgisi> list = ktphane.OkuyucuBilgisi.OrderBy(x => x.Adi_Soyadi).ToPagedList(currentPage, pageSize);
                    btn_ileri.Enabled = list.IsFirstPage;
                    btn_geri.Enabled = list.IsLastPage;
                    labelsayfasayisi.Text = string.Format("Sayfa {0}/{1}", list.PageNumber, list.PageCount);
                    okuyucuBilgisiBindingSource.DataSource = list.ToList();
                }
            }
        }
        void ExportPdfFile()
        {
            PdfPTable pdfTable = new PdfPTable(dataGridView1_okuyuculist.ColumnCount);
            iTextSharp.text.pdf.BaseFont STF_Helvetica_Turkish = iTextSharp.text.pdf.BaseFont.CreateFont("Helvetica", "Cp1254", iTextSharp.text.pdf.BaseFont.NOT_EMBEDDED);

            iTextSharp.text.Font fontNormal = new iTextSharp.text.Font(STF_Helvetica_Turkish, 12, iTextSharp.text.Font.NORMAL);
            pdfTable.DefaultCell.Padding = 3;
            pdfTable.WidthPercentage = 120;

            pdfTable.HorizontalAlignment = Element.ALIGN_LEFT;
            pdfTable.DefaultCell.BorderWidth = 1;

            foreach (DataGridViewColumn column in dataGridView1_okuyuculist.Columns)
            {
                PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText));
                cell.BackgroundColor = new iTextSharp.text.BaseColor(240, 240, 240);
                pdfTable.AddCell(cell);
            }

            foreach (DataGridViewRow row in dataGridView1_okuyuculist.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    pdfTable.AddCell(new Phrase(cell.Value.ToString(), fontNormal));
                }
            }

            //string folderPath = "C:\\PDFs\\";

            SaveFileDialog svg = new SaveFileDialog();
            if (svg.ShowDialog() == DialogResult.OK)
            {
                using (FileStream stream = new FileStream(svg.FileName + ".pdf", FileMode.Create))
                {
                    Document pdfDoc = new Document(PageSize.A2, 10f, 10f, 10f, 0f);
                    PdfWriter.GetInstance(pdfDoc, stream);
                    pdfDoc.Open();

                    pdfDoc.Add(pdfTable);
                    pdfDoc.Close();
                    stream.Close();
                }
            }

        }

        private void ButonYazdirOkuyucuListClick(object sender, EventArgs e)
        {
            ExportPdfFile();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
           
        }

        private void dataGridView1_okuyuculist_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
