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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip;

namespace ComicManagement.GUI
{
    public partial class frmHistoryOrder : Form
    {
        ComicShopContext context = new ComicShopContext();
        BindingSource source;
        public List<Order> orderInfo { get; set; }
        public frmHistoryOrder()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e) => Close();

        private void dgvOrderDetail_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        //public void LoadOrderDetailList()
        //{
        // int orderId = int.Parse(txtOrdersId.Text);
        //// var orderDetail = context.OrderDetails.Where(od => od.OrderId == orderId);
        //IEnumerable<Order> orders;
        //if (Settings.Role == 1)
        //{
        //    orders = context.Orders.Where(od => od.OrderDetails.Any(os => os.Status == false)).ToList();
        //}
        //else
        //{
        //    orders = context.Orders.Where(od => od.UserId == Settings.UserId && od.OrderDetails.Any(os => os.Status == false)).ToList();

        //}
        //try
        //{
        //source = new BindingSource();
        //source.DataSource = orders;

        //txtOrdersId.DataBindings.Clear();
        //txtUserId.DataBindings.Clear();
        //txtOrderDate.DataBindings.Clear();
        //txtFullName.DataBindings.Clear();
        //txtAddress.DataBindings.Clear();
        //txtPhone.DataBindings.Clear();

        //txtOrdersId.DataBindings.Add("Text", source, "id");
        //txtUserId.DataBindings.Add("Text", source, "UserId");
        //txtOrderDate.DataBindings.Add("Text", source, "OrderDate");
        //txtFullName.DataBindings.Add("Text", source, "FullName");
        //txtAddress.DataBindings.Add("Text", source, "Address");
        //txtPhone.DataBindings.Add("Text", source, "Phone");

        // dgvOrders.DataSource = null;
        //  dgvHistoryOrder.DataSource = orders.ToList();

        // dgvHistoryOrder.Columns["UserId"].Visible = false;

        //if (orders.Count() == 0)
        //{
        //    ClearText();
        //    btnDelete.Enabled = false;
        //}
        //else
        //{
        //    btnDelete.Visible = true;
        //}
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message, "Load orders list");
        //    }
        //}

        public void DisplayOrders(List<Order> orders)
        {
            dgvHistoryOrder.DataSource = orders;
            dgvHistoryOrder.Columns["UserId"].Visible = false;
        }


        private void frmHistoryOrder_Load(object sender, EventArgs e)
        {

        }
    }
}
