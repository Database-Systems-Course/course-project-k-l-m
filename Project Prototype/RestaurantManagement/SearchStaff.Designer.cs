﻿namespace RestaurantManagement
{
    partial class SearchStaff
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
            this.datetimepicker_HiringDate = new System.Windows.Forms.DateTimePicker();
            this.textbox_DailyWorkHours = new System.Windows.Forms.TextBox();
            this.textbox_JobTitle = new System.Windows.Forms.TextBox();
            this.textbox_BranchID = new System.Windows.Forms.TextBox();
            this.textbox_LastName = new System.Windows.Forms.TextBox();
            this.textbox_FirstName = new System.Windows.Forms.TextBox();
            this.textbox_NIC = new System.Windows.Forms.TextBox();
            this.button_Search_Staff = new System.Windows.Forms.Button();
            this.label_DailyWorkHours = new System.Windows.Forms.Label();
            this.label_HiringDate = new System.Windows.Forms.Label();
            this.label_JobTitle = new System.Windows.Forms.Label();
            this.label_BranchID = new System.Windows.Forms.Label();
            this.label_LastName = new System.Windows.Forms.Label();
            this.label_FirstName = new System.Windows.Forms.Label();
            this.label_NIC = new System.Windows.Forms.Label();
            this.label_Search_Staff = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button_BackToMenu = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // datetimepicker_HiringDate
            // 
            this.datetimepicker_HiringDate.Location = new System.Drawing.Point(133, 262);
            this.datetimepicker_HiringDate.Name = "datetimepicker_HiringDate";
            this.datetimepicker_HiringDate.Size = new System.Drawing.Size(177, 20);
            this.datetimepicker_HiringDate.TabIndex = 31;
            this.datetimepicker_HiringDate.ValueChanged += new System.EventHandler(this.datetimepicker_HiringDate_ValueChanged);
            // 
            // textbox_DailyWorkHours
            // 
            this.textbox_DailyWorkHours.Location = new System.Drawing.Point(133, 299);
            this.textbox_DailyWorkHours.Name = "textbox_DailyWorkHours";
            this.textbox_DailyWorkHours.Size = new System.Drawing.Size(177, 20);
            this.textbox_DailyWorkHours.TabIndex = 30;
            // 
            // textbox_JobTitle
            // 
            this.textbox_JobTitle.Location = new System.Drawing.Point(133, 226);
            this.textbox_JobTitle.Name = "textbox_JobTitle";
            this.textbox_JobTitle.Size = new System.Drawing.Size(177, 20);
            this.textbox_JobTitle.TabIndex = 29;
            // 
            // textbox_BranchID
            // 
            this.textbox_BranchID.Location = new System.Drawing.Point(133, 192);
            this.textbox_BranchID.Name = "textbox_BranchID";
            this.textbox_BranchID.Size = new System.Drawing.Size(177, 20);
            this.textbox_BranchID.TabIndex = 28;
            // 
            // textbox_LastName
            // 
            this.textbox_LastName.Location = new System.Drawing.Point(133, 158);
            this.textbox_LastName.Name = "textbox_LastName";
            this.textbox_LastName.Size = new System.Drawing.Size(177, 20);
            this.textbox_LastName.TabIndex = 27;
            // 
            // textbox_FirstName
            // 
            this.textbox_FirstName.Location = new System.Drawing.Point(133, 127);
            this.textbox_FirstName.Name = "textbox_FirstName";
            this.textbox_FirstName.Size = new System.Drawing.Size(177, 20);
            this.textbox_FirstName.TabIndex = 26;
            // 
            // textbox_NIC
            // 
            this.textbox_NIC.Location = new System.Drawing.Point(133, 91);
            this.textbox_NIC.Name = "textbox_NIC";
            this.textbox_NIC.Size = new System.Drawing.Size(177, 20);
            this.textbox_NIC.TabIndex = 25;
            this.textbox_NIC.TextChanged += new System.EventHandler(this.textbox_NIC_TextChanged);
            // 
            // button_Search_Staff
            // 
            this.button_Search_Staff.Location = new System.Drawing.Point(235, 334);
            this.button_Search_Staff.Name = "button_Search_Staff";
            this.button_Search_Staff.Size = new System.Drawing.Size(75, 23);
            this.button_Search_Staff.TabIndex = 24;
            this.button_Search_Staff.Text = "Search ";
            this.button_Search_Staff.UseVisualStyleBackColor = true;
            this.button_Search_Staff.Click += new System.EventHandler(this.button_Search_Staff_Click);
            // 
            // label_DailyWorkHours
            // 
            this.label_DailyWorkHours.AutoSize = true;
            this.label_DailyWorkHours.Location = new System.Drawing.Point(37, 302);
            this.label_DailyWorkHours.Name = "label_DailyWorkHours";
            this.label_DailyWorkHours.Size = new System.Drawing.Size(93, 13);
            this.label_DailyWorkHours.TabIndex = 23;
            this.label_DailyWorkHours.Text = "Daily Work Hours:";
            this.label_DailyWorkHours.Click += new System.EventHandler(this.label_DailyWorkHours_Click);
            // 
            // label_HiringDate
            // 
            this.label_HiringDate.AutoSize = true;
            this.label_HiringDate.Location = new System.Drawing.Point(37, 268);
            this.label_HiringDate.Name = "label_HiringDate";
            this.label_HiringDate.Size = new System.Drawing.Size(63, 13);
            this.label_HiringDate.TabIndex = 22;
            this.label_HiringDate.Text = "Hiring Date:";
            this.label_HiringDate.Click += new System.EventHandler(this.label_HiringDate_Click);
            // 
            // label_JobTitle
            // 
            this.label_JobTitle.AutoSize = true;
            this.label_JobTitle.Location = new System.Drawing.Point(37, 229);
            this.label_JobTitle.Name = "label_JobTitle";
            this.label_JobTitle.Size = new System.Drawing.Size(50, 13);
            this.label_JobTitle.TabIndex = 21;
            this.label_JobTitle.Text = "Job Title:";
            this.label_JobTitle.Click += new System.EventHandler(this.label_JobTitle_Click);
            // 
            // label_BranchID
            // 
            this.label_BranchID.AutoSize = true;
            this.label_BranchID.Location = new System.Drawing.Point(37, 195);
            this.label_BranchID.Name = "label_BranchID";
            this.label_BranchID.Size = new System.Drawing.Size(58, 13);
            this.label_BranchID.TabIndex = 20;
            this.label_BranchID.Text = "Branch ID:";
            this.label_BranchID.Click += new System.EventHandler(this.label_BranchID_Click);
            // 
            // label_LastName
            // 
            this.label_LastName.AutoSize = true;
            this.label_LastName.Location = new System.Drawing.Point(37, 161);
            this.label_LastName.Name = "label_LastName";
            this.label_LastName.Size = new System.Drawing.Size(61, 13);
            this.label_LastName.TabIndex = 19;
            this.label_LastName.Text = "Last Name:";
            this.label_LastName.Click += new System.EventHandler(this.label_LastName_Click);
            // 
            // label_FirstName
            // 
            this.label_FirstName.AutoSize = true;
            this.label_FirstName.Location = new System.Drawing.Point(37, 130);
            this.label_FirstName.Name = "label_FirstName";
            this.label_FirstName.Size = new System.Drawing.Size(60, 13);
            this.label_FirstName.TabIndex = 18;
            this.label_FirstName.Text = "First Name:";
            this.label_FirstName.Click += new System.EventHandler(this.label_FirstName_Click);
            // 
            // label_NIC
            // 
            this.label_NIC.AutoSize = true;
            this.label_NIC.Location = new System.Drawing.Point(37, 94);
            this.label_NIC.Name = "label_NIC";
            this.label_NIC.Size = new System.Drawing.Size(28, 13);
            this.label_NIC.TabIndex = 17;
            this.label_NIC.Text = "NIC:";
            // 
            // label_Search_Staff
            // 
            this.label_Search_Staff.AutoSize = true;
            this.label_Search_Staff.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Search_Staff.Location = new System.Drawing.Point(159, 42);
            this.label_Search_Staff.Name = "label_Search_Staff";
            this.label_Search_Staff.Size = new System.Drawing.Size(111, 20);
            this.label_Search_Staff.TabIndex = 16;
            this.label_Search_Staff.Text = "Search Staff";
            this.label_Search_Staff.Click += new System.EventHandler(this.label_AddStaff_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(480, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 20);
            this.label1.TabIndex = 33;
            this.label1.Text = "Results";
            // 
            // button_BackToMenu
            // 
            this.button_BackToMenu.Location = new System.Drawing.Point(540, 415);
            this.button_BackToMenu.Name = "button_BackToMenu";
            this.button_BackToMenu.Size = new System.Drawing.Size(129, 23);
            this.button_BackToMenu.TabIndex = 35;
            this.button_BackToMenu.Text = "Back to Menu";
            this.button_BackToMenu.UseVisualStyleBackColor = true;
            this.button_BackToMenu.Click += new System.EventHandler(this.button_BackToMenu_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(344, 91);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(325, 228);
            this.dataGridView1.TabIndex = 36;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // SearchStaff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(681, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button_BackToMenu);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.datetimepicker_HiringDate);
            this.Controls.Add(this.textbox_DailyWorkHours);
            this.Controls.Add(this.textbox_JobTitle);
            this.Controls.Add(this.textbox_BranchID);
            this.Controls.Add(this.textbox_LastName);
            this.Controls.Add(this.textbox_FirstName);
            this.Controls.Add(this.textbox_NIC);
            this.Controls.Add(this.button_Search_Staff);
            this.Controls.Add(this.label_DailyWorkHours);
            this.Controls.Add(this.label_HiringDate);
            this.Controls.Add(this.label_JobTitle);
            this.Controls.Add(this.label_BranchID);
            this.Controls.Add(this.label_LastName);
            this.Controls.Add(this.label_FirstName);
            this.Controls.Add(this.label_NIC);
            this.Controls.Add(this.label_Search_Staff);
            this.Name = "SearchStaff";
            this.Text = "SearchStaff";
            this.Load += new System.EventHandler(this.SearchStaff_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker datetimepicker_HiringDate;
        private System.Windows.Forms.TextBox textbox_DailyWorkHours;
        private System.Windows.Forms.TextBox textbox_JobTitle;
        private System.Windows.Forms.TextBox textbox_BranchID;
        private System.Windows.Forms.TextBox textbox_LastName;
        private System.Windows.Forms.TextBox textbox_FirstName;
        private System.Windows.Forms.TextBox textbox_NIC;
        private System.Windows.Forms.Button button_Search_Staff;
        private System.Windows.Forms.Label label_DailyWorkHours;
        private System.Windows.Forms.Label label_HiringDate;
        private System.Windows.Forms.Label label_JobTitle;
        private System.Windows.Forms.Label label_BranchID;
        private System.Windows.Forms.Label label_LastName;
        private System.Windows.Forms.Label label_FirstName;
        private System.Windows.Forms.Label label_NIC;
        private System.Windows.Forms.Label label_Search_Staff;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_BackToMenu;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}