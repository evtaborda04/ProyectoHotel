using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad
{
    public class Factura: Reserva
    {
        #region
        public int codigofactura { get; set; }
        public DateTime fechaingreso { get; set; }
        public DateTime fechasalida { get; set; }
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
            this.IDCliente = cedula;
            this.Nom = nombre;
            this.codhabitacion = habitacion;
            this.tipohabitacion = tipohab;
            this.precio = precio;
            this.cantidad_dias = cantidad_dias;
            Total = total;
        }
    }
}
