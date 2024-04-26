namespace QL_Cafe.GUI
{
    partial class fCafeCategory
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
            panel3 = new Panel();
            label2 = new Label();
            txtNameCa = new TextBox();
            panel2 = new Panel();
            label1 = new Label();
            txtIDCa = new TextBox();
            btnUpdate = new Button();
            btnAdd = new Button();
            btnDelete = new Button();
            dataGridViewDrinksCategory = new DataGridView();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewDrinksCategory).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(12, 56);
            panel1.Name = "panel1";
            panel1.Size = new Size(602, 101);
            panel1.TabIndex = 16;
            // 
            // panel3
            // 
            panel3.Controls.Add(label2);
            panel3.Controls.Add(txtNameCa);
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
            // txtNameCa
            // 
            txtNameCa.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNameCa.Location = new Point(88, 6);
            txtNameCa.Name = "txtNameCa";
            txtNameCa.Size = new Size(233, 30);
            txtNameCa.TabIndex = 8;
            // 
            // panel2
            // 
            panel2.Controls.Add(label1);
            panel2.Controls.Add(txtIDCa);
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
            // txtIDCa
            // 
            txtIDCa.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtIDCa.Location = new Point(88, 6);
            txtIDCa.Name = "txtIDCa";
            txtIDCa.Size = new Size(233, 30);
            txtIDCa.TabIndex = 8;
            // 
            // btnUpdate
            // 
            btnUpdate.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnUpdate.Location = new Point(375, 163);
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
            btnAdd.Location = new Point(133, 163);
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
            btnDelete.Location = new Point(254, 163);
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
            // fCafeCategory
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(625, 480);
            Controls.Add(panel1);
            Controls.Add(btnUpdate);
            Controls.Add(btnAdd);
            Controls.Add(btnDelete);
            Controls.Add(dataGridViewDrinksCategory);
            Name = "fCafeCategory";
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
        private TextBox txtNameCa;
        private Panel panel2;
        private Label label1;
        private TextBox txtIDCa;
        private Button btnUpdate;
        private Button btnAdd;
        private Button btnDelete;
        private DataGridView dataGridViewDrinksCategory;
    }
}