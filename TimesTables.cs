using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
 
namespace Loop_Examples1
{
    class Program
    {
        static void Main(string[] args)
        {
            int num, i, result;
            Console.Write("Enter a number\t");
            num = Convert.ToInt32(Console.ReadLine());
 
            for (i = 1; i <= 10; i++)
            {
                result = num * i;
                Console.WriteLine("{0} x {1} = {2}", num, i, result);
            }
            Console.ReadLine();
        }
    }
}

