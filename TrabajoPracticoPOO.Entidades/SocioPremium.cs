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
            
        }
        public SocioPremium(string nombre, string dni, DateTime fechaAlta, Localidad localidad, Servicio serv)
            : base(nombre, dni, fechaAlta, localidad, serv)
        {
            costoMembresia = 35000 + 10000;
            cantidadDias = 5;
            servicio = Servicio.GimnasioTrainer;
        }
        public override string MostrarDatos()
        {
            return base.MostrarDatos()+ $", Costo Membresía: {costoMembresia}, Cantidad de Días: {cantidadDias}, Servicio: {servicio}, Tipo: Socio Premium";
        }
        public override decimal CalcularGastoMensual()
        {
            return costoMembresia;
        }
    }
}
