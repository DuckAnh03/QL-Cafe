using QL_Cafe.DTO;
using QL_Cafe.BUS;
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
    public partial class fCafe : Form
    {
        private readonly DrinksBUS _drinksBUS = new DrinksBUS();

        private List<Drinks> drinks = new();
        public fCafe()
        {
            InitializeComponent();
        }

        private void loadData()
        {
            drinks = _drinksBUS.GetAllDrinks();
            dataGridViewDrinks.DataSource = drinks;
        }

        private void fCafe_Load(object sender, EventArgs e)
        {
            loadData();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int id = drinks[dataGridViewDrinks.CurrentCell.RowIndex].ID ?? 0;
            if (id != 0 && _drinksBUS.Delete(id))
            {
                loadData();
                return;
            }

            MessageBox.Show("Không thể xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }


    }
}
