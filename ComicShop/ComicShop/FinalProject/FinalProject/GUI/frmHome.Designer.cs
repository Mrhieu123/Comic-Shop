namespace ComicManagement.GUI
{
    partial class frmHome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHome));
            BottomToolStripPanel = new ToolStripPanel();
            TopToolStripPanel = new ToolStripPanel();
            RightToolStripPanel = new ToolStripPanel();
            LeftToolStripPanel = new ToolStripPanel();
            ContentPanel = new ToolStripContentPanel();
            toolStripContainer1 = new ToolStripContainer();
            pnLogout = new Panel();
            lbLogout = new Label();
            pnLogin = new Panel();
            lbLogin = new Label();
            pnExit = new Panel();
            lbExit = new Label();
            pictureBox4 = new PictureBox();
            pnManagement = new Panel();
            lbManagement = new Label();
            pnBook = new Panel();
            lbBooks = new Label();
            panel2 = new Panel();
            lbCart = new Label();
            pnOrderManagement = new Panel();
            lbOrder = new Label();
            pnMemberManagement = new Panel();
            lbMemberManagement = new Label();
            panel1 = new Panel();
            pnProfile = new Panel();
            lbProfile = new Label();
            pnCategory = new Panel();
            lbCategory = new Label();
            label1 = new Label();
            toolStripContainer1.SuspendLayout();
            pnLogout.SuspendLayout();
            pnLogin.SuspendLayout();
            pnExit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            pnManagement.SuspendLayout();
            pnBook.SuspendLayout();
            panel2.SuspendLayout();
            pnOrderManagement.SuspendLayout();
            pnMemberManagement.SuspendLayout();
            panel1.SuspendLayout();
            pnProfile.SuspendLayout();
            pnCategory.SuspendLayout();
            SuspendLayout();
            // 
            // BottomToolStripPanel
            // 
            BottomToolStripPanel.Location = new Point(0, 0);
            BottomToolStripPanel.Name = "BottomToolStripPanel";
            BottomToolStripPanel.Orientation = Orientation.Horizontal;
            BottomToolStripPanel.RowMargin = new Padding(4, 0, 0, 0);
            BottomToolStripPanel.Size = new Size(0, 0);
            // 
            // TopToolStripPanel
            // 
            TopToolStripPanel.Location = new Point(0, 0);
            TopToolStripPanel.Name = "TopToolStripPanel";
            TopToolStripPanel.Orientation = Orientation.Horizontal;
            TopToolStripPanel.RowMargin = new Padding(4, 0, 0, 0);
            TopToolStripPanel.Size = new Size(0, 0);
            // 
            // RightToolStripPanel
            // 
            RightToolStripPanel.Location = new Point(0, 0);
            RightToolStripPanel.Name = "RightToolStripPanel";
            RightToolStripPanel.Orientation = Orientation.Horizontal;
            RightToolStripPanel.RowMargin = new Padding(4, 0, 0, 0);
            RightToolStripPanel.Size = new Size(0, 0);
            // 
            // LeftToolStripPanel
            // 
            LeftToolStripPanel.Location = new Point(0, 0);
            LeftToolStripPanel.Name = "LeftToolStripPanel";
            LeftToolStripPanel.Orientation = Orientation.Horizontal;
            LeftToolStripPanel.RowMargin = new Padding(4, 0, 0, 0);
            LeftToolStripPanel.Size = new Size(0, 0);
            // 
            // ContentPanel
            // 
            ContentPanel.BackColor = Color.LightBlue;
            ContentPanel.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            ContentPanel.Size = new Size(1293, 492);
            // 
            // toolStripContainer1
            // 
            // 
            // toolStripContainer1.ContentPanel
            // 
            toolStripContainer1.ContentPanel.BackColor = Color.DarkGray;
            toolStripContainer1.ContentPanel.BackgroundImage = (Image)resources.GetObject("toolStripContainer1.ContentPanel.BackgroundImage");
            toolStripContainer1.ContentPanel.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            toolStripContainer1.ContentPanel.Size = new Size(950, 883);
            toolStripContainer1.ContentPanel.Load += toolStripContainer1_ContentPanel_Load_2;
            toolStripContainer1.Dock = DockStyle.Fill;
            toolStripContainer1.Location = new Point(350, 0);
            toolStripContainer1.Name = "toolStripContainer1";
            toolStripContainer1.Size = new Size(950, 883);
            toolStripContainer1.TabIndex = 5;
            toolStripContainer1.Text = "toolStripContainer1";
            // 
            // toolStripContainer1.TopToolStripPanel
            // 
            toolStripContainer1.TopToolStripPanel.Click += toolStripContainer1_TopToolStripPanel_Click;
            // 
            // pnLogout
            // 
            pnLogout.BackColor = Color.DarkGray;
            pnLogout.Controls.Add(lbLogout);
            pnLogout.Location = new Point(29, 580);
            pnLogout.Name = "pnLogout";
            pnLogout.Size = new Size(181, 52);
            pnLogout.TabIndex = 8;
            pnLogout.Visible = false;
            pnLogout.Paint += pnLogout_Paint;
            // 
            // lbLogout
            // 
            lbLogout.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            lbLogout.ForeColor = Color.White;
            lbLogout.Location = new Point(9, 13);
            lbLogout.Name = "lbLogout";
            lbLogout.Size = new Size(113, 30);
            lbLogout.TabIndex = 4;
            lbLogout.Text = "Logout";
            lbLogout.Click += lbLogout_Click;
            // 
            // pnLogin
            // 
            pnLogin.BackColor = Color.DarkGray;
            pnLogin.Controls.Add(lbLogin);
            pnLogin.Location = new Point(31, 584);
            pnLogin.Name = "pnLogin";
            pnLogin.Size = new Size(181, 51);
            pnLogin.TabIndex = 7;
            pnLogin.Paint += pnLogin_Paint;
            // 
            // lbLogin
            // 
            lbLogin.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            lbLogin.ForeColor = Color.White;
            lbLogin.Location = new Point(14, 13);
            lbLogin.Name = "lbLogin";
            lbLogin.Size = new Size(96, 30);
            lbLogin.TabIndex = 4;
            lbLogin.Text = "Login";
            lbLogin.Click += lbLogin_Click;
            // 
            // pnExit
            // 
            pnExit.Controls.Add(lbExit);
            pnExit.Controls.Add(pictureBox4);
            pnExit.Location = new Point(0, 645);
            pnExit.Name = "pnExit";
            pnExit.Size = new Size(221, 63);
            pnExit.TabIndex = 10;
            // 
            // lbExit
            // 
            lbExit.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            lbExit.ForeColor = Color.White;
            lbExit.Location = new Point(71, 16);
            lbExit.Name = "lbExit";
            lbExit.Size = new Size(76, 44);
            lbExit.TabIndex = 4;
            lbExit.Text = "Exit";
            lbExit.Click += exitProgram_Click;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(3, 3);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(61, 60);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 0;
            pictureBox4.TabStop = false;
            // 
            // pnManagement
            // 
            pnManagement.Controls.Add(lbManagement);
            pnManagement.Location = new Point(31, 329);
            pnManagement.Name = "pnManagement";
            pnManagement.Size = new Size(292, 56);
            pnManagement.TabIndex = 11;
            pnManagement.Visible = false;
            pnManagement.Paint += pnManagement_Paint;
            // 
            // lbManagement
            // 
            lbManagement.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            lbManagement.ForeColor = Color.White;
            lbManagement.Location = new Point(14, 9);
            lbManagement.Name = "lbManagement";
            lbManagement.Size = new Size(260, 33);
            lbManagement.TabIndex = 4;
            lbManagement.Text = "Product Management";
            lbManagement.Click += lbManagement_Click;
            // 
            // pnBook
            // 
            pnBook.BackColor = Color.DarkGray;
            pnBook.Controls.Add(lbBooks);
            pnBook.Location = new Point(31, 147);
            pnBook.Name = "pnBook";
            pnBook.Size = new Size(179, 52);
            pnBook.TabIndex = 4;
            // 
            // lbBooks
            // 
            lbBooks.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            lbBooks.ForeColor = Color.White;
            lbBooks.Location = new Point(17, 11);
            lbBooks.Name = "lbBooks";
            lbBooks.Size = new Size(96, 40);
            lbBooks.TabIndex = 4;
            lbBooks.Text = "Books";
            lbBooks.Click += lbBooks_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.DarkGray;
            panel2.Controls.Add(lbCart);
            panel2.Location = new Point(31, 205);
            panel2.Name = "panel2";
            panel2.Size = new Size(179, 52);
            panel2.TabIndex = 9;
            // 
            // lbCart
            // 
            lbCart.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            lbCart.ForeColor = Color.White;
            lbCart.Location = new Point(17, 14);
            lbCart.Name = "lbCart";
            lbCart.Size = new Size(88, 33);
            lbCart.TabIndex = 4;
            lbCart.Text = "Cart";
            lbCart.Click += lbCart_Click;
            // 
            // pnOrderManagement
            // 
            pnOrderManagement.BackColor = Color.DarkGray;
            pnOrderManagement.Controls.Add(lbOrder);
            pnOrderManagement.Location = new Point(31, 269);
            pnOrderManagement.Name = "pnOrderManagement";
            pnOrderManagement.Size = new Size(292, 54);
            pnOrderManagement.TabIndex = 12;
            pnOrderManagement.Visible = false;
            pnOrderManagement.Paint += panel3_Paint;
            // 
            // lbOrder
            // 
            lbOrder.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            lbOrder.ForeColor = Color.White;
            lbOrder.Location = new Point(14, 11);
            lbOrder.Name = "lbOrder";
            lbOrder.Size = new Size(239, 32);
            lbOrder.TabIndex = 4;
            lbOrder.Text = "Order Management";
            lbOrder.Click += label1_Click;
            // 
            // pnMemberManagement
            // 
            pnMemberManagement.BackColor = Color.DarkGray;
            pnMemberManagement.Controls.Add(lbMemberManagement);
            pnMemberManagement.Location = new Point(31, 391);
            pnMemberManagement.Name = "pnMemberManagement";
            pnMemberManagement.Size = new Size(295, 54);
            pnMemberManagement.TabIndex = 13;
            pnMemberManagement.Visible = false;
            // 
            // lbMemberManagement
            // 
            lbMemberManagement.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            lbMemberManagement.ForeColor = Color.White;
            lbMemberManagement.Location = new Point(11, 11);
            lbMemberManagement.Name = "lbMemberManagement";
            lbMemberManagement.Size = new Size(281, 32);
            lbMemberManagement.TabIndex = 4;
            lbMemberManagement.Text = "Members Management";
            lbMemberManagement.Click += label1_Click_1;
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkGray;
            panel1.Controls.Add(pnProfile);
            panel1.Controls.Add(pnLogout);
            panel1.Controls.Add(pnCategory);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pnLogin);
            panel1.Controls.Add(pnMemberManagement);
            panel1.Controls.Add(pnManagement);
            panel1.Controls.Add(pnOrderManagement);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(pnBook);
            panel1.Controls.Add(pnExit);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(350, 883);
            panel1.TabIndex = 1;
            panel1.Paint += panel1_Paint;
            // 
            // pnProfile
            // 
            pnProfile.BackColor = Color.DarkGray;
            pnProfile.Controls.Add(lbProfile);
            pnProfile.Location = new Point(31, 89);
            pnProfile.Name = "pnProfile";
            pnProfile.Size = new Size(179, 52);
            pnProfile.TabIndex = 16;
            pnProfile.Visible = false;
            // 
            // lbProfile
            // 
            lbProfile.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            lbProfile.ForeColor = Color.White;
            lbProfile.Location = new Point(17, 11);
            lbProfile.Name = "lbProfile";
            lbProfile.Size = new Size(96, 40);
            lbProfile.TabIndex = 4;
            lbProfile.Text = "Profile";
            lbProfile.Click += lbProfile_Click;
            // 
            // pnCategory
            // 
            pnCategory.BackColor = Color.DarkGray;
            pnCategory.Controls.Add(lbCategory);
            pnCategory.Location = new Point(31, 451);
            pnCategory.Name = "pnCategory";
            pnCategory.Size = new Size(295, 54);
            pnCategory.TabIndex = 15;
            pnCategory.Visible = false;
            pnCategory.Paint += pnCategory_Paint;
            // 
            // lbCategory
            // 
            lbCategory.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            lbCategory.ForeColor = Color.White;
            lbCategory.Location = new Point(11, 11);
            lbCategory.Name = "lbCategory";
            lbCategory.Size = new Size(281, 32);
            lbCategory.TabIndex = 4;
            lbCategory.Text = "Category Management";
            lbCategory.Click += lbCategory_Click;
            // 
            // label1
            // 
            label1.Font = new Font("MingLiU_HKSCS-ExtB", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(71, 9);
            label1.Name = "label1";
            label1.Size = new Size(189, 41);
            label1.TabIndex = 14;
            label1.Text = "Comic Shop";
            label1.Click += label1_Click_2;
            // 
            // frmHome
            // 
            AutoScaleDimensions = new SizeF(12F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Lavender;
            ClientSize = new Size(1300, 883);
            Controls.Add(toolStripContainer1);
            Controls.Add(panel1);
            Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 3, 4, 3);
            Name = "frmHome";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Book";
            WindowState = FormWindowState.Maximized;
            Activated += frmBook_Activated;
            toolStripContainer1.ResumeLayout(false);
            toolStripContainer1.PerformLayout();
            pnLogout.ResumeLayout(false);
            pnLogin.ResumeLayout(false);
            pnExit.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            pnManagement.ResumeLayout(false);
            pnBook.ResumeLayout(false);
            panel2.ResumeLayout(false);
            pnOrderManagement.ResumeLayout(false);
            pnMemberManagement.ResumeLayout(false);
            panel1.ResumeLayout(false);
            pnProfile.ResumeLayout(false);
            pnCategory.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private ToolStripPanel BottomToolStripPanel;
        private ToolStripPanel TopToolStripPanel;
        private ToolStripPanel RightToolStripPanel;
        private ToolStripPanel LeftToolStripPanel;
        private ToolStripContentPanel ContentPanel;
        private ToolStripContainer toolStripContainer1;
        private Panel pnLogout;
        private Label lbLogout;
        private Panel pnLogin;
        private Label lbLogin;
        private Panel pnExit;
        private Label lbExit;
        private PictureBox pictureBox4;
        private Panel pnManagement;
        private Label lbManagement;
        private Panel pnBook;
        private Label lbBooks;
        private Panel panel2;
        private Label lbCart;
        private Panel pnOrderManagement;
        private Label lbOrder;
        private Panel pnMemberManagement;
        private Label lbMemberManagement;
        private Panel panel1;
        private Label label1;
        private Panel pnProfile;
        private Label lbProfile;
        private Panel pnCategory;
        private Label lbCategory;
    }
}