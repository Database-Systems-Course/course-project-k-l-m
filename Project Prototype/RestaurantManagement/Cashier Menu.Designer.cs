namespace RestaurantManagement
{
    partial class Manager_Menu
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
            this.button_SearchOrder = new System.Windows.Forms.Button();
            this.button_AddOrder = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_SearchOrder
            // 
            this.button_SearchOrder.Location = new System.Drawing.Point(111, 144);
            this.button_SearchOrder.Margin = new System.Windows.Forms.Padding(2);
            this.button_SearchOrder.Name = "button_SearchOrder";
            this.button_SearchOrder.Size = new System.Drawing.Size(188, 67);
            this.button_SearchOrder.TabIndex = 8;
            this.button_SearchOrder.Text = "Search Order";
            this.button_SearchOrder.UseVisualStyleBackColor = true;
            // 
            // button_AddOrder
            // 
            this.button_AddOrder.Location = new System.Drawing.Point(111, 58);
            this.button_AddOrder.Margin = new System.Windows.Forms.Padding(2);
            this.button_AddOrder.Name = "button_AddOrder";
            this.button_AddOrder.Size = new System.Drawing.Size(188, 55);
            this.button_AddOrder.TabIndex = 7;
            this.button_AddOrder.Text = "Add Order";
            this.button_AddOrder.UseVisualStyleBackColor = true;
            // 
            // Manager_Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(435, 288);
            this.Controls.Add(this.button_SearchOrder);
            this.Controls.Add(this.button_AddOrder);
            this.Name = "Manager_Menu";
            this.Text = "Manager_Menu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_SearchOrder;
        private System.Windows.Forms.Button button_AddOrder;
    }
}