using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1_RodriguezLeandro
{
    public class Materias : Plan 
    {
        public int IDMateria { get; set; }
        public string NombreMateria { get; set; }
        public Comision Comisiones { get; set; }
        public Final Finales { get; set; }

    }
}
