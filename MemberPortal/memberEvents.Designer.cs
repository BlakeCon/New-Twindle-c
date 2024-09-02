namespace gym_c__thing.MemberPortal
{
    partial class memberEvents
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(memberEvents));
            this.sidebar = new System.Windows.Forms.FlowLayoutPanel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.btn_menu = new System.Windows.Forms.PictureBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btn_home = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btn_menu_events = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.btn_menu_logout = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.sidebarTimer = new System.Windows.Forms.Timer(this.components);
            this.sidebar.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_menu)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // sidebar
            // 
            this.sidebar.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.sidebar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.sidebar.Controls.Add(this.panel3);
            this.sidebar.Controls.Add(this.panel4);
            this.sidebar.Controls.Add(this.panel5);
            this.sidebar.Controls.Add(this.panel6);
            this.sidebar.Location = new System.Drawing.Point(0, 0);
            this.sidebar.MaximumSize = new System.Drawing.Size(268, 680);
            this.sidebar.MinimumSize = new System.Drawing.Size(77, 680);
            this.sidebar.Name = "sidebar";
            this.sidebar.Size = new System.Drawing.Size(77, 680);
            this.sidebar.TabIndex = 3;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.btn_menu);
            this.panel3.Location = new System.Drawing.Point(3, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(265, 117);
            this.panel3.TabIndex = 3;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Modern No. 20", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(98, 48);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 24);
            this.label8.TabIndex = 3;
            this.label8.Text = "Menu";
            // 
            // btn_menu
            // 
            this.btn_menu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_menu.Image = ((System.Drawing.Image)(resources.GetObject("btn_menu.Image")));
            this.btn_menu.Location = new System.Drawing.Point(9, 34);
            this.btn_menu.Name = "btn_menu";
            this.btn_menu.Size = new System.Drawing.Size(45, 45);
            this.btn_menu.TabIndex = 0;
            this.btn_menu.TabStop = false;
            this.btn_menu.Click += new System.EventHandler(this.btn_menu_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btn_home);
            this.panel4.Controls.Add(this.button1);
            this.panel4.Location = new System.Drawing.Point(3, 126);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(265, 70);
            this.panel4.TabIndex = 4;
            // 
            // btn_home
            // 
            this.btn_home.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_home.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_home.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_home.Image = ((System.Drawing.Image)(resources.GetObject("btn_home.Image")));
            this.btn_home.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_home.Location = new System.Drawing.Point(-9, -7);
            this.btn_home.Name = "btn_home";
            this.btn_home.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btn_home.Size = new System.Drawing.Size(282, 85);
            this.btn_home.TabIndex = 4;
            this.btn_home.Text = "Home";
            this.btn_home.UseVisualStyleBackColor = false;
            this.btn_home.Click += new System.EventHandler(this.button4_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(-4, -4);
            this.button1.Name = "button1";
            this.button1.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.button1.Size = new System.Drawing.Size(282, 85);
            this.button1.TabIndex = 3;
            this.button1.Text = "Home";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.btn_menu_events);
            this.panel5.Location = new System.Drawing.Point(3, 202);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(265, 70);
            this.panel5.TabIndex = 5;
            // 
            // btn_menu_events
            // 
            this.btn_menu_events.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_menu_events.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_menu_events.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_menu_events.Image = ((System.Drawing.Image)(resources.GetObject("btn_menu_events.Image")));
            this.btn_menu_events.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_menu_events.Location = new System.Drawing.Point(-4, -6);
            this.btn_menu_events.Name = "btn_menu_events";
            this.btn_menu_events.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btn_menu_events.Size = new System.Drawing.Size(282, 85);
            this.btn_menu_events.TabIndex = 4;
            this.btn_menu_events.Text = "Events";
            this.btn_menu_events.UseVisualStyleBackColor = false;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.btn_menu_logout);
            this.panel6.Location = new System.Drawing.Point(3, 278);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(265, 70);
            this.panel6.TabIndex = 6;
            // 
            // btn_menu_logout
            // 
            this.btn_menu_logout.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_menu_logout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_menu_logout.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_menu_logout.Image = ((System.Drawing.Image)(resources.GetObject("btn_menu_logout.Image")));
            this.btn_menu_logout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_menu_logout.Location = new System.Drawing.Point(-4, -10);
            this.btn_menu_logout.Name = "btn_menu_logout";
            this.btn_menu_logout.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btn_menu_logout.Size = new System.Drawing.Size(282, 85);
            this.btn_menu_logout.TabIndex = 5;
            this.btn_menu_logout.Text = "Log Out";
            this.btn_menu_logout.UseVisualStyleBackColor = false;
            this.btn_menu_logout.Click += new System.EventHandler(this.btn_menu_logout_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(124, 38);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1116, 622);
            this.dataGridView1.TabIndex = 4;
            // 
            // sidebarTimer
            // 
            this.sidebarTimer.Interval = 10;
            this.sidebarTimer.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // memberEvents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.sidebar);
            this.Controls.Add(this.dataGridView1);
            this.Name = "memberEvents";
            this.Text = "memberEvents";
            this.Load += new System.EventHandler(this.memberEvents_Load);
            this.sidebar.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_menu)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel sidebar;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox btn_menu;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btn_home;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button btn_menu_events;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button btn_menu_logout;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Timer sidebarTimer;
    }
}