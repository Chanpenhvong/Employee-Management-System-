using ETMS___Using_Sqlite.Entities;
using ETMS___Using_Sqlite.Features;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ETMS___Using_Sqlite
{
    public partial class ClockManagement : Form
    {
        TimeSheet timeSheet;
        public ClockManagement(TimeSheet timeSheet)
        {
            this.timeSheet = timeSheet;
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            currentTimeLabel.Text = DateTime.Now.ToString();
        }

        private void clockinButton_Click(object sender, EventArgs e)
        {
            try
            {
                var log = new Log() { TimeStamp = DateTime.Now, Timeshift = 0 };
                timeSheet.LogEmployee(cardnoTextBox.Text, log);
                ShowMessage("Time-in Successfully!", true);
            }
            catch (ArgumentException Ec)
            {
                ShowMessage(Ec.Message, false);
            }
        }

        private void timeoutButton_Click(Object sender, EventArgs e)
        {
            try
            {
                var log = new Log() { TimeStamp = DateTime.Now, Timeshift = 0 };
                timeSheet.LogEmployee(cardnoTextBox.Text, log);
                ShowMessage("Time-in Successfully!", true);
            }
            catch (ArgumentException Ec)
            {
                ShowMessage(Ec.Message, false);
            }
        }
        private void ShowMessage(string message, bool Issucceed)
        {

            if (Issucceed)
            {
                MessageBox.Show(message, "Application Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(message, "Application Info", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            cardnoTextBox.Clear();
            cardnoTextBox.Focus();
        }
    }
}
