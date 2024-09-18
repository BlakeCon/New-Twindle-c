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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace gym_c__thing.StaffPortal
{
    public partial class manageMember : Form
    {
        public static manageMember instance = new manageMember();
        //Making these public so that it can be accessed from the memberViewerStaff form
        public string searchMethod;
        public TextBox searchBox;
        public manageMember()
        {
            InitializeComponent();
            instance = this;
            //Declaring the searchMethod and searchBox variables
            searchMethod = null;
            searchBox = txt_search;
        }

        private void btn_idSearch_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This wont work yet, need to Parse it as an int lol");
            int Id = 0;
            //Returns the username, memberType, email, name and id of the member using the id
            (string username, string memberType, string email, string name, int idReturner) = dbManagerClass.GetMemberInfoId(Id);
        }

        private void btn_nameSearch_Click(object sender, EventArgs e)
        {
            searchMethod = "name";
            dbManagerClass dbManagerClass = new dbManagerClass();
            //Returns the username, memberType, email, name and id of the member using the name
            (string usrNotused, string memberType, string email, string nameReturner, int id) = dbManagerClass.GetMemberInfoName(name);
        }

        private void btn_usrnameSearch_Click(object sender, EventArgs e)
        {
            searchMethod = "username";
            dbManagerClass dbManagerClass = new dbManagerClass();
            //Returns the username, memberType, email, name and id of the member using the username
            (string usernameReturner, string memberType, string email, string name, int id) = dbManagerClass.GetMemberInfoUsername(username);
        }
    }
}
