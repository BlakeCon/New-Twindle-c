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

        //Method called when the back button is clicked
        private void btn_back_Click(object sender, EventArgs e)
        {
            //Closes the current form and shows the main form
            this.Close();
            Form1.instance.Show();
        }

        //Method called when the submit button is clicked
        private void btn_submit_Click(object sender, EventArgs e)
        {
            //Creates a new instance of the dbRegistrationManager.
            dbRegistrationManager memberRegister = new dbRegistrationManager();
            //Gets the username, password, email and memberType from the textboxes.
            string username = txt_username.Text;
            string password = txt_password.Text;
            string email = txt_email.Text;
            string memberType = txt_memberType.Text;

            //Calls the RegisterUser method from the dbRegistrationManager and passes the username, email, password and memberType, returns a bool which is stored in the result variable.
            bool result = memberRegister.RegisterUser(username, email, password, memberType);

            //If the result is true, a message box will appear saying "Registration successful!" and the form will close and the memberLogin form will show.
            if (result)
            {
                MessageBox.Show("Registration successful!");

                this.Close();
                memberLogin memberLogin = new memberLogin();
                memberLogin.Show();
            }
            //If the result is false, a general message box will appear saying "Registration failed!", note each error is handled in the dbRegistrationManager class.
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
