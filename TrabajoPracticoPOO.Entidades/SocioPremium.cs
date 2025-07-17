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
            costoMembresia = 35000;
            servicio = Servicio.GimnasioTrainer;
        }

        public override string MostrarDatos()
        {
            return base.MostrarDatos()+ $", Costo Membresía: {CalcularGastoMensual()}, Cantidad de Días: {cantidadDias}, Servicio: {servicio}, Tipo: Socio Premium";
        }
        public override decimal CalcularGastoMensual()
        {
            return costoMembresia + 10000;
        }
    }
}
