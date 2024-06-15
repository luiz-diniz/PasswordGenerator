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

            Console.WriteLine("----- PasswordGenerator -----\n\n");

            try
            {
                Console.WriteLine("- Include Numbers (y or n): ");
                LoopBooleanInsertion(out var numberValue);
                passwordOptions.Numbers = numberValue;

                Console.WriteLine("\n- Include Special Characters (y or n): ");
                LoopBooleanInsertion(out var specialCharacters);
                passwordOptions.SpecialCharacters = specialCharacters;

                Console.WriteLine("\n- Include UpperCase Characters (y or n): ");
                LoopBooleanInsertion(out var upperCharacters);
                passwordOptions.UpperCaseCharacters = upperCharacters;

                Console.WriteLine("\n- Include LowerCase Characters (y or n): ");
                LoopBooleanInsertion(out var lowerCharacters);
                passwordOptions.LowerCaseCharacters = lowerCharacters;

                Console.WriteLine("\n- Passwords Size (Max 100): ");
                LoopIntegerInsertion(out var sizeValue);
                passwordOptions.Size = sizeValue;

                Console.WriteLine("\n- Quantity of passwords to be generated (Max 100): ");
                LoopIntegerInsertion(out var quantityValue);
                passwordOptions.Quantity = quantityValue;

                Console.Write($"Generating passwords... {Environment.NewLine}{Environment.NewLine}");

                Console.WriteLine(BuildResult(passwordGenerator.GeneratePasswords(passwordOptions)));
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error trying to generate the password:\n{ex.Message}");
            }                 

            Console.ReadKey();
        }

        public static void LoopBooleanInsertion(out bool value)
        {
            var validInput = false;
            value = false;

            do
            {
                var insertedValue = Console.ReadLine().Trim();

                if (String.Equals(insertedValue, "y", StringComparison.OrdinalIgnoreCase))
                {
                    value = true;
                    return;
                }
                else if(String.Equals(insertedValue, "n", StringComparison.OrdinalIgnoreCase))             
                    return;             
                
                Console.WriteLine($"Invalid value inserted. Try again: {Environment.NewLine} ");
            } while (!validInput);
        }

        public static void LoopIntegerInsertion(out int value)
        {
            var validInput = false;
            value = 0;

            do
            {
                int.TryParse(Console.ReadLine(), out var quantity);

                if(quantity > 0 && quantity <= 100)
                {
                    value = quantity;
                    return;
                }

                Console.WriteLine($"Invalid value inserted. Try again: {Environment.NewLine} ");
            } while (!validInput);
        }

        public static string BuildResult(IEnumerable<string> passwords)
        {
            var builder = new StringBuilder();

            foreach (var password in passwords)         
                builder.AppendLine($"{password} {Environment.NewLine}");

            return builder.ToString();
        }
    }
}
