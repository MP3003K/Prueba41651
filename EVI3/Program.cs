using EVI3.Business;
using EVI3.Data;
using EVI3.Entities;
EntidadBase entidad = new EntidadBase("Mijail");

var claseAcciones = new ClaseAcciones();
List<IAccionesBase> listAcciones = new List<IAccionesBase>()
{
  new Accion1(),
  new Accion2(),
};
claseAcciones.setAcciones(listAcciones);
claseAcciones.Guardar(entidad);

