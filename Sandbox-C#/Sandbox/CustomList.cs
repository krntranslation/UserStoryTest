﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;


namespace Sandbox
{
    public class CustomList<T> : IEnumerable
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
            get { return count; }

        }

        private int capacity;

        public int Capacity
        {
            get { return capacity; }
            set { capacity = value; }
        }
        public T this[int index]
        {
            get { return items[index]; }
            set { items[index] = value; }
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
        }
        public void Remove(T itemToRemove)
        {
            for (int i = 0; i < count; i++)
            {
                if (itemToRemove.Equals(items[i]))
                {
                    count -= 1;
                    for (int j = i; j < (count + 1); j++)
                    {
                        items[j] = items[j + 1];
                    }
                }
                else
                {
                    items[i] = items[i];
                }
            }
        }

        public override string ToString()
        {
            string itemsWord = "[";

            for (int i = 0; i < count; i++)
            {
                string word = items[i].ToString();
                if (i == count - 1)
                {
                    itemsWord += word + "]";
                    break;
                }
                itemsWord += word + ", ";
            }
            return itemsWord;
        }
       
        private string[] items1;
        private List<string> items2;
       
        
        public static CustomList<T> operator +(CustomList<T> firstList, CustomList<T> secondList)
        {
            CustomList<int> item = new CustomList<int>();
            
            for(int i = 0; i < item.count; i++)
            {
                for(int j = 0; j < item.count; j++)
                {

                }
            }
        }


         public IEnumerator GetEnumerator()
        {
            for(int i = 0;i < items.Length; i++)
            {
                
                yield return items1[i];
                yield return items2[2];
                //return this.GetEnumerator();
            }
            
        }

    }
}



