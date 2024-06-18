using System;

namespace PasswordGenerator.Core.Exceptions;

public class InvalidCharactersOptionsSelected : Exception
{
    public InvalidCharactersOptionsSelected(string message) : base(message)
    {
    }
}
