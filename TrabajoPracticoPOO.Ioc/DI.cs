using Microsoft.Extensions.DependencyInjection;

namespace TrabajoPracticoPOO.Ioc
{
    public static class DI
    {
        public static IServiceProvider Configurar()
        {
            var servicios = new ServiceCollection();

            servicios.AddScoped<IrepositorioClientes, RepositorioClientesLinq>();
            servicios.AddScoped<IservicioClientes, ServicioClientes>();

            return servicios.BuildServiceProvider();
        }
    }
}
