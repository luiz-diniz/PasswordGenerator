using System.Collections.Generic;

namespace PasswordGenerator.Core.Interfaces
{
    public interface IStringGenerator
    {
        /// <summary>
        /// Size of the string to be generated.
        /// </summary>
        int StringSize { get; set; }

        /// <summary>
        /// Generate a string of random characters based on a user defined range (inclusive) of the ASCII table.
        /// </summary>
        /// <returns>A random string.</returns>
        string GenerateString(int initialValue, int finalValue);

        /// <summary>
        /// Generate a string of random numbers.
        /// </summary>
        /// <returns>A random string of numbers.</returns>
        string GenerateStringNumbers();
    }
}
