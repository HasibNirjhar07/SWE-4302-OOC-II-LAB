using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Task_2
{
    public class Teacher
    {
        public void teach(Student student)
        {
            Console.WriteLine(" Teacher is teaching .");
            student.learn();
            Console.ReadKey();
        }
    }
}

