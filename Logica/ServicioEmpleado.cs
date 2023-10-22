using Datos;
using Entidad;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class ServicioEmpleado
    {
        RepositorioEmpleado repositorioempleado = null;
        public List<Empleado> listaEmpleados = null;

        public ServicioEmpleado()
        {
            repositorioempleado = new RepositorioEmpleado();
            listaEmpleados = repositorioempleado.ConsultarEmpleados();
        }
        public string GuardarEmpleado(Empleado empleado)
        {
            if (empleado == null)
            {
                return "ERROR... No se puede Agregar Empleados Nulos o sin Informacion";
            }
            var msg = repositorioempleado.GuardarEmpleado(empleado);
            listaEmpleados = repositorioempleado.ConsultarEmpleados();
            return msg;
        }
        public List<Empleado> ConsultarEmpleados()
        {
            return listaEmpleados;
        }
        public List<Empleado> ConsultarConFiltro(string filtro)
        {
            if (filtro == " ")
            {
                return listaEmpleados;
            }
            var listaFiltrada = new List<Empleado>();
            foreach (var item in listaEmpleados)
            {
                if (item.Nombre.Contains(filtro) || item.Estado.Contains(filtro))
                {
                    listaFiltrada.Add(item);
                }
            }
            return listaFiltrada;
        }
    }
}
