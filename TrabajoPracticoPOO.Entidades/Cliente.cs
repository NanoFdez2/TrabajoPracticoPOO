using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace TrabajoPracticoPOO.Entidades
{
    public abstract class Cliente : IValidatableObject
    {


        public string nombre { get; set; }
        public string DNI { get; set; }
        public DateTime fechaAlta { get; set; }
        public decimal costoMembresia { get; set; }
        public int antiguedad { get; set; }
        public int cantidadDias { get; set; }
        public Localidad localidad { get; set; }
        public Servicio servicio { get; set; }

        public virtual decimal CalcularGastoMensual()
        {
            return costoMembresia;
        }

        protected Cliente()
        {

        }

        public Cliente(string Nombre, string dni, DateTime FechaAlta, Localidad ciudad, Servicio serv, decimal CostoMembresia, int CantidadDias)
        {
            nombre = Nombre;
            DNI = dni;
            fechaAlta = FechaAlta;
            localidad = ciudad;
            servicio = serv;
            cantidadDias = CantidadDias;
            costoMembresia = 35000m;
        }

        public virtual string MostrarDatos()
        {
            return $"Nombre: {nombre}, DNI: {DNI}, Fecha de Alta: {fechaAlta.ToShortDateString()}, Localidad: {localidad}";
        }
        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            if (string.IsNullOrWhiteSpace(nombre))
                yield return new ValidationResult("El nombre no puede ser nulo ni vacio!!!");

            if (!Regex.IsMatch(DNI ?? "", @"^\d{8}$")) 
            yield return new ValidationResult("El DNI debe ser de 8 digitos!");

            if (fechaAlta > DateTime.Now)
                yield return new ValidationResult("La fecha de alta no puede ser mayor a la fecha actual");

        }
    }
}
