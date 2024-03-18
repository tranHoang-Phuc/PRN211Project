namespace WinFormsApp1
{
    partial class frmSetting
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
            btnAccount = new Button();
            btnSetting = new Button();
            btnLanguage = new Button();
            btnExit = new Button();
            btLogout = new Button();
            btnClose = new Button();
            lbAcccountName = new Label();
            SuspendLayout();
            // 
            // btnAccount
            // 
            btnAccount.Enabled = false;
            btnAccount.Image = Resources.fSetting_icon_profile_32;
            btnAccount.ImageAlign = ContentAlignment.MiddleLeft;
            btnAccount.Location = new Point(-2, 28);
            btnAccount.Margin = new Padding(0);
            btnAccount.Name = "btnAccount";
            btnAccount.Padding = new Padding(10, 0, 0, 0);
            btnAccount.Size = new Size(205, 40);
            btnAccount.TabIndex = 0;
            btnAccount.Text = "Tài khoản";
            btnAccount.UseVisualStyleBackColor = true;
            btnAccount.Click += btnClose_Click;
            // 
            // btnSetting
            // 
            btnSetting.BackColor = Color.White;
            btnSetting.Enabled = false;
            btnSetting.Image = Resources.fSetting_icon_settting_32;
            btnSetting.ImageAlign = ContentAlignment.MiddleLeft;
            btnSetting.Location = new Point(-2, 73);
            btnSetting.Margin = new Padding(0);
            btnSetting.Name = "btnSetting";
            btnSetting.Padding = new Padding(10, 0, 0, 0);
            btnSetting.Size = new Size(205, 40);
            btnSetting.TabIndex = 2;
            btnSetting.Text = "Cài đặt";
            btnSetting.UseVisualStyleBackColor = false;
            // 
            // btnLanguage
            // 
            btnLanguage.Enabled = false;
            btnLanguage.Image = Resources.fSetting_icon_Language_32;
            btnLanguage.ImageAlign = ContentAlignment.MiddleLeft;
            btnLanguage.Location = new Point(-2, 113);
            btnLanguage.Margin = new Padding(0);
            btnLanguage.Name = "btnLanguage";
            btnLanguage.Padding = new Padding(10, 0, 0, 0);
            btnLanguage.Size = new Size(205, 40);
            btnLanguage.TabIndex = 4;
            btnLanguage.Text = "Ngôn ngữ";
            btnLanguage.UseVisualStyleBackColor = true;
            btnLanguage.Click += btnClose_Click;
            // 
            // btnExit
            // 
            btnExit.Image = Resources.fSetting_icon_Thoat_32;
            btnExit.ImageAlign = ContentAlignment.MiddleLeft;
            btnExit.Location = new Point(-2, 217);
            btnExit.Margin = new Padding(0);
            btnExit.Name = "btnExit";
            btnExit.Padding = new Padding(10, 0, 0, 0);
            btnExit.Size = new Size(205, 40);
            btnExit.TabIndex = 5;
            btnExit.Text = "Thoát";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnClose_Click;
            // 
            // btLogout
            // 
            btLogout.Image = Resources.fSetting_icon_Exit_32;
            btLogout.ImageAlign = ContentAlignment.MiddleLeft;
            btLogout.Location = new Point(-2, 177);
            btLogout.Margin = new Padding(0);
            btLogout.Name = "btLogout";
            btLogout.Padding = new Padding(10, 0, 0, 0);
            btLogout.Size = new Size(205, 40);
            btLogout.TabIndex = 4;
            btLogout.Text = "Đăng xuất";
            btLogout.UseVisualStyleBackColor = true;
            btLogout.Click += btnClose_Click;
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.Black;
            btnClose.ForeColor = SystemColors.ControlLightLight;
            btnClose.Location = new Point(162, -1);
            btnClose.Margin = new Padding(0);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(41, 29);
            btnClose.TabIndex = 6;
            btnClose.Text = "X";
            btnClose.UseVisualStyleBackColor = false;
            // 
            // lbAcccountName
            // 
            lbAcccountName.AutoSize = true;
            lbAcccountName.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbAcccountName.Location = new Point(67, 4);
            lbAcccountName.Name = "lbAcccountName";
            lbAcccountName.Size = new Size(54, 19);
            lbAcccountName.TabIndex = 7;
            lbAcccountName.Text = "label1";
            // 
            // frmSetting
            // 
            AutoScaleDimensions = new SizeF(8F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(202, 258);
            Controls.Add(lbAcccountName);
            Controls.Add(btnClose);
            Controls.Add(btnExit);
            Controls.Add(btLogout);
            Controls.Add(btnLanguage);
            Controls.Add(btnSetting);
            Controls.Add(btnAccount);
            Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "frmSetting";
            StartPosition = FormStartPosition.Manual;
            Text = "fSetting";
            Load += fSetting_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAccount;
        private Button btnSetting;
        private Button btnLanguage;
        private Button btnExit;
        private Button btLogout;
        private Button btnClose;
        private Label lbAcccountName;
    }
}