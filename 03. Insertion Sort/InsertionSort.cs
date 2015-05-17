using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class SelectionSort
{
    static void Main()
    {
        string[] input = Console.ReadLine().Split(' ');
        int[] inputInt = input.Select(int.Parse).ToArray();
        int lowest, newIndex;
        for (int i = 0; i < inputInt.Length - 1; i++)
        {
            lowest = i;
            for (int j = i + 1; j < inputInt.Length; j++)
            {
                if (inputInt[j] < inputInt[lowest])
                {
                    lowest = j;
                }
            }
            newIndex = inputInt[i];
            inputInt[i] = inputInt[lowest];
            inputInt[lowest] = newIndex;

        }
        for (int i = 0; i < inputInt.Length; i++)
        {
            Console.Write(inputInt[i] + " ");
        }

    }
}
