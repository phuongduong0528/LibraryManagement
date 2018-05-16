﻿using System;
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
    public partial class tLibMan : Form
    {
        private string _uesrRole;
        private string _userId;
        public tLibMan()
        {
            InitializeComponent();
        }

        public tLibMan(string userRole, string userId)
        {
            InitializeComponent();
            _uesrRole = userRole;
            _userId = userId;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if(_uesrRole == "ThuThu")
            {
                đổiMậtKhẩuToolStripMenuItem.Visible = false;
                phânQuyềnToolStripMenuItem.Visible = false;
            }
            if(_uesrRole == "BanDoc")
            {
                phânQuyềnToolStripMenuItem.Visible = false;
                thôngSốHệThốngToolStripMenuItem.Visible = false;
                thôngTinCáNhânToolStripMenuItem.Visible = false;
                thốngKêToolStripMenuItem.Visible = false;
                quảnLýBạnĐọcToolStripMenuItem.Visible = false;
                bổSungSáchToolStripMenuItem.Visible = false;
                quảnLýSáchMượnToolStripMenuItem.Visible = false;
                thôngTinCáNhânToolStripMenuItem.Visible = false;
            }
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // Code cho sự kiện Thêm mới bạn đọc
        private void thêmMớiBạnĐọcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Register init = new Register();
            //this.Close();
            init.Show();
        }

        // Code cho sự kiện Đăng xuất
        private void raKhỏiHệThốngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tLogin login = new tLogin();
            this.Close();
            login.Show();
        }

        // Code cho sự kiện tìm kiếm sách
        private void tìmKiếmSáchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tSearch search = new tSearch();
            search.ShowDialog();
        }

        // Code thêm mới sách vào thư viện
        private void bổSungSáchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tBooksMan2 bm = new tBooksMan2();
            bm.ShowDialog();
        }

        // code cho toolstip quản lý sách
        private void quảnLýSáchToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        // Quản lý sách mượn - trả
        private void quảnLýSáchMượnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tBooksMan tbm = new tBooksMan(_userId);
            tbm.ShowDialog();
        }

        // Quản lý bạn đọc
        private void quảnLýBạnĐọcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tUserMan um = new tUserMan();
            um.ShowDialog();
        }

        // Đổi mật khẩu
        private void đổiMậtKhẩuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tChangePass cp = new tChangePass();
            cp.ShowDialog();
        }

        // Form thông tin cá nhân bạn đọc
        private void tìmKiếmBạnĐọcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tInfoUser iu = new tInfoUser();
            iu.ShowDialog();
        }

        // form danh sách những quyển sách đang mượn của thư viện
        private void danhSáchNhữngSáchĐangMượnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tInfoBook ib = new tInfoBook();
            ib.ShowDialog();
        }
    }
}