using Microsoft.AspNetCore.Mvc;
using PasswordGenerator.Core;
using PasswordGenerator.Models;

namespace PasswordGenerator.Api.Controllers
{
    [ApiController]
    [Route("api/passwordgenerator")]
    public class PasswordGeneratorController
    {
        private IPasswordGeneratorManager _passwordGenerator;

        public PasswordGeneratorController(IPasswordGeneratorManager passwordGeneratorManager)
        {
            _passwordGenerator = passwordGeneratorManager;
        }

        [HttpPost]
        [Route("generate")]
        public string Generate(PasswordOptions passwordOptions)
        {
            return _passwordGenerator.Generate(passwordOptions);
        }
    }
}