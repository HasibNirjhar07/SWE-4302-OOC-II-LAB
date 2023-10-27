using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericList
{
    public class Student:Person
    {
        public string uniName { get; set; }

       public Student(string name,int age, string address,string uniName) : base( name,  age, address)
        {
            this.uniName = uniName;
        }

        public void Study()
        {
            Console.WriteLine(name + " studies at " + uniName);
        }
    }
}
