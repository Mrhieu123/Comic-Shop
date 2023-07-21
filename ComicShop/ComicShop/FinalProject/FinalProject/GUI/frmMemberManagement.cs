using ComicManagement.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComicManagement.GUI
{
    public partial class frmMemberManagement : Form
    {
        private ComicShopContext context = new ComicShopContext();
        BindingSource source;
        public frmMemberManagement()
        {
            InitializeComponent();
            LoadUserList();
        }

        private void frmMemberManagement_Load(object sender, EventArgs e)
        {

        }

        private void LoadUserList()
        {
            var users = context.Users.ToList();
            try
            {
                source = new BindingSource();
                source.DataSource = users;

                txtId.DataBindings.Clear();
                txtFName.DataBindings.Clear();
                txtLName.DataBindings.Clear();
                txtPhone.DataBindings.Clear();
                txtEmail.DataBindings.Clear();
                txtAddress.DataBindings.Clear();

                txtId.DataBindings.Add("text", source, "Id");
                txtFName.DataBindings.Add("text", source, "FirstName");
                txtLName.DataBindings.Add("text", source, "LastName");
                txtPhone.DataBindings.Add("text", source, "Phone");
                txtEmail.DataBindings.Add("text", source, "Email");
                txtAddress.DataBindings.Add("text", source, "Address");

                dgvUsers.DataSource = null;
                dgvUsers.DataSource = source;
                if (users.Count() == 0)
                {
                    ClearText();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Load user list");
            }
        }
        private void ClearText()
        {
            txtId.Text = string.Empty;
            txtFName.Text = string.Empty;
            txtLName.Text = string.Empty;
            txtPhone.Text = string.Empty;
            txtEmail.Text = string.Empty;
            txtAddress.Text = string.Empty;
        }

        private void btnLock_Click(object sender, EventArgs e)
        {
            var id = int.Parse(txtId.Text);
            Models.User user = null;
            try
            {
                user = context.Users.SingleOrDefault(u => u.Id == id);
                if (user != null && user.Role != 1)
                {
                    user.Status = !user.Status.Value;
                    context.Users.Update(user);
                    context.SaveChanges();
                    MessageBox.Show("Change Status Successfully", "Change Status");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Change Status");
            }

        }

        private void dgvUsers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
