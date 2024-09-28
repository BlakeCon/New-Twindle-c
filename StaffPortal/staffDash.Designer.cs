namespace gym_c__thing.StaffPortal
{
    partial class staffDash
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(staffDash));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_logout = new System.Windows.Forms.Button();
            this.lbl_superuser = new System.Windows.Forms.Label();
            this.lbl_secLvl = new System.Windows.Forms.Label();
            this.lbl_user = new System.Windows.Forms.Label();
            this.lbl_id = new System.Windows.Forms.Label();
            this.btn_manageUser = new System.Windows.Forms.Button();
            this.btn_Events = new System.Windows.Forms.Button();
            this.btn_manageStaff = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.btn_logout);
            this.panel1.Controls.Add(this.lbl_superuser);
            this.panel1.Controls.Add(this.lbl_secLvl);
            this.panel1.Controls.Add(this.lbl_user);
            this.panel1.Controls.Add(this.lbl_id);
            this.panel1.Location = new System.Drawing.Point(0, 640);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1288, 44);
            this.panel1.TabIndex = 0;
            // 
            // btn_logout
            // 
            this.btn_logout.Location = new System.Drawing.Point(12, 13);
            this.btn_logout.Name = "btn_logout";
            this.btn_logout.Size = new System.Drawing.Size(75, 23);
            this.btn_logout.TabIndex = 4;
            this.btn_logout.Text = "Logout";
            this.btn_logout.UseVisualStyleBackColor = true;
            this.btn_logout.Click += new System.EventHandler(this.btn_logout_Click);
            // 
            // lbl_superuser
            // 
            this.lbl_superuser.AutoSize = true;
            this.lbl_superuser.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_superuser.Location = new System.Drawing.Point(1148, 16);
            this.lbl_superuser.Name = "lbl_superuser";
            this.lbl_superuser.Size = new System.Drawing.Size(99, 16);
            this.lbl_superuser.TabIndex = 3;
            this.lbl_superuser.Text = "Superuser: Yes";
            // 
            // lbl_secLvl
            // 
            this.lbl_secLvl.AutoSize = true;
            this.lbl_secLvl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_secLvl.Location = new System.Drawing.Point(999, 16);
            this.lbl_secLvl.Name = "lbl_secLvl";
            this.lbl_secLvl.Size = new System.Drawing.Size(136, 16);
            this.lbl_secLvl.TabIndex = 2;
            this.lbl_secLvl.Text = "Security Level: NONE";
            // 
            // lbl_user
            // 
            this.lbl_user.AutoSize = true;
            this.lbl_user.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_user.Location = new System.Drawing.Point(869, 16);
            this.lbl_user.Name = "lbl_user";
            this.lbl_user.Size = new System.Drawing.Size(92, 16);
            this.lbl_user.TabIndex = 1;
            this.lbl_user.Text = "User: Admin A";
            // 
            // lbl_id
            // 
            this.lbl_id.AutoSize = true;
            this.lbl_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_id.Location = new System.Drawing.Point(759, 16);
            this.lbl_id.Name = "lbl_id";
            this.lbl_id.Size = new System.Drawing.Size(38, 16);
            this.lbl_id.TabIndex = 0;
            this.lbl_id.Text = "Id: 00";
            // 
            // btn_manageUser
            // 
            this.btn_manageUser.Image = ((System.Drawing.Image)(resources.GetObject("btn_manageUser.Image")));
            this.btn_manageUser.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_manageUser.Location = new System.Drawing.Point(217, 120);
            this.btn_manageUser.Name = "btn_manageUser";
            this.btn_manageUser.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btn_manageUser.Size = new System.Drawing.Size(422, 222);
            this.btn_manageUser.TabIndex = 1;
            this.btn_manageUser.Text = "Manage Users";
            this.btn_manageUser.UseVisualStyleBackColor = true;
            this.btn_manageUser.Click += new System.EventHandler(this.btn_manageUser_Click);
            // 
            // btn_Events
            // 
            this.btn_Events.Image = ((System.Drawing.Image)(resources.GetObject("btn_Events.Image")));
            this.btn_Events.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Events.Location = new System.Drawing.Point(762, 120);
            this.btn_Events.Name = "btn_Events";
            this.btn_Events.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btn_Events.Size = new System.Drawing.Size(422, 222);
            this.btn_Events.TabIndex = 2;
            this.btn_Events.Text = "Manage Events";
            this.btn_Events.UseVisualStyleBackColor = true;
            this.btn_Events.Click += new System.EventHandler(this.btn_Events_Click);
            // 
            // btn_manageStaff
            // 
            this.btn_manageStaff.Image = ((System.Drawing.Image)(resources.GetObject("btn_manageStaff.Image")));
            this.btn_manageStaff.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_manageStaff.Location = new System.Drawing.Point(217, 399);
            this.btn_manageStaff.Name = "btn_manageStaff";
            this.btn_manageStaff.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btn_manageStaff.Size = new System.Drawing.Size(422, 222);
            this.btn_manageStaff.TabIndex = 3;
            this.btn_manageStaff.Text = "Manage Staff";
            this.btn_manageStaff.UseVisualStyleBackColor = true;
            this.btn_manageStaff.Click += new System.EventHandler(this.btn_manageStaff_Click);
            // 
            // button1
            // 
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(762, 399);
            this.button1.Name = "button1";
            this.button1.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.button1.Size = new System.Drawing.Size(422, 222);
            this.button1.TabIndex = 4;
            this.button1.Text = "Generate Gym Statisitcs Report";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(211, 159);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // staffDash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_manageStaff);
            this.Controls.Add(this.btn_Events);
            this.Controls.Add(this.btn_manageUser);
            this.Controls.Add(this.panel1);
            this.Name = "staffDash";
            this.Text = "Staff Portal";
            this.Load += new System.EventHandler(this.staffDash_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_secLvl;
        private System.Windows.Forms.Label lbl_user;
        private System.Windows.Forms.Label lbl_id;
        private System.Windows.Forms.Label lbl_superuser;
        private System.Windows.Forms.Button btn_manageUser;
        private System.Windows.Forms.Button btn_Events;
        private System.Windows.Forms.Button btn_manageStaff;
        private System.Windows.Forms.Button btn_logout;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}