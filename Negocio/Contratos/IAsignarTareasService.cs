using Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio.Contratos
{
    public interface IAsignarTareasService
    {
        void AgregarTarea(int empleadoLegajo, Tarea tarea, int empleadoId);
        void EliminarTarea(int tareaIDSeleccionada);
        List<Empleado>? ObtenerEmpleadosDisponibles(int equipoId);
        public Proyecto? ObtenerProyectoActual(int legajo);
    }
}
