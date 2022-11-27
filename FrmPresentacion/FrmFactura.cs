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
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("GUARDADO");
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Finalizado");
        }
        //public FrmFactura()
        //{
        //    InitializeComponent();
        //}

        //private void btnGuardar_Click(object sender, EventArgs e)
        //{
        //    guardar();
        //}

        //void guardar()
        //{
        //    Cliente clientes;
        //    string codreserva;
        //    string codigofactura;
        //    DateTime fechaingreso;
        //    DateTime fechasalida;
        //    string tipohabitacion;
        //    double precio;
        //    string id;


        //    Facturacion facturas = new Facturacion();
        //    ServicioFactura servico = new ServicioFactura();
        //    id = txtidcliente.Text;
        //    clientes = new ServicioCliente().BuscarID(id);
        //    if (clientes == null)
        //    {
        //        MessageBox.Show("Cliente No existe, Por favor registrarse previamente");
        //        return;
        //    }
        //    else
        //    {
        //        codigofactura = txtcodigofactura.Text;
        //        codreserva = txtcodigoreserva.Text;
        //        tipohabitacion = cmbtipohabitacion.Text;
        //        precio = Convert.ToDouble(txtprecio.Text);   
        //        fechaingreso = dateingreso.Value;
        //        fechasalida = datesalida.Value;
        //        double valor =Convert.ToDouble( txtprecio.Text);


        //        Facturacion facturasfinal = new Facturacion(codigofactura,codreserva , clientes, tipohabitacion, precio,fechaingreso,fechasalida);
        //        servico.Guardar(facturasfinal);
        //        MessageBox.Show("Factura guardada correctamente");
        //    }


        //}

    }
}
