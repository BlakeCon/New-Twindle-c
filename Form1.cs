﻿using gym_c__thing.Logins;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gym_c__thing
{
    public partial class Form1 : Form
    {
        public static Form1 instance;
        public Form1()
        {
            InitializeComponent();
            instance = this;
        }

        private void btn_memLogin_Click(object sender, EventArgs e)
        {
            memberLogin memberlogin = new memberLogin();
            memberlogin.Show();
            this.Hide();
        }

        private void btn_register_Click(object sender, EventArgs e)
        {
            memberRegistercs memberRegistercs = new memberRegistercs();
            memberRegistercs.Show();
            this.Hide();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_staff_Click(object sender, EventArgs e)
        {
            this.Hide();
            staffLogin staffLogin = new staffLogin();
            staffLogin.Show();
        }
    }
}