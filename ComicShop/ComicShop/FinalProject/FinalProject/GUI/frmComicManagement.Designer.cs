namespace ComicManagement.GUI
{
    partial class frmComicManagement
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            panel1 = new Panel();
            gbBookManagement = new GroupBox();
            btnRefresh = new Button();
            btnChooseFile = new Button();
            cbCategory = new ComboBox();
            btnDelete = new Button();
            btnEdit = new Button();
            btnAdd = new Button();
            nmPrice = new NumericUpDown();
            tbAuthor = new TextBox();
            tbImage = new TextBox();
            tbBookID = new TextBox();
            lbCategory = new Label();
            tbTitle = new TextBox();
            lbPrice = new Label();
            lbAuthor = new Label();
            lbBookID = new Label();
            lbTitle = new Label();
            dgvBookManagement = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            label1 = new Label();
            panel1.SuspendLayout();
            gbBookManagement.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nmPrice).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvBookManagement).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(gbBookManagement);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1350, 170);
            panel1.TabIndex = 0;
            // 
            // gbBookManagement
            // 
            gbBookManagement.BackColor = Color.GhostWhite;
            gbBookManagement.Controls.Add(label1);
            gbBookManagement.Controls.Add(btnRefresh);
            gbBookManagement.Controls.Add(btnChooseFile);
            gbBookManagement.Controls.Add(cbCategory);
            gbBookManagement.Controls.Add(btnDelete);
            gbBookManagement.Controls.Add(btnEdit);
            gbBookManagement.Controls.Add(btnAdd);
            gbBookManagement.Controls.Add(nmPrice);
            gbBookManagement.Controls.Add(tbAuthor);
            gbBookManagement.Controls.Add(tbImage);
            gbBookManagement.Controls.Add(tbBookID);
            gbBookManagement.Controls.Add(lbCategory);
            gbBookManagement.Controls.Add(tbTitle);
            gbBookManagement.Controls.Add(lbPrice);
            gbBookManagement.Controls.Add(lbAuthor);
            gbBookManagement.Controls.Add(lbBookID);
            gbBookManagement.Controls.Add(lbTitle);
            gbBookManagement.Dock = DockStyle.Top;
            gbBookManagement.Location = new Point(0, 0);
            gbBookManagement.Name = "gbBookManagement";
            gbBookManagement.Size = new Size(1350, 193);
            gbBookManagement.TabIndex = 1;
            gbBookManagement.TabStop = false;
            gbBookManagement.Text = "Book Management";
            gbBookManagement.Enter += gbBookManagement_Enter;
            // 
            // btnRefresh
            // 
            btnRefresh.BackColor = Color.LightSteelBlue;
            btnRefresh.Location = new Point(232, 134);
            btnRefresh.Margin = new Padding(2);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(90, 36);
            btnRefresh.TabIndex = 8;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = false;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // btnChooseFile
            // 
            btnChooseFile.BackColor = Color.LightSteelBlue;
            btnChooseFile.Location = new Point(760, 57);
            btnChooseFile.Name = "btnChooseFile";
            btnChooseFile.Size = new Size(90, 27);
            btnChooseFile.TabIndex = 7;
            btnChooseFile.Text = "Choose File";
            btnChooseFile.UseVisualStyleBackColor = false;
            btnChooseFile.Click += btnChooseFile_Click;
            // 
            // cbCategory
            // 
            cbCategory.FormattingEnabled = true;
            cbCategory.Location = new Point(868, 91);
            cbCategory.Name = "cbCategory";
            cbCategory.Size = new Size(198, 28);
            cbCategory.TabIndex = 6;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.LightSteelBlue;
            btnDelete.Location = new Point(868, 131);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(90, 36);
            btnDelete.TabIndex = 5;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnEdit
            // 
            btnEdit.BackColor = Color.LightSteelBlue;
            btnEdit.Location = new Point(659, 134);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(90, 36);
            btnEdit.TabIndex = 4;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = false;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.LightSteelBlue;
            btnAdd.Location = new Point(445, 134);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(90, 36);
            btnAdd.TabIndex = 3;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // nmPrice
            // 
            nmPrice.Location = new Point(868, 24);
            nmPrice.Name = "nmPrice";
            nmPrice.Size = new Size(198, 27);
            nmPrice.TabIndex = 2;
            // 
            // tbAuthor
            // 
            tbAuthor.Location = new Point(124, 88);
            tbAuthor.Name = "tbAuthor";
            tbAuthor.Size = new Size(198, 27);
            tbAuthor.TabIndex = 1;
            // 
            // tbImage
            // 
            tbImage.Location = new Point(868, 57);
            tbImage.Name = "tbImage";
            tbImage.Size = new Size(198, 27);
            tbImage.TabIndex = 1;
            // 
            // tbBookID
            // 
            tbBookID.Location = new Point(124, 26);
            tbBookID.Name = "tbBookID";
            tbBookID.ReadOnly = true;
            tbBookID.Size = new Size(198, 27);
            tbBookID.TabIndex = 1;
            // 
            // lbCategory
            // 
            lbCategory.AutoSize = true;
            lbCategory.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            lbCategory.Location = new Point(760, 94);
            lbCategory.Name = "lbCategory";
            lbCategory.Size = new Size(84, 25);
            lbCategory.TabIndex = 0;
            lbCategory.Text = "Category";
            // 
            // tbTitle
            // 
            tbTitle.Location = new Point(124, 57);
            tbTitle.Name = "tbTitle";
            tbTitle.Size = new Size(198, 27);
            tbTitle.TabIndex = 1;
            // 
            // lbPrice
            // 
            lbPrice.AutoSize = true;
            lbPrice.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            lbPrice.Location = new Point(760, 26);
            lbPrice.Name = "lbPrice";
            lbPrice.Size = new Size(49, 25);
            lbPrice.TabIndex = 0;
            lbPrice.Text = "Price";
            // 
            // lbAuthor
            // 
            lbAuthor.AutoSize = true;
            lbAuthor.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            lbAuthor.Location = new Point(11, 88);
            lbAuthor.Name = "lbAuthor";
            lbAuthor.Size = new Size(67, 25);
            lbAuthor.TabIndex = 0;
            lbAuthor.Text = "Author";
            // 
            // lbBookID
            // 
            lbBookID.AutoSize = true;
            lbBookID.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            lbBookID.Location = new Point(11, 26);
            lbBookID.Name = "lbBookID";
            lbBookID.Size = new Size(71, 25);
            lbBookID.TabIndex = 0;
            lbBookID.Text = "BookID";
            // 
            // lbTitle
            // 
            lbTitle.AutoSize = true;
            lbTitle.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            lbTitle.Location = new Point(11, 57);
            lbTitle.Name = "lbTitle";
            lbTitle.Size = new Size(44, 25);
            lbTitle.TabIndex = 0;
            lbTitle.Text = "Title";
            // 
            // dgvBookManagement
            // 
            dgvBookManagement.AllowUserToAddRows = false;
            dgvBookManagement.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvBookManagement.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBookManagement.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5, Column6 });
            dgvBookManagement.Dock = DockStyle.Bottom;
            dgvBookManagement.Location = new Point(0, 190);
            dgvBookManagement.Name = "dgvBookManagement";
            dgvBookManagement.RowHeadersWidth = 51;
            dataGridViewCellStyle1.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            dgvBookManagement.RowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvBookManagement.RowTemplate.Height = 29;
            dgvBookManagement.Size = new Size(1350, 489);
            dgvBookManagement.TabIndex = 0;
            dgvBookManagement.CellClick += dgvBookManagement_CellClick;
            dgvBookManagement.CellContentClick += dgvBookManagement_CellContentClick;
            // 
            // Column1
            // 
            Column1.HeaderText = "ID";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            // 
            // Column2
            // 
            Column2.HeaderText = "Category";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            // 
            // Column3
            // 
            Column3.HeaderText = "Title";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            // 
            // Column4
            // 
            Column4.HeaderText = "Price";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            // 
            // Column5
            // 
            Column5.HeaderText = "ProductURL";
            Column5.MinimumWidth = 6;
            Column5.Name = "Column5";
            // 
            // Column6
            // 
            Column6.HeaderText = "Author";
            Column6.MinimumWidth = 6;
            Column6.Name = "Column6";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(1326, 9);
            label1.Name = "label1";
            label1.Size = new Size(18, 20);
            label1.TabIndex = 9;
            label1.Text = "X";
            label1.Click += label1_Click;
            // 
            // frmComicManagement
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightBlue;
            ClientSize = new Size(1350, 679);
            Controls.Add(panel1);
            Controls.Add(dgvBookManagement);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmComicManagement";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CRUDBookGUI";
            panel1.ResumeLayout(false);
            gbBookManagement.ResumeLayout(false);
            gbBookManagement.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nmPrice).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvBookManagement).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private GroupBox gbBookManagement;
        private Button btnChooseFile;
        private ComboBox cbCategory;
        private Button btnDelete;
        private Button btnEdit;
        private Button btnAdd;
        private NumericUpDown nmPrice;
        private TextBox tbAuthor;
        private TextBox tbImage;
        private TextBox tbBookID;
        private Label lbCategory;
        private TextBox tbTitle;
        private Label lbPrice;
        private Label lbAuthor;
        private Label lbBookID;
        private Label lbTitle;
        private DataGridView dgvBookManagement;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private Button btnRefresh;
        private Label label1;
    }
}