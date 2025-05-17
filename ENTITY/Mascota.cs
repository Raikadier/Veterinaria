using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTITY
{
    public class Mascota: NamedEntity
    {
        public int Edad { get; set; }
        public Especie Especie { get; set; }
        public Raza Raza { get; set; }

        public override string ToString()
        {
            return $"{Id};{Nombre};{Edad};{Especie.Id};{Raza.Id}";
        }
    }
}
