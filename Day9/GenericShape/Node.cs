using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericShape
{
    class Node<T> where T : Shape
    {
        public T  Value { get; set; }
        public Node(T value) {
        Value = value;
        
        }
    }
}
