using ETMS___Using_Sqlite.Features;

namespace ETMS___Using_Sqlite;
public partial class LoginForm : Form
{
    private TimeSheet _timeSheet;
    public LoginForm(TimeSheet timeSheet)
    {
        InitializeComponent();
        _timeSheet = timeSheet;
    }

    private void LoginButton_Click(object sender, EventArgs e)
    {
        var un = usernameTextBox.Text.Trim();
        var ps = passwordTextBox.Text.Trim();
        Authentication auth = new Authentication(_timeSheet.DbContext, un, ps);
        try
        {
            bool result = auth.ValidateLogin();
            if (result)
            {
                this.Hide();
                MainForm mfrm = new MainForm(_timeSheet);
                mfrm.Show();
            }
            else
            {
                MessageBox.Show("Incorrect username or password!");
            }
        }
        catch (ArgumentException Ae)
        {
            MessageBox.Show(Ae.Message);
        }
    }
}