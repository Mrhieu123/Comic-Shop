namespace ComicManagement.GUI
{
    partial class frmInputNewPass
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
            txtPassword = new TextBox();
            label1 = new Label();
            label2 = new Label();
            txtRepassword = new TextBox();
            btnSave = new Button();
            SuspendLayout();
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(265, 99);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(254, 27);
            txtPassword.TabIndex = 26;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(120, 106);
            label1.Name = "label1";
            label1.Size = new Size(106, 20);
            label1.TabIndex = 27;
            label1.Text = "New password";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(131, 175);
            label2.Name = "label2";
            label2.Size = new Size(95, 20);
            label2.TabIndex = 28;
            label2.Text = "Re-password";
            // 
            // txtRepassword
            // 
            txtRepassword.Location = new Point(265, 168);
            txtRepassword.Name = "txtRepassword";
            txtRepassword.Size = new Size(254, 27);
            txtRepassword.TabIndex = 29;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(317, 238);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(94, 29);
            btnSave.TabIndex = 30;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            // 
            // frmInputNewPass
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(711, 370);
            Controls.Add(btnSave);
            Controls.Add(txtRepassword);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtPassword);
            Name = "frmInputNewPass";
            Text = "frmInputNewPass";
            Load += frmInputNewPass_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtPassword;
        private Label label1;
        private Label label2;
        private TextBox txtRepassword;
        private Button btnSave;
    }
}