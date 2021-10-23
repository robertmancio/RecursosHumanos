
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Odbc;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaVista
{
    public partial class frmDiasTrabajados : Form
    {
        public frmDiasTrabajados()
        {
            InitializeComponent();
            LlenarDgv();
            CenterToScreen();
        }
        DataTable Dt = new DataTable();
        public void LlenarDgv()
        {
           

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            
        }

        private void dgvAplicaciones_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
