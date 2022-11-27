using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad
{
    public class Habitacion
    {
        public string IdHabitacion { get; set; }
        public string TipoHabitacion { get; set; }
        public double precio { get; set; }
        public int Nropiso { get; set; }

        private string linea;

        public Habitacion()
        {
        }

        
       
        public Habitacion(string linea)
        {
            if (linea != null)
            {
                Mapear(linea);
            }

        }

        public Habitacion(string idHabitacion, string tipoHabitacion, double precio, int nropiso)
        {
            IdHabitacion = idHabitacion;
            TipoHabitacion = tipoHabitacion;
            this.precio = precio;
            Nropiso = nropiso;
        }

        public string Linea()
        {
            return IdHabitacion + ";" + TipoHabitacion + ";" + precio + ";" + Nropiso;
        }
        private void Mapear(string linea)
        {
            IdHabitacion = linea.Split(';')[0];
            TipoHabitacion = linea.Split(';')[1];
            precio = Convert.ToDouble( linea.Split(';')[2]);
            Nropiso = Convert.ToInt32( linea.Split(';')[3]);
     

        }
        //public override string ToString()
        //{
        //    return IdHabitacion.ToString() + ";" + NumPiso.ToString() + ";" + NumCama.ToString() + ";" +
        //        NumDuchas.ToString() + ";" + NumAir.ToString() + ";" + NumTv.ToString() + ";" + NumCloset.ToString();
        //}
    }
}
