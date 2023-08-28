namespace Flight.UI
{
    partial class PageModifyFlight
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
            dateTimePicker = new DateTimePicker();
            textBox_price = new TextBox();
            textBox_to = new TextBox();
            label3 = new Label();
            label2 = new Label();
            button_modifyFlight = new Button();
            label1 = new Label();
            textBox_from = new TextBox();
            textBox_ID = new TextBox();
            label_password = new Label();
            label_username = new Label();
            label_loginpage = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // dateTimePicker
            // 
            dateTimePicker.Location = new Point(315, 210);
            dateTimePicker.Name = "dateTimePicker";
            dateTimePicker.Size = new Size(193, 23);
            dateTimePicker.TabIndex = 35;
            // 
            // textBox_price
            // 
            textBox_price.Location = new Point(315, 239);
            textBox_price.Name = "textBox_price";
            textBox_price.Size = new Size(177, 23);
            textBox_price.TabIndex = 34;
            // 
            // textBox_to
            // 
            textBox_to.Location = new Point(315, 181);
            textBox_to.Name = "textBox_to";
            textBox_to.Size = new Size(177, 23);
            textBox_to.TabIndex = 33;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ImageAlign = ContentAlignment.MiddleRight;
            label3.Location = new Point(274, 247);
            label3.Name = "label3";
            label3.Size = new Size(36, 15);
            label3.TabIndex = 32;
            label3.Text = "Price:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ImageAlign = ContentAlignment.MiddleRight;
            label2.Location = new Point(274, 218);
            label2.Name = "label2";
            label2.Size = new Size(35, 15);
            label2.TabIndex = 31;
            label2.Text = "Date:";
            // 
            // button_modifyFlight
            // 
            button_modifyFlight.Location = new Point(417, 268);
            button_modifyFlight.Name = "button_modifyFlight";
            button_modifyFlight.Size = new Size(75, 23);
            button_modifyFlight.TabIndex = 30;
            button_modifyFlight.Text = "Modify";
            button_modifyFlight.UseVisualStyleBackColor = true;
            button_modifyFlight.Click += button_modifyFlight_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ImageAlign = ContentAlignment.MiddleRight;
            label1.Location = new Point(286, 189);
            label1.Name = "label1";
            label1.Size = new Size(23, 15);
            label1.TabIndex = 29;
            label1.Text = "To:";
            // 
            // textBox_from
            // 
            textBox_from.Location = new Point(315, 152);
            textBox_from.Name = "textBox_from";
            textBox_from.Size = new Size(177, 23);
            textBox_from.TabIndex = 27;
            // 
            // textBox_ID
            // 
            textBox_ID.Location = new Point(315, 96);
            textBox_ID.Name = "textBox_ID";
            textBox_ID.Size = new Size(177, 23);
            textBox_ID.TabIndex = 28;
            // 
            // label_password
            // 
            label_password.AutoSize = true;
            label_password.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label_password.ImageAlign = ContentAlignment.MiddleRight;
            label_password.Location = new Point(271, 160);
            label_password.Name = "label_password";
            label_password.Size = new Size(38, 15);
            label_password.TabIndex = 25;
            label_password.Text = "From:";
            // 
            // label_username
            // 
            label_username.AutoSize = true;
            label_username.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label_username.ImageAlign = ContentAlignment.MiddleRight;
            label_username.Location = new Point(238, 99);
            label_username.Name = "label_username";
            label_username.Size = new Size(71, 15);
            label_username.TabIndex = 26;
            label_username.Text = "Modifier ID:";
            // 
            // label_loginpage
            // 
            label_loginpage.AutoSize = true;
            label_loginpage.FlatStyle = FlatStyle.Flat;
            label_loginpage.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label_loginpage.Location = new Point(329, 54);
            label_loginpage.Name = "label_loginpage";
            label_loginpage.Size = new Size(145, 30);
            label_loginpage.TabIndex = 24;
            label_loginpage.Text = "Modify Flight";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ImageAlign = ContentAlignment.MiddleRight;
            label4.Location = new Point(365, 134);
            label4.Name = "label4";
            label4.Size = new Size(67, 15);
            label4.TabIndex = 36;
            label4.Text = "New values";
            // 
            // PageModifyFlight
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(label4);
            Controls.Add(dateTimePicker);
            Controls.Add(textBox_price);
            Controls.Add(textBox_to);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(button_modifyFlight);
            Controls.Add(label1);
            Controls.Add(textBox_from);
            Controls.Add(textBox_ID);
            Controls.Add(label_password);
            Controls.Add(label_username);
            Controls.Add(label_loginpage);
            Name = "PageModifyFlight";
            Size = new Size(776, 388);
            Load += PageModifyFlight_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker dateTimePicker;
        private TextBox textBox_price;
        private TextBox textBox_to;
        private Label label3;
        private Label label2;
        private Button button_modifyFlight;
        private Label label1;
        private TextBox textBox_from;
        private TextBox textBox_ID;
        private Label label_password;
        private Label label_username;
        private Label label_loginpage;
        private Label label4;
    }
}
