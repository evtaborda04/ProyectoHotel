using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad
{
    public class Cliente
    {

        public string IDCliente { get; set; }
        public string Nom { get; set; }
        public string apellido { get; set; }
        public string Genero { get; set; }

      
        public Cliente()
        {

        }



        public Cliente(string linea)
        {
            if (linea != null)
            {
                Mapear(linea);
            }

        }

        public Cliente(string iDCliente, string nom, string apellido, string genero)
        {
            IDCliente = iDCliente;
            Nom = nom;
            this.apellido = apellido;
            Genero = genero;
        }

        public string Linea()
        {
            return IDCliente + ";" + Nom + ";" + apellido + ";" + Genero;
        }
        private void Mapear(string linea)
        {
            IDCliente = linea.Split(';')[0];
            Nom = linea.Split(';')[1];
            apellido = linea.Split(';')[2];
            Genero = linea.Split(';')[3];
        }
    }
}
