namespace QL_Cafe.GUI
{
    partial class fCategory
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
            panel1 = new Panel();
            btnCancel = new Button();
            btnConfirm = new Button();
            panel3 = new Panel();
            label2 = new Label();
            txtName = new TextBox();
            panel2 = new Panel();
            label1 = new Label();
            txtID = new TextBox();
            btnUpdate = new Button();
            btnAdd = new Button();
            btnDelete = new Button();
            dataGridViewDrinksCategory = new DataGridView();
            btnClose = new Button();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewDrinksCategory).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(btnCancel);
            panel1.Controls.Add(btnConfirm);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(12, 56);
            panel1.Name = "panel1";
            panel1.Size = new Size(602, 101);
            panel1.TabIndex = 16;
            // 
            // btnCancel
            // 
            btnCancel.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCancel.Location = new Point(363, 50);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(115, 38);
            btnCancel.TabIndex = 16;
            btnCancel.Text = "Hủy";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnConfirm
            // 
            btnConfirm.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnConfirm.Location = new Point(484, 50);
            btnConfirm.Name = "btnConfirm";
            btnConfirm.Size = new Size(115, 38);
            btnConfirm.TabIndex = 15;
            btnConfirm.Text = "Xác nhận";
            btnConfirm.UseVisualStyleBackColor = true;
            btnConfirm.Click += btnConfirm_Click;
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
            label2.Size = new Size(84, 22);
            label2.TabIndex = 5;
            label2.Text = "Loại cafe";
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
            // txtID
            // 
            txtID.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtID.Location = new Point(88, 6);
            txtID.Name = "txtID";
            txtID.Size = new Size(233, 30);
            txtID.TabIndex = 8;
            // 
            // btnUpdate
            // 
            btnUpdate.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnUpdate.Location = new Point(254, 163);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(115, 38);
            btnUpdate.TabIndex = 15;
            btnUpdate.Text = "Sửa";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnAdd
            // 
            btnAdd.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAdd.Location = new Point(12, 163);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(115, 38);
            btnAdd.TabIndex = 14;
            btnAdd.Text = "Thêm";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnDelete
            // 
            btnDelete.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDelete.Location = new Point(133, 163);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(115, 38);
            btnDelete.TabIndex = 13;
            btnDelete.Text = "Xóa";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // dataGridViewDrinksCategory
            // 
            dataGridViewDrinksCategory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewDrinksCategory.Location = new Point(12, 207);
            dataGridViewDrinksCategory.Name = "dataGridViewDrinksCategory";
            dataGridViewDrinksCategory.RowHeadersWidth = 51;
            dataGridViewDrinksCategory.Size = new Size(602, 271);
            dataGridViewDrinksCategory.TabIndex = 12;
            dataGridViewDrinksCategory.SelectionChanged += dataGridViewDrinksCategory_SelectionChanged;
            // 
            // btnClose
            // 
            btnClose.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnClose.Location = new Point(496, 163);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(115, 38);
            btnClose.TabIndex = 17;
            btnClose.Text = "Đóng";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // fCafeCategory
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(625, 480);
            Controls.Add(btnClose);
            Controls.Add(panel1);
            Controls.Add(btnUpdate);
            Controls.Add(btnAdd);
            Controls.Add(btnDelete);
            Controls.Add(dataGridViewDrinksCategory);
            Name = "fCafeCategory";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CafeCategory";
            Load += fCafeCategory_Load;
            panel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewDrinksCategory).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel3;
        private Label label2;
        private TextBox txtName;
        private Panel panel2;
        private Label label1;
        private TextBox txtID;
        private Button btnUpdate;
        private Button btnAdd;
        private Button btnDelete;
        private DataGridView dataGridViewDrinksCategory;
        private Button btnClose;
        private Button btnCancel;
        private Button btnConfirm;
    }
}