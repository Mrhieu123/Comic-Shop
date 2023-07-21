using ComicManagement.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComicManagement.GUI
{
    public partial class frmRegister : Form
    {

        ComicShopContext context;
        public string Captchas;
        #region methods
        public frmRegister()
        {
            InitializeComponent();
            context = new ComicShopContext();
        }
        #endregion
        #region events
        private void lbExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {

                User user1 = context.Users.SingleOrDefault(u => u.UserName == tbUsername.Text);
                if (user1 != null)
                {
                    throw new Exception("UserName have exists");
                }

                if (!tbUsername.Text.Equals("") && !tbPassword.Text.Equals("") && !tbRePassword.Text.Equals("") &&
                    !txtFirtName.Text.Equals("") && !txtLastName.Text.Equals("") && !txtEmail.Text.Equals(""))
                {
                    if (!Regex.IsMatch(txtEmail.Text, @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$"))
                    {
                        throw new Exception("Invalid email please enter must be 'someone@gmail.com'");
                    }
                    if (tbPassword.Text.Equals(tbRePassword.Text))
                    {
                        User user = new User
                        {
                            FirstName = txtFirtName.Text,
                            LastName = txtLastName.Text,
                            Email = txtEmail.Text,
                            UserName = tbUsername.Text,
                            Password = tbPassword.Text,
                            Role = 2,
                            Status = true
                        };
                        string captcha = txtCapcha.Text;
                        if (captcha != null)
                        {
                            bool checkCapchas = CheckCaptcha(captcha, Captchas);
                            if (checkCapchas)
                            {
                                context.Users.Add(user);
                                context.SaveChanges();
                                MessageBox.Show("Register sucessfully!");
                                this.Close();
                            }
                            else
                            {
                                MessageBox.Show("Captcha incorrect!");
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Password and re-password must be equals");
                    }
                }
                else
                {
                    MessageBox.Show("Please fill all the blank field");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Register Fail");
            }
            #endregion
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
            frmLogin frmLogin = new frmLogin();
            frmLogin.Show();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }


        public string CreateCaptcha()
        {
            const string characterArray = "0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz";
            StringBuilder strCaptcha = new StringBuilder();
            Random rand = new Random();
            for (int i = 0; i < 7; i++)
            {
                string str = characterArray[rand.Next(characterArray.Length)].ToString();
                strCaptcha.Append(str);
            }
            return strCaptcha.ToString();
        }

        public bool CheckCaptcha(string txt, string captcha)
        {
            bool isMatchCaptcha;

            if (txt.Trim().Equals(captcha.Trim()))
            {
                isMatchCaptcha = true;
            }
            else { isMatchCaptcha = false; }
            return isMatchCaptcha;
        }


        public bool Send(string sendto, string subject, string content)
        {
            bool isSend;
            string _from = "hungnthe163708@fpt.edu.vn";
            string _pass = "dpfhvtgyrfatmlzq";
            //sendto: Email receiver (người nhận)
            //subject: Tiêu đề email
            //content: Nội dung của email
            //Nếu gửi email thành công, sẽ trả về kết quả: OK, không thành công sẽ trả về thông tin l�-i
            try
            {
                MailMessage mail = new MailMessage();
                SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");

                mail.From = new MailAddress(_from);
                mail.To.Add(sendto);
                mail.Subject = subject;
                mail.IsBodyHtml = true;
                mail.Body = content;

                mail.Priority = MailPriority.High;

                SmtpServer.Port = 587;
                SmtpServer.Credentials = new System.Net.NetworkCredential(_from, _pass);
                SmtpServer.EnableSsl = true;

                SmtpServer.Send(mail);
                isSend = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                isSend = false;
            }
            return isSend;
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            try
            {
                string subjects = "ComicShop account registration verification";
                Captchas = CreateCaptcha();
                bool isSend = Send(txtEmail.Text, subjects, Captchas);
                if (isSend)
                {
                    MessageBox.Show("Send captcha to your email successfully!");
                    btnRegister.Enabled = true;
                }
                else
                {
                    MessageBox.Show("send fail!");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Send captcha fail.");
            }

        }

        private void txtFirtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txtCapcha_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
