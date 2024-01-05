namespace ETMS___Using_Sqlite
{
    partial class EmployeeForm
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
            groupBox1 = new GroupBox();
            cardnoTextBox = new TextBox();
            label5 = new Label();
            positionTextBox = new TextBox();
            label4 = new Label();
            fullnameTextBox = new TextBox();
            label3 = new Label();
            identityTextBox = new TextBox();
            label2 = new Label();
            groupBox2 = new GroupBox();
            passwordTextBox = new TextBox();
            label7 = new Label();
            usernameTextBox = new TextBox();
            label6 = new Label();
            addnewButton = new Button();
            saveButton = new Button();
            updateButton = new Button();
            dataGridView1 = new DataGridView();
            DeleteButton = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(497, 39);
            label1.Name = "label1";
            label1.Size = new Size(268, 46);
            label1.TabIndex = 0;
            label1.Text = "Employee Form";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(cardnoTextBox);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(positionTextBox);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(fullnameTextBox);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(identityTextBox);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(43, 104);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(515, 302);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = " Employee Info";
            // 
            // cardnoTextBox
            // 
            cardnoTextBox.Location = new Point(151, 241);
            cardnoTextBox.Name = "cardnoTextBox";
            cardnoTextBox.Size = new Size(233, 38);
            cardnoTextBox.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(42, 241);
            label5.Name = "label5";
            label5.Size = new Size(103, 31);
            label5.TabIndex = 6;
            label5.Text = "Card No:";
            // 
            // positionTextBox
            // 
            positionTextBox.Location = new Point(151, 179);
            positionTextBox.Name = "positionTextBox";
            positionTextBox.Size = new Size(233, 38);
            positionTextBox.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(46, 179);
            label4.Name = "label4";
            label4.Size = new Size(100, 31);
            label4.TabIndex = 4;
            label4.Text = "Position:";
            // 
            // fullnameTextBox
            // 
            fullnameTextBox.Location = new Point(151, 115);
            fullnameTextBox.Name = "fullnameTextBox";
            fullnameTextBox.Size = new Size(233, 38);
            fullnameTextBox.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(26, 118);
            label3.Name = "label3";
            label3.Size = new Size(122, 31);
            label3.TabIndex = 2;
            label3.Text = "Full Name:";
            // 
            // identityTextBox
            // 
            identityTextBox.Location = new Point(151, 50);
            identityTextBox.Name = "identityTextBox";
            identityTextBox.ReadOnly = true;
            identityTextBox.Size = new Size(233, 38);
            identityTextBox.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(27, 57);
            label2.Name = "label2";
            label2.Size = new Size(123, 31);
            label2.TabIndex = 0;
            label2.Text = "Identity Id:";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(passwordTextBox);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(usernameTextBox);
            groupBox2.Controls.Add(label6);
            groupBox2.Location = new Point(43, 414);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(515, 160);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "User Account";
            // 
            // passwordTextBox
            // 
            passwordTextBox.Location = new Point(150, 110);
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.Size = new Size(234, 38);
            passwordTextBox.TabIndex = 3;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(29, 110);
            label7.Name = "label7";
            label7.Size = new Size(115, 31);
            label7.TabIndex = 2;
            label7.Text = "Password:";
            // 
            // usernameTextBox
            // 
            usernameTextBox.Location = new Point(151, 46);
            usernameTextBox.Name = "usernameTextBox";
            usernameTextBox.Size = new Size(233, 38);
            usernameTextBox.TabIndex = 1;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(23, 49);
            label6.Name = "label6";
            label6.Size = new Size(122, 31);
            label6.TabIndex = 0;
            label6.Text = "Username:";
            label6.DataContextChanged += updateButton_Click;
            // 
            // addnewButton
            // 
            addnewButton.Location = new Point(40, 584);
            addnewButton.Name = "addnewButton";
            addnewButton.Size = new Size(117, 47);
            addnewButton.TabIndex = 3;
            addnewButton.Text = "Add New";
            addnewButton.UseVisualStyleBackColor = true;
            addnewButton.Click += addnewButton_Click;
            // 
            // saveButton
            // 
            saveButton.Location = new Point(202, 584);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(75, 47);
            saveButton.TabIndex = 4;
            saveButton.Text = "Save";
            saveButton.UseVisualStyleBackColor = true;
            saveButton.Click += saveButton_Click;
            // 
            // updateButton
            // 
            updateButton.Location = new Point(317, 584);
            updateButton.Name = "updateButton";
            updateButton.Size = new Size(106, 47);
            updateButton.TabIndex = 5;
            updateButton.Text = "Update";
            updateButton.UseVisualStyleBackColor = true;
            updateButton.Click += updateButton_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(580, 119);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(608, 512);
            dataGridView1.TabIndex = 6;
            dataGridView1.SelectionChanged += dataGridView1_SelectionChanged;
            // 
            // DeleteButton
            // 
            DeleteButton.Location = new Point(447, 585);
            DeleteButton.Name = "DeleteButton";
            DeleteButton.Size = new Size(111, 46);
            DeleteButton.TabIndex = 7;
            DeleteButton.Text = "Delete";
            DeleteButton.UseVisualStyleBackColor = true;
            DeleteButton.Click += DeleteButton_Click;
            // 
            // EmployeeForm
            // 
            AutoScaleDimensions = new SizeF(13F, 31F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1245, 670);
            Controls.Add(DeleteButton);
            Controls.Add(dataGridView1);
            Controls.Add(updateButton);
            Controls.Add(saveButton);
            Controls.Add(addnewButton);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(5);
            Name = "EmployeeForm";
            Text = "EmployeeForm";
            DataContextChanged += updateButton_Click;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private void DataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private Label label1;
        private GroupBox groupBox1;
        private TextBox cardnoTextBox;
        private Label label5;
        private TextBox positionTextBox;
        private Label label4;
        private TextBox fullnameTextBox;
        private Label label3;
        private TextBox identityTextBox;
        private Label label2;
        private GroupBox groupBox2;
        private TextBox passwordTextBox;
        private Label label7;
        private TextBox usernameTextBox;
        private Label label6;
        private Button addnewButton;
        private Button saveButton;
        private Button updateButton;
        private DataGridView dataGridView1;
        private Button DeleteButton;
    }
}