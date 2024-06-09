using System.Collections.Generic;

namespace PasswordGenerator.Core.Interfaces
{
    public interface IStringGenerator
    {
        int StringSize { get; set; }
        string GenerateString(int initialValue, int finalValue);
        string GenerateStringNumbers();
    }
}
