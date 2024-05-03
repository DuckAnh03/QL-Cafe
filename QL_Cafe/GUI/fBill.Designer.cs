namespace QL_Cafe.GUI
{
    partial class fBill
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
            panel5 = new Panel();
            txtPrice = new TextBox();
            panel3 = new Panel();
            label2 = new Label();
            txtName = new TextBox();
            panel2 = new Panel();
            label1 = new Label();
            txtID = new TextBox();
            dataGridViewBill = new DataGridView();
            label4 = new Label();
            panel1.SuspendLayout();
            panel5.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewBill).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(panel5);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(602, 149);
            panel1.TabIndex = 8;
            // 
            // panel5
            // 
            panel5.Controls.Add(txtPrice);
            panel5.Location = new Point(3, 95);
            panel5.Name = "panel5";
            panel5.Size = new Size(291, 40);
            panel5.TabIndex = 12;
            // 
            // txtPrice
            // 
            txtPrice.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPrice.Location = new Point(88, 6);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(200, 30);
            txtPrice.TabIndex = 8;
            // 
            // panel3
            // 
            panel3.Controls.Add(label4);
            panel3.Controls.Add(label2);
            panel3.Controls.Add(txtName);
            panel3.Location = new Point(3, 49);
            panel3.Name = "panel3";
            panel3.Size = new Size(291, 40);
            panel3.TabIndex = 10;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(3, 9);
            label2.Name = "label2";
            label2.Size = new Size(0, 22);
            label2.TabIndex = 5;
            // 
            // txtName
            // 
            txtName.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtName.Location = new Point(88, 6);
            txtName.Name = "txtName";
            txtName.Size = new Size(200, 30);
            txtName.TabIndex = 8;
            // 
            // panel2
            // 
            panel2.Controls.Add(label1);
            panel2.Controls.Add(txtID);
            panel2.Location = new Point(3, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(291, 40);
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
            txtID.Size = new Size(200, 30);
            txtID.TabIndex = 8;
            // 
            // dataGridViewBill
            // 
            dataGridViewBill.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewBill.Location = new Point(12, 197);
            dataGridViewBill.Name = "dataGridViewBill";
            dataGridViewBill.RowHeadersWidth = 51;
            dataGridViewBill.Size = new Size(602, 271);
            dataGridViewBill.TabIndex = 9;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(3, 9);
            label4.Name = "label4";
            label4.Size = new Size(0, 22);
            label4.TabIndex = 9;
            // 
            // fBill
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(622, 480);
            Controls.Add(dataGridViewBill);
            Controls.Add(panel1);
            Name = "fBill";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "fBill";
            panel1.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewBill).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel5;
        private TextBox txtPrice;
        private Panel panel3;
        private Label label2;
        private TextBox txtName;
        private Panel panel2;
        private Label label1;
        private TextBox txtID;
        private DataGridView dataGridViewBill;
        private Label label4;
    }
}