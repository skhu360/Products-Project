using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Products
{
    public partial class frmMain : frminheritance
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnProducts_Click(object sender, EventArgs e)
        {
            frmProducts frmProducts = new frmProducts();
            frmProducts.Show();
            this.Hide();
        }

        private void btnUsers_Click(object sender, EventArgs e)
        {
            frmUsers frmUsers = new frmUsers();
            frmUsers.Show();
            this.Hide();
        }

        private void btnLogOff_Click(object sender, EventArgs e)
        {
            frmLogin frmlogOff = new frmLogin();
            frmlogOff.Show();
            this.Hide();
        }
    }
}
