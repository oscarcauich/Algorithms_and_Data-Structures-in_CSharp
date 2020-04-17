using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelectionSort
{
    class Program
    {
        static void Main(string[] args)
        {

            // declare list of value
            int[] list = {0, 9, 8, 7, 6, 5, 4, 3, 2, 1};

            Console.WriteLine("Before sort: ", String.Join(", ", list));

            // iterate throught the entire list
            for (int i = 0, l = list.Length; i < l; i++)
            {
                // mininum value index
                int minValue = i;

                // iterate through the rest of the list to find if there are lesser values
                for (int j = i + 1; j < l; j++)
                {
                    //compare if previous minValue is still less than current list[j]
                    if (list[j] < list[minValue])
                    {
                        minValue = j;
                    }
                }

                // we found the small number
                int temp = list[minValue];
                list[minValue] = list[i];
                list[i] = temp;
            }

            // print output to console
            Console.WriteLine("AFter sorting: {0}", String.Join(", ", list));

            Console.ReadLine();
        }
    }
}
