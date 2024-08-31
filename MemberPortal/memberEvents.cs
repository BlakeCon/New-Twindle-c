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
    public partial class memberEvents : Form
    {
        bool sidebarExpand;

        public memberEvents()
        {
            InitializeComponent();
        }

        private void memberEvents_Load(object sender, EventArgs e)
        {
            dataGridView1.Columns.Add("Column1", "Column 1");
            dataGridView1.Columns.Add("Column2", "Column 2");
            

            dbManagerClass dbManager = new dbManagerClass();
            List<List<string>> events = dbManager.GetEvents();

            foreach (List<string> eventData in events)
            {
                string column1Value = eventData[0];
                string column2Value = eventData[1];

                dataGridView1.Rows.Add(column1Value, column2Value);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
            memberDash.instance.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
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
            memberLogin.instnace.Close();
            this.Close();
            Form1.instance.Show();
        }

    }
}
