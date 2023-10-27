using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyList<Person> personList = new MyList<Person>();
            MyList<Student> studentList = new MyList<Student>();

            Person person1 = new Person("Alvee", 22, "Uttara");
            Person person2 = new Person("Shazid", 20, "Mirpur");
            Person person3 = new Person("Nirjhar", 23, "Barishal");
            personList.Add(person1);
            personList.Add(person2);
            personList.Add(person3);

            Student student1 = new Student("Mahin", 21, "Uttara", "IUT");
            Student student2 = new Student("Nahiyan", 20, "Banasree", "IIT");
            studentList.Add(student1);
            studentList.Add(student2);

            Console.WriteLine("The Persons are:");
            for (int i = 0; i < personList.size(); i++)
            {
                Console.WriteLine($"Name:{personList.getItem(i).name},Age: {personList.getItem(i).age },Address:{ personList.getItem(i).address }");
               
            }

            Console.WriteLine("The Students are:");

            for (int i = 0;i < studentList.size(); i++)
            {
                Console.WriteLine($"Name:{studentList.getItem(i).name},Age:{studentList.getItem(i).age},Address:{studentList.getItem(i).address},University:{studentList.getItem(i).uniName}");

                studentList.getItem(i).Study();
            }
        }
    }
}
