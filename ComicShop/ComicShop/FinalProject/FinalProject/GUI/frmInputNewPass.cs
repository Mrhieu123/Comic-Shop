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
    public partial class frmInputNewPass : Form
    {
        ComicShopContext context = new ComicShopContext();
        public User users { get; set; }
        public frmInputNewPass()
        {
            InitializeComponent();
        }

        private void frmInputNewPass_Load(object sender, EventArgs e)
        {
            string pass = txtPassword.Text;
            string repass = txtRepassword.Text;
            if (pass.Equals(repass))
            {
                users.Password = pass;
                context.Users.Update(users);
                context.SaveChanges();
                MessageBox.Show("Update successfully!");
            }
        }
    }
}
