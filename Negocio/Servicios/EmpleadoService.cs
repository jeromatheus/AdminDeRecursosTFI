using Datos;
using Negocio.Contratos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio.Servicios
{
    public class EmpleadoService : IEmpleadoService
    {
        private DatosContexto _contexto = new DatosContexto();

        public void EliminarEmpleado(int legajo)
        {
            var empleado = _contexto.Empleados.FirstOrDefault(emp => emp.Legajo.Equals(legajo));
            if (empleado != null)
            {
                _contexto.Empleados.Remove(empleado);
                _contexto.SaveChanges();
            }
        }
    }
}
