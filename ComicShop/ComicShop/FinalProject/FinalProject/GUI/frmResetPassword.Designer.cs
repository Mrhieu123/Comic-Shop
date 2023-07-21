namespace ComicManagement.GUI
{
    partial class frmResetPassword
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
            label3 = new Label();
            btnSend = new Button();
            txtCapcha = new TextBox();
            label4 = new Label();
            txtEmail = new TextBox();
            label6 = new Label();
            btnCheck = new Button();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(250, 12);
            label3.Name = "label3";
            label3.Size = new Size(250, 46);
            label3.TabIndex = 2;
            label3.Text = "Reset Password";
            // 
            // btnSend
            // 
            btnSend.BackColor = Color.LightSteelBlue;
            btnSend.Location = new Point(517, 170);
            btnSend.Name = "btnSend";
            btnSend.Size = new Size(102, 32);
            btnSend.TabIndex = 34;
            btnSend.Text = "Send";
            btnSend.UseVisualStyleBackColor = false;
            btnSend.Click += btnSend_Click_1;
            // 
            // txtCapcha
            // 
            txtCapcha.Location = new Point(239, 173);
            txtCapcha.Name = "txtCapcha";
            txtCapcha.Size = new Size(237, 27);
            txtCapcha.TabIndex = 33;
            // 
            // label4
            // 
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(152, 176);
            label4.Name = "label4";
            label4.Size = new Size(104, 21);
            label4.TabIndex = 32;
            label4.Text = "Capcha";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(239, 113);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(237, 27);
            txtEmail.TabIndex = 36;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(154, 115);
            label6.Name = "label6";
            label6.Size = new Size(46, 20);
            label6.TabIndex = 35;
            label6.Text = "Email";
            // 
            // btnCheck
            // 
            btnCheck.Location = new Point(277, 239);
            btnCheck.Margin = new Padding(3, 4, 3, 4);
            btnCheck.Name = "btnCheck";
            btnCheck.Size = new Size(86, 31);
            btnCheck.TabIndex = 37;
            btnCheck.Text = "Check";
            btnCheck.UseVisualStyleBackColor = true;
            btnCheck.Click += btnCheck_Click;
            // 
            // frmResetPassword
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(729, 341);
            Controls.Add(btnCheck);
            Controls.Add(txtEmail);
            Controls.Add(label6);
            Controls.Add(btnSend);
            Controls.Add(txtCapcha);
            Controls.Add(label4);
            Controls.Add(label3);
            Margin = new Padding(3, 4, 3, 4);
            Name = "frmResetPassword";
            Text = "frmResetPassword";
            Load += frmResetPassword_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label3;
        private Button btnSend;
        private TextBox txtCapcha;
        private Label label4;
        private TextBox txtEmail;
        private Label label6;
        private Button btnCheck;
    }
}