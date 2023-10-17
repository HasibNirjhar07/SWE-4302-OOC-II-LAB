using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagementApp
{
    public class EmployeeController
    {
        public List<Employee> Employees = new List<Employee>();


        public void HireEmployee(string name, double basicSalary, double bonus, string designation, DateTime dateOfJoining)
        {
            Employee employee1 = new Employee(name, basicSalary, bonus, designation, dateOfJoining);
            Employees.Add(employee1);

        }
        public List<Employee> GetAllEmployees()
        {
            return Employees;
        }

        public void RemoveEmployee(Employee employee)
        {
            //code to remove employee object from the list\

            Employees.Remove(employee);

        }

    }
}
