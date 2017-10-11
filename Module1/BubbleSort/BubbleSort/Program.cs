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
            int[] arr = { 4, 9, 7, 1, 3, 6, 5 };
            bool swapped = true;
            while(swapped)
            {
                swapped = false;
                for (int i = 0; i < arr.Length-1; i++)
                {
                    if (arr[i] > arr[i+1])
                    {
                        int temp = arr[i];
                        arr[i] = arr[i + 1];
                        arr[i + 1] = temp;
                        swapped = true;
                    }
                }
            }
            foreach (int i in arr)
            {
                Console.Write(i + ", ");
            }
        }
    }
}
