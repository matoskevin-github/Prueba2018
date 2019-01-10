using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppPOOHerencia.Clases
{
    public class Docente :Persona
    {
        public string Contrato { get; set; }
        public int MateriasDictadas { get; set; }
    }
}

