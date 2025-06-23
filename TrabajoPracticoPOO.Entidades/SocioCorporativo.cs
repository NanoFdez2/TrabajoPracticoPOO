using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabajoPracticoPOO.Entidades
{
    public class SocioCorporativo : Cliente
    {
        public SocioCorporativo()
        {
            
        }
        public SocioCorporativo(string nombre, string dni, DateTime fechaAlta, Localidad localidad, Servicio serv)
        : base(nombre, dni, fechaAlta, localidad, serv)
        {
            costoMembresia = 35000 + 20000; // Spa incluido
            cantidadDias = 6; // 6 veces por semana
            servicio = Servicio.GimnasioTrainerSpa; // Siempre incluye spa
        }

        public override decimal CalcularGastoMensual()
        {
            return costoMembresia;
        }
    }
}
