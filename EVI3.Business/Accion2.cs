using EVI3.Data;
using EVI3.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EVI3.Business
{
    public class Accion2 : IAccionesBase
    {
        public void Ejecutar(EntidadBase entidad)
        {
            entidad.Nombre = "Ropero";
            Console.WriteLine("Ejecutando Accion 2: " + entidad.Nombre);
        }
    }
}
