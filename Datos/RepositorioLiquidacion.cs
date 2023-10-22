using Entidad;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class RepositorioLiquidacion
    {
        string FileName = "Liquidacion.txt";
        public string GuardarLiquidacion(Liquidacion liquidacion)
        {
            var escritor = new StreamWriter(FileName, true);
            escritor.WriteLine(liquidacion.ToString());
            escritor.Close();
            return "El archivo se guardó correctamente";
        }
        public List<Liquidacion> ConsultarLiquidaciones()
        {
            var listaLiquidaciones = new List<Liquidacion>();
            var lector = new StreamReader(FileName);
            while (!lector.EndOfStream)
            {
                listaLiquidaciones.Add(Mapeo(lector.ReadLine()));
            }
            lector.Close();
            return listaLiquidaciones;
        }
        private Liquidacion Mapeo(string linea)
        {
            var liquidacion = new Liquidacion();
            liquidacion.Id = int.Parse(linea.Split(';')[0]);
            liquidacion.Año = int.Parse(linea.Split(';')[1]);
            liquidacion.Mes = int.Parse(linea.Split(';')[2]);
            //liquidacion.TotalSalario = double.Parse(linea.Split(';')[3]);
            //liquidacion.TotalSalud = double.Parse(linea.Split(';')[4]);
            //liquidacion.TotalPension = double.Parse(linea.Split(';')[5]);
            //liquidacion.TotalAuxilioTransporte = double.Parse(linea.Split(';')[6]);
            return liquidacion;
        }
    }
}
