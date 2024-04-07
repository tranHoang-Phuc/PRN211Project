namespace WinFormsApp1
{
    partial class frmTable:Form
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
            button1 = new Button();
            button2 = new Button();
            btnCloseFormTable = new Button();
            btnAddFood = new Button();
            btnCheckOut = new Button();
            panel1 = new Panel();
            tableLayoutPanel1 = new TableLayoutPanel();
            panel3 = new Panel();
            panel9 = new Panel();
            flpTable = new FlowLayoutPanel();
            panel8 = new Panel();
            txtTableEmpty = new TextBox();
            label5 = new Label();
            txtTableActive = new TextBox();
            label4 = new Label();
            txtTableCount = new TextBox();
            label2 = new Label();
            panel7 = new Panel();
            label1 = new Label();
            panel4 = new Panel();
            panel12 = new Panel();
            lsvBill = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            panel11 = new Panel();
            txtNameTable = new TextBox();
            txtTotalPrice = new TextBox();
            panel10 = new Panel();
            nmFoodCount = new NumericUpDown();
            cbFood = new ComboBox();
            cbCategory = new ComboBox();
            panel2 = new Panel();
            label3 = new Label();
            panel5 = new Panel();
            panel6 = new Panel();
            panel1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            panel3.SuspendLayout();
            panel9.SuspendLayout();
            panel8.SuspendLayout();
            panel7.SuspendLayout();
            panel4.SuspendLayout();
            panel12.SuspendLayout();
            panel11.SuspendLayout();
            panel10.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nmFoodCount).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top;
            button1.Location = new Point(129, 7);
            button1.Margin = new Padding(4);
            button1.Name = "button1";
            button1.Size = new Size(102, 29);
            button1.TabIndex = 4;
            button1.Text = "Tổng tiền";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Top;
            button2.Location = new Point(4, 7);
            button2.Margin = new Padding(4);
            button2.Name = "button2";
            button2.Size = new Size(116, 29);
            button2.TabIndex = 10;
            button2.Text = "Bàn đang chọn";
            button2.UseVisualStyleBackColor = true;
            // 
            // btnCloseFormTable
            // 
            btnCloseFormTable.BackColor = Color.Black;
            btnCloseFormTable.Dock = DockStyle.Right;
            btnCloseFormTable.Font = new Font("Microsoft Sans Serif", 19.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnCloseFormTable.ForeColor = Color.White;
            btnCloseFormTable.Location = new Point(1190, 0);
            btnCloseFormTable.Margin = new Padding(4);
            btnCloseFormTable.Name = "btnCloseFormTable";
            btnCloseFormTable.Size = new Size(46, 40);
            btnCloseFormTable.TabIndex = 0;
            btnCloseFormTable.Text = "X";
            btnCloseFormTable.UseVisualStyleBackColor = false;
            btnCloseFormTable.Click += btnCloseFormTable_Click;
            // 
            // btnAddFood
            // 
            btnAddFood.Anchor = AnchorStyles.Right;
            btnAddFood.BackColor = Color.FromArgb(113, 201, 206);
            btnAddFood.FlatStyle = FlatStyle.Flat;
            btnAddFood.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnAddFood.ForeColor = Color.Transparent;
            btnAddFood.Location = new Point(253, 2);
            btnAddFood.Margin = new Padding(4);
            btnAddFood.Name = "btnAddFood";
            btnAddFood.Size = new Size(150, 59);
            btnAddFood.TabIndex = 1;
            btnAddFood.Text = "Thêm món";
            btnAddFood.UseVisualStyleBackColor = false;
            btnAddFood.Click += btnAddFood_Click;
            // 
            // btnCheckOut
            // 
            btnCheckOut.BackColor = Color.FromArgb(113, 201, 206);
            btnCheckOut.Dock = DockStyle.Right;
            btnCheckOut.FlatStyle = FlatStyle.Flat;
            btnCheckOut.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnCheckOut.ForeColor = Color.Transparent;
            btnCheckOut.Location = new Point(349, 0);
            btnCheckOut.Margin = new Padding(4);
            btnCheckOut.Name = "btnCheckOut";
            btnCheckOut.Size = new Size(137, 67);
            btnCheckOut.TabIndex = 5;
            btnCheckOut.Text = "Thanh toán";
            btnCheckOut.UseVisualStyleBackColor = false;
            btnCheckOut.Click += btnCheckOut_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.DimGray;
            panel1.Controls.Add(tableLayoutPanel1);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1238, 748);
            panel1.TabIndex = 21;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = Color.White;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 60F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
            tableLayoutPanel1.Controls.Add(panel3, 0, 0);
            tableLayoutPanel1.Controls.Add(panel4, 1, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 42);
            tableLayoutPanel1.Margin = new Padding(4);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(1238, 706);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Transparent;
            panel3.Controls.Add(panel9);
            panel3.Controls.Add(panel8);
            panel3.Controls.Add(panel7);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(4, 4);
            panel3.Margin = new Padding(4);
            panel3.Name = "panel3";
            panel3.Size = new Size(734, 698);
            panel3.TabIndex = 0;
            // 
            // panel9
            // 
            panel9.Controls.Add(flpTable);
            panel9.Dock = DockStyle.Fill;
            panel9.Location = new Point(0, 30);
            panel9.Margin = new Padding(4);
            panel9.Name = "panel9";
            panel9.Size = new Size(734, 600);
            panel9.TabIndex = 3;
            // 
            // flpTable
            // 
            flpTable.BackColor = Color.FromArgb(227, 253, 253);
            flpTable.BorderStyle = BorderStyle.FixedSingle;
            flpTable.Dock = DockStyle.Fill;
            flpTable.Location = new Point(0, 0);
            flpTable.Margin = new Padding(4);
            flpTable.Name = "flpTable";
            flpTable.Size = new Size(734, 600);
            flpTable.TabIndex = 0;
            // 
            // panel8
            // 
            panel8.Controls.Add(txtTableEmpty);
            panel8.Controls.Add(label5);
            panel8.Controls.Add(txtTableActive);
            panel8.Controls.Add(label4);
            panel8.Controls.Add(txtTableCount);
            panel8.Controls.Add(label2);
            panel8.Dock = DockStyle.Bottom;
            panel8.Location = new Point(0, 630);
            panel8.Margin = new Padding(4);
            panel8.Name = "panel8";
            panel8.Size = new Size(734, 68);
            panel8.TabIndex = 2;
            // 
            // txtTableEmpty
            // 
            txtTableEmpty.Anchor = AnchorStyles.Top;
            txtTableEmpty.Location = new Point(612, 24);
            txtTableEmpty.Margin = new Padding(4);
            txtTableEmpty.Name = "txtTableEmpty";
            txtTableEmpty.ReadOnly = true;
            txtTableEmpty.Size = new Size(78, 23);
            txtTableEmpty.TabIndex = 1;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top;
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(502, 28);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(93, 16);
            label5.TabIndex = 0;
            label5.Text = "Số bàn trống:";
            // 
            // txtTableActive
            // 
            txtTableActive.Anchor = AnchorStyles.Top;
            txtTableActive.Location = new Point(359, 23);
            txtTableActive.Margin = new Padding(4);
            txtTableActive.Name = "txtTableActive";
            txtTableActive.ReadOnly = true;
            txtTableActive.Size = new Size(78, 23);
            txtTableActive.TabIndex = 1;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top;
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(226, 26);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(117, 16);
            label4.TabIndex = 0;
            label4.Text = "Số bàn có khách:";
            // 
            // txtTableCount
            // 
            txtTableCount.Anchor = AnchorStyles.Top;
            txtTableCount.Location = new Point(98, 21);
            txtTableCount.Margin = new Padding(4);
            txtTableCount.Name = "txtTableCount";
            txtTableCount.ReadOnly = true;
            txtTableCount.Size = new Size(78, 23);
            txtTableCount.TabIndex = 1;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top;
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(35, 24);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(56, 16);
            label2.TabIndex = 0;
            label2.Text = "Số bàn:";
            // 
            // panel7
            // 
            panel7.BackColor = Color.FromArgb(57, 62, 70);
            panel7.BorderStyle = BorderStyle.FixedSingle;
            panel7.Controls.Add(label1);
            panel7.Dock = DockStyle.Top;
            panel7.ForeColor = Color.White;
            panel7.Location = new Point(0, 0);
            panel7.Margin = new Padding(0);
            panel7.Name = "panel7";
            panel7.Size = new Size(734, 30);
            panel7.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(318, 4);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(112, 18);
            label1.TabIndex = 0;
            label1.Text = "Danh sách bàn";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // panel4
            // 
            panel4.BackColor = Color.Transparent;
            panel4.BorderStyle = BorderStyle.FixedSingle;
            panel4.Controls.Add(panel12);
            panel4.Controls.Add(panel11);
            panel4.Controls.Add(panel10);
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(746, 4);
            panel4.Margin = new Padding(4);
            panel4.Name = "panel4";
            panel4.Size = new Size(488, 698);
            panel4.TabIndex = 1;
            // 
            // panel12
            // 
            panel12.Controls.Add(lsvBill);
            panel12.Dock = DockStyle.Fill;
            panel12.Location = new Point(0, 65);
            panel12.Margin = new Padding(4);
            panel12.Name = "panel12";
            panel12.Size = new Size(486, 564);
            panel12.TabIndex = 2;
            // 
            // lsvBill
            // 
            lsvBill.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4 });
            lsvBill.Dock = DockStyle.Fill;
            lsvBill.FullRowSelect = true;
            lsvBill.GridLines = true;
            lsvBill.Location = new Point(0, 0);
            lsvBill.Margin = new Padding(4);
            lsvBill.Name = "lsvBill";
            lsvBill.Size = new Size(486, 564);
            lsvBill.TabIndex = 1;
            lsvBill.UseCompatibleStateImageBehavior = false;
            lsvBill.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Tên món";
            columnHeader1.Width = 153;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Số lượng";
            columnHeader2.Width = 73;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Đơn giá";
            columnHeader3.Width = 94;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Thành tiền";
            columnHeader4.Width = 94;
            // 
            // panel11
            // 
            panel11.Controls.Add(txtNameTable);
            panel11.Controls.Add(button2);
            panel11.Controls.Add(txtTotalPrice);
            panel11.Controls.Add(button1);
            panel11.Controls.Add(btnCheckOut);
            panel11.Dock = DockStyle.Bottom;
            panel11.Location = new Point(0, 629);
            panel11.Margin = new Padding(4);
            panel11.Name = "panel11";
            panel11.Size = new Size(486, 67);
            panel11.TabIndex = 1;
            // 
            // txtNameTable
            // 
            txtNameTable.Anchor = AnchorStyles.Top;
            txtNameTable.Location = new Point(4, 38);
            txtNameTable.Margin = new Padding(4);
            txtNameTable.Name = "txtNameTable";
            txtNameTable.ReadOnly = true;
            txtNameTable.Size = new Size(116, 23);
            txtNameTable.TabIndex = 11;
            // 
            // txtTotalPrice
            // 
            txtTotalPrice.Anchor = AnchorStyles.Top;
            txtTotalPrice.Location = new Point(129, 38);
            txtTotalPrice.Margin = new Padding(4);
            txtTotalPrice.Name = "txtTotalPrice";
            txtTotalPrice.ReadOnly = true;
            txtTotalPrice.Size = new Size(102, 23);
            txtTotalPrice.TabIndex = 9;
            txtTotalPrice.Text = "0";
            // 
            // panel10
            // 
            panel10.Controls.Add(nmFoodCount);
            panel10.Controls.Add(btnAddFood);
            panel10.Controls.Add(cbFood);
            panel10.Controls.Add(cbCategory);
            panel10.Dock = DockStyle.Top;
            panel10.Location = new Point(0, 0);
            panel10.Margin = new Padding(4);
            panel10.Name = "panel10";
            panel10.Size = new Size(486, 65);
            panel10.TabIndex = 0;
            // 
            // nmFoodCount
            // 
            nmFoodCount.Anchor = AnchorStyles.Right;
            nmFoodCount.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            nmFoodCount.Location = new Point(410, 17);
            nmFoodCount.Margin = new Padding(4);
            nmFoodCount.Minimum = new decimal(new int[] { 100, 0, 0, int.MinValue });
            nmFoodCount.Name = "nmFoodCount";
            nmFoodCount.Size = new Size(69, 26);
            nmFoodCount.TabIndex = 2;
            nmFoodCount.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // cbFood
            // 
            cbFood.DropDownStyle = ComboBoxStyle.DropDownList;
            cbFood.FormattingEnabled = true;
            cbFood.Location = new Point(4, 36);
            cbFood.Margin = new Padding(4);
            cbFood.Name = "cbFood";
            cbFood.Size = new Size(234, 23);
            cbFood.TabIndex = 0;
            // 
            // cbCategory
            // 
            cbCategory.DropDownStyle = ComboBoxStyle.DropDownList;
            cbCategory.ForeColor = SystemColors.ActiveCaptionText;
            cbCategory.FormattingEnabled = true;
            cbCategory.Location = new Point(4, 5);
            cbCategory.Margin = new Padding(4);
            cbCategory.MaxDropDownItems = 10;
            cbCategory.Name = "cbCategory";
            cbCategory.Size = new Size(234, 23);
            cbCategory.TabIndex = 0;
            cbCategory.SelectedIndexChanged += cbCategory_SelectedIndexChanged;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(label3);
            panel2.Controls.Add(panel5);
            panel2.Controls.Add(panel6);
            panel2.Controls.Add(btnCloseFormTable);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Margin = new Padding(4);
            panel2.Name = "panel2";
            panel2.Size = new Size(1238, 42);
            panel2.TabIndex = 0;
            // 
            // label3
            // 
            label3.Dock = DockStyle.Top;
            label3.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ActiveCaptionText;
            label3.Location = new Point(0, 0);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(1190, 43);
            label3.TabIndex = 1;
            label3.Text = "PHỤC VỤ TẠI QUÁN";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel5
            // 
            panel5.BackColor = Color.DodgerBlue;
            panel5.Location = new Point(4, 50);
            panel5.Margin = new Padding(4);
            panel5.Name = "panel5";
            panel5.Size = new Size(515, 695);
            panel5.TabIndex = 0;
            // 
            // panel6
            // 
            panel6.BackColor = Color.DodgerBlue;
            panel6.Location = new Point(666, 50);
            panel6.Margin = new Padding(4);
            panel6.Name = "panel6";
            panel6.Size = new Size(568, 695);
            panel6.TabIndex = 0;
            // 
            // frmTable
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1238, 748);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "frmTable";
            StartPosition = FormStartPosition.Manual;
            Text = "fTable";
            Load += fTable_Load;
            panel1.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel9.ResumeLayout(false);
            panel8.ResumeLayout(false);
            panel8.PerformLayout();
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            panel4.ResumeLayout(false);
            panel12.ResumeLayout(false);
            panel11.ResumeLayout(false);
            panel11.PerformLayout();
            panel10.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)nmFoodCount).EndInit();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button btnCloseFormTable;
        private Button btnAddFood;
        private Button btnCheckOut;
        private Panel panel1;
        private Panel panel4;
        private Panel panel2;
        private Panel panel3;
        private Panel panel5;
        private Panel panel10;
        private Panel panel6;
        private Panel panel7;
        private Panel panel8;
        private Panel panel9;
        private Panel panel11;
        private Panel panel12;
        private TableLayoutPanel tableLayoutPanel1;
        private FlowLayoutPanel flpTable;
        private TextBox txtTableEmpty;
        private TextBox txtTableActive;
        private TextBox txtTableCount;
        private TextBox txtNameTable;
        private TextBox txtTotalPrice;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private ComboBox cbFood;
        private ComboBox cbCategory;
        private NumericUpDown nmFoodCount;
        private ListView lsvBill;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
    }
}