using ComicManagement.GUI;
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
    public partial class frmHome : Form
    {
        ComicShopContext context;
        ShoppingCart cart;
        #region methods
        public frmHome()
        {
            InitializeComponent();
            context = new ComicShopContext();

        }
        #endregion
        #region events
        private void frmBook_Activated(object sender, EventArgs e)
        {
            if (Settings.UserName != null && Settings.UserName != " ")
            {
                pnLogout.Visible = true;
                //lbLogout.Text = $"Logout({Settings.UserName})";
                lbLogout.Text = "Logout";
                pnLogin.Visible = false;
                pnManagement.Visible = false;
                pnMemberManagement.Visible = false;
                pnOrderManagement.Visible = false;
                if (Settings.Role == 1)
                {
                    pnMemberManagement.Visible = true;
                    pnManagement.Visible = true;
                    pnOrderManagement.Visible = true;
                    pnCategory.Visible = true;
                    pnProfile.Visible = true;
                }
                if (Settings.Role == 2)
                {
                    pnProfile.Visible = true;
                    pnOrderManagement.Visible = true;
                }
            }
            cart = ShoppingCart.GetCart();
            int count = cart.GetCount();
            lbCart.Text = $"Cart ({count})";

        }
        private void lbBooks_Click(object sender, EventArgs e)
        {
            frmComic bookShop = new frmComic();
            bookShop.TopLevel = false;
            bookShop.FormBorderStyle = FormBorderStyle.None;
            bookShop.Show();
            toolStripContainer1.ContentPanel.Controls.Clear();
            toolStripContainer1.ContentPanel.Controls.Add(bookShop);
        }
        private void lbCart_Click(object sender, EventArgs e)
        {
            frmCart billing = new frmCart();
            billing.TopLevel = false;
            billing.FormBorderStyle = FormBorderStyle.None;
            billing.Show();
            toolStripContainer1.ContentPanel.Controls.Clear();
            toolStripContainer1.ContentPanel.Controls.Add(billing);
        }
        private void lbManagement_Click(object sender, EventArgs e)
        {
            frmComicManagement bookManagement = new frmComicManagement();

            bookManagement.TopLevel = false;
            bookManagement.FormBorderStyle = FormBorderStyle.None;
            bookManagement.Show();
            toolStripContainer1.ContentPanel.Controls.Clear();
            toolStripContainer1.ContentPanel.Controls.Add(bookManagement);
        }

        private void lbLogin_Click(object sender, EventArgs e)
        {
            frmLogin login = new frmLogin();
            login.Show();
        }
        private void lbLogout_Click(object sender, EventArgs e)
        {

            ShoppingCart cart = new ShoppingCart();
            pnLogout.Visible = false;
            pnLogin.Visible = true;
            cart = ShoppingCart.GetCart();
            Settings.UserName = null;
            Settings.CartId = null;
            cart.EmptyCart();
            lbCart.Text = "Cart";
            pnMemberManagement.Visible = false;
            pnManagement.Visible = false;
            pnOrderManagement.Visible = false;
            pnCategory.Visible= false;
            pnProfile.Visible = false;
            List<Form> openFormList = new List<Form>();

            // Sao chép các Form vào danh sách tạm thời
            foreach (Form form in Application.OpenForms)
            {
                if (form != Application.OpenForms[0])
                {
                    openFormList.Add(form);
                }
            }

            // Đóng các Form trong danh sách tạm thời
            foreach (Form form in openFormList)
            {
                form.Close();
            }
        }
        private void exitProgram_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        #endregion

        private void label1_Click(object sender, EventArgs e)
        {
            frmOrders frmOrders = new frmOrders();

            frmOrders.TopLevel = false;
            frmOrders.FormBorderStyle = FormBorderStyle.None;
            frmOrders.Show();
            toolStripContainer1.ContentPanel.Controls.Clear();
            toolStripContainer1.ContentPanel.Controls.Add(frmOrders);
        }

        private void pnLogin_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {
            frmMemberManagement frmMemberManagement = new frmMemberManagement();

            frmMemberManagement.TopLevel = false;
            frmMemberManagement.FormBorderStyle = FormBorderStyle.None;
            frmMemberManagement.Show();
            toolStripContainer1.ContentPanel.Controls.Clear();
            toolStripContainer1.ContentPanel.Controls.Add(frmMemberManagement);



        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pnManagement_Paint(object sender, PaintEventArgs e)
        {

        }

        private void toolStripContainer1_TopToolStripPanel_Click(object sender, EventArgs e)
        {

        }

        private void toolStripContainer1_ContentPanel_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void toolStripContainer1_ContentPanel_Load_1(object sender, EventArgs e)
        {

        }

        private void toolStripContainer1_ContentPanel_Load_2(object sender, EventArgs e)
        {

        }

        private void lbCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void pnLogout_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void lbProfile_Click(object sender, EventArgs e)
        {
            frmProfile frmProfile = new frmProfile();

            frmProfile.TopLevel = false;
            frmProfile.FormBorderStyle = FormBorderStyle.None;
            frmProfile.Show();
            toolStripContainer1.ContentPanel.Controls.Clear();
            toolStripContainer1.ContentPanel.Controls.Add(frmProfile);
        }

        private void pnCategory_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lbCategory_Click(object sender, EventArgs e)
        {
            frmCategoryManagemet frmCategory = new frmCategoryManagemet();

            frmCategory.TopLevel = false;
            frmCategory.FormBorderStyle = FormBorderStyle.None;
            frmCategory.Show();
            toolStripContainer1.ContentPanel.Controls.Clear();
            toolStripContainer1.ContentPanel.Controls.Add(frmCategory);
        }
    }
}
