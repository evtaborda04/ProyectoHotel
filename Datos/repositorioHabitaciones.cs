using Datos.ICRUD;
using Entidad;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class repositorioHabitaciones : Conexion, ICRUDHABITACION<Habitacion>
    {
        public string Actualizar(Habitacion hab)
        {
            try
            {
                string _sql = string.Format("UPDATE [dbo].[habitacion] SET [tipo] = '{0}' ,[precio] ='{1}',[nropiso] = '{2}' WHERE [ID] = '{3}'", hab.TipoHabitacion, hab.precio, hab.Nropiso, hab.IdHabitacion);

                var cmd = new SqlCommand(_sql, conexionBd);
                Abrirconexion();
                int filas = cmd.ExecuteNonQuery();
                Cerrarconexion();
                if (filas == 1)
                {
                    return "se Actualizo la habitacion con"+hab.IdHabitacion+"correctamente";
                }
                return "No se pudo actualizar la habitacion = :" + hab.IdHabitacion;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public Habitacion BuscarHabitacion(string id)
        {
            try
            {
                string _sql = string.Format("select * from habitacion where Id='{0}'", id);
                var cmd = new SqlCommand(_sql, conexionBd);
                Abrirconexion();
                var reader = cmd.ExecuteReader();
                reader.Read();
                var habitacion = new Habitacion(reader.GetString(0), reader.GetString(1), reader.GetDouble(2), reader.GetInt32(3));
                Cerrarconexion();
                return habitacion;
            }
            catch (Exception)
            {

                return null;
            }
        }

        public List<Habitacion> ConsultarTodos(string busqueda)
        {
            string _sql = string.Format("select * from habitacion where id like '{0}%' or tipo like '{1}%'", busqueda, busqueda);
            System.Data.DataTable tabla = new DataTable("habitacion");
            SqlDataAdapter adapter = new SqlDataAdapter(_sql, conexionBd);

            adapter.Fill(tabla);

            List<Habitacion> lista = new List<Habitacion>();

            foreach (var fila in tabla.Rows)
            {

                lista.Add(map((DataRow)fila));
            }
            return lista;
            return null;
        }
        Habitacion map(DataRow fila)
        {
            Habitacion habitacion = new Habitacion();
            habitacion.IdHabitacion = (string)fila[0];
            habitacion.TipoHabitacion = (string)fila[1];
            habitacion.precio = (double)fila[2];
            habitacion.Nropiso = (int)fila[3];
            return habitacion;
        }

        public string Eliminar(Habitacion hab)
        {
            try
            {
                string _sql = string.Format("DELETE FROM [dbo].[habitacion] WHERE ID='{0}'", hab.IdHabitacion);

                var cmd = new SqlCommand(_sql, conexionBd);
                Abrirconexion();
                int filas = cmd.ExecuteNonQuery();
                Cerrarconexion();
                if (filas == 1)
                {
                    return "habitacion con = :" + hab.IdHabitacion + "eliminada corretamente";
                }
                else
                {
                    return "No se pudo eliminar la habitacion con id  = :" + hab.IdHabitacion;
                }

            }
            catch (Exception ex)
            {

                return ex.Message;
            }
        }

        public string Insertar(Habitacion hab)
        {
            try
            {
                string _sql = string.Format("INSERT INTO Habitacion VALUES('" + hab.IdHabitacion + "','" + hab.TipoHabitacion + "','" + hab.precio + "','" + hab.Nropiso + "')");
                var cmd = new SqlCommand(_sql, conexionBd);
                Abrirconexion();
                int filas = cmd.ExecuteNonQuery();
                Cerrarconexion();
                if (filas > 0)
                {
                    return "Datos guardados satisfactoriamente";
                }
                return "No se pudo guardar los datos";

            }
            catch (Exception e)
            {

                return e.Message;
            }
            return null;
        }
    }
}
