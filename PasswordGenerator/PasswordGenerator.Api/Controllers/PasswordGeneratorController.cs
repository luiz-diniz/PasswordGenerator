using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PasswordGenerator.Core.Interfaces;
using PasswordGenerator.Models;
using System;

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
                _logger.LogInformation($"Request coming from - IP: {Request.HttpContext.Connection.RemoteIpAddress}");

                var result = _passwordGenerator.GeneratePasswords(passwordOptions);

                return Ok(result);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }
    }
}