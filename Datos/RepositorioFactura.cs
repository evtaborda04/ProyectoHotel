using Entidad;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class RepositorioFactura
    {
        //string ruta = "factura.txt";
        //public string Guardar(Facturacion facturacion)
        //{
        //    try
        //    {

        //        StreamWriter escritor = new StreamWriter(ruta, true);

        //        escritor.WriteLine(facturacion.ToString());

        //        escritor.Close();

        //        return "";
        //    }
        //    catch (Exception)
        //    {
        //        return "";
        //    }

        //}
        //public string Modificar(List<Facturacion> facturaciones)
        //{
        //    try
        //    {
        //        StreamWriter escritor = new StreamWriter(ruta, false);// sobreescribe
        //        foreach (var item in facturaciones)
        //        {
        //            escritor.WriteLine(item.ToString());
        //            //close
        //        }

        //        escritor.Close();

        //        return "";


        //    }
        //    catch (Exception)
        //    {

        //        return "";
        //    }

        //}
        //public string Modificar2(List<Facturacion> facturaciones)
        //{
        //    try
        //    {
        //        StreamWriter escritor = new StreamWriter("tmp.txt", true);
        //        foreach (var item in facturaciones)
        //        {
        //            escritor.WriteLine(item.ToString());

        //        }

        //        escritor.Close();

        //        File.Delete(ruta);  // elimina
        //        File.Move("tmp.txt", ruta);// renombrar

        //        return "Se modificaron los datos";

        //    }
        //    catch (Exception)
        //    {

        //        return "NO Se guardaron los datos";
        //    }

        //}

        //public List<Facturacion> Consultar()
        //{
        //    try
        //    {
        //        StreamReader lector = new StreamReader(ruta);
        //        List<Facturacion> reservas = new List<Facturacion>();
        //        string linea = string.Empty;
        //        while (!lector.EndOfStream)
        //        {
        //            linea = lector.ReadLine();
        //            string codigofactura = linea.Split(';')[0];
        //            string codigoreserva = linea.Split(';')[1];
        //            Cliente cliente = new repositorioClientes().Buscar(linea.Split(';')[2]);
        //            string tipohabitacion = linea.Split(';')[3];
        //            double precio = double.Parse(linea.Split(';')[4]);
        //            double descuento = Convert.ToDouble(linea.Split(';')[5]);
        //            DateTime fechaingreso = DateTime.Parse(linea.Split(';')[6]);
        //            DateTime fechasalida = DateTime.Parse(linea.Split(';')[7]);
        //            double total = Convert.ToDouble(linea.Split(';')[8]);
        //            Facturacion facturar = new Facturacion(codigofactura, codigoreserva,cliente, tipohabitacion,  precio,fechaingreso,fechasalida);
        //            reservas.Add(facturar);


        //        }


        //        lector.Close();

        //        return reservas;
        //    }
        //    catch (Exception)
        //    {
        //        return null;
        //    }
        //}
        //public bool Encontrar(string Idregistrado, String Idbuscado)
        //{
        //    return Idregistrado == Idbuscado;

        //}
        //public string Eliminar(String codfactura)
        //{
        //    List<Facturacion> facturaciones = new List<Facturacion>();
        //    facturaciones = Consultar();
        //    FileStream archivo = new FileStream(ruta, FileMode.Create);
        //    archivo.Close();
        //    foreach (var item in facturaciones)
        //    {
        //        if (!Encontrar(Convert.ToString(item.codfactura),  codfactura))
        //        {
        //            Guardar(item);
        //        }
        //    }
        //    return null;

        //}
    }
}
