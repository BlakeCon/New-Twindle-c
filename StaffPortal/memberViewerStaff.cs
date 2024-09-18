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
using System.Xml.Linq;


namespace gym_c__thing.StaffPortal
{
    public partial class memberViewerStaff : Form
    {
        
        public memberViewerStaff()
        {
            InitializeComponent();
        }
        
        private void memberViewerStaff_Load(object sender, EventArgs e)
        {
            string searchMethod = manageMember.instance.searchMethod;
            string search = manageMember.instance.searchBox.Text;
            dbManagerClass dbManagerClass = new dbManagerClass();
            if (searchMethod == "name")
                //Returns the username, memberType, email, name and id of the member using the name
                (string usrNotused, string memberType, string email, string nameReturner, int id) = dbManagerClass.GetMemberInfoName(search);
            if (searchMethod == "id")
                //Returns the username, memberType, email, name and id of the member using the id
                (string username, string memberType, string email, string name, int idReturner) = dbManagerClass.GetMemberInfoId(Int32.Parse(search));
            if (searchMethod == "username")
                //Returns the username, memberType, email, name and id of the member using the username
                (string usernameReturner, string memberType, string email, string name, int id) = dbManagerClass.GetMemberInfoUsername(search);

        }
    }
}
