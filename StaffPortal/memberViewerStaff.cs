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
            string email = null;
            string username = null;
            string memberType = null;
            string name = null;
            int id = 0;
            

            dbManagerClass dbManagerClass = new dbManagerClass();
            if (searchMethod == "name")
            {
                //Returns the username, memberType, email, name and id of the member using the name
                (username, memberType, email, name, id) = dbManagerClass.GetMemberInfoName(search);
            }
                
            if (searchMethod == "id")
            {
                //Returns the username, memberType, email, name and id of the member using the id
                (username, memberType, email, name, id) = dbManagerClass.GetMemberInfoId(Int32.Parse(search));
            }
                
            if (searchMethod == "username")
            {
                //Returns the username, memberType, email, name and id of the member using the username
                (username, memberType, email, name, id) = dbManagerClass.GetMemberInfoUsername(search);
            }
                
            txt_email.Text = email;
            txt_id.Text = id.ToString();
            txt_name.Text = name;
            txt_memberType.Text = memberType;
            txt_usrname.Text = username;

        }
    }
}
