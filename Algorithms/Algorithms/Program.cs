using System;

namespace Algorithms
{
    public class Program
    {
        public static void Main(string[] args)
        {
           var list = new int[5]{390,205,182,45,235};

           var obj = new SelectionSort();
           //var result = obj.Sort(list);

           var insSort = new InsertionSort();
           var result = insSort.Sort(list);

           Console.WriteLine("Done");
        }


    }
}
