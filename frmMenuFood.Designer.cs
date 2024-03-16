namespace WinFormsApp1
{
    partial class frmMenuFood
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
            btnCloseFormMenuFood = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            btnAdd = new Button();
            btnEditExit = new Button();
            groupBox1 = new GroupBox();
            lsvFood = new ListView();
            clhId = new ColumnHeader();
            clhFoodName = new ColumnHeader();
            clhImage = new ColumnHeader();
            clhPrice = new ColumnHeader();
            clhIdCategory = new ColumnHeader();
            pnDSMTop = new Panel();
            cbFilterDishes = new ComboBox();
            cbFindFoodName = new ComboBox();
            grbEditFood = new GroupBox();
            panel1 = new Panel();
            cbEditCategory = new ComboBox();
            label11 = new Label();
            label7 = new Label();
            txtEditId = new TextBox();
            txtEditImageName = new TextBox();
            label6 = new Label();
            label2 = new Label();
            txtEditFoodName = new TextBox();
            txtEditPrice = new TextBox();
            label3 = new Label();
            pnThemMon = new GroupBox();
            panel3 = new Panel();
            cbAddCategory = new ComboBox();
            label10 = new Label();
            txtNewImages = new TextBox();
            label5 = new Label();
            label8 = new Label();
            txtNewFoodName = new TextBox();
            txtNewPrice = new TextBox();
            label9 = new Label();
            label1 = new Label();
            pnTop = new Panel();
            pnLeft = new Panel();
            pnRight = new Panel();
            groupBox1.SuspendLayout();
            pnDSMTop.SuspendLayout();
            grbEditFood.SuspendLayout();
            panel1.SuspendLayout();
            pnThemMon.SuspendLayout();
            panel3.SuspendLayout();
            pnTop.SuspendLayout();
            pnLeft.SuspendLayout();
            pnRight.SuspendLayout();
            SuspendLayout();
            // 
            // btnCloseFormMenuFood
            // 
            btnCloseFormMenuFood.BackColor = Color.Black;
            btnCloseFormMenuFood.Dock = DockStyle.Right;
            btnCloseFormMenuFood.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnCloseFormMenuFood.ForeColor = SystemColors.HighlightText;
            btnCloseFormMenuFood.Location = new Point(1384, 0);
            btnCloseFormMenuFood.Margin = new Padding(0);
            btnCloseFormMenuFood.Name = "btnCloseFormMenuFood";
            btnCloseFormMenuFood.Size = new Size(59, 46);
            btnCloseFormMenuFood.TabIndex = 4;
            btnCloseFormMenuFood.Text = "X";
            btnCloseFormMenuFood.UseVisualStyleBackColor = false;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.FromArgb(113, 201, 206);
            btnUpdate.Location = new Point(211, 286);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(113, 43);
            btnUpdate.TabIndex = 4;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.LightSlateGray;
            btnDelete.Location = new Point(380, 286);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(150, 43);
            btnDelete.TabIndex = 5;
            btnDelete.Text = "Xóa món";
            btnDelete.UseVisualStyleBackColor = false;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.FromArgb(113, 201, 206);
            btnAdd.Location = new Point(300, 222);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(113, 43);
            btnAdd.TabIndex = 4;
            btnAdd.Text = "Thêm món";
            btnAdd.UseVisualStyleBackColor = false;
            // 
            // btnEditExit
            // 
            btnEditExit.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnEditExit.BackColor = Color.Black;
            btnEditExit.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnEditExit.ForeColor = SystemColors.HighlightText;
            btnEditExit.Location = new Point(617, 0);
            btnEditExit.Margin = new Padding(0);
            btnEditExit.Name = "btnEditExit";
            btnEditExit.Size = new Size(31, 33);
            btnEditExit.TabIndex = 6;
            btnEditExit.Text = "X";
            btnEditExit.UseVisualStyleBackColor = false;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.FromArgb(57, 62, 70);
            groupBox1.Controls.Add(lsvFood);
            groupBox1.Controls.Add(pnDSMTop);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.ForeColor = Color.White;
            groupBox1.Location = new Point(0, 10);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(771, 707);
            groupBox1.TabIndex = 19;
            groupBox1.TabStop = false;
            groupBox1.Text = "Danh sách món ăn";
            // 
            // lsvFood
            // 
            lsvFood.Columns.AddRange(new ColumnHeader[] { clhId, clhFoodName, clhImage, clhPrice, clhIdCategory });
            lsvFood.Dock = DockStyle.Fill;
            lsvFood.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lsvFood.FullRowSelect = true;
            lsvFood.GridLines = true;
            lsvFood.Location = new Point(3, 58);
            lsvFood.MultiSelect = false;
            lsvFood.Name = "lsvFood";
            lsvFood.Size = new Size(765, 646);
            lsvFood.TabIndex = 15;
            lsvFood.UseCompatibleStateImageBehavior = false;
            lsvFood.View = View.Details;
            // 
            // clhId
            // 
            clhId.Text = "ID";
            clhId.Width = 55;
            // 
            // clhFoodName
            // 
            clhFoodName.Text = "Tên món ăn";
            clhFoodName.Width = 250;
            // 
            // clhImage
            // 
            clhImage.Text = "Image Name";
            clhImage.Width = 150;
            // 
            // clhPrice
            // 
            clhPrice.Text = "Đơn giá vnđ/cái";
            clhPrice.Width = 186;
            // 
            // clhIdCategory
            // 
            clhIdCategory.Text = "ID Category";
            clhIdCategory.TextAlign = HorizontalAlignment.Center;
            clhIdCategory.Width = 120;
            // 
            // pnDSMTop
            // 
            pnDSMTop.Controls.Add(cbFilterDishes);
            pnDSMTop.Controls.Add(cbFindFoodName);
            pnDSMTop.Dock = DockStyle.Top;
            pnDSMTop.Location = new Point(3, 22);
            pnDSMTop.Name = "pnDSMTop";
            pnDSMTop.Size = new Size(765, 36);
            pnDSMTop.TabIndex = 25;
            // 
            // cbFilterDishes
            // 
            cbFilterDishes.BackColor = Color.FromArgb(113, 201, 206);
            cbFilterDishes.Dock = DockStyle.Left;
            cbFilterDishes.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cbFilterDishes.FormattingEnabled = true;
            cbFilterDishes.Items.AddRange(new object[] { "All" });
            cbFilterDishes.Location = new Point(0, 0);
            cbFilterDishes.Name = "cbFilterDishes";
            cbFilterDishes.Size = new Size(190, 28);
            cbFilterDishes.TabIndex = 17;
            // 
            // cbFindFoodName
            // 
            cbFindFoodName.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cbFindFoodName.AutoCompleteSource = AutoCompleteSource.ListItems;
            cbFindFoodName.BackColor = Color.LightSlateGray;
            cbFindFoodName.Dock = DockStyle.Right;
            cbFindFoodName.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cbFindFoodName.FormattingEnabled = true;
            cbFindFoodName.Location = new Point(476, 0);
            cbFindFoodName.Name = "cbFindFoodName";
            cbFindFoodName.Size = new Size(289, 28);
            cbFindFoodName.TabIndex = 16;
            // 
            // grbEditFood
            // 
            grbEditFood.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            grbEditFood.BackColor = Color.FromArgb(57, 62, 70);
            grbEditFood.Controls.Add(panel1);
            grbEditFood.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            grbEditFood.ForeColor = Color.White;
            grbEditFood.Location = new Point(10, 347);
            grbEditFood.Name = "grbEditFood";
            grbEditFood.Size = new Size(665, 364);
            grbEditFood.TabIndex = 20;
            grbEditFood.TabStop = false;
            grbEditFood.Text = "Chỉnh sửa";
            grbEditFood.Visible = false;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.White;
            panel1.Controls.Add(cbEditCategory);
            panel1.Controls.Add(label11);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(txtEditId);
            panel1.Controls.Add(txtEditImageName);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(btnEditExit);
            panel1.Controls.Add(btnDelete);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(btnUpdate);
            panel1.Controls.Add(txtEditFoodName);
            panel1.Controls.Add(txtEditPrice);
            panel1.Controls.Add(label3);
            panel1.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            panel1.Location = new Point(0, 29);
            panel1.Name = "panel1";
            panel1.Size = new Size(665, 335);
            panel1.TabIndex = 21;
            // 
            // cbEditCategory
            // 
            cbEditCategory.BackColor = Color.LightSlateGray;
            cbEditCategory.DropDownStyle = ComboBoxStyle.DropDownList;
            cbEditCategory.FormattingEnabled = true;
            cbEditCategory.Location = new Point(211, 224);
            cbEditCategory.Name = "cbEditCategory";
            cbEditCategory.Size = new Size(319, 26);
            cbEditCategory.TabIndex = 12;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.ForeColor = Color.Black;
            label11.Location = new Point(103, 224);
            label11.Name = "label11";
            label11.Size = new Size(62, 18);
            label11.TabIndex = 11;
            label11.Text = "ID Loại:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.ForeColor = Color.Black;
            label7.Location = new Point(87, 46);
            label7.Name = "label7";
            label7.Size = new Size(79, 18);
            label7.TabIndex = 9;
            label7.Text = "Id món ăn:";
            // 
            // txtEditId
            // 
            txtEditId.Enabled = false;
            txtEditId.Location = new Point(211, 38);
            txtEditId.Name = "txtEditId";
            txtEditId.ReadOnly = true;
            txtEditId.Size = new Size(319, 26);
            txtEditId.TabIndex = 10;
            // 
            // txtEditImageName
            // 
            txtEditImageName.Enabled = false;
            txtEditImageName.Location = new Point(211, 126);
            txtEditImageName.Name = "txtEditImageName";
            txtEditImageName.ReadOnly = true;
            txtEditImageName.Size = new Size(319, 26);
            txtEditImageName.TabIndex = 8;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = Color.Black;
            label6.Location = new Point(98, 134);
            label6.Name = "label6";
            label6.Size = new Size(67, 18);
            label6.TabIndex = 7;
            label6.Text = "Tên ảnh:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.Black;
            label2.Location = new Point(72, 89);
            label2.Name = "label2";
            label2.Size = new Size(93, 18);
            label2.TabIndex = 0;
            label2.Text = "Tên món ăn:";
            // 
            // txtEditFoodName
            // 
            txtEditFoodName.Location = new Point(211, 81);
            txtEditFoodName.Name = "txtEditFoodName";
            txtEditFoodName.Size = new Size(319, 26);
            txtEditFoodName.TabIndex = 1;
            // 
            // txtEditPrice
            // 
            txtEditPrice.Location = new Point(211, 172);
            txtEditPrice.Name = "txtEditPrice";
            txtEditPrice.Size = new Size(319, 26);
            txtEditPrice.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.Black;
            label3.Location = new Point(44, 175);
            label3.Name = "label3";
            label3.Size = new Size(122, 18);
            label3.TabIndex = 2;
            label3.Text = "Đơn giá vnđ/cái:";
            // 
            // pnThemMon
            // 
            pnThemMon.BackColor = Color.FromArgb(57, 62, 70);
            pnThemMon.Controls.Add(panel3);
            pnThemMon.Dock = DockStyle.Top;
            pnThemMon.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            pnThemMon.ForeColor = Color.White;
            pnThemMon.Location = new Point(10, 10);
            pnThemMon.Name = "pnThemMon";
            pnThemMon.Size = new Size(664, 306);
            pnThemMon.TabIndex = 20;
            pnThemMon.TabStop = false;
            pnThemMon.Text = "Thêm món ăn";
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel3.BackColor = Color.White;
            panel3.Controls.Add(cbAddCategory);
            panel3.Controls.Add(label10);
            panel3.Controls.Add(txtNewImages);
            panel3.Controls.Add(label5);
            panel3.Controls.Add(label8);
            panel3.Controls.Add(txtNewFoodName);
            panel3.Controls.Add(txtNewPrice);
            panel3.Controls.Add(label9);
            panel3.Controls.Add(btnAdd);
            panel3.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            panel3.Location = new Point(0, 29);
            panel3.Name = "panel3";
            panel3.Size = new Size(664, 277);
            panel3.TabIndex = 21;
            // 
            // cbAddCategory
            // 
            cbAddCategory.BackColor = Color.LightSlateGray;
            cbAddCategory.DropDownStyle = ComboBoxStyle.DropDownList;
            cbAddCategory.FormattingEnabled = true;
            cbAddCategory.Location = new Point(209, 189);
            cbAddCategory.Name = "cbAddCategory";
            cbAddCategory.Size = new Size(319, 26);
            cbAddCategory.TabIndex = 18;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.ForeColor = Color.Black;
            label10.Location = new Point(88, 189);
            label10.Name = "label10";
            label10.Size = new Size(77, 18);
            label10.TabIndex = 17;
            label10.Text = "Phân loại:";
            // 
            // txtNewImages
            // 
            txtNewImages.Enabled = false;
            txtNewImages.Location = new Point(209, 103);
            txtNewImages.Name = "txtNewImages";
            txtNewImages.ReadOnly = true;
            txtNewImages.Size = new Size(319, 26);
            txtNewImages.TabIndex = 16;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = Color.Black;
            label5.Location = new Point(97, 106);
            label5.Name = "label5";
            label5.Size = new Size(67, 18);
            label5.TabIndex = 15;
            label5.Text = "Tên ảnh:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.ForeColor = Color.Black;
            label8.Location = new Point(74, 61);
            label8.Name = "label8";
            label8.Size = new Size(93, 18);
            label8.TabIndex = 11;
            label8.Text = "Tên món ăn:";
            // 
            // txtNewFoodName
            // 
            txtNewFoodName.Location = new Point(209, 54);
            txtNewFoodName.Name = "txtNewFoodName";
            txtNewFoodName.Size = new Size(319, 26);
            txtNewFoodName.TabIndex = 12;
            // 
            // txtNewPrice
            // 
            txtNewPrice.Location = new Point(209, 149);
            txtNewPrice.Name = "txtNewPrice";
            txtNewPrice.Size = new Size(319, 26);
            txtNewPrice.TabIndex = 14;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.ForeColor = Color.Black;
            label9.Location = new Point(42, 152);
            label9.Name = "label9";
            label9.Size = new Size(122, 18);
            label9.TabIndex = 13;
            label9.Text = "Đơn giá vnđ/cái:";
            // 
            // label1
            // 
            label1.BackColor = SystemColors.Control;
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Arial", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(1443, 46);
            label1.TabIndex = 21;
            label1.Text = "DANH SÁCH MÓN ĂN";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pnTop
            // 
            pnTop.BorderStyle = BorderStyle.FixedSingle;
            pnTop.Controls.Add(btnCloseFormMenuFood);
            pnTop.Controls.Add(label1);
            pnTop.Dock = DockStyle.Top;
            pnTop.Location = new Point(0, 0);
            pnTop.Name = "pnTop";
            pnTop.Size = new Size(1445, 48);
            pnTop.TabIndex = 23;
            // 
            // pnLeft
            // 
            pnLeft.Controls.Add(groupBox1);
            pnLeft.Dock = DockStyle.Left;
            pnLeft.Location = new Point(0, 48);
            pnLeft.MinimumSize = new Size(550, 0);
            pnLeft.Name = "pnLeft";
            pnLeft.Padding = new Padding(0, 10, 0, 0);
            pnLeft.Size = new Size(771, 717);
            pnLeft.TabIndex = 24;
            // 
            // pnRight
            // 
            pnRight.Controls.Add(grbEditFood);
            pnRight.Controls.Add(pnThemMon);
            pnRight.Dock = DockStyle.Fill;
            pnRight.Location = new Point(771, 48);
            pnRight.Name = "pnRight";
            pnRight.Padding = new Padding(10, 10, 0, 0);
            pnRight.Size = new Size(674, 717);
            pnRight.TabIndex = 22;
            // 
            // frmMenuFood
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(1445, 765);
            Controls.Add(pnRight);
            Controls.Add(pnLeft);
            Controls.Add(pnTop);
            Font = new Font("Arial", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "frmMenuFood";
            Text = "fMenuFood";
            groupBox1.ResumeLayout(false);
            pnDSMTop.ResumeLayout(false);
            grbEditFood.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            pnThemMon.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            pnTop.ResumeLayout(false);
            pnLeft.ResumeLayout(false);
            pnRight.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button btnCloseFormMenuFood;
        private Button btnUpdate;
        private Button btnDelete;
        private Button btnAdd;
        private Button btnEditExit;
        private GroupBox groupBox1;
        private GroupBox grbEditFood;
        private GroupBox pnThemMon;
        private ComboBox cbFilterDishes;
        private ComboBox cbFindFoodName;
        private ListView lsvFood;
        private ColumnHeader clhId;
        private ColumnHeader clhFoodName;
        private ColumnHeader clhImage;
        private ColumnHeader clhPrice;
        private ColumnHeader clhIdCategory;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private Panel panel1;
        private Panel pnTop;
        private Panel panel3;
        private Panel pnLeft;
        private Panel pnDSMTop;
        private Panel pnRight;
        private TextBox txtEditFoodName;
        private TextBox txtEditImageName;
        private TextBox txtEditPrice;
        private TextBox txtEditId;
        private TextBox txtNewImages;
        private TextBox txtNewFoodName;
        private TextBox txtNewPrice;
        private ComboBox cbEditCategory;
        private ComboBox cbAddCategory;
    }
}