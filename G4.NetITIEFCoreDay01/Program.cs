using G4.NetITIEFCoreDay01.Context;
using G4.NetITIEFCoreDay01.Model;
using Microsoft.EntityFrameworkCore;

namespace G4.NetITIEFCoreDay01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CompanyContext db = new CompanyContext();

            //Employee E1 = new Employee() { Name = "Ziad", Age = 25, Salary = 4000 };

            //Employee E2 = new Employee() { Name = "Ziad", Age = 25, Salary = 4000 };
            //Employee E3 = new Employee() { Name = "Ziad", Age = 25, Salary = 4000 };
            //Employee E4 = new Employee() { Name = "Ziad", Age = 25, Salary = 4000 };
            //Employee E5 = new Employee() { Name = "Ziadaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa", Age = 25, Salary = 4000 };

            //db.Employees.AddRange([E2, E3, E4]);
            //db.Employees.Add(E5); Ex
            //db.SaveChanges();

            //Department d1 = new Department { DeptName="SD"};
            //Department d2 = new Department { DeptName="HR"};
            //db.Departments.Add(d1);
            //db.Departments.Add(d2);
            //db.SaveChanges();

            //Employee E6 = new Employee() { Name = "Mohamed", Age = 25, Salary = 4000, DepartmentId = 1 };
            //Employee E7 = new Employee() { Name = "Mohamed", Age = 25, Salary = 4000, DepartmentId = 2 };
            //db.Employees.Add(E6);
            //db.Employees.Add(E7);
            //db.SaveChanges();

            // LINQ to EF
            //var q1 = db.Employees.ToList();
            //var q2 = db.Departments.ToList();


            var q3 = db
                .Employees
                .Include(e => e.Department)
                .ToList();

            foreach (var item in q3)
            {
                Console.WriteLine(item);
            }
        }
    }
}
