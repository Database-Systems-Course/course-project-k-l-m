namespace RestaurantManagement
{
    partial class AddOrder
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
            this.label_CustomerNIC = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label_FirstName = new System.Windows.Forms.Label();
            this.groupbox_CustomerDetails = new System.Windows.Forms.GroupBox();
            this.label_LastName = new System.Windows.Forms.Label();
            this.textbox_CustomerNIC = new System.Windows.Forms.TextBox();
            this.textbox_FirstName = new System.Windows.Forms.TextBox();
            this.textbox_LastName = new System.Windows.Forms.TextBox();
            this.groupbox_StaffDetails = new System.Windows.Forms.GroupBox();
            this.groupbox_CustomerDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_CustomerNIC
            // 
            this.label_CustomerNIC.AutoSize = true;
            this.label_CustomerNIC.Location = new System.Drawing.Point(6, 34);
            this.label_CustomerNIC.Name = "label_CustomerNIC";
            this.label_CustomerNIC.Size = new System.Drawing.Size(88, 13);
            this.label_CustomerNIC.TabIndex = 1;
            this.label_CustomerNIC.Text = "Customer NIC:";
            this.label_CustomerNIC.Click += new System.EventHandler(this.label_CustomerID_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(271, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Add Order";
            // 
            // label_FirstName
            // 
            this.label_FirstName.AutoSize = true;
            this.label_FirstName.Location = new System.Drawing.Point(6, 62);
            this.label_FirstName.Name = "label_FirstName";
            this.label_FirstName.Size = new System.Drawing.Size(71, 13);
            this.label_FirstName.TabIndex = 3;
            this.label_FirstName.Text = "First Name:";
            // 
            // groupbox_CustomerDetails
            // 
            this.groupbox_CustomerDetails.Controls.Add(this.textbox_LastName);
            this.groupbox_CustomerDetails.Controls.Add(this.textbox_FirstName);
            this.groupbox_CustomerDetails.Controls.Add(this.textbox_CustomerNIC);
            this.groupbox_CustomerDetails.Controls.Add(this.label_LastName);
            this.groupbox_CustomerDetails.Controls.Add(this.label_CustomerNIC);
            this.groupbox_CustomerDetails.Controls.Add(this.label_FirstName);
            this.groupbox_CustomerDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupbox_CustomerDetails.Location = new System.Drawing.Point(38, 64);
            this.groupbox_CustomerDetails.Name = "groupbox_CustomerDetails";
            this.groupbox_CustomerDetails.Size = new System.Drawing.Size(260, 135);
            this.groupbox_CustomerDetails.TabIndex = 4;
            this.groupbox_CustomerDetails.TabStop = false;
            this.groupbox_CustomerDetails.Text = "CustomerDetails";
            // 
            // label_LastName
            // 
            this.label_LastName.AutoSize = true;
            this.label_LastName.Location = new System.Drawing.Point(6, 90);
            this.label_LastName.Name = "label_LastName";
            this.label_LastName.Size = new System.Drawing.Size(71, 13);
            this.label_LastName.TabIndex = 4;
            this.label_LastName.Text = "Last Name:";
            this.label_LastName.Click += new System.EventHandler(this.label_LastName_Click);
            // 
            // textbox_CustomerNIC
            // 
            this.textbox_CustomerNIC.Location = new System.Drawing.Point(100, 31);
            this.textbox_CustomerNIC.Name = "textbox_CustomerNIC";
            this.textbox_CustomerNIC.Size = new System.Drawing.Size(131, 20);
            this.textbox_CustomerNIC.TabIndex = 5;
            // 
            // textbox_FirstName
            // 
            this.textbox_FirstName.Location = new System.Drawing.Point(100, 59);
            this.textbox_FirstName.Name = "textbox_FirstName";
            this.textbox_FirstName.Size = new System.Drawing.Size(131, 20);
            this.textbox_FirstName.TabIndex = 6;
            // 
            // textbox_LastName
            // 
            this.textbox_LastName.Location = new System.Drawing.Point(100, 87);
            this.textbox_LastName.Name = "textbox_LastName";
            this.textbox_LastName.Size = new System.Drawing.Size(131, 20);
            this.textbox_LastName.TabIndex = 7;
            // 
            // groupbox_StaffDetails
            // 
            this.groupbox_StaffDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupbox_StaffDetails.Location = new System.Drawing.Point(343, 79);
            this.groupbox_StaffDetails.Name = "groupbox_StaffDetails";
            this.groupbox_StaffDetails.Size = new System.Drawing.Size(200, 100);
            this.groupbox_StaffDetails.TabIndex = 5;
            this.groupbox_StaffDetails.TabStop = false;
            this.groupbox_StaffDetails.Text = "Staff Details";
            // 
            // AddOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(615, 450);
            this.Controls.Add(this.groupbox_StaffDetails);
            this.Controls.Add(this.groupbox_CustomerDetails);
            this.Controls.Add(this.label1);
            this.Name = "AddOrder";
            this.Text = "AddOrder";
            this.groupbox_CustomerDetails.ResumeLayout(false);
            this.groupbox_CustomerDetails.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label_CustomerNIC;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_FirstName;
        private System.Windows.Forms.GroupBox groupbox_CustomerDetails;
        private System.Windows.Forms.Label label_LastName;
        private System.Windows.Forms.TextBox textbox_CustomerNIC;
        private System.Windows.Forms.TextBox textbox_LastName;
        private System.Windows.Forms.TextBox textbox_FirstName;
        private System.Windows.Forms.GroupBox groupbox_StaffDetails;
    }
}