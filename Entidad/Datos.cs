using System;

namespace Entidad
{
    public abstract class Datos
    {
        public const int MYSQL_INT = 2147483647;
        public const int SAFE_MYSQL_INT = 2147483600;
        protected string ObtenerFecha(DateTime Fecha)
        {
            return Fecha.Year + "-" + Fecha.Month + "-" + Fecha.Day;
        }
    }
}