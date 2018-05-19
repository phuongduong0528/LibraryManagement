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
        public tInfoBook()
        {
            InitializeComponent();
            _quyenSachController = new QuyenSachController();
        }

        private void timkiemBtn_Click(object sender, EventArgs e)
        {
            quyensachDgv.DataSource =
                QuyenSachAdaptor.GetListQuyenSachDto(_quyenSachController.GetBorrowedBooks())
                    .Where(b => b.TenSach.Contains(tensachTxb.Text))
                    .ToList();
        }

        private void tensachTxb_TextChanged(object sender, EventArgs e)
        {
            quyensachDgv.DataSource = 
                QuyenSachAdaptor.GetListQuyenSachDto(_quyenSachController.GetBorrowedBooks())
                    .Where(b=>b.TenSach.Contains(tensachTxb.Text))
                    .ToList();
        }
    }
}
