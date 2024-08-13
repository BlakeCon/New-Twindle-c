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
        public static memberLogin instnace;
        public TextBox usernameTxtBxt;

        public memberLogin()
        {
            InitializeComponent();
            instnace = this;
            usernameTxtBxt = txt_usrname;
        }

        private void btn_submit_Click(object sender, EventArgs e)
        {
            string username = txt_usrname.Text; 
            string password = txt_password.Text; 

            dbManagerClass dbManager = new dbManagerClass(); 
            bool credentialsMatch = dbManager.CompareCredentials(username, password);
            if (credentialsMatch) {
                this.Hide();
                MemberPortal.memberDash memberDash = new MemberPortal.memberDash();
                memberDash.Show();
                password = null;
            } else {
                MessageBox.Show("Login failed!");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void memberLogin_Load(object sender, EventArgs e)
        {

        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            txt_password.Clear();
            txt_usrname.Clear();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1.instance.Show();
        }
    }
}
