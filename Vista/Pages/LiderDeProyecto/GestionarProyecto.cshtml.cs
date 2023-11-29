using Dominio.Entidades;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Negocio.Contratos;
using Vista.Pages.Login;

namespace Vista.Pages.LiderDeProyecto
{
    public class GestionarProyectoModel : PageModel
    {
        private IGestionarProyectoService _servicio;
        public Proyecto Proyecto { get; set; }  
        public List<Empleado> EmpleadosDisponibles { get; set; }  
        public int LegajoSeleccionado { get; set; }  



        public GestionarProyectoModel(IGestionarProyectoService servicio)
        {
            _servicio = servicio;
        }

        public void OnGet()
        {
            Proyecto = _servicio.ObtenerProyectoActual(IniciarSesionModel.EmpleadoId);
            if (Proyecto != null)
                EmpleadosDisponibles = _servicio.ObtenerEmpleadosDisponibles();
        }
    }
}
