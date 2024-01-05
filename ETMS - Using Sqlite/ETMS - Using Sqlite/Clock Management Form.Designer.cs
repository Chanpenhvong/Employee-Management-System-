namespace ETMS___Using_Sqlite
{
    partial class ClockManagement
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
            components = new System.ComponentModel.Container();
            label1 = new Label();
            currentTimeLabel = new Label();
            label2 = new Label();
            cardnoTextBox = new TextBox();
            clockinButton = new Button();
            clockoutButton = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(337, 45);
            label1.Name = "label1";
            label1.Size = new Size(200, 46);
            label1.TabIndex = 0;
            label1.Text = "Clock Form";
            // 
            // currentTimeLabel
            // 
            currentTimeLabel.AutoSize = true;
            currentTimeLabel.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            currentTimeLabel.Location = new Point(381, 124);
            currentTimeLabel.Name = "currentTimeLabel";
            currentTimeLabel.Size = new Size(99, 46);
            currentTimeLabel.TabIndex = 1;
            currentTimeLabel.Text = "Time";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(231, 229);
            label2.Name = "label2";
            label2.Size = new Size(103, 31);
            label2.TabIndex = 2;
            label2.Text = "Card No:";
            // 
            // cardnoTextBox
            // 
            cardnoTextBox.Location = new Point(340, 226);
            cardnoTextBox.Name = "cardnoTextBox";
            cardnoTextBox.Size = new Size(279, 38);
            cardnoTextBox.TabIndex = 3;
            // 
            // clockinButton
            // 
            clockinButton.Location = new Point(265, 319);
            clockinButton.Name = "clockinButton";
            clockinButton.Size = new Size(128, 52);
            clockinButton.TabIndex = 4;
            clockinButton.Text = "Time-in";
            clockinButton.UseVisualStyleBackColor = true;
            clockinButton.Click += clockinButton_Click;
            // 
            // clockoutButton
            // 
            clockoutButton.Location = new Point(469, 319);
            clockoutButton.Name = "clockoutButton";
            clockoutButton.Size = new Size(129, 52);
            clockoutButton.TabIndex = 5;
            clockoutButton.Text = "Time-out";
            clockoutButton.UseVisualStyleBackColor = true;
            // 
            // ClockManagement
            // 
            AutoScaleDimensions = new SizeF(13F, 31F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(827, 464);
            Controls.Add(clockoutButton);
            Controls.Add(clockinButton);
            Controls.Add(cardnoTextBox);
            Controls.Add(label2);
            Controls.Add(currentTimeLabel);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(5);
            Name = "ClockManagement";
            Text = "Clock Management";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label currentTimeLabel;
        private Label label2;
        private TextBox cardnoTextBox;
        private Button clockinButton;
        private Button clockoutButton;
        private System.Windows.Forms.Timer timer1;
    }
}