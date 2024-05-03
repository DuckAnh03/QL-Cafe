using QL_Cafe.BUS;
using QL_Cafe.DAL;
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
using System.Globalization;

namespace QL_Cafe.GUI
{
    public partial class fMain : Form
    {
        private readonly DrinksBUS _drinksBUS = new DrinksBUS();
        private readonly CategoryBUS _categoryBUS = new CategoryBUS();
        private readonly BillInfoBUS _billinfoBUS = new BillInfoBUS();
        private readonly TableBUS _tableBUS = new TableBUS();
        private readonly BillBUS _billBUS = new BillBUS();
        private readonly MenuBUS _menuBUS = new MenuBUS();
        private List<KeyValuePair<int, string>> comboboxCategoryData = new() { new(0, "Tất cả cafe") };
        private List<Drinks> drinks = new();
        private List<BillInfo> billinfolist = new();
        private List<Table> tablelist = new();
        private List<Menu> menulist = new();
        DateTime checkin, checkout;
        int status;

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

        private void fMain_Load(object sender, EventArgs e)
        {
            loadCategory();
            loadCafeData();
            loadTableData();
        }
        private void loadCafeData()
        {
            drinks = _drinksBUS.GetDrinksByCategoryId(comboboxCategoryData[cbbCategory.SelectedIndex].Key);
            cbbDrinks.DataSource = drinks;
            cbbDrinks.DisplayMember = "DrinksName";
        }
        private void loadCategory() 
        {
            var loaicafe = _categoryBUS.GetAllCategory().Select(x => new KeyValuePair<int, string>(x.ID ?? 0, x.CategoryName));

            comboboxCategoryData.AddRange(loaicafe);
            cbbCategory.DataSource = comboboxCategoryData;
            cbbCategory.DisplayMember = "Value";
        }

        private void loadTableData()
        {
            tablelist = _tableBUS.GetAllTable();
            foreach (var table in tablelist)
            {
                Button btn = new Button() { Width = 100, Height = 100 };
                btn.Text = table.Name + Environment.NewLine + table.Status;
                btn.Click += Btn_Click;
                btn.Tag = table;

                switch (table.Status)
                {
                    case "Trống":
                        btn.BackColor = Color.AliceBlue;
                        break;
                    default:
                        btn.BackColor = Color.LightYellow;
                        break;
                }
                flpTable.Controls.Add(btn);
            }
        }

        private void ShowBill(int id)
        {
            listViewBill.Items.Clear();

            menulist = _menuBUS.getMenu(id);
            double total = 0;

            foreach (var menu in menulist)
            {
                ListViewItem listViewItem = new ListViewItem(menu.DrinksName.ToString());
                listViewItem.SubItems.Add(menu.Price.ToString());
                listViewItem.SubItems.Add(menu.Count.ToString());
                listViewItem.SubItems.Add(menu.TotalPrice.ToString());
                total += menu.TotalPrice;
                listViewBill.Items.Add(listViewItem);
            }
            CultureInfo culture = new CultureInfo("vi-VN");
            txtTotal.Text = total.ToString("c", culture);

        }
        private void Btn_Click(object? sender, EventArgs e)
        {
            int tableId = (int)((sender as Button).Tag as Table).ID;
            listViewBill.Tag = (sender as Button).Tag;
            ShowBill(tableId);
        }

        

        private void cbbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadCafeData();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Table table = listViewBill.Tag as Table;

            int idbill = _billBUS.getUncheckBillByIDTable((int)table.ID);
            int count = (int)numericUpDown1.Value;
            int drinksid = (int)drinks[cbbDrinks.SelectedIndex].ID;
            if (idbill == -1)
            {
                _billBUS.Add((int)table.ID);
                idbill = _billBUS.getUncheckBillByIDTable((int)table.ID);
                _billinfoBUS.Add(idbill , drinksid, count);
            }
            else
            {
                _billinfoBUS.Add(idbill, drinksid, count);
            }
            ShowBill((int)table.ID);
        }




    }
}
