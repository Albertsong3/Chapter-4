using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Perfect
{
    class Program
    {
        static void Main(String[] args)
        {
            int Number = 1, counter, sum = 0, mod;

            while (Number <= 1000)
            {
                counter = Number - 1;

                while (counter > 0)
                {
                    mod = Number % counter;

                    if (mod.Equals(0))
                        sum = sum + counter;
                    counter--;

                }

                if (sum.Equals(Number))
                    Console.WriteLine(Number);

                sum = 0;

                Number++;
            }
            

        }
    }
}
