using Entidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class Response
    {
        public bool Error { get; set; }
        public string Message { get; set; }
        public Cliente Cliente { get; set; }
        public List<Cliente> Clientes { get; set; }
        public Habitacion Habitacion { get; set; }
        public List<Habitacion> Habitaciones { get; set; }
        public Factura Factura { get; set; }
       
        public List<Factura> Facturas { get; set; }
   
        public Reserva Reserva { get; set; }
        public List<Reserva> Reservas { get; set; }

        public Response(Cliente cliente)
        {
            Cliente = cliente;
            Error = false;
        }
        public Response(List<Cliente> clientes)
        {
            Clientes = clientes;
            Error = false;
        }
        public Response(List<Habitacion> habitaciones)
        {
            Habitaciones = habitaciones;
            Error = false;
        }
        public Response(Habitacion habitacion)
        {
            Habitacion = habitacion;
            Error = false;

        }

        public Response(Factura facturas)
        {
            Factura = facturas;
            Error = false;
        }

        public Response(List<Factura> factura)
        {
            Facturas = factura;
            Error = false;
        }



        //public Responce(List<Vehiculo> vehiculos)
        //{
        //    Vehiculos = vehiculos;
        //    Error = false;
        //}
        public Response(string mensaje)
        {
            Error = true;
            Message = mensaje;
        }

        public Response()
        {
        }

        public Response(Reserva reserva)
        {
            Reserva = reserva;
            Error = false;
        }
        public Response(List<Reserva> reservas)
        {
            Reservas = reservas;
            Error = false;
        }

    }
}
