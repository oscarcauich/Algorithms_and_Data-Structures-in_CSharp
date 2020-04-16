using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BubbleSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] list = {0,9,8,7,6,5,4,3,2,1};

            // list before sorting them

            Console.WriteLine("Before Sort: {0}", String.Join(", ",  list));

            bool swapped;

            // check if we have elements to swap
            do
            {
                swapped = false;

                // go through each element and compare element with adjacent element
                for (int i = 0, n = list.Length; i < n - 1; i++)
                {
                    // check if left element and greater than right element and swap if true
                    if (list[i] > list[i + 1])
                    {
                        int temp = list[i];
                        list[i] = list[i + 1];
                        list[i + 1] = temp;

                        // we swapped
                        swapped = true;
                    }
                }
            } while (swapped);

            // Write output to console window
            Console.WriteLine("After bubbleSort: {0}", String.Join(", ", list));

            // prevent console window from closing, so we can see the final result;
            Console.ReadLine();
        }
    }
}
