namespace Flight.Model
{
    partial class FormHost
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panelMain = new Panel();
            button_proceed = new Button();
            comboBox_main = new ComboBox();
            SuspendLayout();
            // 
            // panelMain
            // 
            panelMain.Location = new Point(12, 12);
            panelMain.Name = "panelMain";
            panelMain.Size = new Size(776, 388);
            panelMain.TabIndex = 0;
            // 
            // button_proceed
            // 
            button_proceed.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            button_proceed.Location = new Point(522, 415);
            button_proceed.Name = "button_proceed";
            button_proceed.Size = new Size(127, 23);
            button_proceed.TabIndex = 0;
            button_proceed.Text = "Proceed to:";
            button_proceed.UseVisualStyleBackColor = true;
            button_proceed.Click += button_proceed_Click;
            // 
            // comboBox_main
            // 
            comboBox_main.FormattingEnabled = true;
            comboBox_main.Location = new Point(655, 415);
            comboBox_main.Name = "comboBox_main";
            comboBox_main.Size = new Size(133, 23);
            comboBox_main.TabIndex = 1;
            comboBox_main.SelectedIndexChanged += comboBox_main_SelectedIndexChanged;
            // 
            // FormHost
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(comboBox_main);
            Controls.Add(button_proceed);
            Controls.Add(panelMain);
            Name = "FormHost";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Panel panelMain;
        private Button button_proceed;
        private ComboBox comboBox_main;
    }
}