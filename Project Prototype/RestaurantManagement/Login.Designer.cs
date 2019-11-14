namespace RestaurantManagement
{
    partial class Login
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
            this.label_UserName = new System.Windows.Forms.Label();
            this.textbox_UserName = new System.Windows.Forms.TextBox();
            this.textbox_Password = new System.Windows.Forms.TextBox();
            this.label_Password = new System.Windows.Forms.Label();
            this.button_Login = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label_UserName
            // 
            this.label_UserName.AutoSize = true;
            this.label_UserName.Location = new System.Drawing.Point(112, 104);
            this.label_UserName.Name = "label_UserName";
            this.label_UserName.Size = new System.Drawing.Size(75, 19);
            this.label_UserName.TabIndex = 0;
            this.label_UserName.Text = "Username:";
            this.label_UserName.Click += new System.EventHandler(this.label1_Click);
            // 
            // textbox_UserName
            // 
            this.textbox_UserName.Location = new System.Drawing.Point(203, 99);
            this.textbox_UserName.Name = "textbox_UserName";
            this.textbox_UserName.Size = new System.Drawing.Size(217, 26);
            this.textbox_UserName.TabIndex = 1;
            this.textbox_UserName.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textbox_Password
            // 
            this.textbox_Password.Location = new System.Drawing.Point(203, 143);
            this.textbox_Password.Name = "textbox_Password";
            this.textbox_Password.Size = new System.Drawing.Size(217, 26);
            this.textbox_Password.TabIndex = 3;
            // 
            // label_Password
            // 
            this.label_Password.AutoSize = true;
            this.label_Password.Location = new System.Drawing.Point(115, 148);
            this.label_Password.Name = "label_Password";
            this.label_Password.Size = new System.Drawing.Size(71, 19);
            this.label_Password.TabIndex = 2;
            this.label_Password.Text = "Password:";
            // 
            // button_Login
            // 
            this.button_Login.Location = new System.Drawing.Point(328, 215);
            this.button_Login.Name = "button_Login";
            this.button_Login.Size = new System.Drawing.Size(92, 39);
            this.button_Login.TabIndex = 4;
            this.button_Login.Text = "Login";
            this.button_Login.UseVisualStyleBackColor = true;
            this.button_Login.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(111, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(312, 27);
            this.label3.TabIndex = 5;
            this.label3.Text = "Restaurant Management System";
            this.label3.Click += new System.EventHandler(this.Label3_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(527, 301);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button_Login);
            this.Controls.Add(this.textbox_Password);
            this.Controls.Add(this.label_Password);
            this.Controls.Add(this.textbox_UserName);
            this.Controls.Add(this.label_UserName);
            this.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Login";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_UserName;
        private System.Windows.Forms.TextBox textbox_UserName;
        private System.Windows.Forms.TextBox textbox_Password;
        private System.Windows.Forms.Label label_Password;
        private System.Windows.Forms.Button button_Login;
        private System.Windows.Forms.Label label3;
    }
}

