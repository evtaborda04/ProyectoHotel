using Datos;
using Entidad;
using System;
using System.Collections;
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
    public partial class FrmconsultaFactura : Form
    {
        //List<Factura> lista = new Logica.ServicioFacturaciones().Consultar();
        public FrmconsultaFactura()
        {
            InitializeComponent();
            
        }

        void cargarfacturas(string condicion)
        {
            grillaconsulta.DataSource = new repositorioFactura().ConsultarTodos(condicion);

        }

        private void buscarfactura_TextChanged(object sender, EventArgs e)
        {
            string condicion = txtbuscarfactura.Text.Trim();
            cargarfacturas(condicion);
        }

        private void FrmconsultaFactura_Load(object sender, EventArgs e)
        {
            cargarfacturas("");
        }
    }
}
