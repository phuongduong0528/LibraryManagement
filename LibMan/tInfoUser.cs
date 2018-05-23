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
using LibraryManagement.DbManager.Controller;
using LibraryManagement.DbManager.Models;

namespace LibMan
{
    public partial class tInfoUser : Form
    {
        private string _userID;
        private string _maSv;
        private DocGiaController _docGiaController;
        private SinhVienController _sinhVienController;
        public tInfoUser()
        {
            InitializeComponent();
        }

        public tInfoUser(string userID)
        {
            InitializeComponent();
            _userID = userID;
            _docGiaController = new DocGiaController();
            _sinhVienController = new SinhVienController();
        }

        private void tInfoUser_Load(object sender, EventArgs e)
        {
            DocGia docGia = _docGiaController.GetByID(_userID);
            _maSv = docGia.SinhVien.MaSV;

            maBanDocTxb.Text = docGia.ID;
            HoTenTxb.Text = docGia.SinhVien.HoTen;
            gioiTinhTxb.Text = docGia.SinhVien.GioiTinh;
            ngaySinhTxb.Text = docGia.SinhVien.NgaySinh.ToString("dd/MM/yyyy", CultureInfo.InvariantCulture);
            diaChiTxb.Text = docGia.SinhVien.SoDT;
            sdtTxb.Text = docGia.SinhVien.SoDT;
        }

        private void xacNhanBtn_Click(object sender, EventArgs e)
        {
            SinhVien sv = new SinhVien();
            sv.MaSV = _maSv;
            sv.HoTen = HoTenTxb.Text;
            try
            {
                sv.NgaySinh = DateTime.ParseExact(ngaySinhTxb.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ngày sinh sai định dạng");
                return;
            }

            if (gioiTinhTxb.Text == "Nam" || gioiTinhTxb.Text == "Nữ")
            {
                sv.GioiTinh = gioiTinhTxb.Text;
            }
            else
            {
                MessageBox.Show("Giới tính phải là Nam hoặc Nữ");
                return;
            }
            sv.DiaChi = diaChiTxb.Text;
            sv.SoDT = sdtTxb.Text;
            if (_sinhVienController.Edit(sv))
            {
                MessageBox.Show("Đã sửa thông tin thành công");
            }
            else
            {
                MessageBox.Show("Không thể sửa thông tin");
            }
        }
    }
}
