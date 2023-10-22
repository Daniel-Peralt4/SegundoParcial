using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad
{
    [Serializable]
    public class Empleado
    {
        public int ID { get; set; }
        public string Nombre { get; set; }
        public double SalarioBase { get; set;}
        public string Estado { get; set; }

        public Empleado() { }
        public Empleado(int id, string nombre, double salarioBase, string estado)
        {
            ID = id;
            Nombre = nombre;
            SalarioBase = salarioBase;
            Estado = estado;
        }
        public override string ToString()
        {
            return $"{ID};{Nombre};{SalarioBase};{Estado}";
        }
        //public void RegistrarEmpleado(int id, string nombre, double salariobase, string estado)
        //{
        //    Empleado nuevoEmpleado = new Empleado(id, nombre, salariobase, estado);
        //}
    }
}
