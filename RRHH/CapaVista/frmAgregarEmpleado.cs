using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace CapaVista
{
    public partial class frmAgregarEmpleado : Form
    {
        public frmAgregarEmpleado()
        {
            InitializeComponent();
            CenterToScreen();
        }

        private void btnPrueba_Click(object sender, EventArgs e)
        {
        
            
        }

        public void funLimpiar()
        {
            
        }

        private void btnHabilitado_CheckedChanged(object sender, EventArgs e)
        {
            textBox3.Text = "1";
        }

        private void btnInhabilitado_CheckedChanged(object sender, EventArgs e)
        {
            textBox3.Text = "0";
        }

        private void labelIdaplicacion_Click(object sender, EventArgs e)
        {

        }

        private void frmMantenimientoPerfil_Load(object sender, EventArgs e)
        {

        }
    }
}
