namespace ComicManagement.GUI
{
    partial class frmCart
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCart));
            lbCart = new Label();
            btnCheckOut = new Button();
            lbCancel = new Label();
            dgvBilling = new DataGridView();
            panel4 = new Panel();
            lbUsername = new Label();
            pictureBox4 = new PictureBox();
            pnBilling = new Panel();
            label5 = new Label();
            tbTotal = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvBilling).BeginInit();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            pnBilling.SuspendLayout();
            SuspendLayout();
            // 
            // lbCart
            // 
            lbCart.Font = new Font("Arial Unicode MS", 22.2F, FontStyle.Italic, GraphicsUnit.Point);
            lbCart.ForeColor = Color.Black;
            lbCart.Location = new Point(631, 26);
            lbCart.Name = "lbCart";
            lbCart.Size = new Size(100, 50);
            lbCart.TabIndex = 1;
            lbCart.Text = "Cart";
            lbCart.Click += lbCart_Click;
            // 
            // btnCheckOut
            // 
            btnCheckOut.BackColor = Color.LightSteelBlue;
            btnCheckOut.Enabled = false;
            btnCheckOut.Location = new Point(986, 495);
            btnCheckOut.Margin = new Padding(3, 2, 3, 2);
            btnCheckOut.Name = "btnCheckOut";
            btnCheckOut.Size = new Size(112, 37);
            btnCheckOut.TabIndex = 7;
            btnCheckOut.Text = "Check Out ";
            btnCheckOut.UseVisualStyleBackColor = false;
            btnCheckOut.Click += btnCheckOut_Click;
            // 
            // lbCancel
            // 
            lbCancel.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbCancel.ForeColor = SystemColors.ActiveCaptionText;
            lbCancel.Location = new Point(1323, 0);
            lbCancel.Name = "lbCancel";
            lbCancel.Size = new Size(27, 32);
            lbCancel.TabIndex = 9;
            lbCancel.Text = "X";
            lbCancel.Click += lbCancel_Click;
            // 
            // dgvBilling
            // 
            dgvBilling.AllowUserToAddRows = false;
            dgvBilling.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvBilling.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBilling.Location = new Point(225, 95);
            dgvBilling.Margin = new Padding(3, 2, 3, 2);
            dgvBilling.Name = "dgvBilling";
            dgvBilling.RowHeadersWidth = 51;
            dgvBilling.RowTemplate.Height = 29;
            dgvBilling.Size = new Size(873, 367);
            dgvBilling.TabIndex = 13;
            dgvBilling.CellClick += dgvBilling_CellClick;
            dgvBilling.CellContentClick += dgvBilling_CellContentClick;
            // 
            // panel4
            // 
            panel4.Controls.Add(lbUsername);
            panel4.Controls.Add(pictureBox4);
            panel4.Location = new Point(21, 26);
            panel4.Margin = new Padding(3, 2, 3, 2);
            panel4.Name = "panel4";
            panel4.Size = new Size(231, 50);
            panel4.TabIndex = 14;
            // 
            // lbUsername
            // 
            lbUsername.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbUsername.ForeColor = Color.Black;
            lbUsername.Location = new Point(59, 12);
            lbUsername.Name = "lbUsername";
            lbUsername.Size = new Size(114, 30);
            lbUsername.TabIndex = 4;
            lbUsername.Text = "UserName";
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(3, 2);
            pictureBox4.Margin = new Padding(3, 2, 3, 2);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(50, 46);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 0;
            pictureBox4.TabStop = false;
            // 
            // pnBilling
            // 
            pnBilling.BackColor = SystemColors.ButtonFace;
            pnBilling.Controls.Add(label5);
            pnBilling.Controls.Add(tbTotal);
            pnBilling.Controls.Add(panel4);
            pnBilling.Controls.Add(dgvBilling);
            pnBilling.Controls.Add(lbCancel);
            pnBilling.Controls.Add(btnCheckOut);
            pnBilling.Controls.Add(lbCart);
            pnBilling.Dock = DockStyle.Fill;
            pnBilling.Location = new Point(0, 0);
            pnBilling.Margin = new Padding(3, 2, 3, 2);
            pnBilling.Name = "pnBilling";
            pnBilling.Size = new Size(1350, 679);
            pnBilling.TabIndex = 3;
            pnBilling.Paint += pnBilling_Paint;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(225, 491);
            label5.Name = "label5";
            label5.Size = new Size(120, 28);
            label5.TabIndex = 16;
            label5.Text = "Total Money";
            // 
            // tbTotal
            // 
            tbTotal.Location = new Point(362, 495);
            tbTotal.Margin = new Padding(3, 4, 3, 4);
            tbTotal.Name = "tbTotal";
            tbTotal.ReadOnly = true;
            tbTotal.Size = new Size(154, 27);
            tbTotal.TabIndex = 15;
            // 
            // frmCart
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightBlue;
            ClientSize = new Size(1350, 679);
            Controls.Add(pnBilling);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "frmCart";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Billing";
            ((System.ComponentModel.ISupportInitialize)dgvBilling).EndInit();
            panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            pnBilling.ResumeLayout(false);
            pnBilling.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label lbCart;
        private Button btnCheckOut;
        private Label lbCancel;
        private DataGridView dgvBilling;
        private Panel panel4;
        private Label lbUsername;
        private PictureBox pictureBox4;
        private Panel pnBilling;
        private TextBox tbTotal;
        private Label label5;
    }
}