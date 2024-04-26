using QL_Cafe.BUS;
using QL_Cafe.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace QL_Cafe.GUI
{
    public partial class fCafeCategory : Form
    {
        private readonly CategoryBUS _categoryBUS = new CategoryBUS();

        private List<Category> category = new();

        private int selectionId = 0;
        public fCafeCategory()
        {
            InitializeComponent();
        }

        private void loadData()
        {

            category = _categoryBUS.GetAllCategory();
            dataGridViewDrinksCategory.DataSource = category;
        }

        private void fCafeCategory_Load(object sender, EventArgs e)
        {
            loadData();
        }

        private void dataGridViewDrinksCategory_SelectionChanged(object sender, EventArgs e)
        {
            selectionId = dataGridViewDrinksCategory.CurrentCell.RowIndex;
            if (selectionId >= category.Count)
            {
                selectionId = category.Count - 1;
            }
            txtIDCa.Text = category[selectionId].ID?.ToString();
            txtNameCa.Text = category[selectionId].CategoryName;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var loaicafe = new Category(null, txtNameCa.Text);
            if (_categoryBUS.Add(loaicafe))
            {
                loadData();
                return;
            }
            MessageBox.Show($"Không thể thêm {txtNameCa.Text}!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (_categoryBUS.Update(new(int.Parse(txtIDCa.Text), txtNameCa.Text)))
            {
                loadData();
                return;
            }

            MessageBox.Show("Không thể cập nhật!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtIDCa.Text, out int value) && _categoryBUS.Delete(value))
            {
                loadData();
                return;
            }

            MessageBox.Show("Không thể xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
            fMain f = new fMain();
            f.Show();
        }
    }
}
