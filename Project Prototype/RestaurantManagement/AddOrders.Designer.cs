namespace RestaurantManagement
{
    partial class AddOrders
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
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.button_AddOrder = new System.Windows.Forms.Button();
            this.label_Date = new System.Windows.Forms.Label();
            this.groupbox_StaffDetails = new System.Windows.Forms.GroupBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupbox_CustomerDetails = new System.Windows.Forms.GroupBox();
            this.textbox_LastName = new System.Windows.Forms.TextBox();
            this.textbox_FirstName = new System.Windows.Forms.TextBox();
            this.textbox_CustomerNIC = new System.Windows.Forms.TextBox();
            this.label_LastName = new System.Windows.Forms.Label();
            this.label_CustomerNIC = new System.Windows.Forms.Label();
            this.label_FirstName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.combobox_FoodItems = new System.Windows.Forms.ComboBox();
            this.label_FoodItems = new System.Windows.Forms.Label();
            this.button_BackToMenu = new System.Windows.Forms.Button();
            this.OrderedItems = new System.Windows.Forms.ListBox();
            this.button_AddItem = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.QtyTextBox = new System.Windows.Forms.TextBox();
            this.Quantity = new System.Windows.Forms.ListBox();
            this.groupbox_StaffDetails.SuspendLayout();
            this.groupbox_CustomerDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(424, 74);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(195, 20);
            this.dateTimePicker1.TabIndex = 10;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // button_AddOrder
            // 
            this.button_AddOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_AddOrder.Location = new System.Drawing.Point(574, 415);
            this.button_AddOrder.Name = "button_AddOrder";
            this.button_AddOrder.Size = new System.Drawing.Size(75, 23);
            this.button_AddOrder.TabIndex = 9;
            this.button_AddOrder.Text = "Add Order";
            this.button_AddOrder.UseVisualStyleBackColor = true;
            this.button_AddOrder.Click += new System.EventHandler(this.button_AddOrder_Click);
            // 
            // label_Date
            // 
            this.label_Date.AutoSize = true;
            this.label_Date.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Date.Location = new System.Drawing.Point(363, 76);
            this.label_Date.Name = "label_Date";
            this.label_Date.Size = new System.Drawing.Size(38, 13);
            this.label_Date.TabIndex = 13;
            this.label_Date.Text = "Date:";
            this.label_Date.Click += new System.EventHandler(this.label_Date_Click);
            // 
            // groupbox_StaffDetails
            // 
            this.groupbox_StaffDetails.Controls.Add(this.comboBox1);
            this.groupbox_StaffDetails.Controls.Add(this.label2);
            this.groupbox_StaffDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupbox_StaffDetails.Location = new System.Drawing.Point(45, 61);
            this.groupbox_StaffDetails.Name = "groupbox_StaffDetails";
            this.groupbox_StaffDetails.Size = new System.Drawing.Size(231, 69);
            this.groupbox_StaffDetails.TabIndex = 12;
            this.groupbox_StaffDetails.TabStop = false;
            this.groupbox_StaffDetails.Text = "Staff Details";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(78, 30);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(147, 21);
            this.comboBox1.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Staff ID:";
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
            this.groupbox_CustomerDetails.Location = new System.Drawing.Point(357, 175);
            this.groupbox_CustomerDetails.Name = "groupbox_CustomerDetails";
            this.groupbox_CustomerDetails.Size = new System.Drawing.Size(260, 135);
            this.groupbox_CustomerDetails.TabIndex = 11;
            this.groupbox_CustomerDetails.TabStop = false;
            this.groupbox_CustomerDetails.Text = "CustomerDetails";
            // 
            // textbox_LastName
            // 
            this.textbox_LastName.Location = new System.Drawing.Point(100, 87);
            this.textbox_LastName.Name = "textbox_LastName";
            this.textbox_LastName.Size = new System.Drawing.Size(131, 20);
            this.textbox_LastName.TabIndex = 7;
            // 
            // textbox_FirstName
            // 
            this.textbox_FirstName.Location = new System.Drawing.Point(100, 59);
            this.textbox_FirstName.Name = "textbox_FirstName";
            this.textbox_FirstName.Size = new System.Drawing.Size(131, 20);
            this.textbox_FirstName.TabIndex = 6;
            this.textbox_FirstName.TextChanged += new System.EventHandler(this.Textbox_FirstName_TextChanged);
            // 
            // textbox_CustomerNIC
            // 
            this.textbox_CustomerNIC.Location = new System.Drawing.Point(100, 31);
            this.textbox_CustomerNIC.Name = "textbox_CustomerNIC";
            this.textbox_CustomerNIC.Size = new System.Drawing.Size(131, 20);
            this.textbox_CustomerNIC.TabIndex = 5;
            // 
            // label_LastName
            // 
            this.label_LastName.AutoSize = true;
            this.label_LastName.Location = new System.Drawing.Point(14, 87);
            this.label_LastName.Name = "label_LastName";
            this.label_LastName.Size = new System.Drawing.Size(71, 13);
            this.label_LastName.TabIndex = 4;
            this.label_LastName.Text = "Last Name:";
            // 
            // label_CustomerNIC
            // 
            this.label_CustomerNIC.AutoSize = true;
            this.label_CustomerNIC.Location = new System.Drawing.Point(9, 33);
            this.label_CustomerNIC.Name = "label_CustomerNIC";
            this.label_CustomerNIC.Size = new System.Drawing.Size(88, 13);
            this.label_CustomerNIC.TabIndex = 1;
            this.label_CustomerNIC.Text = "Customer NIC:";
            // 
            // label_FirstName
            // 
            this.label_FirstName.AutoSize = true;
            this.label_FirstName.Location = new System.Drawing.Point(14, 59);
            this.label_FirstName.Name = "label_FirstName";
            this.label_FirstName.Size = new System.Drawing.Size(71, 13);
            this.label_FirstName.TabIndex = 3;
            this.label_FirstName.Text = "First Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(304, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Add Order";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // combobox_FoodItems
            // 
            this.combobox_FoodItems.FormattingEnabled = true;
            this.combobox_FoodItems.Location = new System.Drawing.Point(123, 144);
            this.combobox_FoodItems.Name = "combobox_FoodItems";
            this.combobox_FoodItems.Size = new System.Drawing.Size(147, 21);
            this.combobox_FoodItems.TabIndex = 15;
            // 
            // label_FoodItems
            // 
            this.label_FoodItems.AutoSize = true;
            this.label_FoodItems.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_FoodItems.Location = new System.Drawing.Point(50, 147);
            this.label_FoodItems.Name = "label_FoodItems";
            this.label_FoodItems.Size = new System.Drawing.Size(73, 13);
            this.label_FoodItems.TabIndex = 16;
            this.label_FoodItems.Text = "Food Items:";
            // 
            // button_BackToMenu
            // 
            this.button_BackToMenu.Location = new System.Drawing.Point(433, 415);
            this.button_BackToMenu.Name = "button_BackToMenu";
            this.button_BackToMenu.Size = new System.Drawing.Size(109, 23);
            this.button_BackToMenu.TabIndex = 17;
            this.button_BackToMenu.Text = "Back to Menu";
            this.button_BackToMenu.UseVisualStyleBackColor = true;
            this.button_BackToMenu.Click += new System.EventHandler(this.button_BackToMenu_Click);
            // 
            // OrderedItems
            // 
            this.OrderedItems.FormattingEnabled = true;
            this.OrderedItems.Location = new System.Drawing.Point(58, 229);
            this.OrderedItems.Name = "OrderedItems";
            this.OrderedItems.Size = new System.Drawing.Size(182, 186);
            this.OrderedItems.TabIndex = 18;
            // 
            // button_AddItem
            // 
            this.button_AddItem.Location = new System.Drawing.Point(201, 186);
            this.button_AddItem.Name = "button_AddItem";
            this.button_AddItem.Size = new System.Drawing.Size(75, 23);
            this.button_AddItem.TabIndex = 19;
            this.button_AddItem.Text = "Add Item";
            this.button_AddItem.UseVisualStyleBackColor = true;
            this.button_AddItem.Click += new System.EventHandler(this.Button_AddItem_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(56, 191);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "Quantity:";
            // 
            // QtyTextBox
            // 
            this.QtyTextBox.Location = new System.Drawing.Point(123, 190);
            this.QtyTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.QtyTextBox.Name = "QtyTextBox";
            this.QtyTextBox.Size = new System.Drawing.Size(52, 20);
            this.QtyTextBox.TabIndex = 21;
            this.QtyTextBox.Text = "1";
            // 
            // Quantity
            // 
            this.Quantity.FormattingEnabled = true;
            this.Quantity.Location = new System.Drawing.Point(236, 229);
            this.Quantity.Name = "Quantity";
            this.Quantity.Size = new System.Drawing.Size(68, 186);
            this.Quantity.TabIndex = 22;
            // 
            // AddOrders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(685, 389);
            this.Controls.Add(this.Quantity);
            this.Controls.Add(this.QtyTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button_AddItem);
            this.Controls.Add(this.OrderedItems);
            this.Controls.Add(this.button_BackToMenu);
            this.Controls.Add(this.label_FoodItems);
            this.Controls.Add(this.combobox_FoodItems);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.button_AddOrder);
            this.Controls.Add(this.label_Date);
            this.Controls.Add(this.groupbox_StaffDetails);
            this.Controls.Add(this.groupbox_CustomerDetails);
            this.Controls.Add(this.label1);
            this.Name = "AddOrders";
            this.Text = "AddOrders";
            this.Load += new System.EventHandler(this.AddOrders_Load);
            this.groupbox_StaffDetails.ResumeLayout(false);
            this.groupbox_StaffDetails.PerformLayout();
            this.groupbox_CustomerDetails.ResumeLayout(false);
            this.groupbox_CustomerDetails.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button button_AddOrder;
        private System.Windows.Forms.Label label_Date;
        private System.Windows.Forms.GroupBox groupbox_StaffDetails;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupbox_CustomerDetails;
        private System.Windows.Forms.TextBox textbox_LastName;
        private System.Windows.Forms.TextBox textbox_FirstName;
        private System.Windows.Forms.Label label_LastName;
        private System.Windows.Forms.Label label_CustomerNIC;
        private System.Windows.Forms.Label label_FirstName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox combobox_FoodItems;
        private System.Windows.Forms.Label label_FoodItems;
        private System.Windows.Forms.Button button_BackToMenu;
        private System.Windows.Forms.ListBox OrderedItems;
        private System.Windows.Forms.Button button_AddItem;
        private System.Windows.Forms.TextBox textbox_CustomerNIC;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox QtyTextBox;
        private System.Windows.Forms.ListBox Quantity;
    }
}