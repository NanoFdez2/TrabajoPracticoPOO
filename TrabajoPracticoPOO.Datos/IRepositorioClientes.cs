using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrabajoPracticoPOO.Entidades;

namespace TrabajoPracticoPOO.Datos
{
    public interface IRepositorioClientes
    {
        
        public void AgregarCliente(Cliente cliente);
        public List<Cliente> BuscarPorNombre(string nombre);
        public List<Cliente> ListarPersonal();
        public List<Cliente> ListarPorAntiguedad(int añosMin);
        public List<Cliente> OrdenarPorPago();
        public List<Cliente> BuscarPorTipo(Type tipo);
        public List<Cliente> ListarTodos();
        public bool EliminarCliente(string dni);
        bool Existe(string dni);
    }
}
