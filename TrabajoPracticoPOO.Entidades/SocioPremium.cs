using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabajoPracticoPOO.Entidades
{
    public class SocioPremium : Cliente
    {

        public SocioPremium()
        {
            cantidadDias = 5;
            costoMembresia = 35000 + 10000;
            servicio = Servicio.GimnasioTrainer;
        }
        public override decimal CalcularGastoMensual()
        {
            return costoMembresia;
        }
    }
}
