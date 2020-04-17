using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsertionSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] list = {0, 9, 8, 7, 6, 5, 4, 3, 2, 1};

            Console.WriteLine("Before sorting: {0}", String.Join(", ", list));

            for (int i = 0, n = list.Length; i < n; i++)
            {
                int tempValue = list[i];

                // create an iterator value to go backwards on the list
                int j = i;

                // compare the current value with tempValue
                while (j > 0 && list[j - 1] > tempValue)
                {
                    list[j] = list[j - 1];
                    j--;
                }

                list[j] = tempValue;
            }

            // output new value 
            Console.WriteLine("After Insertion sort: {0}", String.Join(", ", list));

            // wait for user before closing window
            Console.ReadLine();
        }
    }
}
