using ComicManagement.Models;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace ComicManagement.GUI
{
    public partial class frmProfile : Form
    {
        private readonly ComicShopContext _context = new ComicShopContext();
        private string connectionString;
        private Models.User userProfile;
        public frmProfile()
        {
            InitializeComponent();

        }
        string currentUser = frmLogin.ApplicationState.CurrentUser;
        private void frmProfile_Load(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(currentUser))
            {
                userProfile = LoadUserProfile(currentUser);

                if (userProfile != null)
                {
                    DisplayUserProfile(userProfile);
                }
            }
            else
            {
                MessageBox.Show("Please login before accessing the profile.");
                Close();
            }

        }
        private Models.User LoadUserProfile(string usernames)
        {
            Models.User userProfile = null;

            using (var context = new ComicShopContext())
            {
                try
                {
                    userProfile = context.Users
                        .Where(u => u.UserName == usernames)
                        .Select(u => new Models.User
                        {
                            Id = u.Id,
                            UserName = u.UserName,
                            Password = u.Password,
                            FirstName = u.FirstName,
                            LastName = u.LastName,
                            Address = u.Address,
                            Phone = u.Phone,
                            Email = u.Email,
                            Role = u.Role,
                            Status = u.Status,

                        })
                        .FirstOrDefault();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("err :  " + ex.Message);
                }

                return userProfile;
            }

        }
        private void DisplayUserProfile(Models.User userProfile)
        {
            if (userProfile != null)
            {
                txtFirstName.Text = userProfile.UserName;
                txtLastName.Text = userProfile.Password;
                txtFirstName.Text = userProfile.FirstName;
                txtLastName.Text = userProfile.LastName;
                txtAddress.Text = userProfile.Address;
                txtPhone.Text = userProfile.Phone;
                txtEmail.Text = userProfile.Email;
            }
        }

        private Models.User GetUserObject()
        {
            Models.User user = _context.Users.Where(u => u.UserName == currentUser).FirstOrDefault();
            user.FirstName = txtFirstName.Text;
            user.LastName = txtLastName.Text;
            user.Address = txtAddress.Text;
            user.Phone = txtPhone.Text;
            user.Email = txtEmail.Text;
            return user;
        }

        private void btnUpdate_Click_1(object sender, EventArgs e)
        {
            Models.User user = GetUserObject();
            _context.Users.Update(user);
            _context.SaveChanges();
            MessageBox.Show($"Update succcessful !!");
            txtLastName.Text = user.LastName; 
            txtFirstName.Text = user.FirstName; 
            txtAddress.Text = user.Address; 
            txtPhone.Text = user.Phone; 
            txtEmail.Text = user.Email;
        }
    }
}
