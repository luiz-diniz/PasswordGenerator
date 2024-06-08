using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PasswordGenerator.Core;
using PasswordGenerator.Models;
using System;

namespace PasswordGenerator.Api.Controllers
{
    [ApiController]
    [Route("api/passwords")]
    public class PasswordGeneratorController : ControllerBase
    {
        private IPasswordGeneratorManager _passwordGenerator;
        private ILogger<PasswordGeneratorController> _logger;

        public PasswordGeneratorController(IPasswordGeneratorManager passwordGeneratorManager, ILogger<PasswordGeneratorController> logger)
        {
            _passwordGenerator = passwordGeneratorManager;
            _logger = logger;
        }

        [HttpGet]
        public IActionResult Generate([FromQuery] PasswordOptions passwordOptions)
        {
            try
            {
                _logger.LogInformation("Request coming from - " +
                                       $"IP: {Request.HttpContext.Connection.RemoteIpAddress}");

                var result = _passwordGenerator.GeneratePassword(passwordOptions);

                return Ok(result);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }
    }
}