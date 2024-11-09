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
        Random random = new Random();
        bool sidebarExpand;
        public static memberDash instance;
        public string username;
        //The 50 should be a temp starting number, this will be replaced with a database call to get the current number of members in the gym.
        public int membersInGym = 50;
        //The capasity should be a temp starting number, this will be replaced with a database call to get the capasity of the gym.
        private const int capasity = 100;
        public bool startingNumber;
        private bool checkedInGym;
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

            progressBarUpdate(membersInGym);



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

        private void progressBarUpdate(int InGym)
        {
            //Rounds it as a float to 1 decimal place and that cant be used for progress bar values. 
            float capasityUsage = (float)Math.Round(((float)InGym / capasity) * 100, 1);
            //Add code to change colour here//
            //updates the lable and the progress bar with new value. 
            lbl_noInGym.Text = InGym.ToString();
            progressBar1.Value = (int)capasityUsage;
        }

        //Method that is called every tick of a timer.
        private void sidebarTimer_Tick(object sender, EventArgs e)
        {
            //Adds or removes width dependant on if the sidebar is expanded or not.
            if (sidebarExpand)
            {
                sidebar.Width -= 10;
                //When the sidebar had reached the minimum size, it will swap the boolean and stop the timer.
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

        //When the menu button is clicked it starts the timer for the sidebar to expand or contract..
        private void btn_menu_Click(object sender, EventArgs e)
        {
            sidebarTimer.Start();
        }

        //Method called when the logout button is clicked.
        private void btn_menu_logout_Click(object sender, EventArgs e)
        {
            //Does a check if the member is still checked in. 
            {
                //Message box that asks if the user wants to check out. If they do it will remove 1 from the members in gym and update the progress bar.
                DialogResult result = MessageBox.Show("Do you want to check out?", "Check Out", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    membersInGym -= 1;
                    progressBarUpdate(membersInGym);
                    checkedInGym = false;
                }
            }

            //Closes the current form and shows the main form.
            this.Close();
            Form1.instance.Show();
        }

        //Opens the events form and closes the current form.
        private void btn_menu_events_Click(object sender, EventArgs e)
        {
            this.Hide();
            memberEvents memberEvents = new memberEvents();
            memberEvents.Show();
        }

        //Opens the billing form and closes the current form.
        private void btn_billing_Click(object sender, EventArgs e)
        {
            this.Hide();
            memberBilling memberBilling = new memberBilling();
            memberBilling.Show();
        }

        //method called when the check in button is clicked.
        private void btn_checkIn_Click(object sender, EventArgs e)
        {
            //Checks if the user is already checked in, if they are it will show a message box and return.
            if (checkedInGym)
            {
                MessageBox.Show("You're already checked in!", "Checked In", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            //Checks if the gym is at capasity, if it is it will show a message box and return.
            if(membersInGym == 100)
            {
                MessageBox.Show("The gym is currently at capasity! Please come back later", "Gym Full!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            //If the user is not checked in and the gym is not at capasity, it will add 1 to the members in gym and update the progress bar.
            membersInGym +=1;
            progressBarUpdate(membersInGym);
            checkedInGym = true;
        }

        //method called when the check out button is clicked.
        private void btn_checkOut_Click(object sender, EventArgs e)
        {
            //Checks if the user is checked in, if they are not it will show a message box and return.
            if (!checkedInGym)
            {
                MessageBox.Show("You're not checked in!", "Not Checked In", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            //If the user is checked in, it will remove 1 from the members in gym and update the progress bar.
            membersInGym -= 1;
            progressBarUpdate(membersInGym);
            checkedInGym = false;
        }

    }
}
