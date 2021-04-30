using Microsoft.AspNetCore.Mvc;

namespace GestionDeVehiculos.Infrastructure
{
    [Route("[controller]/[action]", Name = "[controller]_[action]")]
    public abstract class BaseController : Controller
    {
    }
}
