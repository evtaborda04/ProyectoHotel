using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad
{
    public class Factura
    {
        #region
        public int codigofactura { get; set; }
        public DateTime fechaingreso { get; set; }
        public DateTime fechasalida { get; set; }
        public string codreserva { get; set; }
        public string cedula { get; set; }
        public string Nombre { get; set; }
        public string habitacion { get; set; }
        public string tipohab { get; set; }
        public double precio { get; set; }
        public int cantidad_dias { get; set; }
        public double Total { get; set; }
        #endregion
        public Factura()
        {
        }

        public Factura(int codigofactura, DateTime fechaingreso, DateTime fechasalida, string codreserva, string cedula, string nombre, string habitacion, string tipohab, double precio, int cantidad_dias, double total)
        {
            this.codigofactura = codigofactura;
            this.fechaingreso = fechaingreso;
            this.fechasalida = fechasalida;
            this.codreserva = codreserva;
            this.cedula = cedula;
            Nombre = nombre;
            this.habitacion = habitacion;
            this.tipohab = tipohab;
            this.precio = precio;
            this.cantidad_dias = cantidad_dias;
            Total = total;
        }
    }
}
