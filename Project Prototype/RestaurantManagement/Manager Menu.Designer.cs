namespace RestaurantManagement
{
    partial class Menu
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
            this.button_AddOrder = new System.Windows.Forms.Button();
            this.button_SearchOrder = new System.Windows.Forms.Button();
            this.button_AddStaff = new System.Windows.Forms.Button();
            this.button_SearchStaff = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_AddOrder
            // 
            this.button_AddOrder.Location = new System.Drawing.Point(96, 37);
            this.button_AddOrder.Margin = new System.Windows.Forms.Padding(2);
            this.button_AddOrder.Name = "button_AddOrder";
            this.button_AddOrder.Size = new System.Drawing.Size(188, 55);
            this.button_AddOrder.TabIndex = 5;
            this.button_AddOrder.Text = "Add Order";
            this.button_AddOrder.UseVisualStyleBackColor = true;
            this.button_AddOrder.Click += new System.EventHandler(this.Button1_Click);
            // 
            // button_SearchOrder
            // 
            this.button_SearchOrder.Location = new System.Drawing.Point(96, 123);
            this.button_SearchOrder.Margin = new System.Windows.Forms.Padding(2);
            this.button_SearchOrder.Name = "button_SearchOrder";
            this.button_SearchOrder.Size = new System.Drawing.Size(188, 67);
            this.button_SearchOrder.TabIndex = 6;
            this.button_SearchOrder.Text = "Search Order";
            this.button_SearchOrder.UseVisualStyleBackColor = true;
            this.button_SearchOrder.Click += new System.EventHandler(this.button_SearchOrder_Click);
            // 
            // button_AddStaff
            // 
            this.button_AddStaff.Location = new System.Drawing.Point(96, 226);
            this.button_AddStaff.Margin = new System.Windows.Forms.Padding(2);
            this.button_AddStaff.Name = "button_AddStaff";
            this.button_AddStaff.Size = new System.Drawing.Size(188, 63);
            this.button_AddStaff.TabIndex = 7;
            this.button_AddStaff.Text = "Add Staff";
            this.button_AddStaff.UseVisualStyleBackColor = true;
            this.button_AddStaff.Click += new System.EventHandler(this.button_AddStaff_Click);
            // 
            // button_SearchStaff
            // 
            this.button_SearchStaff.Location = new System.Drawing.Point(96, 327);
            this.button_SearchStaff.Margin = new System.Windows.Forms.Padding(2);
            this.button_SearchStaff.Name = "button_SearchStaff";
            this.button_SearchStaff.Size = new System.Drawing.Size(188, 60);
            this.button_SearchStaff.TabIndex = 8;
            this.button_SearchStaff.Text = "Search Staff";
            this.button_SearchStaff.UseVisualStyleBackColor = true;
            this.button_SearchStaff.Click += new System.EventHandler(this.button_SearchStaff_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(96, 421);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(188, 56);
            this.button1.TabIndex = 9;
            this.button1.Text = "Add/Delete Food";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 527);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button_SearchStaff);
            this.Controls.Add(this.button_AddStaff);
            this.Controls.Add(this.button_SearchOrder);
            this.Controls.Add(this.button_AddOrder);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Menu";
            this.Text = "Menu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_AddOrder;
        private System.Windows.Forms.Button button_SearchOrder;
        private System.Windows.Forms.Button button_AddStaff;
        private System.Windows.Forms.Button button_SearchStaff;
        private System.Windows.Forms.Button button1;
    }
}