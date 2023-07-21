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
    public partial class frmResetPassword : Form
    {
        ComicShopContext context;
        String Captchas;
        public frmResetPassword()
        {
            InitializeComponent();
        }

        private void frmResetPassword_Load(object sender, EventArgs e)
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


        private void btnSend_Click_1(object sender, EventArgs e)
        {
            try
            {
                string subjects = "ComicShop account registration verification";
                Captchas = CreateCaptcha();
                bool isSend = Send(txtEmail.Text, subjects, Captchas);
                if (isSend)
                {
                    MessageBox.Show("Send captcha to your email successfully!");
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

        private void btnCheck_Click(object sender, EventArgs e)
        {

            Models.User user1 = context.Users.SingleOrDefault(u => u.Email == txtEmail.Text);
            if (user1 == null)
            {
                string captcha = txtCapcha.Text;
                if (captcha != null)
                {
                    bool checkCapchas = CheckCaptcha(captcha, Captchas);
                    if (checkCapchas)
                    {
                        frmInputNewPass frmnew = new frmInputNewPass()
                        {
                            users = user1

                        };
                    }
                }
                else
                {
                    MessageBox.Show("Captcha incorrect!");
                }
            }
            else
            {
                MessageBox.Show("Email not empty!");
            }
        }
    }
}


