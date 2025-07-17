using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabajoPracticoPOO.Servicios.DTO
{
    public class ValidationResultDto
    {
        public bool EsValido { get; set; }
        public List<string> Errores { get; set; } = new List<string>();

    }
}
