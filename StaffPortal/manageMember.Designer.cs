namespace gym_c__thing.StaffPortal
{
    partial class manageMember
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
            this.btn_usrnameSearch = new System.Windows.Forms.Button();
            this.btn_nameSearch = new System.Windows.Forms.Button();
            this.btn_idSearch = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_search = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_back = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.btn_usrnameSearch);
            this.panel1.Controls.Add(this.btn_nameSearch);
            this.panel1.Controls.Add(this.btn_idSearch);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txt_search);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(22, 22);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1203, 622);
            this.panel1.TabIndex = 3;
            // 
            // btn_usrnameSearch
            // 
            this.btn_usrnameSearch.Location = new System.Drawing.Point(646, 340);
            this.btn_usrnameSearch.Margin = new System.Windows.Forms.Padding(2);
            this.btn_usrnameSearch.Name = "btn_usrnameSearch";
            this.btn_usrnameSearch.Size = new System.Drawing.Size(171, 72);
            this.btn_usrnameSearch.TabIndex = 17;
            this.btn_usrnameSearch.Text = "Seach Username";
            this.btn_usrnameSearch.UseVisualStyleBackColor = true;
            this.btn_usrnameSearch.Click += new System.EventHandler(this.btn_usrnameSearch_Click);
            // 
            // btn_nameSearch
            // 
            this.btn_nameSearch.Location = new System.Drawing.Point(471, 340);
            this.btn_nameSearch.Margin = new System.Windows.Forms.Padding(2);
            this.btn_nameSearch.Name = "btn_nameSearch";
            this.btn_nameSearch.Size = new System.Drawing.Size(171, 72);
            this.btn_nameSearch.TabIndex = 16;
            this.btn_nameSearch.Text = "Search Name";
            this.btn_nameSearch.UseVisualStyleBackColor = true;
            this.btn_nameSearch.Click += new System.EventHandler(this.btn_nameSearch_Click);
            // 
            // btn_idSearch
            // 
            this.btn_idSearch.Location = new System.Drawing.Point(296, 340);
            this.btn_idSearch.Margin = new System.Windows.Forms.Padding(2);
            this.btn_idSearch.Name = "btn_idSearch";
            this.btn_idSearch.Size = new System.Drawing.Size(171, 72);
            this.btn_idSearch.TabIndex = 15;
            this.btn_idSearch.Text = "Search ID";
            this.btn_idSearch.UseVisualStyleBackColor = true;
            this.btn_idSearch.Click += new System.EventHandler(this.btn_idSearch_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(479, 242);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(167, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "Id / Name / Username:";
            // 
            // txt_search
            // 
            this.txt_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_search.Location = new System.Drawing.Point(378, 285);
            this.txt_search.Name = "txt_search";
            this.txt_search.Size = new System.Drawing.Size(368, 32);
            this.txt_search.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Impact", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(465, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Find Member";
            // 
            // btn_back
            // 
            this.btn_back.Location = new System.Drawing.Point(10, 650);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(88, 25);
            this.btn_back.TabIndex = 5;
            this.btn_back.Text = "Back";
            this.btn_back.UseVisualStyleBackColor = true;
            // 
            // manageMember
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_back);
            this.Name = "manageMember";
            this.Text = "manageMember";
            this.Load += new System.EventHandler(this.manageMember_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txt_search;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_nameSearch;
        private System.Windows.Forms.Button btn_idSearch;
        private System.Windows.Forms.Button btn_usrnameSearch;
    }
}