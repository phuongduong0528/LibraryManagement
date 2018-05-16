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
    public partial class UserMan : Form
    {
        public UserMan()
        {
            InitializeComponent();
            txtbTK1.Text = "Tìm kiếm độc giả...";
        }

        private void txtbTK1_Leave(object sender, EventArgs e)
        {
            if (txtbTK1.Text == "")
            {
                txtbTK1.Text = "Tìm kiếm độc giả...";
            }
        }

        private void txtbTK1_Enter(object sender, EventArgs e)
        {
            if (txtbTK1.Text == "Tìm kiếm độc giả...")
            {
                txtbTK1.Text = "";
            }
        }
    }
}
