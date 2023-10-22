using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad
{
    [Serializable]
    public class Liquidacion
    {
        public int Id { get; set; }
        public int Año { get; set; }
        public int Mes { get; set; }
        public double TotalSalario { get; }
        public double TotalSalud { get; }
        public double TotalPension { get; }
        public double TotalAuxilioTransporte { get; }
        public List<DetalleLiquidacion> Detalles { get; set; }
        public Liquidacion(int id, int año, int mes)
        {
            Id = id;
            Año = año;
            Mes = mes;
        }
        public Liquidacion()
        {
            Detalles = new List<DetalleLiquidacion>();
        }
        public override string ToString()
        {
            return $"{Id};{Año};{Mes};{TotalSalario};{TotalSalud};" +
                $"{TotalPension};{TotalAuxilioTransporte}";
        }
    }
}
