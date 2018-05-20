using LibraryManagement.DbManager.Adaptor;
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
    public partial class tBooksMan2 : Form
    {
        private DauSachController _dauSachController;
        private TacGiaController _tacGiaController;
        private TheLoaiController _theLoaiController;
        private NhaXuatBanController _nhaXuatBanController;
        public tBooksMan2()
        {
            InitializeComponent();

            // khởi tạo phần chữ chìm trong ô tìm kiếm
            txtbTK1.ForeColor = Color.Silver;
            txtbTK2.ForeColor = Color.Silver;
            txtbTK3.ForeColor = Color.Silver;
            

            txtbTK1.Text = "Tìm kiếm sách...";
            txtbTK2.Text = "Tìm kiếm tác giả...";
            txtbTK3.Text = "Tìm kiếm NXB...";
            

            this.txtbTK1.Leave += new System.EventHandler(this.txtbTK1_Leave);
            this.txtbTK1.Enter += new System.EventHandler(this.txtbTK1_Enter);

            _dauSachController = new DauSachController();
            _tacGiaController = new TacGiaController();
            _theLoaiController = new TheLoaiController();
            _nhaXuatBanController = new NhaXuatBanController();
        }

        // code sự kiện chỉ nhập số trong ô trong giá
        private void textBox7_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        // code sự kiện chỉ nhập số trong số lượng
        private void textBox8_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        // code sự kiện chỉ nhập số trong năm xuất bản
        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        // chữ chìm cho ô tìm kiếm sách
        private void txtbTK1_Leave(object sender, EventArgs e)
        {
            if(txtbTK1.Text == "")
            {
                txtbTK1.Text = "Tìm kiếm sách...";
            }
        }
        // chữ chìm trong ô tìm kiếm sách
        private void txtbTK1_Enter(object sender, EventArgs e)
        {
            if(txtbTK1.Text == "Tìm kiếm sách...")
            {
                txtbTK1.Text = "";
            }
        }

        // chữ chìm trong ô tìm kiếm tác giả
        private void txtbTK2_Leave(object sender, EventArgs e)
        {
            if(txtbTK2.Text == "Tìm kiếm tác giả...")
            {
                txtbTK2.Text = "";
            }
        }
        // chữ chìm trong ô tìm kiếm tác giả
        private void txtbTK2_Enter(object sender, EventArgs e)
        {
            if (txtbTK2.Text == "Tìm kiếm sách...")
            {
                txtbTK2.Text = "";
            }
        }

        private void tBooksMan2_Load(object sender, EventArgs e)
        {
            dausachDgv.DataSource = DauSachAdaptor.GetListDauSachDto(_dauSachController.GetAllDauSach().Take(100).ToList());
            tacgiaDgv.DataSource = _tacGiaController.GetAll().Select(tg => new { tg.ID, tg.TenTacGia, tg.ThongTin }).ToList();
            nhaxuatbanCbx.DataSource = _nhaXuatBanController.GetAllByName();
            theLoaiCbx.DataSource = _theLoaiController.GetAllByName();
        }

        private void txtbTK1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                dausachDgv.DataSource = DauSachAdaptor.GetListDauSachDto(_dauSachController.SearchByName(txtbTK1.Text));
            }
            catch(Exception ex)
            {

            }
        }

        private void nhapTgBtn_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tacgiaTxb.Text))
            {
                _tacGiaController.Add(tentaggiaTxb.Text, thongtinTgRtb.Text);
                MessageBox.Show("Đã nhập thành công");
                tacgiaDgv.DataSource = _tacGiaController.GetAll();
            }
            else
            {
                MessageBox.Show("Bạn chưa nhập tên tác giả");
            }
        }

        private void txtbTK2_TextChanged(object sender, EventArgs e)
        {
            try
            {
                tacgiaDgv.DataSource = _tacGiaController.SearchByName(txtbTK2.Text);
            }
            catch(Exception ex)
            {

            }
        }

        private void tacgiaDgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int i = tacgiaDgv.CurrentCell.RowIndex;
                int id = Convert.ToInt32(tacgiaDgv.Rows[i].Cells[0].Value);
                TacGia tacGia = new TacGia();
                tacGia = _tacGiaController.GetById(id);
                tentaggiaTxb.Text = tacGia.TenTacGia;
                thongtinTgRtb.Text = tacGia.ThongTin;
            }
            catch(Exception ex)
            {

            }
        }

        private void nhapsachBtn_Click(object sender, EventArgs e)
        {
            if (nhapsachBtn.Text == "Nhập")
            {
                ResetTextBox();
                huyBtn.Visible = true;
                suasachBtn.Enabled = false;
                xoaBtn.Enabled = false;
                nhapsachBtn.Text = "OK";
                listTacgiaLb.Visible = false;
            }
            else
            {
                
                DauSach dauSach = new DauSach();
                dauSach.ID = 0;
                try
                {
                    dauSach.SoLuong = Convert.ToInt32(soLuongTxb.Text);
                    dauSach.NamXuatBan = Convert.ToInt32(namxuatbanTxb.Text);
                    dauSach.GiaThanh = Convert.ToInt32(giaTxb.Text);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Các trường số lượng, năm xuất bản, giá thành\nphải là số nguyên");
                    huyBtn.Visible = false;
                    suasachBtn.Enabled = true;
                    xoaBtn.Enabled = true;
                    nhapsachBtn.Text = "Nhập";
                    return;
                }
                if(_tacGiaController.FindIdByName(tacgiaTxb.Text) == -1)
                {
                    _tacGiaController.Add(tacgiaTxb.Text);
                    dauSach.IDTacGia = _tacGiaController.FindIdByName(tacgiaTxb.Text);
                }
                else
                {
                    dauSach.IDTacGia = _tacGiaController.FindIdByName(tacgiaTxb.Text);
                }
                dauSach.IDTheLoai = _theLoaiController.FindIdByName(theLoaiCbx.SelectedItem.ToString());
                dauSach.IDNhaXuatBan = _nhaXuatBanController.FindIdByName(nhaxuatbanCbx.SelectedItem.ToString());
                dauSach.TenSach = tensachTxb.Text;
                dauSach.KeSach = vitriTxb.Text;
                dauSach.TrangThai = "OK";
                if (_dauSachController.Add(dauSach))
                {
                    MessageBox.Show("Đã thêm thành công");
                }
                else
                {
                    MessageBox.Show("Không thể thêm dư liệu\nKiểm tra lại dữ liệu nhập");
                }

                huyBtn.Visible = false;
                suasachBtn.Enabled = true;
                xoaBtn.Enabled = true;
                nhapsachBtn.Text = "Nhập";
                dausachDgv.DataSource = DauSachAdaptor.GetListDauSachDto(_dauSachController.GetAllDauSach().Take(100).ToList());
            }
        }

        private void tacgiaTxb_TextChanged(object sender, EventArgs e)
        {
            listTacgiaLb.Visible = true;
            listTacgiaLb.DataSource = _tacGiaController.SearchByName(tacgiaTxb.Text);
        }

        private void listTacgiaLb_Click(object sender, EventArgs e)
        {
            try
            {
                tacgiaTxb.Text = listTacgiaLb.SelectedItem.ToString();
                listTacgiaLb.Visible = false;
            }
            catch(Exception ex)
            {

            }
        }

        private void suasachBtn_Click(object sender, EventArgs e)
        {
            if (suasachBtn.Text == "Sửa")
            {
                huyBtn.Visible = true;
                nhapsachBtn.Enabled = false;
                xoaBtn.Enabled = false;
                suasachBtn.Text = "OK";
            }
            else
            {
                try
                {
                    int i = dausachDgv.CurrentCell.RowIndex;
                    int id = Convert.ToInt32(dausachDgv.Rows[i].Cells[0].Value);
                    DauSach dauSach = new DauSach();
                    dauSach.ID = id;
                    dauSach.IDTacGia = _tacGiaController.FindIdByName(tacgiaTxb.Text);
                    dauSach.IDTheLoai = _theLoaiController.FindIdByName(theLoaiCbx.SelectedItem.ToString());
                    dauSach.IDNhaXuatBan = _nhaXuatBanController.FindIdByName(nhaxuatbanCbx.SelectedItem.ToString());
                    dauSach.TenSach = tensachTxb.Text;
                    dauSach.SoLuong = Convert.ToInt32(soLuongTxb.Text);
                    dauSach.NamXuatBan = Convert.ToInt32(namxuatbanTxb.Text);
                    dauSach.GiaThanh = Convert.ToInt32(giaTxb.Text);
                    dauSach.KeSach = vitriTxb.Text;
                    dauSach.TrangThai = "OK";
                    if (_dauSachController.Edit(dauSach))
                    {
                        MessageBox.Show("Đã sửa thành công");
                    }
                    else
                    {
                        MessageBox.Show("Không thể sửa dư liệu\nKiểm tra lại dữ liệu nhập");
                    }

                    huyBtn.Visible = false;
                    nhapsachBtn.Enabled = true;
                    xoaBtn.Enabled = true;
                    suasachBtn.Text = "Sửa";
                }
                catch (Exception ex)
                {
                    huyBtn.Visible = false;
                    nhapsachBtn.Enabled = true;
                    xoaBtn.Enabled = true;
                    suasachBtn.Text = "Sửa";
                    return;
                }
                dausachDgv.DataSource = DauSachAdaptor.GetListDauSachDto(_dauSachController.GetAllDauSach().Take(100).ToList());
            }
            
        }

        private void dausachDgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = dausachDgv.CurrentCell.RowIndex;
            int id = Convert.ToInt32(dausachDgv.Rows[i].Cells[0].Value);
            DauSach ds = _dauSachController.GetById(id);
            tacgiaTxb.Text = ds.TacGia.TenTacGia;
            tensachTxb.Text = ds.TenSach;
            giaTxb.Text = ds.GiaThanh.ToString();
            namxuatbanTxb.Text = ds.NamXuatBan.ToString();
            soLuongTxb.Text = ds.SoLuong.ToString();
            vitriTxb.Text = ds.KeSach;
            nhaxuatbanCbx.SelectedItem = ds.NhaXuatBan.TenNhaXuatBan;
            theLoaiCbx.SelectedItem = ds.TheLoai.TenTheLoai;

            listTacgiaLb.Visible = false;
        }

        private void nhaplaiBtn_Click(object sender, EventArgs e)
        {
            ResetTextBox();
        }

        private void ResetTextBox()
        {
            tacgiaTxb.Clear();
            tensachTxb.Clear();
            giaTxb.Clear();
            namxuatbanTxb.Clear();
            soLuongTxb.Clear();
            vitriTxb.Clear();
        }

        private void huyBtn_Click(object sender, EventArgs e)
        {
            nhapsachBtn.Enabled = true;
            suasachBtn.Enabled = true;
            xoaBtn.Enabled = true;
            suasachBtn.Text = "Sửa";
            nhapsachBtn.Text = "Nhập";
            huyBtn.Visible = false;
        }

        private void tBooksMan2_Click(object sender, EventArgs e)
        {
            listTacgiaLb.Visible = false;
        }

        private void tpSach_Click(object sender, EventArgs e)
        {
            listTacgiaLb.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dausachDgv.DataSource = DauSachAdaptor.GetListDauSachDto(_dauSachController.GetAllDauSach().Take(100).ToList());
        }

        private void suatacgiaBtn_Click(object sender, EventArgs e)
        {
            try
            {
                int i = tacgiaDgv.CurrentCell.RowIndex;
                int id = Convert.ToInt32(tacgiaDgv.Rows[i].Cells[0].Value);
                if(_tacGiaController.Edit(id, thongtinTgRtb.Text))
                {
                    MessageBox.Show("Đã sửa thành công");
                }
                else
                {
                    MessageBox.Show("Không thể sửa dữ liệu");
                }
                tacgiaDgv.DataSource = _tacGiaController.GetAll().Select(tg => new { tg.ID, tg.TenTacGia, tg.ThongTin }).ToList();
            }
            catch(Exception ex)
            {

            }
            
        }

        private void lammoiDgvtacgiaBtn_Click(object sender, EventArgs e)
        {
            tacgiaDgv.DataSource = _tacGiaController.GetAll().Select(tg=> new{tg.ID,tg.TenTacGia,tg.ThongTin}).ToList();
        }

        private void nhaplaitgBtn_Click(object sender, EventArgs e)
        {
            
        }

        private void nhapNxbBtn_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tenNxbTxb.Text))
            {
                _nhaXuatBanController.Add(tenNxbTxb.Text);
                nhaxuatbanDgv.DataSource = _nhaXuatBanController.GetAll();
                MessageBox.Show("Đã nhập thành công");
            }
            else
            {
                MessageBox.Show("Bạn chưa nhập tên NXB");
            }
        }

        private void nhaxuatbanDgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int i = nhaxuatbanDgv.CurrentCell.RowIndex;
                int id = Convert.ToInt32(nhaxuatbanDgv.Rows[i].Cells[0].Value);
                NhaXuatBan nxb = _nhaXuatBanController.GetById(id);
                tenNxbTxb.Text = nxb.TenNhaXuatBan;
            }
            catch(Exception ex)
            {

            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            try
            {
                int i = nhaxuatbanDgv.CurrentCell.RowIndex;
                int id = Convert.ToInt32(nhaxuatbanDgv.Rows[i].Cells[0].Value);
                _nhaXuatBanController.Edit(id, tenNxbTxb.Text);
            }
            catch (Exception ex)
            {

            }
        }

        private void lammoiDgvNXBBtn_Click(object sender, EventArgs e)
        {
            nhaxuatbanDgv.DataSource = _nhaXuatBanController.GetAll();
        }

        private void lammoiDgvTheloaiBtn_Click(object sender, EventArgs e)
        {
            theloaiDgv.DataSource = _theLoaiController.GetAll().Select(tl=>new {tl.ID,tl.TenTheLoai}).ToList();
        }

        private void nhaptheloaiBtn_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tentheloaiTxb.Text))
            {
                _theLoaiController.Add(tentheloaiTxb.Text);
                theloaiDgv.DataSource = _theLoaiController.GetAll();
                MessageBox.Show("Đã nhập thành công");
            }
            else
            {
                MessageBox.Show("Bạn chưa nhập tên thể loại");
            }
        }

        private void theloaiDgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int i = theloaiDgv.CurrentCell.RowIndex;
                int id = Convert.ToInt32(theloaiDgv.Rows[i].Cells[0].Value);
                TheLoai theLoai = new TheLoai();
                theLoai = _theLoaiController.GetById(id);
                tentheloaiTxb.Text = theLoai.TenTheLoai;
            }
            catch(Exception ex)
            {

            }
        }

        private void suatheloaiBtn_Click(object sender, EventArgs e)
        {
            try
            {
                int i = theloaiDgv.CurrentCell.RowIndex;
                int id = Convert.ToInt32(theloaiDgv.Rows[i].Cells[0].Value);
                _theLoaiController.Edit(id, tentheloaiTxb.Text);
                theloaiDgv.DataSource = _theLoaiController.GetAll();
                MessageBox.Show("Đã sửa thành công");
            }
            catch (Exception ex)
            {

            }
        }

        private void xoaBtn_Click(object sender, EventArgs e)
        {
            try
            {
                int i = dausachDgv.CurrentCell.RowIndex;
                int id = Convert.ToInt32(dausachDgv.Rows[i].Cells[0].Value);
                DialogResult result = MessageBox.Show("Bạn có muốn xóa tất cả quyển sách trong đầu sách không?", "",
                    MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);
                if (result == DialogResult.Yes)
                    _dauSachController.Remove(id, true);
                if(result == DialogResult.No)
                    _dauSachController.Remove(id, false);
                if(result == DialogResult.Cancel)
                    return;
                dausachDgv.DataSource = DauSachAdaptor.GetListDauSachDto(_dauSachController.GetAllDauSach().Take(100).ToList());
            }
            catch(Exception ex)
            {

            }
        }

        private void xoaTgBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Bạn có muốn xóa tác giả này không?", "",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
                {
                    int i = tacgiaDgv.CurrentCell.RowIndex;
                    int id = Convert.ToInt32(tacgiaDgv.Rows[i].Cells[0].Value);
                    _tacGiaController.Remove(id);
                }
                tacgiaDgv.DataSource = _tacGiaController.GetAll();
            }
            catch(Exception ex)
            {
            }
        }

        private void xoaNxbBtn_Click(object sender, EventArgs e)
        {
            int i = nhaxuatbanDgv.CurrentCell.RowIndex;
            int id = Convert.ToInt32(nhaxuatbanDgv.Rows[i].Cells[0].Value);
            _theLoaiController.Remove(id);
            nhaxuatbanDgv.DataSource = _nhaXuatBanController.GetAll();
        }

        private void xoaTheloaiBtn_Click(object sender, EventArgs e)
        {
            try
            {
                int i = theloaiDgv.CurrentCell.RowIndex;
                int id = Convert.ToInt32(theloaiDgv.Rows[i].Cells[0].Value);
                _theLoaiController.Remove(id);
                theloaiDgv.DataSource = _theLoaiController.GetAll();
            }
            catch(Exception ex)
            {

            }
        }

        private void xemcutheBtn_Click(object sender, EventArgs e)
        {
            try
            {
                int i = dausachDgv.CurrentCell.RowIndex;
                int id = Convert.ToInt32(dausachDgv.Rows[i].Cells[0].Value);
                tQuyenSach tQuyenSach = new tQuyenSach(id);
                tQuyenSach.ShowDialog();
            }
            catch (Exception)
            {

            }
        }
    }
}
