using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1_RodriguezLeandro
{
    public class Facultad
    {
        public int ID { get; set; }
        public string NombreFacultad { get; set; }
        public Direccion Direccion { get; set; }
        public int Telefono { get; set; }
        public Carrera Carreras { get; set; }

    }
}
