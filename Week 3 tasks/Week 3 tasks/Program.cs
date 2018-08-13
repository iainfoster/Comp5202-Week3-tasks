using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_3_tasks
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("please enter a number: ");
            int num1 = int.Parse(Console.ReadLine());
            Console.Write("please enter anouther number: ");
            int num2 = int.Parse(Console.ReadLine());

            if (num1 == num2)
                Console.WriteLine("the two numbers you entered are equal.");
            else if (num1 > num2)
                Console.WriteLine($"the first number entered, {num1}, is the larger of the two.");
            else
                Console.WriteLine($"the second number entered, {num2}, is the larger of the two");
            Console.WriteLine("task comeplete. Please press enter to continue.....");
            Console.ReadLine();
            Console.Clear();
        

        }
    }
}
