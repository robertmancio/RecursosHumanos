using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//0901-18-1982 Roberto López 
namespace CapaVista
{
    public partial class frmAgregarEmpleado : Form
    {
        private string usuario = "";
        public frmAgregarEmpleado()
        {
            InitializeComponent();
            CenterToScreen();
            TextBox[] alias = navegador1.funAsignandoTexts(this);
            //definicion de textboxs, tabla y BD
            navegador1.funAsignarAliasVista(alias, "empleado", "hotelSanCarlos");
            navegador1.funAsignarSalidadVista(this);

            //definicion del campo de estado / para dar de bajars
            navegador1.campoEstado = "estado";

            //el id de aplicacion para ayudas y reportes, quedara obsoleto en la nueva version
            navegador1.idAplicacion = "5002";//en la nueva se usara el nombre

            //-- Estos atributos no cambian
            //inicio de elementos para ejecutar la ayuda
            navegador1.tablaAyuda = "Aplicacion";
            navegador1.campoAyuda = "pkId";
            //fin de elementos para ejecutar la ayuda

            // Inicio datos para ejecurar reportes
            navegador1.funReportesVista("ruta", "idAplicacion", "Reporte");
            // Final datos para ejecutar reportes
            //-- fin de atributos no cambiantes

            //enviar el data grid view para la navegación
            navegador1.pideGrid(this.dgvEmpleado);
            //llena el data grid
            navegador1.llenaTabla();
            //pide la referencia a la form para poder cerrarla
            navegador1.pedirRef(this);
            //FALTA USUARIO Y ACTUALIZAR PERSMISOS

            //Para las combo boxes
            //Parametros: La combo box, la tabla, el id de la tabla, el valor a mostrar, y el campo de estado
            navegador1.funLlenarComboControl(cmbEmpresa, "empresa", "idEmpresa", "nombre", "estatus");
            navegador1.funLlenarComboControl(cmbPuesto, "puesto", "pkIdPuesto", "nombre", "estado");

        }
        //Actualización de permisos que se debe realizar después de tener la variable usuario ingresada
        public void funActualizarUsuario(string user)
        {
            //colocamos el nombre del usuario
            usuario = user;
            //y ya con el nombre del usuario podemos actualizar los permisos
            navegador1.usuario = user;
            navegador1.aplicacion = "Mantenimiento Empleado";//nombre de la app en seguridad
            navegador1.funActualizarPermisos();//actualizamos los permisos
            navegador1.idmodulo = "5";//7 es contabilidad
            navegador1.funReportesVista("ruta", "idAplicacion", "Reporte");

        }

        private void dvgCuentas_SelectionChanged(object sender, EventArgs e)
        {
            navegador1.funSeleccionarDTVista(dgvEmpleado);
        }

        private void rdbActivo_CheckedChanged(object sender, EventArgs e)
        {
            navegador1.funCambioEstatusRBVista(txtEstado, rdbActivo, "A");
        }

        private void rdbInactivo_CheckedChanged(object sender, EventArgs e)
        {
            navegador1.funCambioEstatusRBVista(txtEstado, rdbInactivo, "I");
        }

        private void cmbEmpresa_SelectedIndexChanged(object sender, EventArgs e)
        {
            navegador1.funComboTextboxVista(cmbEmpresa,txtEmpresa);
        }

        private void cmbPuesto_SelectedIndexChanged(object sender, EventArgs e)
        {
            navegador1.funComboTextboxVista(cmbPuesto, txtPuesto);
        }

        private void txtEstado_TextChanged(object sender, EventArgs e)
        {
            navegador1.funSetearRBVista(rdbActivo, rdbInactivo, txtEstado);
        }

        private void txtEmpresa_TextChanged(object sender, EventArgs e)
        {
            navegador1.funTextboxComboVista(cmbEmpresa, txtEmpresa);
        }

        private void txtPuesto_TextChanged(object sender, EventArgs e)
        {
            navegador1.funTextboxComboVista(cmbPuesto, txtPuesto);
        }
        private void btnGuardarNacimiento_Click(object sender, EventArgs e)
        {
            String dt = "";
            dt = dtFechaNacimiento.Value.ToString("yyyy-MM-dd");//lo pasa al formato necesitado por mysql
            txtNacimiento.Text = dt;
            // MessageBox.Show(txtFecha.Text);
        }
        private void dtFechaNacimiento_ValueChanged(object sender, EventArgs e)
        {
            navegador1.funDPTextBoxVista(dtFechaNacimiento, txtNacimiento);
        }

        private void txtFechaNacimiento_TextChanged(object sender, EventArgs e)
        {
            navegador1.funTextBoxDPTVista(dtFechaNacimiento, txtNacimiento);
            navegador1.funDPTextBoxVista(dtFechaNacimiento, txtNacimiento);
        }
        private void btnGuardarContratacion_Click(object sender, EventArgs e)
        {
            String dt = "";
            dt = dtContratacion.Value.ToString("yyyy-MM-dd");//lo pasa al formato necesitado por mysql
            txtContratacion.Text = dt;
            // MessageBox.Show(txtFecha.Text);
        }
        private void dtContratracion_ValueChanged(object sender, EventArgs e)
        {
            navegador1.funDPTextBoxVista(dtContratacion, txtContratacion);
        }

        private void txtContratacion_TextChanged(object sender, EventArgs e)
        {
            navegador1.funTextBoxDPTVista(dtContratacion, txtContratacion);
            navegador1.funDPTextBoxVista(dtContratacion, txtContratacion);
        }
        private void btnGuardarFinContrato_Click(object sender, EventArgs e)
        {
            String dt = "";
            dt = dtFinContrato.Value.ToString("yyyy-MM-dd");//lo pasa al formato necesitado por mysql
            txtFinContrato.Text = dt;
            // MessageBox.Show(txtFecha.Text);
        }
        private void dtFinContrato_ValueChanged(object sender, EventArgs e)
        {
            navegador1.funDPTextBoxVista(dtFinContrato, txtFinContrato);
        }

        private void txtFinContrato_TextChanged(object sender, EventArgs e)
        {
            navegador1.funTextBoxDPTVista(dtFinContrato, txtFinContrato);
            navegador1.funDPTextBoxVista(dtFinContrato, txtFinContrato);
        }

        private void dgvEmpleado_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
