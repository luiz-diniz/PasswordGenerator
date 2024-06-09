using Microsoft.Extensions.Logging;
using PasswordGenerator.Core.Interfaces;
using PasswordGenerator.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PasswordGenerator.Core
{
    public class PasswordGenerator : IPasswordGenerator
    {
        private readonly IStringGenerator _stringGenerator;
        private readonly ILogger<PasswordGenerator> _logger;

        public PasswordGenerator(IStringGenerator stringGenerator, ILogger<PasswordGenerator> logger = null)
        {
            _stringGenerator = stringGenerator;
            _logger = logger;
        }

        public IEnumerable<string> GeneratePasswords(PasswordOptions passwordOptions)
        {
            try
            {
                ValidateOptions(passwordOptions);
                
                return EnumeratePasswords(passwordOptions);
            }
            catch (Exception ex)
            {
                _logger?.LogError(ex, $"Error trying to generate the passwords: {ex.Message}");
                throw;
            }
        }

        private IEnumerable<string> EnumeratePasswords(PasswordOptions passwordOptions)
        {
            for (int i = 0; i < passwordOptions.Quantity; i++)
                yield return Generate(passwordOptions);
        }

        private string Generate(PasswordOptions passwordOptions)
        {
            var generatedStringResult = new StringBuilder();

            _stringGenerator.StringSize = passwordOptions.Size;

            if (passwordOptions.Numbers)
                generatedStringResult.Append(_stringGenerator.GenerateStringNumbers());
            if (passwordOptions.SpecialCharacters)
                generatedStringResult.Append(_stringGenerator.GenerateString(33, 43));
            if (passwordOptions.UpperCaseCharacters)
                generatedStringResult.Append(_stringGenerator.GenerateString(65, 90));
            if (passwordOptions.LowerCaseCharacters)
                generatedStringResult.Append(_stringGenerator.GenerateString(97, 122));

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

        private void ValidateOptions(PasswordOptions passwordOptions)
        {
            if (passwordOptions == null)
                throw new ArgumentNullException(nameof(passwordOptions), "Password options object is null.");

            if (passwordOptions.Quantity <= 0 || passwordOptions.Quantity > 100)
                throw new ArgumentOutOfRangeException(nameof(passwordOptions.Quantity), "Invalid passwords quantities. Passwords quantities must be between 1 and 100.");

            if (passwordOptions.Size <= 0 || passwordOptions.Size > 100)
                throw new ArgumentOutOfRangeException(nameof(passwordOptions.Size), "Invalid password size. Password size must be between 1 and 100.");

            if (!passwordOptions.Numbers && !passwordOptions.UpperCaseCharacters && !passwordOptions.LowerCaseCharacters && !passwordOptions.SpecialCharacters)
                throw new ArgumentOutOfRangeException("CharactersOptions", "All options are setted to false. Set at least one to true.");

            LogPasswordOptions(passwordOptions);
        }

        private void LogPasswordOptions(PasswordOptions passwordOptions)
        {
            _logger?.LogInformation(
                 $@"Password Options chosen:
                    Size: {passwordOptions.Size}{Environment.NewLine} 
                    Numbers: {passwordOptions.Numbers}{Environment.NewLine} 
                    SpecialCharacters: {passwordOptions.SpecialCharacters}{Environment.NewLine}
                    UpperCaseCharacters: {passwordOptions.UpperCaseCharacters}{Environment.NewLine}
                    LowerCaseCharacters: {passwordOptions.LowerCaseCharacters}{Environment.NewLine}
                    Quantity: {passwordOptions.Quantity}{Environment.NewLine}");

        }
    }
}