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

namespace gym_c__thing.MemberPortal
{
    public partial class memberBilling : Form
    {
        public memberBilling()
        {
            InitializeComponent();
        }

        private void memberBilling_Load(object sender, EventArgs e)
        {
            string search = memberDash.instance.username;
            string email = null;
            string username = null;
            string memberType = null;
            string name = null;
            int id = 0;


            dbManagerClass dbManagerClass = new dbManagerClass();

           
            //Returns the username, memberType, email, name and id of the member using the username
            (username, memberType, email, name, id) = dbManagerClass.GetMemberInfoUsername(search);

            txt_email.Text = email;
            txt_id.Text = id.ToString();
            txt_name.Text = name;
            txt_memberType.Text = memberType;
            txt_usrname.Text = username;
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Close();
            memberDash.instance.Show();
        }
    }
}
