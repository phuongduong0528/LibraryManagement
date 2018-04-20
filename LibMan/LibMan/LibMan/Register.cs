using LibraryManagement.DbManager.Controller;
using LibraryManagement.DbManager.Models;
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
    public partial class Register : Form
    {
        private SinhVienController _sinhVienController;
        private DocGiaController _docGiaController;
        public Register()
        {
            InitializeComponent();
            _sinhVienController = new SinhVienController();
            _docGiaController = new DocGiaController();
        }

        // code cho nút Nhập lại
        private void btnNhapLai_Click(object sender, EventArgs e)
        {
            txtbMaSV.ResetText();
            txtbHoten.ResetText();
            dtpNgaysinh.ResetText();
            cbbGioitinh.ResetText();
            txtbDiachi.ResetText();
            txtbSDT.ResetText();
            txtbHanthe.ResetText();
        }

        private void btnThemMoi_Click(object sender, EventArgs e)
        {
            SinhVien sinhVien = new SinhVien();
            sinhVien.MaSV = txtbMaSV.Text;
            sinhVien.HoTen = txtbHoten.Text;
            sinhVien.NgaySinh = dtpNgaysinh.Value.Date;
            sinhVien.GioiTinh = cbbGioitinh.SelectedItem.ToString();
            sinhVien.DiaChi = txtbDiachi.Text;
            sinhVien.SoDT = txtbSDT.Text;
            if (_sinhVienController.Validate(sinhVien.MaSV))
            {
                MessageBox.Show("MaSV đã tồn tại, bạn hãy nhập lại mã khác");
            }
            else
            {
                if (_sinhVienController.AddNew(sinhVien))
                {
                    _docGiaController.AddNew(txtbMaSV.Text, Convert.ToInt32(txtbHanthe.Text), "1234");
                    MessageBox.Show("Đã thêm thành công bạn đọc");
                    btnNhapLai_Click(sender, e);
                }
            }
        }

        private void Register_Load(object sender, EventArgs e)
        {
            cbbGioitinh.SelectedIndex = 0;
        }

        private void txtbHanthe_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
