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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Drawing.Text;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace QL_Cafe.GUI
{
    public partial class fCafe : Form
    {
        private readonly DrinksBUS _drinksBUS = new DrinksBUS();
        private readonly CategoryBUS _categoryBUS = new CategoryBUS();
        private List<KeyValuePair<int, string>> comboboxDatas = new() { new(0, "Tất cả cafe") };
        private List<Drinks> drinks = new();
        public fCafe()
        {
            InitializeComponent();
        }


        private void loadData()
        {
            drinks = _drinksBUS.GetDrinksByCategoryId(comboboxDatas[cbb_CafeCategory.SelectedIndex].Key);
            dataGridViewDrinks.DataSource = drinks;
        }

        private void fCafe_Load(object sender, EventArgs e)
        {
            var loaicafe = _categoryBUS.GetAllCategory().Select(x => new KeyValuePair<int, string>(x.ID ?? 0, x.CategoryName));
            comboboxDatas.AddRange(loaicafe);

            cbb_CafeCategory.DataSource = comboboxDatas;
            cbb_CafeCategory.DisplayMember = "Value";

            btnConfirm.Hide();
            btnCancel.Hide();
        }



        private void cbb_CafeCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbb_CafeCategory.SelectedIndex == 0)
            {
                btnAdd.Enabled = false;
            }
            else
            {
                btnAdd.Enabled = true;
            }
            loadData();
        }

        private void dataGridViewDrinks_SelectionChanged(object sender, EventArgs e)
        {
            if (drinks.Count <= 0)
            {
                txtID.Text = string.Empty;
                txtName.Text = string.Empty;
                txtPrice.Text = string.Empty;
                return;
            }

            var id = dataGridViewDrinks.CurrentCell.RowIndex;
            if (id >= drinks.Count)
            {
                id = drinks.Count - 1;
            }
            txtID.Text = drinks[id].ID?.ToString();
            txtName.Text = drinks[id].DrinksName;
            txtPrice.Text = drinks[id].Price.ToString();
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

        private void btnAdd_Click(object sender, EventArgs e)
        {
            dataGridViewDrinks.ClearSelection();

            //Xóa dữ liệu textBox để thêm mới
            txtID.Clear();
            txtName.Clear();
            txtPrice.Clear();

            txtName.Select();

            //Hiện nút xác nhận, hủy
            btnConfirm.Show();
            btnCancel.Show();

            //Không cho click button còn lại khi chưa xác nhận || hủy
            btnAdd.Enabled = false;
            btnDelete.Enabled = false;
            btnUpdate.Enabled = false;
        }
        public void btnConfirm_Click(object sender, EventArgs e)
        {
            Drinks newcafe = new Drinks()
            {
                DrinksName = txtName.Text,
                IDCategory = comboboxDatas[cbb_CafeCategory.SelectedIndex].Key,
                Price = double.Parse(txtPrice.Text),
            };
            if (_drinksBUS.Add(newcafe))
            {
                loadData();
                return;
            }
            MessageBox.Show($"Không thể thêm cafe!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);

            btnAdd.Enabled = true;
            btnDelete.Enabled = true;
            btnUpdate.Enabled = true;

            btnConfirm.Hide();
            btnCancel.Hide();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtName.Clear();
            txtPrice.Clear();

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
