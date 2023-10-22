using Entidad;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class RepositorioEmpleado
    {
        string FileName = "Empleados.txt";
        public string GuardarEmpleado(Empleado empleado)
        {
            var escritor = new StreamWriter(FileName, true);
            escritor.WriteLine(empleado.ToString());
            escritor.Close();
            return "El archivo se guardó correctamente";
        }
        public List<Empleado> ConsultarEmpleados()
        {
            var listaEmpleados = new List<Empleado>();
            var lector = new StreamReader(FileName);
            while (!lector.EndOfStream)
            {
                listaEmpleados.Add(Mapeo(lector.ReadLine()));
            }
            lector.Close();
            return listaEmpleados;
        }
        private Empleado Mapeo(string linea)
        {
            var empleado = new Empleado();
            empleado.ID = int.Parse(linea.Split(';')[0]);
            empleado.Nombre = linea.Split(';')[1];
            empleado.SalarioBase = double.Parse(linea.Split(';')[2]);
            empleado.Estado = linea.Split(';')[3];
            return empleado;
        }
    }
}
