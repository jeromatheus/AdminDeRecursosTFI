using Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio.Contratos
{
    public interface IProyectoService
    {
        void AgregarEquipo(int legajo , Equipo equipo);
        
    }
}