using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EVI3.Entities
{
    public class EntidadBase
    {
        public string _nombre="";
        public string Nombre { get { return _nombre; } set { _nombre = value; } }

        public EntidadBase(string nombre)
        {
            _nombre = nombre;
        }
    }
}
