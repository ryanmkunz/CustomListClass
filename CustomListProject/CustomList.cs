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
        private T this[int i]
        {
            get { return items[i]; }
            set { items[i] = value; }
        }

        public void Add(T item)
        {

        }

       
    }
}
