using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabajoPracticoPOO.Entidades
{
    public class SocioComun : Cliente
    {


        public SocioComun()
        {
            cantidadDias = 3;
            costoMembresia = 35000;
            servicio = Servicio.Gimnasio;

        }
        public override decimal CalcularGastoMensual()
        {
            return costoMembresia;
        }
    }
}
