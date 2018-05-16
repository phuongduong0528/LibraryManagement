using LibraryManagement.DbManager.Controller;
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
    public partial class tLogin : Form
    {
        private LoginController _loginController;
        private string _userRole;
        public tLogin()
        {
            InitializeComponent();
            _loginController = new LoginController();
        }

        // Code khi load Form
        private void Login_Load(object sender, EventArgs e)
        {
            txtbMatKhau.UseSystemPasswordChar = true;
        }



        // code cho nút Thoát
        private void btnThoat_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Bạn có thực sự muốn thoát", "Thông báo", MessageBoxButtons.OKCancel) == DialogResult.OK)
                this.Close();
        }

        // code cho sự kiện hiển thị mật khẩu
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                txtbMatKhau.UseSystemPasswordChar = false;
            }
            else
            {
                txtbMatKhau.UseSystemPasswordChar = true;
            }
        }

        // code cho nút Đăng nhập
        private async void btnDangNhap_Click(object sender, EventArgs e)
        {
            lblStatus.Visible = true;
            int state = 0; //Ket qua dang nhap 0 - Fail | 1 - OK
            string pass = Utilities.CalculateHash(txtbMatKhau.Text.Trim() + txtbTaiKhoan.Text.Trim()); //Password hashing
            if (txtbTaiKhoan.Text == "" && txtbMatKhau.Text == "")
            {
                MessageBox.Show("Bạn cần nhập đầy đủ thông tin tài khoản và mật khẩu", "Thông báo đăng nhập", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtbTaiKhoan.Focus();
            }
            else if (txtbTaiKhoan.Text == "")
            {
                MessageBox.Show("Tên đăng nhập không được bỏ trống", "Thông báo đăng nhập", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (txtbMatKhau.Text == "")
            {

            }
            if (cbxUserType.SelectedItem == null)
            {
                MessageBox.Show("Bạn chưa chọn mục \"Bạn là ai?\"", "Lỗi đăng nhập",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //Kiem Tra Dang nhap theo loai ngoi dung
            if (cbxUserType.SelectedIndex == 0)
            {
                state = await _loginController.AuthNguoiQL(txtbTaiKhoan.Text, pass);
                _userRole = "Admin";
            }
            if (cbxUserType.SelectedIndex == 1)
            {
                state = await _loginController.AuthThuThu(txtbTaiKhoan.Text, pass);
                _userRole = "ThuThu";
            }
            if (cbxUserType.SelectedIndex == 2)
            {
                state = await _loginController.AuthDocGia(txtbTaiKhoan.Text, pass);
                _userRole = "BanDoc";
            }

            Authentication(state, _userRole);
        }

        private void Authentication(int state, string userRole)
        {
            //Sau khi kiem tra dang nhap
            if (state == 1)
            {
                tLibMan libMan = new tLibMan(userRole,txtbTaiKhoan.Text);
                libMan.FormClosed += LibMan_FormClosed;
                libMan.Show();
                this.Visible = false;
            }
            else
            {
                MessageBox.Show("Sai ID cá nhân hoặc mật khẩu", "Lỗi đăng nhập",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            lblStatus.Visible = false;
        }

        private void LibMan_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Visible = true;
            txtbMatKhau.Clear();
        }
    }
}
