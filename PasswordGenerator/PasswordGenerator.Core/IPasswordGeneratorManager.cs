using PasswordGenerator.Models;

namespace PasswordGenerator.Core
{
    public interface IPasswordGeneratorManager
    {
        public string[] GeneratePassword(PasswordOptions passwordOptions);
    }
}
