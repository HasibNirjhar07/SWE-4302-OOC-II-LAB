


﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;


namespace EmployeeManagementApp
{
    public class Employee
    {
        public string Name { get; set; }
        public double Salary { get; set; }
        public double BasicSalary { get; set; }
        public double Bonus { get; set; }
        public string Designation { get; set; }
        public DateTime DateOfJoining { get; set; }
        public double HouseAllowance { get; set; }
        public double TransportAllowance { get; private set; }
        public double CostOfLiving { get; private set; }


        public Employee(string name, double basicSalary, double bonus, string designation, DateTime dateOfJoining)
        {
            Name = name;
            BasicSalary = basicSalary;
            Bonus = bonus;
            Designation = designation;
            DateOfJoining = dateOfJoining;
        }

        public double getSalary()
        {
            return BasicSalary + HouseAllowance + TransportAllowance + CostOfLiving + Bonus;
        }

        public double CalculateSalary()
        {
            double houseAllowancePercentage = 0.4 ;
            double transportAllowance = 5000;
            double costOfLiving = 800;
            double houseAllowance = BasicSalary * houseAllowancePercentage;
            return BasicSalary + houseAllowance + transportAllowance + costOfLiving + Bonus;
        }


    }

   
       


    }


