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
using static System.Net.Mime.MediaTypeNames;

namespace ComicManagement.GUI
{
    public partial class frmCategoryManagemet : Form
    {
        private ComicShopContext context = new ComicShopContext();
        BindingSource source;
        int idCategory;
        public frmCategoryManagemet()
        {
            InitializeComponent();
            LoadList();
        }

        private void frmCategoryManagemet_Load(object sender, EventArgs e)
        {

        }
        private void LoadList()
        {
            var categories = context.Categories.ToList();
            try
            {
                source = new BindingSource();
                source.DataSource = categories;
                dataGridView.DataSource = null;
                dataGridView.DataSource = source;

                dataGridView.Columns["Products"].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Load user list");
            }
        }
        private void ClearText()
        {
            txtId.Text = string.Empty;
            txtName.Text = string.Empty;
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            ClearText();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            string categoryName = txtName.Text;
            Category category = context.Categories.FirstOrDefault(c => c.Id == idCategory);

            if (category != null)
            {
                category.Name = categoryName;
                context.SaveChanges();
                LoadList();
                MessageBox.Show("Update successful!");
            }
            else
            {
                MessageBox.Show("Category not found!");
            }



            LoadList();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                Category p = context.Categories.Find(idCategory);
                context.Categories.Remove(p);
                context.SaveChanges();
                MessageBox.Show("Remove successfull!!!!");
                LoadList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.InnerException.Message);

            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                string? name = txtName.Text;
                if (context.Categories.FirstOrDefault(c => c.Name.Equals(name)) != null)
                {
                    throw new Exception("Category exists");
                }
                else
                {
                    Category category = new Category();
                    category.Name = txtName.Text;
                    context.Add(category);
                    context.SaveChanges();
                    LoadList();
                    MessageBox.Show("Add successfully", "Add Category");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void gbBookManagement_Enter(object sender, EventArgs e)
        {

        }

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
            if (dataGridView.Columns[e.ColumnIndex] is DataGridViewColumn && e.RowIndex >= 0)
            {
                DataGridViewRow row = (DataGridViewRow)dataGridView.Rows[e.RowIndex];
                idCategory = int.Parse(row.Cells["id"].Value.ToString());
                string name = row.Cells["name"].Value.ToString();
                txtId.Text = idCategory.ToString();
                txtName.Text = name;
            }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}