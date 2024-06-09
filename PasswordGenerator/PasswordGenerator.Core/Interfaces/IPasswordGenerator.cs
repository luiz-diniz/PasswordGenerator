using PasswordGenerator.Models;
using System.Collections.Generic;

namespace PasswordGenerator.Core.Interfaces
{
    public interface IPasswordGenerator
    {
        public IEnumerable<string> GeneratePasswords(PasswordOptions passwordOptions);
    }
}
