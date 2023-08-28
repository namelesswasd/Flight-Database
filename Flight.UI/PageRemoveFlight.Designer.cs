namespace Flight.UI
{
    partial class PageRemoveFlight
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
            button_removeFlight = new Button();
            textBox_ID = new TextBox();
            label_username = new Label();
            label_loginpage = new Label();
            label_fetchFlight = new Label();
            button_fetchFlight = new Button();
            SuspendLayout();
            // 
            // button_removeFlight
            // 
            button_removeFlight.Location = new Point(416, 239);
            button_removeFlight.Name = "button_removeFlight";
            button_removeFlight.Size = new Size(75, 23);
            button_removeFlight.TabIndex = 30;
            button_removeFlight.Text = "Remove";
            button_removeFlight.UseVisualStyleBackColor = true;
            button_removeFlight.Click += button_removeFlight_Click;
            // 
            // textBox_ID
            // 
            textBox_ID.Location = new Point(314, 118);
            textBox_ID.Name = "textBox_ID";
            textBox_ID.Size = new Size(177, 23);
            textBox_ID.TabIndex = 28;
            // 
            // label_username
            // 
            label_username.AutoSize = true;
            label_username.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label_username.ImageAlign = ContentAlignment.MiddleRight;
            label_username.Location = new Point(285, 126);
            label_username.Name = "label_username";
            label_username.Size = new Size(23, 15);
            label_username.TabIndex = 26;
            label_username.Text = "ID:";
            // 
            // label_loginpage
            // 
            label_loginpage.AutoSize = true;
            label_loginpage.FlatStyle = FlatStyle.Flat;
            label_loginpage.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label_loginpage.Location = new Point(325, 85);
            label_loginpage.Name = "label_loginpage";
            label_loginpage.Size = new Size(154, 30);
            label_loginpage.TabIndex = 24;
            label_loginpage.Text = "Remove Flight";
            // 
            // label_fetchFlight
            // 
            label_fetchFlight.Anchor = AnchorStyles.None;
            label_fetchFlight.AutoSize = true;
            label_fetchFlight.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label_fetchFlight.Location = new Point(314, 159);
            label_fetchFlight.Name = "label_fetchFlight";
            label_fetchFlight.Size = new Size(81, 15);
            label_fetchFlight.TabIndex = 26;
            label_fetchFlight.Text = "Preview Flight";
            label_fetchFlight.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // button_fetchFlight
            // 
            button_fetchFlight.Location = new Point(314, 239);
            button_fetchFlight.Name = "button_fetchFlight";
            button_fetchFlight.Size = new Size(96, 23);
            button_fetchFlight.TabIndex = 30;
            button_fetchFlight.Text = "Fetch Flight";
            button_fetchFlight.UseVisualStyleBackColor = true;
            button_fetchFlight.Click += button_fetchFlight_Click;
            // 
            // PageRemoveFlight
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(button_fetchFlight);
            Controls.Add(button_removeFlight);
            Controls.Add(textBox_ID);
            Controls.Add(label_fetchFlight);
            Controls.Add(label_username);
            Controls.Add(label_loginpage);
            Name = "PageRemoveFlight";
            Size = new Size(776, 388);
            Load += PageRemoveFlight_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button_removeFlight;
        private TextBox textBox_ID;
        private Label label_username;
        private Label label_loginpage;
        private Label label_fetchFlight;
        private Button button_fetchFlight;
    }
}
