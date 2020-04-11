using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1_RodriguezLeandro
{
    public class Plan : Carrera
    {
        public int IDPlan { get; set; }
        public Materias Materias{ get; set; }
        public int Duracion { get; set; }

    }
}
