using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IBIL;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace WebApi31Test.Controllers
{
    [Route("api/test")]
    [ApiController]
    public class ApiTestController : ControllerBase
    {
        public IApiTestBIL _apiTestBIL;
        public ILogger<ApiTestController> _logger;

        public ApiTestController()
        {

        }

        public ApiTestController(IApiTestBIL apiTestBIL, ILogger<ApiTestController> logger) //
        {
            _apiTestBIL = apiTestBIL;
            _logger = logger;
        }

        [HttpGet("info")]
        public string Info()
        {
            _apiTestBIL.Show();
            _logger.LogWarning("123");
            return "123";
        }
    }
}