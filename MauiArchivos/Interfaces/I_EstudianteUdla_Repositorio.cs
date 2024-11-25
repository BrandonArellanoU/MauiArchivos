using MauiArchivos.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiArchivos.Interfaces
{
    internal interface I_EstudianteUdla_Repositorio
    {
        IEnumerable<EstudianteUdla> DevuelveListadoEstudiantes();

        EstudianteUdla DevuelveEstudianteUdla(); 
        bool CrearEstudianteUdla(EstudianteUdla estudiante);

        bool ActualizarEstudianteUdla(EstudianteUdla estudiante);

        bool EliminarEstudianteUdla(int id);
    }
}
