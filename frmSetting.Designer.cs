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
            // btnExit
            // 
            this.btnExit.Image = global::WinFormsApp1.Resources.fSetting_icon_Thoat_32;
            this.btnExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExit.Location = new System.Drawing.Point(-2, 217);
            this.btnExit.Margin = new System.Windows.Forms.Padding(0);
            this.btnExit.Name = "btnExit";
            this.btnExit.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnExit.Size = new System.Drawing.Size(205, 40);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "Thoát";
            this.btnExit.UseVisualStyleBackColor = true;
            // 
            // btLogout
            // 
            this.btLogout.Image = global::WinFormsApp1.Resources.fSetting_icon_Exit_32;
            this.btLogout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btLogout.Location = new System.Drawing.Point(-2, 177);
            this.btLogout.Margin = new System.Windows.Forms.Padding(0);
            this.btLogout.Name = "btLogout";
            this.btLogout.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btLogout.Size = new System.Drawing.Size(205, 40);
            this.btLogout.TabIndex = 4;
            this.btLogout.Text = "Đăng xuất";
            this.btLogout.UseVisualStyleBackColor = true;
            // 
            // btnLanguage
            // 
            this.btnLanguage.Enabled = false;
            this.btnLanguage.Image = global::WinFormsApp1.Resources.fSetting_icon_Language_32;
            this.btnLanguage.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLanguage.Location = new System.Drawing.Point(-2, 113);
            this.btnLanguage.Margin = new System.Windows.Forms.Padding(0);
            this.btnLanguage.Name = "btnLanguage";
            this.btnLanguage.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnLanguage.Size = new System.Drawing.Size(205, 40);
            this.btnLanguage.TabIndex = 4;
            this.btnLanguage.Text = "Ngôn ngữ";
            this.btnLanguage.UseVisualStyleBackColor = true;
            // 
            // btnSetting
            // 
            this.btnSetting.BackColor = System.Drawing.Color.White;
            this.btnSetting.Enabled = false;
            this.btnSetting.Image = global::WinFormsApp1.Resources.fSetting_icon_settting_32;
            this.btnSetting.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSetting.Location = new System.Drawing.Point(-2, 73);
            this.btnSetting.Margin = new System.Windows.Forms.Padding(0);
            this.btnSetting.Name = "btnSetting";
            this.btnSetting.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnSetting.Size = new System.Drawing.Size(205, 40);
            this.btnSetting.TabIndex = 2;
            this.btnSetting.Text = "Cài đặt";
            this.btnSetting.UseVisualStyleBackColor = false;
            // 
            // btnAccount
            // 
            this.btnAccount.Enabled = false;
            this.btnAccount.Image = global::WinFormsApp1.Resources.fSetting_icon_profile_32;
            this.btnAccount.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAccount.Location = new System.Drawing.Point(-2, 28);
            this.btnAccount.Margin = new System.Windows.Forms.Padding(0);
            this.btnAccount.Name = "btnAccount";
            this.btnAccount.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnAccount.Size = new System.Drawing.Size(205, 40);
            this.btnAccount.TabIndex = 0;
            this.btnAccount.Text = "Tài khoản";
            this.btnAccount.UseVisualStyleBackColor = true;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Black;
            this.btnClose.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnClose.Location = new System.Drawing.Point(162, -1);
            this.btnClose.Margin = new System.Windows.Forms.Padding(0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(41, 29);
            this.btnClose.TabIndex = 6;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = false;
            // 
            // lbAcccountName
            // 
            this.lbAcccountName.AutoSize = true;
            this.lbAcccountName.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbAcccountName.Location = new System.Drawing.Point(67, 4);
            this.lbAcccountName.Name = "lbAcccountName";
            this.lbAcccountName.Size = new System.Drawing.Size(65, 24);
            this.lbAcccountName.TabIndex = 7;
            this.lbAcccountName.Text = "label1";
            // 
            // fSetting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(202, 258);
            this.Controls.Add(this.lbAcccountName);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btLogout);
            this.Controls.Add(this.btnLanguage);
            this.Controls.Add(this.btnSetting);
            this.Controls.Add(this.btnAccount);
            this.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "fSetting";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "fSetting";
            this.ResumeLayout(false);
            this.PerformLayout();
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