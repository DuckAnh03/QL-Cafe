using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QL_Cafe.GUI
{
    public partial class fMain : Form
    {
        public fMain()
        {
            InitializeComponent();
        }

        private void MenuStripListCafe_Click(object sender, EventArgs e)
        {
            this.Hide();
            fCafe fCafeList = new fCafe();
            fCafeList.Show();
        }

        private void MenuStripCafeCategoryList_Click(object sender, EventArgs e)
        {
            this.Hide();
            fCategory fCafeCategoryList = new fCategory();
            fCafeCategoryList.Show();
        }

        private void MSLogout_Click(object sender, EventArgs e)
        {
            this.Close();
            fLogin flogin = new fLogin();
            flogin.Show();
        }

        private void thôngTinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fUser f = new fUser();
            f.ShowDialog();
        }
    }
}
