using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    public class Program
    {
        public static void Main(string[] args)
        {
           int[] list = new int[5]{390,205,182,45,235};

           SelectionSort obj = new SelectionSort();
           //var result = obj.Sort(list);

           InsertionSort insSort = new InsertionSort();
           var result = insSort.Sort(list);

           Console.WriteLine("Done");
        }


    }
}
