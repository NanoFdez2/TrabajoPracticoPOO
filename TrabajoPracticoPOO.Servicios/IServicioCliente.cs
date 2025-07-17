using TrabajoPracticoPOO.Entidades;
using TrabajoPracticoPOO.Servicios.DTO;

namespace TrabajoPracticoPOO.Servicios
{
    public interface IServicioCliente
    {
        ValidationResultDto Agregar(Cliente cliente);
        ValidationResultDto Editar(Cliente cliente);
        ValidationResultDto Eliminar(string dni);
        Cliente? ObtenerClientePorDni(string dni);
        List<Cliente> ObtenerTodos();
    }
}
