using gym_c__thing.Classes;
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
using System.Globalization;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace gym_c__thing.MemberPortal
{
    public partial class memberDash : Form
    {
        bool sidebarExpand;
        public static memberDash instance;
        public string username;
        public int membersInGym;
        public bool startingNumber;
        public bool checkedInGym;
        string timeFormat = "HH:mm";


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

            //Generates a random starting number for the progress bar
            Random random = new Random();
            int randomNumber = random.Next(101);
            progressBarUpdate(randomNumber);




            username = memberLogin.instnace.usernameTxtBxt.Text;
            memberLogin.instnace.Close();
            lbl_usrName.Text = username;

            dbManagerClass dbManagerClass = new dbManagerClass();
            (string usrNotused, string memberType, string email, string name, int id) = dbManagerClass.GetMemberInfoUsername(username);

            lbl_memberType.Text = memberType;
            lbl_Id.Text = id.ToString();

            if (email == "Email not avalible")
            {
                MessageBox.Show("Remember to add your Email by using the 'Billing' page or asking a staff member!", "Missing Email!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            if (name == "Name not avalible")
            {
                MessageBox.Show("Remember to add your Name by using the 'Billing' page or asking a staff member!", "Missing Name!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

            }

            //closingChecks();
        }

        private void closingChecks() 
        {
            string dayFormat = "ddd";
            var today = DateTime.Now.ToString(dayFormat);

            dbManagerClass dbManagerClass = new dbManagerClass();
            (string openingTime, string closingTime) = dbManagerClass.getHours(today);

            DateTime currentTime = DateTime.ParseExact(DateTime.Now.ToString(timeFormat), timeFormat, CultureInfo.InvariantCulture);
            DateTime closingTimeParsed = DateTime.ParseExact(closingTime, timeFormat, CultureInfo.InvariantCulture);

            if (currentTime > closingTimeParsed || closingTime == "Closed")
            {
                lbl_openStatus.Text = "We are now : CLOSED!";
            }
            else
            {
                lbl_openStatus.Text = "We are now: OPEN!";
            }
            
            lbl_closingTimeToday.Text = closingTime;
            lbl_openingTimeToday.Text = openingTime;

        }





        private void progressBarUpdate(int value)
        {
            if (value > 90)
            {
                progressBar1.BackColor = Color.Yellow;
            }
            if (value > 99)
            {
                progressBar1.BackColor = Color.Red;
            }
            lbl_noInGym.Text = value.ToString();
            progressBar1.Value = value;
            membersInGym = value;
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
            if (checkedInGym)
            {
                DialogResult result = MessageBox.Show("Do you want to check out?", "Check Out", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    progressBarUpdate(membersInGym - 1);
                    checkedInGym = false;
                }
            }
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

        private void btn_checkIn_Click(object sender, EventArgs e)
        {
            if (checkedInGym)
            {
                MessageBox.Show("You're already checked in!", "Checked In", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if(membersInGym == 100)
            {
                MessageBox.Show("The gym is currently at capasity! Please come back later", "Gym Full!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            progressBarUpdate(membersInGym + 1);
            checkedInGym = true;
        }

        private void btn_checkOut_Click(object sender, EventArgs e)
        {
            if (!checkedInGym)
            {
                MessageBox.Show("You're not checked in!", "Not Checked In", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            progressBarUpdate(membersInGym - 1);
            checkedInGym = false;
        }

    }
}
