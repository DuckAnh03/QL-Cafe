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
    public partial class fCategory : Form
    {
        private readonly CategoryBUS _categoryBUS = new CategoryBUS();

        private List<Category> category = new();

        private int selectionId = 0;
        public fCategory()
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
            txtID.Text = category[selectionId].ID?.ToString();
            txtName.Text = category[selectionId].CategoryName;
        }

        

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (_categoryBUS.Update(new(int.Parse(txtID.Text), txtName.Text)))
            {
                loadData();
                return;
            }

            MessageBox.Show("Không thể cập nhật!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtID.Text, out int value) && _categoryBUS.Delete(value))
            {
                loadData();
                return;
            }

            MessageBox.Show("Không thể xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            dataGridViewDrinksCategory.ClearSelection();

            //Xóa dữ liệu textBox để thêm mới
            txtID.Clear();
            txtName.Clear();

            txtName.Select();

            //Hiện nút xác nhận, hủy
            btnConfirm.Show();
            btnCancel.Show();

            //Không cho click button còn lại khi chưa xác nhận || hủy
            btnAdd.Enabled = false;
            btnDelete.Enabled = false;
            btnUpdate.Enabled = false;
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            var loaicafe = new Category(null, txtName.Text);
            if (_categoryBUS.Add(loaicafe))
            {
                loadData();
                return;
            }
            MessageBox.Show($"Không thể thêm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);

            btnAdd.Enabled = true;
            btnDelete.Enabled = true;
            btnUpdate.Enabled = true;

            btnConfirm.Hide();
            btnCancel.Hide();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtID.Clear();
            txtName.Clear();

            btnAdd.Enabled = true;
            btnDelete.Enabled = true;
            btnUpdate.Enabled = true;

            btnConfirm.Hide();
            btnCancel.Hide();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
            fMain f = new fMain();
            f.Show();
        }

        
    }
}
