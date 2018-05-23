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
    public partial class tThongKeSach : Form
    {
        private DauSachController _dauSachController;
        private TheLoaiController _theLoaiController;
        private TacGiaController _tacGiaController;
        public tThongKeSach()
        {
            InitializeComponent();
            _dauSachController = new DauSachController();
            _theLoaiController = new TheLoaiController();
            _tacGiaController = new TacGiaController();
        }

        private void loaiThongKeCbx_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (loaiThongKeCbx.SelectedIndex)
            {
                case 0:
                    ketquaTkDgv.DataSource = SachMuonNhieuAdaptor.GetListSachMuonNhieuDtos(
                        _dauSachController.GetAllDauSach());
                    break;
                case 1:
                    ThongKeSachTheoTheLoai();
                    break;
                case 2:
                    ThongKeSachTheoTacGia();
                    break;
            }
        }

        private void ThongKeSachTheoTheLoai()
        {
            ketquaTkDgv.DataSource = _theLoaiController.GetListNumberOfBooks();
            ketquaTkDgv.Columns[1].HeaderText = "Tên thể loại";
            ketquaTkDgv.Columns[2].HeaderText = "Số lượng";
        }

        private void ThongKeSachTheoTacGia()
        {
            ketquaTkDgv.DataSource = _tacGiaController.GetListNumberOfBooks();
            ketquaTkDgv.Columns[1].HeaderText = "Tên tác giả";
            ketquaTkDgv.Columns[2].HeaderText = "Số lượng";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ExcelPackage excelPackage = new ExcelPackage();
            ExcelWorksheet excelWorksheets =  excelPackage.Workbook.Worksheets.Add("Thong ke sach");
            switch (loaiThongKeCbx.SelectedIndex)
            {
                case 0:
                    excelWorksheets.Cells["A1"].Value = "Sách mượn nhiều";
                    excelWorksheets.Cells["A3"].Value = "ID Sách";
                    excelWorksheets.Cells["B3"].Value = "Tên sách";
                    excelWorksheets.Cells["C3"].Value = "Tác giả";
                    excelWorksheets.Cells["D3"].Value = "NXB";
                    excelWorksheets.Cells["E3"].Value = "Thể loại";
                    excelWorksheets.Cells["F3"].Value = "Số lượt mượn";
                    excelWorksheets.Cells["A3:F3"].Style.Font.Bold = true;
                    break;
                case 1:
                    excelWorksheets.Cells["A1"].Value = "Thống số lượng kê sách theo thể loại";
                    excelWorksheets.Cells["A3"].Value = "ID Sách";
                    excelWorksheets.Cells["B3"].Value = "Thể loại";
                    excelWorksheets.Cells["C3"].Value = "Số lượng";
                    excelWorksheets.Cells["A3:C3"].Style.Font.Bold = true;
                    break;
                case 2:
                    excelWorksheets.Cells["A1"].Value = "Thống kê số lượng sách theo tác giả";
                    excelWorksheets.Cells["A3"].Value = "ID Sách";
                    excelWorksheets.Cells["B3"].Value = "Tác giả";
                    excelWorksheets.Cells["C3"].Value = "Số lượng";
                    excelWorksheets.Cells["A3:C3"].Style.Font.Bold = true;
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
                    excelWorksheets.Cells[i + 4, j+1].Value = 
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
            excelPackage.SaveAs(new FileInfo(path + @"\thongkesach.xlsx"));
            MessageBox.Show("Đã xuất thành công thống kê");
        }
    }
}
