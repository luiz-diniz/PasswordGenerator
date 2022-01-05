using System;

namespace PasswordGenerator.Models
{
    public class Password
    {
        public string PasswordString { get; set; }
        public int MaxSize { get; set; }
        public bool Numbers { get; set; }
        public bool SpecialCharacters { get; set; }
        public bool UpperCaseLetters { get; set; }
        public bool LowerCaseLetters { get; set; }
    }
}