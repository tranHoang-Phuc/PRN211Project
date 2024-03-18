namespace WinFormsApp1
{
    partial class frmEmployees
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
            btnCloseFormRevenue = new Button();
            colorDialog1 = new ColorDialog();
            panel1 = new Panel();
            tableLayoutPanel1 = new TableLayoutPanel();
            panel2 = new Panel();
            panel5 = new Panel();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            panel4 = new Panel();
            panel12 = new Panel();
            txtPassword = new TextBox();
            label10 = new Label();
            panel11 = new Panel();
            txtUserName = new TextBox();
            label9 = new Label();
            panel10 = new Panel();
            dtpDataStartWork = new DateTimePicker();
            label8 = new Label();
            panel7 = new Panel();
            txtEmail = new TextBox();
            label6 = new Label();
            panel8 = new Panel();
            txtPhoneNumber = new TextBox();
            label5 = new Label();
            panel9 = new Panel();
            cbJobPosition = new ComboBox();
            label7 = new Label();
            panel16 = new Panel();
            txtId = new TextBox();
            label12 = new Label();
            panel6 = new Panel();
            txtLastName = new TextBox();
            label4 = new Label();
            txtFirstName = new TextBox();
            label3 = new Label();
            panel3 = new Panel();
            label2 = new Label();
            panel13 = new Panel();
            lsvEmployees = new ListView();
            id = new ColumnHeader();
            firstName = new ColumnHeader();
            lastName = new ColumnHeader();
            Email = new ColumnHeader();
            SĐT = new ColumnHeader();
            s = new ColumnHeader();
            Tên = new ColumnHeader();
            panel14 = new Panel();
            panel15 = new Panel();
            label11 = new Label();
            label1 = new Label();
            panel1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            panel2.SuspendLayout();
            panel5.SuspendLayout();
            panel4.SuspendLayout();
            panel12.SuspendLayout();
            panel11.SuspendLayout();
            panel10.SuspendLayout();
            panel7.SuspendLayout();
            panel8.SuspendLayout();
            panel9.SuspendLayout();
            panel16.SuspendLayout();
            panel6.SuspendLayout();
            panel3.SuspendLayout();
            panel13.SuspendLayout();
            panel15.SuspendLayout();
            SuspendLayout();
            // 
            // btnCloseFormRevenue
            // 
            btnCloseFormRevenue.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnCloseFormRevenue.AutoSize = true;
            btnCloseFormRevenue.BackColor = Color.Black;
            btnCloseFormRevenue.Font = new Font("Microsoft Sans Serif", 19.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnCloseFormRevenue.ForeColor = Color.White;
            btnCloseFormRevenue.Location = new Point(1098, 3);
            btnCloseFormRevenue.Margin = new Padding(4, 3, 4, 3);
            btnCloseFormRevenue.Name = "btnCloseFormRevenue";
            btnCloseFormRevenue.Size = new Size(49, 47);
            btnCloseFormRevenue.TabIndex = 22;
            btnCloseFormRevenue.Text = "X";
            btnCloseFormRevenue.UseVisualStyleBackColor = false;
            this.btnCloseFormRevenue.Click += new System.EventHandler(this.btnCloseFormRevenue_Click_1);
            // 
            // panel1
            // 
            panel1.Controls.Add(tableLayoutPanel1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 49);
            panel1.Margin = new Padding(4, 3, 4, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(1150, 649);
            panel1.TabIndex = 24;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 60F));
            tableLayoutPanel1.Controls.Add(panel2, 0, 0);
            tableLayoutPanel1.Controls.Add(panel13, 1, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Margin = new Padding(0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(1150, 649);
            tableLayoutPanel1.TabIndex = 25;
            // 
            // panel2
            // 
            panel2.Controls.Add(panel5);
            panel2.Controls.Add(panel4);
            panel2.Controls.Add(panel3);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(4, 3);
            panel2.Margin = new Padding(4, 3, 4, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(452, 643);
            panel2.TabIndex = 0;
            // 
            // panel5
            // 
            panel5.Controls.Add(button4);
            panel5.Controls.Add(button3);
            panel5.Controls.Add(button2);
            panel5.Controls.Add(button1);
            panel5.Dock = DockStyle.Bottom;
            panel5.Location = new Point(0, 571);
            panel5.Margin = new Padding(4, 3, 4, 3);
            panel5.Name = "panel5";
            panel5.Size = new Size(452, 72);
            panel5.TabIndex = 3;
            // 
            // button4
            // 
            button4.BackColor = Color.FromArgb(113, 201, 206);
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            button4.Location = new Point(344, 13);
            button4.Margin = new Padding(4, 3, 4, 3);
            button4.Name = "button4";
            button4.Size = new Size(102, 48);
            button4.TabIndex = 0;
            button4.Text = "Làm mới";
            button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);

            // 
            // button3
            // 
            button3.BackColor = Color.LightSlateGray;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            button3.Location = new Point(232, 13);
            button3.Margin = new Padding(4, 3, 4, 3);
            button3.Name = "button3";
            button3.Size = new Size(102, 48);
            button3.TabIndex = 0;
            button3.Text = "Xóa";
            button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);

            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(113, 201, 206);
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(119, 13);
            button2.Margin = new Padding(4, 3, 4, 3);
            button2.Name = "button2";
            button2.Size = new Size(102, 48);
            button2.TabIndex = 0;
            button2.Text = "Sửa";
            button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);

            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(113, 201, 206);
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(6, 13);
            button1.Margin = new Padding(4, 3, 4, 3);
            button1.Name = "button1";
            button1.Size = new Size(102, 48);
            button1.TabIndex = 0;
            button1.Text = "Thêm";
            button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);

            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(227, 253, 253);
            panel4.Controls.Add(panel12);
            panel4.Controls.Add(panel11);
            panel4.Controls.Add(panel10);
            panel4.Controls.Add(panel7);
            panel4.Controls.Add(panel8);
            panel4.Controls.Add(panel9);
            panel4.Controls.Add(panel16);
            panel4.Controls.Add(panel6);
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(0, 50);
            panel4.Margin = new Padding(4, 3, 4, 3);
            panel4.Name = "panel4";
            panel4.Size = new Size(452, 593);
            panel4.TabIndex = 2;
            // 
            // panel12
            // 
            panel12.Controls.Add(txtPassword);
            panel12.Controls.Add(label10);
            panel12.Dock = DockStyle.Top;
            panel12.Location = new Point(0, 259);
            panel12.Margin = new Padding(4, 3, 4, 3);
            panel12.Name = "panel12";
            panel12.Size = new Size(452, 38);
            panel12.TabIndex = 0;
            // 
            // txtPassword
            // 
            txtPassword.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtPassword.BorderStyle = BorderStyle.FixedSingle;
            txtPassword.Location = new Point(114, 7);
            txtPassword.Margin = new Padding(4, 3, 4, 3);
            txtPassword.MaxLength = 8;
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(164, 23);
            txtPassword.TabIndex = 1;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(28, 9);
            label10.Margin = new Padding(4, 0, 4, 0);
            label10.Name = "label10";
            label10.Size = new Size(70, 17);
            label10.TabIndex = 0;
            label10.Text = "Mật khẩu:";
            // 
            // panel11
            // 
            panel11.Controls.Add(txtUserName);
            panel11.Controls.Add(label9);
            panel11.Dock = DockStyle.Top;
            panel11.Location = new Point(0, 221);
            panel11.Margin = new Padding(4, 3, 4, 3);
            panel11.Name = "panel11";
            panel11.Size = new Size(452, 38);
            panel11.TabIndex = 0;
            // 
            // txtUserName
            // 
            txtUserName.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtUserName.BorderStyle = BorderStyle.FixedSingle;
            txtUserName.Location = new Point(114, 7);
            txtUserName.Margin = new Padding(4, 3, 4, 3);
            txtUserName.MaxLength = 10;
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(164, 23);
            txtUserName.TabIndex = 1;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(36, 9);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(61, 17);
            label9.TabIndex = 0;
            label9.Text = "Tên DN:";
            // 
            // panel10
            // 
            panel10.Controls.Add(dtpDataStartWork);
            panel10.Controls.Add(label8);
            panel10.Dock = DockStyle.Top;
            panel10.Location = new Point(0, 183);
            panel10.Margin = new Padding(4, 3, 4, 3);
            panel10.Name = "panel10";
            panel10.Size = new Size(452, 38);
            panel10.TabIndex = 0;
            // 
            // dtpDataStartWork
            // 
            dtpDataStartWork.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dtpDataStartWork.Location = new Point(114, 8);
            dtpDataStartWork.Margin = new Padding(4, 3, 4, 3);
            dtpDataStartWork.Name = "dtpDataStartWork";
            dtpDataStartWork.Size = new Size(164, 23);
            dtpDataStartWork.TabIndex = 1;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(23, 8);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(72, 17);
            label8.TabIndex = 0;
            label8.Text = "Ngày vào:";
            // 
            // panel7
            // 
            panel7.Controls.Add(txtEmail);
            panel7.Controls.Add(label6);
            panel7.Dock = DockStyle.Top;
            panel7.Location = new Point(0, 145);
            panel7.Margin = new Padding(4, 3, 4, 3);
            panel7.Name = "panel7";
            panel7.Size = new Size(452, 38);
            panel7.TabIndex = 0;
            // 
            // txtEmail
            // 
            txtEmail.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtEmail.BorderStyle = BorderStyle.FixedSingle;
            txtEmail.Location = new Point(114, 8);
            txtEmail.Margin = new Padding(4, 3, 4, 3);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(332, 23);
            txtEmail.TabIndex = 1;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(54, 8);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(46, 17);
            label6.TabIndex = 0;
            label6.Text = "Email:";
            // 
            // panel8
            // 
            panel8.Controls.Add(txtPhoneNumber);
            panel8.Controls.Add(label5);
            panel8.Dock = DockStyle.Top;
            panel8.Location = new Point(0, 107);
            panel8.Margin = new Padding(4, 3, 4, 3);
            panel8.Name = "panel8";
            panel8.Size = new Size(452, 38);
            panel8.TabIndex = 0;
            // 
            // txtPhoneNumber
            // 
            txtPhoneNumber.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtPhoneNumber.BorderStyle = BorderStyle.FixedSingle;
            txtPhoneNumber.Location = new Point(114, 8);
            txtPhoneNumber.Margin = new Padding(4, 3, 4, 3);
            txtPhoneNumber.Name = "txtPhoneNumber";
            txtPhoneNumber.Size = new Size(332, 23);
            txtPhoneNumber.TabIndex = 1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(61, 12);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(40, 17);
            label5.TabIndex = 0;
            label5.Text = "SDT:";
            // 
            // panel9
            // 
            panel9.Controls.Add(cbJobPosition);
            panel9.Controls.Add(label7);
            panel9.Dock = DockStyle.Top;
            panel9.Location = new Point(0, 69);
            panel9.Margin = new Padding(4, 3, 4, 3);
            panel9.Name = "panel9";
            panel9.Size = new Size(452, 38);
            panel9.TabIndex = 0;
            // 
            // cbJobPosition
            // 
            cbJobPosition.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            cbJobPosition.DropDownStyle = ComboBoxStyle.DropDownList;
            cbJobPosition.FormattingEnabled = true;
            cbJobPosition.Location = new Point(114, 9);
            cbJobPosition.Margin = new Padding(4, 3, 4, 3);
            cbJobPosition.Name = "cbJobPosition";
            cbJobPosition.Size = new Size(164, 23);
            cbJobPosition.TabIndex = 1;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(34, 9);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(63, 17);
            label7.TabIndex = 0;
            label7.Text = "Chức vụ:";
            // 
            // panel16
            // 
            panel16.Controls.Add(txtId);
            panel16.Controls.Add(label12);
            panel16.Dock = DockStyle.Top;
            panel16.Location = new Point(0, 38);
            panel16.Margin = new Padding(2);
            panel16.Name = "panel16";
            panel16.Size = new Size(452, 31);
            panel16.TabIndex = 0;
            panel16.Visible = false;
            // 
            // txtId
            // 
            txtId.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtId.BorderStyle = BorderStyle.FixedSingle;
            txtId.Location = new Point(114, 5);
            txtId.Margin = new Padding(2);
            txtId.MaxLength = 8;
            txtId.Name = "txtId";
            txtId.Size = new Size(128, 23);
            txtId.TabIndex = 1;
            txtId.Visible = false;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label12.Location = new Point(79, 6);
            label12.Margin = new Padding(2, 0, 2, 0);
            label12.Name = "label12";
            label12.Size = new Size(25, 17);
            label12.TabIndex = 0;
            label12.Text = "ID:";
            // 
            // panel6
            // 
            panel6.Controls.Add(txtLastName);
            panel6.Controls.Add(label4);
            panel6.Controls.Add(txtFirstName);
            panel6.Controls.Add(label3);
            panel6.Dock = DockStyle.Top;
            panel6.Location = new Point(0, 0);
            panel6.Margin = new Padding(4, 3, 4, 3);
            panel6.Name = "panel6";
            panel6.Size = new Size(452, 38);
            panel6.TabIndex = 0;
            // 
            // txtLastName
            // 
            txtLastName.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtLastName.BorderStyle = BorderStyle.FixedSingle;
            txtLastName.Location = new Point(321, 8);
            txtLastName.Margin = new Padding(4, 3, 4, 3);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(125, 23);
            txtLastName.TabIndex = 3;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(282, 9);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(37, 17);
            label4.TabIndex = 2;
            label4.Text = "Tên:";
            // 
            // txtFirstName
            // 
            txtFirstName.BorderStyle = BorderStyle.FixedSingle;
            txtFirstName.Location = new Point(114, 8);
            txtFirstName.Margin = new Padding(4, 3, 4, 3);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(164, 23);
            txtFirstName.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(8, 9);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(85, 17);
            label3.TabIndex = 0;
            label3.Text = "Họ tên đệm:";
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(57, 62, 70);
            panel3.Controls.Add(label2);
            panel3.Dock = DockStyle.Top;
            panel3.ForeColor = Color.White;
            panel3.Location = new Point(0, 0);
            panel3.Margin = new Padding(4, 3, 4, 3);
            panel3.Name = "panel3";
            panel3.Size = new Size(452, 50);
            panel3.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(121, 13);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(166, 20);
            label2.TabIndex = 0;
            label2.Text = "Thông tin nhân viên";
            // 
            // panel13
            // 
            panel13.Controls.Add(lsvEmployees);
            panel13.Controls.Add(panel14);
            panel13.Controls.Add(panel15);
            panel13.Dock = DockStyle.Fill;
            panel13.Location = new Point(464, 3);
            panel13.Margin = new Padding(4, 3, 4, 3);
            panel13.Name = "panel13";
            panel13.Size = new Size(682, 643);
            panel13.TabIndex = 1;
            // 
            // lsvEmployees
            // 
            lsvEmployees.Columns.AddRange(new ColumnHeader[] { id, firstName, lastName, Email, SĐT, s, Tên });
            lsvEmployees.Dock = DockStyle.Fill;
            lsvEmployees.ForeColor = Color.Black;
            lsvEmployees.FullRowSelect = true;
            lsvEmployees.GridLines = true;
            lsvEmployees.Location = new Point(0, 48);
            lsvEmployees.Margin = new Padding(4, 3, 4, 3);
            lsvEmployees.Name = "lsvEmployees";
            lsvEmployees.Size = new Size(682, 523);
            lsvEmployees.TabIndex = 2;
            lsvEmployees.UseCompatibleStateImageBehavior = false;
            lsvEmployees.View = View.Details;
            this.lsvEmployees.SelectedIndexChanged += new System.EventHandler(this.lsvEmployees_SelectedIndexChanged);

            // 
            // id
            // 
            id.Text = "ID";
            id.Width = 35;
            // 
            // firstName
            // 
            firstName.Text = "Họ";
            firstName.Width = 67;
            // 
            // lastName
            // 
            lastName.Text = "Tên";
            lastName.Width = 124;
            // 
            // Email
            // 
            Email.Text = "Email";
            Email.Width = 140;
            // 
            // SĐT
            // 
            SĐT.Text = "SĐT";
            SĐT.Width = 101;
            // 
            // s
            // 
            s.Text = "Vị trí";
            s.Width = 128;
            // 
            // Tên
            // 
            Tên.Text = "Ngày vào";
            Tên.Width = 130;
            // 
            // panel14
            // 
            panel14.Dock = DockStyle.Bottom;
            panel14.Location = new Point(0, 571);
            panel14.Margin = new Padding(4, 3, 4, 3);
            panel14.Name = "panel14";
            panel14.Size = new Size(682, 72);
            panel14.TabIndex = 1;
            // 
            // panel15
            // 
            panel15.BackColor = Color.FromArgb(57, 62, 70);
            panel15.Controls.Add(label11);
            panel15.Dock = DockStyle.Top;
            panel15.ForeColor = Color.White;
            panel15.Location = new Point(0, 0);
            panel15.Margin = new Padding(4, 3, 4, 3);
            panel15.Name = "panel15";
            panel15.Size = new Size(682, 48);
            panel15.TabIndex = 0;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label11.Location = new Point(220, 13);
            label11.Margin = new Padding(4, 0, 4, 0);
            label11.Name = "label11";
            label11.Size = new Size(177, 20);
            label11.TabIndex = 0;
            label11.Text = "Danh sách nhân viên";
            // 
            // label1
            // 
            label1.BackColor = Color.WhiteSmoke;
            label1.BorderStyle = BorderStyle.FixedSingle;
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Arial", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(0, 0);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(1150, 49);
            label1.TabIndex = 23;
            label1.Text = "QUẢN LÝ NHÂN VIÊN";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // frmEmployees
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1150, 698);
            Controls.Add(panel1);
            Controls.Add(btnCloseFormRevenue);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 3, 4, 3);
            Name = "frmEmployees";
            Text = "fRevenue";
            panel1.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel12.ResumeLayout(false);
            panel12.PerformLayout();
            panel11.ResumeLayout(false);
            panel11.PerformLayout();
            panel10.ResumeLayout(false);
            panel10.PerformLayout();
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            panel8.ResumeLayout(false);
            panel8.PerformLayout();
            panel9.ResumeLayout(false);
            panel9.PerformLayout();
            panel16.ResumeLayout(false);
            panel16.PerformLayout();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel13.ResumeLayout(false);
            panel15.ResumeLayout(false);
            panel15.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCloseFormRevenue;
        private ColorDialog colorDialog1;
        private Panel panel1;
        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel2;
        private Panel panel5;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Panel panel4;
        private Panel panel12;
        private TextBox txtPassword;
        private Label label10;
        private Panel panel11;
        private TextBox txtUserName;
        private Label label9;
        private Panel panel10;
        private DateTimePicker dtpDataStartWork;
        private Label label8;
        private Panel panel7;
        private TextBox txtEmail;
        private Label label6;
        private Panel panel8;
        private TextBox txtPhoneNumber;
        private Label label5;
        private Panel panel9;
        private ComboBox cbJobPosition;
        private Label label7;
        private Panel panel16;
        private TextBox txtId;
        private Label label12;
        private Panel panel6;
        private TextBox txtLastName;
        private Label label4;
        private TextBox txtFirstName;
        private Label label3;
        private Panel panel3;
        private Label label2;
        private Panel panel14;
        private Panel panel13;
        private ListView lsvEmployees;
        private Label label11;
        private Panel panel15;
        private Label label1;
        private ColumnHeader id;
        private ColumnHeader firstName;
        private ColumnHeader lastName;
        private ColumnHeader Email;
        private ColumnHeader SĐT;
        private ColumnHeader s;
        private ColumnHeader Tên;
    }
}