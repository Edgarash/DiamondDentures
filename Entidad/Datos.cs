using System;

namespace Entidad
{
    public abstract class Datos
    {
        protected string ObtenerFecha(DateTime Fecha)
        {
            return Fecha.Year + "-" + Fecha.Month + "-" + Fecha.Day;
        }
    }
}
