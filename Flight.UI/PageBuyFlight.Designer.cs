namespace Flight.UI
{
    partial class PageBuyFlight
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
            dataGridView1 = new DataGridView();
            label_username = new Label();
            label1 = new Label();
            textBox_flightID = new TextBox();
            button_purchase = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label_loginpage
            // 
            label_loginpage.AutoSize = true;
            label_loginpage.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label_loginpage.Location = new Point(18, 16);
            label_loginpage.Name = "label_loginpage";
            label_loginpage.Size = new Size(112, 30);
            label_loginpage.TabIndex = 1;
            label_loginpage.Text = "Buy flight";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(184, 51);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(563, 309);
            dataGridView1.TabIndex = 2;
            // 
            // label_username
            // 
            label_username.AutoSize = true;
            label_username.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label_username.ImageAlign = ContentAlignment.MiddleRight;
            label_username.Location = new Point(184, 28);
            label_username.Name = "label_username";
            label_username.Size = new Size(238, 15);
            label_username.TabIndex = 3;
            label_username.Text = "Flights that you reserved with your account:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ImageAlign = ContentAlignment.MiddleRight;
            label1.Location = new Point(18, 61);
            label1.Name = "label1";
            label1.Size = new Size(53, 15);
            label1.TabIndex = 4;
            label1.Text = "Flight ID";
            // 
            // textBox_flightID
            // 
            textBox_flightID.Location = new Point(18, 79);
            textBox_flightID.Name = "textBox_flightID";
            textBox_flightID.Size = new Size(140, 23);
            textBox_flightID.TabIndex = 5;
            // 
            // button_purchase
            // 
            button_purchase.Location = new Point(83, 108);
            button_purchase.Name = "button_purchase";
            button_purchase.Size = new Size(75, 23);
            button_purchase.TabIndex = 6;
            button_purchase.Text = "Purchase!";
            button_purchase.UseVisualStyleBackColor = true;
            button_purchase.Click += button_purchase_Click;
            // 
            // PageBuyFlight
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(button_purchase);
            Controls.Add(textBox_flightID);
            Controls.Add(label1);
            Controls.Add(label_username);
            Controls.Add(dataGridView1);
            Controls.Add(label_loginpage);
            Name = "PageBuyFlight";
            Size = new Size(776, 388);
            Load += PageBuyFlight_Load;
            VisibleChanged += PageBuyFlight_VisibleChanged;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label_loginpage;
        private DataGridView dataGridView1;
        private Label label_username;
        private Label label1;
        private TextBox textBox_flightID;
        private Button button_purchase;
    }
}
