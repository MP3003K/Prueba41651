using EVI3.Entities;

namespace EVI3.Data
{
    public class EntidadBaseDao : IAccionesBase
    {
        public void Ejecutar(EntidadBase entidad)
        {
            Guardar(entidad);
        }
        private void Guardar(EntidadBase entidad)
        {
            Console.WriteLine("Ejecutar Guardar: " + entidad.Nombre);
        }
    }
}
