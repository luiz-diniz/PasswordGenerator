using PasswordGenerator.Core;
using PasswordGenerator.Models;
using System;

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

            Console.Write("Your password is:\n");
            Console.WriteLine(passwordGenerator.Generate(passwordOptions));

            Console.ReadKey();
        }
    }
}
