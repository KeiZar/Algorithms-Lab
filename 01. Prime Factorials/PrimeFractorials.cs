using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        int input = int.Parse(Console.ReadLine());
        int divider = 2;
        int result = 0;
        List<int> dividerList = new List<int>();
        Console.Write(input + " = ");
        while (input >= divider)
        {
            if (input % divider == 0)
            {
                result = input / divider;
                input = result;
                dividerList.Add(divider);
            }
            else
            {
                divider++;
            }
        }
        string joined = string.Join<int>(" * ", dividerList);
        Console.WriteLine(joined);
    }
}

