namespace WinFormsApp1
{
    partial class frmBill
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
            label1 = new Label();
            btnCloseFormBill = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            panel1 = new Panel();
            btnShow = new Button();
            dtpEnd = new DateTimePicker();
            dtpStart = new DateTimePicker();
            label2 = new Label();
            lbDayBegin = new Label();
            label3 = new Label();
            lsvBill = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            lsvBillDetail = new ListView();
            columnHeader5 = new ColumnHeader();
            columnHeader6 = new ColumnHeader();
            columnHeader7 = new ColumnHeader();
            columnHeader8 = new ColumnHeader();
            panel2 = new Panel();
            btnDelete = new Button();
            txtTotal = new TextBox();
            lbTotal = new Label();
            tableLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Font = new Font("Arial", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(0, 0);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(1059, 40);
            label1.TabIndex = 20;
            label1.Text = "HÓA ĐƠN ĐÃ THANH TOÁN";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnCloseFormBill
            // 
            btnCloseFormBill.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnCloseFormBill.BackColor = Color.Black;
            btnCloseFormBill.Font = new Font("Microsoft Sans Serif", 19.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnCloseFormBill.ForeColor = Color.White;
            btnCloseFormBill.Location = new Point(1020, 0);
            btnCloseFormBill.Name = "btnCloseFormBill";
            btnCloseFormBill.Size = new Size(36, 36);
            btnCloseFormBill.TabIndex = 2;
            btnCloseFormBill.Text = "X";
            btnCloseFormBill.UseVisualStyleBackColor = false;
            this.btnCloseFormBill.Click += new System.EventHandler(this.btnCloseFormBill_Click);
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(panel1, 0, 0);
            tableLayoutPanel1.Controls.Add(label3, 1, 0);
            tableLayoutPanel1.Controls.Add(lsvBill, 0, 1);
            tableLayoutPanel1.Controls.Add(lsvBillDetail, 1, 1);
            tableLayoutPanel1.Controls.Add(panel2, 0, 2);
            tableLayoutPanel1.Location = new Point(0, 38);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 11.1721611F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 88.8278351F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 67F));
            tableLayoutPanel1.Size = new Size(1061, 567);
            tableLayoutPanel1.TabIndex = 22;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(224, 224, 224);
            panel1.Controls.Add(btnShow);
            panel1.Controls.Add(dtpEnd);
            panel1.Controls.Add(dtpStart);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(lbDayBegin);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(0);
            panel1.Name = "panel1";
            panel1.Size = new Size(530, 55);
            panel1.TabIndex = 0;
            // 
            // btnShow
            // 
            btnShow.Anchor = AnchorStyles.Left;
            btnShow.BackColor = Color.FromArgb(113, 201, 206);
            btnShow.FlatStyle = FlatStyle.Flat;
            btnShow.Font = new Font("Arial", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnShow.ForeColor = SystemColors.ButtonHighlight;
            btnShow.Location = new Point(388, 2);
            btnShow.Margin = new Padding(2);
            btnShow.Name = "btnShow";
            btnShow.Size = new Size(132, 50);
            btnShow.TabIndex = 9;
            btnShow.Text = "Xem";
            btnShow.UseVisualStyleBackColor = false;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click_2);
            // 
            // dtpEnd
            // 
            dtpEnd.Anchor = AnchorStyles.Left;
            dtpEnd.CalendarFont = new Font("Arial", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            dtpEnd.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            dtpEnd.Location = new Point(80, 29);
            dtpEnd.Margin = new Padding(2);
            dtpEnd.Name = "dtpEnd";
            dtpEnd.Size = new Size(203, 23);
            dtpEnd.TabIndex = 7;
            // 
            // dtpStart
            // 
            dtpStart.Anchor = AnchorStyles.Left;
            dtpStart.CalendarFont = new Font("Arial", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            dtpStart.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            dtpStart.Location = new Point(79, 2);
            dtpStart.Margin = new Padding(2);
            dtpStart.Name = "dtpStart";
            dtpStart.Size = new Size(203, 23);
            dtpStart.TabIndex = 8;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(2, 33);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(78, 18);
            label2.TabIndex = 5;
            label2.Text = "Đến ngày:";
            // 
            // lbDayBegin
            // 
            lbDayBegin.AutoSize = true;
            lbDayBegin.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbDayBegin.Location = new Point(9, 6);
            lbDayBegin.Margin = new Padding(2, 0, 2, 0);
            lbDayBegin.Name = "lbDayBegin";
            lbDayBegin.Size = new Size(69, 18);
            lbDayBegin.TabIndex = 6;
            lbDayBegin.Text = "Từ ngày:";
            // 
            // label3
            // 
            label3.BackColor = Color.FromArgb(57, 62, 70);
            label3.Dock = DockStyle.Fill;
            label3.Font = new Font("Arial", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(533, 0);
            label3.Name = "label3";
            label3.Size = new Size(525, 55);
            label3.TabIndex = 37;
            label3.Text = "Thông tin chi tiết hóa đơn";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lsvBill
            // 
            lsvBill.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4 });
            lsvBill.Dock = DockStyle.Fill;
            lsvBill.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lsvBill.FullRowSelect = true;
            lsvBill.GridLines = true;
            lsvBill.Location = new Point(0, 55);
            lsvBill.Margin = new Padding(0);
            lsvBill.Name = "lsvBill";
            lsvBill.Size = new Size(530, 444);
            lsvBill.TabIndex = 38;
            lsvBill.UseCompatibleStateImageBehavior = false;
            lsvBill.View = View.Details;
            this.lsvBill.SelectedIndexChanged += new System.EventHandler(this.lsvBill_SelectedIndexChanged_1);

            // 
            // columnHeader1
            // 
            columnHeader1.Text = "ID";
            columnHeader1.Width = 33;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Tên bàn";
            columnHeader2.TextAlign = HorizontalAlignment.Center;
            columnHeader2.Width = 149;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Ngày";
            columnHeader3.TextAlign = HorizontalAlignment.Center;
            columnHeader3.Width = 180;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Thành tiền";
            columnHeader4.TextAlign = HorizontalAlignment.Center;
            columnHeader4.Width = 175;
            // 
            // lsvBillDetail
            // 
            lsvBillDetail.Columns.AddRange(new ColumnHeader[] { columnHeader5, columnHeader6, columnHeader7, columnHeader8 });
            lsvBillDetail.Dock = DockStyle.Fill;
            lsvBillDetail.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lsvBillDetail.FullRowSelect = true;
            lsvBillDetail.GridLines = true;
            lsvBillDetail.Location = new Point(530, 55);
            lsvBillDetail.Margin = new Padding(0);
            lsvBillDetail.Name = "lsvBillDetail";
            lsvBillDetail.Size = new Size(531, 444);
            lsvBillDetail.TabIndex = 38;
            lsvBillDetail.UseCompatibleStateImageBehavior = false;
            lsvBillDetail.View = View.Details;
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "Tên món";
            columnHeader5.Width = 92;
            // 
            // columnHeader6
            // 
            columnHeader6.Text = "Số lượng";
            columnHeader6.TextAlign = HorizontalAlignment.Center;
            columnHeader6.Width = 177;
            // 
            // columnHeader7
            // 
            columnHeader7.Text = "Giá tiền";
            columnHeader7.TextAlign = HorizontalAlignment.Center;
            columnHeader7.Width = 141;
            // 
            // columnHeader8
            // 
            columnHeader8.Text = "Thành tiền";
            columnHeader8.TextAlign = HorizontalAlignment.Center;
            columnHeader8.Width = 175;
            // 
            // panel2
            // 
            panel2.Controls.Add(btnDelete);
            panel2.Controls.Add(txtTotal);
            panel2.Controls.Add(lbTotal);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(2, 501);
            panel2.Margin = new Padding(2);
            panel2.Name = "panel2";
            panel2.Size = new Size(526, 64);
            panel2.TabIndex = 39;
            // 
            // btnDelete
            // 
            btnDelete.Anchor = AnchorStyles.Right;
            btnDelete.BackColor = Color.LightSlateGray;
            btnDelete.Font = new Font("Arial", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnDelete.ForeColor = SystemColors.ButtonHighlight;
            btnDelete.Location = new Point(401, 6);
            btnDelete.Margin = new Padding(0);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(123, 48);
            btnDelete.TabIndex = 33;
            btnDelete.Text = "Xoá";
            btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);

            // 
            // txtTotal
            // 
            txtTotal.Font = new Font("Arial", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtTotal.Location = new Point(108, 14);
            txtTotal.Margin = new Padding(2);
            txtTotal.Name = "txtTotal";
            txtTotal.Size = new Size(199, 29);
            txtTotal.TabIndex = 2;
            txtTotal.TextAlign = HorizontalAlignment.Right;
            // 
            // lbTotal
            // 
            lbTotal.Font = new Font("Arial", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            lbTotal.ForeColor = SystemColors.ActiveCaptionText;
            lbTotal.Location = new Point(7, 21);
            lbTotal.Margin = new Padding(2, 0, 2, 0);
            lbTotal.Name = "lbTotal";
            lbTotal.Size = new Size(105, 22);
            lbTotal.TabIndex = 0;
            lbTotal.Text = "Tổng tiền:";
            // 
            // frmBill
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(1061, 605);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(btnCloseFormBill);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 3, 4, 3);
            Name = "frmBill";
            Text = "frmBill";
            tableLayoutPanel1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Button btnCloseFormBill;
        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel1;
        private Label lbDayBegin;
        private Button btnShow;
        private DateTimePicker dtpEnd;
        private DateTimePicker dtpStart;
        private Label label2;
        private Label label3;
        private ListView lsvBill;
        private ListView lsvBillDetail;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader6;
        private ColumnHeader columnHeader7;
        private ColumnHeader columnHeader8;
        private Panel panel2;
        private TextBox txtTotal;
        private Label lbTotal;
        private Button btnDelete;
    }
}