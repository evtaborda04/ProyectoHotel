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
    public class repositorioFactura : Conexion, ICRUD<Factura>
    {
        public string Actualizar(Factura rent)
        {
            try
            {
                string _sql = string.Format("UPDATE [dbo].[Factura] SET [fechaingreso] = '{0}' ,[fechasalida] ='{1}',[cod_reserva] = '{2}', [cedula]= '{3}',[nombre]= '{4}',[habitacion]= '{5}', [tipohabitacion]= '{6}', [precio]= '{7}', [cantidad_dias]= '{8}',[total]= '{9}' WHERE [cod_factura] = '{10}'"
                    , rent.fechaingreso, rent.fechasalida, rent.codreserva, rent.IDCliente,
                    rent.Nom, rent.codhabitacion, rent.tipohabitacion, rent.precio, rent.cantidad_dias,
                    rent.Total, rent.codigofactura);

                var cmd = new SqlCommand(_sql, conexionBd);
                Abrirconexion();
                int filas = cmd.ExecuteNonQuery();
                Cerrarconexion();
                if (filas == 1)
                {
                    return "se Actualizo la reserva con" + rent.codigofactura + "correctamente";
                }
                return "No se pudo actualizar la habitacion = :" + rent.codigofactura;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public Factura BuscarFactura(string id)
        {
            try
            {
                string _sql = string.Format("select * from factura where cod_factura='{0}'", id);
                var cmd = new SqlCommand(_sql, conexionBd);
                Abrirconexion();
                var reader = cmd.ExecuteReader();
                reader.Read();
                var factura = new Factura(reader.GetInt32(0), reader.GetDateTime(1), reader.GetDateTime(2), reader.GetString(3), reader.GetString(4), reader.GetString(5), reader.GetString(6), reader.GetString(7), reader.GetDouble(8), reader.GetInt32(9), reader.GetDouble(10));
                Cerrarconexion();
                return factura;
            }
            catch (Exception)
            {

                return null;
            }
        }

        public List<Factura> ConsultarTodos(string busqueda)
        {
            string _sql = string.Format("select * from factura where cod_factura like '{0}%' or cod_reserva like '{1}%' or cedula like '{2}%'", busqueda, busqueda, busqueda);
            System.Data.DataTable tabla = new DataTable("factura");
            SqlDataAdapter adapter = new SqlDataAdapter(_sql, conexionBd);

            adapter.Fill(tabla);

            List<Factura> lista = new List<Factura>();

            foreach (var fila in tabla.Rows)
            {

                lista.Add(map((DataRow)fila));
            }
            return lista;
        }


        Factura map(DataRow fila)
        {
            Factura factura = new Factura();
            factura.codigofactura = (int)fila[0];
            factura.fechaingreso = (DateTime)fila[1];
            factura.fechasalida = (DateTime)fila[2];
            factura.codreserva = (string)fila[3];
            factura.IDCliente = (string)fila[4];
            factura.Nom = (string)fila[5];
            factura.codhabitacion = (string)fila[6];
            factura.tipohabitacion = (string)fila[7];
            factura.precio = (double)fila[8];
            factura.cantidad_dias =(int)fila[9];
            factura.Total = (double)fila[10];
            return factura;
        }

        public string Eliminar(Factura ren)
        {
            try
            {
                string _sql = string.Format("DELETE FROM [dbo].[factura] WHERE cod_factura='{0}'", ren.codigofactura);

                var cmd = new SqlCommand(_sql, conexionBd);
                Abrirconexion();
                int filas = cmd.ExecuteNonQuery();
                Cerrarconexion();
                if (filas == 1)
                {
                    return "reserca con codigo=:" + ren.codigofactura + "eliminada corretamente";
                }
                else
                {
                    return "No se pudo eliminar la reserva con codigo= :" + ren.codigofactura;
                }

            }
            catch (Exception ex)
            {

                return ex.Message;
            }
        }

        public string Insertar(Factura rent)
        {
            try
            {
                string _sql = string.Format("INSERT INTO factura VALUES('" +  rent.fechaingreso + "','" + rent.fechasalida
                    + "','" + rent.codreserva + "','" + rent.IDCliente + "','" +
                    rent.Nom + "','" + rent.codhabitacion + "','" + rent.tipohabitacion + "','" +
                    rent.precio + "','" + rent.cantidad_dias + "','" + rent.Total + "')");
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



        public DataTable cargarfacturas()
        {
            SqlDataAdapter dt = new SqlDataAdapter("pa_cargar_reserva", conexionBd);
            dt.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable tabla = new DataTable();
            dt.Fill(tabla);
            return tabla;
        }

        public Factura BuscarID(string id)
        {
            //Esta funcion no esta disponible en la factura
            throw new NotImplementedException();
        }
    }
}

