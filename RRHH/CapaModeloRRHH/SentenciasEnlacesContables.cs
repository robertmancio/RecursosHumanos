using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//0901-18-17144 Luis De La Cruz
namespace CapaModelo
{

    public class SentenciasEnlacesContables
    {
        Conexion cn = new Conexion();



        public string calculoDebe(string fechaI, string fechaF)
        {
            //select sum(saldo) from polizaDetalle where concepto = 'Venta' and idTipoOperacion = '1' 
            //and fechaPoliza between cast('2021-10-1' as date) and cast('2021-10-02' as date);

            string total = "";
            string Query = "select sum(saldo) from polizaDetalle where concepto = 'Nomina' and idTipoOperacion = '1' and" +
                " fechaPoliza between cast('" + fechaI + "' as date) and cast('" + fechaF + "' as date) ;";

            OdbcCommand consulta = new OdbcCommand(Query, cn.conexion());
            consulta.ExecuteNonQuery();

            OdbcDataReader busqueda;
            busqueda = consulta.ExecuteReader();

            if (busqueda.Read())
            {

                total = busqueda["sum(saldo)"].ToString();

            }

            return total;
        }

        public string calculoHaber(string fechaI, string fechaF)
        {
            //select sum(saldo) from polizaDetalle where concepto = 'Venta' and idTipoOperacion = '1' 
            //and fechaPoliza between cast('2021-10-1' as date) and cast('2021-10-02' as date);

            string total = "";
            string Query = "select sum(saldo) from polizaDetalle where concepto = 'Nomina' and idTipoOperacion = '2' and" +
                " fechaPoliza between cast('" + fechaI + "' as date) and cast('" + fechaF + "' as date) ;";

            OdbcCommand consulta = new OdbcCommand(Query, cn.conexion());
            consulta.ExecuteNonQuery();

            OdbcDataReader busqueda;
            busqueda = consulta.ExecuteReader();

            if (busqueda.Read())
            {

                total = busqueda["sum(saldo)"].ToString();

            }

            return total;
        }

        public string incrementarId()
        {
            string id = "";
            // string Query = "select * from polizaEncabezado order by length (idPolizaEncabezado) DESC limit 1;";
            string Query = " SELECT(idPolizaEncabezado * 1) as `idPolizaEncabezado` from polizaEncabezado order by(idPolizaEncabezado) DESC limit 1;";
            //  string Query = "select * from polizaDetalle ORDER BY length(idPolizaEncabezado ) ASC;";

            OdbcCommand consulta = new OdbcCommand(Query, cn.conexion());
            consulta.ExecuteNonQuery();

            OdbcDataReader busqueda;
            busqueda = consulta.ExecuteReader();

            if (busqueda.Read())
            {

                id = busqueda["idPolizaEncabezado"].ToString();

            }
            else
            {
                Console.WriteLine("Error acá");
            }
            return id;
        }

        public void insertarEncabezado(string Id, string fecha, string tipoPoliza)
        {
            string cadena = "INSERT INTO" +
            " polizaEncabezado VALUES (" + "'" + Id + "', '" + fecha + "' ,'" + tipoPoliza + "');";

            OdbcCommand consulta = new OdbcCommand(cadena, cn.conexion());
            consulta.ExecuteNonQuery();
        }


        public void insertarDetalle(string Id, string fecha, string idCuenta, string saldo, string idtipoOp, string concepto)
        {


            string cadena = "INSERT INTO" +
            " polizaDetalle VALUES (" + "'" + Id + "', '" + fecha + "' ,'" + idCuenta + "','" + saldo + "','" + idtipoOp + "','" + concepto + "' );";

            OdbcCommand consulta = new OdbcCommand(cadena, cn.conexion());
            consulta.ExecuteNonQuery();
        }


    }
}
