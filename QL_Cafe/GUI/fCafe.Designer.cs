namespace QL_Cafe.GUI
{
    partial class fCafe
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
            dataGridViewDrinks = new DataGridView();
            btnDelete = new Button();
            btnAdd = new Button();
            btnUpdate = new Button();
            label1 = new Label();
            panel1 = new Panel();
            panel5 = new Panel();
            label3 = new Label();
            txtPrice = new TextBox();
            panel3 = new Panel();
            label2 = new Label();
            txtName = new TextBox();
            panel2 = new Panel();
            txtID = new TextBox();
            panel4 = new Panel();
            cbb_CafeCategory = new ComboBox();
            Loại = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridViewDrinks).BeginInit();
            panel1.SuspendLayout();
            panel5.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridViewDrinks
            // 
            dataGridViewDrinks.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewDrinks.Location = new Point(18, 209);
            dataGridViewDrinks.Name = "dataGridViewDrinks";
            dataGridViewDrinks.RowHeadersWidth = 51;
            dataGridViewDrinks.Size = new Size(602, 271);
            dataGridViewDrinks.TabIndex = 1;
            // 
            // btnDelete
            // 
            btnDelete.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDelete.Location = new Point(260, 165);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(115, 38);
            btnDelete.TabIndex = 2;
            btnDelete.Text = "Xóa";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnAdd
            // 
            btnAdd.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAdd.Location = new Point(139, 165);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(115, 38);
            btnAdd.TabIndex = 3;
            btnAdd.Text = "Thêm";
            btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            btnUpdate.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnUpdate.Location = new Point(381, 165);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(115, 38);
            btnUpdate.TabIndex = 4;
            btnUpdate.Text = "Sửa";
            btnUpdate.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(3, 9);
            label1.Name = "label1";
            label1.Size = new Size(30, 22);
            label1.TabIndex = 5;
            label1.Text = "ID";
            // 
            // panel1
            // 
            panel1.Controls.Add(panel5);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(18, 58);
            panel1.Name = "panel1";
            panel1.Size = new Size(602, 101);
            panel1.TabIndex = 7;
            // 
            // panel5
            // 
            panel5.Controls.Add(label3);
            panel5.Controls.Add(txtPrice);
            panel5.Location = new Point(337, 49);
            panel5.Name = "panel5";
            panel5.Size = new Size(262, 40);
            panel5.TabIndex = 12;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(3, 9);
            label3.Name = "label3";
            label3.Size = new Size(39, 22);
            label3.TabIndex = 5;
            label3.Text = "Giá";
            // 
            // txtPrice
            // 
            txtPrice.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPrice.Location = new Point(88, 6);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(167, 30);
            txtPrice.TabIndex = 8;
            // 
            // panel3
            // 
            panel3.Controls.Add(label2);
            panel3.Controls.Add(txtName);
            panel3.Location = new Point(3, 49);
            panel3.Name = "panel3";
            panel3.Size = new Size(327, 40);
            panel3.TabIndex = 10;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(3, 9);
            label2.Name = "label2";
            label2.Size = new Size(78, 22);
            label2.TabIndex = 5;
            label2.Text = "Tên cafe";
            // 
            // txtName
            // 
            txtName.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtName.Location = new Point(88, 6);
            txtName.Name = "txtName";
            txtName.Size = new Size(233, 30);
            txtName.TabIndex = 8;
            // 
            // panel2
            // 
            panel2.Controls.Add(label1);
            panel2.Controls.Add(txtID);
            panel2.Location = new Point(3, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(327, 40);
            panel2.TabIndex = 9;
            // 
            // txtID
            // 
            txtID.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtID.Location = new Point(88, 6);
            txtID.Name = "txtID";
            txtID.Size = new Size(233, 30);
            txtID.TabIndex = 8;
            // 
            // panel4
            // 
            panel4.Controls.Add(cbb_CafeCategory);
            panel4.Controls.Add(Loại);
            panel4.Location = new Point(18, 12);
            panel4.Name = "panel4";
            panel4.Size = new Size(330, 40);
            panel4.TabIndex = 11;
            // 
            // cbb_CafeCategory
            // 
            cbb_CafeCategory.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbb_CafeCategory.FormattingEnabled = true;
            cbb_CafeCategory.Location = new Point(90, 6);
            cbb_CafeCategory.Name = "cbb_CafeCategory";
            cbb_CafeCategory.Size = new Size(234, 30);
            cbb_CafeCategory.TabIndex = 8;
            // 
            // Loại
            // 
            Loại.AutoSize = true;
            Loại.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Loại.Location = new Point(3, 9);
            Loại.Name = "Loại";
            Loại.Size = new Size(84, 22);
            Loại.TabIndex = 5;
            Loại.Text = "Loại cafe";
            // 
            // fCafe
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(634, 492);
            Controls.Add(panel1);
            Controls.Add(panel4);
            Controls.Add(btnUpdate);
            Controls.Add(btnAdd);
            Controls.Add(btnDelete);
            Controls.Add(dataGridViewDrinks);
            Name = "fCafe";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cafe";
            Load += fCafe_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewDrinks).EndInit();
            panel1.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridViewDrinks;
        private Button btnDelete;
        private Button btnAdd;
        private Button btnUpdate;
        private Label label1;
        private Panel panel1;
        private Panel panel4;
        private ComboBox cbb_CafeCategory;
        private Label Loại;
        private Panel panel3;
        private Label label2;
        private TextBox txtName;
        private Panel panel2;
        private TextBox txtID;
        private Panel panel5;
        private Label label3;
        private TextBox txtPrice;
    }
}