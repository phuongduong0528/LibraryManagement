using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibraryManagement.DbManager.Adaptor;
using LibraryManagement.DbManager.Controller;
using LibraryManagement.DbManager.Models;

namespace LibMan
{
    public partial class tQuyenSach : Form
    {
        private int _idDauSach;
        private string _idQuyenSach;
        private DauSachController _dauSachController;
        private QuyenSachController _quyenSachController;
        public tQuyenSach()
        {
            InitializeComponent();
        }

        public tQuyenSach(int idDauSach)
        {
            InitializeComponent();
            _idDauSach = idDauSach;
            _dauSachController = new DauSachController();
            _quyenSachController = new QuyenSachController();
        }

        private void tQuyenSach_Load(object sender, EventArgs e)
        {
            DauSach dauSach = _dauSachController.GetById(_idDauSach);
            tensachLbl.Text = "Tên sách: " + dauSach.TenSach;
            tacgiaLbl.Text = "Tác giả: " + dauSach.TacGia.TenTacGia;
            theloaiLbl.Text = "Thể loại: " + dauSach.TheLoai.TenTheLoai;
            nxbLbl.Text = "NXB: " + dauSach.NhaXuatBan.TenNhaXuatBan;
            LoadGridView();
        }

        private void LoadGridView()
        {
            quyensachDgv.DataSource = null;
            quyensachDgv.DataSource = _quyenSachController.GetAllByDauSach(_idDauSach);
            quyensachDgv.Columns[1].Visible = false;
            quyensachDgv.Columns[4].Visible = false;
            quyensachDgv.Columns[5].Visible = false;
        }

        

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int i = quyensachDgv.CurrentCell.RowIndex;
                _idQuyenSach = quyensachDgv.Rows[i].Cells[0].Value.ToString();
                string tinhtrang = quyensachDgv.Rows[i].Cells[2].Value.ToString();
                string mota = quyensachDgv.Rows[i].Cells[3].Value.ToString();
                if (tinhtrang.Equals("OK"))
                {
                    tinhtrangsachCbx.SelectedIndex = 0;
                }
                if (tinhtrang.Equals("Rách"))
                {
                    tinhtrangsachCbx.SelectedIndex = 1;
                }
                if (tinhtrang.Equals("Mất"))
                {
                    tinhtrangsachCbx.SelectedIndex = 2;
                }
                if (!mota.Equals("none"))
                {
                    motaRtb.Clear();
                    motaRtb.Text = mota;
                }
            }
            catch (Exception)
            {

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (_quyenSachController.Edit(_idQuyenSach, tinhtrangsachCbx.SelectedItem.ToString(), motaRtb.Text))
            {
                MessageBox.Show("Đã sửa thành công");
                LoadGridView();
            }
            else
            {
                MessageBox.Show("Không thể sửa dứ liệu");
            }
        }

        private void themBtn_Click(object sender, EventArgs e)
        {
            if (numericUpDown1.Value <= 0)
            {
                MessageBox.Show("Số được chọn không hợp lệ");
            }
            else
            {
                _quyenSachController.AddMore(Convert.ToInt32(numericUpDown1.Value), _idDauSach);
                MessageBox.Show("Đã thêm thành công");
                LoadGridView();
            }
        }
    }
}
