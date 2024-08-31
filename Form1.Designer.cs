namespace gym_c__thing
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.btn_memLogin = new System.Windows.Forms.Button();
            this.btn_register = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_staff = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(228, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(717, 119);
            this.label1.TabIndex = 0;
            this.label1.Text = "TWINDLE GYM";
            // 
            // btn_memLogin
            // 
            this.btn_memLogin.BackColor = System.Drawing.Color.Transparent;
            this.btn_memLogin.Location = new System.Drawing.Point(217, 222);
            this.btn_memLogin.Name = "btn_memLogin";
            this.btn_memLogin.Size = new System.Drawing.Size(304, 166);
            this.btn_memLogin.TabIndex = 1;
            this.btn_memLogin.Text = "Member Login";
            this.btn_memLogin.UseVisualStyleBackColor = false;
            this.btn_memLogin.Click += new System.EventHandler(this.btn_memLogin_Click);
            // 
            // btn_register
            // 
            this.btn_register.BackColor = System.Drawing.Color.Transparent;
            this.btn_register.Location = new System.Drawing.Point(449, 416);
            this.btn_register.Name = "btn_register";
            this.btn_register.Size = new System.Drawing.Size(304, 166);
            this.btn_register.TabIndex = 2;
            this.btn_register.Text = "Register Today!";
            this.btn_register.UseVisualStyleBackColor = false;
            this.btn_register.Click += new System.EventHandler(this.btn_register_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(422, 171);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(300, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "Welcome! Please select an option: ";
            // 
            // btn_staff
            // 
            this.btn_staff.BackColor = System.Drawing.Color.Transparent;
            this.btn_staff.Location = new System.Drawing.Point(602, 222);
            this.btn_staff.Name = "btn_staff";
            this.btn_staff.Size = new System.Drawing.Size(304, 166);
            this.btn_staff.TabIndex = 4;
            this.btn_staff.Text = "Staff Login";
            this.btn_staff.UseVisualStyleBackColor = false;
            this.btn_staff.Click += new System.EventHandler(this.btn_staff_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.btn_staff);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_register);
            this.Controls.Add(this.btn_memLogin);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_memLogin;
        private System.Windows.Forms.Button btn_register;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_staff;
    }
}

