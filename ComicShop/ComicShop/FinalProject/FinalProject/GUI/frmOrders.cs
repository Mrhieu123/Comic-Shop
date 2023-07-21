using ComicManagement.Models;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComicManagement.GUI
{
    public partial class frmOrders : Form
    {
        ComicShopContext context = new ComicShopContext();
        BindingSource source;
        public frmOrders()
        {
            InitializeComponent();
            LoadOrderDetailList();
        }
        private void btnClose_Click(object sender, EventArgs e) => Close();

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int orderid = int.Parse(txtOrdersId.Text);
            //Order ord = context.Orders.Where(od => od.Id == orderid);
            Order ord = context.Orders.SingleOrDefault(od => od.Id == orderid);
            if (orderid != null)
            {
                context.Orders.Remove(ord);
                context.SaveChanges();
                LoadOrderDetailList();
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnView_Click(object sender, EventArgs e)
        {
            try
            {
                int orderId = int.Parse(txtOrdersId.Text);
                // OrderDetail ord = context.OrderDetails.SingleOrDefault(od => od.Id == orderId);
                List<OrderDetail> orderDetail = new List<OrderDetail>();
                orderDetail = context.OrderDetails.Where(o => o.OrderId == orderId).ToList();
                frmOrdersDetail frmdetail = new frmOrdersDetail();
                frmdetail.DisplayOrders(orderDetail);
                //LoadOrderDetailList();
                frmdetail.Show();

                // LoadOrderDetailList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Get Order Detail");
            }
        }


        public void LoadOrderDetailList()
        {
            // int orderId = int.Parse(txtOrdersId.Text);
            // var orderDetail = context.OrderDetails.Where(od => od.OrderId == orderId);
            IEnumerable<Order> orders;
            if (Settings.Role == 1)
            {
                orders = context.Orders.Where(od => od.OrderDetails.Any(os => os.Status == false)).ToList();
            }
            else
            {
                orders = context.Orders.Where(od => od.UserId == Settings.UserId && od.OrderDetails.Any(os => os.Status == false)).ToList();

            }
            try
            {
                source = new BindingSource();
                source.DataSource = orders;

                txtOrdersId.DataBindings.Clear();
                txtUserId.DataBindings.Clear();
                txtOrderDate.DataBindings.Clear();
                txtFullName.DataBindings.Clear();
                txtAddress.DataBindings.Clear();
                txtPhone.DataBindings.Clear();

                txtOrdersId.DataBindings.Add("Text", source, "id");
                txtUserId.DataBindings.Add("Text", source, "UserId");
                txtOrderDate.DataBindings.Add("Text", source, "OrderDate");
                txtFullName.DataBindings.Add("Text", source, "FullName");
                txtAddress.DataBindings.Add("Text", source, "Address");
                txtPhone.DataBindings.Add("Text", source, "Phone");

                dgvOrders.DataSource = null;
                dgvOrders.DataSource = source;

                dgvOrders.Columns["OrderDetails"].Visible = false;

                dgvOrders.Columns["UserId"].Visible = false;

                if (orders.Count() == 0)
                {
                    ClearText();
                    btnDelete.Enabled = false;
                }
                else
                {
                    btnDelete.Visible = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Load orders list");
            }
        }

        private void ClearText()
        {
            txtOrdersId.Text = string.Empty;
            txtUserId.Text = string.Empty;
            txtOrderDate.Text = string.Empty;
            txtAddress.Text = string.Empty;
            txtFullName.Text = string.Empty;
            txtPhone.Text = string.Empty;
        }

        private void btnExit_Click(object sender, EventArgs e) => Close();

        private void frmOrders_Load(object sender, EventArgs e)
        {
            if (Settings.Role == 1)
            {
                btnUpdate.Visible = false;
            }
            if (Settings.Role == 2)
            {
                btnAccept.Visible = false;
            }


        }

        private void dgvOrders_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {


            try
            {
                int orderid = int.Parse(txtOrdersId.Text);

                Order ord = context.Orders.SingleOrDefault(od => od.Id == orderid);
                if (ord != null)
                {
                    ord.Id = int.Parse(txtOrdersId.Text);
                    ord.UserId = int.Parse(txtUserId.Text);
                    ord.OrderDate = DateTime.Parse(txtOrderDate.Text);
                    ord.FullName = txtFullName.Text;
                    ord.Address = txtAddress.Text;
                    ord.Phone = txtPhone.Text;
                    context.Orders.Update(ord);
                    context.SaveChanges();
                    MessageBox.Show("Update order successfully!!");
                    LoadOrderDetailList();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            try
            {
                int orderid = int.Parse(txtOrdersId.Text);

                List<OrderDetail> ord = context.OrderDetails.Where(od => od.OrderId == orderid).ToList();
                if (ord != null)
                {
                    foreach (OrderDetail orderDetail in ord)
                    {
                        orderDetail.Status = true;
                    }
                    context.OrderDetails.UpdateRange(ord);
                    context.SaveChanges();
                    MessageBox.Show("Your order has been approved successfully!");
                    LoadOrderDetailList();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnHistory_Click(object sender, EventArgs e)
        {

            List<Order> order = new List<Order>();
            if (Settings.Role == 1)
            {
                order = context.Orders.Where(od => od.OrderDetails.Any(os => os.Status == true)).ToList();

            }
            else
            {
                order = context.Orders.Where(od => od.UserId == Settings.UserId && od.OrderDetails.Any(os => os.Status == true)).ToList();

            }
            frmHistoryOrder frmHistoryOrder = new frmHistoryOrder();
            frmHistoryOrder.DisplayOrders(order);
            //LoadOrderDetailList();
            frmHistoryOrder.Show();


        }

        private void txtAddress_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
