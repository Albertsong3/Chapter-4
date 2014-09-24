using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EvenNums
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 2;
            int red;

            while (num <= 100)
            {
                red = num % 2;
                if (red.Equals(0))
                    Console.WriteLine(num);

                num++;
            }


            
            

           
        }
    }
}
