
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dominio.Entidades;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Vista.Pages.LiderDeProyecto
{
    public class GestionarProyectosModel : PageModel
    {
        public int EmpleadoSeleccionado { set; get; }
        public int EquipoSeleccionado { set; get; }
        public List<Empleado>? Empleados { get; set; } = new List<Empleado>();
        public List<Equipo>? Equipos { get; set; } = new List<Equipo>();
        public void OnGet()
        {
            cargarMockupEmpleadoEquipo(); 
        }

        private void cargarMockupEmpleadoEquipo()
        {
            Empleado e1 = new Empleado()
            {
                Nombre = "Juan",
                Apellido = "Perez",
                Legajo = 2000,
                FechaDeNacimiento = System.DateTime.MinValue
            };
            Empleado e2 = new Empleado()
            {
                Nombre = "Maria",
                Apellido = "Gomez",
                Legajo = 2001,
                FechaDeNacimiento = DateTime.Parse("1990-05-15")
            };

            Empleado e3 = new Empleado()
            {
                Nombre = "Carlos",
                Apellido = "Rodriguez",
                Legajo = 2002,
                FechaDeNacimiento = DateTime.Parse("1985-08-20")
            };
            Empleados.Add(e1);
            Empleados.Add(e2);
            Empleados.Add(e3);
        }
    }
}

