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
    public partial class frmCart : Form
    {
        ShoppingCart cart;
        ComicShopContext context;
        #region Methods
        public frmCart()
        {
            InitializeComponent();
            context = new ComicShopContext();
            lbUsername.Text = Settings.UserName;
            bindGrid();
        }
        void bindGrid()
        {
            cart = ShoppingCart.GetCart();
            tbTotal.Text = cart.GetTotal().ToString();
            dgvBilling.Columns.Clear();
            dgvBilling.DataSource = cart.GetCartItems().ToList();
            dgvBilling.Columns["CartId"].Visible = false;
            dgvBilling.Columns["id"].Visible = false;
            dgvBilling.Columns["Product"].Visible = false;
            if (dgvBilling.Rows.Count > 0 && Settings.UserName != null)
            {
                btnCheckOut.Enabled = true;
            }
            else if (dgvBilling.Rows.Count == 0)
            {
                btnCheckOut.Enabled = false;
            }
            int count = dgvBilling.Columns.Count;
            DataGridViewButtonColumn btnAdd = new DataGridViewButtonColumn
            {
                Text = "Add to cart",
                Name = "Add",
                UseColumnTextForButtonValue = true,
            };
            dgvBilling.Columns.Insert(0, btnAdd);

            DataGridViewButtonColumn btnRemove = new DataGridViewButtonColumn
            {
                Text = "Remove from cart",
                Name = "Remove",
                UseColumnTextForButtonValue = true,
            };
            dgvBilling.Columns.Insert(count + 1, btnRemove);
        }
        #endregion
        #region Events
        private void btnCheckOut_Click(object sender, EventArgs e)
        {
            frmCheckOut checkOut = new frmCheckOut();
            DialogResult dr = checkOut.ShowDialog();
            if (dr == DialogResult.OK)
            {
                cart.EmptyCart();
                bindGrid();
            }

        }
        private void dgvBilling_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgvBilling.Columns["Add"].Index)
            {
                int productId = (int)dgvBilling.Rows[e.RowIndex].Cells["ProductId"].Value;
                Product product = context.Products.Find(productId);
                cart.AddToCart(product);
                bindGrid();
            }
            else if (e.ColumnIndex == dgvBilling.Columns["Remove"].Index)
            {
                int recordId = (int)dgvBilling.Rows[e.RowIndex].Cells["id"].Value;
                cart.RemoveFromCart(recordId);
                bindGrid();
            }
        }
        private void lbCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        private void dgvBilling_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void lbCart_Click(object sender, EventArgs e)
        {

        }

        private void pnBilling_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
