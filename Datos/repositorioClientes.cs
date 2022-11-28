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
    public class repositorioClientes : Conexion,ICRUDCLIENTE<Cliente>
    {
        public string Insertar(Cliente cli)
        {
            try
            {
                string _sql = string.Format("INSERT INTO Clientes VALUES('" + cli.IDCliente + "','" + cli.Nom + "','" + cli.apellido + "','" + cli.Genero  + "')");
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
            catch (SqlException e)
            {
                if (e.Number == 2627)
                {
                    return "Error: El cliente ya existe, Por favor revisar";

                }

                return e.Message;
            }
            return null;
        }

        public string Eliminar(Cliente cli)
        {
            try
            {
                string _sql = string.Format("DELETE FROM [dbo].[Clientes] WHERE ID='{0}'", cli.IDCliente);

                var cmd = new SqlCommand(_sql, conexionBd);
                Abrirconexion();
                int filas = cmd.ExecuteNonQuery();
                Cerrarconexion();
                if (filas == 1)
                {
                    return "cliente = :" + cli.IDCliente + "eliminado corretamente";
                }
                else
                {
                    return "No se pudo eliminar el cliente con  = :" + cli.IDCliente;
                }

            }
            catch (Exception ex)
            {

                return "El cliente tiene una Habitacion Asignada, Por favor revisar";
            }
        }

        public string Actualizar(Cliente cli)
        {
            try
            {
                string _sql = string.Format("UPDATE [dbo].[Clientes] SET [nombre] = '{0}' ,[apellido] ='{1}',[genero] = '{2}' WHERE [ID] = '{3}'", cli.Nom, cli.apellido, cli.Genero,cli.IDCliente);

                var cmd = new SqlCommand(_sql, conexionBd);
                Abrirconexion();
                int filas = cmd.ExecuteNonQuery();
                Cerrarconexion();
                if (filas == 1)
                {
                    return "se Actualizo el registro del cliente cuyo id = :" + cli.Nom;
                }
                return "No se pudo actualizar el cliente = :" + cli.Nom;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public Cliente BuscarID(string id)
        {
            try
            {
                string _sql = string.Format("select * from clientes where Id='{0}'", id);
                var cmd = new SqlCommand(_sql, conexionBd);
                Abrirconexion();
                var reader = cmd.ExecuteReader();
                reader.Read();
                var cliente = new Cliente(reader.GetString(0), reader.GetString(1), reader.GetString(2), reader.GetString(3));
                Cerrarconexion();
                return cliente;
            }
            catch (Exception)
            {

                return null;
            }

        }

        public List<Cliente> ConsultarTodos(string busqueda)
        {
            string _sql = string.Format("select * from clientes where id like '{0}%' or Nombre like '{1}%'", busqueda, busqueda);
            System.Data.DataTable tabla = new DataTable("clientes");
            SqlDataAdapter adapter = new SqlDataAdapter(_sql, conexionBd);

            adapter.Fill(tabla);

            List<Cliente> lista = new List<Cliente>();

            foreach (var fila in tabla.Rows)
            {

                lista.Add(map((DataRow)fila));
            }
            return lista;
            return null;
        }

        //mapeo
        Cliente map(DataRow fila)
        {
            Cliente cliente = new Cliente();
            cliente.IDCliente = (string)fila[0];
            cliente.Nom = (string)fila[1];
            cliente.apellido = (string)fila[2];
            cliente.Genero = (string)fila[3];
            return cliente;
        }
    }
}

