using TrabajoPracticoPOO.Entidades;
using TrabajoPracticoPOO.Servicios.dto;

namespace TrabajoPracticoPOO.Servicios
{
    public interface IServiceCliente
    {
        ValidationResultDto Agregar(Cliente cliente);
        ValidationResultDto BuscarPorNombre(string nombre);
        List<Cliente> ListarPersonal();
        List<Cliente> ListarPorAntiguedad(int añosMin);
        List<Cliente> OrdenarPorPago();
        List<Cliente> BuscarPorTipo(Type tipo);
        List<Cliente> ListarTodos();
        ValidationResultDto EliminarCliente(string dni);
    }
}
