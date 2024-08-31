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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace gym_c__thing.StaffPortal
{
    public partial class staffDash : Form
    {
        public staffDash()
        {
            InitializeComponent();
        }

        private void staffDash_Load(object sender, EventArgs e)
        {
            //Adding all user details to the bottom 

            staffDbManager dbManager = new staffDbManager();

            string id = staffLogin.instance.idText.Text;
            
            staffLogin.instance.Close();

            (string user, string position, bool EventsPerm, bool superuser) = dbManager.GetStaffInfo(id);

            lbl_id.Text = "ID: " + id;
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
    }
}
