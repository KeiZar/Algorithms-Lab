using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Program
{
    static void Main()
    {
        string[] input = Console.ReadLine().Split(",".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
        int counter = 0;
        string[,] inputMatrix = new string[0,0]{};
        while (input[0] != "END") 
        {
            var inputedText = input;
            for (int i = 0; i < inputedText.Length; i++)
            {
                inputMatrix[counter, i] = inputedText[i];
            }
            counter++;
            input = Console.ReadLine().Split(",".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
        }
        for (int i = 0; i < inputMatrix.GetLength(0); i++)
        {
            for (int j = 0; j < inputMatrix.GetLength(1); j++)
            {
                Console.Write(inputMatrix[i, j]);
            }
            Console.WriteLine();
        }
    }
}
