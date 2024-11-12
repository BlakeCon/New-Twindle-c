using gym_c__thing.Classes;
using gym_c__thing.Logins;
using System;
using System.Windows.Forms;

//comment!!
namespace gym_c__thing.StaffPortal
{
    public partial class staffDash : Form
    {
        public static staffDash instance;
        string staffId = staffLogin.instance.idText.Text;

        public staffDash()
        {
            InitializeComponent();
            instance = this;
        }

        private void staffDash_Load(object sender, EventArgs e)
        {
            //Adding all user details to the bottom using concatination 

            staffDbManager dbManager = new staffDbManager();

            
            
            staffLogin.instance.Close();

            (string user, string position, bool EventsPerm, bool superuser) = dbManager.GetStaffInfo(staffId);

            lbl_id.Text = "ID: " + staffId;
            lbl_secLvl.Text = "Security Level : " + position;
            lbl_user.Text = "User: " + user;
            
            if (superuser) {
                lbl_superuser.Text = "Superuser: Yes";
            } 
            else 
            {
                lbl_superuser.Text = "Superuser: No";
            }
        }

        private void btn_manageUser_Click(object sender, EventArgs e)
        {
            this.Hide();
            manageMember manageMember = new manageMember();
            manageMember.Show();
        }

        private void btn_Events_Click(object sender, EventArgs e)
        {
            staffDbManager dbManager = new staffDbManager();
            (string user, string position, bool EventsPerm, bool superuser) = dbManager.GetStaffInfo(staffId);
            if (EventsPerm)
            {
                this.Hide();
                manageEvents manageEvents = new manageEvents();
                manageEvents.Show();
            }
            else
            {
                MessageBox.Show("You do not have permission to access this page");
            }
        }

        private void btn_manageStaff_Click(object sender, EventArgs e)
        {
            staffDbManager dbManager = new staffDbManager();
            (string user, string position, bool EventsPerm, bool superuser) = dbManager.GetStaffInfo(staffId);
            if (superuser)
            {
                this.Hide();
                manageStaff manageStaff = new manageStaff();
                manageStaff.Show();
            }
            else
            {
                MessageBox.Show("You do not have permission to access this page");
            }
        }

        private void btn_menu_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void btn_manageEvents_Click(object sender, EventArgs e)
        {

        }

        private void btn_stats_Click(object sender, EventArgs e)
        {

        }

        private void btn_logout_Click_1(object sender, EventArgs e)
        {
            this.Close();
            Form1.instance.Show();
        }
    }
}
