using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TableofSquares.cs
{
    class Program
    {
        static void Main(string[] args)
        {
            int number;
            while (number <= 20)
            {
                Console.WriteLine(number + " " + (number * number));
            }
            number++;
        }
        Console.ReadLine();

        }
    }
}
