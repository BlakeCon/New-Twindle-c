using gym_c__thing.Classes;
using System;
using System.Windows.Forms;

namespace gym_c__thing.Logins
{
    public partial class memberLogin : Form
    {
        public static memberLogin instnace;
        public TextBox usernameTxtBxt;

        //This is the constructor for the memberLogin form, also initializes the instance and usernameTxtBxt variables so they can be accessed from other forms.
        public memberLogin()
        {
            InitializeComponent();
            instnace = this;
            usernameTxtBxt = txt_usrname;
        }

        //Method called when the submit button is clicked
        private void btn_submit_Click(object sender, EventArgs e)
        {
            //Gets the username and password from the textboxes
            string username = txt_usrname.Text; 
            string password = txt_password.Text; 

            //Creates a new instance of the dbManagerClass and calls the CompareCredentials method to check if the credentials match the database.
            dbManagerClass dbManager = new dbManagerClass(); 
            bool credentialsMatch = dbManager.CompareCredentials(username, password);
           
            //Note: The password is set to null after the form is hidden, this is to prevent the password from being stored in memory.
            //Another note: as a 2nd security measure, the form is closed after the member dash gets the username from this form.
            
            //If the credentials match, credentialsMatch will be true and the memberDash form will be shown, if not, a message box will appear.
            if (credentialsMatch) {
                this.Hide();
                //Creates a new instance of the memberDash form and shows it.
                MemberPortal.memberDash memberDash = new MemberPortal.memberDash();
                memberDash.Show();
                password = null;
            } else {
                MessageBox.Show("Login failed!");
            }
        }

        //Method called when the clear button is clicked
        private void btn_clear_Click(object sender, EventArgs e)
        {
            //Clears the textboxes
            txt_password.Clear();
            txt_usrname.Clear();
        }

        //Method called when the back button is clicked
        private void btn_back_Click(object sender, EventArgs e)
        {
            //Closes the current form and shows the previous form (Form1).
            this.Close();
            Form1.instance.Show();
        }

        //Method called when the show password checkbox is checked or unchecked
        private void chbox_showPassword_CheckedChanged(object sender, EventArgs e)
        {
            //If the checkbox is checked, the password will be shown, if not, it will be hidden.
            bool check = chbox_showPassword.Checked;
            if (check)
            {
                //UseSystemPasswordChar is used as it is more secure than setting the password to a string of *'s.
                txt_password.UseSystemPasswordChar = false;
            }
            else
            {
                txt_password.UseSystemPasswordChar = true;
            }
        }

        private void memberLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
