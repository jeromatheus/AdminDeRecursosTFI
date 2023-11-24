using Datos;
using Dominio.Entidades;
using Negocio.Contratos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class ProyectoService: IProyectoService
{
    private DatosContexto _contexto = new DatosContexto();
    public  void AgregarEquipo(int legajo , Equipo equipo)
    {
       var empleado = _contexto.Empleados.FirstOrDefault(emp => emp.Legajo.Equals(legajo));
       var equipoExistente = _contexto.Proyectos.FirstOrDefault(proyecto => proyecto.Equipo.EquipoId.Equals(equipo.EquipoId));
        if (empleado != null)
        {
            if (equipoExistente == null)
            {
                // El equipo no existe, así que creamos uno nuevo
                equipoExistente = new Proyecto { Equipo = equipo };
                _contexto.Proyectos.Add(equipoExistente);
            }

            // Verificar si el empleado ya está en el equipo para evitar duplicados
            if (!equipoExistente.Equipo.Empleados.Contains(empleado))
            {
                // Agregar el empleado al equipo
                equipoExistente.Equipo.Empleados.Add(empleado);
                _contexto.SaveChanges();

            }
        }
    }
}