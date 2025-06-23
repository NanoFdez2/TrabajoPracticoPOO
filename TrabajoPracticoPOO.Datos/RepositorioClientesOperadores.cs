using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrabajoPracticoPOO.Entidades;

namespace TrabajoPracticoPOO.Datos
{
    public class RepositorioClientesOperadores
    {
        private List<Cliente> clientes = new List<Cliente>();

        public static RepositorioClientesOperadores operator +(RepositorioClientesOperadores repo, Cliente cliente)
        {
            if (!(repo == cliente))
            {
                repo.clientes.Add(cliente);
                Console.WriteLine("Se ha agregado el cliente!!!");
            }
            else
            {
                Console.WriteLine("El cliente ya existe, el DNI ya está en la base!!!.");
            }

            return repo;
        }

        public static RepositorioClientesOperadores operator -(RepositorioClientesOperadores repo, Cliente cliente)
        {
            var existente = repo.clientes.FirstOrDefault(c => c.DNI == cliente.DNI);
            if (existente != null)
            {
                repo.clientes.Remove(existente);
                Console.WriteLine("El cliente eliminado.");
            }
            else
            {
                Console.WriteLine("No se encontró un cliente con ese DNI!!!");
            }

            return repo;
        }

        public static bool operator ==(RepositorioClientesOperadores repo, Cliente cliente)
        {
            return repo.clientes.Any(c => c.DNI == cliente.DNI);
        }

        public static bool operator !=(RepositorioClientesOperadores repo, Cliente cliente)
        {
            return !(repo == cliente);
        }
        public Cliente this[int index]
        {
            get
            {
                if (index >= 0 && index < clientes.Count)
                {
                    return clientes[index];
                }
                throw new IndexOutOfRangeException(nameof(index));
            }
        }

        public void MostrarTodo()
        {
            if (clientes.Count == 0)
            {
                Console.WriteLine("No hay clientes en la lista aún.");
                return;
            }

            foreach (var cliente in clientes)
            {
                Console.WriteLine($"Nombre: {cliente.nombre}, DNI: {cliente.DNI}, TipoCliente: {cliente.GetType().Name}, Servicio: {cliente.servicio}, Pago: ${cliente.CalcularGastoMensual()}");
            }
        }

        public Cliente BuscarPorDNI(string dni)
        {
            return clientes.FirstOrDefault(c => c.DNI == dni);
        }
        public int Cantidad => clientes.Count;

        public List<Cliente> ObtenerTodos() => new List<Cliente>(clientes);
    }


}
