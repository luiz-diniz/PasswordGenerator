using PasswordGenerator.Models;
using System;
using System.Linq;
using System.Text;

namespace PasswordGenerator.Core
{
    public class PasswordGeneratorManager : IPasswordGeneratorManager
    {
        public string[] GeneratePassword(PasswordOptions passwordOptions)
        {
            if (passwordOptions == null)
                throw new ArgumentNullException(nameof(passwordOptions), "Password options object is null.");

            if (passwordOptions.Quantity <= 0)
                throw new ArgumentOutOfRangeException(nameof(passwordOptions), "Invalid quantity value.");

            if (passwordOptions.Size <= 0)
                throw new ArgumentOutOfRangeException(nameof(passwordOptions), "Invalid password size. Password size must be higher than zero.");

            string[] passwords = new string[passwordOptions.Quantity];

            for (int i = 0; i < passwords.Length; i++)
                passwords[i] = Generate(passwordOptions);

            return passwords;
        }

        private string Generate(PasswordOptions passwordOptions)
        {
            var generatedStringResult = new StringBuilder();

            //characters numbers based on the ascii table
            if(passwordOptions.Numbers)
                generatedStringResult.Append(GenerateCharacters(0, 9, passwordOptions.Size, true).ToString());
            if(passwordOptions.SpecialCharacters)
                generatedStringResult.Append(GenerateCharacters(33, 43, passwordOptions.Size, false).ToString());
            if(passwordOptions.UpperCaseLetters)
                generatedStringResult.Append(GenerateCharacters(65, 90, passwordOptions.Size, false).ToString());
            if(passwordOptions.LowerCaseLetters)
                generatedStringResult.Append(GenerateCharacters(97, 122, passwordOptions.Size, false).ToString());

            var appendedCharacters = generatedStringResult.ToString().ToArray();

            return RandomizeCharacters(appendedCharacters).Substring(0, passwordOptions.Size);
        }

        private string RandomizeCharacters(char[] text)
        {
            var random = new Random();

            for (int i = 0; i < text.Length; i++)
            {
                var randomIndex = random.Next(0, text.Length);
                var temp = text[randomIndex];
                text[randomIndex] = text[i];
                text[i] = temp;
            }

            return new string(text);
        }

        private string GenerateCharacters(int initialRange, int finalRange, int size, bool isNumber)
        {
            var builder = new StringBuilder();
            var random = new Random();

            for (int i = 0; i < size; i++)
            {
                int random_num = random.Next(initialRange, finalRange + 1);

                if (isNumber)
                   builder.Append(random_num.ToString());               
                else
                   builder.Append(Convert.ToChar(random_num).ToString());
            }

            return builder.ToString();
        }     
    }
}