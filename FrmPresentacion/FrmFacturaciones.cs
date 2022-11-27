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
    public partial class FrmFacturaciones : Form
    {
        public FrmFacturaciones()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            guardar();
        }
        void guardar()
        {
            Cliente clientes;
            Habitacion habitacion;
            string codigofactura;
            DateTime fechaingreso;
            DateTime fechasalida;
            string tipohabitacion;
            double precio;
            string id;
            string idhabitacion;
            Factura reservas = new Factura();
            ServicioFacturaciones servico = new ServicioFacturaciones();
            id = txtidcliente.Text;
            idhabitacion = txtidhabitacion.Text;
            //clientes = new ServicioCliente().BuscarID(id);
            habitacion = new ServicioHabitacion().BuscarHabitacion(idhabitacion);



            //if (clientes == null)
            //{
            //    MessageBox.Show("Cliente No existe, Por favor registrarse previamente");
            //    return;
            //}
            //else if (habitacion == null)
            //{
            //    MessageBox.Show("Habitacion No existe, por favor verifique");
            //}
            //else
            //{
            //    codigofactura = txtcodigoreserva.Text;
            //    fechaingreso = dateingreso.Value;
            //    fechasalida = datesalida.Value;
            //    tipohabitacion = cmbtipohabitacion.Text;
            //    precio = Convert.ToDouble(txtprecio.Text);
            //    Factura reservados = new Factura(codigofactura, habitacion, fechaingreso, fechasalida, clientes, tipohabitacion, precio);
            //    servico.Guardar(reservados);
            //    MessageBox.Show("Factura guardada correctamente");
            //}
            }
            

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Buscar(txtcodigoreserva.Text);
        }

        void Buscar(string reservados)
        {

            ServicioFacturaciones reserva = new ServicioFacturaciones();
            Factura reservar;


            reservar = reserva.BuscarReserva( reservados);
            if (reservar == null)
            {
                MessageBox.Show("La factura no existe");
                return;

            }
            else
            {
                Ver(reservar);
            }



        }
        Cliente cliente;
        void Ver(Factura reserva)
        {
            Cliente clientes;
            string id;
            id = txtidcliente.Text;
            //clientes = new ServicioCliente().BuscarID(id);

            txtcodigoreserva.Text =reserva.codigofactura;
            dateingreso.Value = reserva.fechaingreso;
            datesalida.Value = reserva.fechasalida;
            txtidcliente.Text = reserva.cliente.Nom;
            cmbtipohabitacion.Text = reserva.tipohab;
            txtprecio.Text = Convert.ToString( reserva.precio);

        }

        private void btnactualizar_Click(object sender, EventArgs e)
        {
            //ServicioReserva servico = new ServicioReserva();
            //Entidad.Reserva reserva;
            //string idreserva;



            //idreserva = txtcodigoreserva.Text;

            //reserva = servico.BuscarReserva(idreserva);
            //if (reserva == null)
            //{
            //    MessageBox.Show("reserva no existe");
            //    return;

            //}
            //else
            //{
            //    reserva.codigoreserva = txtcodigoreserva.Text;
            //    reserva.fechaingreso = dateingreso.Value;
            //    reserva.fechasalida = datesalida.Value;
            //    reserva.cliente.IDCliente = txtidcliente.Text;
            //    reserva.tipohab = cmbtipohabitacion.Text;
            //    reserva.precio =Convert.ToDouble( txtprecio.Text);
            //    servico.Modificar(txtcodigoreserva.Text, new Reserva(txtcodigoreserva.Text, dateingreso.Value,datesalida.Value, txtidcliente.Text,cmbtipohabitacion.Text,Convert.ToDouble( txtprecio.Text)));
            //    MessageBox.Show("Cliente actualizado correctamente");
            //}

           
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            txtcodigoreserva.Clear();
            dateingreso.Value = DateTime.Today;
            datesalida.Value = DateTime.Today;
            txtidcliente.Clear();
            cmbtipohabitacion.Text = "";
            txtprecio.Clear();
        }
    }
}
