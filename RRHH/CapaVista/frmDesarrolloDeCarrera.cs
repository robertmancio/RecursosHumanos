using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System;
using System.Data;
using System.Data.Odbc;
using System.Windows.Forms;

namespace CapaVista
{
    public partial class frmDesarrolloDeCarrera : Form
    {
        public frmDesarrolloDeCarrera()
        {
            InitializeComponent();
            LlenarDgv();
            CenterToScreen();
        }
        DataTable Dt = new DataTable();
        public void LlenarDgv()
        {
           

        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

    }
}