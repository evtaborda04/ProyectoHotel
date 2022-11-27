using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad
{
    public class Facturacion : Factura
    {
        public string codfactura { get; set; }
        private Cliente clientes;
        private Factura reserva;

        private string codreserva;

        public Facturacion(string codfactura, double total)
        {
            this.codfactura = codfactura;
            total = total;
        }

        public Facturacion()
        {
        }

        public Facturacion(string codfactura)
        {
            this.codfactura = codfactura;
        }

        public Facturacion(string codfactura, Factura reserva, Cliente clientes, string tipohabitacion, double precio, DateTime fechaingreso, DateTime fechasalida) : this(codfactura)
        {
            this.codreserva = codreserva;
            this.clientes = clientes;
            TipoHabitacion = tipohabitacion;
            this.precio = precio;
            this.fechaingreso = fechaingreso;
            this.fechasalida = fechasalida;
        }

        public override string ToString()
        {
            return codfactura.ToString() +";" + reserva.codigofactura.ToString() +";" + cliente.IDCliente.ToString() +";"+ TipoHabitacion.ToString() + ";" + precio.ToString() +";"+  fechaingreso.ToString() +";" + fechasalida.ToString();
   
        }

    }
}
