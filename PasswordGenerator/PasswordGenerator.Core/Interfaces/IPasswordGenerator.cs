using PasswordGenerator.Models;
using System.Collections.Generic;

namespace PasswordGenerator.Core.Interfaces
{
    public interface IPasswordGenerator
    {
        /// <summary>
        /// Generate passwords based on user preference
        /// </summary>
        /// <param name="passwordOptions">Object cointaining all the options available for generating the passwords.</param>
        /// <returns>An IEnumerable of string with the passwords generated</returns>
        public IEnumerable<string> GeneratePasswords(PasswordOptions passwordOptions);
    }
}
