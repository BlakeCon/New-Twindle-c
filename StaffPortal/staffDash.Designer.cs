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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_id = new System.Windows.Forms.Label();
            this.lbl_user = new System.Windows.Forms.Label();
            this.lbl_secLvl = new System.Windows.Forms.Label();
            this.lbl_superuser = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.lbl_superuser);
            this.panel1.Controls.Add(this.lbl_secLvl);
            this.panel1.Controls.Add(this.lbl_user);
            this.panel1.Controls.Add(this.lbl_id);
            this.panel1.Location = new System.Drawing.Point(0, 640);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1288, 44);
            this.panel1.TabIndex = 0;
            // 
            // lbl_id
            // 
            this.lbl_id.AutoSize = true;
            this.lbl_id.Location = new System.Drawing.Point(14, 15);
            this.lbl_id.Name = "lbl_id";
            this.lbl_id.Size = new System.Drawing.Size(34, 13);
            this.lbl_id.TabIndex = 0;
            this.lbl_id.Text = "Id: 00";
            // 
            // lbl_user
            // 
            this.lbl_user.AutoSize = true;
            this.lbl_user.Location = new System.Drawing.Point(124, 15);
            this.lbl_user.Name = "lbl_user";
            this.lbl_user.Size = new System.Drawing.Size(74, 13);
            this.lbl_user.TabIndex = 1;
            this.lbl_user.Text = "User: Admin A";
            // 
            // lbl_secLvl
            // 
            this.lbl_secLvl.AutoSize = true;
            this.lbl_secLvl.Location = new System.Drawing.Point(254, 15);
            this.lbl_secLvl.Name = "lbl_secLvl";
            this.lbl_secLvl.Size = new System.Drawing.Size(111, 13);
            this.lbl_secLvl.TabIndex = 2;
            this.lbl_secLvl.Text = "Security Level: NONE";
            // 
            // lbl_superuser
            // 
            this.lbl_superuser.AutoSize = true;
            this.lbl_superuser.Location = new System.Drawing.Point(403, 15);
            this.lbl_superuser.Name = "lbl_superuser";
            this.lbl_superuser.Size = new System.Drawing.Size(79, 13);
            this.lbl_superuser.TabIndex = 3;
            this.lbl_superuser.Text = "Superuser: Yes";
            // 
            // staffDash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.panel1);
            this.Name = "staffDash";
            this.Text = "staffDash";
            this.Load += new System.EventHandler(this.staffDash_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_secLvl;
        private System.Windows.Forms.Label lbl_user;
        private System.Windows.Forms.Label lbl_id;
        private System.Windows.Forms.Label lbl_superuser;
    }
}