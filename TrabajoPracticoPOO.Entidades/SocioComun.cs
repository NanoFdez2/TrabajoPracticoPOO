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
            
        }
        public SocioComun(string nombre, string dni, DateTime fechaAlta, Localidad localidad, Servicio serv)
        : base(nombre, dni, fechaAlta, localidad, serv)
        {
            costoMembresia = 35000;
            cantidadDias = 3;
            servicio = Servicio.Gimnasio;
        }
        public override decimal CalcularGastoMensual()
        {
            return costoMembresia;
        }
    }
}
