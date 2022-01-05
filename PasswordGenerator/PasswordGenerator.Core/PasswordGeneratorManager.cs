using PasswordGenerator.Models;
using System;
using System.Text;

namespace PasswordGenerator.Core
{
    public class PasswordGeneratorManager : IPasswordGeneratorManager
    {
        public string Generate(PasswordOptions passwordOptions)
        {
            string numericChars = "";
            string upperChars = "";
            string lowerChars = "";
            string specialChars = "";

            //characters numbers based on the ascii table
            if(passwordOptions.Numbers)
                numericChars =  GenerateCharacters(0, 9, passwordOptions.MaxSize, true).ToString();
            if(passwordOptions.SpecialCharacters)
                specialChars = GenerateCharacters(33, 43, passwordOptions.MaxSize, false).ToString();
            if(passwordOptions.UpperCaseLetters)
                upperChars = GenerateCharacters(65, 90, passwordOptions.MaxSize, false).ToString();
            if(passwordOptions.LowerCaseLetters)
                lowerChars = GenerateCharacters(97, 122, passwordOptions.MaxSize, false).ToString();

            return specialChars;
        }

        private string GenerateCharacters(int initialRange, int finalRange, int size, bool isNumber)
        {
            var builder = new StringBuilder();
            var random = new Random();

            for (int i = 0; i < size; i++)
            {
                int random_num = random.Next(initialRange, finalRange);

                if (isNumber)
                   builder.Append(random_num.ToString());               
                else
                   builder.Append(Convert.ToChar(random_num).ToString());
            }

            return builder.ToString();
        }
    }
}