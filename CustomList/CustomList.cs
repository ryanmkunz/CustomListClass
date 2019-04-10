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
            //TODO don't let user access out of bounds index
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
                items = new T[itemsNew.Length];
                for (int i = 0; i < itemsNew.Length; i++)
                {
                    items[i] = itemsNew[i];
                }
            }
            count++;
        }

        public bool Remove(T item)
        {
            int frequency = 0;
            T[] itemsNew = new T[items.Length - 1];
            for (int i = 0; i < items.Length; i++)
            {                
                if (item.Equals(items[i]) && frequency == 0)
                {
                    frequency++;
                    count--;
                }
                else if (frequency > 0)
                {
                    itemsNew[i - 1] = items[i];
                }
                else if (i == items.Length - 1 && frequency == 0)
                {
                    return false;
                }
                else
                {                    
                    itemsNew[i] = items[i];
                }
            }
            if (frequency > 0)
            {
                items = new T[itemsNew.Length];
                for (int i = 0; i < items.Length; i++)
                {
                    items[i] = itemsNew[i];                    
                }
                return true;
            }
            else
            {
                return false;
            }
        }

        public override string ToString()
        {
            string convertedString = "";
            for (int i = 0; i < items.Length; i++)
            {
                convertedString += items[i];
            }
            return convertedString;
        }
        public static CustomList<T> operator +(CustomList<T> l1, CustomList<T> l2)
        {
            return new CustomList<T>();
        }
    }
}
