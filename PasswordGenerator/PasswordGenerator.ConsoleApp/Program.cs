using PasswordGenerator.Core;
using PasswordGenerator.Models;
using System;
using System.Text;

namespace PasswordGenerator.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var passwordOptions = new PasswordOptions();
            var passwordGenerator = new PasswordGeneratorManager();

            Console.WriteLine("----- PasswordGenerator Console version -----\n\n");

            Console.WriteLine("-- Select which elements you want on the password using 'y or n' for each of them.\n");

            Console.WriteLine("- Numbers: ");
            passwordOptions.Numbers = Console.ReadLine().ToLower().Trim() == "y" ? true : false;

            Console.WriteLine("\n- Special Characters: ");
            passwordOptions.SpecialCharacters = Console.ReadLine().ToLower().Trim() == "y" ? true : false;

            Console.WriteLine("\n- Uppercase letters: ");
            passwordOptions.UpperCaseLetters = Console.ReadLine().ToLower().Trim() == "y" ? true : false;

            Console.WriteLine("\n- Lowecase letters: ");
            passwordOptions.LowerCaseLetters = Console.ReadLine().ToLower().Trim() == "y" ? true : false;

            Console.WriteLine("\n- Password size: ");
            passwordOptions.Size =  Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\n- Quantity of passwords to be generated: ");
            passwordOptions.Quantity = Convert.ToInt32(Console.ReadLine());

            Console.Write(passwordOptions.Quantity > 1 ? "Your passwords are:\n\n" : "Your passwords is:\n\n");
            Console.WriteLine(BuildResult(passwordGenerator.GeneratePassword(passwordOptions)));

            Console.ReadKey();
        }

        static string BuildResult(string[] passwords)
        {
            var builder = new StringBuilder();

            foreach (var password in passwords)
            {
                builder.AppendLine($"{password}");
                builder.AppendLine();
            }

            return builder.ToString();
        }
    }
}
