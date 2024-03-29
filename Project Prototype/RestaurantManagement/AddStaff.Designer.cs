﻿namespace RestaurantManagement
{
    partial class AddStaff
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
            this.label_AddStaff = new System.Windows.Forms.Label();
            this.label_NIC = new System.Windows.Forms.Label();
            this.label_FirstName = new System.Windows.Forms.Label();
            this.label_LastName = new System.Windows.Forms.Label();
            this.label_BranchID = new System.Windows.Forms.Label();
            this.label_JobTitle = new System.Windows.Forms.Label();
            this.label_HiringDate = new System.Windows.Forms.Label();
            this.label_DailyWorkHours = new System.Windows.Forms.Label();
            this.button_AddStaff = new System.Windows.Forms.Button();
            this.textbox_NIC = new System.Windows.Forms.TextBox();
            this.textbox_FirstName = new System.Windows.Forms.TextBox();
            this.textbox_LastName = new System.Windows.Forms.TextBox();
            this.textbox_DailyWorkHours = new System.Windows.Forms.TextBox();
            this.datetimepicker_HiringDate = new System.Windows.Forms.DateTimePicker();
            this.button_BackToMenu = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label_AddStaff
            // 
            this.label_AddStaff.AutoSize = true;
            this.label_AddStaff.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_AddStaff.Location = new System.Drawing.Point(133, 25);
            this.label_AddStaff.Name = "label_AddStaff";
            this.label_AddStaff.Size = new System.Drawing.Size(86, 20);
            this.label_AddStaff.TabIndex = 0;
            this.label_AddStaff.Text = "Add Staff";
            // 
            // label_NIC
            // 
            this.label_NIC.AutoSize = true;
            this.label_NIC.Location = new System.Drawing.Point(19, 77);
            this.label_NIC.Name = "label_NIC";
            this.label_NIC.Size = new System.Drawing.Size(28, 13);
            this.label_NIC.TabIndex = 1;
            this.label_NIC.Text = "NIC:";
            // 
            // label_FirstName
            // 
            this.label_FirstName.AutoSize = true;
            this.label_FirstName.Location = new System.Drawing.Point(19, 113);
            this.label_FirstName.Name = "label_FirstName";
            this.label_FirstName.Size = new System.Drawing.Size(60, 13);
            this.label_FirstName.TabIndex = 2;
            this.label_FirstName.Text = "First Name:";
            // 
            // label_LastName
            // 
            this.label_LastName.AutoSize = true;
            this.label_LastName.Location = new System.Drawing.Point(19, 144);
            this.label_LastName.Name = "label_LastName";
            this.label_LastName.Size = new System.Drawing.Size(61, 13);
            this.label_LastName.TabIndex = 3;
            this.label_LastName.Text = "Last Name:";
            // 
            // label_BranchID
            // 
            this.label_BranchID.AutoSize = true;
            this.label_BranchID.Location = new System.Drawing.Point(19, 178);
            this.label_BranchID.Name = "label_BranchID";
            this.label_BranchID.Size = new System.Drawing.Size(58, 13);
            this.label_BranchID.TabIndex = 4;
            this.label_BranchID.Text = "Branch ID:";
            // 
            // label_JobTitle
            // 
            this.label_JobTitle.AutoSize = true;
            this.label_JobTitle.Location = new System.Drawing.Point(19, 212);
            this.label_JobTitle.Name = "label_JobTitle";
            this.label_JobTitle.Size = new System.Drawing.Size(50, 13);
            this.label_JobTitle.TabIndex = 5;
            this.label_JobTitle.Text = "Job Title:";
            // 
            // label_HiringDate
            // 
            this.label_HiringDate.AutoSize = true;
            this.label_HiringDate.Location = new System.Drawing.Point(19, 251);
            this.label_HiringDate.Name = "label_HiringDate";
            this.label_HiringDate.Size = new System.Drawing.Size(63, 13);
            this.label_HiringDate.TabIndex = 6;
            this.label_HiringDate.Text = "Hiring Date:";
            // 
            // label_DailyWorkHours
            // 
            this.label_DailyWorkHours.AutoSize = true;
            this.label_DailyWorkHours.Location = new System.Drawing.Point(19, 285);
            this.label_DailyWorkHours.Name = "label_DailyWorkHours";
            this.label_DailyWorkHours.Size = new System.Drawing.Size(93, 13);
            this.label_DailyWorkHours.TabIndex = 7;
            this.label_DailyWorkHours.Text = "Daily Work Hours:";
            // 
            // button_AddStaff
            // 
            this.button_AddStaff.Location = new System.Drawing.Point(197, 333);
            this.button_AddStaff.Name = "button_AddStaff";
            this.button_AddStaff.Size = new System.Drawing.Size(95, 23);
            this.button_AddStaff.TabIndex = 8;
            this.button_AddStaff.Text = "Add Staff";
            this.button_AddStaff.UseVisualStyleBackColor = true;
            this.button_AddStaff.Click += new System.EventHandler(this.Button_AddStaff_Click);
            // 
            // textbox_NIC
            // 
            this.textbox_NIC.Location = new System.Drawing.Point(115, 74);
            this.textbox_NIC.Name = "textbox_NIC";
            this.textbox_NIC.Size = new System.Drawing.Size(177, 20);
            this.textbox_NIC.TabIndex = 9;
            this.textbox_NIC.TextChanged += new System.EventHandler(this.Textbox_NIC_TextChanged);
            // 
            // textbox_FirstName
            // 
            this.textbox_FirstName.Location = new System.Drawing.Point(115, 110);
            this.textbox_FirstName.Name = "textbox_FirstName";
            this.textbox_FirstName.Size = new System.Drawing.Size(177, 20);
            this.textbox_FirstName.TabIndex = 10;
            this.textbox_FirstName.TextChanged += new System.EventHandler(this.Textbox_FirstName_TextChanged);
            // 
            // textbox_LastName
            // 
            this.textbox_LastName.Location = new System.Drawing.Point(115, 141);
            this.textbox_LastName.Name = "textbox_LastName";
            this.textbox_LastName.Size = new System.Drawing.Size(177, 20);
            this.textbox_LastName.TabIndex = 11;
            // 
            // textbox_DailyWorkHours
            // 
            this.textbox_DailyWorkHours.Location = new System.Drawing.Point(115, 282);
            this.textbox_DailyWorkHours.Name = "textbox_DailyWorkHours";
            this.textbox_DailyWorkHours.Size = new System.Drawing.Size(177, 20);
            this.textbox_DailyWorkHours.TabIndex = 14;
            // 
            // datetimepicker_HiringDate
            // 
            this.datetimepicker_HiringDate.Location = new System.Drawing.Point(115, 245);
            this.datetimepicker_HiringDate.Name = "datetimepicker_HiringDate";
            this.datetimepicker_HiringDate.Size = new System.Drawing.Size(177, 20);
            this.datetimepicker_HiringDate.TabIndex = 15;
            // 
            // button_BackToMenu
            // 
            this.button_BackToMenu.Location = new System.Drawing.Point(22, 333);
            this.button_BackToMenu.Name = "button_BackToMenu";
            this.button_BackToMenu.Size = new System.Drawing.Size(100, 23);
            this.button_BackToMenu.TabIndex = 16;
            this.button_BackToMenu.Text = "Back to Menu";
            this.button_BackToMenu.UseVisualStyleBackColor = true;
            this.button_BackToMenu.Click += new System.EventHandler(this.button_BackToMenu_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(115, 208);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(177, 21);
            this.comboBox1.TabIndex = 17;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.ComboBox1_SelectedIndexChanged);
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(115, 174);
            this.comboBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(177, 21);
            this.comboBox2.TabIndex = 18;
            // 
            // AddStaff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(357, 388);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button_BackToMenu);
            this.Controls.Add(this.datetimepicker_HiringDate);
            this.Controls.Add(this.textbox_DailyWorkHours);
            this.Controls.Add(this.textbox_LastName);
            this.Controls.Add(this.textbox_FirstName);
            this.Controls.Add(this.textbox_NIC);
            this.Controls.Add(this.button_AddStaff);
            this.Controls.Add(this.label_DailyWorkHours);
            this.Controls.Add(this.label_HiringDate);
            this.Controls.Add(this.label_JobTitle);
            this.Controls.Add(this.label_BranchID);
            this.Controls.Add(this.label_LastName);
            this.Controls.Add(this.label_FirstName);
            this.Controls.Add(this.label_NIC);
            this.Controls.Add(this.label_AddStaff);
            this.Name = "AddStaff";
            this.Text = "AddStaff";
            this.Load += new System.EventHandler(this.AddStaff_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_AddStaff;
        private System.Windows.Forms.Label label_NIC;
        private System.Windows.Forms.Label label_FirstName;
        private System.Windows.Forms.Label label_LastName;
        private System.Windows.Forms.Label label_BranchID;
        private System.Windows.Forms.Label label_JobTitle;
        private System.Windows.Forms.Label label_HiringDate;
        private System.Windows.Forms.Label label_DailyWorkHours;
        private System.Windows.Forms.Button button_AddStaff;
        private System.Windows.Forms.TextBox textbox_NIC;
        private System.Windows.Forms.TextBox textbox_FirstName;
        private System.Windows.Forms.TextBox textbox_LastName;
        private System.Windows.Forms.TextBox textbox_DailyWorkHours;
        private System.Windows.Forms.DateTimePicker datetimepicker_HiringDate;
        private System.Windows.Forms.Button button_BackToMenu;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
    }
}