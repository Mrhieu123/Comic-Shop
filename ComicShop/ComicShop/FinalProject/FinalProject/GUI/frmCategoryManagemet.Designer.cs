namespace ComicManagement.GUI
{
    partial class frmCategoryManagemet
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
            lbTitle = new Label();
            lbBookID = new Label();
            txtName = new TextBox();
            txtId = new TextBox();
            btnAdd = new Button();
            btnEdit = new Button();
            btnDelete = new Button();
            btnRefresh = new Button();
            dataGridView = new DataGridView();
            gbBookManagement = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            gbBookManagement.SuspendLayout();
            SuspendLayout();
            // 
            // lbTitle
            // 
            lbTitle.AutoSize = true;
            lbTitle.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            lbTitle.Location = new Point(40, 83);
            lbTitle.Name = "lbTitle";
            lbTitle.Size = new Size(59, 25);
            lbTitle.TabIndex = 0;
            lbTitle.Text = "Name";
            // 
            // lbBookID
            // 
            lbBookID.AutoSize = true;
            lbBookID.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            lbBookID.Location = new Point(40, 45);
            lbBookID.Name = "lbBookID";
            lbBookID.Size = new Size(30, 25);
            lbBookID.TabIndex = 0;
            lbBookID.Text = "ID";
            // 
            // txtName
            // 
            txtName.Location = new Point(124, 81);
            txtName.Name = "txtName";
            txtName.Size = new Size(198, 27);
            txtName.TabIndex = 1;
            // 
            // txtId
            // 
            txtId.Location = new Point(124, 43);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(198, 27);
            txtId.TabIndex = 1;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.LightSteelBlue;
            btnAdd.Location = new Point(147, 134);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(90, 36);
            btnAdd.TabIndex = 3;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnEdit
            // 
            btnEdit.BackColor = Color.LightSteelBlue;
            btnEdit.Location = new Point(256, 134);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(90, 36);
            btnEdit.TabIndex = 4;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = false;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.LightSteelBlue;
            btnDelete.Location = new Point(367, 134);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(90, 36);
            btnDelete.TabIndex = 5;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnRefresh
            // 
            btnRefresh.BackColor = Color.LightSteelBlue;
            btnRefresh.Location = new Point(40, 134);
            btnRefresh.Margin = new Padding(2);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(90, 36);
            btnRefresh.TabIndex = 8;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = false;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // dataGridView
            // 
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Location = new Point(40, 200);
            dataGridView.Name = "dataGridView";
            dataGridView.RowHeadersWidth = 51;
            dataGridView.RowTemplate.Height = 29;
            dataGridView.Size = new Size(417, 265);
            dataGridView.TabIndex = 10;
            dataGridView.CellContentClick += dataGridView_CellContentClick;
            dataGridView.CellClick += DataGridView_CellClick;
            // 
            // gbBookManagement
            // 
            gbBookManagement.BackColor = Color.GhostWhite;
            gbBookManagement.Controls.Add(dataGridView);
            gbBookManagement.Controls.Add(btnRefresh);
            gbBookManagement.Controls.Add(btnDelete);
            gbBookManagement.Controls.Add(btnEdit);
            gbBookManagement.Controls.Add(btnAdd);
            gbBookManagement.Controls.Add(txtId);
            gbBookManagement.Controls.Add(txtName);
            gbBookManagement.Controls.Add(lbBookID);
            gbBookManagement.Controls.Add(lbTitle);
            gbBookManagement.Dock = DockStyle.Top;
            gbBookManagement.Location = new Point(0, 0);
            gbBookManagement.Name = "gbBookManagement";
            gbBookManagement.Size = new Size(500, 497);
            gbBookManagement.TabIndex = 3;
            gbBookManagement.TabStop = false;
            gbBookManagement.Text = "Category Management";
            gbBookManagement.Enter += gbBookManagement_Enter;
            // 
            // frmCategoryManagemet
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(500, 500);
            Controls.Add(gbBookManagement);
            Name = "frmCategoryManagemet";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmCategoryManagemet";
            Load += frmCategoryManagemet_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            gbBookManagement.ResumeLayout(false);
            gbBookManagement.PerformLayout();
            ResumeLayout(false);
        }


        #endregion

        private Label lbTitle;
        private Label lbBookID;
        private TextBox txtName;
        private TextBox txtId;
        private Button btnAdd;
        private Button btnEdit;
        private Button btnDelete;
        private Button btnRefresh;
        private DataGridView dataGridView;
        private GroupBox gbBookManagement;
    }
}