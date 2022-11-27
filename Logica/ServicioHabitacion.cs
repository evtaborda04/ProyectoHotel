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
        List<Habitacion> habitaciones;
        repositorioHabitaciones repositorioHabitaciones = new repositorioHabitaciones();
        public ServicioHabitacion()
        {
            habitaciones = repositorioHabitaciones.ConsultarTodos();
        }

        public string Guardar(Habitacion habitacion)
        {
            string mensaje = string.Empty;
            try
            {

                if (repositorioHabitaciones.Buscar(habitacion.IdHabitacion) == null)
                {
                    mensaje = repositorioHabitaciones.Guardar(habitacion);
                    Actualizar();
                    return mensaje;

                }
                return mensaje;
            }
            catch (Exception e)
            {
                return "Error:" + e.Message;
            }
        }

        private void Actualizar()
        {
            habitaciones = repositorioHabitaciones.ConsultarTodos();
        }
        public List<Habitacion> Consultar()
        {
            return habitaciones;
        }

        public Habitacion BuscarHabitacion(string IDhabitacion)
        {
            foreach (var item in habitaciones)
            {
                if (item.IdHabitacion == IDhabitacion)
                {
                    return item;
                }
            }
            return null;
        }

        public string Eliminar(string identificacion)
        {
            Habitacion habitacion = BuscarHabitacion(identificacion);
            if (habitacion == null)
            {
                return "Habitacion no existe";
            }
            else
            {
                habitaciones.Remove(habitacion);

                repositorioHabitaciones.Modificar_tmp(habitaciones);
                return "Habitacion eliminada";
            }
        }
        public string Modificar(string idhabitacion, Habitacion habitacion_New)
        {
            Habitacion habitacion_actual = BuscarHabitacion(idhabitacion);
            if (habitacion_actual == null)
            {
                return Guardar(habitacion_New);

            }
            else
            {
                habitacion_actual.IdHabitacion = habitacion_New.IdHabitacion;
                return repositorioHabitaciones.Modificar_tmp(habitaciones);
            }

        }

        public class HabitacionConsultaResponse
        {
            public List<Habitacion> Habitaciones { get; set; }
            public string Message { get; set; }
            public bool Error { get; set; }
            public bool HabitacionEncontrada { get; set; }
            public HabitacionConsultaResponse(string message)
            {
                Error = true;
                Message = message;
                HabitacionEncontrada = false;
            }
            public HabitacionConsultaResponse(List<Habitacion> habitaciones)
            {
                Habitaciones = habitaciones;
                Error = false;
                HabitacionEncontrada = true;
            }
        }
    }
}
