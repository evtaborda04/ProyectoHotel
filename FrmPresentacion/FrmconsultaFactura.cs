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
        List<Factura> lista = new Logica.ServicioFacturaciones().Consultar();
        public FrmconsultaFactura()
        {
            InitializeComponent();
            
        }





        void BuscarDatos()
        {
            grillaconsulta.DataSource = new Logica.ServicioFacturaciones().Consultar();
        }
        void BuscarDatosFiltro(String Filtro)
        {
            grillaconsulta.Rows.Clear();
            foreach (var item in lista)
            {
                if (item.codigofactura.ToUpper().StartsWith(Filtro.ToUpper()))
                {
                    grillaconsulta.Rows.Add(item.codigofactura,item.habitacion.IdHabitacion, item.fechaingreso, item.fechasalida, item.cliente.Nom,item.tipohab,item.precio);
                }
            }
        }

        private void ConsultaFactura_Load(object sender, EventArgs e)
        {
            BuscarDatosFiltro("");
        }

        private void buscarfactura_TextChanged(object sender, EventArgs e)
        {
            BuscarDatosFiltro(buscarfactura.Text);
        }
    }
}
