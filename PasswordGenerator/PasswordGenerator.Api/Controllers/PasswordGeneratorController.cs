using Microsoft.AspNetCore.Mvc;
using PasswordGenerator.Core;
using PasswordGenerator.Models;
using System;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Cors;

namespace PasswordGenerator.Api.Controllers
{
    [ApiController]
    [Route("api/passwordgenerator")]
    public class PasswordGeneratorController : ControllerBase
    {
        private IPasswordGeneratorManager _passwordGenerator;
        private ILogger<PasswordGeneratorController> _logger;

        public PasswordGeneratorController(IPasswordGeneratorManager passwordGeneratorManager, ILogger<PasswordGeneratorController> logger)
        {
            _passwordGenerator = passwordGeneratorManager;
            _logger = logger;
        }

        [HttpPost]
        [Route("generate")]
        public IActionResult Generate(PasswordOptions passwordOptions)
        {
            try
            {
                _logger.LogInformation("Request coming from - " +
                                       $"IP: {Request.HttpContext.Connection.RemoteIpAddress}");

                return Ok(_passwordGenerator.GeneratePassword(passwordOptions));
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }
    }
}