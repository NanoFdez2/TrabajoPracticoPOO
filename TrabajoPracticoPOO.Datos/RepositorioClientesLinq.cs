﻿using System.Text.RegularExpressions;
using TrabajoPracticoPOO.Entidades;

namespace TrabajoPracticoPOO.Datos
{
    public class RepositorioClientesLinq:IRepositorioClientes
    {
        private List<Cliente> clientes;
        public Cliente? this[string dni]
        {
            get
            {
                return clientes.FirstOrDefault(c => c.DNI == dni);
            }
        }
        public void AgregarCliente(Cliente cliente)
        {

            if (!clientes.Any(c => c.DNI == cliente.DNI))
            {
                clientes.Add(cliente);
            }
            else
            {
                Console.WriteLine("El cliente con el mismo DNI ya existe");

            }


        }
        public List<Cliente> BuscarPorNombre(string nombre)
        {
            return clientes.Where(c => c.nombre.Contains(nombre, StringComparison.OrdinalIgnoreCase)).ToList();
        }

        public List<Cliente> ListarPersonal()
        {
            return clientes.Where(c => c.servicio == Servicio.GimnasioTrainer
            || c.servicio == Servicio.GimnasioTrainerSpa).ToList();
        }

        public List<Cliente> ListarPorAntiguedad(int añosMin)
        {
            return clientes.Where(c => c.antiguedad >= añosMin).ToList();
        }

        public List<Cliente> OrdenarPorPago()
        {
            return clientes.OrderByDescending(c => c.CalcularGastoMensual()).ToList();
        }

        public List<Cliente> BuscarPorTipo(Type tipo)
        {
            return clientes.Where(c => c.GetType() == tipo || c.GetType().IsSubclassOf(tipo)).ToList();

        }
        public List<Cliente> ListarTodos()
        {
            return clientes.ToList();
        }

        public  bool EliminarCliente(string dni)
        {
            var c = clientes.FirstOrDefault(x => x.DNI == dni);
            if (c == null) return false;
            clientes.Remove(c);
            return true;
        }

        public bool Existe(string dni)=>this[dni] != null;


        public RepositorioClientesLinq()
        {
            clientes = new List<Cliente>();
        }    
    }
}

