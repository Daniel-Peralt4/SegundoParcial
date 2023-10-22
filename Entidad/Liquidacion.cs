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
        public double TotalSalario { get; set; }
        public double TotalSalud { get; set; }
        public double TotalPension { get; set; }
        public double TotalAuxilioTransporte { get; set; }
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
        public static DetalleLiquidacion CalcularDetalle(Empleado empleado, double salarioMinimo)
        {
            var detalle = new DetalleLiquidacion();

            detalle.Salario = empleado.SalarioBase;

            // Calculo de salud (4%)
            detalle.Salud = detalle.Salario * 0.04;

            // Calculo de pension (4%)
            detalle.Pension = detalle.Salario * 0.04;

            // Validar auxilio de transporte
            if (empleado.SalarioBase <= salarioMinimo * 2)
            {
                detalle.AuxilioTransporte = 106.454;
            }

            // Calcular total devengado
            detalle.Devengado = detalle.Salario - detalle.Salud - detalle.Pension + detalle.AuxilioTransporte;

            return detalle;
        }
    }
}
