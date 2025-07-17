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
            costoMembresia = 35000 + 20000;
            cantidadDias = 6;
            servicio = Servicio.GimnasioTrainerSpa;
        }
        public override string MostrarDatos()
        {
            return base.MostrarDatos()+
                $", Costo Membresía: {costoMembresia:C}, Cantidad de Días: {cantidadDias}, Servicio: {servicio}, Tipo: Socio Corporativo";
        }
        public override decimal CalcularGastoMensual()
        {
            return costoMembresia;
        }
    }
}
