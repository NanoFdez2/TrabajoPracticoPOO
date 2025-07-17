using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrabajoPracticoPOO.Datos;
using TrabajoPracticoPOO.Entidades;
using TrabajoPracticoPOO.Servicios.dto;

namespace TrabajoPracticoPOO.Servicios
{
    public class ServiceCliente : IServiceCliente
    {
        private readonly IRepositorioClientes _repositorioClientes;

        public ServiceCliente(IRepositorioClientes repositorioClientes)
        {
            _repositorioClientes = repositorioClientes;
        }
        public ValidationResultDto Agregar(Cliente cliente)
        {
            ValidationContext validationContext = new ValidationContext(cliente);
            List<ValidationResult> errores = new List<ValidationResult>();
            ValidationResultDto resultadoDto = new ValidationResultDto() { EsValido = true };
            if (Validator.TryValidateObject(cliente, validationContext, errores, true))
            {
                if (_repositorioClientes.Existe(cliente.DNI))
                {
                    resultadoDto.Errores.Add("dni existente!!!");
                    resultadoDto.EsValido = false;
                }
                else
                {
                    _repositorioClientes.AgregarCliente(cliente);
                }
            }
            else
            {
                resultadoDto.Errores
                    .AddRange(errores
                    .Select(r => r.ErrorMessage ?? "Error de validación desconocido."));
            }
            return resultadoDto;
        }

        public ValidationResultDto BuscarPorNombre(string nombre)
        {
            var resultadoDto = new ValidationResultDto { EsValido = true };
            var clientes = _repositorioClientes.BuscarPorNombre(nombre);

            if (clientes == null || clientes.Count == 0)
            {
                resultadoDto.EsValido = false;
                resultadoDto.Errores.Add("No se encontraron clientes con ese nombre.");
            }
             return resultadoDto;
        }

        public List<Cliente> BuscarPorTipo(Type tipo)
        {
            return _repositorioClientes.BuscarPorTipo(tipo);
        }


        public List<Cliente> ListarPersonal()
        {
            return _repositorioClientes.ListarPersonal();
        }

        public List<Cliente> ListarPorAntiguedad(int añosMin)
        {
            return _repositorioClientes.ListarPorAntiguedad(añosMin);
        }

        public List<Cliente> ListarTodos()
        {
            return _repositorioClientes.ListarTodos();
        }

        public List<Cliente> OrdenarPorPago()
        {
            return _repositorioClientes.OrdenarPorPago();
        }

        ValidationResultDto IServiceCliente.EliminarCliente(string dni)
        {
            ValidationResultDto resultadoDto = new ValidationResultDto() { EsValido = true };
            if (!_repositorioClientes.Existe(dni))
            {
                resultadoDto.EsValido = false;
                resultadoDto.Errores.Add("dni inexistente!!");
            }
            else
            {
                _repositorioClientes.EliminarCliente(dni);

            }
            return resultadoDto;
        }
    }
}
