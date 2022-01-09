using System;

namespace PasswordGenerator.Models
{
    public class PasswordOptions
    {
        public int Size { get; set; }
        public bool Numbers { get; set; }
        public bool SpecialCharacters { get; set; }
        public bool UpperCaseLetters { get; set; }
        public bool LowerCaseLetters { get; set; }
    }
}