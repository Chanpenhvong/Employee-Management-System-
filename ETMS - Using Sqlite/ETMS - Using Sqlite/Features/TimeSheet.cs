using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ETMS___Using_Sqlite.Entities;
using Microsoft.EntityFrameworkCore;

namespace ETMS___Using_Sqlite.Features
{
    public class TimeSheet
    {
        public TimeSheetDbContext DbContext { get; }
        public TimeSheet()
        {
            DbContext = new TimeSheetDbContext();
        }
        public void AddEmployee(Employee emp)
        {
            if(string.IsNullOrEmpty(emp.FullName)||
                string.IsNullOrEmpty(emp.Position)||
                string.IsNullOrEmpty(emp.CardNo) ||
                string.IsNullOrEmpty(emp.UserAccount!.UserName)||
                string.IsNullOrEmpty(emp.UserAccount.Password))
            {
                throw new ArgumentException("Please provide all employee data!");
            }
            else
            {
                DbContext.Employees.Add(emp);
                DbContext.SaveChanges();
            }
        }
        public void UpdateEmployee(string IdentityId, string FullName, string Position){
            if (string.IsNullOrEmpty(FullName) || string.IsNullOrEmpty(Position))
            {
                throw new ArgumentException("Please provide all employee data!");
            }
            var emp = DbContext.Employees.Find(new Guid(IdentityId));
            if (emp == null)
            {
                throw new ArgumentException("Employee not found!");
            }
            //update the employee data
            emp.FullName = FullName;
            emp.Position = Position;
            DbContext.SaveChanges();
        
        }
        public void DeleteEmployee(string IdentityId)
        {
            var emp = DbContext.Employees.Find(new Guid(IdentityId));
            if (emp == null)
            {
                throw new ArgumentException("Employee not found!");
            }
            DbContext.Employees.Remove(emp);
            DbContext.SaveChanges();
        }
        public void LogEmployee(string CardNo, Log LogInfo)
        {
            if (string.IsNullOrEmpty(CardNo))
            {
                throw new ArgumentException("Card No is empty!");
            }
            var emp = DbContext.Employees.
                Include(l => l.Logs).
                FirstOrDefault(emp => emp.CardNo == CardNo.Trim());

            if (emp == null)
            {
                throw new ArgumentException($"Card No {CardNo} not found in empoyee list.");
            }
            emp.Logs!.Add(LogInfo);
            DbContext.SaveChanges();
        }
        public List<EmployeeView> GetAllEmployee()
        {
            return DbContext.Employees.Select(emp => new EmployeeView()
            {
                IdentityId =emp.EmployeeId,
                FullName =emp.FullName,
                Position =emp.Position,
                CardNo = emp.CardNo
            }).ToList();
        }

        public List<Employee> GetAllEmployees(bool isSimpleVersion) {
            return DbContext.Employees.ToList();
        }

    }
}
