namespace Flight.UI
{
    partial class PageListFlights
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
            dataGridView_flights = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView_flights).BeginInit();
            SuspendLayout();
            // 
            // label_loginpage
            // 
            label_loginpage.AutoSize = true;
            label_loginpage.FlatStyle = FlatStyle.Flat;
            label_loginpage.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label_loginpage.Location = new Point(12, 9);
            label_loginpage.Name = "label_loginpage";
            label_loginpage.Size = new Size(247, 30);
            label_loginpage.TabIndex = 25;
            label_loginpage.Text = "List of available flights:";
            // 
            // dataGridView_flights
            // 
            dataGridView_flights.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_flights.Location = new Point(12, 42);
            dataGridView_flights.Name = "dataGridView_flights";
            dataGridView_flights.RowTemplate.Height = 25;
            dataGridView_flights.Size = new Size(748, 327);
            dataGridView_flights.TabIndex = 31;
            // 
            // PageListFlights
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(dataGridView_flights);
            Controls.Add(label_loginpage);
            Name = "PageListFlights";
            Size = new Size(776, 388);
            Load += PageListFlights_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView_flights).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label_loginpage;
        private DataGridView dataGridView_flights;
    }
}
