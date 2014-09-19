using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            char user;
            string input;

            for (int i = 1; i <= 100; i++)
            {
                Console.WriteLine("Enter a vowel");
                input = Console.ReadLine();
                user = Convert.ToChar(input);




                if (user == '!')
                    break;
                switch (user)
                {
                    case 'a': Console.WriteLine("Ok");
                        break;

                    case 'e': Console.WriteLine("Ok");
                        break;

                    case 'i': Console.WriteLine("Ok");
                        break;

                    case 'o': Console.WriteLine("Ok");
                        break;

                    case 'u': Console.WriteLine("Ok");
                        break;

                    case 'A': Console.WriteLine("Ok");
                        break;

                    case 'E': Console.WriteLine("Ok");
                        break;

                    case 'I': Console.WriteLine("Ok");
                        break;

                    case 'O': Console.WriteLine("Ok");
                        break;

                    case 'U': Console.WriteLine("Ok");
                        break;

                    default: Console.WriteLine("Error");
                        break;

                }

            }
        }
    }
}
