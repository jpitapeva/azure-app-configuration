using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System;
using System.Net;

namespace AppConfigurations.WebApi.Controllers
{
    /// <summary>
    /// controller
    /// </summary>
    [ApiController]
    [Route("v1/[controller]")]
    public class AppConfigurationsController : ControllerBase
    {
        private static readonly Guid ValorReferencia = Guid.NewGuid();

        [HttpGet]
        [ProducesResponseType((int)HttpStatusCode.OK)]
        public object ExemploAppConfigurationsController([FromServices] IConfiguration configuration)
        {
            return new
            {
                data = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss"),
                ValorReferencia,
                ValorTesteConfig = configuration["config"] //"config" é o nome da chave configurada dentro do portal da azure do recurso Azure Configurations. 
            };
        }
    }
}
