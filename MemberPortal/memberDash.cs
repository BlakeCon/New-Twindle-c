﻿using gym_c__thing.Classes;
using gym_c__thing.Logins;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gym_c__thing.MemberPortal
{
    public partial class memberDash : Form
    {
        bool sidebarExpand;
        public static memberDash instance;
        public string username;

        public memberDash()
        {
            InitializeComponent();
            instance = this;
            username = string.Empty;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void memberDash_Load(object sender, EventArgs e)
        {

            //random number
            Random random = new Random();
            int randomNumber = random.Next(101);
            lbl_noInGym.Text = randomNumber.ToString();
            progressBar1.Value = randomNumber;



            username = memberLogin.instnace.usernameTxtBxt.Text;
            memberLogin.instnace.Close();
            lbl_usrName.Text = username;

            dbManagerClass dbManagerClass = new dbManagerClass();
            (string usrNotused, string memberType, string email, string name, int id) = dbManagerClass.GetMemberInfoUsername(username);

            lbl_memberType.Text = memberType;
            lbl_ID.Text = id.ToString();

            if (email == "Email not avalible") 
            {
                MessageBox.Show("Remember to add your Email by using the 'Billing' page or asking a staff member!", "Missing Email!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            if (name == "Name not avalible") 
            {
                MessageBox.Show("Remember to add your Name by using the 'Billing' page or asking a staff member!", "Missing Name!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

            }
        }

        private void sidebarTimer_Tick(object sender, EventArgs e)
        {
            if (sidebarExpand)
            {
                sidebar.Width -= 10;
                if (sidebar.Width == sidebar.MinimumSize.Width)
                {
                    sidebarExpand = false;
                    sidebarTimer.Stop();
                }
            }
            else
            {
                sidebar.Width += 10;
                if (sidebar.Width == sidebar.MaximumSize.Width)
                {
                    sidebarExpand = true;
                    sidebarTimer.Stop();
                }
            }
        }

        private void btn_menu_Click(object sender, EventArgs e)
        {
            sidebarTimer.Start();
        }

        private void btn_menu_logout_Click(object sender, EventArgs e)
        {
            memberLogin.instnace.Close();
            this.Close();
            Form1.instance.Show();
        }

        private void btn_menu_events_Click(object sender, EventArgs e)
        {
            this.Hide();
            memberEvents memberEvents = new memberEvents();
            memberEvents.Show();
        }

        private void btn_billing_Click(object sender, EventArgs e)
        {
            this.Hide();
            memberBilling memberBilling = new memberBilling();
            memberBilling.Show();
        }
    }
}
