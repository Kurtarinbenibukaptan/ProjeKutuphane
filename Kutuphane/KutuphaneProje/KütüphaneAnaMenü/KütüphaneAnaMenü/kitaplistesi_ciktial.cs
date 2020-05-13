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
using iTextSharp.text.pdf;
using iTextSharp.text;
using System.IO;

namespace KütüphaneAnaMenü
{
    //Burada itextsharp eklentisi kullanılarak çıktı alma sağlanmıştır. Kodlar internetten hazır bir
    //şekilde alınıp projeye göre düzenlenmiştir.
    public partial class Kitaplistesi_ciktial : Form
    {
        public Kitaplistesi_ciktial()
        {
            InitializeComponent();
        }
        int currentPage = 1;
        int pageSize = 40;

        private void CiktiAlFormLoad(object sender, EventArgs e)
        {
            //{
            using (kutuphaneEntities ktphane = new kutuphaneEntities())
            {
                //    using (kutuphaneEntities ktphane = new kutuphaneEntities())
                IPagedList<Kitap> list = ktphane.Kitap.OrderBy(x => x.barkod_id).ToPagedList(currentPage, pageSize);
                btn_ileri.Enabled = list.IsFirstPage;
                btn_geri.Enabled = list.IsLastPage;
                labelsayfasayisi.Text = string.Format("Sayfa {0}/{1}", list.PageNumber, list.PageCount); 
                kitapBindingSource.DataSource = list.ToList();
            }
        }

        private void ButonIleriClick(object sender, EventArgs e)
        {
            if (btn_ileri.Enabled)
            {
                using (kutuphaneEntities ktphane = new kutuphaneEntities())
                {

                    currentPage++;
                    IPagedList<Kitap> list = ktphane.Kitap.OrderBy(x => x.barkod_id).ToPagedList(currentPage, pageSize);
                    btn_ileri.Enabled = list.IsFirstPage;
                    btn_geri.Enabled = list.IsLastPage;
                    labelsayfasayisi.Text = string.Format("Sayfa {0}/{1}", list.PageNumber, list.PageCount);
                    kitapBindingSource.DataSource = list.ToList();
                }
            }
        }

        private void ButonGeriClick(object sender, EventArgs e)
        {
            if (btn_geri.Enabled)
            {
                using (kutuphaneEntities ktphane = new kutuphaneEntities())
                {
                    if (currentPage > 1)
                    {
                        currentPage--;
                    }
                    IPagedList<Kitap> list = ktphane.Kitap.OrderBy(x => x.barkod_id).ToPagedList(currentPage, pageSize);
                    btn_ileri.Enabled = list.IsFirstPage;
                    btn_geri.Enabled = list.IsLastPage;
                    labelsayfasayisi.Text = string.Format("Sayfa {0}/{1}", list.PageNumber, list.PageCount);
                    kitapBindingSource.DataSource = list.ToList();
                }
            }
        }
        void ExportPdfFile()
        {
            PdfPTable pdfTable = new PdfPTable(dataGridView1_KitapListesi.ColumnCount);
            iTextSharp.text.pdf.BaseFont STF_Helvetica_Turkish = iTextSharp.text.pdf.BaseFont.CreateFont("Helvetica", "Cp1254", iTextSharp.text.pdf.BaseFont.NOT_EMBEDDED);

            iTextSharp.text.Font fontNormal = new iTextSharp.text.Font(STF_Helvetica_Turkish, 12, iTextSharp.text.Font.NORMAL);
            pdfTable.DefaultCell.Padding = 3;
            pdfTable.WidthPercentage = 60;
            
            pdfTable.HorizontalAlignment = Element.ALIGN_LEFT;
            pdfTable.DefaultCell.BorderWidth = 1;

            foreach (DataGridViewColumn column in dataGridView1_KitapListesi.Columns)
            {
                PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText));
                cell.BackgroundColor = new iTextSharp.text.BaseColor(240, 240, 240);
                pdfTable.AddCell(cell);
            }

            foreach (DataGridViewRow row in dataGridView1_KitapListesi.Rows)
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
   
        private void ButonYazdirKitaplistClick(object sender, EventArgs e)
        {
            ExportPdfFile();
        }

        private void PrintDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
           // e.Graphics.DrawImage(bmp, 0, 0);
        }

        private void dataGridView1_KitapListesi_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
