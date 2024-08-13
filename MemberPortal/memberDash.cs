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

namespace gym_c__thing.MemberPortal
{
    public partial class memberDash : Form
    {
        public memberDash()
        {
            InitializeComponent();
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



            string username = memberLogin.instnace.usernameTxtBxt.Text;
            lbl_usrName.Text = username;

            dbManagerClass dbManagerClass = new dbManagerClass();
            (string usrNotused, string memberType) = dbManagerClass.GetMemberInfo(username);

            lbl_memberType.Text = memberType;
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
