namespace ComicManagement.GUI
{
    partial class frmProfile
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
            label12 = new Label();
            label8 = new Label();
            label9 = new Label();
            label2 = new Label();
            label6 = new Label();
            label7 = new Label();
            txtFirstName = new TextBox();
            txtLastName = new TextBox();
            txtAddress = new TextBox();
            txtPhone = new TextBox();
            txtEmail = new TextBox();
            btnUpdate = new Button();
            SuspendLayout();
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Arial Rounded MT Bold", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            label12.ForeColor = SystemColors.ControlText;
            label12.ImageAlign = ContentAlignment.MiddleRight;
            label12.Location = new Point(12, 9);
            label12.Name = "label12";
            label12.Size = new Size(134, 39);
            label12.TabIndex = 23;
            label12.Text = "Profile ";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(29, 66);
            label8.Name = "label8";
            label8.Size = new Size(76, 20);
            label8.TabIndex = 27;
            label8.Text = "FristName";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(29, 115);
            label9.Name = "label9";
            label9.Size = new Size(75, 20);
            label9.TabIndex = 28;
            label9.Text = "LastName";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(29, 167);
            label2.Name = "label2";
            label2.Size = new Size(62, 20);
            label2.TabIndex = 29;
            label2.Text = "Address";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(394, 115);
            label6.Name = "label6";
            label6.Size = new Size(50, 20);
            label6.TabIndex = 30;
            label6.Text = "Phone";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(394, 70);
            label7.Name = "label7";
            label7.Size = new Size(46, 20);
            label7.TabIndex = 31;
            label7.Text = "Email";
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(133, 63);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(180, 27);
            txtFirstName.TabIndex = 35;
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(133, 112);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(180, 27);
            txtLastName.TabIndex = 36;
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(133, 164);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(180, 27);
            txtAddress.TabIndex = 39;
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(476, 112);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(180, 27);
            txtPhone.TabIndex = 40;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(476, 63);
            txtEmail.Name = "txtEmail";
            txtEmail.ReadOnly = true;
            txtEmail.Size = new Size(180, 27);
            txtEmail.TabIndex = 41;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = SystemColors.ActiveCaption;
            btnUpdate.Location = new Point(325, 232);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(115, 39);
            btnUpdate.TabIndex = 44;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click_1;
            // 
            // frmProfile
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(741, 374);
            Controls.Add(btnUpdate);
            Controls.Add(txtEmail);
            Controls.Add(txtPhone);
            Controls.Add(txtAddress);
            Controls.Add(txtLastName);
            Controls.Add(txtFirstName);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label2);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label12);
            Name = "frmProfile";
            Text = "frmProfile";
            Load += frmProfile_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label12;
        private Label label8;
        private Label label9;
        private Label label2;
        private Label label6;
        private Label label7;
        private TextBox txtFirstName;
        private TextBox txtLastName;
        private TextBox txtAddress;
        private TextBox txtPhone;
        private TextBox txtEmail;
        private Button btnUpdate;
    }
}