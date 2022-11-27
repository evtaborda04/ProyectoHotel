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
    public partial class PaginaPrincipal : Form
    {
        public PaginaPrincipal()
        {
            InitializeComponent();
        }

  
      

     

        private void habitacionesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmHabitacion habi = new FrmHabitacion();
            habi.Show();
        }

        private void agendarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmFacturaciones agend = new FrmFacturaciones();
            agend.Show();
        }

        private void facturaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmFactura factura = new FrmFactura();
            factura.Show();
        }

        private void agendaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmClientes clien = new FrmClientes();
            clien.Show();
        }

        private void listarFacturasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmconsultaFactura facturas = new FrmconsultaFactura();
            facturas.Show();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
