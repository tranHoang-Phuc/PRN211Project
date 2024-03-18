namespace WinFormsApp1
{
    partial class frmTakeaway
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
            components = new System.ComponentModel.Container();
            btnDone = new Button();
            label3 = new Label();
            panel4 = new Panel();
            btnDeleteOrder = new Button();
            rtbNote = new RichTextBox();
            lbIdAddress = new Label();
            label5 = new Label();
            panel6 = new Panel();
            columnHeader9 = new ColumnHeader();
            columnHeader8 = new ColumnHeader();
            columnHeader7 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            lsvBillDetail = new ListView();
            panel7 = new Panel();
            pnRight = new Panel();
            btnCloseFormTakeaway = new Button();
            label1 = new Label();
            panel1 = new Panel();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            lsvTABill = new ListView();
            clhId = new ColumnHeader();
            clhIdTableFood = new ColumnHeader();
            clhInDate = new ColumnHeader();
            clhOutDate = new ColumnHeader();
            clhStatus = new ColumnHeader();
            columnHeader1 = new ColumnHeader();
            label2 = new Label();
            tabPage2 = new TabPage();
            lsvTADone = new ListView();
            columnHeader2 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            columnHeader6 = new ColumnHeader();
            columnHeader10 = new ColumnHeader();
            columnHeader11 = new ColumnHeader();
            label4 = new Label();
            imageList1 = new ImageList(components);
            pnLeft = new Panel();
            panel4.SuspendLayout();
            panel6.SuspendLayout();
            panel7.SuspendLayout();
            pnRight.SuspendLayout();
            panel1.SuspendLayout();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            pnLeft.SuspendLayout();
            SuspendLayout();
            // 
            // btnDone
            // 
            btnDone.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            btnDone.BackColor = Color.FromArgb(113, 201, 206);
            btnDone.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnDone.ForeColor = SystemColors.ButtonHighlight;
            btnDone.Location = new Point(400, 2);
            btnDone.Name = "btnDone";
            btnDone.Size = new Size(143, 44);
            btnDone.TabIndex = 14;
            btnDone.Text = "Hoàn thành";
            btnDone.UseVisualStyleBackColor = false;
            btnDone.Click += btnDone_Click;
            // 
            // label3
            // 
            label3.BackColor = Color.FromArgb(57, 62, 70);
            label3.BorderStyle = BorderStyle.FixedSingle;
            label3.Dock = DockStyle.Top;
            label3.Font = new Font("Arial", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.Transparent;
            label3.Location = new Point(10, 10);
            label3.Name = "label3";
            label3.Size = new Size(696, 37);
            label3.TabIndex = 12;
            label3.Text = "Thông tin chi tiết đơn hàng";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel4
            // 
            panel4.BackColor = Color.White;
            panel4.Controls.Add(btnDeleteOrder);
            panel4.Controls.Add(btnDone);
            panel4.Dock = DockStyle.Bottom;
            panel4.Location = new Point(10, 654);
            panel4.Name = "panel4";
            panel4.Size = new Size(696, 47);
            panel4.TabIndex = 22;
            // 
            // btnDeleteOrder
            // 
            btnDeleteOrder.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            btnDeleteOrder.BackColor = Color.LightSlateGray;
            btnDeleteOrder.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnDeleteOrder.ForeColor = SystemColors.ButtonHighlight;
            btnDeleteOrder.Location = new Point(549, 2);
            btnDeleteOrder.Name = "btnDeleteOrder";
            btnDeleteOrder.Size = new Size(135, 45);
            btnDeleteOrder.TabIndex = 16;
            btnDeleteOrder.Text = "Hủy đơn";
            btnDeleteOrder.UseVisualStyleBackColor = false;
            btnDeleteOrder.Click += btnDone_Click;
            // 
            // rtbNote
            // 
            rtbNote.Dock = DockStyle.Bottom;
            rtbNote.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            rtbNote.Location = new Point(0, 520);
            rtbNote.Name = "rtbNote";
            rtbNote.Size = new Size(696, 87);
            rtbNote.TabIndex = 17;
            rtbNote.Text = "Ghi chú:";
            // 
            // lbIdAddress
            // 
            lbIdAddress.BackColor = Color.White;
            lbIdAddress.BorderStyle = BorderStyle.FixedSingle;
            lbIdAddress.Dock = DockStyle.Fill;
            lbIdAddress.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbIdAddress.Location = new Point(117, 0);
            lbIdAddress.Name = "lbIdAddress";
            lbIdAddress.Size = new Size(579, 53);
            lbIdAddress.TabIndex = 18;
            lbIdAddress.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            label5.BackColor = Color.White;
            label5.BorderStyle = BorderStyle.FixedSingle;
            label5.Dock = DockStyle.Left;
            label5.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(0, 0);
            label5.Name = "label5";
            label5.Size = new Size(117, 53);
            label5.TabIndex = 19;
            label5.Text = "ID:\r\nAddress:";
            label5.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // panel6
            // 
            panel6.Controls.Add(lbIdAddress);
            panel6.Controls.Add(label5);
            panel6.Dock = DockStyle.Top;
            panel6.Location = new Point(0, 0);
            panel6.Name = "panel6";
            panel6.Size = new Size(696, 53);
            panel6.TabIndex = 20;
            // 
            // columnHeader9
            // 
            columnHeader9.Text = "Quantity";
            columnHeader9.Width = 120;
            // 
            // columnHeader8
            // 
            columnHeader8.Text = "Food Name";
            columnHeader8.Width = 240;
            // 
            // columnHeader7
            // 
            columnHeader7.Text = "Food ID";
            columnHeader7.Width = 100;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Bill ID";
            columnHeader3.Width = 90;
            // 
            // lsvBillDetail
            // 
            lsvBillDetail.Columns.AddRange(new ColumnHeader[] { columnHeader3, columnHeader7, columnHeader8, columnHeader9 });
            lsvBillDetail.Dock = DockStyle.Fill;
            lsvBillDetail.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lsvBillDetail.FullRowSelect = true;
            lsvBillDetail.GridLines = true;
            lsvBillDetail.Location = new Point(0, 53);
            lsvBillDetail.MultiSelect = false;
            lsvBillDetail.Name = "lsvBillDetail";
            lsvBillDetail.Size = new Size(696, 467);
            lsvBillDetail.TabIndex = 21;
            lsvBillDetail.UseCompatibleStateImageBehavior = false;
            lsvBillDetail.View = View.Details;
            // 
            // panel7
            // 
            panel7.Controls.Add(lsvBillDetail);
            panel7.Controls.Add(panel6);
            panel7.Controls.Add(rtbNote);
            panel7.Dock = DockStyle.Fill;
            panel7.Location = new Point(10, 47);
            panel7.Name = "panel7";
            panel7.Size = new Size(696, 607);
            panel7.TabIndex = 23;
            // 
            // pnRight
            // 
            pnRight.Controls.Add(panel7);
            pnRight.Controls.Add(label3);
            pnRight.Controls.Add(panel4);
            pnRight.Dock = DockStyle.Fill;
            pnRight.Location = new Point(601, 44);
            pnRight.Name = "pnRight";
            pnRight.Padding = new Padding(10, 10, 0, 0);
            pnRight.Size = new Size(706, 701);
            pnRight.TabIndex = 29;
            // 
            // btnCloseFormTakeaway
            // 
            btnCloseFormTakeaway.BackColor = Color.Black;
            btnCloseFormTakeaway.Dock = DockStyle.Right;
            btnCloseFormTakeaway.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnCloseFormTakeaway.ForeColor = SystemColors.ButtonHighlight;
            btnCloseFormTakeaway.Location = new Point(1248, 0);
            btnCloseFormTakeaway.Margin = new Padding(0);
            btnCloseFormTakeaway.Name = "btnCloseFormTakeaway";
            btnCloseFormTakeaway.Size = new Size(59, 44);
            btnCloseFormTakeaway.TabIndex = 8;
            btnCloseFormTakeaway.Text = "X";
            btnCloseFormTakeaway.UseVisualStyleBackColor = false;
            btnCloseFormTakeaway.Click += btnCloseFormTakeaway_Click;
            // 
            // label1
            // 
            label1.BackColor = Color.WhiteSmoke;
            label1.BorderStyle = BorderStyle.FixedSingle;
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Arial", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(1307, 44);
            label1.TabIndex = 19;
            label1.Text = "PHỤC VỤ MANG VỀ";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            panel1.BackColor = Color.WhiteSmoke;
            panel1.Controls.Add(btnCloseFormTakeaway);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1307, 44);
            panel1.TabIndex = 27;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.ImageList = imageList1;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Margin = new Padding(0);
            tabControl1.Name = "tabControl1";
            tabControl1.Padding = new Point(0, 0);
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(601, 701);
            tabControl1.TabIndex = 20;
            tabControl1.SelectedIndexChanged += tabControl1_SelectedIndexChanged;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(lsvTABill);
            tabPage1.Controls.Add(label2);
            tabPage1.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            tabPage1.ImageIndex = 0;
            tabPage1.Location = new Point(4, 24);
            tabPage1.Margin = new Padding(0);
            tabPage1.Name = "tabPage1";
            tabPage1.Size = new Size(593, 673);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Waiting";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // lsvTABill
            // 
            lsvTABill.Columns.AddRange(new ColumnHeader[] { clhId, clhIdTableFood, clhInDate, clhOutDate, clhStatus, columnHeader1 });
            lsvTABill.Dock = DockStyle.Fill;
            lsvTABill.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lsvTABill.FullRowSelect = true;
            lsvTABill.GridLines = true;
            lsvTABill.Location = new Point(0, 34);
            lsvTABill.MultiSelect = false;
            lsvTABill.Name = "lsvTABill";
            lsvTABill.Size = new Size(593, 639);
            lsvTABill.TabIndex = 17;
            lsvTABill.UseCompatibleStateImageBehavior = false;
            lsvTABill.View = View.Details;
            lsvTABill.SelectedIndexChanged += lsvTABill_SelectedIndexChanged;
            // 
            // clhId
            // 
            clhId.Text = "ID Bill";
            clhId.Width = 55;
            // 
            // clhIdTableFood
            // 
            clhIdTableFood.Text = "Table ID";
            clhIdTableFood.Width = 70;
            // 
            // clhInDate
            // 
            clhInDate.Text = "CheckIn Date";
            clhInDate.Width = 150;
            // 
            // clhOutDate
            // 
            clhOutDate.Text = "Checout Date";
            clhOutDate.Width = 150;
            // 
            // clhStatus
            // 
            clhStatus.Text = "Paid";
            clhStatus.TextAlign = HorizontalAlignment.Center;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Employee ID";
            columnHeader1.Width = 90;
            // 
            // label2
            // 
            label2.BackColor = Color.FromArgb(57, 62, 70);
            label2.BorderStyle = BorderStyle.FixedSingle;
            label2.Dock = DockStyle.Top;
            label2.Font = new Font("Arial", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.Transparent;
            label2.Location = new Point(0, 0);
            label2.Margin = new Padding(0);
            label2.Name = "label2";
            label2.Size = new Size(593, 34);
            label2.TabIndex = 10;
            label2.Text = "Đơn hàng mang về đang chờ";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(lsvTADone);
            tabPage2.Controls.Add(label4);
            tabPage2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            tabPage2.ImageIndex = 1;
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(593, 673);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Finished";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // lsvTADone
            // 
            lsvTADone.Columns.AddRange(new ColumnHeader[] { columnHeader2, columnHeader4, columnHeader5, columnHeader6, columnHeader10, columnHeader11 });
            lsvTADone.Dock = DockStyle.Fill;
            lsvTADone.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lsvTADone.FullRowSelect = true;
            lsvTADone.GridLines = true;
            lsvTADone.Location = new Point(3, 37);
            lsvTADone.MultiSelect = false;
            lsvTADone.Name = "lsvTADone";
            lsvTADone.Size = new Size(587, 633);
            lsvTADone.TabIndex = 17;
            lsvTADone.UseCompatibleStateImageBehavior = false;
            lsvTADone.View = View.Details;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "ID Bill";
            columnHeader2.Width = 55;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Table ID";
            columnHeader4.Width = 90;
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "CheckIn Date";
            columnHeader5.Width = 110;
            // 
            // columnHeader6
            // 
            columnHeader6.Text = "Checout Date";
            columnHeader6.Width = 110;
            // 
            // columnHeader10
            // 
            columnHeader10.Text = "Paid";
            columnHeader10.TextAlign = HorizontalAlignment.Center;
            // 
            // columnHeader11
            // 
            columnHeader11.Text = "Employee ID";
            // 
            // label4
            // 
            label4.BackColor = Color.FromArgb(57, 62, 70);
            label4.BorderStyle = BorderStyle.FixedSingle;
            label4.Dock = DockStyle.Top;
            label4.Font = new Font("Arial", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.Transparent;
            label4.Location = new Point(3, 3);
            label4.Margin = new Padding(0);
            label4.Name = "label4";
            label4.Size = new Size(587, 34);
            label4.TabIndex = 10;
            label4.Text = "Đơn hàng mang về đã hoàn thành";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth8Bit;
            imageList1.ImageSize = new Size(16, 16);
            imageList1.TransparentColor = Color.Transparent;
            // 
            // pnLeft
            // 
            pnLeft.Controls.Add(tabControl1);
            pnLeft.Dock = DockStyle.Left;
            pnLeft.Location = new Point(0, 44);
            pnLeft.Name = "pnLeft";
            pnLeft.Size = new Size(601, 701);
            pnLeft.TabIndex = 28;
            // 
            // frmTakeaway
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1307, 745);
            Controls.Add(pnRight);
            Controls.Add(pnLeft);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "frmTakeaway";
            Text = "fTakeaway";
            Load += fTakeaway_Load;
            panel4.ResumeLayout(false);
            panel6.ResumeLayout(false);
            panel7.ResumeLayout(false);
            pnRight.ResumeLayout(false);
            panel1.ResumeLayout(false);
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage2.ResumeLayout(false);
            pnLeft.ResumeLayout(false);
            ResumeLayout(false);
        }
        #endregion
        private System.Windows.Forms.Button btnDone;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnDeleteOrder;
        private System.Windows.Forms.RichTextBox rtbNote;
        private System.Windows.Forms.Label lbIdAddress;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ListView lsvBillDetail;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel pnRight;
        private System.Windows.Forms.Button btnCloseFormTakeaway;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel pnLeft;
        private System.Windows.Forms.ListView lsvTABill;
        private System.Windows.Forms.ColumnHeader clhId;
        private System.Windows.Forms.ColumnHeader clhIdTableFood;
        private System.Windows.Forms.ColumnHeader clhInDate;
        private System.Windows.Forms.ColumnHeader clhOutDate;
        private System.Windows.Forms.ColumnHeader clhStatus;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ListView lsvTADone;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ImageList imageList1;
    }
}