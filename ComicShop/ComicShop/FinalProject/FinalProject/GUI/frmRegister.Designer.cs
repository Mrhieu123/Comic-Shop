namespace ComicManagement.GUI
{
    partial class frmRegister
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
            panel2 = new Panel();
            btnSend = new Button();
            txtCapcha = new TextBox();
            label4 = new Label();
            linkLabel1 = new LinkLabel();
            label7 = new Label();
            txtEmail = new TextBox();
            label6 = new Label();
            txtLastName = new TextBox();
            txtFirtName = new TextBox();
            label3 = new Label();
            label1 = new Label();
            tbRePassword = new TextBox();
            tbPassword = new TextBox();
            lbExit = new Label();
            btnRegister = new Button();
            tbUsername = new TextBox();
            label2 = new Label();
            label8 = new Label();
            lbUserName = new Label();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ButtonFace;
            panel2.Controls.Add(btnSend);
            panel2.Controls.Add(txtCapcha);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(linkLabel1);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(txtEmail);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(txtLastName);
            panel2.Controls.Add(txtFirtName);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(tbRePassword);
            panel2.Controls.Add(tbPassword);
            panel2.Controls.Add(lbExit);
            panel2.Controls.Add(btnRegister);
            panel2.Controls.Add(tbUsername);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(lbUserName);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 0);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(673, 417);
            panel2.TabIndex = 3;
            panel2.Paint += panel2_Paint;
            // 
            // btnSend
            // 
            btnSend.BackColor = Color.LightSteelBlue;
            btnSend.Location = new Point(461, 240);
            btnSend.Margin = new Padding(3, 2, 3, 2);
            btnSend.Name = "btnSend";
            btnSend.Size = new Size(102, 32);
            btnSend.TabIndex = 28;
            btnSend.Text = "Send";
            btnSend.UseVisualStyleBackColor = false;
            btnSend.Click += btnSend_Click;
            // 
            // txtCapcha
            // 
            txtCapcha.Location = new Point(180, 243);
            txtCapcha.Margin = new Padding(3, 2, 3, 2);
            txtCapcha.Name = "txtCapcha";
            txtCapcha.Size = new Size(237, 27);
            txtCapcha.TabIndex = 27;
            txtCapcha.TextChanged += txtCapcha_TextChanged;
            // 
            // label4
            // 
            label4.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(119, 243);
            label4.Name = "label4";
            label4.Size = new Size(49, 21);
            label4.TabIndex = 26;
            label4.Text = "OTP";
            label4.Click += label4_Click;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(230, 351);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(178, 20);
            linkLabel1.TabIndex = 25;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Already have an account?";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = SystemColors.Info;
            label7.Font = new Font("Cooper Black", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(195, 9);
            label7.Name = "label7";
            label7.Size = new Size(228, 23);
            label7.TabIndex = 23;
            label7.Text = "Create a new account";
            label7.Click += label7_Click;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(414, 90);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(179, 27);
            txtEmail.TabIndex = 22;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(313, 88);
            label6.Name = "label6";
            label6.Size = new Size(54, 25);
            label6.TabIndex = 20;
            label6.Text = "Email";
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(414, 41);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(179, 27);
            txtLastName.TabIndex = 16;
            // 
            // txtFirtName
            // 
            txtFirtName.Location = new Point(119, 41);
            txtFirtName.Name = "txtFirtName";
            txtFirtName.Size = new Size(179, 27);
            txtFirtName.TabIndex = 15;
            txtFirtName.TextChanged += txtFirtName_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(16, 39);
            label3.Name = "label3";
            label3.Size = new Size(97, 25);
            label3.TabIndex = 14;
            label3.Text = "First Name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(313, 39);
            label1.Name = "label1";
            label1.Size = new Size(95, 25);
            label1.TabIndex = 13;
            label1.Text = "Last Name";
            // 
            // tbRePassword
            // 
            tbRePassword.Location = new Point(119, 188);
            tbRePassword.Margin = new Padding(3, 2, 3, 2);
            tbRePassword.Name = "tbRePassword";
            tbRePassword.PasswordChar = '*';
            tbRePassword.Size = new Size(179, 27);
            tbRePassword.TabIndex = 12;
            // 
            // tbPassword
            // 
            tbPassword.Location = new Point(119, 140);
            tbPassword.Margin = new Padding(3, 2, 3, 2);
            tbPassword.Name = "tbPassword";
            tbPassword.PasswordChar = '*';
            tbPassword.Size = new Size(179, 27);
            tbPassword.TabIndex = 12;
            // 
            // lbExit
            // 
            lbExit.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbExit.ForeColor = SystemColors.ActiveCaptionText;
            lbExit.Location = new Point(643, 0);
            lbExit.Name = "lbExit";
            lbExit.Size = new Size(27, 32);
            lbExit.TabIndex = 9;
            lbExit.Text = "X";
            lbExit.Click += lbExit_Click;
            // 
            // btnRegister
            // 
            btnRegister.BackColor = Color.LightSteelBlue;
            btnRegister.Location = new Point(218, 307);
            btnRegister.Margin = new Padding(3, 2, 3, 2);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(174, 32);
            btnRegister.TabIndex = 7;
            btnRegister.Text = "Register";
            btnRegister.UseVisualStyleBackColor = false;
            btnRegister.Click += btnSave_Click;
            // 
            // tbUsername
            // 
            tbUsername.Location = new Point(119, 89);
            tbUsername.Margin = new Padding(3, 2, 3, 2);
            tbUsername.Name = "tbUsername";
            tbUsername.Size = new Size(179, 27);
            tbUsername.TabIndex = 5;
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(16, 187);
            label2.Name = "label2";
            label2.Size = new Size(104, 21);
            label2.TabIndex = 4;
            label2.Text = "RePassword";
            // 
            // label8
            // 
            label8.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label8.ForeColor = Color.Black;
            label8.Location = new Point(16, 139);
            label8.Name = "label8";
            label8.Size = new Size(81, 27);
            label8.TabIndex = 4;
            label8.Text = "Password";
            // 
            // lbUserName
            // 
            lbUserName.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            lbUserName.ForeColor = Color.Black;
            lbUserName.Location = new Point(16, 88);
            lbUserName.Name = "lbUserName";
            lbUserName.Size = new Size(104, 23);
            lbUserName.TabIndex = 3;
            lbUserName.Text = "User Name";
            // 
            // frmRegister
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightBlue;
            ClientSize = new Size(673, 417);
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "frmRegister";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Register";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel2;
        private TextBox tbPassword;
        private Label lbExit;
        private Button btnRegister;
        private TextBox tbUsername;
        private Label label8;
        private Label lbUserName;
        private TextBox tbRePassword;
        private Label label2;
        private Label label3;
        private Label label1;
        private TextBox txtLastName;
        private TextBox txtFirtName;
        private TextBox txtEmail;
        private Label label6;
        private Label label7;
        private LinkLabel linkLabel1;
        private Button btnSend;
        private TextBox txtCapcha;
        private Label label4;
    }
}