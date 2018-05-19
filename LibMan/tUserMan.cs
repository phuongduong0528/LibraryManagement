using LibraryManagement.DbManager.Adaptor;
using LibraryManagement.DbManager.Controller;
using LibraryManagement.DbManager.Dto;
using LibraryManagement.DbManager.Models;
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
    public partial class tUserMan : Form
    {
        private DocGiaController _docGiaController;
        private SinhVienController _sinhVienController;
        public tUserMan()
        {
            InitializeComponent();
            txtbTK1.Text = "Tìm kiếm độc giả...";
            _docGiaController = new DocGiaController();
            _sinhVienController = new SinhVienController();
        }

        private void txtbTK1_Leave(object sender, EventArgs e)
        {
            if (txtbTK1.Text == "")
            {
                txtbTK1.Text = "Tìm kiếm độc giả...";
            }
        }

        private void txtbTK1_Enter(object sender, EventArgs e)
        {
            if (txtbTK1.Text == "Tìm kiếm độc giả...")
            {
                txtbTK1.Text = "";
            }
        }

        private void tUserMan_Load(object sender, EventArgs e)
        {
            danhsachDgDgv.DataSource = 
                DocGiaAdaptor.GetListDocGiaDto(_docGiaController.GetAll());
        }

        private void nhapBtn_Click(object sender, EventArgs e)
        {
            if(nhapBtn.Text == "Nhập")
            {
                ResetTextBox();
                suaBtn.Enabled = false;
                xoaBtn.Enabled = false;
                nhapBtn.Text = "OK";
            }
            else
            {
                SinhVien sinhVien = new SinhVien();
                if (_sinhVienController.CheckMSV(msvTxb.Text))
                {
                    MessageBox.Show("Mã sinh viên đã tồn tại");
                    return;
                }
                sinhVien.MaSV = msvTxb.Text;
                sinhVien.HoTen = hotenTxb.Text;
                sinhVien.NgaySinh = ngaysinhDtp.Value;
                if (namRbt.Checked)
                    sinhVien.GioiTinh = "Nam";
                else
                    sinhVien.GioiTinh = "Nữ";
                sinhVien.DiaChi = diachiTxb.Text;
                sinhVien.SoDT = sdtTxb.Text;
                _sinhVienController.Add(sinhVien);
                _docGiaController.Add(sinhVien.MaSV, hanthethuvienDtp.Value.Year, "1234");

                suaBtn.Enabled = true;
                xoaBtn.Enabled = true;
                nhapBtn.Text = "Nhập";
            }
        }

        private void txtbTK1_TextChanged(object sender, EventArgs e)
        {
            if(comboBox1.SelectedIndex == 0)
            {
                danhsachDgDgv.DataSource = DocGiaAdaptor.GetListDocGiaDto(
                _docGiaController.SearchByID(txtbTK1.Text)
                );
            }
            if(comboBox1.SelectedIndex == 1)
            {
                danhsachDgDgv.DataSource = DocGiaAdaptor.GetListDocGiaDto(
                _docGiaController.SearchByMSV(txtbTK1.Text)
                );
            }
            if (comboBox1.SelectedIndex == 2)
            {
                danhsachDgDgv.DataSource = DocGiaAdaptor.GetListDocGiaDto(
                _docGiaController.SearchByName(txtbTK1.Text)
                );
            }

        }

        private void danhsachDgDgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int i = danhsachDgDgv.CurrentCell.RowIndex;
                string id = danhsachDgDgv.Rows[i].Cells[0].Value.ToString();
                DocGiaDto docGiaDto = new DocGiaDto();
                docGiaDto = DocGiaAdaptor.GetDocGiaDto(_docGiaController.GetByID(id));
                msvTxb.Text = docGiaDto.MaSV;
                hotenTxb.Text = docGiaDto.Ten;
                diachiTxb.Text = docGiaDto.DiaChi;
                sdtTxb.Text = docGiaDto.SoDT;
                ngaysinhDtp.Value = DateTime.ParseExact(docGiaDto.NgaySinh, "dd/MM/yyyy", CultureInfo.InvariantCulture);
                if (docGiaDto.GioiTinh.Equals("Nam"))
                    namRbt.Checked = true;
                else
                    nuRbt.Checked = true;
                hanthethuvienDtp.Value = DateTime.ParseExact(docGiaDto.HanThe, "dd/MM/yyyy", CultureInfo.InvariantCulture);
            }
            catch(Exception ex)
            {
            }
        }

        private void suaBtn_Click(object sender, EventArgs e)
        {
            if(suaBtn.Text == "Sửa")
            {
                suaBtn.Text = "OK";
                nhapBtn.Enabled = false;
                xoaBtn.Enabled = false;
                msvTxb.Enabled = false;
            }
            else
            {
                SinhVien sinhVien = new SinhVien();
                sinhVien.MaSV = msvTxb.Text;
                sinhVien.HoTen = hotenTxb.Text;
                sinhVien.NgaySinh = ngaysinhDtp.Value;
                if (namRbt.Checked)
                    sinhVien.GioiTinh = "Nam";
                else
                    sinhVien.GioiTinh = "Nữ";
                sinhVien.DiaChi = diachiTxb.Text;
                sinhVien.SoDT = sdtTxb.Text;
                if (_sinhVienController.Edit(sinhVien))
                {
                    MessageBox.Show("Sửa dữ liệu thành công");
                }
                else
                {
                    MessageBox.Show("Không thể sửa dữ liệu\n" +
                        "Hãy kiểm tra lại phần nhập liệu");
                }
                suaBtn.Text = "Sửa";
                nhapBtn.Enabled = true;
                xoaBtn.Enabled = true;
                msvTxb.Enabled = true;
            }
        }

        private void nhaplaiBtn_Click(object sender, EventArgs e)
        {
            ResetTextBox();
        }

        private void ResetTextBox() 
        {
            diachiTxb.Clear();
            hotenTxb.Clear();
            msvTxb.Clear();
            sdtTxb.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            danhsachDgDgv.DataSource =
                DocGiaAdaptor.GetListDocGiaDto(_docGiaController.GetAll());
        }

        private void huyBtn_Click(object sender, EventArgs e)
        {
            suaBtn.Enabled = true;
            xoaBtn.Enabled = true;
            nhapBtn.Text = "Nhập";
        }
    }
}
