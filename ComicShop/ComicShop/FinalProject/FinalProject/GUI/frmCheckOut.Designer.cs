namespace ComicManagement.GUI
{
    partial class frmCheckOut
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
            btnCancel = new Button();
            btnSave = new Button();
            txtTotal = new TextBox();
            txtPhone = new TextBox();
            txtAddress = new TextBox();
            txtFullName = new TextBox();
            lbTotal = new Label();
            lbPhone = new Label();
            lbAddress = new Label();
            lbFullName = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.LightSteelBlue;
            btnCancel.Location = new Point(211, 260);
            btnCancel.Margin = new Padding(3, 4, 3, 4);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(93, 32);
            btnCancel.TabIndex = 23;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.LightSteelBlue;
            btnSave.DialogResult = DialogResult.OK;
            btnSave.Location = new Point(43, 260);
            btnSave.Margin = new Padding(3, 4, 3, 4);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(93, 32);
            btnSave.TabIndex = 22;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // txtTotal
            // 
            txtTotal.BackColor = Color.White;
            txtTotal.Location = new Point(174, 198);
            txtTotal.Margin = new Padding(3, 4, 3, 4);
            txtTotal.Name = "txtTotal";
            txtTotal.ReadOnly = true;
            txtTotal.Size = new Size(143, 27);
            txtTotal.TabIndex = 20;
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(174, 151);
            txtPhone.Margin = new Padding(3, 4, 3, 4);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(143, 27);
            txtPhone.TabIndex = 18;
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(174, 101);
            txtAddress.Margin = new Padding(3, 4, 3, 4);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(143, 27);
            txtAddress.TabIndex = 21;
            // 
            // txtFullName
            // 
            txtFullName.Location = new Point(174, 59);
            txtFullName.Margin = new Padding(3, 4, 3, 4);
            txtFullName.Name = "txtFullName";
            txtFullName.Size = new Size(143, 27);
            txtFullName.TabIndex = 13;
            // 
            // lbTotal
            // 
            lbTotal.AutoSize = true;
            lbTotal.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            lbTotal.Location = new Point(43, 198);
            lbTotal.Name = "lbTotal";
            lbTotal.Size = new Size(49, 25);
            lbTotal.TabIndex = 11;
            lbTotal.Text = "Total";
            lbTotal.Click += lbTotal_Click;
            // 
            // lbPhone
            // 
            lbPhone.AutoSize = true;
            lbPhone.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            lbPhone.Location = new Point(43, 151);
            lbPhone.Name = "lbPhone";
            lbPhone.Size = new Size(62, 25);
            lbPhone.TabIndex = 9;
            lbPhone.Text = "Phone";
            lbPhone.Click += lbPhone_Click;
            // 
            // lbAddress
            // 
            lbAddress.AutoSize = true;
            lbAddress.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            lbAddress.Location = new Point(43, 103);
            lbAddress.Name = "lbAddress";
            lbAddress.Size = new Size(77, 25);
            lbAddress.TabIndex = 5;
            lbAddress.Text = "Address";
            // 
            // lbFullName
            // 
            lbFullName.AutoSize = true;
            lbFullName.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            lbFullName.Location = new Point(43, 58);
            lbFullName.Name = "lbFullName";
            lbFullName.Size = new Size(88, 25);
            lbFullName.TabIndex = 4;
            lbFullName.Text = "Full name";
            lbFullName.Click += lbFName_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Unicode MS", 13.8F, FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(111, 9);
            label1.Name = "label1";
            label1.Size = new Size(124, 31);
            label1.TabIndex = 24;
            label1.Text = "Check Out";
            // 
            // frmCheckOut
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Azure;
            ClientSize = new Size(349, 370);
            ControlBox = false;
            Controls.Add(label1);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(txtTotal);
            Controls.Add(txtPhone);
            Controls.Add(txtAddress);
            Controls.Add(txtFullName);
            Controls.Add(lbTotal);
            Controls.Add(lbPhone);
            Controls.Add(lbAddress);
            Controls.Add(lbFullName);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "frmCheckOut";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CheckOut";
            Load += frmCheckOut_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCancel;
        private Button btnSave;
        private TextBox txtTotal;
        private TextBox txtPhone;
        private TextBox txtAddress;
        private TextBox txtLastName;
        private TextBox txtFullName;
        private Label lbTotal;
        private Label lbPhone;
        private Label lbAddress;
        private Label lbLName;
        private Label lbFullName;
        private Label label1;
    }
}