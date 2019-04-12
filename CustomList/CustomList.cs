using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomListProject
{
    public class CustomList<T> : IEnumerable where T : IComparable
    {
        private T[] items = new T[1];
        
        public T this[int i]
        {
            get
            {
                if (i < count && i >= 0)
                {
                    return items[i];
                }
                else
                {
                    throw new ArgumentOutOfRangeException(string.Format("index out of range"));
                }                
            }
            set
            {
                if (i < count && i >= 0)
                {
                    items[i] = value;
                }                
            }
        }
        private int count;
        public int Count
        {
            get
            {               
                return count;
            }
        }

        //---------------------------------------------------
        //What is happening here?

        //when a foreach loop is hit it calls on the GetEnumerator method
        //

        int position = -1;
        //IEnumerator and IEnumerable require these methods.
        public IEnumerator GetEnumerator()
        {
            for (int index = 0; index < count; index++)
            {
                yield return items[index];                
            }
        }

        //IEnumerator
        public bool MoveNext()
        {
            position++;
            return (position < count);
        }

        //IEnumerable
        public void Reset()
        { position = 0; }

        //IEnumerable
        public object Current
        {
            get { return items[position]; }
        }
        //---------------------------------------------------

        public void Add(T item)
        {            
            if (count == 0)
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
            CustomList<T> Combination = new CustomList<T>();
            for (int i = 0; i < (l1.count); i++)
            {
                Combination.Add(l1[i]);
            }
            for (int i = 0; i < (l2.count); i++)
            {
                Combination.Add(l2[i]);
            }
            return Combination;
        }

        public static CustomList<T> operator -(CustomList<T> l1, CustomList<T> l2)
        {
            for (int i = 0; i < l2.count; i++)
            {
                for (int j = 0; j < l1.count; j++)
                {
                    if (l1[j].Equals(l2[i]))
                    {
                        l1.Remove(l1[j]);
                    }
                }
            }
            return l1;
        }

        public CustomList<T> Zip(CustomList<T> l1)
        {
            CustomList<T> Combination = new CustomList<T>();
            for (int i = 0; i < Math.Max(count,l1.count); i++)
            {
                if (count > i)
                {
                    Combination.Add(items[i]);
                }
                if (l1.count > i)
                {
                    Combination.Add(l1[i]);
                }                
            }
            return Combination;
        }

        public CustomList<T> Sort() //bubble sort
        {
            int i;
            int j;

            for (j = count-1; j > 0; j--)
            {
                for (i = 0; i < j; i++)
                {
                    if (items[i].CompareTo(items[i+1]) > 0)
                    {
                        exchange(this, i, i + 1);
                    }
                }            
            }
            return this;
        }

        public void exchange(CustomList<T> l1, int m, int n)
        {
            T temporary;
            temporary = l1[m];
            l1[m] = l1[n];
            l1[n] = temporary;
        }
    }
}
