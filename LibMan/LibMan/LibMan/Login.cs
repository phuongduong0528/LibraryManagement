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
    public partial class Login : Form
    {
        LoginController _loginController;
        public Login()
        {
            InitializeComponent();
            _loginController = new LoginController();
            // code khởi tạo chữ chìm (WaterMark)
            txtbTaiKhoan.ForeColor = Color.Silver;
            txtbMatKhau.ForeColor = Color.Silver;
            txtbTaiKhoan.Text = "Tài khoản của bạn...";
            txtbMatKhau.Text = "Mật khẩu của bạn...";
            this.txtbTaiKhoan.Leave += new System.EventHandler(this.txtbTaiKhoan_Leave);
            this.txtbTaiKhoan.Enter += new System.EventHandler(this.txtbTaiKhoan_Enter);

            txtbMatKhau.Leave += TxtbMatKhau_Leave;
            txtbMatKhau.Enter += TxtbMatKhau_Enter;
        }

        // Code cho chữ chìm của Mật Khẩu
        private void TxtbMatKhau_Leave(object sender, EventArgs e)
        {
            if (txtbMatKhau.Text == "")
            {
                txtbMatKhau.Text = "Mật khẩu của bạn...";
                txtbMatKhau.ForeColor = Color.Silver;
                txtbMatKhau.UseSystemPasswordChar = false;
            }
        }

        // Code cho chữ chìm của Mật Khẩu
        private void TxtbMatKhau_Enter(object sender, EventArgs e)
        {
            if (txtbMatKhau.Text == "Mật khẩu của bạn...")
            {
                txtbMatKhau.Text = "";
                txtbMatKhau.ForeColor = Color.Black;
                txtbMatKhau.UseSystemPasswordChar = true;
            }
        }


        private void Login_Load(object sender, EventArgs e)
        {

        }

        // code cho phần chữ chìm của tài khoản
        private void txtbTaiKhoan_Leave(object sender, EventArgs e)
        {
            if (txtbTaiKhoan.Text == "")
            {
                txtbTaiKhoan.Text = "Tài khoản của bạn...";
                txtbTaiKhoan.ForeColor = Color.Silver;
            }
        }

        // code cho phần chữ chìm của tài khoản
        private void txtbTaiKhoan_Enter(object sender, EventArgs e)
        {
            if (txtbTaiKhoan.Text == "Tài khoản của bạn...")
            {
                txtbTaiKhoan.Text = "";
                txtbTaiKhoan.ForeColor = Color.Black;
            }
        }

        // code cho nút Thoát
        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

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

        private async void btnDangNhap_Click(object sender, EventArgs e)
        {
            lblStatus.Visible = true;
            int state = 0; //Ket qua dang nhap 0 - Fail | 1 - OK
            int userType = -1;
            string pass = Utilities.CalculateHash(txtbMatKhau.Text.Trim() + txtbTaiKhoan.Text.Trim()); //Password hashing
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
                userType = 0;
            }
            if (cbxUserType.SelectedIndex == 1)
            {
                state = await _loginController.AuthThuThu(txtbTaiKhoan.Text, pass);
                userType = 1;
            }
            if (cbxUserType.SelectedIndex == 2)
            {
                state = await _loginController.AuthDocGia(txtbTaiKhoan.Text, pass);
                userType = 2;
            }
            
            //Sau khi kiem tra dang nhap
            if (state == 1)
            {
                LibMan libMan = new LibMan(txtbTaiKhoan.Text);
                libMan.FormClosed += LibMan_FormClosed;
                libMan.AlterFeature(userType);
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
