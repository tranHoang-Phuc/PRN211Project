namespace WinFormsApp1
{
    partial class frmAddTable
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            txtAddTableName = new TextBox();
            btnAddTable = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(6, 14);
            label1.Name = "label1";
            label1.Size = new Size(71, 20);
            label1.TabIndex = 0;
            label1.Text = "Tên bàn:";
            // 
            // txtAddTableName
            // 
            txtAddTableName.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtAddTableName.Location = new Point(79, 10);
            txtAddTableName.Name = "txtAddTableName";
            txtAddTableName.Size = new Size(212, 26);
            txtAddTableName.TabIndex = 1;
            // 
            // btnAddTable
            // 
            btnAddTable.BackColor = Color.FromArgb(113, 201, 206);
            btnAddTable.DialogResult = DialogResult.OK;
            btnAddTable.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnAddTable.ForeColor = Color.Transparent;
            btnAddTable.Location = new Point(203, 39);
            btnAddTable.Name = "btnAddTable";
            btnAddTable.Size = new Size(88, 46);
            btnAddTable.TabIndex = 2;
            btnAddTable.Text = "Thêm bàn";
            btnAddTable.UseVisualStyleBackColor = false;
            // 
            // frmAddTable
            // 
            ClientSize = new Size(304, 93);
            Controls.Add(btnAddTable);
            Controls.Add(txtAddTableName);
            Controls.Add(label1);
            Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "frmAddTable";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Thêm bàn";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtAddTableName;
        public Button btnAddTable;
    }
}
