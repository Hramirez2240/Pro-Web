using GestionDeVehiculos.Controllers;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace GestionDeVehiculos.Infrastructure
{
    [Route("[controller]/[action]", Name = "[controller]_[action]")]
    public abstract class BaseController : Controller
    {
        private ILogger<HomeController> logger;

        protected BaseController(ILogger<HomeController> logger)
        {
            this.logger = logger;
        }
    }
}
