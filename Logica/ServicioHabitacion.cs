using Datos;
using Entidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class ServicioHabitacion
    {
        repositorioHabitaciones repositoriohabitacion = new repositorioHabitaciones();
        List<Habitacion> lista = new List<Habitacion>();
        private string id;

        public string Guardar(Habitacion habitacion)
        {
            string mensaje = string.Empty;
            try
            {

                if (repositoriohabitacion.BuscarHabitacion(habitacion.IdHabitacion) == null)
                {
                    mensaje = repositoriohabitacion.Insertar(habitacion);
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
                return new Response(repositoriohabitacion.BuscarHabitacion(id));
            }
            catch (Exception exception)
            {
                return new Response("Se presentó el siguiente error:" + exception.Message);
            }
        }
        public Habitacion Buscar(string id)
        {
            foreach (var item in lista)
            {
                if (item.IdHabitacion == id)
                {
                    return item;
                }

            }
            return null;

        }

        public string Eliminar(Habitacion habitacion)
        {
            Habitacion habitaciones = Buscar(id);

            if (habitacion != null)
            {
                return "habitacion no existe";
            }
            else
            {
                repositoriohabitacion.Eliminar(habitacion);

                return "habitacion eliminada";
            }
        }
        public string Actualizar(Habitacion habitacion)
        {
            Habitacion habitaciones = Buscar(id);
            if (habitacion == null)
            {
                return Guardar(habitacion);

            }
            else
            {
                habitacion.IdHabitacion = habitacion.IdHabitacion;
                return repositoriohabitacion.Actualizar(habitacion);
            }
        }
    }
}
