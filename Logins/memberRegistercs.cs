using gym_c__thing.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gym_c__thing.Logins
{
    public partial class memberRegistercs : Form
    {
        public memberRegistercs()
        {
            InitializeComponent();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1.instance.Show();
        }

        private void btn_submit_Click(object sender, EventArgs e)
        {
            dbRegistrationManager memberRegister = new dbRegistrationManager();
            string username = txt_username.Text;
            string password = txt_password.Text;
            string email = txt_email.Text;
            string memberType = txt_memberType.Text;

            bool result = memberRegister.RegisterUser(username, email, password, memberType);

            if (result)
            {
                MessageBox.Show("Registration successful!");

                //var smtpClient = new SmtpClient("smtp.gmail.com")
               // {
                   // Port = 587,
                  //  Credentials = new NetworkCredential("collegeexperiements@gmail.com", "Connor1202"),
                   // EnableSsl = true,
               // };

                //smtpClient.Send("collegeexperiements@gmail.com", email, "Thanks for registering!", "Thanks for registering to Twindle Gyms!");

                this.Close();
                memberLogin memberLogin = new memberLogin();
                memberLogin.Show();
            }
            else
            {
                MessageBox.Show("Registration failed!");
            }
        }

        private void memberRegistercs_Load(object sender, EventArgs e)
        {

        }
    }
}
