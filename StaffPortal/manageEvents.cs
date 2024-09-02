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

namespace gym_c__thing.StaffPortal
{
    public partial class manageEvents : Form
    {
        public manageEvents()
        {
            InitializeComponent();
        }

        private void manageEvents_Load(object sender, EventArgs e)
        {

        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            staffDbManager DbManager = new staffDbManager();
            int id = DbManager.getLatesEventID();

            id = id + 1;
            string name = txt_name.Text;
            string info = txt_info.Text;
            string expiry = txt_expiry.Text;

            bool result = DbManager.AddEvent(id, name, info, expiry);
            if (result)
            {
                MessageBox.Show("Event Added");
            }
            else
            {
                MessageBox.Show("Event not added");
            }
        }

        private void btn_remove_Click(object sender, EventArgs e)
        {
            staffDbManager DbManager = new staffDbManager();
            int id;
            bool result;
            if (int.TryParse(txt_id.Text, out id))
            {
                result = DbManager.RemoveEvent(id);
                if (result)
                {
                    MessageBox.Show("Event Removed");
                }
                else
                {
                    MessageBox.Show("Event not removed");
                }
            }
            else
            {
                MessageBox.Show("Invalid ID");
            }
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Close();
            staffDash.instance.Show();
        }
    }
}
