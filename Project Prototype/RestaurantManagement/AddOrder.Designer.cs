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
            this.textbox_LastName = new System.Windows.Forms.TextBox();
            this.textbox_FirstName = new System.Windows.Forms.TextBox();
            this.textbox_CustomerNIC = new System.Windows.Forms.TextBox();
            this.label_LastName = new System.Windows.Forms.Label();
            this.groupbox_StaffDetails = new System.Windows.Forms.GroupBox();
            this.textbox_StaffID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupbox_ItemsOrdered = new System.Windows.Forms.GroupBox();
            this.checkbox_Daal = new System.Windows.Forms.CheckBox();
            this.checkbox_SingaporeanRice = new System.Windows.Forms.CheckBox();
            this.checkbox_PlainRice = new System.Windows.Forms.CheckBox();
            this.checkbox_Chowmein = new System.Windows.Forms.CheckBox();
            this.checkbox_Pizza = new System.Windows.Forms.CheckBox();
            this.checkbox_Pasta = new System.Windows.Forms.CheckBox();
            this.checkbox_Bread = new System.Windows.Forms.CheckBox();
            this.checkbox_Shashlik = new System.Windows.Forms.CheckBox();
            this.checkbox_MixVegetable = new System.Windows.Forms.CheckBox();
            this.checkbox_ChickenQorma = new System.Windows.Forms.CheckBox();
            this.checkbox_ChickenKarahi = new System.Windows.Forms.CheckBox();
            this.checkbox_Nihari = new System.Windows.Forms.CheckBox();
            this.checkbox_Soup = new System.Windows.Forms.CheckBox();
            this.checkbox_Salad = new System.Windows.Forms.CheckBox();
            this.checkbox_Kheer = new System.Windows.Forms.CheckBox();
            this.checkbox_Halwa = new System.Windows.Forms.CheckBox();
            this.checkbox_Tart = new System.Windows.Forms.CheckBox();
            this.checkbox_Cake = new System.Windows.Forms.CheckBox();
            this.checkbox_IceCream = new System.Windows.Forms.CheckBox();
            this.checkbox_Smoothie = new System.Windows.Forms.CheckBox();
            this.checkbox_Shake = new System.Windows.Forms.CheckBox();
            this.checkbox_GreenTea = new System.Windows.Forms.CheckBox();
            this.checkbox_Juice = new System.Windows.Forms.CheckBox();
            this.checkbox_Custard = new System.Windows.Forms.CheckBox();
            this.checkbox_Coffee = new System.Windows.Forms.CheckBox();
            this.checkbox_MilkTea = new System.Windows.Forms.CheckBox();
            this.checkbox_Soda = new System.Windows.Forms.CheckBox();
            this.button_AddOrder = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label_Date = new System.Windows.Forms.Label();
            this.button_BackToMenu = new System.Windows.Forms.Button();
            this.groupbox_CustomerDetails.SuspendLayout();
            this.groupbox_StaffDetails.SuspendLayout();
            this.groupbox_ItemsOrdered.SuspendLayout();
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
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
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
            this.label_LastName.Location = new System.Drawing.Point(6, 90);
            this.label_LastName.Name = "label_LastName";
            this.label_LastName.Size = new System.Drawing.Size(71, 13);
            this.label_LastName.TabIndex = 4;
            this.label_LastName.Text = "Last Name:";
            this.label_LastName.Click += new System.EventHandler(this.label_LastName_Click);
            // 
            // groupbox_StaffDetails
            // 
            this.groupbox_StaffDetails.Controls.Add(this.textbox_StaffID);
            this.groupbox_StaffDetails.Controls.Add(this.label2);
            this.groupbox_StaffDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupbox_StaffDetails.Location = new System.Drawing.Point(343, 64);
            this.groupbox_StaffDetails.Name = "groupbox_StaffDetails";
            this.groupbox_StaffDetails.Size = new System.Drawing.Size(231, 63);
            this.groupbox_StaffDetails.TabIndex = 5;
            this.groupbox_StaffDetails.TabStop = false;
            this.groupbox_StaffDetails.Text = "Staff Details";
            // 
            // textbox_StaffID
            // 
            this.textbox_StaffID.Location = new System.Drawing.Point(67, 31);
            this.textbox_StaffID.Name = "textbox_StaffID";
            this.textbox_StaffID.Size = new System.Drawing.Size(133, 20);
            this.textbox_StaffID.TabIndex = 1;
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
            // groupbox_ItemsOrdered
            // 
            this.groupbox_ItemsOrdered.Controls.Add(this.checkbox_Daal);
            this.groupbox_ItemsOrdered.Controls.Add(this.checkbox_SingaporeanRice);
            this.groupbox_ItemsOrdered.Controls.Add(this.checkbox_PlainRice);
            this.groupbox_ItemsOrdered.Controls.Add(this.checkbox_Chowmein);
            this.groupbox_ItemsOrdered.Controls.Add(this.checkbox_Pizza);
            this.groupbox_ItemsOrdered.Controls.Add(this.checkbox_Pasta);
            this.groupbox_ItemsOrdered.Controls.Add(this.checkbox_Bread);
            this.groupbox_ItemsOrdered.Controls.Add(this.checkbox_Shashlik);
            this.groupbox_ItemsOrdered.Controls.Add(this.checkbox_MixVegetable);
            this.groupbox_ItemsOrdered.Controls.Add(this.checkbox_ChickenQorma);
            this.groupbox_ItemsOrdered.Controls.Add(this.checkbox_ChickenKarahi);
            this.groupbox_ItemsOrdered.Controls.Add(this.checkbox_Nihari);
            this.groupbox_ItemsOrdered.Controls.Add(this.checkbox_Soup);
            this.groupbox_ItemsOrdered.Controls.Add(this.checkbox_Salad);
            this.groupbox_ItemsOrdered.Controls.Add(this.checkbox_Kheer);
            this.groupbox_ItemsOrdered.Controls.Add(this.checkbox_Halwa);
            this.groupbox_ItemsOrdered.Controls.Add(this.checkbox_Tart);
            this.groupbox_ItemsOrdered.Controls.Add(this.checkbox_Cake);
            this.groupbox_ItemsOrdered.Controls.Add(this.checkbox_IceCream);
            this.groupbox_ItemsOrdered.Controls.Add(this.checkbox_Smoothie);
            this.groupbox_ItemsOrdered.Controls.Add(this.checkbox_Shake);
            this.groupbox_ItemsOrdered.Controls.Add(this.checkbox_GreenTea);
            this.groupbox_ItemsOrdered.Controls.Add(this.checkbox_Juice);
            this.groupbox_ItemsOrdered.Controls.Add(this.checkbox_Custard);
            this.groupbox_ItemsOrdered.Controls.Add(this.checkbox_Coffee);
            this.groupbox_ItemsOrdered.Controls.Add(this.checkbox_MilkTea);
            this.groupbox_ItemsOrdered.Controls.Add(this.checkbox_Soda);
            this.groupbox_ItemsOrdered.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupbox_ItemsOrdered.Location = new System.Drawing.Point(38, 205);
            this.groupbox_ItemsOrdered.Name = "groupbox_ItemsOrdered";
            this.groupbox_ItemsOrdered.Size = new System.Drawing.Size(536, 199);
            this.groupbox_ItemsOrdered.TabIndex = 6;
            this.groupbox_ItemsOrdered.TabStop = false;
            this.groupbox_ItemsOrdered.Text = "Items Ordered";
            // 
            // checkbox_Daal
            // 
            this.checkbox_Daal.AutoSize = true;
            this.checkbox_Daal.Location = new System.Drawing.Point(11, 121);
            this.checkbox_Daal.Name = "checkbox_Daal";
            this.checkbox_Daal.Size = new System.Drawing.Size(52, 17);
            this.checkbox_Daal.TabIndex = 26;
            this.checkbox_Daal.Text = "Daal";
            this.checkbox_Daal.UseVisualStyleBackColor = true;
            // 
            // checkbox_SingaporeanRice
            // 
            this.checkbox_SingaporeanRice.AutoSize = true;
            this.checkbox_SingaporeanRice.Location = new System.Drawing.Point(11, 167);
            this.checkbox_SingaporeanRice.Name = "checkbox_SingaporeanRice";
            this.checkbox_SingaporeanRice.Size = new System.Drawing.Size(127, 17);
            this.checkbox_SingaporeanRice.TabIndex = 25;
            this.checkbox_SingaporeanRice.Text = "Singaporean Rice";
            this.checkbox_SingaporeanRice.UseVisualStyleBackColor = true;
            // 
            // checkbox_PlainRice
            // 
            this.checkbox_PlainRice.AutoSize = true;
            this.checkbox_PlainRice.Location = new System.Drawing.Point(171, 94);
            this.checkbox_PlainRice.Name = "checkbox_PlainRice";
            this.checkbox_PlainRice.Size = new System.Drawing.Size(84, 17);
            this.checkbox_PlainRice.TabIndex = 24;
            this.checkbox_PlainRice.Text = "Plain Rice";
            this.checkbox_PlainRice.UseVisualStyleBackColor = true;
            // 
            // checkbox_Chowmein
            // 
            this.checkbox_Chowmein.AutoSize = true;
            this.checkbox_Chowmein.Location = new System.Drawing.Point(171, 71);
            this.checkbox_Chowmein.Name = "checkbox_Chowmein";
            this.checkbox_Chowmein.Size = new System.Drawing.Size(83, 17);
            this.checkbox_Chowmein.TabIndex = 23;
            this.checkbox_Chowmein.Text = "Chowmein";
            this.checkbox_Chowmein.UseVisualStyleBackColor = true;
            // 
            // checkbox_Pizza
            // 
            this.checkbox_Pizza.AutoSize = true;
            this.checkbox_Pizza.Location = new System.Drawing.Point(171, 48);
            this.checkbox_Pizza.Name = "checkbox_Pizza";
            this.checkbox_Pizza.Size = new System.Drawing.Size(56, 17);
            this.checkbox_Pizza.TabIndex = 22;
            this.checkbox_Pizza.Text = "Pizza";
            this.checkbox_Pizza.UseVisualStyleBackColor = true;
            // 
            // checkbox_Pasta
            // 
            this.checkbox_Pasta.AutoSize = true;
            this.checkbox_Pasta.Location = new System.Drawing.Point(171, 25);
            this.checkbox_Pasta.Name = "checkbox_Pasta";
            this.checkbox_Pasta.Size = new System.Drawing.Size(58, 17);
            this.checkbox_Pasta.TabIndex = 21;
            this.checkbox_Pasta.Text = "Pasta";
            this.checkbox_Pasta.UseVisualStyleBackColor = true;
            // 
            // checkbox_Bread
            // 
            this.checkbox_Bread.AutoSize = true;
            this.checkbox_Bread.Location = new System.Drawing.Point(171, 120);
            this.checkbox_Bread.Name = "checkbox_Bread";
            this.checkbox_Bread.Size = new System.Drawing.Size(59, 17);
            this.checkbox_Bread.TabIndex = 20;
            this.checkbox_Bread.Text = "Bread";
            this.checkbox_Bread.UseVisualStyleBackColor = true;
            // 
            // checkbox_Shashlik
            // 
            this.checkbox_Shashlik.AutoSize = true;
            this.checkbox_Shashlik.Location = new System.Drawing.Point(11, 144);
            this.checkbox_Shashlik.Name = "checkbox_Shashlik";
            this.checkbox_Shashlik.Size = new System.Drawing.Size(74, 17);
            this.checkbox_Shashlik.TabIndex = 19;
            this.checkbox_Shashlik.Text = "Shashlik";
            this.checkbox_Shashlik.UseVisualStyleBackColor = true;
            // 
            // checkbox_MixVegetable
            // 
            this.checkbox_MixVegetable.AutoSize = true;
            this.checkbox_MixVegetable.Location = new System.Drawing.Point(11, 95);
            this.checkbox_MixVegetable.Name = "checkbox_MixVegetable";
            this.checkbox_MixVegetable.Size = new System.Drawing.Size(102, 17);
            this.checkbox_MixVegetable.TabIndex = 18;
            this.checkbox_MixVegetable.Text = "MixVegetable";
            this.checkbox_MixVegetable.UseVisualStyleBackColor = true;
            // 
            // checkbox_ChickenQorma
            // 
            this.checkbox_ChickenQorma.AutoSize = true;
            this.checkbox_ChickenQorma.Location = new System.Drawing.Point(11, 71);
            this.checkbox_ChickenQorma.Name = "checkbox_ChickenQorma";
            this.checkbox_ChickenQorma.Size = new System.Drawing.Size(112, 17);
            this.checkbox_ChickenQorma.TabIndex = 17;
            this.checkbox_ChickenQorma.Text = "Chicken Qorma";
            this.checkbox_ChickenQorma.UseVisualStyleBackColor = true;
            // 
            // checkbox_ChickenKarahi
            // 
            this.checkbox_ChickenKarahi.AutoSize = true;
            this.checkbox_ChickenKarahi.Location = new System.Drawing.Point(11, 49);
            this.checkbox_ChickenKarahi.Name = "checkbox_ChickenKarahi";
            this.checkbox_ChickenKarahi.Size = new System.Drawing.Size(112, 17);
            this.checkbox_ChickenKarahi.TabIndex = 16;
            this.checkbox_ChickenKarahi.Text = "Chicken Karahi";
            this.checkbox_ChickenKarahi.UseVisualStyleBackColor = true;
            // 
            // checkbox_Nihari
            // 
            this.checkbox_Nihari.AutoSize = true;
            this.checkbox_Nihari.Location = new System.Drawing.Point(11, 26);
            this.checkbox_Nihari.Name = "checkbox_Nihari";
            this.checkbox_Nihari.Size = new System.Drawing.Size(59, 17);
            this.checkbox_Nihari.TabIndex = 15;
            this.checkbox_Nihari.Text = "Nihari";
            this.checkbox_Nihari.UseVisualStyleBackColor = true;
            // 
            // checkbox_Soup
            // 
            this.checkbox_Soup.AutoSize = true;
            this.checkbox_Soup.Location = new System.Drawing.Point(171, 167);
            this.checkbox_Soup.Name = "checkbox_Soup";
            this.checkbox_Soup.Size = new System.Drawing.Size(55, 17);
            this.checkbox_Soup.TabIndex = 14;
            this.checkbox_Soup.Text = "Soup";
            this.checkbox_Soup.UseVisualStyleBackColor = true;
            // 
            // checkbox_Salad
            // 
            this.checkbox_Salad.AutoSize = true;
            this.checkbox_Salad.Location = new System.Drawing.Point(171, 144);
            this.checkbox_Salad.Name = "checkbox_Salad";
            this.checkbox_Salad.Size = new System.Drawing.Size(58, 17);
            this.checkbox_Salad.TabIndex = 13;
            this.checkbox_Salad.Text = "Salad";
            this.checkbox_Salad.UseVisualStyleBackColor = true;
            // 
            // checkbox_Kheer
            // 
            this.checkbox_Kheer.AutoSize = true;
            this.checkbox_Kheer.Location = new System.Drawing.Point(313, 144);
            this.checkbox_Kheer.Name = "checkbox_Kheer";
            this.checkbox_Kheer.Size = new System.Drawing.Size(59, 17);
            this.checkbox_Kheer.TabIndex = 12;
            this.checkbox_Kheer.Text = "Kheer";
            this.checkbox_Kheer.UseVisualStyleBackColor = true;
            // 
            // checkbox_Halwa
            // 
            this.checkbox_Halwa.AutoSize = true;
            this.checkbox_Halwa.Location = new System.Drawing.Point(313, 120);
            this.checkbox_Halwa.Name = "checkbox_Halwa";
            this.checkbox_Halwa.Size = new System.Drawing.Size(61, 17);
            this.checkbox_Halwa.TabIndex = 11;
            this.checkbox_Halwa.Text = "Halwa";
            this.checkbox_Halwa.UseVisualStyleBackColor = true;
            // 
            // checkbox_Tart
            // 
            this.checkbox_Tart.AutoSize = true;
            this.checkbox_Tart.Location = new System.Drawing.Point(314, 95);
            this.checkbox_Tart.Name = "checkbox_Tart";
            this.checkbox_Tart.Size = new System.Drawing.Size(49, 17);
            this.checkbox_Tart.TabIndex = 10;
            this.checkbox_Tart.Text = "Tart";
            this.checkbox_Tart.UseVisualStyleBackColor = true;
            // 
            // checkbox_Cake
            // 
            this.checkbox_Cake.AutoSize = true;
            this.checkbox_Cake.Location = new System.Drawing.Point(314, 71);
            this.checkbox_Cake.Name = "checkbox_Cake";
            this.checkbox_Cake.Size = new System.Drawing.Size(55, 17);
            this.checkbox_Cake.TabIndex = 9;
            this.checkbox_Cake.Text = "Cake";
            this.checkbox_Cake.UseVisualStyleBackColor = true;
            // 
            // checkbox_IceCream
            // 
            this.checkbox_IceCream.AutoSize = true;
            this.checkbox_IceCream.Location = new System.Drawing.Point(314, 48);
            this.checkbox_IceCream.Name = "checkbox_IceCream";
            this.checkbox_IceCream.Size = new System.Drawing.Size(83, 17);
            this.checkbox_IceCream.TabIndex = 8;
            this.checkbox_IceCream.Text = "Ice Cream";
            this.checkbox_IceCream.UseVisualStyleBackColor = true;
            // 
            // checkbox_Smoothie
            // 
            this.checkbox_Smoothie.AutoSize = true;
            this.checkbox_Smoothie.Location = new System.Drawing.Point(427, 72);
            this.checkbox_Smoothie.Name = "checkbox_Smoothie";
            this.checkbox_Smoothie.Size = new System.Drawing.Size(78, 17);
            this.checkbox_Smoothie.TabIndex = 7;
            this.checkbox_Smoothie.Text = "Smoothie";
            this.checkbox_Smoothie.UseVisualStyleBackColor = true;
            // 
            // checkbox_Shake
            // 
            this.checkbox_Shake.AutoSize = true;
            this.checkbox_Shake.Location = new System.Drawing.Point(427, 95);
            this.checkbox_Shake.Name = "checkbox_Shake";
            this.checkbox_Shake.Size = new System.Drawing.Size(62, 17);
            this.checkbox_Shake.TabIndex = 6;
            this.checkbox_Shake.Text = "Shake";
            this.checkbox_Shake.UseVisualStyleBackColor = true;
            // 
            // checkbox_GreenTea
            // 
            this.checkbox_GreenTea.AutoSize = true;
            this.checkbox_GreenTea.Location = new System.Drawing.Point(427, 167);
            this.checkbox_GreenTea.Name = "checkbox_GreenTea";
            this.checkbox_GreenTea.Size = new System.Drawing.Size(86, 17);
            this.checkbox_GreenTea.TabIndex = 5;
            this.checkbox_GreenTea.Text = "Green Tea";
            this.checkbox_GreenTea.UseVisualStyleBackColor = true;
            // 
            // checkbox_Juice
            // 
            this.checkbox_Juice.AutoSize = true;
            this.checkbox_Juice.Location = new System.Drawing.Point(427, 49);
            this.checkbox_Juice.Name = "checkbox_Juice";
            this.checkbox_Juice.Size = new System.Drawing.Size(56, 17);
            this.checkbox_Juice.TabIndex = 4;
            this.checkbox_Juice.Text = "Juice";
            this.checkbox_Juice.UseVisualStyleBackColor = true;
            // 
            // checkbox_Custard
            // 
            this.checkbox_Custard.AutoSize = true;
            this.checkbox_Custard.Location = new System.Drawing.Point(314, 26);
            this.checkbox_Custard.Name = "checkbox_Custard";
            this.checkbox_Custard.Size = new System.Drawing.Size(69, 17);
            this.checkbox_Custard.TabIndex = 3;
            this.checkbox_Custard.Text = "Custard";
            this.checkbox_Custard.UseVisualStyleBackColor = true;
            // 
            // checkbox_Coffee
            // 
            this.checkbox_Coffee.AutoSize = true;
            this.checkbox_Coffee.Location = new System.Drawing.Point(427, 121);
            this.checkbox_Coffee.Name = "checkbox_Coffee";
            this.checkbox_Coffee.Size = new System.Drawing.Size(63, 17);
            this.checkbox_Coffee.TabIndex = 2;
            this.checkbox_Coffee.Text = "Coffee";
            this.checkbox_Coffee.UseVisualStyleBackColor = true;
            this.checkbox_Coffee.CheckedChanged += new System.EventHandler(this.checkbox_Coffee_CheckedChanged);
            // 
            // checkbox_MilkTea
            // 
            this.checkbox_MilkTea.AutoSize = true;
            this.checkbox_MilkTea.Location = new System.Drawing.Point(427, 144);
            this.checkbox_MilkTea.Name = "checkbox_MilkTea";
            this.checkbox_MilkTea.Size = new System.Drawing.Size(75, 17);
            this.checkbox_MilkTea.TabIndex = 1;
            this.checkbox_MilkTea.Text = "Milk Tea";
            this.checkbox_MilkTea.UseVisualStyleBackColor = true;
            this.checkbox_MilkTea.CheckedChanged += new System.EventHandler(this.checkbox_Tea_CheckedChanged);
            // 
            // checkbox_Soda
            // 
            this.checkbox_Soda.AutoSize = true;
            this.checkbox_Soda.Location = new System.Drawing.Point(427, 26);
            this.checkbox_Soda.Name = "checkbox_Soda";
            this.checkbox_Soda.Size = new System.Drawing.Size(55, 17);
            this.checkbox_Soda.TabIndex = 0;
            this.checkbox_Soda.Text = "Soda";
            this.checkbox_Soda.UseVisualStyleBackColor = true;
            this.checkbox_Soda.CheckedChanged += new System.EventHandler(this.checkbox_Soda_CheckedChanged);
            // 
            // button_AddOrder
            // 
            this.button_AddOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_AddOrder.Location = new System.Drawing.Point(499, 176);
            this.button_AddOrder.Name = "button_AddOrder";
            this.button_AddOrder.Size = new System.Drawing.Size(75, 23);
            this.button_AddOrder.TabIndex = 3;
            this.button_AddOrder.Text = "Add Order";
            this.button_AddOrder.UseVisualStyleBackColor = true;
            this.button_AddOrder.Click += new System.EventHandler(this.button_AddOrder_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(395, 139);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(179, 20);
            this.dateTimePicker1.TabIndex = 4;
            // 
            // label_Date
            // 
            this.label_Date.AutoSize = true;
            this.label_Date.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Date.Location = new System.Drawing.Point(349, 145);
            this.label_Date.Name = "label_Date";
            this.label_Date.Size = new System.Drawing.Size(38, 13);
            this.label_Date.TabIndex = 7;
            this.label_Date.Text = "Date:";
            // 
            // button_BackToMenu
            // 
            this.button_BackToMenu.Location = new System.Drawing.Point(465, 415);
            this.button_BackToMenu.Name = "button_BackToMenu";
            this.button_BackToMenu.Size = new System.Drawing.Size(109, 23);
            this.button_BackToMenu.TabIndex = 8;
            this.button_BackToMenu.Text = "Back to Menu";
            this.button_BackToMenu.UseVisualStyleBackColor = true;
            this.button_BackToMenu.Click += new System.EventHandler(this.button_BackToMenu_Click);
            // 
            // AddOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(606, 450);
            this.Controls.Add(this.button_BackToMenu);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.button_AddOrder);
            this.Controls.Add(this.label_Date);
            this.Controls.Add(this.groupbox_ItemsOrdered);
            this.Controls.Add(this.groupbox_StaffDetails);
            this.Controls.Add(this.groupbox_CustomerDetails);
            this.Controls.Add(this.label1);
            this.Name = "AddOrder";
            this.Text = "AddOrder";
            this.groupbox_CustomerDetails.ResumeLayout(false);
            this.groupbox_CustomerDetails.PerformLayout();
            this.groupbox_StaffDetails.ResumeLayout(false);
            this.groupbox_StaffDetails.PerformLayout();
            this.groupbox_ItemsOrdered.ResumeLayout(false);
            this.groupbox_ItemsOrdered.PerformLayout();
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
        private System.Windows.Forms.TextBox textbox_StaffID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button_AddOrder;
        private System.Windows.Forms.GroupBox groupbox_ItemsOrdered;
        private System.Windows.Forms.CheckBox checkbox_MilkTea;
        private System.Windows.Forms.CheckBox checkbox_Soda;
        private System.Windows.Forms.CheckBox checkbox_Coffee;
        private System.Windows.Forms.CheckBox checkbox_Juice;
        private System.Windows.Forms.CheckBox checkbox_Custard;
        private System.Windows.Forms.CheckBox checkbox_GreenTea;
        private System.Windows.Forms.CheckBox checkbox_Smoothie;
        private System.Windows.Forms.CheckBox checkbox_Shake;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label_Date;
        private System.Windows.Forms.CheckBox checkbox_Shashlik;
        private System.Windows.Forms.CheckBox checkbox_MixVegetable;
        private System.Windows.Forms.CheckBox checkbox_ChickenQorma;
        private System.Windows.Forms.CheckBox checkbox_ChickenKarahi;
        private System.Windows.Forms.CheckBox checkbox_Nihari;
        private System.Windows.Forms.CheckBox checkbox_Soup;
        private System.Windows.Forms.CheckBox checkbox_Salad;
        private System.Windows.Forms.CheckBox checkbox_Kheer;
        private System.Windows.Forms.CheckBox checkbox_Halwa;
        private System.Windows.Forms.CheckBox checkbox_Tart;
        private System.Windows.Forms.CheckBox checkbox_Cake;
        private System.Windows.Forms.CheckBox checkbox_IceCream;
        private System.Windows.Forms.CheckBox checkbox_PlainRice;
        private System.Windows.Forms.CheckBox checkbox_Chowmein;
        private System.Windows.Forms.CheckBox checkbox_Pizza;
        private System.Windows.Forms.CheckBox checkbox_Pasta;
        private System.Windows.Forms.CheckBox checkbox_Bread;
        private System.Windows.Forms.CheckBox checkbox_SingaporeanRice;
        private System.Windows.Forms.CheckBox checkbox_Daal;
        private System.Windows.Forms.Button button_BackToMenu;
    }
}