﻿namespace gym_c__thing
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
            this.btn_memberLogin = new System.Windows.Forms.Button();
            this.btn_register = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_staffLogin = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_memberLogin
            // 
            this.btn_memberLogin.BackColor = System.Drawing.Color.Transparent;
            this.btn_memberLogin.Location = new System.Drawing.Point(77, 311);
            this.btn_memberLogin.Name = "btn_memberLogin";
            this.btn_memberLogin.Size = new System.Drawing.Size(304, 166);
            this.btn_memberLogin.TabIndex = 1;
            this.btn_memberLogin.Text = "Member Login";
            this.btn_memberLogin.UseVisualStyleBackColor = false;
            this.btn_memberLogin.Click += new System.EventHandler(this.btn_memLogin_Click);
            // 
            // btn_register
            // 
            this.btn_register.BackColor = System.Drawing.Color.Transparent;
            this.btn_register.Location = new System.Drawing.Point(454, 311);
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
            this.label2.Location = new System.Drawing.Point(450, 235);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(300, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "Welcome! Please select an option: ";
            // 
            // btn_staffLogin
            // 
            this.btn_staffLogin.BackColor = System.Drawing.Color.Transparent;
            this.btn_staffLogin.Location = new System.Drawing.Point(869, 311);
            this.btn_staffLogin.Name = "btn_staffLogin";
            this.btn_staffLogin.Size = new System.Drawing.Size(304, 166);
            this.btn_staffLogin.TabIndex = 4;
            this.btn_staffLogin.Text = "Staff Login";
            this.btn_staffLogin.UseVisualStyleBackColor = false;
            this.btn_staffLogin.Click += new System.EventHandler(this.btn_staff_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(454, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(304, 192);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_staffLogin);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_register);
            this.Controls.Add(this.btn_memberLogin);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_memberLogin;
        private System.Windows.Forms.Button btn_register;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_staffLogin;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

