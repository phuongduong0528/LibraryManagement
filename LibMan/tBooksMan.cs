using LibraryManagement.DbManager.Adaptor;
using LibraryManagement.DbManager.Controller;
using LibraryManagement.DbManager.Dto;
using LibraryManagement.DbManager.Models;
using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
        private string _userId;
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
            _userId = userId;
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
            try
            {
                foreach(DataGridViewRow selectedrows in sachmuonDgv.SelectedRows)
                {
                    sachmuonDgv.Rows.RemoveAt(selectedrows.Index);
                }
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
        }

        private void choMuonBtn_Click(object sender, EventArgs e)
        {
            PhieuMuonController phieuMuonController = new PhieuMuonController();
            DongPhieuMuonController dongPhieuMuonController = new DongPhieuMuonController();
            int idphieumuon = phieuMuonController.Add(_userId, idDocGiaTxb.Text,ngayHenTraDtp.Value);
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
                _dauSachDto = _dauSachDto = _dauSachs.SingleOrDefault(ds => ds.Id == Convert.ToInt32(lbshowMS.Text));
                foreach (QuyenSach quyensach in
                    _quyenSachController.GetAvailable(Convert.ToInt32(lbshowMS.Text), Convert.ToInt32(soLuongTxb.Text))
                    )
                {
                    _sachmuons.Add(quyensach);
                    _dauSachDto.SoLuongConLai -= 1;
                }
                sachmuonDgv.DataSource = null;
                sachmuonDgv.DataSource = _sachmuons.Select(sm => new {sm.ID,sm.DauSach.TenSach,sm.TinhTrang }).ToList();
                dausachDgv.DataSource = null;
                dausachDgv.DataSource = _dauSachs;
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
            //ngayHenTraDtp.Text = "Ngày hẹn trả: " + phieuMuonDto.HanTraSach;
            listIdPhieuMuon.Visible = false;
        }

        private void LoadGridView()
        {
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
                
            }
            catch(Exception ex)
            {
                MessageBox.Show("Bạn chưa chọn trong bảng");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //if(sachmuonDgv.DataSource != null)
            //{
            DocGia docGia = _docGiaController.GetByID(idDocGiaTxb.Text);


            ExcelPackage excelPackage = new ExcelPackage();
            ExcelWorksheet excelWorksheet = excelPackage.Workbook.Worksheets.Add("PhieuMuon");
            excelWorksheet.Cells["A1"].Value = "Mã độc giả";
            excelWorksheet.Cells["B1"].Value = docGia.ID;
            excelWorksheet.Cells["B1"].Style.Font.Bold = true;
            excelWorksheet.Cells["C1"].Value = "Tên độc giả";
            excelWorksheet.Cells["D1"].Value = docGia.SinhVien.HoTen;
            excelWorksheet.Cells["D1"].Style.Font.Bold = true;
            excelWorksheet.Cells["A2"].Value = "Số lượng mượn";
            excelWorksheet.Cells["A3"].Value = "Ngày mượn";
            excelWorksheet.Cells["B3"].Value = DateTime.Now.ToString("dd/MM/yyyy");
            excelWorksheet.Cells["C3"].Style.Font.Bold = true;
            excelWorksheet.Cells["A4"].Value = "Danh sách sách mượn";
            excelWorksheet.Cells["A4:D4"].Merge = true;
            excelWorksheet.Cells["A4:D4"].Style.Font.Bold = true;
            excelWorksheet.Cells["A4:D4"].Style.Font.Size = 20f;
            excelWorksheet.Cells["A4:D4"].Style.HorizontalAlignment = OfficeOpenXml.Style.ExcelHorizontalAlignment.Center;

            ExcelRange range = excelWorksheet.Cells[1,1,3,4];
            range.Style.Font.Size = 12.0f;

            excelPackage.SaveAs(new System.IO.FileInfo(@"C:\Users\HP\Desktop\phieumuon.xlsx"));
            //}
        }
    }
}
