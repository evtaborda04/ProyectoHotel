using Datos;
using Entidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class servicioReserva
    {
      
        repositorioReserva repositorioreserva = new repositorioReserva();
        List<Reserva> lista = new List<Reserva>();
        private string id;

        public string Guardar(Reserva reserva)
        {
            string mensaje = string.Empty;
            try
            {
                mensaje = repositorioreserva.Insertar(reserva);
                return mensaje;

            }
            catch (Exception e)
            {
                return "Error:" + e.Message;
            }
        }
        public Reserva Buscar(string id)
        {
            foreach (var item in lista)
            {
                if (item.codreserva == id)
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
                return new Response(repositorioreserva.BuscarReserva(id));
            }
            catch (Exception exception)
            {
                return new Response("Se presentó el siguiente error:" + exception.Message);
            }
        }



        public string Eliminar(Reserva reserva)
        {
            Reserva reservas = Buscar(id);

            if (reserva != null)
            {
                return "reserva no existe";
            }
            else
            {
                repositorioreserva.Eliminar(reserva);

                return "reserva eliminada";
            }
        }
        public string Actualizar(Reserva reserva)
        {
            Reserva reservas = Buscar(id);
            if (reserva == null)
            {
                return Guardar(reserva);

            }
            else
            {
                reserva.codreserva = reserva.codreserva;
                return repositorioreserva.Actualizar(reserva);
            }
        }

    }
}
