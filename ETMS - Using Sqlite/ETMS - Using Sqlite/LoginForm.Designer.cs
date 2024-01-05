namespace ETMS___Using_Sqlite
{
    partial class LoginForm
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
            LoinForm = new Label();
            label1 = new Label();
            usernameTextBox = new TextBox();
            label2 = new Label();
            passwordTextBox = new TextBox();
            loginButton = new Button();
            SuspendLayout();
            // 
            // LoinForm
            // 
            LoinForm.AutoSize = true;
            LoinForm.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
            LoinForm.Location = new Point(338, 55);
            LoinForm.Margin = new Padding(5, 0, 5, 0);
            LoinForm.Name = "LoinForm";
            LoinForm.Size = new Size(236, 54);
            LoinForm.TabIndex = 0;
            LoinForm.Text = "Login Form";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(159, 187);
            label1.Name = "label1";
            label1.Size = new Size(124, 31);
            label1.TabIndex = 1;
            label1.Text = "Username:";
            // 
            // usernameTextBox
            // 
            usernameTextBox.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            usernameTextBox.Location = new Point(307, 180);
            usernameTextBox.Name = "usernameTextBox";
            usernameTextBox.Size = new Size(321, 38);
            usernameTextBox.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(165, 253);
            label2.Name = "label2";
            label2.Size = new Size(118, 31);
            label2.TabIndex = 3;
            label2.Text = "Password:";
            // 
            // passwordTextBox
            // 
            passwordTextBox.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            passwordTextBox.Location = new Point(307, 253);
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.Size = new Size(321, 38);
            passwordTextBox.TabIndex = 4;
            // 
            // loginButton
            // 
            loginButton.Location = new Point(388, 363);
            loginButton.Name = "loginButton";
            loginButton.Size = new Size(122, 45);
            loginButton.TabIndex = 5;
            loginButton.Text = "Login";
            loginButton.UseVisualStyleBackColor = true;
            loginButton.Click += LoginButton_Click;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(13F, 31F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(862, 482);
            Controls.Add(loginButton);
            Controls.Add(passwordTextBox);
            Controls.Add(label2);
            Controls.Add(usernameTextBox);
            Controls.Add(label1);
            Controls.Add(LoinForm);
            Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            Margin = new Padding(5);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "LoginForm";
            Text = "  Login Form";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LoinForm;
        private Label label1;
        private TextBox usernameTextBox;
        private Label label2;
        private TextBox passwordTextBox;
        private Button loginButton;
    }
}