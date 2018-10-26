using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Lav metode til at sammenligne to strenge for akronym

namespace uge1Opgave2
{
    class Program
    {
        static void Main(string[] args)
        {
            string a;
            string b;
            bool answer = false;

            Console.WriteLine("Enter first string here: ");
            a = Console.ReadLine();
            Console.WriteLine("Enter second string here: ");
            b = Console.ReadLine();

            answer = Compairer.compairStrings(a, b);
            Console.WriteLine("The two strings match: " + answer.ToString());

            Console.ReadKey();
        }
    }
}
