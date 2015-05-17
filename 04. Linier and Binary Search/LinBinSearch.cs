using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    class LinBinSearch
    {
        static void Main()
        {
            string[] input = Console.ReadLine().Split(' ');
            int[] inputInt = input.Select(int.Parse).ToArray();
            int element = int.Parse(Console.ReadLine());
            Console.WriteLine(LinearSearch(inputInt, element));
        }
        private static int LinearSearch(int[] array, int numToFind) 
        {
            int resultInt = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == numToFind) 
                {
                    resultInt = i;
                    break;
                }
                else 
                {
                    resultInt = -1;
                }
            }
            return resultInt;
        }
    }
