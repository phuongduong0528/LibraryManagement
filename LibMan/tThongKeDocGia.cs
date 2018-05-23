using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibraryManagement.DbManager.Adaptor;
using LibraryManagement.DbManager.Controller;
using OfficeOpenXml;
using OfficeOpenXml.Style;

namespace LibMan
{
    public partial class tThongKeDocGia : Form
    {
        private DocGiaController _docGiaController;
        public tThongKeDocGia()
        {
            InitializeComponent();
            _docGiaController = new DocGiaController();
        }

        private void tThongKeDocGia_Load(object sender, EventArgs e)
        {

        }

        private void loaiThongKeCbx_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (loaiThongKeCbx.SelectedIndex)
            {
                case 0:
                    LoadGridViewDocGiaMuonNhieu();
                    break;
                case 1:
                    LoadGridViewDocGiaMoi();
                    break;
            }
        }

        private void LoadGridViewDocGiaMoi()
        {
            DateTime date1 = DateTime.Now.Date - new TimeSpan(30, 0, 0, 0);
            DateTime date2 = DateTime.Now.Date;
            ketquaTkDgv.DataSource = DocGiaAdaptor.GetListDocGiaDto(_docGiaController.GetByRegisterDate(date1, date2));
        }

        private void LoadGridViewDocGiaMuonNhieu()
        {
            ketquaTkDgv.DataSource = _docGiaController.BookedTimesPerReader();
            ketquaTkDgv.Columns[0].HeaderText = "ID";
            ketquaTkDgv.Columns[1].HeaderText = "Họ tên";
            ketquaTkDgv.Columns[2].HeaderText = "Số lần mượn";
            ketquaTkDgv.Columns[3].HeaderText = "Số sách mượn";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ExcelPackage excelPackage = new ExcelPackage();
            ExcelWorksheet excelWorksheets = excelPackage.Workbook.Worksheets.Add("Thong ke sach");
            switch (loaiThongKeCbx.SelectedIndex)
            {
                case 0:
                    excelWorksheets.Cells["A1"].Value = "Độc giả mượn nhiều";
                    excelWorksheets.Cells["A3"].Value = "ID";
                    excelWorksheets.Cells["B3"].Value = "Họ tên";
                    excelWorksheets.Cells["C3"].Value = "Số lần mượn";
                    excelWorksheets.Cells["D3"].Value = "Số sách mượn";
                    excelWorksheets.Cells["A3:D3"].Style.Font.Bold = true;
                    break;
                case 1:
                    excelWorksheets.Cells["A1"].Value = "Độc giả mới";
                    excelWorksheets.Cells["A3"].Value = "ID";
                    excelWorksheets.Cells["B3"].Value = "Mã SV";
                    excelWorksheets.Cells["D3"].Value = "Tên";
                    excelWorksheets.Cells["E3"].Value = "Ngày sinh";
                    excelWorksheets.Cells["F3"].Value = "Giới tính";
                    excelWorksheets.Cells["G3"].Value = "Địa chỉ";
                    excelWorksheets.Cells["H3"].Value = "Số ĐT";
                    excelWorksheets.Cells["I3"].Value = "Ngày đăng kí";
                    excelWorksheets.Cells["J3"].Value = "Hạn thẻ";
                    excelWorksheets.Cells["K3"].Value = "Trạng thái";
                    excelWorksheets.Cells["A3:K3"].Style.Font.Bold = true;
                    break;
            }

            excelWorksheets.Cells["A1:D1"].Merge = true;
            excelWorksheets.Cells["A1:D1"].Style.Font.Bold = true;
            excelWorksheets.Cells["A1:D1"].Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
            excelWorksheets.Cells["A1:D1"].Style.Font.Size = 16f;

            for (int i = 0; i < ketquaTkDgv.RowCount; i++)
            {
                for (int j = 0; j < ketquaTkDgv.ColumnCount; j++)
                {
                    excelWorksheets.Cells[i + 4, j + 1].Value =
                        ketquaTkDgv.Rows[i].Cells[j].Value.ToString();
                }
            }

            int rowcount = ketquaTkDgv.RowCount;
            int columncount = ketquaTkDgv.ColumnCount;

            excelWorksheets.Cells[3, 1, 3 + rowcount, columncount].Style.Border.Top.Style = ExcelBorderStyle.Medium;
            excelWorksheets.Cells[3, 1, 3 + rowcount, columncount].Style.Border.Bottom.Style = ExcelBorderStyle.Medium;
            excelWorksheets.Cells[3, 1, 3 + rowcount, columncount].Style.Border.Left.Style = ExcelBorderStyle.Medium;
            excelWorksheets.Cells[3, 1, 3 + rowcount, columncount].Style.Border.Right.Style = ExcelBorderStyle.Medium;

            excelWorksheets.Cells[3, 1, 3 + rowcount, 1 + columncount].Style.Font.Size = 12f;

            string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            excelPackage.SaveAs(new FileInfo(path + @"\thongkedocgia.xlsx"));
            MessageBox.Show("Đã xuất thành công thống kê");
        }
    }
}
