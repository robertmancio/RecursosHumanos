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
{
    public partial class frmNomina : Form
    {
        private controladorNominasCierre cn = new controladorNominasCierre();
        private Bitacora bitacora = new Bitacora();

        public frmNomina()
        {
            InitializeComponent();
            ActualizarEmpleadosNominas("2021");
            LlenarMeses();
            LlenarAños();
        }

        // JORGE GONZÁLEZ 0901 18 3920
        public void ActualizarEmpleadosNominas(string año)
        {
            DataTable dt = cn.LlenarEmpleadosParaNominas(año);
            dgvNominaEmpleados.DataSource = dt;
        }

        // JORGE GONZÁLEZ 0901 18 3920
        public void LlenarMeses()
        {
            string[] names = DateTimeFormatInfo.CurrentInfo.MonthNames;

            for (int i = 0; i < names.Length - 1; i++)
            {
                cboMesCalcular.Items.Insert(i, names[i].ToUpper());
            }
        }

        // JORGE GONZÁLEZ 0901 18 3920
        public void LlenarAños()
        {
            int i = 0;
            for (int año = 2020; año < 2023; año++)
            {
                cboAnio.Items.Insert(i, año);
                i++;
            }
        }

        // JORGE GONZÁLEZ 0901 18 3920
        private void dgvNominaEmpleados_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            obtenerEmpleado();
            calculosNomina();
        }

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

        // JORGE GONZÁLEZ 0901 18 3920
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
        }// JORGE GONZÁLEZ 0901 18 3920

        public void obtenerEmpleado()
        {
            txtCodigoEmpleadoNomina.Text = dgvNominaEmpleados.SelectedRows[0].Cells[0].Value.ToString();
            txtEmpleadoNomina.Text = dgvNominaEmpleados.SelectedRows[0].Cells[1].Value.ToString();
            txtSueldoNomina.Text = dgvNominaEmpleados.SelectedRows[0].Cells[2].Value.ToString();
            txtAnio.Text = dgvNominaEmpleados.SelectedRows[0].Cells[3].Value.ToString();
        }

        private const double porcentajeHoraLaboral = 1.5;
        private const int diasLaboralesMensuales = 21;
        private const int horasLaboralesDiarias = 8;

        // JORGE GONZÁLEZ 0901 18 3920
        public void calculosNomina(double horasExtraordinarias = 0)
        {
            int diasLaborados = stringAInt(txtDiasLaborados.Text);
            double salarioOrdinario = Math.Round(stringADouble(dgvNominaEmpleados.SelectedRows[0].Cells[2].Value.ToString()), 2);
            horasExtraordinarias = Math.Round(stringADouble(txtHorasExtraordinarias.Text), 2);
            double salarioExtraOrdinario = Math.Round(horasExtraordinarias * (((salarioOrdinario / diasLaboralesMensuales) / horasLaboralesDiarias)) * porcentajeHoraLaboral, 2);
            double igss = Math.Round(salarioOrdinario * 0.0483);
            double isr;
            if (salarioOrdinario >= 15000)
            {
                isr = Math.Round(salarioOrdinario * 0.07);
            }
            else
            {
                isr = Math.Round(salarioOrdinario * 0.05);
            }
            int horasOrdinarias = diasLaborados * 8;
            double salarioTotal = salarioOrdinario + salarioExtraOrdinario;
            double deduccionTotal = isr + igss;
            double salarioLiquido = salarioTotal - deduccionTotal;

            txtHorasOrdinarias.Text = horasOrdinarias.ToString();
            txtSalarioOrdinario.Text = salarioOrdinario.ToString();
            txtSalarioExtraordinario.Text = salarioExtraOrdinario.ToString();
            txtSalarioTotal.Text = salarioTotal.ToString();
            txtISR.Text = isr.ToString();
            txtIGSS.Text = igss.ToString();
            txtDeduccionTotal.Text = deduccionTotal.ToString();
            txtSalarioLiquido.Text = salarioLiquido.ToString();
        }

        // JORGE GONZÁLEZ 0901 18 3920
        private void btnCalcularNomina_Click(object sender, EventArgs e)
        {
            if (txtCodigoEmpleadoNomina.Text == "")
            {
                txtValidaciones.Text = "Seleccione un empleado";
            }
            else if (cboMesCalcular.SelectedIndex == -1)
            {
                txtValidaciones.Text = "Debe de seleccionar un mes";
            }
            else if (txtHorasExtraordinarias.Text == "")
            {
                txtValidaciones.Text = "Ingrese las horas extraordinarias";
            }
            else
            {
                txtValidaciones.Text = "";
                guardarNomina(dgvNominaEmpleados.SelectedRows[0], stringAInt(txtHorasExtraordinarias.Text));
            }
        }

        private int mesElegido;
        private string mesElegidotxt;
        private int[] mes = { 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 };

        private string[] mestxt = { "ENERO", "FEBRERO", "MARZO", "ABRIL", "MAYO", "JUNIO", "JULIO", "AGOSTO", "SEPTIEMBRE", "OCTUBRE", "NOVIEMBRE", "DICIEMBRE" };

        private void cboMesCalcular_SelectedIndexChanged(object sender, EventArgs e)

        {
            switch (cboMesCalcular.Text)
            {
                case "ENERO":
                    txtDiasLaborados.Text = dgvNominaEmpleados.SelectedRows[0].Cells[4].Value.ToString();
                    mesElegido = 4;
                    mesElegidotxt = "ENERO";
                    break;

                case "FEBRERO":
                    txtDiasLaborados.Text = dgvNominaEmpleados.SelectedRows[0].Cells[5].Value.ToString();
                    mesElegido = 5;
                    mesElegidotxt = "FEBRERO";
                    break;

                case "MARZO":
                    txtDiasLaborados.Text = dgvNominaEmpleados.SelectedRows[0].Cells[6].Value.ToString();
                    mesElegido = 6;
                    mesElegidotxt = "MARZO";
                    break;

                case "ABRIL":
                    txtDiasLaborados.Text = dgvNominaEmpleados.SelectedRows[0].Cells[7].Value.ToString();
                    mesElegido = 7;
                    mesElegidotxt = "ABRIL";
                    break;

                case "MAYO":
                    txtDiasLaborados.Text = dgvNominaEmpleados.SelectedRows[0].Cells[8].Value.ToString();
                    mesElegido = 8;
                    mesElegidotxt = "MAYO";
                    break;

                case "JUNIO":
                    txtDiasLaborados.Text = dgvNominaEmpleados.SelectedRows[0].Cells[9].Value.ToString();
                    mesElegido = 9;
                    mesElegidotxt = "JUNIO";
                    break;

                case "JULIO":
                    txtDiasLaborados.Text = dgvNominaEmpleados.SelectedRows[0].Cells[10].Value.ToString();
                    mesElegido = 10;
                    mesElegidotxt = "JULIO";
                    break;

                case "AGOSTO":
                    txtDiasLaborados.Text = dgvNominaEmpleados.SelectedRows[0].Cells[11].Value.ToString();
                    mesElegido = 11;
                    mesElegidotxt = "AGOSTO";
                    break;

                case "SEPTIEMBRE":
                    txtDiasLaborados.Text = dgvNominaEmpleados.SelectedRows[0].Cells[12].Value.ToString();
                    mesElegido = 12;
                    mesElegidotxt = "SEPTIEMBRE";
                    break;

                case "OCTUBRE":
                    txtDiasLaborados.Text = dgvNominaEmpleados.SelectedRows[0].Cells[13].Value.ToString();
                    mesElegido = 13;
                    mesElegidotxt = "OCTUBRE";
                    break;

                case "NOVIEMBRE":
                    txtDiasLaborados.Text = dgvNominaEmpleados.SelectedRows[0].Cells[14].Value.ToString();
                    mesElegido = 14;
                    mesElegidotxt = "NOVIEMBRE";
                    break;

                case "DICIEMBRE":
                    txtDiasLaborados.Text = dgvNominaEmpleados.SelectedRows[0].Cells[15].Value.ToString();
                    mesElegido = 15;
                    mesElegidotxt = "DICIEMBRE";
                    break;

                default:
                    break;
            }

            calculosNomina();
        }

        private void txtHorasExtraordinarias_TextChanged(object sender, EventArgs e)
        {
            calculosNomina();
        }

        private void txtHorasExtraordinarias_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnGuardarMes_Click(object sender, EventArgs e)
        {
            bitacora.guardarEnBitacora(IdUsuario, "5", "5200", "Guardar Nómina Mensual");
            if (cboMesCalcular.SelectedIndex == -1)
            {
                txtValidaciones.Text = "Debe de seleccionar un mes";
            }
            else
            {
                foreach (DataGridViewRow fila in dgvNominaEmpleados.Rows)
                {
                    txtValidaciones.Text = "";
                    guardarNomina(fila);
                }
            }
        }

        private void guardarNomina(DataGridViewRow fila, int horasExtraordinarias = 0)
        {
            bitacora.guardarEnBitacora(IdUsuario, "5", "5200", "Guardar Nómina");
            if (fila.Cells[0].Value != null)
            {
                string fkIdEmpleado = fila.Cells[0].Value.ToString();
                string año = fila.Cells[3].Value.ToString();
                int diasLaborados = stringAInt(fila.Cells[mesElegido].Value.ToString());
                double salarioOrdinario = Math.Round(stringADouble(fila.Cells[2].Value.ToString()), 2);
                double salarioExtraOrdinario = Math.Round(horasExtraordinarias * (((salarioOrdinario / diasLaboralesMensuales) / horasLaboralesDiarias)) * porcentajeHoraLaboral, 2);
                double igss = Math.Round(salarioOrdinario * 0.0483);
                double isr;
                if (salarioOrdinario >= 15000)
                {
                    isr = Math.Round(salarioOrdinario * 0.07);
                }
                else
                {
                    isr = Math.Round(salarioOrdinario * 0.05);
                }
                int horasOrdinarias = diasLaborados * 8;
                double salarioTotal = salarioOrdinario + salarioExtraOrdinario;
                double deduccionTotal = isr + igss;
                double salarioLiquido = salarioTotal - deduccionTotal;
                cn.InsertarNomina(fkIdEmpleado, año, mesElegidotxt, diasLaborados.ToString(), horasOrdinarias.ToString(), horasExtraordinarias.ToString(), salarioTotal.ToString(), igss.ToString(), isr.ToString(), deduccionTotal.ToString(), salarioLiquido.ToString());
            }
        }

        private void cboAnio_SelectedIndexChanged(object sender, EventArgs e)
        {
            ActualizarEmpleadosNominas(cboAnio.Text);
        }
    }
}