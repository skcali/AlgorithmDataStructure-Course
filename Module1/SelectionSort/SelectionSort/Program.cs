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

            int[] lst = { 4, 9, 7, 1, 3, 6, 5 };
            int n = lst.Length;
            for (int i = 0; i < n; i++)
            {
                int MinIndex = i;
                for (int j = i; j < n; j++)
                {
                    if (lst[MinIndex] > lst[j])
                    {
                        MinIndex = j;
                    }
                }
                int temp = lst[i];
                lst[i] = lst[MinIndex];
                lst[MinIndex] = temp;
            }
            
            foreach(int i in lst)
            {
                Console.Write(i + ", ");
            }
        }
    }
}
