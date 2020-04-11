using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1_RodriguezLeandro
{
    public class Carrera : Facultad
    {
        public int IDCarrera { get; set; }
        public string NombreCarrera { get; set; }
        public Plan Plan { get; set; }

    }
}
