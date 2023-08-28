namespace Flight.UI
{
    partial class PageAddFlight
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
            button_addFlight = new Button();
            label1 = new Label();
            textBox_from = new TextBox();
            textBox_ID = new TextBox();
            label_password = new Label();
            label_username = new Label();
            label2 = new Label();
            label3 = new Label();
            textBox_to = new TextBox();
            textBox_price = new TextBox();
            dateTimePicker = new DateTimePicker();
            SuspendLayout();
            // 
            // label_loginpage
            // 
            label_loginpage.AutoSize = true;
            label_loginpage.FlatStyle = FlatStyle.Flat;
            label_loginpage.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label_loginpage.Location = new Point(341, 73);
            label_loginpage.Name = "label_loginpage";
            label_loginpage.Size = new Size(116, 30);
            label_loginpage.TabIndex = 1;
            label_loginpage.Text = "Add Flight";
            // 
            // button_addFlight
            // 
            button_addFlight.Location = new Point(420, 257);
            button_addFlight.Name = "button_addFlight";
            button_addFlight.Size = new Size(75, 23);
            button_addFlight.TabIndex = 16;
            button_addFlight.Text = "Add";
            button_addFlight.UseVisualStyleBackColor = true;
            button_addFlight.Click += button_addFlight_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ImageAlign = ContentAlignment.MiddleRight;
            label1.Location = new Point(289, 178);
            label1.Name = "label1";
            label1.Size = new Size(23, 15);
            label1.TabIndex = 15;
            label1.Text = "To:";
            // 
            // textBox_from
            // 
            textBox_from.Location = new Point(318, 141);
            textBox_from.Name = "textBox_from";
            textBox_from.Size = new Size(177, 23);
            textBox_from.TabIndex = 12;
            // 
            // textBox_ID
            // 
            textBox_ID.Location = new Point(318, 112);
            textBox_ID.Name = "textBox_ID";
            textBox_ID.Size = new Size(177, 23);
            textBox_ID.TabIndex = 13;
            // 
            // label_password
            // 
            label_password.AutoSize = true;
            label_password.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label_password.ImageAlign = ContentAlignment.MiddleRight;
            label_password.Location = new Point(274, 149);
            label_password.Name = "label_password";
            label_password.Size = new Size(38, 15);
            label_password.TabIndex = 10;
            label_password.Text = "From:";
            // 
            // label_username
            // 
            label_username.AutoSize = true;
            label_username.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label_username.ImageAlign = ContentAlignment.MiddleRight;
            label_username.Location = new Point(289, 120);
            label_username.Name = "label_username";
            label_username.Size = new Size(23, 15);
            label_username.TabIndex = 11;
            label_username.Text = "ID:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ImageAlign = ContentAlignment.MiddleRight;
            label2.Location = new Point(277, 207);
            label2.Name = "label2";
            label2.Size = new Size(35, 15);
            label2.TabIndex = 18;
            label2.Text = "Date:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ImageAlign = ContentAlignment.MiddleRight;
            label3.Location = new Point(277, 236);
            label3.Name = "label3";
            label3.Size = new Size(36, 15);
            label3.TabIndex = 20;
            label3.Text = "Price:";
            // 
            // textBox_to
            // 
            textBox_to.Location = new Point(318, 170);
            textBox_to.Name = "textBox_to";
            textBox_to.Size = new Size(177, 23);
            textBox_to.TabIndex = 21;
            // 
            // textBox_price
            // 
            textBox_price.Location = new Point(318, 228);
            textBox_price.Name = "textBox_price";
            textBox_price.Size = new Size(177, 23);
            textBox_price.TabIndex = 22;
            // 
            // dateTimePicker
            // 
            dateTimePicker.Location = new Point(318, 199);
            dateTimePicker.Name = "dateTimePicker";
            dateTimePicker.Size = new Size(193, 23);
            dateTimePicker.TabIndex = 23;
            // 
            // PageAddFlight
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(dateTimePicker);
            Controls.Add(textBox_price);
            Controls.Add(textBox_to);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(button_addFlight);
            Controls.Add(label1);
            Controls.Add(textBox_from);
            Controls.Add(textBox_ID);
            Controls.Add(label_password);
            Controls.Add(label_username);
            Controls.Add(label_loginpage);
            Name = "PageAddFlight";
            Size = new Size(776, 388);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label_loginpage;
        private Button button_addFlight;
        private Label label1;
        private TextBox textBox_from;
        private TextBox textBox_ID;
        private Label label_password;
        private Label label_username;
        private Label label2;
        private Label label3;
        private TextBox textBox_to;
        private TextBox textBox_price;
        private DateTimePicker dateTimePicker;
    }
}
