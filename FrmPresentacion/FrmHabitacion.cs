using Datos;
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
        public FrmHabitacion()
        {
            InitializeComponent();

        }

        void cargarlistadohabitacion(string busqueda)
        {
            listahabitaciones.DataSource = new repositorioHabitaciones().ConsultarTodos(busqueda);
            listahabitaciones.DisplayMember = "TipoHabitacion";
            listahabitaciones.ValueMember = "idhabitacion";
            if (listahabitaciones.Items.Count > 0)
            {
                listahabitaciones.SelectedIndex = 0;
                listahabitaciones.Select();
            }
        }
        void CargarGrillaHabitacion(string busqueda)
        {
            grillahabitaciones.DataSource = new repositorioHabitaciones().ConsultarTodos(busqueda);

        }

        void Buscar(string id)
        {
            try
            {
                var habitacion = new repositorioHabitaciones().BuscarHabitacion(id);
                ver(habitacion);
            }
            catch (Exception)
            {


            }
        }
        void ver(Habitacion habitacion)
        {
            if (habitacion == null)
            {
                return;
            }
            txtidhabitacion.Text = habitacion.IdHabitacion;
            cmbtipohabitacion.Text = habitacion.TipoHabitacion;
            txtPrecio.Text = Convert.ToString(habitacion.precio);
            numericpisos.Text = Convert.ToString(habitacion.Nropiso);

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
            refresh();



        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Buscar(txtidhabitacion.Text);
        }
       
   

        private void btnactualizar_Click(object sender, EventArgs e)
        {

            Habitacion habitacion = new Habitacion();
            ServicioHabitacion servicio = new ServicioHabitacion();
            habitacion.IdHabitacion = txtidhabitacion.Text;
            habitacion.TipoHabitacion = cmbtipohabitacion.Text;
            habitacion.precio = Convert.ToDouble(txtPrecio.Text);
            habitacion.Nropiso = Convert.ToInt32(numericpisos.Text);
            Actualizar(habitacion);
            MessageBox.Show("Habitacion actualizada correctamente");
            refresh();


        }
        void Actualizar(Habitacion habitacion)
        {
            MessageBox.Show(new ServicioHabitacion().Actualizar(habitacion));

        }


        private void btneliminar_Click(object sender, EventArgs e)
        {

            if (txtidhabitacion.Text.Length == 0)
            {
                return;
            }
            Eliminar(new repositorioHabitaciones().BuscarHabitacion(txtidhabitacion.Text));
            refresh();

        }
        void Eliminar(Habitacion habitacion)
        {

            MessageBox.Show(new repositorioHabitaciones().Eliminar(habitacion));

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



        private void txtbuscaridhabitacion_TextChanged(object sender, EventArgs e)
        {
            string condicion = txtbuscaridhabitacion.Text.Trim();
            CargarGrillaHabitacion(condicion);
        }

        private void FrmHabitacion_Load(object sender, EventArgs e)
        {
            cargarlistadohabitacion("");
            CargarGrillaHabitacion("");
        }
        void refresh()
        {
            cargarlistadohabitacion("");
            CargarGrillaHabitacion("");
        }

        private void grillahabitaciones_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string id = grillahabitaciones.Rows[e.RowIndex].Cells[0].Value.ToString();
            Buscar(id);
            listahabitaciones.SelectedIndex = e.RowIndex;
            this.tabControl1.TabPages[0].Show();
        }

        private void listahabitaciones_SelectedIndexChanged(object sender, EventArgs e)
        {
            string id = listahabitaciones.SelectedValue.ToString();
            Buscar(id);
        }
    }
}
