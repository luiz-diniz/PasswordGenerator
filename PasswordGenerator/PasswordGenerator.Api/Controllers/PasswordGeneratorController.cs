using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PasswordGenerator.Core.Interfaces;
using PasswordGenerator.Models;
using System;
using System.Net;

namespace PasswordGenerator.Api.Controllers
{
    [ApiController]
    [Route("api/passwords")]
    public class PasswordGeneratorController : ControllerBase
    {
        private IPasswordGenerator _passwordGenerator;
        private ILogger<PasswordGeneratorController> _logger;

        public PasswordGeneratorController(IPasswordGenerator passwordGeneratorManager, ILogger<PasswordGeneratorController> logger)
        {
            _passwordGenerator = passwordGeneratorManager;
            _logger = logger;
        }

        [HttpGet]
        public IActionResult Generate([FromQuery] PasswordOptions passwordOptions)
        {
            try
            {
                var result = _passwordGenerator.GeneratePasswords(passwordOptions);

                return Ok(result);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, ex.Message);
                return StatusCode((int)HttpStatusCode.InternalServerError, "Error while generating passwords.");
            }
        }
    }
}