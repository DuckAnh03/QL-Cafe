namespace QL_Cafe.GUI
{
    partial class fMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            quảnLýToolStripMenuItem = new ToolStripMenuItem();
            MenuStripListCafe = new ToolStripMenuItem();
            MenuStripCafeCategoryList = new ToolStripMenuItem();
            hóaĐơnToolStripMenuItem = new ToolStripMenuItem();
            nhânViênToolStripMenuItem = new ToolStripMenuItem();
            thốngKêToolStripMenuItem = new ToolStripMenuItem();
            tàiKhoảnToolStripMenuItem = new ToolStripMenuItem();
            thôngTinToolStripMenuItem = new ToolStripMenuItem();
            MSLogout = new ToolStripMenuItem();
            panel2 = new Panel();
            listViewBill = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            panel3 = new Panel();
            btnAdd = new Button();
            label1 = new Label();
            numericUpDown1 = new NumericUpDown();
            cbbCategory = new ComboBox();
            cbbDrinks = new ComboBox();
            flpTable = new FlowLayoutPanel();
            panel1 = new Panel();
            label2 = new Label();
            txtTotal = new TextBox();
            btnTT = new Button();
            menuStrip1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { quảnLýToolStripMenuItem, tàiKhoảnToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // quảnLýToolStripMenuItem
            // 
            quảnLýToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { MenuStripListCafe, MenuStripCafeCategoryList, hóaĐơnToolStripMenuItem, nhânViênToolStripMenuItem, thốngKêToolStripMenuItem });
            quảnLýToolStripMenuItem.Name = "quảnLýToolStripMenuItem";
            quảnLýToolStripMenuItem.Size = new Size(73, 24);
            quảnLýToolStripMenuItem.Text = "Quản lý";
            // 
            // MenuStripListCafe
            // 
            MenuStripListCafe.Name = "MenuStripListCafe";
            MenuStripListCafe.Size = new Size(192, 26);
            MenuStripListCafe.Text = "Danh sách cafe";
            MenuStripListCafe.Click += MenuStripListCafe_Click;
            // 
            // MenuStripCafeCategoryList
            // 
            MenuStripCafeCategoryList.Name = "MenuStripCafeCategoryList";
            MenuStripCafeCategoryList.Size = new Size(192, 26);
            MenuStripCafeCategoryList.Text = "Loại cafe";
            MenuStripCafeCategoryList.Click += MenuStripCafeCategoryList_Click;
            // 
            // hóaĐơnToolStripMenuItem
            // 
            hóaĐơnToolStripMenuItem.Name = "hóaĐơnToolStripMenuItem";
            hóaĐơnToolStripMenuItem.Size = new Size(192, 26);
            hóaĐơnToolStripMenuItem.Text = "Hóa đơn";
            // 
            // nhânViênToolStripMenuItem
            // 
            nhânViênToolStripMenuItem.Name = "nhânViênToolStripMenuItem";
            nhânViênToolStripMenuItem.Size = new Size(192, 26);
            nhânViênToolStripMenuItem.Text = "Nhân viên";
            // 
            // thốngKêToolStripMenuItem
            // 
            thốngKêToolStripMenuItem.Name = "thốngKêToolStripMenuItem";
            thốngKêToolStripMenuItem.Size = new Size(192, 26);
            thốngKêToolStripMenuItem.Text = "Thống kê";
            // 
            // tàiKhoảnToolStripMenuItem
            // 
            tàiKhoảnToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { thôngTinToolStripMenuItem, MSLogout });
            tàiKhoảnToolStripMenuItem.Name = "tàiKhoảnToolStripMenuItem";
            tàiKhoảnToolStripMenuItem.Size = new Size(85, 24);
            tàiKhoảnToolStripMenuItem.Text = "Tài khoản";
            // 
            // thôngTinToolStripMenuItem
            // 
            thôngTinToolStripMenuItem.Name = "thôngTinToolStripMenuItem";
            thôngTinToolStripMenuItem.Size = new Size(160, 26);
            thôngTinToolStripMenuItem.Text = "Thông tin ";
            thôngTinToolStripMenuItem.Click += thôngTinToolStripMenuItem_Click;
            // 
            // MSLogout
            // 
            MSLogout.Name = "MSLogout";
            MSLogout.Size = new Size(160, 26);
            MSLogout.Text = "Đăng xuất";
            MSLogout.Click += MSLogout_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(listViewBill);
            panel2.Controls.Add(panel3);
            panel2.Location = new Point(353, 31);
            panel2.Name = "panel2";
            panel2.Size = new Size(435, 407);
            panel2.TabIndex = 2;
            // 
            // listViewBill
            // 
            listViewBill.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4 });
            listViewBill.GridLines = true;
            listViewBill.Location = new Point(6, 78);
            listViewBill.Name = "listViewBill";
            listViewBill.Size = new Size(423, 326);
            listViewBill.TabIndex = 3;
            listViewBill.UseCompatibleStateImageBehavior = false;
            listViewBill.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Tên đồ uống";
            columnHeader1.Width = 170;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Giá";
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Số lượng";
            columnHeader3.Width = 80;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Thành tiền";
            columnHeader4.Width = 110;
            // 
            // panel3
            // 
            panel3.Controls.Add(btnAdd);
            panel3.Controls.Add(label1);
            panel3.Controls.Add(numericUpDown1);
            panel3.Controls.Add(cbbCategory);
            panel3.Controls.Add(cbbDrinks);
            panel3.Location = new Point(3, 3);
            panel3.Name = "panel3";
            panel3.Size = new Size(429, 73);
            panel3.TabIndex = 2;
            // 
            // btnAdd
            // 
            btnAdd.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAdd.Location = new Point(312, 39);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(114, 30);
            btnAdd.TabIndex = 4;
            btnAdd.Text = "Thêm";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(312, 6);
            label1.Name = "label1";
            label1.Size = new Size(38, 22);
            label1.TabIndex = 3;
            label1.Text = "SL:";
            // 
            // numericUpDown1
            // 
            numericUpDown1.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            numericUpDown1.Location = new Point(356, 3);
            numericUpDown1.Minimum = new decimal(new int[] { 100, 0, 0, int.MinValue });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(70, 30);
            numericUpDown1.TabIndex = 2;
            numericUpDown1.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // cbbCategory
            // 
            cbbCategory.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbbCategory.FormattingEnabled = true;
            cbbCategory.Location = new Point(3, 3);
            cbbCategory.Name = "cbbCategory";
            cbbCategory.Size = new Size(303, 30);
            cbbCategory.TabIndex = 0;
            cbbCategory.SelectedIndexChanged += cbbCategory_SelectedIndexChanged;
            // 
            // cbbDrinks
            // 
            cbbDrinks.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbbDrinks.FormattingEnabled = true;
            cbbDrinks.Location = new Point(3, 39);
            cbbDrinks.Name = "cbbDrinks";
            cbbDrinks.Size = new Size(303, 30);
            cbbDrinks.TabIndex = 1;
            // 
            // flpTable
            // 
            flpTable.AutoScroll = true;
            flpTable.Location = new Point(12, 31);
            flpTable.Name = "flpTable";
            flpTable.Size = new Size(335, 497);
            flpTable.TabIndex = 3;
            // 
            // panel1
            // 
            panel1.Controls.Add(label2);
            panel1.Controls.Add(txtTotal);
            panel1.Controls.Add(btnTT);
            panel1.Location = new Point(353, 441);
            panel1.Name = "panel1";
            panel1.Size = new Size(435, 87);
            panel1.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(197, 8);
            label2.Name = "label2";
            label2.Size = new Size(90, 22);
            label2.TabIndex = 2;
            label2.Text = "Tổng tiền:";
            // 
            // txtTotal
            // 
            txtTotal.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTotal.Location = new Point(293, 5);
            txtTotal.Name = "txtTotal";
            txtTotal.ReadOnly = true;
            txtTotal.Size = new Size(136, 30);
            txtTotal.TabIndex = 1;
            txtTotal.Text = "0";
            // 
            // btnTT
            // 
            btnTT.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnTT.Location = new Point(293, 41);
            btnTT.Name = "btnTT";
            btnTT.Size = new Size(136, 36);
            btnTT.TabIndex = 0;
            btnTT.Text = "Thanh toán";
            btnTT.UseVisualStyleBackColor = true;
            // 
            // fMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 540);
            Controls.Add(panel1);
            Controls.Add(flpTable);
            Controls.Add(panel2);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "fMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "fMain";
            Load += fMain_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem quảnLýToolStripMenuItem;
        private ToolStripMenuItem MenuStripListCafe;
        private ToolStripMenuItem MenuStripCafeCategoryList;
        private ToolStripMenuItem hóaĐơnToolStripMenuItem;
        private ToolStripMenuItem nhânViênToolStripMenuItem;
        private ToolStripMenuItem thốngKêToolStripMenuItem;
        private ToolStripMenuItem tàiKhoảnToolStripMenuItem;
        private ToolStripMenuItem MSLogout;
        private ToolStripMenuItem thôngTinToolStripMenuItem;
        private Panel panel2;
        private Panel panel3;
        private Button btnAdd;
        private Label label1;
        private NumericUpDown numericUpDown1;
        private ComboBox cbbCategory;
        private ComboBox cbbDrinks;
        private FlowLayoutPanel flpTable;
        private ListView listViewBill;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private Panel panel1;
        private Label label2;
        private TextBox txtTotal;
        private Button btnTT;
    }
}