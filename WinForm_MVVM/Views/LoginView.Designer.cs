namespace WinForm_MVVM.Views
{
    partial class LoginView
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
            label2 = new Label();
            txtUserId = new TextBox();
            label1 = new Label();
            txtPassword = new TextBox();
            btnLogin = new Button();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(286, 124);
            label2.Name = "label2";
            label2.Size = new Size(71, 21);
            label2.TabIndex = 6;
            label2.Text = "ユーザーID";
            // 
            // txtUserId
            // 
            txtUserId.Location = new Point(286, 148);
            txtUserId.Name = "txtUserId";
            txtUserId.Size = new Size(231, 29);
            txtUserId.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(286, 218);
            label1.Name = "label1";
            label1.Size = new Size(68, 21);
            label1.TabIndex = 8;
            label1.Text = "パスワード";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(286, 242);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(231, 29);
            txtPassword.TabIndex = 7;
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(286, 315);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(231, 34);
            btnLogin.TabIndex = 9;
            btnLogin.Text = "ログイン";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // LoginView
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnLogin);
            Controls.Add(label1);
            Controls.Add(txtPassword);
            Controls.Add(label2);
            Controls.Add(txtUserId);
            Name = "LoginView";
            Text = "LoginView";
            Load += LoginView_Load;
            Controls.SetChildIndex(lblTitle, 0);
            Controls.SetChildIndex(txtUserId, 0);
            Controls.SetChildIndex(label2, 0);
            Controls.SetChildIndex(txtPassword, 0);
            Controls.SetChildIndex(label1, 0);
            Controls.SetChildIndex(btnLogin, 0);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private TextBox txtUserId;
        private Label label1;
        private TextBox txtPassword;
        private Button btnLogin;
    }
}