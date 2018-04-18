using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibMan
{
    public partial class LibMan : Form
    {
        private string currentUserID;
        public LibMan()
        {
            InitializeComponent();
        }

        public LibMan(string userid)
        {
            InitializeComponent();
            currentUserID = userid;
        }

        public void AlterFeature(int userType)
        {
            if(userType == 1)
            {
                phânQuyềnToolStripMenuItem.Visible = false;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

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
            this.Close();
        }

        // Code cho sự kiện tìm kiếm sách
        private void tìmKiếmSáchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Search search = new Search();
            search.ShowDialog();
        }

        // Code thêm mới sách vào thư viện
        private void bổSungSáchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddBooks addbooks = new AddBooks();
            addbooks.Show();
        }

        private void thôngSốHệThốngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Process.Start("msinfo32.exe");
        }
    }
}
