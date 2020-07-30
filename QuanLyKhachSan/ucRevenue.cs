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
                            RevenueBUS.Instance.ExportDataTableToPdf(dtgvIncome, sfd.FileName, " BÁO CÁO DOANH THU THÁNG " + dateMonth.Value.Month.ToString(), dateMonth.Value.Month.ToString(), dateMonth.Value.Year.ToString());
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
