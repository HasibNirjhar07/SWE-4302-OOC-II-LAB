using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagementApp
{
    public class EmployeeManager
    {
        public List<Employee> Employees { get; set; }
        public EmployeeManager()
        {
            Employees = new List<Employee>();
        }
        public void FindAnEmployee(string name)
        {
            int tmp = 0;
            foreach (Employee employee in Employees)
            {

                if (employee.Name == name)
                {
                    Console.WriteLine("Employee Found");
                    Console.WriteLine("Name: " + employee.Name);
                    Console.WriteLine("Basic Salary: " + employee.BasicSalary);
                    Console.WriteLine("Bonus: " + employee.Bonus);
                    Console.WriteLine("Designation: " + employee.Designation);
                    Console.WriteLine("Date of Joining: " + employee.DateOfJoining);
                    Console.WriteLine("Total Salary: " + employee.getSalary());
                    tmp = 1;
                }

            }
            if (tmp == 0)
            {
                Console.WriteLine("Employee Not Found");
            }

        }

        public void UpdateEmployee(Employee employee)
        {
            int tmp = 0;
            foreach (Employee emp in Employees)
            {
                if (emp == employee)
                {
                    emp.BasicSalary = employee.BasicSalary;
                    emp.Bonus = employee.Bonus;
                    emp.Designation = employee.Designation;
                    emp.DateOfJoining = employee.DateOfJoining;
                    tmp = 1;
                }
            }
            if (tmp == 0)
            {
                Console.WriteLine("Employee Not Found");
            }

        }




        public void PrintEmployees()
        {
            foreach (Employee emp in Employees)
            {
                Console.WriteLine("Name: {0}, Salary: {1}", emp.Name, emp.getSalary());
            }
        }
    }
}
