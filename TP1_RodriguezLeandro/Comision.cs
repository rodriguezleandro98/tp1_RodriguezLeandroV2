using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1_RodriguezLeandro
{
    public class Comision : Materias
    {
        public int IDComision { get; set; }
        public DateTime Horario { get; set; }
        public Aula Aula { get; set; }
        public Docente Docentes { get; set; }
        public Ayudante Ayudantes { get; set; }
        public Alumno Alumnos { get; set; }
        public Parcial Parciales { get; set; }
        public char Turno { get; set; }

    }
}
