using System;
using System.ComponentModel.DataAnnotations;

namespace PasswordGenerator.Models
{
    public class PasswordOptions
    {
        [Required]
        [Range(1, 100)]
        public int Size { get; set; }

        [Required]
        public bool Numbers { get; set; }

        [Required]
        public bool SpecialCharacters { get; set; }

        [Required]
        public bool UpperCaseCharacters { get; set; }

        [Required]
        public bool LowerCaseCharacters { get; set; }

        [Required]
        [Range(1, 100)]
        public int Quantity { get; set; }
    }
}