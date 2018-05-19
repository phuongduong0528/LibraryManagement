using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibraryManagement.DbManager.Controller;

namespace LibMan
{
    public partial class tChangePass : Form
    {
        private LoginController _loginController = new LoginController();
        private NguoiQLController _nguoiQLController = new NguoiQLController();
        private DocGiaController _docGiaController = new DocGiaController();

        public tChangePass()
        {
            InitializeComponent();
        }

        public tChangePass(bool docGia, string userID)
        {
            InitializeComponent();

            if (docGia)
            {
                accountIdTxb.Text = userID;
                accountIdTxb.ReadOnly = true;
                comboBox1.SelectedIndex = 1;
                comboBox1.Enabled = false;
            }
        }

        private void xacnhanBtn_Click(object sender, EventArgs e)
        {
            if (!newPassTxb.Text.Equals(cnewPassTxb.Text))
            {
                MessageBox.Show("Xac nhận mật khẩu sai");
                return;
            }
            if(comboBox1.SelectedIndex == 0)
            {
                if (_nguoiQLController.ChangePassword(accountIdTxb.Text, newPassTxb.Text))
                {
                    MessageBox.Show("Thay đổi mật khẩu thành công!");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Sai Id người dùng");
                    return;
                }
            }
            else
            {
                if (_docGiaController.Edit(accountIdTxb.Text, newPassTxb.Text))
                {
                    MessageBox.Show("Thay đổi mật khẩu thành công!");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Sai Id người dùng");
                    return;
                }
            }
        }

        private void acountIdTxb_TextChanged(object sender, EventArgs e)
        {
            listIdTxb.Visible = true;
            if (comboBox1.SelectedIndex == 0)
                listIdTxb.DataSource = _nguoiQLController.ListId(accountIdTxb.Text);
            else
                listIdTxb.DataSource = _docGiaController.SearchByID_string(accountIdTxb.Text);
        }

        private void tChangePass_Click(object sender, EventArgs e)
        {
            listIdTxb.Visible = false;
        }

        private void listIdTxb_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void listIdTxb_Click(object sender, EventArgs e)
        {
            accountIdTxb.Text = listIdTxb.SelectedItem.ToString();
            listIdTxb.Visible = false;
        }

        private void thoatBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tChangePass_Load(object sender, EventArgs e)
        {

        }
    }
}
