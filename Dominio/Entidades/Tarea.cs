using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Entidades
{
    public class Tarea
    {
        public int TareaId { get; set; }
        public string? Descripcion { get; set; }
        public int TiempoDedicacionEstimado { get; set; }
        public int TiempoDedicacionReal { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFin { get; set; }
    }
}
