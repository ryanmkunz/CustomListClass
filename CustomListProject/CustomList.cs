using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomListProject
{
    public class CustomList<T>
    {
        private T[] items = new T[1];
        
        public T this[int i]
        {
            get { return items[i]; }
            set { items[i] = value; }
        }
        private int count;
        public int Count
        {
            get
            {               
                return count;
            }
        }

        public void Add(T item)
        {
            
            if (Count == 0)
            {
                items[0] = item;
            }
            else
            {
                T[] itemsNew = new T[items.Length + 1];
                for (int i = 0; i < items.Length; i++)
                {
                    itemsNew[i] = items[i];
                }
                itemsNew[itemsNew.Length - 1] = item;
                items = new T[items.Length + 1];
                for (int i = 0; i < itemsNew.Length; i++)
                {
                    items[i] = itemsNew[i];
                }
            }
            count++;
        }
    }
}
