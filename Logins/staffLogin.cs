using gym_c__thing.Classes;
using gym_c__thing.StaffPortal;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gym_c__thing.Logins
{
    public partial class staffLogin : Form
    {
        //declears the instance and the text box so it can be accessed from other forms such as staffDash.
        public static staffLogin instance;
        public TextBox idText;
        
        public staffLogin()
        {
            //Initializes the component and sets the instance to this form and the idText variable to the txt_ID textbox.
            InitializeComponent();
            instance = this;
            idText = txt_ID;
        }

        //Method called when the submit button is clicked. 
        private void btn_submit_Click(object sender, EventArgs e)
        {
            //Gets the ID and password from the textboxes and saves them in variables.
            string id = txt_ID.Text;
            string pass = txt_pass.Text;

            //Creates a new instance of the staffDbManager.
            staffDbManager staffDbManager = new staffDbManager();

            //If the credentials compare method from the staffDbManager returns true, the current form will close and the staffDash form will show the staff dashboard.
            //SECURITY NOTE: This does not pass the password on to another form it should be cleared from memory when its closed by staffDash. 
            if (staffDbManager.CompareCredentials(id, pass)) 
            {
                this.Hide();
                staffDash staffDash = new staffDash();
                staffDash.Show();
            }
            else
            //If the credentials are incorrect then a text box appears and the password textbox is cleared.
            {
                MessageBox.Show("Invalid Credentials");
                txt_pass.Text = "";
            }
                

        }

        private void staffLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
