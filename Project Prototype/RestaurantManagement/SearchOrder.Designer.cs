namespace RestaurantManagement
{
    partial class SearchOrder
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
            this.label_SearchOrder = new System.Windows.Forms.Label();
            this.label_CustomerNIC = new System.Windows.Forms.Label();
            this.label_OrderID = new System.Windows.Forms.Label();
            this.label_StaffID = new System.Windows.Forms.Label();
            this.label_OrderDate = new System.Windows.Forms.Label();
            this.textbox_CustomerNIC = new System.Windows.Forms.TextBox();
            this.textbox_StaffID = new System.Windows.Forms.TextBox();
            this.textbox_OrderID = new System.Windows.Forms.TextBox();
            this.datetimepicker_OrderDate = new System.Windows.Forms.DateTimePicker();
            this.button_Search = new System.Windows.Forms.Button();
            this.button_View = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.button_BackToMenu = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label_SearchOrder
            // 
            this.label_SearchOrder.AutoSize = true;
            this.label_SearchOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_SearchOrder.Location = new System.Drawing.Point(320, 25);
            this.label_SearchOrder.Name = "label_SearchOrder";
            this.label_SearchOrder.Size = new System.Drawing.Size(116, 20);
            this.label_SearchOrder.TabIndex = 0;
            this.label_SearchOrder.Text = "Search Order";
            this.label_SearchOrder.Click += new System.EventHandler(this.label_SearchOrder_Click);
            // 
            // label_CustomerNIC
            // 
            this.label_CustomerNIC.AutoSize = true;
            this.label_CustomerNIC.Location = new System.Drawing.Point(22, 71);
            this.label_CustomerNIC.Name = "label_CustomerNIC";
            this.label_CustomerNIC.Size = new System.Drawing.Size(75, 13);
            this.label_CustomerNIC.TabIndex = 1;
            this.label_CustomerNIC.Text = "Customer NIC:";
            this.label_CustomerNIC.Click += new System.EventHandler(this.label_CustomerNIC_Click);
            // 
            // label_OrderID
            // 
            this.label_OrderID.AutoSize = true;
            this.label_OrderID.Location = new System.Drawing.Point(472, 68);
            this.label_OrderID.Name = "label_OrderID";
            this.label_OrderID.Size = new System.Drawing.Size(47, 13);
            this.label_OrderID.TabIndex = 2;
            this.label_OrderID.Text = "OrderID:";
            // 
            // label_StaffID
            // 
            this.label_StaffID.AutoSize = true;
            this.label_StaffID.Location = new System.Drawing.Point(51, 95);
            this.label_StaffID.Name = "label_StaffID";
            this.label_StaffID.Size = new System.Drawing.Size(46, 13);
            this.label_StaffID.TabIndex = 3;
            this.label_StaffID.Text = "Staff ID:";
            this.label_StaffID.Click += new System.EventHandler(this.label_StaffID_Click);
            // 
            // label_OrderDate
            // 
            this.label_OrderDate.AutoSize = true;
            this.label_OrderDate.Location = new System.Drawing.Point(457, 96);
            this.label_OrderDate.Name = "label_OrderDate";
            this.label_OrderDate.Size = new System.Drawing.Size(62, 13);
            this.label_OrderDate.TabIndex = 4;
            this.label_OrderDate.Text = "Order Date:";
            // 
            // textbox_CustomerNIC
            // 
            this.textbox_CustomerNIC.Location = new System.Drawing.Point(103, 68);
            this.textbox_CustomerNIC.Name = "textbox_CustomerNIC";
            this.textbox_CustomerNIC.Size = new System.Drawing.Size(199, 20);
            this.textbox_CustomerNIC.TabIndex = 5;
            this.textbox_CustomerNIC.TextChanged += new System.EventHandler(this.textbox_CustomerNIC_TextChanged);
            // 
            // textbox_StaffID
            // 
            this.textbox_StaffID.Location = new System.Drawing.Point(103, 92);
            this.textbox_StaffID.Name = "textbox_StaffID";
            this.textbox_StaffID.Size = new System.Drawing.Size(199, 20);
            this.textbox_StaffID.TabIndex = 6;
            this.textbox_StaffID.TextChanged += new System.EventHandler(this.textbox_StaffID_TextChanged);
            // 
            // textbox_OrderID
            // 
            this.textbox_OrderID.Location = new System.Drawing.Point(525, 65);
            this.textbox_OrderID.Name = "textbox_OrderID";
            this.textbox_OrderID.Size = new System.Drawing.Size(200, 20);
            this.textbox_OrderID.TabIndex = 7;
            this.textbox_OrderID.TextChanged += new System.EventHandler(this.textbox_OrderID_TextChanged);
            // 
            // datetimepicker_OrderDate
            // 
            this.datetimepicker_OrderDate.Location = new System.Drawing.Point(525, 91);
            this.datetimepicker_OrderDate.Name = "datetimepicker_OrderDate";
            this.datetimepicker_OrderDate.Size = new System.Drawing.Size(200, 20);
            this.datetimepicker_OrderDate.TabIndex = 8;
            // 
            // button_Search
            // 
            this.button_Search.Location = new System.Drawing.Point(632, 129);
            this.button_Search.Name = "button_Search";
            this.button_Search.Size = new System.Drawing.Size(93, 24);
            this.button_Search.TabIndex = 9;
            this.button_Search.Text = "Search";
            this.button_Search.UseVisualStyleBackColor = true;
            this.button_Search.Click += new System.EventHandler(this.button_Search_Click);
            // 
            // button_View
            // 
            this.button_View.Location = new System.Drawing.Point(621, 423);
            this.button_View.Name = "button_View";
            this.button_View.Size = new System.Drawing.Size(104, 23);
            this.button_View.TabIndex = 11;
            this.button_View.Text = "View";
            this.button_View.UseVisualStyleBackColor = true;
            this.button_View.Click += new System.EventHandler(this.button_View_Click);
            // 
            // button_BackToMenu
            // 
            this.button_BackToMenu.Location = new System.Drawing.Point(463, 423);
            this.button_BackToMenu.Name = "button_BackToMenu";
            this.button_BackToMenu.Size = new System.Drawing.Size(132, 23);
            this.button_BackToMenu.TabIndex = 12;
            this.button_BackToMenu.Text = "Back To Menu";
            this.button_BackToMenu.UseVisualStyleBackColor = true;
            this.button_BackToMenu.Click += new System.EventHandler(this.button_BackToMenu_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(32, 161);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(456, 236);
            this.dataGridView1.TabIndex = 13;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // SearchOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(774, 458);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button_BackToMenu);
            this.Controls.Add(this.button_View);
            this.Controls.Add(this.button_Search);
            this.Controls.Add(this.datetimepicker_OrderDate);
            this.Controls.Add(this.textbox_OrderID);
            this.Controls.Add(this.textbox_StaffID);
            this.Controls.Add(this.textbox_CustomerNIC);
            this.Controls.Add(this.label_OrderDate);
            this.Controls.Add(this.label_StaffID);
            this.Controls.Add(this.label_OrderID);
            this.Controls.Add(this.label_CustomerNIC);
            this.Controls.Add(this.label_SearchOrder);
            this.Name = "SearchOrder";
            this.Text = "SarchOrder";
            this.Load += new System.EventHandler(this.SarchOrder_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_SearchOrder;
        private System.Windows.Forms.Label label_CustomerNIC;
        private System.Windows.Forms.Label label_OrderID;
        private System.Windows.Forms.Label label_StaffID;
        private System.Windows.Forms.Label label_OrderDate;
        private System.Windows.Forms.TextBox textbox_CustomerNIC;
        private System.Windows.Forms.TextBox textbox_StaffID;
        private System.Windows.Forms.TextBox textbox_OrderID;
        private System.Windows.Forms.DateTimePicker datetimepicker_OrderDate;
        private System.Windows.Forms.Button button_Search;
        private System.Windows.Forms.Button button_View;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button button_BackToMenu;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}