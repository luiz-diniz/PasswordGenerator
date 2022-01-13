using Microsoft.AspNetCore.Mvc;
using PasswordGenerator.Core;
using PasswordGenerator.Models;
using System;

namespace PasswordGenerator.Api.Controllers
{
    [ApiController]
    [Route("api/passwordgenerator")]
    public class PasswordGeneratorController : ControllerBase
    {
        private IPasswordGeneratorManager _passwordGenerator;

        public PasswordGeneratorController(IPasswordGeneratorManager passwordGeneratorManager)
        {
            _passwordGenerator = passwordGeneratorManager;
        }

        [HttpPost]
        [Route("generate")]
        public IActionResult Generate(PasswordOptions passwordOptions)
        {
            try
            {
                return Ok(_passwordGenerator.GeneratePassword(passwordOptions));
            }
            catch (Exception ex)
            {
                if (ex is ArgumentNullException || ex is ArgumentOutOfRangeException)
                    return BadRequest(ex.Message);

                return StatusCode(500, ex.Message);
            }
        }
    }
}