﻿using Datos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prueba
{
    public partial class prubaconexion : Form
    {
        public prubaconexion()
        {
            InitializeComponent();
        }

       





        private void button1_Click(object sender, EventArgs e)
        {
          Conexion conexion = new Conexion();
            conexion.Abrirconexion();

        }
    }
}
