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
            Harmonic head = new Harmonic();
            head.Harmonic_number();
            Console.ReadLine();
        }
    }
}
