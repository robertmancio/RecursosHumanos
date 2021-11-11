using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaModelo
{
    public class SentenciasNominas
    {
        private Conexion cn = new Conexion();
        private OdbcCommand Comm;

        public int funIniciarSesion(string Usuario, string Contraseña, int validar)
        {
            try
            {
                string con = "";

                string Query = "select * from `componenteseguridad`.`Usuario` where nombre='" + Usuario + "';";

                OdbcCommand consulta = new OdbcCommand(Query, cn.conexion());
                consulta.ExecuteNonQuery();

                OdbcDataReader busqueda;
                busqueda = consulta.ExecuteReader();

                if (busqueda.Read())
                {
                    con = busqueda["contraseña"].ToString();
                }

                validar = Contraseña.CompareTo(con);
            }
            catch
            {
            }

            return validar;
        }

        public void funInsertar(string Id, string Nombre, int estado, string ruta)
        {
            string cadena = "INSERT INTO" +
            " `componenteseguridad`.`Aplicacion` VALUES (" + "'" + Id + "', '" + Nombre + "' , " + estado + ", '" + ruta + "');";

            OdbcCommand consulta = new OdbcCommand(cadena, cn.conexion());
            consulta.ExecuteNonQuery();
        }

        public void funModificar(string Id, string Nombre, int estado, string ruta)
        {
            string cadena = "UPDATE componenteseguridad.aplicacion set pkId ='" + Id
              + "',nombre ='" + Nombre + "',estado = " + estado + ", idReporteAsociado = '" + ruta + "'  where pkId= '" + Id + "';";

            OdbcCommand consulta = new OdbcCommand(cadena, cn.conexion());
            consulta.ExecuteNonQuery();
        }

        public OdbcDataAdapter funObtenerEmpleadosNominas(string año)
        {
            var con = cn.conexion();
            string sql = "SELECT * FROM empleadoNomina WHERE anio = " + año + ";";
            OdbcDataAdapter dataTable = new OdbcDataAdapter(sql, cn.conexion());
            cn.desconexion(con);
            return dataTable;
        }

        public OdbcDataAdapter funVerCierresDeNomina(int año = 2020)
        {
            var con = cn.conexion();
            string sql = "SELECT año AS anio, mes AS Mes, TotalAPagar FROM cierreDeNominas WHERE año = " + año + ";";
            OdbcDataAdapter dataTable = new OdbcDataAdapter(sql, cn.conexion());
            cn.desconexion(con);
            return dataTable;
        }

        public OdbcDataAdapter funVerNominas(int año = 2020, string mes = "ENERO")
        {
            var con = cn.conexion();
            string sql = "SELECT CONCAT(B.pkIdEmpleado,' - ',B.nombre, ' ', B.apellido) AS empleado, CONCAT(A.mes,'/', A.año) AS fecha, A.diasLaborados, A.horasOrdinarias, A.horasExtraordinarias, A.salarioTotal, A.igss, A.isr, A.totalDeducciones, A.salarioLiquido FROM nominas AS A INNER JOIN empleado AS B ON A.fkIdEmpleado = B.pkIdEmpleado WHERE A.año = " + año + " AND A.mes = '" + mes + "';";
            OdbcDataAdapter dataTable = new OdbcDataAdapter(sql, cn.conexion());
            cn.desconexion(con);
            return dataTable;
        }

        public void funLlenarNominaMensual(string fkIdEmpleado, string año, string mes, string diasLaborados, string horasOrdinarias, string horasExtraordinarias, string salarioTotal, string igss, string isr, string totalDeducciones, string salarioLiquido)
        {
            var con = cn.conexion();
            string exists = "select * from nominas where fkIdEmpleado='" + fkIdEmpleado + "' AND año = " + año + " AND mes = '" + mes + "';";

            OdbcCommand checkIfExists = new OdbcCommand(exists, con);
            checkIfExists.ExecuteNonQuery();

            OdbcDataReader check;
            check = checkIfExists.ExecuteReader();

            if (!check.HasRows)
            {
                string pkIdNominas = Guid.NewGuid().ToString("N").Substring(0, 10);
                string cadena = "INSERT INTO nominas(pkIdNominas, fkIdEmpleado, año, mes, diasLaborados, horasOrdinarias" +
                    ", horasExtraordinarias, salarioTotal, igss, isr, totalDeducciones, salarioLiquido)" +
                    " VALUES ('" + pkIdNominas + "','" + fkIdEmpleado + "'," + año + ",'" + mes + "'," + diasLaborados + "," + horasOrdinarias + "," + horasExtraordinarias + "," + salarioTotal + "," + igss + "," + isr + "," + totalDeducciones + "," + salarioLiquido + ")";

                OdbcCommand consulta = new OdbcCommand(cadena, cn.conexion());
                consulta.ExecuteNonQuery();
            }
            cn.desconexion(con);
        }

        public void funLlenarCierreDeNominas(string año, string mes, string totalAPagar)
        {
            var con = cn.conexion();
            string exists = "select * from cierreDeNominas where año = " + año + " AND mes='" + mes + "';";

            OdbcCommand checkIfExists = new OdbcCommand(exists, con);
            checkIfExists.ExecuteNonQuery();

            OdbcDataReader check;
            check = checkIfExists.ExecuteReader();

            if (!check.HasRows)
            {
                string pkIdCierreDeNominas = Guid.NewGuid().ToString("N").Substring(0, 10);
                string cadena = "INSERT INTO cierreDeNominas(pkIdCierreDeNominas, año, mes, totalAPagar)" +
                    " VALUES ('" + pkIdCierreDeNominas + "'," + año + ",'" + mes + "'," + totalAPagar + ")";

                OdbcCommand consulta = new OdbcCommand(cadena, cn.conexion());
                consulta.ExecuteNonQuery();
            }
            cn.desconexion(con);
        }

        public void funEliminar(string Id)
        {
            string cadena = "delete from componenteseguridad.aplicacion where pkId ='" + Id + "';";

            OdbcCommand consulta = new OdbcCommand(cadena, cn.conexion());
            consulta.ExecuteNonQuery();
        }

        public (string, int) funBuscar(string id, string nombre, int estado, string ruta)
        {
            string Query = "select * from `componenteseguridad`.`Aplicacion` where pkId='" + id + "';";

            OdbcCommand consulta = new OdbcCommand(Query, cn.conexion());
            consulta.ExecuteNonQuery();

            OdbcDataReader busqueda;
            busqueda = consulta.ExecuteReader();

            if (busqueda.Read())
            {
                nombre = busqueda["nombre"].ToString();
                estado = int.Parse(busqueda["estado"].ToString());
            }

            return (nombre, estado);
        }

        public string funcObtenerNuevocodigo(string Tabla, string Campo)
        {
            String CampoResultante = "";

            string Consulta = "SELECT MAX(" + Campo + "+1) FROM " + Tabla + ";";
            OdbcCommand command = new OdbcCommand(Consulta, cn.conexion());
            OdbcDataReader reader = command.ExecuteReader();
            reader.Read();
            CampoResultante = reader.GetValue(0).ToString();
            reader.Close();
            if (String.IsNullOrEmpty(CampoResultante))
                CampoResultante = "1";
            return CampoResultante;
        }

        public OdbcDataReader funcInsertar(String Consulta)
        {
            Comm = new OdbcCommand(Consulta, cn.conexion());
            OdbcDataReader mostrar = Comm.ExecuteReader();
            return mostrar;
        }

        public OdbcDataReader funcConsulta(string Consulta)
        {
            Comm = new OdbcCommand(Consulta, cn.conexion());
            OdbcDataReader reader = Comm.ExecuteReader();
            return reader;
        }

        public OdbcDataReader funcModificar(string Consulta)
        {
            try
            {
                Comm = new OdbcCommand(Consulta, cn.conexion());
                OdbcDataReader mostrar = Comm.ExecuteReader();
                return mostrar;
            }
            catch (Exception Error)
            {
                Console.WriteLine("Error en modelo-modificar ", Error);
                return null;
            }
        }

        public void funInsertarP(string Id, string Nombre, int estado)
        {
            string cadena = "INSERT INTO" +
            " `componenteseguridad`.`Perfil` VALUES (" + "'" + Id + "', '" + Nombre + "' , '" + estado + "');";

            OdbcCommand consulta = new OdbcCommand(cadena, cn.conexion());
            consulta.ExecuteNonQuery();
        }
    }
}