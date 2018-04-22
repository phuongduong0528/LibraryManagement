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
    public partial class AddBooks : Form
    {
        private List<string> _taggias;
        private TacGiaController _tacGiaController;

        public AddBooks()
        {
            InitializeComponent();
            _taggias = new List<string>();
            _tacGiaController = new TacGiaController();
        }

        private void RefreshListBox(string searchString)
        {
            listtacgiaLB.Items.Clear();
            _taggias.Clear();
            _taggias = _tacGiaController.FindByName(searchString);
            foreach (string name in _taggias)
            {
                listtacgiaLB.Items.Add(name);
            }
        }

        private void themBtn_Click(object sender, EventArgs e)
        {

        }

        private void nhaplaiBtn_Click(object sender, EventArgs e)
        {

        }

        private void tacgiaTxb_TextChanged(object sender, EventArgs e)
        {
            listtacgiaLB.Visible = true;
            RefreshListBox(tacgiaTxb.Text);
        }

        private void AddBooks_Load(object sender, EventArgs e)
        {

        }

        private void AddBooks_Click(object sender, EventArgs e)
        {
            listtacgiaLB.Visible = false;
        }

        private void listtacgiaLB_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                tacgiaTxb.Text = listtacgiaLB.SelectedItem.ToString();
                listtacgiaLB.Visible = false;
            }
            catch(Exception ex)
            {

            }
        }

        private void giaTxb_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void giaTxb_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
