using Microsoft.Extensions.DependencyInjection;
using TrabajoPracticoPOO.Datos;
using TrabajoPracticoPOO.Servicios;

namespace TrabajoPracticoPOO.Ioc
{
    public static class DI
    {
        public static IServiceProvider Configurar()
        {
            var servicios = new ServiceCollection();

            servicios.AddScoped<IRepositorioClientes, RepositorioClientesLinq>();
            servicios.AddScoped<IServiceCliente, ServiceCliente>();

            return servicios.BuildServiceProvider();
        }
    }
}
