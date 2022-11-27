using Entidad;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class Facturas
    {
        string ruta = "FacturasClientes.txt";
        public string Guardar(Factura facturas)
        {
            try
            {

                StreamWriter escritor = new StreamWriter(ruta, true);

                escritor.WriteLine(facturas.ToString());

                escritor.Close();

                return "";
            }
            catch (Exception)
            {
                return "";
            }

        }
        public string Modificar(List<Factura> facturas)
        {
            try
            {
                StreamWriter escritor = new StreamWriter(ruta, false);// sobreescribe
                foreach (var item in facturas)
                {
                    escritor.WriteLine(item.ToString());
                    //close
                }

                escritor.Close();

                return "";


            }
            catch (Exception)
            {

                return "";
            }

        }
        public string Modificar2(List<Factura> facturas)
        {
            try
            {
                StreamWriter escritor = new StreamWriter("tmp.txt", true);
                foreach (var item in facturas)
                {
                    escritor.WriteLine(item.ToString());

                }

                escritor.Close();

                File.Delete(ruta);  // elimina
                File.Move("tmp.txt", ruta);// renombrar

                return "Se modificaron los datos los datos";

            }
            catch (Exception)
            {

                return "NO Se guardaron los datos";
            }

        }

        public List<Factura> Consultar()
        {
            try
            {
                StreamReader lector = new StreamReader(ruta);
                List<Factura> facturas = new List<Factura>();
                string linea = string.Empty;
                while (!lector.EndOfStream)
                {
                    linea = lector.ReadLine();
                    string codigoreserva = linea.Split(';')[0];
                    Habitacion habitaciones = new repositorioHabitaciones().Buscar(linea.Split(';')[1]);
                    DateTime fechaingreso = DateTime.Parse(linea.Split(';')[2]);
                    DateTime fechasalida = DateTime.Parse(linea.Split(';')[3]);
                    Cliente cliente = new repositorioClientes().BuscarID(linea.Split(';')[4]);
                    string tipohab = linea.Split(';')[5];
                    double precio = double.Parse(linea.Split(';')[6]);
                    Factura facturar = new Factura(codigoreserva,habitaciones, fechaingreso, fechasalida, cliente, tipohab, precio);
                    facturas.Add(facturar);


                }


                lector.Close();

                return facturas;
            }
            catch (Exception)
            {
                return null;
            }
        }
        public bool Encontrar(string Idregistrado, String Idbuscado)
        {
            return Idregistrado == Idbuscado;

        }

        private bool Encontrado(string idhabitacionregistrada, string idhabitacionbuscada)
        {
            return idhabitacionregistrada == idhabitacionbuscada;
        }
        public string Eliminar(String codfactura)
        {
            List<Factura> facturas = new List<Factura>();
            facturas = Consultar();
            FileStream archivo = new FileStream(ruta, FileMode.Create);
            archivo.Close();
            foreach (var item in facturas)
            {
                if (!Encontrar(Convert.ToString(item.codigofactura), codfactura))
                {
                    Guardar(item);
                }
            }
            return null;

        }
    }
}
