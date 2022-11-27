using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class Conexion
    {
        private static Conexion conexion = null;
        protected SqlConnection conexionBd;
        protected string cadenaconexion;

        public Conexion()
        {
            cadenaconexion = string.Format("Server={0};Database={1};Trusted_Connection=True;",".\\SQLEXPRESS","PROYECTOHOTEL");
            conexionBd = new SqlConnection(cadenaconexion);
        }

        public string Abrirconexion()
        {
                if (conexionBd.State == System.Data.ConnectionState.Open)
                {
                    Cerrarconexion();
                }
                conexionBd.Open();
                return conexionBd.State.ToString();


            }

        public void Cerrarconexion()
        {
            conexionBd.Close();
        }

        public static Conexion GetInstancia()
        {
            if (conexion == null)
            {
                conexion = new Conexion();
            }
            return conexion;
        }

    }
}
