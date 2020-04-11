using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1_RodriguezLeandro
{
    public class Persona
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int DNI { get; set; }
        public char Sexo { get; set; }
        public DateTime FechaNac { get; set; }
        public Contacto Contacto { get; set; }
        public Direccion Direccion { get; set; }
    }
}
