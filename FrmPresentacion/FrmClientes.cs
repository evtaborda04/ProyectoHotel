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
    public partial class FrmClientes : Form
    {
        public FrmClientes()
        {
            InitializeComponent();
        }
        void cargarlistado(string busqueda)
        {
            listadoclientes.DataSource = new repositorioClientes().ConsultarTodos(busqueda);
            listadoclientes.DisplayMember = "Nom";
            listadoclientes.ValueMember = "IDCliente";
            if (listadoclientes.Items.Count > 0)
            {
                listadoclientes.SelectedIndex = 0;
                listadoclientes.Select();
            }
        }
        void CargarGrillaClientes(string busqueda)
        {
            grilladeclientes.DataSource = new repositorioClientes().ConsultarTodos(busqueda);

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        void Buscar(string id)
        {
            try
            {
                var cliente = new repositorioClientes().BuscarID(id);
                ver(cliente);
            }
            catch (Exception)
            {


            }
        }
        void ver(Cliente cliente)
        {
            if (cliente == null)
            {
                return;
            }
            txtcedula.Text = cliente.IDCliente;
            txtnombre.Text = cliente.Nom;
            txtapellido.Text = cliente.apellido;
            cmbgenero.Text = cliente.Genero;

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Agregar();
            refresh();
        }
        void Agregar()
        {
            Cliente cliente = new Cliente();
            ServicioCliente servicio = new ServicioCliente();
            cliente.IDCliente = txtcedula.Text;
            cliente.Nom = txtnombre.Text;
            cliente.apellido = txtapellido.Text;
            cliente.Genero = cmbgenero.Text;
            servicio.Guardar(cliente);
            MessageBox.Show("Guardado correctamente");

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            if (txtcedula.Text.Length == 0)
            {
                return;
            }
            Eliminar(new repositorioClientes().BuscarID(txtcedula.Text));
            refresh();

        }

        void Eliminar(Cliente cliente)
        {

            MessageBox.Show(new repositorioClientes().Eliminar(cliente));

        }


        void Ver(Cliente cliente)
        {
            txtcedula.Text = cliente.IDCliente;
            txtnombre.Text = cliente.Nom;
            txtapellido.Text = cliente.apellido;
            cmbgenero.Text = cliente.Genero;

        }

       

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            txtcedula.Text = "";
            txtnombre.Clear();
            txtapellido.Clear();
            cmbgenero.Text = "";
            txtcedula.Focus();

        }

        private void txtbuscargrilla_TextChanged(object sender, EventArgs e)
        {
            string condicion = txtbuscargrilla.Text.Trim();
            CargarGrillaClientes(condicion);
        }

        private void FrmClientes_Load(object sender, EventArgs e)
        {
            cargarlistado("");
            CargarGrillaClientes("");

        }
        void refresh()
        {
            cargarlistado("");
            CargarGrillaClientes("");
        }

        private void btnactualizar_Click(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente();
            ServicioCliente servicio = new ServicioCliente();
            cliente.IDCliente = txtcedula.Text;
            cliente.Nom = txtnombre.Text;
            cliente.apellido = txtapellido.Text;
            cliente.Genero = cmbgenero.Text;
            Actualizar(cliente);
            MessageBox.Show("Actualizado correctamente");
            refresh();

        }

        void Actualizar(Cliente cliente)
        {
            MessageBox.Show(new ServicioCliente().Actualizar(cliente));

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

   

        private void grilladeclientes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string id = grilladeclientes.Rows[e.RowIndex].Cells[0].Value.ToString();
            Buscar(id);
            listadoclientes.SelectedIndex = e.RowIndex;
            this.tabControl1.TabPages[0].Show();
        }

        private void listadoclientes_SelectedIndexChanged(object sender, EventArgs e)
        {

            string id = listadoclientes.SelectedValue.ToString();
            Buscar(id);
        }
    }

}
