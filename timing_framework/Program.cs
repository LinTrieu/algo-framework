using System;
using System.Collections.Generic;
using System.Linq;

namespace timing_framework
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("------------------");
            Console.WriteLine("List of Integers");
            ListOfIntegers().ForEach(Console.WriteLine);
            Console.WriteLine("------------------");
            Console.WriteLine("Sorted List");
            SortsList().ForEach(Console.WriteLine);
            Console.WriteLine("------------------");
        }

        public static List<int> ListOfIntegers()
        {
            List<int> numbers = new List<int> { 5, 2, 3, 1, 4 };
            return numbers;
        }

        public static List<int> SortsList()
        {
            List<int> sortedList = ListOfIntegers();
            sortedList.Sort();
            return sortedList;
        }

        //public void WriteToConsole(IEnumerable items)
        //{
        //    foreach (object i in items)
        //    {
        //        Console.WriteLine(i);
        //    }
        //}
    }
}
