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
            var validInput = false;

            Console.WriteLine("----- PasswordGenerator Console version -----\n\n");

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
                    passwordOptions.UpperCaseLetters = Console.ReadLine().ToLower().Trim() == "y" ? true : false;

                    Console.WriteLine("\n- Lowecase letters: ");
                    passwordOptions.LowerCaseLetters = Console.ReadLine().ToLower().Trim() == "y" ? true : false;


                    Console.WriteLine("\n- Password size: ");
                    var size = 0;
                    var sizeSuccess = Int32.TryParse(Console.ReadLine(), out size);
                    passwordOptions.Size = size;

                    Console.WriteLine("\n- Quantity of passwords to be generated: ");
                    var quantity = 0;
                    var quantitySuccess = Int32.TryParse(Console.ReadLine(), out quantity);
                    passwordOptions.Quantity = quantity;

                    if (!ValidateInput(passwordOptions) || !sizeSuccess || !quantitySuccess)
                    {
                        Console.WriteLine("\nAlert");
                        Console.WriteLine("Invalid options defined.\n");
                        continue;
                    }

                    Console.Write(passwordOptions.Quantity > 1 ? "Your passwords are:\n\n" : "Your passwords is:\n\n");
                    Console.WriteLine(BuildResult(passwordGenerator.GeneratePassword(passwordOptions)));
                    break;

                } while (!validInput);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error trying to generate the password.");
            }                 

            Console.ReadKey();
        }

        static bool ValidateInput(PasswordOptions passwordOptions)
        {
            if ((!passwordOptions.Numbers && !passwordOptions.SpecialCharacters &&
                !passwordOptions.UpperCaseLetters && !passwordOptions.LowerCaseLetters) ||
                passwordOptions.Size <= 0 || passwordOptions.Quantity <= 0)
                return false;

            return true;
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
