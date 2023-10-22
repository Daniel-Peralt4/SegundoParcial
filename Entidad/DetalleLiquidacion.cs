using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad
{
    public class DetalleLiquidacion
    {
        public int Id { get; set; }
        public int IdLiquidacion { get; set; }
        public int Año { get; set; }
        public int Mes { get; set; }

        public int IdEmpleado { get; set; }
        public string Nombre { get; set; }
        public decimal Salario { get; set; }

        public decimal Salud { get; set; }
        public decimal Pension { get; set; }
        public decimal AuxilioTransporte { get; set; }

        public decimal Devengado { get; set; }

        public DetalleLiquidacion()
        {

        }
        public override string ToString()
        {
            return $"{Id};{IdLiquidacion};{Año};{Mes};" +
                    $"{IdEmpleado};{Nombre};{Salario};" +
                    $"{Salud};{Pension};{AuxilioTransporte}";
        }
    }
}
