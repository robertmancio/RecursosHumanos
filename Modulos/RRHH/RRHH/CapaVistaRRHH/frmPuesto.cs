using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static datosUsuario;
using VistaBitacora;
using BitacoraUsuario;

namespace CapaVista
{
    public partial class frmPuesto : Form
    {
        MDIRRHH MDI = new MDIRRHH();
        private string usuario = "";
        public frmPuesto()
        {
            Bitacora loggear = new Bitacora();

            InitializeComponent();
            CenterToScreen();
            //Parametrización navegador
            /*arreglo de textboxs*/
            TextBox[] alias = navegador1.funAsignandoTexts(this);
            //definicion de textboxs, tabla y BD
            navegador1.funAsignarAliasVista(alias, "puesto", "hotelSanCarlos");
            navegador1.funAsignarSalidadVista(this);

            //definicion del campo de estado / para dar de bajars
            navegador1.campoEstado = "estado";

            //el id de aplicacion para ayudas y reportes, quedara obsoleto en la nueva version
            navegador1.idAplicacion = "5003";//en la nueva se usara el nombre

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
            navegador1.pideGrid(this.dvgConsulta);
            //llena el data grid
            navegador1.llenaTabla();
            //pide la referencia a la form para poder cerrarla
            navegador1.pedirRef(this);
        }

        private void dgvImpuesto_SelectionChanged(object sender, EventArgs e)
        {
            navegador1.funSeleccionarDTVista(dvgConsulta);
        }

        private void rdbActivo_CheckedChanged(object sender, EventArgs e)
        {
            navegador1.funCambioEstatusRBVista(txtEstado, rdbActivo, "A");
        }

        private void rdbInactivo_CheckedChanged(object sender, EventArgs e)
        {
            navegador1.funCambioEstatusRBVista(txtEstado, rdbInactivo, "I");
        }

        private void txtEstado_TextChanged(object sender, EventArgs e)
        {
            navegador1.funSetearRBVista(rdbActivo, rdbInactivo, txtEstado);
        }
        public void funActualizarUsuario(string user)
        {
            usuario = user;
            //y ya con el nombre del usuario podemos actualizar los permisos
            navegador1.usuario = user;
            navegador1.aplicacion = "Mantenimiento Puesto";//nombre de la app en seguridad
            navegador1.funActualizarPermisos();//actualizamos los permisos
            navegador1.idmodulo = "5";//7 es contabilidad
            navegador1.funReportesVista("ruta", "idAplicacion", "Reporte");
        }



    }

    }

