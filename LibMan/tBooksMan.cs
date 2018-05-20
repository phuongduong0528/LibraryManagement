using LibraryManagement.DbManager.Adaptor;
using LibraryManagement.DbManager.Controller;
using LibraryManagement.DbManager.Dto;
using LibraryManagement.DbManager.Models;
using OfficeOpenXml;
using OfficeOpenXml.Style;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibMan
{
    public partial class tBooksMan : Form
    {
        private DauSachController _dauSachController;
        private QuyenSachController _quyenSachController;
        private DocGiaController _docGiaController;
        private PhieuMuonController _phieuMuonController;
        private DongPhieuMuonController _dongphieuMuonController;
        private DauSach _dauSach;
        private DauSachDto _dauSachDto;
        List<QuyenSach> _sachmuons;
        List<DauSachDto> _dauSachs;
        List<DongPhieuMuonDto> _dongPhieuMuonDtos;
        private string _NQLuserId;
        int _idphieumuon;

        public tBooksMan()
        {
            InitializeComponent();
            _dauSachController = new DauSachController();
            _dauSach = new DauSach();
            _dauSachDto = new DauSachDto();
            _sachmuons = new List<QuyenSach>();
            _quyenSachController = new QuyenSachController();
            _dauSachs = new List<DauSachDto>();
            _docGiaController = new DocGiaController();
            _phieuMuonController = new PhieuMuonController();
            _dongphieuMuonController = new DongPhieuMuonController();
            _dongPhieuMuonDtos = new List<DongPhieuMuonDto>();
        }

        public tBooksMan(string userId)
        {
            InitializeComponent();
            _dauSachController = new DauSachController();
            _dauSach = new DauSach();
            _dauSachDto = new DauSachDto();
            _NQLuserId = userId;
            _sachmuons = new List<QuyenSach>();
            _quyenSachController = new QuyenSachController();
            _dauSachs = new List<DauSachDto>();
            _docGiaController = new DocGiaController();
            _phieuMuonController = new PhieuMuonController();
            _dongphieuMuonController = new DongPhieuMuonController();
            _dongPhieuMuonDtos = new List<DongPhieuMuonDto>();
        }

        private void xoaBtn_Click(object sender, EventArgs e)
        {
            DauSachDto tempDsDto = new DauSachDto();
            try
            {
                QuyenSach qs = new QuyenSach();
                if(sachmuonDgv.SelectedRows.Count != 0)
                {
                    foreach (DataGridViewRow rows in sachmuonDgv.SelectedRows)
                    {
                        qs = _sachmuons.SingleOrDefault(sm => sm.ID.Equals(rows.Cells[0].Value.ToString()));
                        tempDsDto = _dauSachs.SingleOrDefault(ds => ds.Id.Equals(qs.IDDauSach));
                        tempDsDto.SoLuongConLai += 1;
                        _sachmuons.Remove(qs);
                    }
                }
                else
                {
                    int i = sachmuonDgv.CurrentCell.RowIndex;
                    string id = sachmuonDgv.Rows[i].Cells[0].Value.ToString();
                    qs = _sachmuons.SingleOrDefault(sm => sm.ID.Equals(id));
                    tempDsDto = _dauSachs.SingleOrDefault(ds => ds.Id.Equals(qs.IDDauSach));
                    tempDsDto.SoLuongConLai += 1;
                    _sachmuons.Remove(qs);
                }
                sachmuonDgv.DataSource = _sachmuons.Select(sm => new { sm.ID, sm.DauSach.TenSach, sm.TinhTrang }).ToList();
                dausachDgv.DataSource = _dauSachs.Where(ds => ds.TenSach.Contains(timkiemsachTxb.Text)).ToList();
            }
            catch(Exception ex)
            {

            }
        }

        private void timkiemsachTxb_TextChanged(object sender, EventArgs e)
        {
            dausachDgv.DataSource = _dauSachs.Where(ds=>ds.TenSach.Contains(timkiemsachTxb.Text)).ToList();
        }

        private void dausachDgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                LoadThongTinSach();
            }
            catch (Exception ex)
            {

            }
        }

        private void LoadThongTinSach()
        {
            int i = dausachDgv.CurrentCell.RowIndex;
            int sachId = Convert.ToInt32(dausachDgv.Rows[i].Cells[0].Value);
            //_dauSachDto = DauSachAdaptor.GetDauSachDto(_dauSachController.GetById(sachId));
            _dauSachDto = _dauSachs.SingleOrDefault(ds => ds.Id == sachId);
            lbshowMS.Text = _dauSachDto.Id.ToString();
            lbshowTen.Text = _dauSachDto.TenSach;
            lbshowSL.Text = _dauSachDto.SoLuongConLai.ToString();
            lbshowTG.Text = _dauSachDto.TacGia;
            lbshowTL.Text = _dauSachDto.TheLoai;
            lbshowNXB.Text = _dauSachDto.NhaXuatBan;
            lbshowNam.Text = _dauSachDto.NamXuatBan.ToString();
            soluongmuonLbl.Text = "Số lượng mượn: " + sachmuonDgv.RowCount.ToString();
        }

        private void choMuonBtn_Click(object sender, EventArgs e)
        {
            PhieuMuonController phieuMuonController = new PhieuMuonController();
            DongPhieuMuonController dongPhieuMuonController = new DongPhieuMuonController();
            if(_docGiaController.GetByID(idDocGiaTxb.Text) == null)
            {
                MessageBox.Show("Mã độc giả chưa chọn");
                return;
            }
            int idphieumuon = phieuMuonController.Add(_NQLuserId, idDocGiaTxb.Text,ngayHenTraDtp.Value);
            if(idphieumuon == -1)
            {
                MessageBox.Show("Không thể cho mượn");
                return;
            }
            List<string> idquyensach = new List<string>();
            for(int i = 0; i < sachmuonDgv.RowCount; i++)
            {
                idquyensach.Add(sachmuonDgv.Rows[i].Cells[0].Value.ToString());
            }
            if(dongPhieuMuonController.Add(idphieumuon, idquyensach))
            {
                MessageBox.Show("Đã mượn thành công!");
                this.Close();
            }
        }

        private void tBooksMan_Load(object sender, EventArgs e)
        {
            ngayHenTraDtp.Value = DateTime.Now + new TimeSpan(7,0,0,0);
            _dauSachs = DauSachAdaptor.GetListDauSachDto(_dauSachController
                .SearchByName(timkiemsachTxb.Text));
            ngaymuonLbl.Text = "Ngày mượn: " + DateTime.Now.ToString("dd/MM/yyyy");
            tinhtrangsachCbx.SelectedIndex = 0;
        }

        private void txtbSoluong_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void muonMoiBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if(lbshowMS.Equals("-"))
                {
                    MessageBox.Show("Bạn chưa chọn sách");
                    return;
                }
                if (_dauSachDto.SoLuongConLai == 0)
                {
                    MessageBox.Show("Sách đã mượn hết");
                    return;
                }
                if(Convert.ToInt32(soLuongTxb.Text) > _dauSachDto.SoLuongConLai)
                {
                    MessageBox.Show("Số lượng sách vượt quá số lượng còn");
                    return;
                }
                _dauSachDto = _dauSachs.SingleOrDefault(ds => ds.Id == Convert.ToInt32(lbshowMS.Text));
                int soluong = Convert.ToInt32(soLuongTxb.Text);
                foreach (QuyenSach quyensach in
                    _quyenSachController.GetAvailable(Convert.ToInt32(lbshowMS.Text))
                    )
                {
                    
                    if(soluong == 0)
                    {
                        break;
                    }
                    if (_sachmuons.Any(sm => sm.ID.Equals(quyensach.ID)))
                    {
                        continue;
                    }
                    _sachmuons.Add(quyensach);
                    _dauSachDto.SoLuongConLai -= 1;
                    soluong--;
                }
                sachmuonDgv.DataSource = null;
                sachmuonDgv.DataSource = _sachmuons.Select(sm => new {sm.ID,sm.DauSach.TenSach,sm.TinhTrang }).ToList();
                dausachDgv.DataSource = null;
                dausachDgv.DataSource = _dauSachs.Where(ds => ds.TenSach.Contains(timkiemsachTxb.Text)).ToList();
                LoadThongTinSach();
            }
            catch (Exception ex)
            {

            }
        }

        private void xemBtn_Click(object sender, EventArgs e)
        {
            dausachDgv.DataSource = null;
            dausachDgv.DataSource = _dauSachs.Where(ds => ds.TenSach.Contains(timkiemsachTxb.Text)).ToList();
        }

        private void idDocGiaTxb_TextChanged(object sender, EventArgs e)
        {
            listIdDocGia.Visible = true;
            listIdDocGia.DataSource = _docGiaController.SearchByID_string(idDocGiaTxb.Text);
        }

        private void listIdDocGia_Click(object sender, EventArgs e)
        {
            try
            {
                idDocGiaTxb.Text = listIdDocGia.SelectedItem.ToString();
                DocGia docGia = _docGiaController.GetByID(idDocGiaTxb.Text);
                madocgiaLbl.Text = "Mã độc giả: " + docGia.ID;
                tendocgiaLbl.Text = "Tên độc giả: " + docGia.SinhVien.HoTen;
                listIdDocGia.Visible = false;
            }
            catch (Exception ex)
            {
                
            }
            
        }

        private void tBooksMan_Click(object sender, EventArgs e)
        {
            listIdDocGia.Visible = false;
        }

        private void idPhieuMuonTxb_TextChanged_1(object sender, EventArgs e)
        {
            listIdPhieuMuon.Visible = true;
            listIdPhieuMuon.DataSource = _phieuMuonController.GetId(idPhieuMuonTxb.Text);
        }

        private void ListIdPhieuMuon_Click(object sender, EventArgs e)
        {
            idPhieuMuonTxb.Text = listIdPhieuMuon.SelectedItem.ToString();
            _idphieumuon = Convert.ToInt32(idPhieuMuonTxb.Text);
            LoadGridView();
            PhieuMuonDto phieuMuonDto = new PhieuMuonDto();
            phieuMuonDto = PhieuMuonAdaptor.GetPhieuMuonDto(_phieuMuonController.GetById(_idphieumuon));
            tendocgiaLbl2.Text = "Tên độc giả: " + phieuMuonDto.DocGia;
            iddocgiaLbl.Text = "ID Độc giả: " + phieuMuonDto.IdDocGia;
            nguoichomuonLbl.Text = "Người cho mượn: " + phieuMuonDto.NguoiQl;
            hantraDtp2.Value = DateTime.ParseExact(phieuMuonDto.HanTraSach, "dd/MM/yyyy", CultureInfo.InvariantCulture);
            //ngayHenTraDtp.Text = "Ngày hẹn trả: " + phieuMuonDto.HanTraSach;
            listIdPhieuMuon.Visible = false;
        }

        private void LoadGridView()
        {
            dataGridView2.DataSource = null;
            dataGridView2.DataSource =
                            DongPhieuMuonAdaptor.GetListDongPhieuMuonDto(
                                _dongphieuMuonController.GetListByPhieuMuon(_idphieumuon)
                                );
        }

        private void trasachBtn_Click(object sender, EventArgs e)
        {
            try
            {
                int i = dataGridView2.CurrentCell.RowIndex;
                int iddongphieu = Convert.ToInt32(dataGridView2.Rows[i].Cells[0].Value);
                int tienphat = 0;
                if(tinhtrangsachCbx.SelectedIndex == 2)
                {
                    QuyenSach qs = _quyenSachController.GetById(dataGridView2.Rows[i].Cells[2].Value.ToString());
                    tienphat = qs.DauSach.GiaThanh;
                }
                if(dataGridView2.Rows[i].Cells[6].Value.ToString() != "")
                {
                    MessageBox.Show("Sách đã trả");
                    return;
                }
                if(_dongphieuMuonController.Edit(_idphieumuon, iddongphieu, DateTime.Now,
                    tinhtrangsachCbx.SelectedItem.ToString(), richTextBox1.Text, tienphat)
                    )
                {
                    MessageBox.Show("Trả sách thành công");
                    LoadGridView();
                }

                _dauSachs = DauSachAdaptor.GetListDauSachDto(_dauSachController
               .SearchByName(timkiemsachTxb.Text));
            }
            catch(Exception ex)
            {
                MessageBox.Show("Bạn chưa chọn trong bảng");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {

            if (_docGiaController.GetByID(idDocGiaTxb.Text) == null)
            {
                MessageBox.Show("Mã độc giả chưa chọn");
                return;
            }
            if (sachmuonDgv.DataSource != null)
            {
                DocGia docGia = _docGiaController.GetByID(idDocGiaTxb.Text);

                ExcelPackage excelPackage = new ExcelPackage();
                ExcelWorksheet excelWorksheet = excelPackage.Workbook.Worksheets.Add("PhieuMuon");

                excelWorksheet.Cells["A1"].Value = "Mã độc giả";
                excelWorksheet.Cells["B1"].Value = docGia.ID;
                excelWorksheet.Cells["B1"].Style.Font.Bold = true;

                excelWorksheet.Cells["A2"].Value = "Tên độc giả";
                excelWorksheet.Cells["B2"].Value = docGia.SinhVien.HoTen;
                excelWorksheet.Cells["B2"].Style.Font.Bold = true;

                excelWorksheet.Cells["A3"].Value = "Số lượng mượn";
                excelWorksheet.Cells["B3"].Value = sachmuonDgv.RowCount;
                excelWorksheet.Cells["B3"].Style.Font.Bold = true;
                excelWorksheet.Cells["B3"].Style.HorizontalAlignment = ExcelHorizontalAlignment.Left;

                excelWorksheet.Cells["A4"].Value = "Ngày mượn";
                excelWorksheet.Cells["B4"].Value = DateTime.Now.ToString("dd/MM/yyyy");
                excelWorksheet.Cells["B4"].Style.Font.Bold = true;

                excelWorksheet.Cells["A5"].Value = "Danh sách sách mượn";
                excelWorksheet.Cells["A5:D5"].Merge = true;
                excelWorksheet.Cells["A5:D5"].Style.Font.Bold = true;
                excelWorksheet.Cells["A5:D5"].Style.Font.Size = 20f;
                excelWorksheet.Cells["A5:D5"].Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;

                //Đầu đề bảng
                excelWorksheet.Cells["A6"].Value = "ID Quyển sách";
                excelWorksheet.Cells["B6"].Value = "Tên sách";
                excelWorksheet.Cells["C6"].Value = "Ngày trả";
                excelWorksheet.Cells["D6"].Value = "Tình trạng";
                excelWorksheet.Cells["A6:D6"].Style.Font.Bold = true;

                //Copy từ GridView vào Excel
                for (int i = 0; i < sachmuonDgv.ColumnCount-1; i++)
                {
                    for (int j = 0; j < sachmuonDgv.RowCount; j++)
                    {
                        excelWorksheet.Cells[j + 7, i + 1].Value =
                            sachmuonDgv.Rows[j].Cells[i].Value.ToString();
                    }
                }

                //Độ rộng cột
                excelWorksheet.Column(2).Width = 52.0;
                excelWorksheet.Column(1).Width = 20.0;

                //Vẽ đường viền
                int maxRowIndex = sachmuonDgv.RowCount + 6;
                int maxColumnIndex = sachmuonDgv.ColumnCount + 1;
                excelWorksheet.Cells[6, 1, maxRowIndex, maxColumnIndex].Style.Border.Top.Style = ExcelBorderStyle.Thin;
                excelWorksheet.Cells[6, 1, maxRowIndex, maxColumnIndex].Style.Border.Bottom.Style = ExcelBorderStyle.Thin;
                excelWorksheet.Cells[6, 1, maxRowIndex, maxColumnIndex].Style.Border.Left.Style = ExcelBorderStyle.Thin;
                excelWorksheet.Cells[6, 1, maxRowIndex, maxColumnIndex].Style.Border.Right.Style = ExcelBorderStyle.Thin;

                ExcelRange range = excelWorksheet.Cells[1, 1, 3, 4];
                range.Style.Font.Size = 12.0f;

                //Tự động phát hiện desktop folder
                string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                excelPackage.SaveAs(new System.IO.FileInfo(path + @"\phieumuon.xlsx"));
            }
           
        }

        private void giahantraBtn_Click(object sender, EventArgs e)
        {
            try
            {
                int i = dataGridView2.CurrentCell.RowIndex;
                int iddongphieu = Convert.ToInt32(dataGridView2.Rows[i].Cells[0].Value);
                if (dataGridView2.Rows[i].Cells[6].Value.ToString() != "")
                {
                    MessageBox.Show("Sách đã trả");
                    return;
                }
                if (hantraDtp2.Value < DateTime.Now)
                {
                    MessageBox.Show("Ngày trả sách không hợp lệ");
                }
                else
                {
                    _phieuMuonController.Edit(_idphieumuon, hantraDtp2.Value);
                    MessageBox.Show("Gia hạn trả thành công");
                    LoadGridView();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Chưa chọn dữ liệu");
            }
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
