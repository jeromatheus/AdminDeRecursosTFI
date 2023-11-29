using Datos;
using Dominio.Entidades;
using Microsoft.EntityFrameworkCore;
using Negocio.Contratos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio.Servicios
{
    public class GestionarProyectoService : IGestionarProyectoService
    {
        private DatosContexto _contexto = new DatosContexto();

        public List<Empleado> ObtenerEmpleadosDisponibles()
        {
            var empleados = _contexto.Empleados
                .Include(e => e.Area)
                .Include(e => e.Puesto)
                .Include(e => e.Sueldo)
                .Where(e => e.Puesto.Descripcion != "Administrativo")
                .ToList();
            var empleadosAsignados = _contexto.Equipos
                .Include(eq => eq.Empleados)
                .ThenInclude(e => e.Puesto)
                .Include(eq => eq.Empleados)
                .ThenInclude(e => e.Area)
                .SelectMany(eq => eq.Empleados)
                .ToList();

            return empleados.Except(empleadosAsignados).ToList();
        }

        public Proyecto ObtenerProyectoActual(int empleadoId)
        {
            return _contexto.Proyectos
                .Include(x => x.Cliente)
                .Include(t => t.Tareas)
                .Include(p => p.Equipo)
                .ThenInclude(eq => eq.Empleados)
                .ThenInclude(e => e.Puesto)
                .FirstOrDefault(p => p.Equipo.Empleados
                .Any(e => e.Legajo == empleadoId
                && e.LiderDeProyecto));
        }
    }
}
