using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//This is an int list with four values added, and then one removed
namespace CustomListProject
{
    class Program
    {
        static void Main(string[] args)
        {                
            CustomList<int> numbers = new CustomList<int>();
            bool result;

            numbers.Add(5);
            numbers.Add(10);
            numbers.Add(15);
            numbers.Add(20);

            //This will remove the item 15 from the list
            result = numbers.Remove(15);
        }
    }
}
