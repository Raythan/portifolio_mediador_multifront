using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace portifolio_mediador_multifront.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ConfiguracaoController : ControllerBase
    {
        [HttpGet]
        public int Get()
        {
            return 1;
        }
    }
}
