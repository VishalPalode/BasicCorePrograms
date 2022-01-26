using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCoreProgram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Basic core program");
            FlipCoin head = new FlipCoin();
            head.Checkpercentage();
            Console.ReadLine();
        }
    }
}
