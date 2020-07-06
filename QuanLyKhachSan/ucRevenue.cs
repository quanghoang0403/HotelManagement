using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyKhachSan.BUS;
using QuanLyKhachSan.DTO;
using System.Windows.Forms;
using iTextSharp.text.pdf;
using iTextSharp.text;
using System.IO;


namespace QuanLyKhachSan
{
    public partial class ucRevenue : UserControl
    {
        public ucRevenue()
        {
            InitializeComponent();
            LoadIncomelist();
        }
        private void LoadIncomelist()
        {
            dtgvIncome.DataSource=RevenueBUS.Instance.LoadRevenueList(dateMonth.Value.Month.ToString(), dateMonth.Value.Year.ToString());
        }
        private void btnExport_Click(object sender, EventArgs e)
        {
            if (dtgvIncome.Rows.Count > 0)
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "PDF (*.pdf)|*.pdf";
                sfd.FileName = "Output.pdf";
                bool fileError = false;
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    if (File.Exists(sfd.FileName))
                    {
                        try
                        {
                            File.Delete(sfd.FileName);
                        }
                        catch (IOException ex)
                        {
                            fileError = true;
                            MessageBox.Show("Không thể ghi dữ liệu tới ổ đĩa. Mô tả lỗi:" + ex.Message);
                        }
                    }
                    if (!fileError)
                    {
                        try
                        {
                            ExportDataTableToPdf(dtgvIncome, sfd.FileName, " BÁO CÁO DOANH THU THÁNG " + dateMonth.Value.Month.ToString());
                            MessageBox.Show("Dữ liệu Export thành công!!!", "Info");
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Mô tả lỗi :" + ex.Message);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Không có bản ghi nào được Export!!!", "Info");
            }
        }
        void ExportDataTableToPdf(DataGridView dtblTable, String strPdfPath, string strHeader)
        {
            System.IO.FileStream fs = new FileStream(strPdfPath, FileMode.Create, FileAccess.Write, FileShare.None);
            Document document = new Document();
            document.SetPageSize(iTextSharp.text.PageSize.A4);
            PdfWriter writer = PdfWriter.GetInstance(document, fs);
            document.Open();
            //Report Header
            Font fntHead = FontFactory.GetFont("Arial", 16, BaseColor.GRAY);
            Paragraph prgHeading = new Paragraph();
            prgHeading.Alignment = Element.ALIGN_CENTER;
            prgHeading.Add(new Chunk(strHeader.ToUpper(), fntHead));
            document.Add(prgHeading);

            //Author
            Paragraph prgAuthor = new Paragraph();
            BaseFont btnAuthor = BaseFont.CreateFont(BaseFont.TIMES_ROMAN, BaseFont.CP1252, BaseFont.NOT_EMBEDDED);
            Font fntAuthor = FontFactory.GetFont("Arial", 8, BaseColor.GRAY);
            prgAuthor.Alignment = Element.ALIGN_RIGHT;
            prgAuthor.Add(new Chunk("\n Ngày xuất : " + DateTime.Now.ToShortDateString(), fntAuthor));
            document.Add(prgAuthor);

            //Add a line seperation
            Paragraph p = new Paragraph(new Chunk(new iTextSharp.text.pdf.draw.LineSeparator(0.0F, 100.0F, BaseColor.GRAY, Element.ALIGN_LEFT, 1)));
            document.Add(p);

            //Add line break
            document.Add(new Chunk("\n", fntHead));

            //Write the table
            PdfPTable pdfTable = new PdfPTable(dtblTable.Columns.Count);
            //Table header
            pdfTable.DefaultCell.Padding = 3;
            pdfTable.WidthPercentage = 100;
            pdfTable.HorizontalAlignment = Element.ALIGN_LEFT;
            Font arial = FontFactory.GetFont("Arial", 10, BaseColor.GRAY);
            foreach (DataGridViewColumn column in dtblTable.Columns)
            {
                PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText, arial));
                pdfTable.AddCell(cell);
            }

            DataTable dataTable = RevenueBUS.Instance.LoadRevenueList(dateMonth.Value.Month.ToString(), dateMonth.Value.Year.ToString());

            for (int i = 0; i < dataTable.Rows.Count; i++)
            {
                for (int j = 0; j < dataTable.Columns.Count; j++)
                {
                    pdfTable.AddCell(dataTable.Rows[i][j].ToString());
                }
            }
            document.Add(pdfTable);
            document.Close();
            writer.Close();
            fs.Close();
        }
        private void dateMonth_ValueChanged(object sender, EventArgs e)
        {
            LoadIncomelist();
        }

        public void Reload()
        {
            LoadIncomelist();
        }
    }
}
