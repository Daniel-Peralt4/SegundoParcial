using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace
    [Serializable]

namespace Parcial2.CapaDatos
{
   
    public class DatosEmpleado
    {
        public DatosEmpleado() { }

        public string Identificacion { get; set; }
        public string Nombre { get; set; }
        public decimal SalarioBase { get; set; }
        public string Estado { get; set; }

        public DatosEmpleado(string identificacion, string nombre, decimal salarioBase, string estado)
        {
            Identificacion = identificacion;
            Nombre = nombre;
            SalarioBase = salarioBase;
            Estado = estado;
        }
    }

    public class GestorEmpleados
    {
       
        private static string archivoEmpleados = "empleados.json";

        public static object JsonConvert { get; private set; }

        public static void GuardarEmpleado(DatosEmpleado empleado)
        {
            try
            {
                string datosJson = File.Exists(archivoEmpleados) ? File.ReadAllText(archivoEmpleados) : "[]";
                List<DatosEmpleado> empleados = JsonConvert.DeserializeObject<List<DatosEmpleado>>(datosJson);

                if (empleados.Any(e => e.Identificacion == empleado.Identificacion))
                {
                    MessageBox.Show("Ya existe un empleado con la misma identificación.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                empleados.Add(empleado);

                datosJson = JsonConvert.Serializeobject(empleados);

                File.WriteAllText(archivoEmpleados, datosJson);

                MessageBox.Show("Empleado registrado con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al guardar el empleado: " + ex.Message);
                throw;
            }
        }

    }
}
