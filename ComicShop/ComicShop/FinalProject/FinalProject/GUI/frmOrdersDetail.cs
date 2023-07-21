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
    public partial class frmOrdersDetail : Form
    {

        ComicShopContext context = new ComicShopContext();
        public List<OrderDetail> orderInfo { get; set; }
        public frmOrdersDetail()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e) => Close();

        private void frmOrdersDetail_Load(object sender, EventArgs e)
        {

        }
        public void DisplayOrders(List<OrderDetail> orders)
        {

            dgvOrderDetail.DataSource = orders;
        }

        private void dgvOrderDetail_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 4)
            {
                if (e.Value != null && e.Value is bool)
                {
                    bool status = (bool)e.Value;
                    e.Value = status ? "Success" : "Processing";
                    e.FormattingApplied = true;
                }
            }
        }

        private void dgvOrderDetail_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
