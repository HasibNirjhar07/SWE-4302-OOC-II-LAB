using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace EmployeeManagementApp
{
    public class ReportGenerator
    {
        public void GenerateEmployeeXMLReport(List<Employee> Employees, string outputPath)
        {
            try
            {
                const string XmlVersion = "1.0";
                const string XmlEncoding = "utf-8";
                const string XmlStandalone = "yes";

                var xmlDocument = new XDocument(
                    new XDeclaration(XmlVersion, XmlEncoding, XmlStandalone),
                    new XElement("EmployeeData",
                        Employees.Select(employee => new XElement("Employee",
                            new XElement("Name", employee.Name),
                            new XElement("BasicSalary", employee.BasicSalary),
                            new XElement("Bonus", employee.Bonus),
                            new XElement("Designation", employee.Designation),
                            new XElement("DateOfJoining", employee.DateOfJoining),
                            new XElement("TotalSalary", employee.CalculateSalary())
                        ))
                    )
                );

                xmlDocument.Save(outputPath);

                Console.WriteLine("Employee XML report generated successfully.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error generating the employee XML report: {ex.Message}");
            }
        }
        public void GenerateReport(List<Employee> employees)
        {
            EmployeeController employeeController = new EmployeeController();
            Console.WriteLine(employeeController.GetAllEmployees().Count);
            string outputPath = @"C:\SWE-4302-OOC-II-LAB\Day7\EmployeeReport\EmployeeReport.xml";

            Console.WriteLine(outputPath);
            GenerateEmployeeXMLReport(employeeController.GetAllEmployees(), outputPath);
        }
    }

}

