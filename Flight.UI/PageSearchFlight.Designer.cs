namespace Flight.UI
{
    partial class PageSearchFlight
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
            dataGridView_searchflights = new DataGridView();
            label_username = new Label();
            label1 = new Label();
            comboBox_type = new ComboBox();
            textBox_value = new TextBox();
            button_search = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView_searchflights).BeginInit();
            SuspendLayout();
            // 
            // label_loginpage
            // 
            label_loginpage.AutoSize = true;
            label_loginpage.FlatStyle = FlatStyle.Flat;
            label_loginpage.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label_loginpage.Location = new Point(7, 8);
            label_loginpage.Name = "label_loginpage";
            label_loginpage.Size = new Size(183, 30);
            label_loginpage.TabIndex = 26;
            label_loginpage.Text = "Search flights by:";
            // 
            // dataGridView_searchflights
            // 
            dataGridView_searchflights.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_searchflights.Location = new Point(208, 41);
            dataGridView_searchflights.Name = "dataGridView_searchflights";
            dataGridView_searchflights.RowTemplate.Height = 25;
            dataGridView_searchflights.Size = new Size(557, 328);
            dataGridView_searchflights.TabIndex = 32;
            // 
            // label_username
            // 
            label_username.AutoSize = true;
            label_username.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label_username.ImageAlign = ContentAlignment.MiddleRight;
            label_username.Location = new Point(11, 55);
            label_username.Name = "label_username";
            label_username.Size = new Size(32, 15);
            label_username.TabIndex = 33;
            label_username.Text = "Type";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ImageAlign = ContentAlignment.MiddleRight;
            label1.Location = new Point(7, 86);
            label1.Name = "label1";
            label1.Size = new Size(36, 15);
            label1.TabIndex = 34;
            label1.Text = "Value";
            // 
            // comboBox_type
            // 
            comboBox_type.FormattingEnabled = true;
            comboBox_type.Location = new Point(45, 52);
            comboBox_type.Name = "comboBox_type";
            comboBox_type.Size = new Size(145, 23);
            comboBox_type.TabIndex = 35;
            // 
            // textBox_value
            // 
            textBox_value.Location = new Point(45, 81);
            textBox_value.Name = "textBox_value";
            textBox_value.Size = new Size(145, 23);
            textBox_value.TabIndex = 36;
            // 
            // button_search
            // 
            button_search.Location = new Point(101, 110);
            button_search.Name = "button_search";
            button_search.Size = new Size(89, 23);
            button_search.TabIndex = 37;
            button_search.Text = "Search!";
            button_search.UseVisualStyleBackColor = true;
            button_search.Click += button_search_Click;
            // 
            // PageSearchFlight
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(button_search);
            Controls.Add(textBox_value);
            Controls.Add(comboBox_type);
            Controls.Add(label1);
            Controls.Add(label_username);
            Controls.Add(dataGridView_searchflights);
            Controls.Add(label_loginpage);
            Name = "PageSearchFlight";
            Size = new Size(776, 388);
            Load += PageSearchFlight_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView_searchflights).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label_loginpage;
        private DataGridView dataGridView_searchflights;
        private Label label_username;
        private Label label1;
        private ComboBox comboBox_type;
        private TextBox textBox_value;
        private Button button_search;
    }
}
