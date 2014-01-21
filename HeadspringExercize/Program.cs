using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FizzBuzz;

namespace HeadspringExercize
{
    public class Program
    {
        static void Main(string[] args)
        {
            FizzBuzz.HelperMethods.ConsoleOut(Console.Out,  1,100);
            Console.Write("Press any key to exit:");
            Console.Read();
        }

 
    }
}
