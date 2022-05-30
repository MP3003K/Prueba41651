using EVI3.Data;
using EVI3.Entities;

namespace EVI3.Business
{
    public class ClaseAcciones
    {
        List<IAccionesBase> _acciones;
        public void setAcciones(List<IAccionesBase> acciones)
        {
            _acciones = acciones;
        }
        public void Guardar(EntidadBase entidad)
        {
            foreach (IAccionesBase accion in _acciones)
            {
                accion.Ejecutar(entidad);
            }
        }
    }
}
