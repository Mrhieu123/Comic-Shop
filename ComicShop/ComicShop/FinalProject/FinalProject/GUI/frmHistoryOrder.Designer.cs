namespace ComicManagement.GUI
{
    partial class frmHistoryOrder
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
            dgvHistoryOrder = new DataGridView();
            btnExit = new Button();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvHistoryOrder).BeginInit();
            SuspendLayout();
            // 
            // dgvHistoryOrder
            // 
            dgvHistoryOrder.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvHistoryOrder.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvHistoryOrder.Location = new Point(93, 96);
            dgvHistoryOrder.Name = "dgvHistoryOrder";
            dgvHistoryOrder.RowHeadersWidth = 51;
            dgvHistoryOrder.RowTemplate.Height = 29;
            dgvHistoryOrder.Size = new Size(994, 308);
            dgvHistoryOrder.TabIndex = 14;
            dgvHistoryOrder.CellContentClick += dgvOrderDetail_CellContentClick;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(574, 429);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(130, 32);
            btnExit.TabIndex = 16;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Unicode MS", 16.2F, FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(490, 24);
            label1.Name = "label1";
            label1.Size = new Size(268, 38);
            label1.TabIndex = 17;
            label1.Text = "Orders Successfully";
            // 
            // frmHistoryOrder
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1181, 488);
            Controls.Add(label1);
            Controls.Add(btnExit);
            Controls.Add(dgvHistoryOrder);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmHistoryOrder";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmHistoryOrder";
            Load += frmHistoryOrder_Load;
            ((System.ComponentModel.ISupportInitialize)dgvHistoryOrder).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvHistoryOrder;
        private Button btnExit;
        private Label label1;
    }
}