using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aggregation
{
    public class Program
    {
        static void Main(string[] args)
        {
            Department department = new Department();
            Employee employee1 = new Employee();
            employee1.name = "Test";
            employee1.id = "1234";
            department.addEmployee(employee1);
            employee1.work();

            
        }
    }
}
