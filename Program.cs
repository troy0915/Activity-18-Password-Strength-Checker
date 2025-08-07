using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Activity_18_Password_Strength_Checker
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int passwordCount = 5;
            string[] passwords = new string[passwordCount];
            char[] specialChars = { '!', '@', '#', '$', '%', '^', '&', '*', '(', ')', '-', '+' };

            Console.WriteLine("Enter 5 passwords to validate:");

            for (int i = 0; i < passwordCount; i++)
            {
                Console.Write($"Password {i + 1}: ");
                passwords[i] = Console.ReadLine();

                bool hasLength = passwords[i].Length >= 8;
                bool hasUpper = passwords[i].Any(char.IsUpper);
                bool hasDigit = passwords[i].Any(char.IsDigit);
                bool hasSpecial = passwords[i].IndexOfAny(specialChars) >= 0;

                Console.Write($"Validation: ");

                if (!hasLength)
                {
                    Console.WriteLine("Invalid (must be at least 8 characters)");
                }
                else if (!hasUpper || !hasDigit || !hasSpecial)
                {
                    Console.Write("Weak - missing:");
                    if (!hasUpper) Console.Write(" uppercase letter,");
                    if (!hasDigit) Console.Write(" digit,");
                    if (!hasSpecial) Console.Write(" special character,");
                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine("Strong - meets all requirements");
                }

                Console.WriteLine();
            }
        }
    }
}
