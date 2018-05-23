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

namespace LibMan
{
    public partial class tInfoBook : Form
    {
        private QuyenSachController _quyenSachController;
        private string _userRole;
        private string _userId;

        public tInfoBook()
        {
            InitializeComponent();
            _quyenSachController = new QuyenSachController();
        }

        public tInfoBook(string userRole, string userId)
        {
            InitializeComponent();
            _userRole = userRole;
            _userId = userId;
            _quyenSachController = new QuyenSachController();
        }

        private void timkiemBtn_Click(object sender, EventArgs e)
        {
            if (_userRole != "BanDoc")
            {
                quyensachDgv.DataSource =
                    QuyenSachAdaptor.GetListQuyenSachDto(_quyenSachController.GetBorrowedBooks())
                        .Where(b => b.TenSach.Contains(tensachTxb.Text))
                        .ToList();
            }
            else
            {
                quyensachDgv.DataSource =
                    QuyenSachAdaptor.GetListQuyenSachDto(_quyenSachController.GetBorrowedBooks(_userId))
                        .Where(b => b.TenSach.Contains(tensachTxb.Text))
                        .ToList();
            }
        }

        private void tensachTxb_TextChanged(object sender, EventArgs e)
        {
            if (_userRole != "BanDoc")
            {
                quyensachDgv.DataSource =
                    QuyenSachAdaptor.GetListQuyenSachDto(_quyenSachController.GetBorrowedBooks())
                        .Where(b => b.TenSach.Contains(tensachTxb.Text))
                        .ToList();
            }
            else
            {
                quyensachDgv.DataSource =
                    QuyenSachAdaptor.GetListQuyenSachDto(_quyenSachController.GetBorrowedBooks(_userId))
                        .Where(b => b.TenSach.Contains(tensachTxb.Text))
                        .ToList();
            }
        }

        private void tInfoBook_Load(object sender, EventArgs e)
        {
            if (_userRole == "BanDoc")
            {
                quyensachDgv.DataSource =
                    QuyenSachAdaptor.GetListQuyenSachDto(_quyenSachController.GetBorrowedBooks(_userId)).ToList();
            }
        }
    }
}
