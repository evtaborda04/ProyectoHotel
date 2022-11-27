using Entidad;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class repositorioHabitaciones
    {
        string ruta = "HabitacionesHotel.txt";
        public string Guardar(Habitacion habitacion)
        {
            try
            {

                StreamWriter escritor = new StreamWriter(ruta, true);
                escritor.WriteLine(habitacion.Linea());
                escritor.Close();
                return "Se guardaron los datos";
            }
            catch (Exception)
            {

                return "NO Se guardaron los datos";
            }

        }

        public string Modificar(List<Entidad.Habitacion> habitaciones)
        {
            try
            {
                StreamWriter escritor = new StreamWriter(ruta, false);
                foreach (var item in habitaciones)
                {
                    escritor.WriteLine(item.Linea());
                }

                escritor.Close();

                return "Se modificaron los datos los datos";

            }
            catch (Exception)
            {

                return "NO Se guardaron los datos";
            }

        }
        public string Modificar_tmp(List<Entidad.Habitacion> habitaciones)
        {
            try
            {
                StreamWriter escritor = new StreamWriter("tmp.txt");
                foreach (var item in habitaciones)
                {
                    escritor.WriteLine(item.Linea());

                }

                escritor.Close();

                File.Delete(ruta);

                File.Move("tmp.txt", ruta);

                return "Se modificaron los datos los datos";


            }
            catch (Exception)
            {

                return "NO Se guardaron los datos";
            }

        }
        public Habitacion Buscar(string idhabitacion)
        {
            List<Habitacion> habitaciones = ConsultarTodos();
            foreach (var item in habitaciones)
            {
                if (Encontrado(item.IdHabitacion, idhabitacion))
                {
                    return item;
                }
            }
            return null;
        }
        private bool Encontrado(string IdHabitacionRegistrada, string IdHabitacionBuscada)
        {
            return IdHabitacionRegistrada == IdHabitacionBuscada;
        }

        public List<Habitacion> ConsultarTodos()
        {
            List<Habitacion> habitaciones = new List<Habitacion>();
            FileStream archivo = new FileStream(ruta, FileMode.OpenOrCreate, FileAccess.Read);
            StreamReader lector = new StreamReader(ruta);
            string linea = string.Empty;
            while (!lector.EndOfStream)
            {
                linea = lector.ReadLine();
                Habitacion habitacion = new Habitacion(linea);
                habitaciones.Add(habitacion);
            }
            lector.Close();
            archivo.Close();
            return habitaciones;
        }


        public void Eliminar(String idhabitacion)
        {
            List<Habitacion> habitaciones = new List<Habitacion>();
            habitaciones = ConsultarTodos();
            FileStream archivo = new FileStream(ruta, FileMode.Create);
            archivo.Close();
            foreach (var item in habitaciones)
            {
                if (!Encontrado(item.IdHabitacion, idhabitacion))
                {
                    Guardar(item);
                }
            }
        }
        public void Modificar_old(Habitacion habitacionfirst, Habitacion habitacionNew)
        {
            List<Habitacion> habitaciones;  //se almacenan todos los clientes
            habitaciones = ConsultarTodos();
            FileStream file = new FileStream(ruta, FileMode.Create);
            file.Close();
            foreach (var item in habitaciones)
            {
                if (!Encontrado(item.IdHabitacion, habitacionfirst.IdHabitacion))
                {
                    Guardar(item);
                }
                else
                {
                    Guardar(habitacionNew);
                }
            }
        }

        public List<Habitacion> FiltrarIdentificacion(string idhabitacion)
        {
            return ConsultarTodos().Where(p => p.IdHabitacion.Equals(idhabitacion)).ToList();
        }
    }
}
