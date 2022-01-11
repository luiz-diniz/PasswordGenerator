using PasswordGenerator.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordGenerator.Core
{
    public interface IPasswordGeneratorManager
    {
        public string Generate(PasswordOptions passwordOptions);
        public bool GenerateMultiple(PasswordOptions passwordOptions);
    }
}
