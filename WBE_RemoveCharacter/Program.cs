/**
 * Write a function that accepts a string and a character, removes any instances of that character, then returns the modified string
 * ie: "potato", 't' should return "poao"
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace WBE_RemoveCharacter
{
    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                try
                {
                    Console.Write("Input a string\n\n>>> ");
                    string input = Console.ReadLine();
                    Console.Write("Enter the character to be removed\n\n>>> ");
                    char ch = Convert.ToChar(Console.ReadLine());
                    Console.WriteLine(RemoveCharacter(input, ch));
                }
                catch (Exception ex)
                {
                    Console.WriteLine("\n" + ex.Message);
                }
                Console.Write("\nPress Enter to try another string...");
                Console.ReadLine();
                Console.Clear();
            } while (true);
        }

        static string RemoveCharacter(string input, char ch)
        {
            string output = "";

            Queue myQ = new Queue();

            foreach (var x in input)
            {
                if (x != ch)
                {
                    myQ.Enqueue(x);
                }
            }
            for (int i = 0; i < myQ.Count; i++)
            {
                output += myQ.Dequeue();
            }
            return output;
        }
    }
}
