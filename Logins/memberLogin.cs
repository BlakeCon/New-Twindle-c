using gym_c__thing.Classes;
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
    public partial class memberLogin : Form
    {
        public memberLogin()
        {
            InitializeComponent();
        }

        private void btn_submit_Click(object sender, EventArgs e)
        {
            string username = txt_usrname.Text; 
            string password = txt_password.Text; 

            dbManagerClass dbManager = new dbManagerClass(); 
            bool credentialsMatch = dbManager.CompareCredentials(username, password);
            if (credentialsMatch) {
                MessageBox.Show("Login successful!");
            } else {
                MessageBox.Show("Login failed!");
            }
        }
    }
}
