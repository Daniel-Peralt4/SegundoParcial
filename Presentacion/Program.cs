using Entidad;
using Logica;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentacion
{
    internal class Program
    {
        static List<Empleado> empleados = new List<Empleado>();
        static ServicioEmpleado servicioempleado = new ServicioEmpleado();
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("********** MENU PRINCIPAL **********");
                Console.WriteLine("1. GESTION DE EMPLEADOS");
                Console.WriteLine("2. GESTION DE LIQUIDACIONES ");
                Console.WriteLine("3. SALIR");
                Console.Write("Selecciona una opción: ");

                string opcion = Console.ReadLine();
            }
    }
}
