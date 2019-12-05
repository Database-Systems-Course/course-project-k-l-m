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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.button_AddOrder = new System.Windows.Forms.Button();
            this.button_SearchOrder = new System.Windows.Forms.Button();
            this.button_AddStaff = new System.Windows.Forms.Button();
            this.button_SearchStaff = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_AddOrder
            // 
            this.button_AddOrder.BackColor = System.Drawing.Color.Transparent;
            this.button_AddOrder.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_AddOrder.BackgroundImage")));
            this.button_AddOrder.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_AddOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_AddOrder.Location = new System.Drawing.Point(161, 301);
            this.button_AddOrder.Margin = new System.Windows.Forms.Padding(4);
            this.button_AddOrder.Name = "button_AddOrder";
            this.button_AddOrder.Size = new System.Drawing.Size(309, 109);
            this.button_AddOrder.TabIndex = 5;
            this.button_AddOrder.UseCompatibleTextRendering = true;
            this.button_AddOrder.UseMnemonic = false;
            this.button_AddOrder.UseVisualStyleBackColor = true;
            this.button_AddOrder.Click += new System.EventHandler(this.Button1_Click);
            // 
            // button_SearchOrder
            // 
            this.button_SearchOrder.BackColor = System.Drawing.SystemColors.Highlight;
            this.button_SearchOrder.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_SearchOrder.BackgroundImage")));
            this.button_SearchOrder.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_SearchOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_SearchOrder.Location = new System.Drawing.Point(161, 418);
            this.button_SearchOrder.Margin = new System.Windows.Forms.Padding(4);
            this.button_SearchOrder.Name = "button_SearchOrder";
            this.button_SearchOrder.Size = new System.Drawing.Size(309, 103);
            this.button_SearchOrder.TabIndex = 6;
            this.button_SearchOrder.UseVisualStyleBackColor = false;
            this.button_SearchOrder.Click += new System.EventHandler(this.button_SearchOrder_Click);
            // 
            // button_AddStaff
            // 
            this.button_AddStaff.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_AddStaff.BackgroundImage")));
            this.button_AddStaff.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_AddStaff.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_AddStaff.Location = new System.Drawing.Point(161, 529);
            this.button_AddStaff.Margin = new System.Windows.Forms.Padding(4);
            this.button_AddStaff.Name = "button_AddStaff";
            this.button_AddStaff.Size = new System.Drawing.Size(309, 105);
            this.button_AddStaff.TabIndex = 7;
            this.button_AddStaff.UseVisualStyleBackColor = true;
            this.button_AddStaff.Click += new System.EventHandler(this.button_AddStaff_Click);
            // 
            // button_SearchStaff
            // 
            this.button_SearchStaff.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_SearchStaff.BackgroundImage")));
            this.button_SearchStaff.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_SearchStaff.Cursor = System.Windows.Forms.Cursors.Default;
            this.button_SearchStaff.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_SearchStaff.Location = new System.Drawing.Point(161, 642);
            this.button_SearchStaff.Margin = new System.Windows.Forms.Padding(4);
            this.button_SearchStaff.Name = "button_SearchStaff";
            this.button_SearchStaff.Size = new System.Drawing.Size(309, 112);
            this.button_SearchStaff.TabIndex = 8;
            this.button_SearchStaff.UseVisualStyleBackColor = true;
            this.button_SearchStaff.Click += new System.EventHandler(this.button_SearchStaff_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(645, 973);
            this.Controls.Add(this.button_SearchStaff);
            this.Controls.Add(this.button_AddStaff);
            this.Controls.Add(this.button_SearchOrder);
            this.Controls.Add(this.button_AddOrder);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Menu";
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.Menu_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_AddOrder;
        private System.Windows.Forms.Button button_SearchOrder;
        private System.Windows.Forms.Button button_AddStaff;
        private System.Windows.Forms.Button button_SearchStaff;
    }
}