using BitacoraUsuario;
using CapaControlador;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static datosUsuario;

// MELANIE REVOLORIO - 0901 18 5007
namespace CapaVista
{
    public partial class frmVerCierresDeNomina : Form
    {// MELANIE REVOLORIO - 0901 18 5007
        private Bitacora bitacora = new Bitacora();
        private controladorNominasCierre cn = new controladorNominasCierre();

        public frmVerCierresDeNomina()
        {
            InitializeComponent();

            LlenarAños();
        }

        // MELANIE REVOLORIO - 0901 18 5007
        public void LlenarAños()
        {
            int i = 0;
            for (int año = 2020; año < 2023; año++)
            {
                cboAños.Items.Insert(i, año);
                i++;
            }
        }

        // MELANIE REVOLORIO - 0901 18 5007
        private void cboAños_SelectedIndexChanged(object sender, EventArgs e)
        {
            ActualizarEmpleadosNominas(stringAInt(cboAños.Text));
        }

        public void ActualizarEmpleadosNominas(int año)
        {
            bitacora.guardarEnBitacora(IdUsuario, "5", "5300", "Actualizar Empleados para Cierre de Nómina");
            DataTable dt = cn.LlenarCierreDeNominas(año);
            dgvCierreDeNomina.DataSource = dt;
        }

        // MELANIE REVOLORIO - 0901 18 5007
        public int stringAInt(string str)
        {
            int num;
            bool seConvirtioAInt = int.TryParse(str, out num);
            if (seConvirtioAInt)
            {
                return num;
            }
            else
            {
                return 0;
            }
        }
    }
}