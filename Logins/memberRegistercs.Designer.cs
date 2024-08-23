namespace gym_c__thing.Logins
{
    partial class memberRegistercs
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
            this.txt_username = new System.Windows.Forms.TextBox();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.lbl_Username = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_password = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_memberType = new System.Windows.Forms.ComboBox();
            this.btn_submit = new System.Windows.Forms.Button();
            this.btn_back = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_username
            // 
            this.txt_username.Location = new System.Drawing.Point(446, 181);
            this.txt_username.Name = "txt_username";
            this.txt_username.Size = new System.Drawing.Size(366, 20);
            this.txt_username.TabIndex = 0;
            // 
            // txt_email
            // 
            this.txt_email.Location = new System.Drawing.Point(446, 228);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(366, 20);
            this.txt_email.TabIndex = 2;
            // 
            // lbl_Username
            // 
            this.lbl_Username.AutoSize = true;
            this.lbl_Username.Location = new System.Drawing.Point(296, 181);
            this.lbl_Username.Name = "lbl_Username";
            this.lbl_Username.Size = new System.Drawing.Size(61, 13);
            this.lbl_Username.TabIndex = 3;
            this.lbl_Username.Text = "Username: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(296, 228);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Email: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(296, 273);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Password: ";
            // 
            // txt_password
            // 
            this.txt_password.Location = new System.Drawing.Point(446, 273);
            this.txt_password.Name = "txt_password";
            this.txt_password.Size = new System.Drawing.Size(366, 20);
            this.txt_password.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(296, 321);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Membership Type:";
            // 
            // txt_memberType
            // 
            this.txt_memberType.FormattingEnabled = true;
            this.txt_memberType.Items.AddRange(new object[] {
            "Basic",
            "Day Pass",
            "Premium"});
            this.txt_memberType.Location = new System.Drawing.Point(446, 318);
            this.txt_memberType.Name = "txt_memberType";
            this.txt_memberType.Size = new System.Drawing.Size(366, 21);
            this.txt_memberType.TabIndex = 9;
            this.txt_memberType.Text = "Select A Membership Type";
            // 
            // btn_submit
            // 
            this.btn_submit.Location = new System.Drawing.Point(520, 392);
            this.btn_submit.Name = "btn_submit";
            this.btn_submit.Size = new System.Drawing.Size(75, 23);
            this.btn_submit.TabIndex = 10;
            this.btn_submit.Text = "Submit";
            this.btn_submit.UseVisualStyleBackColor = true;
            this.btn_submit.Click += new System.EventHandler(this.btn_submit_Click);
            // 
            // btn_back
            // 
            this.btn_back.Location = new System.Drawing.Point(12, 646);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(75, 23);
            this.btn_back.TabIndex = 11;
            this.btn_back.Text = "Back";
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // memberRegistercs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.btn_submit);
            this.Controls.Add(this.txt_memberType);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_password);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbl_Username);
            this.Controls.Add(this.txt_email);
            this.Controls.Add(this.txt_username);
            this.Name = "memberRegistercs";
            this.Text = "memberRegistercs";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_username;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.Label lbl_Username;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_password;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox txt_memberType;
        private System.Windows.Forms.Button btn_submit;
        private System.Windows.Forms.Button btn_back;
    }
}