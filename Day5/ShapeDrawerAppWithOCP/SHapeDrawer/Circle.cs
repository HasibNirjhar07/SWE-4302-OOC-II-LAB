﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SHapeDrawer
{
    public class Circle:IShape
    {
        public double Radius { get; set; }
        public Circle(double radius)
        {
            Radius = radius;
        }
        public void Draw()
        {
            Console.WriteLine("Drawing Circle");
        }
        public double calculateArea()
        {
            return Math.PI * Radius * Radius;
        }
    }
}
