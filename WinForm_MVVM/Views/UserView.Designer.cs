namespace WinForm_MVVM
{
    partial class UserView
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
            lblTitle = new Label();
            panel1 = new Panel();
            btnClear = new Button();
            btnSearch = new Button();
            label3 = new Label();
            txtUserName = new TextBox();
            label2 = new Label();
            txtUserId = new TextBox();
            panel2 = new Panel();
            panel4 = new Panel();
            dgvUser = new DataGridView();
            UserIdColumn = new DataGridViewTextBoxColumn();
            UserNameColumn = new DataGridViewTextBoxColumn();
            MailAddressColumn = new DataGridViewTextBoxColumn();
            panel1.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvUser).BeginInit();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Yu Gothic UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 128);
            lblTitle.Location = new Point(12, 9);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(138, 32);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "ユーザーマスタ";
            // 
            // panel1
            // 
            panel1.Controls.Add(btnClear);
            panel1.Controls.Add(btnSearch);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(txtUserName);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(txtUserId);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(12, 44);
            panel1.Name = "panel1";
            panel1.Size = new Size(970, 94);
            panel1.TabIndex = 1;
            // 
            // btnClear
            // 
            btnClear.Font = new Font("Yu Gothic UI", 14.25F);
            btnClear.Location = new Point(865, 58);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(94, 33);
            btnClear.TabIndex = 8;
            btnClear.Text = "クリア";
            btnClear.UseVisualStyleBackColor = true;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.PowderBlue;
            btnSearch.Font = new Font("Yu Gothic UI", 14.25F);
            btnSearch.Location = new Point(771, 58);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(94, 33);
            btnSearch.TabIndex = 7;
            btnSearch.Text = "検索";
            btnSearch.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(252, 12);
            label3.Name = "label3";
            label3.Size = new Size(72, 21);
            label3.TabIndex = 6;
            label3.Text = "ユーザー名";
            // 
            // txtUserName
            // 
            txtUserName.Location = new Point(252, 36);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(187, 29);
            txtUserName.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(38, 12);
            label2.Name = "label2";
            label2.Size = new Size(71, 21);
            label2.TabIndex = 4;
            label2.Text = "ユーザーID";
            // 
            // txtUserId
            // 
            txtUserId.Location = new Point(38, 36);
            txtUserId.Name = "txtUserId";
            txtUserId.Size = new Size(175, 29);
            txtUserId.TabIndex = 3;
            // 
            // panel2
            // 
            panel2.Location = new Point(0, 100);
            panel2.Name = "panel2";
            panel2.Size = new Size(860, 94);
            panel2.TabIndex = 2;
            // 
            // panel4
            // 
            panel4.Controls.Add(dgvUser);
            panel4.Location = new Point(12, 147);
            panel4.Name = "panel4";
            panel4.Size = new Size(860, 401);
            panel4.TabIndex = 2;
            // 
            // dgvUser
            // 
            dgvUser.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUser.Columns.AddRange(new DataGridViewColumn[] { UserIdColumn, UserNameColumn, MailAddressColumn });
            dgvUser.Location = new Point(3, 3);
            dgvUser.Name = "dgvUser";
            dgvUser.Size = new Size(967, 395);
            dgvUser.TabIndex = 0;
            // 
            // UserIdColumn
            // 
            UserIdColumn.DataPropertyName = "UserId";
            UserIdColumn.HeaderText = "ユーザーID";
            UserIdColumn.Name = "UserIdColumn";
            UserIdColumn.Width = 150;
            // 
            // UserNameColumn
            // 
            UserNameColumn.DataPropertyName = "UserName";
            UserNameColumn.HeaderText = "ユーザー名";
            UserNameColumn.Name = "UserNameColumn";
            UserNameColumn.Width = 150;
            // 
            // MailAddressColumn
            // 
            MailAddressColumn.DataPropertyName = "MailAddress";
            MailAddressColumn.HeaderText = "メールアドレス";
            MailAddressColumn.Name = "MailAddressColumn";
            MailAddressColumn.Width = 250;
            // 
            // MainView
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(984, 560);
            Controls.Add(panel4);
            Controls.Add(panel1);
            Controls.Add(lblTitle);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "MainView";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "○○システム";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvUser).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Panel panel1;
        private Label label3;
        private TextBox txtUserName;
        private Label label2;
        private TextBox txtUserId;
        private Panel panel2;
        private Panel panel4;
        private Button btnClear;
        private Button btnSearch;
        private DataGridView dgvUser;
        private DataGridViewTextBoxColumn UserIdColumn;
        private DataGridViewTextBoxColumn UserNameColumn;
        private DataGridViewTextBoxColumn MailAddressColumn;
    }
}
