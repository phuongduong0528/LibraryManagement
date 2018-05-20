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
    public partial class tSearch : Form
    {
        private DauSachController _dauSachController;
        public tSearch()
        {
            InitializeComponent();
            _dauSachController = new DauSachController();
        }

        private void tSearch_Load(object sender, EventArgs e)
        {
            categoryCbx.SelectedIndex = 0;
        }

        private void searchTxb_TextChanged(object sender, EventArgs e)
        {
            switch (categoryCbx.SelectedIndex)
            {
                case 1:
                    searchResulrDgv.DataSource = 
                        DauSachAdaptor.GetListDauSachDto(_dauSachController.GetByFilter("", "", searchTxb.Text));
                    break;
                case 2:
                    searchResulrDgv.DataSource = 
                        DauSachAdaptor.GetListDauSachDto(_dauSachController.GetByFilter("", searchTxb.Text, ""));
                    break;
                default:
                    searchResulrDgv.DataSource =
                        DauSachAdaptor.GetListDauSachDto(_dauSachController.GetByFilter(searchTxb.Text, "", ""));
                    break;
            }
        }

        private void searchResulrDgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
