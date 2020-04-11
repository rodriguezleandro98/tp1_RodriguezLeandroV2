using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1_RodriguezLeandro
{
    public class Alumno : Persona
    {
        public int Legajo { get; set; }
        public Inscripccion Inscripccion { get; set; }
        public Acceso Acceso { get; set; }
        public Materias Materia { get; set; }

    }
}
