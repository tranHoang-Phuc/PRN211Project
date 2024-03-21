using System.Reflection;

namespace WinFormsApp1
{
    partial class frmHome
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
            pnLeft = new Panel();
            panel7 = new Panel();
            btnMenu = new Button();
            btnTakeAway = new Button();
            btnHome = new Button();
            btnBill = new Button();
            btnRevenua = new Button();
            panel4 = new Panel();
            lbAccountName = new Label();
            ptbMenu = new PictureBox();
            btnSetting = new Button();
            pnBody = new Panel();
            pnLeft.SuspendLayout();
            panel7.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ptbMenu).BeginInit();
            SuspendLayout();
            // 
            // pnLeft
            // 
            pnLeft.BackColor = Color.Black;
            pnLeft.Controls.Add(panel7);
            pnLeft.Controls.Add(panel4);
            pnLeft.Controls.Add(btnSetting);
            pnLeft.Dock = DockStyle.Left;
            pnLeft.Location = new Point(0, 0);
            pnLeft.Margin = new Padding(2, 2, 0, 2);
            pnLeft.MaximumSize = new Size(174, 0);
            pnLeft.MinimumSize = new Size(44, 0);
            pnLeft.Name = "pnLeft";
            pnLeft.Size = new Size(58, 721);
            pnLeft.TabIndex = 4;
            // 
            // panel7
            // 
            panel7.Controls.Add(btnMenu);
            panel7.Controls.Add(btnTakeAway);
            panel7.Controls.Add(btnHome);
            panel7.Controls.Add(btnBill);
            panel7.Controls.Add(btnRevenua);
            panel7.Dock = DockStyle.Top;
            panel7.Location = new Point(0, 83);
            panel7.Margin = new Padding(2);
            panel7.Name = "panel7";
            panel7.Size = new Size(58, 253);
            panel7.TabIndex = 6;
            // 
            // btnMenu
            // 
            btnMenu.BackColor = Color.Transparent;
            btnMenu.Cursor = Cursors.Hand;
            btnMenu.Dock = DockStyle.Bottom;
            btnMenu.FlatStyle = FlatStyle.Popup;
            btnMenu.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnMenu.ForeColor = Color.White;
            btnMenu.Image = Resources.fHome_icon_menuFoods;
            btnMenu.ImageAlign = ContentAlignment.MiddleLeft;
            btnMenu.Location = new Point(0, 100);
            btnMenu.Margin = new Padding(0);
            btnMenu.Name = "btnMenu";
            btnMenu.Padding = new Padding(5, 0, 0, 0);
            btnMenu.Size = new Size(58, 51);
            btnMenu.TabIndex = 3;
            btnMenu.Text = "                        Thực đơn";
            btnMenu.TextAlign = ContentAlignment.MiddleLeft;
            btnMenu.UseVisualStyleBackColor = false;
            btnMenu.Click += btnHome_Click;
            // 
            // btnTakeAway
            // 
            btnTakeAway.BackColor = Color.Transparent;
            btnTakeAway.Dock = DockStyle.Top;
            btnTakeAway.FlatStyle = FlatStyle.Popup;
            btnTakeAway.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnTakeAway.ForeColor = Color.White;
            btnTakeAway.Image = Resources.fHome_icon_delivery1;
            btnTakeAway.ImageAlign = ContentAlignment.MiddleLeft;
            btnTakeAway.Location = new Point(0, 51);
            btnTakeAway.Margin = new Padding(0);
            btnTakeAway.Name = "btnTakeAway";
            btnTakeAway.Padding = new Padding(5, 0, 0, 0);
            btnTakeAway.Size = new Size(58, 51);
            btnTakeAway.TabIndex = 2;
            btnTakeAway.Text = "          Mang đi";
            btnTakeAway.TextAlign = ContentAlignment.MiddleLeft;
            btnTakeAway.UseVisualStyleBackColor = false;
            btnTakeAway.Click += btnHome_Click;
            // 
            // btnHome
            // 
            btnHome.BackColor = Color.Transparent;
            btnHome.Cursor = Cursors.Hand;
            btnHome.Dock = DockStyle.Top;
            btnHome.FlatStyle = FlatStyle.Popup;
            btnHome.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnHome.ForeColor = Color.White;
            btnHome.Image = Resources.fHome_icon_table;
            btnHome.ImageAlign = ContentAlignment.MiddleLeft;
            btnHome.Location = new Point(0, 0);
            btnHome.Margin = new Padding(0);
            btnHome.Name = "btnHome";
            btnHome.Padding = new Padding(5, 0, 0, 0);
            btnHome.Size = new Size(58, 51);
            btnHome.TabIndex = 2;
            btnHome.Text = "                        Tại quán";
            btnHome.TextAlign = ContentAlignment.MiddleLeft;
            btnHome.UseVisualStyleBackColor = false;
            btnHome.Click += btnHome_Click;
            // 
            // btnBill
            // 
            btnBill.BackColor = Color.Transparent;
            btnBill.Cursor = Cursors.Hand;
            btnBill.Dock = DockStyle.Bottom;
            btnBill.FlatStyle = FlatStyle.Popup;
            btnBill.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnBill.ForeColor = Color.White;
            btnBill.Image = Resources.fHome_icon_bill;
            btnBill.ImageAlign = ContentAlignment.MiddleLeft;
            btnBill.Location = new Point(0, 151);
            btnBill.Margin = new Padding(0);
            btnBill.Name = "btnBill";
            btnBill.Padding = new Padding(5, 0, 0, 0);
            btnBill.Size = new Size(58, 51);
            btnBill.TabIndex = 4;
            btnBill.Text = "                              Hóa đơn";
            btnBill.TextAlign = ContentAlignment.MiddleLeft;
            btnBill.UseVisualStyleBackColor = false;
            btnBill.Click += btnHome_Click;
            // 
            // btnRevenua
            // 
            btnRevenua.BackColor = Color.Transparent;
            btnRevenua.Cursor = Cursors.Hand;
            btnRevenua.Dock = DockStyle.Bottom;
            btnRevenua.FlatStyle = FlatStyle.Popup;
            btnRevenua.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnRevenua.ForeColor = Color.White;
            btnRevenua.Image = Resources.fHome_icon_employee;
            btnRevenua.ImageAlign = ContentAlignment.MiddleLeft;
            btnRevenua.Location = new Point(0, 202);
            btnRevenua.Margin = new Padding(0);
            btnRevenua.Name = "btnRevenua";
            btnRevenua.Padding = new Padding(5, 0, 0, 0);
            btnRevenua.Size = new Size(58, 51);
            btnRevenua.TabIndex = 5;
            btnRevenua.Text = "                        Nhân sự";
            btnRevenua.TextAlign = ContentAlignment.MiddleLeft;
            btnRevenua.UseVisualStyleBackColor = false;
            btnRevenua.Click += btnHome_Click;
            // 
            // panel4
            // 
            panel4.BorderStyle = BorderStyle.FixedSingle;
            panel4.Controls.Add(lbAccountName);
            panel4.Controls.Add(ptbMenu);
            panel4.Dock = DockStyle.Top;
            panel4.Location = new Point(0, 0);
            panel4.Margin = new Padding(2);
            panel4.Name = "panel4";
            panel4.Size = new Size(58, 83);
            panel4.TabIndex = 5;
            // 
            // lbAccountName
            // 
            lbAccountName.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            lbAccountName.ForeColor = SystemColors.ButtonHighlight;
            lbAccountName.Location = new Point(62, 6);
            lbAccountName.Margin = new Padding(4, 0, 4, 0);
            lbAccountName.Name = "lbAccountName";
            lbAccountName.Size = new Size(108, 75);
            lbAccountName.TabIndex = 6;
            lbAccountName.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // ptbMenu
            // 
            ptbMenu.Cursor = Cursors.Hand;
            ptbMenu.ErrorImage = null;
            ptbMenu.Image = Resources.fHome_icon_option;
            ptbMenu.Location = new Point(7, 23);
            ptbMenu.Margin = new Padding(4, 3, 4, 3);
            ptbMenu.Name = "ptbMenu";
            ptbMenu.Padding = new Padding(5, 0, 0, 0);
            ptbMenu.Size = new Size(37, 32);
            ptbMenu.SizeMode = PictureBoxSizeMode.AutoSize;
            ptbMenu.TabIndex = 6;
            ptbMenu.TabStop = false;
            ptbMenu.Click += ptbMenu_Click;
            // 
            // btnSetting
            // 
            btnSetting.BackColor = Color.Transparent;
            btnSetting.Cursor = Cursors.Hand;
            btnSetting.Dock = DockStyle.Bottom;
            btnSetting.FlatStyle = FlatStyle.Popup;
            btnSetting.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnSetting.ForeColor = Color.White;
            btnSetting.Image = Resources.fHome_icon_settings;
            btnSetting.ImageAlign = ContentAlignment.MiddleLeft;
            btnSetting.Location = new Point(0, 664);
            btnSetting.Margin = new Padding(0);
            btnSetting.Name = "btnSetting";
            btnSetting.Padding = new Padding(9, 0, 0, 0);
            btnSetting.Size = new Size(58, 57);
            btnSetting.TabIndex = 6;
            btnSetting.Text = "                           Cài đặt";
            btnSetting.TextAlign = ContentAlignment.MiddleLeft;
            btnSetting.UseVisualStyleBackColor = false;
            btnSetting.Click += btnHome_Click;
            // 
            // pnBody
            // 
            pnBody.BackgroundImage = Resources.bg;
            pnBody.BackgroundImageLayout = ImageLayout.Stretch;
            pnBody.Dock = DockStyle.Fill;
            pnBody.Location = new Point(58, 0);
            pnBody.Margin = new Padding(2);
            pnBody.Name = "pnBody";
            pnBody.Size = new Size(1279, 721);
            pnBody.TabIndex = 8;
            // 
            // frmHome
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1337, 721);
            Controls.Add(pnBody);
            Controls.Add(pnLeft);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            IsMdiContainer = true;
            Margin = new Padding(4, 3, 4, 3);
            Name = "frmHome";
            StartPosition = FormStartPosition.WindowsDefaultBounds;
            Text = "Quản Lý Quán Cà Phê";
            FormClosing += fTableManager_FormClosing;
            Load += fTableManager_Load;
            pnLeft.ResumeLayout(false);
            panel7.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ptbMenu).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnLeft;
        private Panel panel4;
        private Panel panel7;
        private Panel pnBody;
        private Label lbAccountName;
        private PictureBox ptbMenu;
        private Button btnHome;
        private Button btnMenu;
        private Button btnSetting;
        private Button btnRevenua;
        private Button btnBill;
        private Button btnTakeAway;
    }
}