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

            //Console.WriteLine("------------------");
            //Console.WriteLine("Last element in List");
            //Console.WriteLine(LastElement);

            Console.WriteLine("------------------");
            Console.WriteLine("Reverse List");
            ReverseList().ForEach(Console.WriteLine);

            //Console.WriteLine("------------------");
            //Console.WriteLine("Shuffle List");
            //ShuffleList().ForEach(Console.WriteLine);
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


        //public static List<int> LastElement()
        //{
        //    int number = 
        //    return sortedList;
        //}

        public static List<int> ReverseList()
        {
            List<int> reversedList = ListOfIntegers();
            reversedList.Reverse();
            return reversedList;
        }

        //public static List<int> ShuffleList()
        //{
        //    List<int> shuffledList = ListOfIntegers();
        //    shuffledList.Shuffle();
        //    return shuffledList;
        //}
    }
}
