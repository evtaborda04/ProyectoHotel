using Datos;
using Entidad;
using Logica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrmPresentacion
{
    public partial class FrmReserva : Form
    {
        repositorioReserva Rr = new repositorioReserva();
        public FrmReserva()
        {
            InitializeComponent();
            serviciocliente = new ServicioCliente();
            servicioHabitacion = new ServicioHabitacion();
            servicioreserva = new servicioReserva();
        }
        ServicioCliente serviciocliente;
        ServicioHabitacion servicioHabitacion;
        servicioReserva servicioreserva;



        void cargarlistareservas(string busqueda)
        {
            listareservas.DataSource = new repositorioReserva().ConsultarTodos(busqueda);
            listareservas.DisplayMember = "idcliente";
            listareservas.ValueMember = "codreserva";
            if (listareservas.Items.Count > 0)
            {
                listareservas.SelectedIndex = 0;
                listareservas.Select();
            }
        }
        void CargarGrillaHabitacion(string busqueda)
        {
            grillareservas.DataSource = new repositorioReserva().ConsultarTodos(busqueda);

        }

        void Buscar(string id)
        {
            try
            {
                var reserva = new repositorioReserva().BuscarReserva(id);
                ver(reserva);
            }
            catch (Exception)
            {


            }
        }
        void ver(Reserva reserva)
        {
            if (reserva == null)
            {
                return;
            }
            txtcodreserva.Text = reserva.codreserva;
            cmbcedulas.Text = reserva.IDCliente;
            txtnombre.Text = reserva.Nom;
            cmbhabitacion.Text = reserva.codhabitacion;
            txttipo.Text = reserva.tipohabitacion;
            txtprecio.Text =Convert.ToString( reserva.precio);

        }

        void cargarcedula()
        {
            cmbcedulas.DataSource = Rr.cargarcedulas();
            cmbcedulas.DisplayMember = "id";
        }

        void cargarhabitacion()
        {
            cmbhabitacion.DataSource = Rr.cargarhabitaciones();
            cmbhabitacion.DisplayMember = "id";
        }
        void ver_cliente(Cliente clie)
        {
            if (clie == null)
            {
                return;
            }
            txtnombre.Text = clie.Nom;
        }

        void ver_habitacion(Habitacion habi)
        {
            if (habi == null)
            {
                return;
            }
            txttipo.Text = habi.TipoHabitacion;
            txtprecio.Text = Convert.ToString(habi.precio);
        }


        private Reserva guardadoreserva()
        {
            Reserva reserva = new Reserva
            {
                codreserva = txtcodreserva.Text,
                IDCliente = cmbcedulas.Text,
                Nom = txtnombre.Text,
                codhabitacion = cmbhabitacion.Text,
                tipohabitacion = txttipo.Text,
                precio = Convert.ToDouble(txtprecio.Text),
            };
          
            return reserva;
        }
        void refresh()
        {
            CargarGrillaHabitacion("");
            cargarlistareservas("");
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

            string guardar = servicioreserva.Guardar(guardadoreserva());
            MessageBox.Show(guardar);
            refresh();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Buscar(txtcodreserva.Text);
        }

        private void btnactualizar_Click(object sender, EventArgs e)
        {
            string guardar = servicioreserva.Actualizar(actualizarreserva());
            MessageBox.Show(guardar);
            refresh();
        }

        public Reserva actualizarreserva()
        {
            Reserva reserva = new Reserva
            {
                codreserva = txtcodreserva.Text,
                IDCliente = cmbcedulas.Text,
                Nom = txtnombre.Text,
                codhabitacion = cmbhabitacion.Text,
                tipohabitacion = txttipo.Text,
                precio = Convert.ToDouble(txtprecio.Text),
            };

            return reserva;
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            if (txtcodreserva.Text.Length == 0)
            {
                return;
            }
            Eliminar(new repositorioReserva().BuscarReserva(txtcodreserva.Text));
            refresh();
        }

        void Eliminar(Reserva reserva)
        {

            MessageBox.Show(new repositorioReserva().Eliminar(reserva));

        }

        private void btnbuscarc_Click(object sender, EventArgs e)
        {
            var respuesta = serviciocliente.BuscarPorid(cmbcedulas.Text);
            ver_cliente(respuesta.Cliente);
        }

        private void btnbuscarh_Click(object sender, EventArgs e)
        {
            var respuesta = servicioHabitacion.BuscarPorid(cmbhabitacion.Text);
            ver_habitacion(respuesta.Habitacion);
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void FrmReserva_Load(object sender, EventArgs e)
        {
            cargarhabitacion();
            cargarcedula();
            CargarGrillaHabitacion("");
            cargarlistareservas("");
        }

        private void listareservas_SelectedIndexChanged(object sender, EventArgs e)
        {
            string id = listareservas.SelectedValue.ToString();
            Buscar(id);
        }

        private void grillareservas_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            string id = grillareservas.Rows[e.RowIndex].Cells[0].Value.ToString();
            Buscar(id);
            listareservas.SelectedIndex = e.RowIndex;
            this.tabControl1.TabPages[0].Show();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            txtcodreserva.Text = "";
            cmbcedulas.Text = "";
            txtnombre.Text = "";
            cmbhabitacion.Text = "";
            txtprecio.Text = "";
            txttipo.Text = "";
        }

        private void txtbuscar_TextChanged(object sender, EventArgs e)
        {
            string condicion = txtbuscar.Text.Trim();
            CargarGrillaHabitacion(condicion);
        }
    }
}
