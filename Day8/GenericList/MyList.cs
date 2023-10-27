using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericList
{
    public class MyList<T>
    {
        private T[] items;
        private int count;
        public MyList() {
        
           items = new T[10];
           count = 0;
        
        }
        public void Add(T elt) {
            if (count == items.Length)
            {

                Console.WriteLine("The Capacity is full");

            }
            else
            {
                items[count] = elt;
                count++;
            }
        }

        public T getItem(int index)
        {
            if(index < 0 || index >= items.Length)
            {
                throw new IndexOutOfRangeException("Index is out of range");

            }
            return items[index];
        }

        public T removeItem(int index)
        {
            if(index<0 || index >= items.Length)
            {
                throw new IndexOutOfRangeException("Index is out of range");
            }

            T removedItem= items[index];

            for(int i = index; i< count - 1; i++)
            {
                items[i]= items[i+1];


            }
            count--;

            return removedItem;

        }

        public int size()
        {
            return count;
        }

        public bool isEmpty()
        {
            return count == 0;
        }
        public void Clear()
        {
            count = 0;
        }

        public bool contains(T elt)
        {
            for(int i = 0; i < count; i++)
            {
                if (items[i].Equals(elt))
                {
                    return true;
                }
            }
            return false;

        }

        public T[] toArray()
        {
            T[] array = new T[count];
            Array.Copy(items, array, count);
            return array;
        }




    }
}
