using PasswordGenerator.Core.Interfaces;
using System;
using System.Text;

namespace PasswordGenerator.Core
{
    public class StringGenerator : IStringGenerator
    {
        public int StringSize { get; set; }

        public string GenerateString(int initialValue, int finalValue)
        {
            var builder = new StringBuilder();
            var random = new Random();

            for (int i = 0; i < StringSize; i++)
            {
                int random_num = random.Next(initialValue, finalValue + 1);

                builder.Append(Convert.ToChar(random_num));
            }

            return builder.ToString();
        }

        public string GenerateStringNumbers()
        {
            var builder = new StringBuilder();
            var random = new Random();

            for (int i = 0; i < StringSize; i++)            
                builder.Append(random.Next(0, 10));

            return builder.ToString();
        }
    }
}
