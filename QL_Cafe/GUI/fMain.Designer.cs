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
            MSLogout = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
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
            tàiKhoảnToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { MSLogout });
            tàiKhoảnToolStripMenuItem.Name = "tàiKhoảnToolStripMenuItem";
            tàiKhoảnToolStripMenuItem.Size = new Size(85, 24);
            tàiKhoảnToolStripMenuItem.Text = "Tài khoản";
            // 
            // MSLogout
            // 
            MSLogout.Name = "MSLogout";
            MSLogout.Size = new Size(224, 26);
            MSLogout.Text = "Đăng xuất";
            MSLogout.Click += MSLogout_Click;
            // 
            // fMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "fMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "fMain";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
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
    }
}