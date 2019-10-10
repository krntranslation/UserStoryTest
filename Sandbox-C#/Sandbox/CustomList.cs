using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sandbox
{
    public class CustomList<T>
    {
        private T[] items;
        public int Size { get; private set; }
        private int count;
        private int word;
        
        public int Word
        {
            get { return word; }
            set { count = value; }
        }

        public int Count
        {
            get {return count;}

        }
        private int capacity;

        public int Capacity
        {
            get {return capacity;}
            set {capacity = value;}
        }
        public T this[int index]
        {
            get {return items[index];}
            set {items[index] = value;}
        }

        public CustomList()
        {
            items = new T[4];
            count = 0;
            capacity = 4;

        }
        public void Add(T itemToAdd)
        {
            if (capacity == count)
            {
                capacity = (2 * capacity);
                T[] newItems = new T[capacity];
                for (int i = 0; i < count; i++)
                {
                    newItems[i] = items[i];
                }
                items = newItems;

            }
            items[count] = itemToAdd;
            count += 1;
            if(count == 3)
            {
              items.ToString();
                for(int i = 0; i < items.Length; i++)
                {
                    items[i].ToString();
                       
                }
                
            }


        }
        




    }
}
