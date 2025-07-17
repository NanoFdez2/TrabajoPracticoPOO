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
            costoMembresia = 35000;
            servicio = Servicio.GimnasioTrainerSpa;
        }

        public override string MostrarDatos()
        {
            return base.MostrarDatos()+
                $", Costo Membresía: {CalcularGastoMensual()}, Cantidad de Días: {cantidadDias}, Servicio: {servicio}, Tipo: Socio Corporativo";
        }
        public override decimal CalcularGastoMensual()
        {
            return costoMembresia + 20000; 
        }
    }
}
