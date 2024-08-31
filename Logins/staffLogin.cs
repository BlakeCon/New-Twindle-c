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
        public static staffLogin instance;
        public TextBox idText;
        public staffLogin()
        {
            InitializeComponent();
            instance = this;
            idText = txt_ID;
        }

        private void btn_submit_Click(object sender, EventArgs e)
        {
            string id = txt_ID.Text;
            string pass = txt_pass.Text;

            staffDbManager staffDbManager = new staffDbManager();

            if (staffDbManager.CompareCredentials(id, pass)) 
            {
                this.Hide();
                staffDash staffDash = new staffDash();
                staffDash.Show();
            }
            else
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
