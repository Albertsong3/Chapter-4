using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Getvowel.cs
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Any number thats less than 999");
            int Total = 0;
            while (true)
            {
                int I = Convert.ToInt32(Console.ReadLine());
                Total += I;
                Console.WriteLine("The total is   " + Total);
                if (Total I>= 999)
                    break;
            }
        }
    }
}