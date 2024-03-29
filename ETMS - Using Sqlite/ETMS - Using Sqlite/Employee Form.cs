﻿using ETMS___Using_Sqlite.Entities;
using ETMS___Using_Sqlite.Features;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ETMS___Using_Sqlite
{
    public partial class EmployeeForm : Form
    {
        TimeSheet timeSheet;
        public EmployeeForm(TimeSheet timeSheet)
        {
            InitializeComponent();
            this.timeSheet = timeSheet;
            LoadToGrid();

            updateButton.Enabled = false;
            saveButton.Enabled = false;
        }

        private void addnewButton_Click(object sender, EventArgs e)
        {
            fullnameTextBox.Clear();
            positionTextBox.Clear();
            cardnoTextBox.Clear();
            usernameTextBox.Clear();
            passwordTextBox.Clear();
            fullnameTextBox.Focus();
            saveButton.Enabled = true;
        }

        private void saveButton_Click(Object sender, EventArgs e)
        {
            try
            {
                var emp = new Employee()
                {
                    FullName = fullnameTextBox.Text.Trim(),
                    Position = positionTextBox.Text.Trim(),
                    CardNo = cardnoTextBox.Text.Trim(),
                    UserAccount = new UserAccount()
                    {
                        UserName = usernameTextBox.Text.Trim(),
                        Password = passwordTextBox.Text.Trim()
                    }
                };
                timeSheet.AddEmployee(emp);
                LoadToGrid();
            }
            catch (ArgumentException Ae)
            {
                MessageBox.Show(Ae.Message);
            }
            finally
            {
                addnewButton.Enabled = true;
                saveButton.Enabled = false;
            }

        }
        private void LoadToGrid()
        {
            dataGridView1.DataSource = timeSheet.GetAllEmployee();
            dataGridView1.Refresh();
        }
        private void LoadToGrid(bool isSimpleVersion)
        {
            dataGridView1.DataSource = timeSheet.GetAllEmployees(isSimpleVersion);
            dataGridView1.Refresh();
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            try
            {
                timeSheet.UpdateEmployee(identityTextBox.Text, fullnameTextBox.Text,
                    positionTextBox.Text);
                LoadToGrid();
            }
            catch (ArgumentException Ae)
            {
                MessageBox.Show(Ae.Message);
            }
            finally
            {

                addnewButton.Enabled = true;
                saveButton.Enabled = true;
                updateButton.Enabled = false;
            }
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows != null && dataGridView1.SelectedRows.Count > 0)
            {
                identityTextBox.Text = dataGridView1.SelectedCells[0].Value.ToString();
                fullnameTextBox.Text = dataGridView1.SelectedCells[1].Value.ToString();
                positionTextBox.Text = dataGridView1.SelectedCells[2].Value.ToString();
                cardnoTextBox.Text = dataGridView1.SelectedCells[3].Value.ToString();
                addnewButton.Enabled = false;
                saveButton.Enabled = false;
                updateButton.Enabled = true;

            }
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            try
            {
                timeSheet.DeleteEmployee(identityTextBox.Text);
                LoadToGrid();
            }
            catch (ArgumentException Ae)
            {
                MessageBox.Show(Ae.Message);
            }
            finally
            {

                addnewButton.Enabled = true;
                saveButton.Enabled = true;
                updateButton.Enabled = false;
            }
        }
    }
}
