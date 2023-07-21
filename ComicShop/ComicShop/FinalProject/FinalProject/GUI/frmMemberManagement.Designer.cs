namespace ComicManagement.GUI
{
    partial class frmMemberManagement
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
            txtId = new TextBox();
            txtFName = new TextBox();
            txtLName = new TextBox();
            txtPhone = new TextBox();
            txtEmail = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            txtAddress = new TextBox();
            dgvUsers = new DataGridView();
            btnLock = new Button();
            label7 = new Label();
            label8 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvUsers).BeginInit();
            SuspendLayout();
            // 
            // txtId
            // 
            txtId.Location = new Point(135, 28);
            txtId.Name = "txtId";
            txtId.Size = new Size(231, 27);
            txtId.TabIndex = 0;
            // 
            // txtFName
            // 
            txtFName.Location = new Point(135, 90);
            txtFName.Name = "txtFName";
            txtFName.Size = new Size(231, 27);
            txtFName.TabIndex = 1;
            // 
            // txtLName
            // 
            txtLName.Location = new Point(135, 163);
            txtLName.Name = "txtLName";
            txtLName.Size = new Size(231, 27);
            txtLName.TabIndex = 2;
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(1049, 31);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(231, 27);
            txtPhone.TabIndex = 3;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(1049, 96);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(231, 27);
            txtEmail.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(27, 30);
            label1.Name = "label1";
            label1.Size = new Size(28, 25);
            label1.TabIndex = 5;
            label1.Text = "Id";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(27, 92);
            label2.Name = "label2";
            label2.Size = new Size(92, 25);
            label2.TabIndex = 6;
            label2.Text = "FisrtName";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(27, 165);
            label3.Name = "label3";
            label3.Size = new Size(90, 25);
            label3.TabIndex = 7;
            label3.Text = "LastName";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(947, 33);
            label4.Name = "label4";
            label4.Size = new Size(62, 25);
            label4.TabIndex = 8;
            label4.Text = "Phone";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(947, 98);
            label5.Name = "label5";
            label5.Size = new Size(54, 25);
            label5.TabIndex = 9;
            label5.Text = "Email";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(947, 168);
            label6.Name = "label6";
            label6.Size = new Size(77, 25);
            label6.TabIndex = 10;
            label6.Text = "Address";
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(1049, 166);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(231, 27);
            txtAddress.TabIndex = 11;
            // 
            // dgvUsers
            // 
            dgvUsers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvUsers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUsers.Location = new Point(97, 213);
            dgvUsers.Name = "dgvUsers";
            dgvUsers.RowHeadersWidth = 51;
            dgvUsers.RowTemplate.Height = 29;
            dgvUsers.Size = new Size(1137, 340);
            dgvUsers.TabIndex = 12;
            dgvUsers.CellContentClick += dgvUsers_CellContentClick;
            // 
            // btnLock
            // 
            btnLock.Location = new Point(623, 574);
            btnLock.Name = "btnLock";
            btnLock.Size = new Size(126, 46);
            btnLock.TabIndex = 13;
            btnLock.Text = "Lock User";
            btnLock.UseVisualStyleBackColor = true;
            btnLock.Click += btnLock_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(1302, 9);
            label7.Name = "label7";
            label7.Size = new Size(18, 20);
            label7.TabIndex = 14;
            label7.Text = "X";
            label7.Click += label7_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Arial Unicode MS", 16.2F, FontStyle.Italic, GraphicsUnit.Point);
            label8.Location = new Point(515, 9);
            label8.Name = "label8";
            label8.Size = new Size(308, 38);
            label8.TabIndex = 15;
            label8.Text = "Members Management";
            // 
            // frmMemberManagement
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1332, 632);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(btnLock);
            Controls.Add(dgvUsers);
            Controls.Add(txtAddress);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtEmail);
            Controls.Add(txtPhone);
            Controls.Add(txtLName);
            Controls.Add(txtFName);
            Controls.Add(txtId);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmMemberManagement";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmMemberManagement";
            Load += frmMemberManagement_Load;
            ((System.ComponentModel.ISupportInitialize)dgvUsers).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtId;
        private TextBox txtFName;
        private TextBox txtLName;
        private TextBox txtPhone;
        private TextBox txtEmail;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox txtAddress;
        private DataGridView dgvUsers;
        private Button btnLock;
        private Label label7;
        private Label label8;
    }
}