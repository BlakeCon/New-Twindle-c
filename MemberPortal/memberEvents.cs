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

namespace gym_c__thing.MemberPortal
{
    public partial class memberEvents : Form
    {
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
    }
}
