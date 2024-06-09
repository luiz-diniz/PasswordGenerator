using PasswordGenerator.Core;
using PasswordGenerator.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace PasswordGenerator.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var passwordOptions = new PasswordOptions();
            var passwordGenerator = new Core.PasswordGenerator(new StringGenerator());
            var validInput = false;

            Console.WriteLine("----- PasswordGenerator -----\n\n");

            try
            {
                do
                {
                    Console.WriteLine("-- Select which elements you want on the password using 'y or n' for each of them.\n");

                    Console.WriteLine("- Numbers: ");
                    passwordOptions.Numbers = Console.ReadLine().ToLower().Trim() == "y" ? true : false;

                    Console.WriteLine("\n- Special Characters: ");
                    passwordOptions.SpecialCharacters = Console.ReadLine().ToLower().Trim() == "y" ? true : false;

                    Console.WriteLine("\n- Uppercase letters: ");
                    passwordOptions.UpperCaseCharacters = Console.ReadLine().ToLower().Trim() == "y" ? true : false;

                    Console.WriteLine("\n- Lowecase letters: ");
                    passwordOptions.LowerCaseCharacters = Console.ReadLine().ToLower().Trim() == "y" ? true : false;

                    Console.WriteLine("\n- Password size (Max 100): ");
                    var size = 0;
                    var sizeSuccess = Int32.TryParse(Console.ReadLine(), out size);
                    passwordOptions.Size = size;

                    Console.WriteLine("\n- Quantity of passwords to be generated (Max 100): ");
                    var quantity = 0;
                    var quantitySuccess = Int32.TryParse(Console.ReadLine(), out quantity);
                    passwordOptions.Quantity = quantity;

                    Console.Write($"Generating passwords... {Environment.NewLine}{Environment.NewLine}");
                    Console.WriteLine(BuildResult(passwordGenerator.GeneratePasswords(passwordOptions)));
                    break;

                } while (!validInput);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error trying to generate the password:\n{ex.Message}");
            }                 

            Console.ReadKey();
        }

        static string BuildResult(IEnumerable<string> passwords)
        {
            var builder = new StringBuilder();

            foreach (var password in passwords)         
                builder.AppendLine($"{password} {Environment.NewLine}");

            return builder.ToString();
        }
    }
}
