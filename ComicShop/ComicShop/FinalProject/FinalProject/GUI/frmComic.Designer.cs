namespace ComicManagement.GUI
{
    partial class frmComic
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
            pnBookShop = new Panel();
            tbAuthor = new TextBox();
            lbAuthor = new Label();
            lbCategory = new Label();
            lbTitile = new Label();
            btnSearch = new Button();
            cbCategory = new ComboBox();
            tbTitle = new TextBox();
            btnNext = new Button();
            btnPrevious = new Button();
            pbBookShop = new Panel();
            lbCancel = new Label();
            pnBookShop.SuspendLayout();
            SuspendLayout();
            // 
            // pnBookShop
            // 
            pnBookShop.BackColor = SystemColors.ButtonFace;
            pnBookShop.Controls.Add(tbAuthor);
            pnBookShop.Controls.Add(lbAuthor);
            pnBookShop.Controls.Add(lbCategory);
            pnBookShop.Controls.Add(lbTitile);
            pnBookShop.Controls.Add(btnSearch);
            pnBookShop.Controls.Add(cbCategory);
            pnBookShop.Controls.Add(tbTitle);
            pnBookShop.Controls.Add(btnNext);
            pnBookShop.Controls.Add(btnPrevious);
            pnBookShop.Controls.Add(pbBookShop);
            pnBookShop.Controls.Add(lbCancel);
            pnBookShop.Dock = DockStyle.Fill;
            pnBookShop.Location = new Point(0, 0);
            pnBookShop.Name = "pnBookShop";
            pnBookShop.Size = new Size(1350, 679);
            pnBookShop.TabIndex = 5;
            pnBookShop.Paint += pnBookShop_Paint;
            // 
            // tbAuthor
            // 
            tbAuthor.Location = new Point(641, 33);
            tbAuthor.Margin = new Padding(2);
            tbAuthor.Name = "tbAuthor";
            tbAuthor.Size = new Size(151, 27);
            tbAuthor.TabIndex = 21;
            // 
            // lbAuthor
            // 
            lbAuthor.AutoSize = true;
            lbAuthor.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            lbAuthor.Location = new Point(557, 36);
            lbAuthor.Margin = new Padding(2, 0, 2, 0);
            lbAuthor.Name = "lbAuthor";
            lbAuthor.Size = new Size(67, 25);
            lbAuthor.TabIndex = 22;
            lbAuthor.Text = "Author";
            // 
            // lbCategory
            // 
            lbCategory.AutoSize = true;
            lbCategory.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            lbCategory.Location = new Point(256, 74);
            lbCategory.Name = "lbCategory";
            lbCategory.Size = new Size(84, 25);
            lbCategory.TabIndex = 20;
            lbCategory.Text = "Category";
            // 
            // lbTitile
            // 
            lbTitile.AutoSize = true;
            lbTitile.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            lbTitile.Location = new Point(256, 33);
            lbTitile.Name = "lbTitile";
            lbTitile.Size = new Size(44, 25);
            lbTitile.TabIndex = 20;
            lbTitile.Text = "Title";
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.LightSteelBlue;
            btnSearch.Location = new Point(641, 65);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(113, 34);
            btnSearch.TabIndex = 19;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // cbCategory
            // 
            cbCategory.FormattingEnabled = true;
            cbCategory.Location = new Point(362, 68);
            cbCategory.Name = "cbCategory";
            cbCategory.Size = new Size(151, 28);
            cbCategory.TabIndex = 18;
            cbCategory.SelectedIndexChanged += cbCategory_SelectedIndexChanged;
            // 
            // tbTitle
            // 
            tbTitle.Location = new Point(362, 30);
            tbTitle.Name = "tbTitle";
            tbTitle.Size = new Size(151, 27);
            tbTitle.TabIndex = 17;
            // 
            // btnNext
            // 
            btnNext.BackColor = Color.LightSteelBlue;
            btnNext.ForeColor = SystemColors.ButtonHighlight;
            btnNext.Location = new Point(974, 96);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(88, 32);
            btnNext.TabIndex = 16;
            btnNext.Text = "Next";
            btnNext.UseVisualStyleBackColor = false;
            btnNext.Click += btnNext_Click;
            // 
            // btnPrevious
            // 
            btnPrevious.BackColor = Color.LightSteelBlue;
            btnPrevious.ForeColor = SystemColors.ButtonHighlight;
            btnPrevious.Location = new Point(880, 96);
            btnPrevious.Name = "btnPrevious";
            btnPrevious.Size = new Size(88, 32);
            btnPrevious.TabIndex = 16;
            btnPrevious.Text = "Previous";
            btnPrevious.UseVisualStyleBackColor = false;
            btnPrevious.Click += btnPrevious_Click;
            // 
            // pbBookShop
            // 
            pbBookShop.Location = new Point(256, 134);
            pbBookShop.Name = "pbBookShop";
            pbBookShop.Size = new Size(806, 422);
            pbBookShop.TabIndex = 15;
            pbBookShop.Paint += pbBookShop_Paint;
            // 
            // lbCancel
            // 
            lbCancel.AutoSize = true;
            lbCancel.Location = new Point(1320, 9);
            lbCancel.Name = "lbCancel";
            lbCancel.Size = new Size(18, 20);
            lbCancel.TabIndex = 14;
            lbCancel.Text = "X";
            lbCancel.Click += lbCancel_Click;
            // 
            // frmComic
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightBlue;
            ClientSize = new Size(1350, 679);
            Controls.Add(pnBookShop);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmComic";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ShopBookGUI";
            pnBookShop.ResumeLayout(false);
            pnBookShop.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Label lbCategory;
        private Label lbTitile;
        private Button btnSearch;
        private ComboBox cbCategory;
        private TextBox tbTitle;
        private Button btnNext;
        private Button btnPrevious;
        private Panel pbBookShop;
        private Label lbCancel;
        private Label lbAuthor;
        private TextBox tbAuthor;
        private Panel pnBookShop;
    }
}