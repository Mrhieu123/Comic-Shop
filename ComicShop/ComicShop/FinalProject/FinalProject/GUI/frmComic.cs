using ComicManagement.Models;
using ComicManagement.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComicManagement.GUI
{
    public partial class frmComic : Form
    {
        PageList<Product> pagelist;
        ComicShopContext context;
        Cart cart;
        #region methods
        public frmComic()
        {
            InitializeComponent();
            context = new ComicShopContext();
            cart = new Cart();
            cbCategory.DataSource = context.Categories.ToList();
            cbCategory.DisplayMember = "Name";
            cbCategory.ValueMember = "id";
            bindPanel(1);
        }
        public void bindPanelSearch(int pageIndex)
        {
            string searchTitle = tbTitle.Text.Trim();
            string searchAuthor = tbAuthor.Text.Trim();
            string searchCategory = cbCategory.Text.Trim();

            IQueryable<Product> pros = context.Products;

            if (!string.IsNullOrEmpty(searchTitle))
            {
                pros = pros.Where(p => p.Title.Contains(searchTitle));
            }

            if (!string.IsNullOrEmpty(searchAuthor))
            {
                pros = pros.Where(p => p.Author.Contains(searchAuthor));
            }

            if (!string.IsNullOrEmpty(searchCategory))
            {
                pros = pros.Where(p => p.CidNavigation.Name.Contains(searchCategory));
            }

            pagelist = PageList<Product>.Create(pros, pageIndex, 3);
            btnPrevious.Enabled = pagelist.HasPreviousPage;
            btnNext.Enabled = pagelist.HasNextPage;

            pbBookShop.Controls.Clear();
            int height = pbBookShop.Height;
            int width = (pbBookShop.Width - 50) / 3;
            int i = 0;
            foreach (Product pro in pagelist)
            {
                GroupBox groupBox = new GroupBox();
                groupBox.Text = pro.Title;
                groupBox.Height = height;
                groupBox.Width = width;
                groupBox.Location = new Point(10 + i * width, 10);

                PictureBox pictureBox = new PictureBox();
                pictureBox.BorderStyle = BorderStyle.None;
                string s = Directory.GetCurrentDirectory();
                try
                {
                    pictureBox.Image = Image.FromFile(Directory.GetParent(s)
                        .Parent.Parent.FullName + "/Images/" + pro.ProductUrl);

                }
                catch
                {
                    pictureBox.Image = null;
                }
                pictureBox.Size = new Size(150, 100);
                pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBox.Location = new Point(60, 80);
                groupBox.Controls.Add(pictureBox);

                Label lblPrice = new Label();
                lblPrice.AutoSize = true;
                lblPrice.Text = $"${pro.Price.ToString()}";
                lblPrice.Location = new Point(100, 230);
                groupBox.Controls.Add(lblPrice);

                Label lblUuthor = new Label();
                lblUuthor.AutoSize = true;
                lblUuthor.Text = $"Author:{pro.Author.ToString()}";
                lblUuthor.Location = new Point(90, 280);
                groupBox.Controls.Add(lblUuthor);

                Button btnAdd = new Button();
                btnAdd.Name = $"btn{pro.Id}";
                btnAdd.Text = "Add to cart";
                btnAdd.BackColor = Color.LightSteelBlue;
                btnAdd.ForeColor = Color.White;
                btnAdd.AutoSize = true;
                btnAdd.Location = new Point(80, 300);
                groupBox.Controls.Add(btnAdd);
                btnAdd.Click += BtnAdd_Click;


                i++;
                pbBookShop.Controls.Add(groupBox);
            }
        }
        void bindPanel(int pageIndex)
        {
            IQueryable<Product> pros = context.Products.Where(t => t.CidNavigation.Name.
            Contains(cbCategory.Text));

            pagelist = PageList<Product>.Create(pros, pageIndex, 3);
            btnPrevious.Enabled = pagelist.HasPreviousPage;
            btnNext.Enabled = pagelist.HasNextPage;

            pbBookShop.Controls.Clear();
            int height = pbBookShop.Height;
            int width = (pbBookShop.Width - 50) / 3;
            int i = 0;
            foreach (Product pro in pagelist)
            {
                GroupBox groupBox = new GroupBox();
                groupBox.Text = pro.Title;
                groupBox.Height = height;
                groupBox.Width = width;
                groupBox.Location = new Point(10 + i * width, 10);

                PictureBox pictureBox = new PictureBox();
                pictureBox.BorderStyle = BorderStyle.None;
                string s = Directory.GetCurrentDirectory();
                try
                {
                    pictureBox.Image = Image.FromFile(Directory.GetParent(s)
                        .Parent.Parent.FullName + "/Images/" + pro.ProductUrl);

                }
                catch
                {
                    pictureBox.Image = null;
                }
                pictureBox.Size = new Size(150, 100);
                pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBox.Location = new Point(60, 80);
                groupBox.Controls.Add(pictureBox);

                Label lblPrice = new Label();
                lblPrice.AutoSize = true;
                lblPrice.Text = $"${pro.Price.ToString()}";
                lblPrice.Location = new Point(100, 230);
                groupBox.Controls.Add(lblPrice);

                Label lblUuthor = new Label();
                lblUuthor.AutoSize = true;
                lblUuthor.Text = $"Author:{pro.Author.ToString()}";
                lblUuthor.Location = new Point(90, 280);
                groupBox.Controls.Add(lblUuthor);

                Button btnAdd = new Button();
                btnAdd.Name = $"btn{pro.Id}";
                btnAdd.Text = "Add to cart";
                btnAdd.BackColor = System.Drawing.Color.LightSteelBlue;
                btnAdd.ForeColor = Color.White;
                btnAdd.AutoSize = true;
                btnAdd.Location = new Point(80, 300);
                groupBox.Controls.Add(btnAdd);
                btnAdd.Click += BtnAdd_Click;


                i++;
                pbBookShop.Controls.Add(groupBox);
            }
        }
        #endregion
        #region events
        private void BtnAdd_Click(object? sender, EventArgs e)
        {
            int proid = int.Parse(((Button)sender).Name.Substring(3));
            MessageBox.Show("Add to cart successfully!");
            Product album = context.Products.Find(proid);
            ShoppingCart shoppingCart = ShoppingCart.GetCart();
            shoppingCart.AddToCart(album);
        }
        private void lbCancel_Click(object sender, EventArgs e)
        {
            this.Close();

        }
        private void btnPrevious_Click(object sender, EventArgs e)
        {
            bindPanel(pagelist.PageIndex - 1);
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            bindPanel(pagelist.PageIndex + 1);
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            bindPanelSearch(1);
        }

        private void cbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            bindPanel(1);
        }
        #endregion

        private void pnBookShop_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pbBookShop_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
