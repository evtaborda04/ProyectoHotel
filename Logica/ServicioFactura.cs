using Datos;
using Entidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class ServicioFactura
    {
        repositorioFactura repositoriofactura = new repositorioFactura();
        List<Factura> lista = new List<Factura>();
        private string id;

        public string Guardar(Factura factura)
        {
            string mensaje = string.Empty;
            try
            {
                mensaje = repositoriofactura.Insertar(factura);
                return mensaje;

            }
            catch (Exception e)
            {
                return "Error:" + e.Message;
            }
        }
        public Factura Buscar(string id)
        {
            foreach (var item in lista)
            {
                if (Convert.ToString( item.codigofactura) == id)
                {
                    return item;
                }

            }
            return null;

        }

        public Response Buscarconid(string id)
        {
            try
            {
                return new Response(repositoriofactura.BuscarFactura(id));
            }
            catch (Exception exception)
            {
                return new Response("Se presentó el siguiente error:" + exception.Message);
            }
        }



        public string Eliminar(Factura factura)
        {
            Factura facturas = Buscar(id);

            if (factura != null)
            {
                return "factura no existe";
            }
            else
            {
                repositoriofactura.Eliminar(factura);

                return "factura eliminada";
            }
        }
        public string Actualizar(Factura factura)
        {
            Factura facturas = Buscar(id);
            if (factura == null)
            {
                return Guardar(factura);

            }
            else
            {
                factura.codigofactura = factura.codigofactura;
                return repositoriofactura.Actualizar(factura);
            }
        }
    }
}
