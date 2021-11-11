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

namespace CapaVista
{// JORGE GONZÁLEZ 0901 18 3920
    public partial class frmVerNominas : Form
    {
        private controladorNominasCierre cn = new controladorNominasCierre();
        private Bitacora bitacora = new Bitacora();

        public frmVerNominas()
        {
            InitializeComponent();
            LlenarAños();
            CenterToScreen();
            LlenarMeses();
        }

        // JORGE GONZÁLEZ 0901 18 3920
        public void ActualizarEmpleadosNominas(int año, string mes)
        {
            DataTable dt = cn.LlenarNominas(año, mes);
            dgvNominas.DataSource = dt;
        }

        // JORGE GONZÁLEZ 0901 18 3920
        public void LlenarMeses()
        {
            string[] names = DateTimeFormatInfo.CurrentInfo.MonthNames;

            for (int i = 0; i < names.Length - 1; i++)
            {
                cboMeses.Items.Insert(i, names[i].ToUpper());
            }
        }

        // JORGE GONZÁLEZ 0901 18 3920
        public void LlenarAños()
        {
            int i = 0;
            for (int año = 2020; año < 2023; año++)
            {
                cboAnios.Items.Insert(i, año);
                i++;
            }
        }

        // JORGE GONZÁLEZ 0901 18 3920
        private void cboAnios_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboMeses.Text != "")
            {
                ActualizarEmpleadosNominas(stringAInt(cboAnios.Text), cboMeses.Text);
            }
        }

        // MELANIE REVOLORIO - 0901 18 5007
        private void cboMeses_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboAnios.Text != "")
            {
                ActualizarEmpleadosNominas(stringAInt(cboAnios.Text), cboMeses.Text);
            }
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

        // MELANIE REVOLORIO - 0901 18 5007
        private void btnCierreDeNominas_Click(object sender, EventArgs e)
        {
            double salarioLiquido = 0;
            if (cboMeses.SelectedIndex == -1)
            {
                txtValidaciones.Text = "Debe de seleccionar un mes";
            }
            else if (cboAnios.SelectedIndex == -1)
            {
                txtValidaciones.Text = "Debe de seleccionar un año";
            }
            else
            {
                bitacora.guardarEnBitacora(IdUsuario, "5", "5300", "Cerrar Nóminas");
                txtValidaciones.Text = "";
                foreach (DataGridViewRow fila in dgvNominas.Rows)
                {
                    if (fila.Cells[0].Value != null)
                    {
                        salarioLiquido += stringADouble(fila.Cells[9].Value.ToString());
                    }
                }
                txtTotalAPagar.Text = salarioLiquido.ToString();
                cn.InsertarCierreDeNomina(cboAnios.Text, cboMeses.Text, salarioLiquido.ToString());
            }
        }

        public double stringADouble(string str)
        {
            double num;
            bool seConvirtioAInt = double.TryParse(str, out num);
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