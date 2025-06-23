using TrabajoPracticoPOO.Entidades;

namespace TrabajoPracticoPOO.Utilidades
{
    public static class UtilidadesPersonal
    {

        public static decimal CalcularPromedioPagos(List<Cliente> clientes)
        {
            if (clientes == null || clientes.Count == 0) return 0;
            return clientes.Average(c => c.costoMembresia);
        }

        public static List<Cliente> EncontrarClientesMayorAntiguedad(List<Cliente> clientes)
        {
            if (clientes == null || clientes.Count == 0) return new List<Cliente>();
            var fechaMinima = clientes.Min(c => c.fechaAlta);
            return clientes.Where(c => c.fechaAlta == fechaMinima).ToList();
        }

        public static List<(string Tipo, int Cantidad)> ContarClientesPorTipo(List<Cliente> clientes)
        {
            var resultado = new List<(string, int)>();

            if (clientes == null || clientes.Count == 0)
                return resultado;

            var grupos = clientes.GroupBy(c => c.GetType().Name);
            foreach (var grupo in grupos)
            {
                resultado.Add((grupo.Key, grupo.Count()));
            }

            return resultado;
        }
    }
}
