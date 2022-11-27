using Entidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
namespace Logica
{
    public class ServicioCliente
    {
        repositorioClientes repositorioclientes = new repositorioClientes();
        List<Cliente> lista = new List<Cliente>();
        private string id;

        public string Guardar(Cliente cliente)
        {
            string mensaje = string.Empty;
            try
            {

                if (repositorioclientes.BuscarID(cliente.IDCliente) == null)
                {
                    mensaje = repositorioclientes.Insertar(cliente);
                    return mensaje;

                }
                return mensaje;
            }
            catch (Exception e)
            {
                return "Error:" + e.Message;
            }
        }
        


        public Response BuscarPorid(string id)
        {
            try
            {
                return new Response(repositorioclientes.BuscarID(id));
            }
            catch (Exception exception)
            {
                return new Response("Se presentó el siguiente error:" + exception.Message);
            }
        }
        public Cliente Buscar(string id)
        {
            foreach (var item in lista)
            {
                if (item.IDCliente == id)
                {
                    return item;
                }

            }
            return null;

        }

        public string Eliminar(Cliente cliente)
        {
            Cliente clientes = Buscar(id);

            if (cliente != null)
            {
                return "cliente no existe";
            }
            else
            {
                repositorioclientes.Eliminar(clientes);

                return "cliente eliminado";
            }
        }
        public string Actualizar(Cliente cliente)
        {
            Cliente clientes = Buscar(id);
            if (cliente == null)
            {
                return Guardar(cliente);

            }
            else
            {
                cliente.IDCliente = cliente.IDCliente;
                return repositorioclientes.Actualizar(cliente);
            }
        }
    }
    }

