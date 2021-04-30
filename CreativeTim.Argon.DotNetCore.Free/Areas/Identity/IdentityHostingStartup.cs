using Microsoft.AspNetCore.Hosting;

[assembly: HostingStartup(typeof(GestionDeVehiculos.Areas.Identity.IdentityHostingStartup))]
namespace GestionDeVehiculos.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
            });
        }
    }
}