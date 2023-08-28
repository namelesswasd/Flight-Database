namespace Flight.UI
{
    partial class PageRegister
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label_registerpage = new Label();
            textBox_password = new TextBox();
            textBox_username = new TextBox();
            label_password = new Label();
            label_username = new Label();
            comboBox_type = new ComboBox();
            label1 = new Label();
            button_register = new Button();
            SuspendLayout();
            // 
            // label_registerpage
            // 
            label_registerpage.AutoSize = true;
            label_registerpage.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label_registerpage.Location = new Point(322, 103);
            label_registerpage.Name = "label_registerpage";
            label_registerpage.Size = new Size(146, 30);
            label_registerpage.TabIndex = 1;
            label_registerpage.Text = "Register Page";
            // 
            // textBox_password
            // 
            textBox_password.Location = new Point(322, 178);
            textBox_password.Name = "textBox_password";
            textBox_password.Size = new Size(177, 23);
            textBox_password.TabIndex = 5;
            // 
            // textBox_username
            // 
            textBox_username.Location = new Point(322, 149);
            textBox_username.Name = "textBox_username";
            textBox_username.Size = new Size(177, 23);
            textBox_username.TabIndex = 6;
            // 
            // label_password
            // 
            label_password.AutoSize = true;
            label_password.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label_password.ImageAlign = ContentAlignment.MiddleRight;
            label_password.Location = new Point(259, 186);
            label_password.Name = "label_password";
            label_password.Size = new Size(57, 15);
            label_password.TabIndex = 3;
            label_password.Text = "Password";
            // 
            // label_username
            // 
            label_username.AutoSize = true;
            label_username.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label_username.ImageAlign = ContentAlignment.MiddleRight;
            label_username.Location = new Point(253, 157);
            label_username.Name = "label_username";
            label_username.Size = new Size(63, 15);
            label_username.TabIndex = 4;
            label_username.Text = "Username:";
            // 
            // comboBox_type
            // 
            comboBox_type.FormattingEnabled = true;
            comboBox_type.Location = new Point(322, 207);
            comboBox_type.Name = "comboBox_type";
            comboBox_type.Size = new Size(177, 23);
            comboBox_type.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ImageAlign = ContentAlignment.MiddleRight;
            label1.Location = new Point(284, 215);
            label1.Name = "label1";
            label1.Size = new Size(32, 15);
            label1.TabIndex = 8;
            label1.Text = "Type";
            // 
            // button_register
            // 
            button_register.Location = new Point(424, 236);
            button_register.Name = "button_register";
            button_register.Size = new Size(75, 23);
            button_register.TabIndex = 9;
            button_register.Text = "Register";
            button_register.UseVisualStyleBackColor = true;
            button_register.Click += button_register_Click;
            // 
            // PageRegister
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(button_register);
            Controls.Add(label1);
            Controls.Add(comboBox_type);
            Controls.Add(textBox_password);
            Controls.Add(textBox_username);
            Controls.Add(label_password);
            Controls.Add(label_username);
            Controls.Add(label_registerpage);
            Name = "PageRegister";
            Size = new Size(776, 388);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label_registerpage;
        private TextBox textBox_password;
        private TextBox textBox_username;
        private Label label_password;
        private Label label_username;
        private ComboBox comboBox_type;
        private Label label1;
        private Button button_register;
    }
}
