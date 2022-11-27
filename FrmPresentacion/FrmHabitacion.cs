using Entidad;
using Logica;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrmPresentacion
{
    public partial class FrmHabitacion : Form
    {
        List<Entidad.Habitacion> lista = new Logica.ServicioHabitacion().Consultar();
        DataTable dt = new DataTable();
        public FrmHabitacion()
        {
            InitializeComponent();
            CargarDatos();
        }

        private void cmbPrecio_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Agregar();
        }

        void Agregar()
        {
            Habitacion habitacion = new Habitacion();
            ServicioHabitacion servicio = new ServicioHabitacion();
            habitacion.IdHabitacion = txtidhabitacion.Text;
            habitacion.TipoHabitacion = cmbtipohabitacion.Text;
            habitacion.precio = Convert.ToDouble(txtPrecio.Text);
            habitacion.Nropiso = Convert.ToInt32(numericpisos.Text);
            servicio.Guardar(habitacion);
            MessageBox.Show("Habitacion guardada correctamente");
         


        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Buscar(txtidhabitacion.Text);
        }
        void Buscar(string habitaciones)
        {

            ServicioHabitacion sc = new ServicioHabitacion();
            Habitacion habitacion;


            habitacion = sc.BuscarHabitacion(habitaciones);
            if (habitacion == null)
            {
                MessageBox.Show("No existe");
                return;

            }
            else
            {
                Ver(habitacion);
            }


        }
        void Ver(Habitacion habitacion)
        {

            txtidhabitacion.Text = habitacion.IdHabitacion;
            cmbtipohabitacion.Text = habitacion.TipoHabitacion;
            txtPrecio.Text =Convert.ToString( habitacion.precio);
            numericpisos.Text =Convert.ToString( habitacion.Nropiso);

        }

        private void btnactualizar_Click(object sender, EventArgs e)
        {

            ServicioHabitacion servico = new ServicioHabitacion();
            Entidad.Habitacion habitacion;
            string idhabitacion;


            idhabitacion = txtidhabitacion.Text;

            habitacion = servico.BuscarHabitacion(idhabitacion);
            if (habitacion == null)
            {
                MessageBox.Show("habitacion no existe");
                return;

            }
            else
            {
                habitacion.IdHabitacion = txtidhabitacion.Text;
                habitacion.TipoHabitacion = cmbtipohabitacion.Text;
                habitacion.precio =Convert.ToDouble( txtPrecio.Text);
                habitacion.Nropiso =Convert.ToInt32( numericpisos.Text);
                servico.Modificar(txtidhabitacion.Text, new Habitacion(txtidhabitacion.Text, cmbtipohabitacion.Text,Convert.ToDouble(txtPrecio.Text),Convert.ToInt32(numericpisos.Text)));
                MessageBox.Show("Habitacion actualizada correctamente");
            }
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            ServicioHabitacion servico = new ServicioHabitacion();
            Entidad.Habitacion habitacion;
            string idhabitacion;
            ServicioHabitacion sc = new ServicioHabitacion();

            idhabitacion = txtidhabitacion.Text;

            habitacion = servico.BuscarHabitacion(idhabitacion);
            if (habitacion == null)
            {
                MessageBox.Show("habiatcion no existe");
                return;

            }
            else
            {
                Ver(habitacion);
                MessageBox.Show("habitacion eliminado correctamente");
                servico.Eliminar(idhabitacion);
            }
            

        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            txtidhabitacion.Focus();
            txtidhabitacion.Clear();
            cmbtipohabitacion.Text = "";
            txtPrecio.Clear();
            numericpisos.Value = 1;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }



        public void CargarDatos()
        {
            dt.Columns.Add("Id habitacion");
            dt.Columns.Add("Tipo Habitacion");
            dt.Columns.Add("Precio");
            dt.Columns.Add("Nro Piso");

            grillahabitacion.DataSource = dt;

            RecorrerArchivo();
        }


        public void RecorrerArchivo()
        {
            StreamReader lc = new StreamReader("HabitacionesHotel.txt");

            string cadena;
            string[] campos = new string[4];
            char[] separador = { ';' };

            cadena = lc.ReadLine();

            while (cadena != null)
            {
                campos = cadena.Split(separador);

                DataRow row = dt.NewRow();
                row[0] = campos[0];
                row[1] = campos[1];
                row[2] = campos[2];
                row[3] = campos[3];

                dt.Rows.Add(row);

                cadena = lc.ReadLine();
            }

            lc.Close();
        }

        void BuscarDatos()
        {
            grillahabitaciones.DataSource = new Logica.ServicioHabitacion().Consultar();
        }


        void BuscarDatosFiltro(String Filtro)
        {
            grillahabitaciones.Rows.Clear();
            foreach (var item in lista)
            {
                if (item.IdHabitacion.ToUpper().StartsWith(Filtro.ToUpper()))
                {
                    grillahabitaciones.Rows.Add(item.IdHabitacion, item.TipoHabitacion, item.precio, item.Nropiso);
                }
            }
        }

        private void txtbuscaridhabitacion_TextChanged(object sender, EventArgs e)
        {
            BuscarDatosFiltro(txtbuscaridhabitacion.Text);
        }

        private void FrmHabitacion_Load(object sender, EventArgs e)
        {
            BuscarDatosFiltro("");
        }
    }
}
