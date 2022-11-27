﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad
{
    public class Reserva 
    {
        public string codreserva { get; set; }
        public string idcliente { get; set; }
        public string Nom { get; set; }
        public string codhabitacion { get; set; }
        public string tipohabitacion { get; set; }
        public double precio { get; set; }
        public Reserva()
        {
        }

        public Reserva(string codreserva, string idcliente, string nom, string codhabitacion, string tipohabitacion, double precio)
        {
            this.codreserva = codreserva;
            this.idcliente = idcliente;
            Nom = nom;
            this.codhabitacion = codhabitacion;
            this.tipohabitacion = tipohabitacion;
            this.precio = precio;
        }
    }
}
