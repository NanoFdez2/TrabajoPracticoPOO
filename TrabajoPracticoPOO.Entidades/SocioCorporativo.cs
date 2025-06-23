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
            cantidadDias = 6;
            costoMembresia = 35000 + 20000;
            servicio = Servicio.GimnasioTrainerSpa;
        }
        public override decimal CalcularGastoMensual()
        {
            return costoMembresia;
        }
    }
}
