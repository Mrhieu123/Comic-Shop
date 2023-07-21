using ComicManagement.Models;
using Microsoft.VisualBasic.ApplicationServices;
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
    public partial class frmCheckOut : Form
    {
        ComicShopContext context;
        ShoppingCart cart;
        #region methods
        public frmCheckOut()
        {
            InitializeComponent();
            context = new ComicShopContext();
            cart = ShoppingCart.GetCart();
            int id = context.Users.Where(r => r.UserName == Settings.UserName.ToString()).Select(r => r.Id).FirstOrDefault();
            Models.User user = context.Users.Find(id);
            txtFullName.Text = user.LastName;
            txtPhone.Text = user.Phone;
            txtAddress.Text = user.Address;
            txtTotal.Text = cart.GetTotal().ToString();
        }
        #endregion
        #region events
        private void btnSave_Click(object sender, EventArgs e)
        {
            cart = ShoppingCart.GetCart();
            Order o = new Order();
            o.OrderDate = DateTime.Now;
            o.UserId = Settings.UserId;
            o.FullName = txtFullName.Text;
            o.Address = txtAddress.Text;
            o.Phone = txtPhone.Text;
            o.OrderDate = DateTime.Now;
            o.Total = decimal.Parse(txtTotal.Text);
            cart.CreateOrder(o);
            MessageBox.Show($"Order id {o.Id} is saved!");
            this.Close();
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        private void frmCheckOut_Load(object sender, EventArgs e)
        {

        }

        private void lbPhone_Click(object sender, EventArgs e)
        {

        }

        private void lbFName_Click(object sender, EventArgs e)
        {

        }

        private void lbTotal_Click(object sender, EventArgs e)
        {

        }
    }
}
