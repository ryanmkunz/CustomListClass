using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomListProject
{
    class Program
    {
        static void Main(string[] args)
        {                
            CustomList<int> numbers = new CustomList<int>();
            numbers.Add(5);
            numbers.Add(10);
            numbers.Add(15);
            numbers.Add(20);
            numbers.Add(25);
        }
    }
}
