namespace ComicManagement.GUI
{
    partial class frmLogin
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
            pnLogin = new Panel();
            lbResetPassword = new LinkLabel();
            label1 = new Label();
            lbExit = new Label();
            btnLogin = new Button();
            tbPassword = new TextBox();
            tbUsername = new TextBox();
            lbPassword = new Label();
            lbUserName = new Label();
            lbRegister = new Label();
            pnLogin.SuspendLayout();
            SuspendLayout();
            // 
            // pnLogin
            // 
            pnLogin.BackColor = SystemColors.ButtonFace;
            pnLogin.Controls.Add(lbResetPassword);
            pnLogin.Controls.Add(label1);
            pnLogin.Controls.Add(lbExit);
            pnLogin.Controls.Add(btnLogin);
            pnLogin.Controls.Add(tbPassword);
            pnLogin.Controls.Add(tbUsername);
            pnLogin.Controls.Add(lbPassword);
            pnLogin.Controls.Add(lbUserName);
            pnLogin.Controls.Add(lbRegister);
            pnLogin.Dock = DockStyle.Fill;
            pnLogin.Location = new Point(0, 0);
            pnLogin.Name = "pnLogin";
            pnLogin.Size = new Size(446, 215);
            pnLogin.TabIndex = 1;
            pnLogin.Paint += pnLogin_Paint;
            // 
            // lbResetPassword
            // 
            lbResetPassword.AutoSize = true;
            lbResetPassword.Location = new Point(149, 152);
            lbResetPassword.Name = "lbResetPassword";
            lbResetPassword.Size = new Size(118, 20);
            lbResetPassword.TabIndex = 11;
            lbResetPassword.TabStop = true;
            lbResetPassword.Text = "Forgot Password";
            lbResetPassword.LinkClicked += lbResetPassword_LinkClicked;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Light", 9F, FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(61, 186);
            label1.Name = "label1";
            label1.Size = new Size(180, 20);
            label1.TabIndex = 10;
            label1.Text = "Do you want to join SHOP ?";
            // 
            // lbExit
            // 
            lbExit.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbExit.ForeColor = SystemColors.ActiveCaptionText;
            lbExit.Location = new Point(416, 0);
            lbExit.Name = "lbExit";
            lbExit.Size = new Size(27, 32);
            lbExit.TabIndex = 9;
            lbExit.Text = "X";
            lbExit.Click += lbExit_Click;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.LightSteelBlue;
            btnLogin.Location = new Point(116, 108);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(182, 32);
            btnLogin.TabIndex = 7;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // tbPassword
            // 
            tbPassword.Location = new Point(165, 58);
            tbPassword.Name = "tbPassword";
            tbPassword.PasswordChar = '*';
            tbPassword.Size = new Size(182, 27);
            tbPassword.TabIndex = 6;
            // 
            // tbUsername
            // 
            tbUsername.Location = new Point(165, 22);
            tbUsername.Name = "tbUsername";
            tbUsername.Size = new Size(182, 27);
            tbUsername.TabIndex = 5;
            // 
            // lbPassword
            // 
            lbPassword.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbPassword.ForeColor = Color.Black;
            lbPassword.Location = new Point(29, 57);
            lbPassword.Name = "lbPassword";
            lbPassword.Size = new Size(107, 24);
            lbPassword.TabIndex = 4;
            lbPassword.Text = "Password";
            // 
            // lbUserName
            // 
            lbUserName.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbUserName.ForeColor = Color.Black;
            lbUserName.Location = new Point(29, 22);
            lbUserName.Name = "lbUserName";
            lbUserName.Size = new Size(66, 25);
            lbUserName.TabIndex = 3;
            lbUserName.Text = "Name";
            // 
            // lbRegister
            // 
            lbRegister.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Underline, GraphicsUnit.Point);
            lbRegister.ForeColor = Color.DimGray;
            lbRegister.Location = new Point(261, 182);
            lbRegister.Name = "lbRegister";
            lbRegister.Size = new Size(86, 24);
            lbRegister.TabIndex = 1;
            lbRegister.Text = "Register";
            lbRegister.Click += lbRegister_Click;
            // 
            // frmLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightBlue;
            ClientSize = new Size(446, 215);
            Controls.Add(pnLogin);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LoginGUI";
            pnLogin.ResumeLayout(false);
            pnLogin.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel pnLogin;
        private Label lbExit;
        private Button btnLogin;
        private TextBox tbPassword;
        private TextBox tbUsername;
        private Label lbPassword;
        private Label lbUserName;
        private Label lbRegister;
        private Label label1;
        private LinkLabel lbResetPassword;
    }
}