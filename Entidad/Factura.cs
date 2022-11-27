using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad
{
    public class Factura : Habitacion
    {
    
        public string codigofactura { get; set; }
        public DateTime fechaingreso { get; set; }
        public DateTime fechasalida { get; set; }
        public Habitacion habitacion { get; set; }
        public Cliente cliente { get; set; }
        public string tipohab { get; set; }
        

        public Factura()
        {
        }

    

    

        public Factura(string codigofactura,Habitacion habitacion, DateTime fechaingreso, DateTime fechasalida, Cliente cliente, string tipohab, double precio)
        {
            this.codigofactura = codigofactura;
            this.habitacion = habitacion;
            this.fechaingreso = fechaingreso;
            this.fechasalida = fechasalida;
            this.cliente = cliente;
            this.tipohab = tipohab;
            this.precio = precio;
        }


        public override string ToString()
        {
            return codigofactura.ToString() + ";" + habitacion.IdHabitacion.ToString() +";"+  fechaingreso.ToString()
                + ";" + fechasalida.ToString() + ";" + cliente.IDCliente.ToString() + ";" +
                 tipohab.ToString() + ";" + precio.ToString();
        }

    }
}
