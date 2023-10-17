using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagementApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            EmployeeController employeeController = new EmployeeController();
            employeeController.HireEmployee("John", 10000, 1000, "Manager", new DateTime(2010, 10, 10));
            employeeController.HireEmployee("Mary", 20000, 2000, "Manager", new DateTime(2010, 10, 10));
            employeeController.HireEmployee("Peter", 30000, 3000, "Manager", new DateTime(2010, 10, 10));
            employeeController.HireEmployee("Sam", 40000, 4000, "Manager", new DateTime(2010, 10, 10));

            List<Employee> employees = employeeController.GetAllEmployees();

            foreach (Employee employee in employees)
            {
                Console.WriteLine("Name: " + employee.Name);
                Console.WriteLine("Basic Salary: " + employee.BasicSalary);
                Console.WriteLine("Bonus: " + employee.Bonus);
                Console.WriteLine("Designation: " + employee.Designation);
                Console.WriteLine("Date of Joining: " + employee.DateOfJoining);
                Console.WriteLine("Total Salary: " + employee.CalculateSalary());
            }

            
            EmployeeManager employeeManager = new EmployeeManager();
            employeeManager.Employees = employees;
            employeeManager.FindAnEmployee("John");
            employeeManager.FindAnEmployee("Mary");

            employeeManager.UpdateEmployee(new Employee("John", 10000, 3000, "SeniorManager", new DateTime(2010, 10, 10)));

            //employeeController.RemoveEmployee(employeeManager.Employees[0]);

            employeeManager.PrintEmployees();

            //employeeManager.FindAnEmployee("John");
            ReportGenerator reportGenerator = new ReportGenerator();
            reportGenerator.GenerateReport(employeeManager.Employees);

            reportGenerator.GenerateEmployeeXMLReport(employeeManager.Employees);




            




            Console.ReadKey();
        }
    }
}
