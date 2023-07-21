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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace ComicManagement.GUI
{
    public partial class frmLogin : Form
    {
        #region methods
        public frmLogin()
        {
            InitializeComponent();
        }
        #endregion
        #region events
        private void lbExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public static class ApplicationState
        {
            public static string CurrentUser { get; set; }

        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                bool isUser = false;
                string username = tbUsername.Text;
                string password = tbPassword.Text;
                ApplicationState.CurrentUser = username;
                ComicShopContext context = new ComicShopContext();

                if (username != String.Empty && password != String.Empty)
                {
                    IQueryable<User> admins = context.Users.Where(a => a.Role == 1);
                    IQueryable<User> users = context.Users.Where(a => a.Role == 2);
                    foreach (User user in admins)
                    {
                        if (username.Equals(user.UserName) && password.Equals(user.Password) && user.Status != false)
                        {
                            Settings.UserName = user.UserName;
                            Settings.Role = user.Role;
                            Settings.UserId = user.Id;
                            this.Close();
                            isUser = true;
                        }

                    }
                    foreach (User user in users)
                    {
                        if (username.Equals(user.UserName) && password.Equals(user.Password) && user.Status != false)
                        {
                            Settings.UserName = user.UserName;
                            Settings.Role = user.Role;
                            Settings.UserId = user.Id;
                            this.Close();
                            isUser = true;
                        }
                    }
                    if (isUser == false)
                    {
                        MessageBox.Show("Wrong account or password!");
                    }
                }
                else
                {
                    MessageBox.Show("Please fill into blank!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        private void lbRegister_Click(object sender, EventArgs e)
        {
            this.Close();
            frmRegister usersGUI = new frmRegister();
            usersGUI.Show();
        }
        #endregion


        private void pnLogin_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lbResetPassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
            frmResetPassword usersGUI = new frmResetPassword();
            usersGUI.Show();
        }
    }
}

