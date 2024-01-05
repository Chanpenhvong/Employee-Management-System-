namespace ETMS___Using_Sqlite
{
    partial class MainForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            timeRecordButton = new Button();
            manageEmployeeButton = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(282, 48);
            label1.Name = "label1";
            label1.Size = new Size(676, 54);
            label1.TabIndex = 0;
            label1.Text = "Employee Timesheet Management";
            // 
            // timeRecordButton
            // 
            timeRecordButton.Location = new Point(501, 183);
            timeRecordButton.Name = "timeRecordButton";
            timeRecordButton.Size = new Size(223, 63);
            timeRecordButton.TabIndex = 1;
            timeRecordButton.Text = "Time Record";
            timeRecordButton.UseVisualStyleBackColor = true;
            timeRecordButton.Click += timeRecordButton_Click;
            // 
            // manageEmployeeButton
            // 
            manageEmployeeButton.Location = new Point(485, 296);
            manageEmployeeButton.Name = "manageEmployeeButton";
            manageEmployeeButton.Size = new Size(259, 63);
            manageEmployeeButton.TabIndex = 2;
            manageEmployeeButton.Text = "Manage Employee";
            manageEmployeeButton.UseVisualStyleBackColor = true;
            manageEmployeeButton.Click += manageEmployeeButton_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(13F, 31F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1232, 460);
            Controls.Add(manageEmployeeButton);
            Controls.Add(timeRecordButton);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(5);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "MainForm";
            Text = "MainForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button timeRecordButton;
        private Button manageEmployeeButton;
    }
}