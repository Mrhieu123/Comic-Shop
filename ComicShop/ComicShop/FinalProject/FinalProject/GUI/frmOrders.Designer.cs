namespace ComicManagement.GUI
{
    partial class frmOrders
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
            dgvOrders = new DataGridView();
            btnView = new Button();
            btnDelete = new Button();
            btnExit = new Button();
            label1 = new Label();
            label2 = new Label();
            label5 = new Label();
            label3 = new Label();
            label4 = new Label();
            label6 = new Label();
            txtOrdersId = new TextBox();
            txtUserId = new TextBox();
            txtPhone = new TextBox();
            txtAddress = new TextBox();
            txtFullName = new TextBox();
            txtOrderDate = new DateTimePicker();
            btnUpdate = new Button();
            btnAccept = new Button();
            btnHistory = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvOrders).BeginInit();
            SuspendLayout();
            // 
            // dgvOrders
            // 
            dgvOrders.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvOrders.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvOrders.Location = new Point(157, 231);
            dgvOrders.Name = "dgvOrders";
            dgvOrders.RowHeadersWidth = 51;
            dgvOrders.RowTemplate.Height = 29;
            dgvOrders.Size = new Size(1021, 323);
            dgvOrders.TabIndex = 13;
            dgvOrders.CellContentClick += dgvOrders_CellContentClick;
            // 
            // btnView
            // 
            btnView.Location = new Point(157, 583);
            btnView.Name = "btnView";
            btnView.Size = new Size(94, 29);
            btnView.TabIndex = 14;
            btnView.Text = "View";
            btnView.UseVisualStyleBackColor = true;
            btnView.Click += btnView_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(758, 583);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 29);
            btnDelete.TabIndex = 15;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(1069, 583);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(94, 29);
            btnExit.TabIndex = 16;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(157, 28);
            label1.Name = "label1";
            label1.Size = new Size(79, 25);
            label1.TabIndex = 17;
            label1.Text = "Order Id";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(157, 89);
            label2.Name = "label2";
            label2.Size = new Size(68, 25);
            label2.TabIndex = 18;
            label2.Text = "User Id";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(157, 154);
            label5.Name = "label5";
            label5.Size = new Size(100, 25);
            label5.TabIndex = 19;
            label5.Text = "Order Date";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(820, 160);
            label3.Name = "label3";
            label3.Size = new Size(62, 25);
            label3.TabIndex = 20;
            label3.Text = "Phone";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(820, 96);
            label4.Name = "label4";
            label4.Size = new Size(77, 25);
            label4.TabIndex = 21;
            label4.Text = "Address";
            label4.Click += label4_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(820, 32);
            label6.Name = "label6";
            label6.Size = new Size(91, 25);
            label6.TabIndex = 22;
            label6.Text = "Full Name";
            // 
            // txtOrdersId
            // 
            txtOrdersId.Enabled = false;
            txtOrdersId.Location = new Point(271, 30);
            txtOrdersId.Name = "txtOrdersId";
            txtOrdersId.Size = new Size(238, 27);
            txtOrdersId.TabIndex = 23;
            // 
            // txtUserId
            // 
            txtUserId.Enabled = false;
            txtUserId.Location = new Point(271, 90);
            txtUserId.Name = "txtUserId";
            txtUserId.Size = new Size(238, 27);
            txtUserId.TabIndex = 24;
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(940, 158);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(238, 27);
            txtPhone.TabIndex = 25;
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(940, 94);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(238, 27);
            txtAddress.TabIndex = 26;
            txtAddress.TextChanged += txtAddress_TextChanged;
            // 
            // txtFullName
            // 
            txtFullName.Location = new Point(940, 30);
            txtFullName.Name = "txtFullName";
            txtFullName.Size = new Size(238, 27);
            txtFullName.TabIndex = 27;
            // 
            // txtOrderDate
            // 
            txtOrderDate.Location = new Point(271, 154);
            txtOrderDate.Name = "txtOrderDate";
            txtOrderDate.Size = new Size(238, 27);
            txtOrderDate.TabIndex = 28;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(471, 583);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(94, 29);
            btnUpdate.TabIndex = 29;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnAccept
            // 
            btnAccept.Location = new Point(471, 583);
            btnAccept.Name = "btnAccept";
            btnAccept.Size = new Size(94, 29);
            btnAccept.TabIndex = 30;
            btnAccept.Text = "Accept";
            btnAccept.UseVisualStyleBackColor = true;
            btnAccept.Click += btnAccept_Click;
            // 
            // btnHistory
            // 
            btnHistory.Location = new Point(616, 190);
            btnHistory.Name = "btnHistory";
            btnHistory.Size = new Size(102, 35);
            btnHistory.TabIndex = 31;
            btnHistory.Text = "History ";
            btnHistory.UseVisualStyleBackColor = true;
            btnHistory.Click += btnHistory_Click;
            // 
            // frmOrders
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1332, 632);
            Controls.Add(btnHistory);
            Controls.Add(btnAccept);
            Controls.Add(btnUpdate);
            Controls.Add(txtOrderDate);
            Controls.Add(txtFullName);
            Controls.Add(txtAddress);
            Controls.Add(txtPhone);
            Controls.Add(txtUserId);
            Controls.Add(txtOrdersId);
            Controls.Add(label6);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label5);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnExit);
            Controls.Add(btnDelete);
            Controls.Add(btnView);
            Controls.Add(dgvOrders);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmOrders";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "OrdersDetail";
            Load += frmOrders_Load;
            ((System.ComponentModel.ISupportInitialize)dgvOrders).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvOrders;
        private Button btnView;
        private Button btnDelete;
        private Button btnExit;
        private Label label1;
        private Label label2;
        private Label label5;
        private Label label3;
        private Label label4;
        private Label label6;
        private TextBox txtOrdersId;
        private TextBox txtUserId;
        private TextBox txtPhone;
        private TextBox txtAddress;
        private TextBox txtFullName;
        private DateTimePicker txtOrderDate;
        private Button btnUpdate;
        private Button btnAccept;
        private Button btnHistory;
    }
}