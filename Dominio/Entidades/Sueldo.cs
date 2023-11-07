using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Entidades
{
    public class Sueldo
    {
        public int SueldoId { get; set; }
        public float Bruto { get; set; }
        public float DescuentoJubilacion { get; set; }
        public float DescuentoObraSocial { get; set; }
    }
}
