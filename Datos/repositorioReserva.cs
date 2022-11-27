using Datos.ICRUD;
using Entidad;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class repositorioReserva : Conexion, ICRUDRESERVA<Reserva>
    {
        public string Actualizar(Reserva res)
        {
            try
            {
                string _sql = string.Format("UPDATE [dbo].[reserva] SET [cedula] = '{0}' ,[nombre] ='{1}',[cod_habitacion] = '{2}', [tipo]= '{3}',[precio]= '{4}' WHERE [idreserva] = '{5}'", res.idcliente, res.Nom, res.codhabitacion, res.tipohabitacion,res.precio,res.codreserva);

                var cmd = new SqlCommand(_sql, conexionBd);
                Abrirconexion();
                int filas = cmd.ExecuteNonQuery();
                Cerrarconexion();
                if (filas == 1)
                {
                    return "se Actualizo la reserva con" + res.codreserva + "correctamente";
                }
                return "No se pudo actualizar la habitacion = :" + res.codreserva;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public Reserva BuscarReserva(string id)
        {
            try
            {
                string _sql = string.Format("select * from reserva where Idreserva='{0}'", id);
                var cmd = new SqlCommand(_sql, conexionBd);
                Abrirconexion();
                var reader = cmd.ExecuteReader();
                reader.Read();
                var reserva = new Reserva(reader.GetString(0), reader.GetString(1), reader.GetString(2), reader.GetString(3),reader.GetString(4),reader.GetDouble(5));
                Cerrarconexion();
                return reserva;
            }
            catch (Exception)
            {

                return null;
            }
        }

        public List<Reserva> ConsultarTodos(string busqueda)
        {
            string _sql = string.Format("select * from reserva where idreserva like '{0}%' or cedula like '{1}%'", busqueda, busqueda);
            System.Data.DataTable tabla = new DataTable("reserva");
            SqlDataAdapter adapter = new SqlDataAdapter(_sql, conexionBd);

            adapter.Fill(tabla);

            List<Reserva> lista = new List<Reserva>();

            foreach (var fila in tabla.Rows)
            {

                lista.Add(map((DataRow)fila));
            }
            return lista;
            return null;
        }

        Reserva map(DataRow fila)
        {
            Reserva reserva = new Reserva();
            reserva.codreserva = (string)fila[0];
            reserva.idcliente = (string)fila[1];
            reserva.Nom = (string)fila[2];
            reserva.codhabitacion = (string)fila[3];
            reserva.tipohabitacion = (string)fila[4];
            reserva.precio = (double)fila[5];
            return reserva;
        }


        public string Eliminar(Reserva res)
        {
            try
            {
                string _sql = string.Format("DELETE FROM [dbo].[reserva] WHERE idreserva='{0}'", res.codreserva);

                var cmd = new SqlCommand(_sql, conexionBd);
                Abrirconexion();
                int filas = cmd.ExecuteNonQuery();
                Cerrarconexion();
                if (filas == 1)
                {
                    return "reserca con codigo= :" + res.codreserva + "eliminada corretamente";
                }
                else
                {
                    return "No se pudo eliminar la reserva con codigo = :" + res.codhabitacion;
                }

            }
            catch (Exception ex)
            {

                return ex.Message;
            }
        }

        public string Insertar(Reserva res)
        {
            try
            {
                string _sql = string.Format("INSERT INTO reserva VALUES('" + res.codreserva + "','" + res.idcliente +"','" + res.Nom+ "','" + res.codhabitacion + "','" + res.tipohabitacion + "','" + res.precio + "')");
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


        public DataTable cargarcedulas()
        {
            SqlDataAdapter dt = new SqlDataAdapter("cargarcedulas", conexionBd);
            dt.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable tabla = new DataTable();
            dt.Fill(tabla);
            return tabla;
        }

        public DataTable cargarhabitaciones()
        {
            SqlDataAdapter dt = new SqlDataAdapter("cargarhabitaciones", conexionBd);
            dt.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable tabla = new DataTable();
            dt.Fill(tabla);
            return tabla;
        }

    }
    }

