namespace Flight.UI
{
    partial class PageLogin
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
            label_loginpage = new Label();
            label_username = new Label();
            label_password = new Label();
            textBox_username = new TextBox();
            textBox_password = new TextBox();
            button_login = new Button();
            label_logged = new Label();
            SuspendLayout();
            // 
            // label_loginpage
            // 
            label_loginpage.AutoSize = true;
            label_loginpage.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label_loginpage.Location = new Point(336, 120);
            label_loginpage.Name = "label_loginpage";
            label_loginpage.Size = new Size(122, 30);
            label_loginpage.TabIndex = 0;
            label_loginpage.Text = "Login Page";
            // 
            // label_username
            // 
            label_username.AutoSize = true;
            label_username.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label_username.ImageAlign = ContentAlignment.MiddleRight;
            label_username.Location = new Point(256, 175);
            label_username.Name = "label_username";
            label_username.Size = new Size(63, 15);
            label_username.TabIndex = 1;
            label_username.Text = "Username:";
            // 
            // label_password
            // 
            label_password.AutoSize = true;
            label_password.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label_password.ImageAlign = ContentAlignment.MiddleRight;
            label_password.Location = new Point(262, 204);
            label_password.Name = "label_password";
            label_password.Size = new Size(57, 15);
            label_password.TabIndex = 1;
            label_password.Text = "Password";
            // 
            // textBox_username
            // 
            textBox_username.Location = new Point(325, 167);
            textBox_username.Name = "textBox_username";
            textBox_username.Size = new Size(177, 23);
            textBox_username.TabIndex = 2;
            // 
            // textBox_password
            // 
            textBox_password.Location = new Point(325, 196);
            textBox_password.Name = "textBox_password";
            textBox_password.Size = new Size(177, 23);
            textBox_password.TabIndex = 2;
            // 
            // button_login
            // 
            button_login.Location = new Point(427, 235);
            button_login.Name = "button_login";
            button_login.Size = new Size(75, 23);
            button_login.TabIndex = 3;
            button_login.Text = "Login";
            button_login.UseVisualStyleBackColor = true;
            button_login.Click += button_login_Click;
            // 
            // label_logged
            // 
            label_logged.AutoSize = true;
            label_logged.Font = new Font("Arial Narrow", 14.25F, FontStyle.Italic, GraphicsUnit.Point);
            label_logged.Location = new Point(3, 3);
            label_logged.Name = "label_logged";
            label_logged.Size = new Size(0, 23);
            label_logged.TabIndex = 4;
            // 
            // PageLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(label_logged);
            Controls.Add(button_login);
            Controls.Add(textBox_password);
            Controls.Add(textBox_username);
            Controls.Add(label_password);
            Controls.Add(label_username);
            Controls.Add(label_loginpage);
            Name = "PageLogin";
            Size = new Size(776, 388);
            Load += PageLogin_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label_loginpage;
        private Label label_username;
        private Label label_password;
        private TextBox textBox_username;
        private TextBox textBox_password;
        private Button button_login;
        private Label label_logged;
    }
}
