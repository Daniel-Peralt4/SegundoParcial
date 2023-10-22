using Datos;
using Entidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    internal class ServicioLiquidacion
    {
        RepositorioLiquidacion repositorioliquidacion = null;
        public List<Liquidacion> listaLiquidaciones = null;
        public ServicioLiquidacion()
        {
            repositorioliquidacion = new RepositorioLiquidacion();
            List<Liquidacion> listaLiquidaciones = new List<Liquidacion>();
        }
        public string GuardarLiquidacion(Liquidacion liquidacion)
        {
            if (liquidacion == null)
            {
                return "ERROR... No se puede Agregar Liquidaciones Nulas o sin Informacion";
            }
            if (liquidacion.Id == 0)
            {
                return $"Debe llenar el campo" + $"{liquidacion.Id};";
            }
            else if(liquidacion.Año == 0)
            {
                return $"Debe llenar el campo" + $"{liquidacion.Año};";
            }
            else if(liquidacion.Mes == 0)
            {
                return $"Debe llenar el campo" + $"{liquidacion.Mes};";
            }

            var msg = repositorioliquidacion.GuardarLiquidacion(liquidacion);
            listaLiquidaciones = repositorioliquidacion.ConsultarLiquidaciones();
            return msg;
        }
        public List<Liquidacion> ConsultarLiquidaciones()
        {
            return listaLiquidaciones;
        }
    }
}
