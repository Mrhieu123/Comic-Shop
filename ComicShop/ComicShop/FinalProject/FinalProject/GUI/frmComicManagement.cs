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
    public partial class frmComicManagement : Form
    {
        ComicShopContext context = new ComicShopContext();
        int id;
        #region methods
        public frmComicManagement()
        {
            InitializeComponent();
            LoadData();
        }

        void LoadData()
        {
            dgvBookManagement.Rows.Clear();
            using (var context = new ComicShopContext())
            {
                List<Product> list = context.Products.ToList();

                foreach (var item in list)
                {
                    Category c = context.Categories.Where(x => x.Id == item.Cid).FirstOrDefault();
                    dgvBookManagement.Rows.Add(item.Id, c.Name, item.Title, item.Price, item.ProductUrl, item.Author);
                }
                List<Category> categories = context.Categories.ToList();
                var group = categories.GroupBy(x => x.Name);
                cbCategory.DisplayMember = "Key";
                cbCategory.ValueMember = "Key";
                cbCategory.DataSource = group.ToList();

            }
        }
        #endregion
        #region events
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            tbAuthor.Text = "";
            tbBookID.Text = "";
            tbTitle.Text = "";
            tbImage.Text = "";
            nmPrice.Value = 0;
            cbCategory.SelectedIndex = 0;
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {

            try
            {
                int cid = context.Categories.Where(x => x.Name == cbCategory.Text).Select(x => x.Id).FirstOrDefault();
                Product p = new Product
                {
                    Cid = cid,
                    Title = tbTitle.Text,
                    Price = decimal.Parse(nmPrice.Value.ToString()),
                    ProductUrl = tbImage.Text,
                    Author = tbAuthor.Text
                };
                context.Products.Add(p);
                context.SaveChanges();
                MessageBox.Show("Add successfull!!!!");
                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.InnerException.Message);

            }
        }
        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Int32.Parse(tbBookID.Text);
                Product p = context.Products.Find(id);
                p.Cid = context.Categories.Where(x => x.Name == cbCategory.Text).Select(x => x.Id).FirstOrDefault();
                p.Title = tbTitle.Text;
                p.Price = nmPrice.Value;
                p.ProductUrl = tbImage.Text;
                p.Author = tbAuthor.Text;
                context.Products.Update(p);
                context.SaveChanges();
                MessageBox.Show("Update successfull!!!!");
                LoadData();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.InnerException.Message);

            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Int32.Parse(tbBookID.Text);
                Product p = context.Products.Find(id);
                context.Products.Remove(p);
                context.SaveChanges();
                MessageBox.Show("Remove successfull!!!!");
                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.InnerException.Message);

            }
        }
        private void btnChooseFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            string path = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.ToString();
            openFileDialog1.InitialDirectory = path + "\\Images";
            openFileDialog1.ShowDialog();
            tbImage.Text = openFileDialog1.SafeFileName.ToString();
        }
        private void dgvBookManagement_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tbBookID.Text = dgvBookManagement.Rows[e.RowIndex].Cells["Column1"].Value.ToString();
            tbTitle.Text = dgvBookManagement.Rows[e.RowIndex].Cells["Column3"].Value.ToString();
            tbImage.Text = dgvBookManagement.Rows[e.RowIndex].Cells["Column5"].Value.ToString();
            nmPrice.Value = Int32.Parse(dgvBookManagement.Rows[e.RowIndex].Cells["Column4"].Value.ToString());
            string category = dgvBookManagement.Rows[e.RowIndex].Cells["Column2"].Value.ToString();
            cbCategory.SelectedIndex = cbCategory.FindString(category);
            tbAuthor.Text = dgvBookManagement.Rows[e.RowIndex].Cells["Column6"].Value.ToString();
        }
        #endregion

        private void gbBookManagement_Enter(object sender, EventArgs e)
        {

        }

        private void dgvBookManagement_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
