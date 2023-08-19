using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp95
{
    class Program
    {
        static void Main(string[] args)
        {

            int passes = 0;
            int failures = 0;
            int studentcounter = 1;

            while (studentcounter <= 10)
            {
                Console.Write("Enter result(1=fail,2=pass):");
                int result = int.Parse(Console.ReadLine());

                if (result == 1)
                {
                    passes = passes + 1;
                }
                else
                {
                    failures = failures + 1;
                }
                studentcounter = studentcounter + 1;
            }
            Console.Write($"passed=passes\nfailed=failures");

            if (passes >= 8)
            {
                Console.WriteLine("you win");
                Console.ReadLine();
            }
        }
    }
}
