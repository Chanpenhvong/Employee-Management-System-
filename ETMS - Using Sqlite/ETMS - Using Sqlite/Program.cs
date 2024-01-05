using ETMS___Using_Sqlite.Entities;
using ETMS___Using_Sqlite.Features;

namespace ETMS___Using_Sqlite
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            TimeSheet AppTimeSheet = new TimeSheet();
            AppTimeSheet.DbContext.Database.EnsureCreated();

            var emp = AppTimeSheet.DbContext.Employees.FirstOrDefault();
            if (emp == null)
            {
                var aEmp = new Employee()
                {
                    FullName = "Admin",
                    Position = "Admin",
                    CardNo = "001",
                    UserAccount = new UserAccount()
                    {
                        UserName = "Admin",
                        Password = "123"
                    }
                };
                AppTimeSheet.DbContext.Employees.Add(aEmp);
                AppTimeSheet.DbContext.SaveChanges();
            }
            Application.Run(new LoginForm(AppTimeSheet));
        }
    }
}