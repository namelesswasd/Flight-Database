namespace Flight.UI
{
    partial class PageReserveFlight
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
            button_reserve = new Button();
            textBox_flightID = new TextBox();
            label_password = new Label();
            label_username = new Label();
            dateTimePicker = new DateTimePicker();
            SuspendLayout();
            // 
            // label_loginpage
            // 
            label_loginpage.AutoSize = true;
            label_loginpage.FlatStyle = FlatStyle.Flat;
            label_loginpage.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label_loginpage.Location = new Point(308, 71);
            label_loginpage.Name = "label_loginpage";
            label_loginpage.Size = new Size(166, 30);
            label_loginpage.TabIndex = 26;
            label_loginpage.Text = "Reserve a flight";
            // 
            // button_reserve
            // 
            button_reserve.Location = new Point(410, 183);
            button_reserve.Name = "button_reserve";
            button_reserve.Size = new Size(75, 23);
            button_reserve.TabIndex = 31;
            button_reserve.Text = "Reserve";
            button_reserve.UseVisualStyleBackColor = true;
            button_reserve.Click += button_reserve_Click;
            // 
            // textBox_flightID
            // 
            textBox_flightID.Location = new Point(308, 116);
            textBox_flightID.Name = "textBox_flightID";
            textBox_flightID.Size = new Size(177, 23);
            textBox_flightID.TabIndex = 30;
            // 
            // label_password
            // 
            label_password.AutoSize = true;
            label_password.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label_password.ImageAlign = ContentAlignment.MiddleRight;
            label_password.Location = new Point(267, 151);
            label_password.Name = "label_password";
            label_password.Size = new Size(35, 15);
            label_password.TabIndex = 27;
            label_password.Text = "Date:";
            // 
            // label_username
            // 
            label_username.AutoSize = true;
            label_username.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label_username.ImageAlign = ContentAlignment.MiddleRight;
            label_username.Location = new Point(246, 124);
            label_username.Name = "label_username";
            label_username.Size = new Size(56, 15);
            label_username.TabIndex = 28;
            label_username.Text = "Flight ID:";
            // 
            // dateTimePicker
            // 
            dateTimePicker.Location = new Point(308, 145);
            dateTimePicker.Name = "dateTimePicker";
            dateTimePicker.Size = new Size(193, 23);
            dateTimePicker.TabIndex = 32;
            // 
            // PageReserveFlight
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(dateTimePicker);
            Controls.Add(button_reserve);
            Controls.Add(textBox_flightID);
            Controls.Add(label_password);
            Controls.Add(label_username);
            Controls.Add(label_loginpage);
            Name = "PageReserveFlight";
            Size = new Size(776, 388);
            Load += PageReserveFlight_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label_loginpage;
        private Button button_reserve;
        private TextBox textBox_flightID;
        private Label label_password;
        private Label label_username;
        private DateTimePicker dateTimePicker;
    }
}
