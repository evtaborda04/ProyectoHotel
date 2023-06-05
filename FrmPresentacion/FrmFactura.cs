using Datos;
using Entidad;
using Logica;
using System;
using System.CodeDom;
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
    public partial class FrmFactura : Form
    {
        ServicioCliente serviciocliente;
        ServicioHabitacion servicioHabitacion;
        servicioReserva servicioreserva;
        ServicioFactura serviciofactura;
        public FrmFactura()
        {
            InitializeComponent();
            serviciocliente = new ServicioCliente();
            servicioHabitacion = new ServicioHabitacion();
            servicioreserva = new servicioReserva();
            serviciofactura = new ServicioFactura();
        }
        repositorioFactura Rf = new repositorioFactura();
        void cargarreserva()
        {
            cmbcodreserva.DataSource = Rf.cargarfacturas();
            cmbcodreserva.DisplayMember = "idreserva";
        }

        void ver_reserva(Reserva res)
        {
            if (res == null)
            {
                return;
            }
            txtidcliente.Text = res.IDCliente;
            txtnombre.Text = res.Nom;
            txtcodhabitacion.Text = res.codhabitacion;
            txttipohabitacion.Text = res.tipohabitacion;
            txtprecio.Text =Convert.ToString( res.precio);
        }
        private Factura guardadofactura()
        {
            double valor =Convert.ToDouble( txtprecio.Text);
            int dias = (int)numericdias.Value;
            double total = valor * dias;


            Factura factura = new Factura

            {
                fechaingreso = dateingreso.Value,
                fechasalida = datesalida.Value,
                codreserva = cmbcodreserva.Text,
                IDCliente = txtidcliente.Text,
                Nom = txtnombre.Text,
                codhabitacion = txtcodhabitacion.Text,
                tipohabitacion = txttipohabitacion.Text,
                precio = Convert.ToDouble(txtprecio.Text),
                cantidad_dias = ((int)numericdias.Value),
                Total = total
            };
            txttotal.Text = factura.Total.ToString();
            return factura;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string guardado = serviciofactura.Guardar(guardadofactura());
            MessageBox.Show(guardado);
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void FrmFactura_Load(object sender, EventArgs e)
        {
            cargarreserva();
        }

        private void btnbuscare_Click(object sender, EventArgs e)
        {
            var respuesta = servicioreserva.Buscarconid(cmbcodreserva.Text);
            ver_reserva(respuesta.Reserva);
        }
    }
}
