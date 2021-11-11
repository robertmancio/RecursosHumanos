using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaModelo
{
    public class totalPrestacion
    {

        Conexion cn = new Conexion();
        //Ivania Gatica 0901-18-19528
        public OdbcDataReader llenarcbxPrestacion(string sql)
        {
            try
            {
                OdbcCommand datos = new OdbcCommand(sql, cn.conexion());
                OdbcDataReader leer = datos.ExecuteReader();
                return leer;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }
        //Ivania Gatica 0901-18-19528
        public OdbcDataReader llenarcbxEmpleado(string sql)
        {
            try
            {
                OdbcCommand datos = new OdbcCommand(sql, cn.conexion());
                OdbcDataReader leer = datos.ExecuteReader();
                return leer;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }
        //Ivania Gatica 0901-18-19528
        public string consultaPrestacion(string nombre)
        {

            string id = "";
            string Query = "select * from prestacionlaboral where nombre='" + nombre + "';";

            OdbcCommand consulta = new OdbcCommand(Query, cn.conexion());
            consulta.ExecuteNonQuery();

            OdbcDataReader busqueda;
            busqueda = consulta.ExecuteReader();

            if (busqueda.Read())
            {

                id = busqueda["pkidprestacionlaboral"].ToString();

            }


            return id;
        }

        //Ivania Gatica 0901-18-19528
        public string consultaEmpleado(string nombre)
        {

            string id = "";
            string Query = "select * from empleado where nombre='" + nombre + "';";

            OdbcCommand consulta = new OdbcCommand(Query, cn.conexion());
            consulta.ExecuteNonQuery();

            OdbcDataReader busqueda;
            busqueda = consulta.ExecuteReader();

            if (busqueda.Read())
            {

                id = busqueda["pkidempleado"].ToString();

            }


            return id;
        }

        //public int calculardias(DateTime fechainicio, DateTime fechafinal, int diastrabajados, double diastrabajado)
        //{
        //    diastrabajado = 1 + ((fechafinal - fechainicio).TotalDays * 5 - (fechainicio.DayOfWeek - fechafinal.DayOfWeek) * 2) / 7;
        //    if ((int)fechafinal.DayOfWeek == 6) diastrabajado--;
        //    if ((int)fechainicio.DayOfWeek == 0) diastrabajado--;
        //    diastrabajados += Convert.ToInt32(diastrabajado);
        //    return diastrabajados;


        //}
        //public (string, float) funSueldoEmpleado(string Id, float sueldo)
        //{
        //    string Query = "select * from empleado where pkprestacion='" + Id + "';";

        //    OdbcCommand consulta = new OdbcCommand(Query, cn.conexion());
        //    consulta.ExecuteNonQuery();

        //    OdbcDataReader busqueda;
        //    busqueda = consulta.ExecuteReader();

        //    if (busqueda.Read())
        //    {

        //        sueldo = float.Parse(busqueda["sueldo"].ToString("R"));
        //    }

        //    return sueldo;
        //}



        //Ivania Gatica 0901-18-19528

        public void funInsertar(string Id, string fkidempleado, string fkidprestacionlaboral, string fechainicio, string fechafinal, int totaldiastrabajados, decimal totalprestacion)
        {


            //llamar variable de sueldo de la tabla empleados
            string sueldo = "";
            string sql = "SELECT * FROM empleado WHERE sueldo LIKE '%" + totalprestacion + "%';";
            // MessageBox.Show(sql);

            OdbcCommand cons = new OdbcCommand(sql, cn.conexion());
            cons.ExecuteNonQuery();

            OdbcDataReader busqueda;
            busqueda = cons.ExecuteReader();

            if (busqueda.Read())
            {
                sueldo = busqueda["sueldo"].ToString();
            }


            //Ivania Gatica 0901-18-19528
            //calcular el total de dias laborales trabajados
            totaldiastrabajados = (int)(1 + ((Convert.ToDateTime(fechafinal) - Convert.ToDateTime(fechainicio)).TotalDays * 5 - (Convert.ToDateTime(fechainicio).DayOfWeek - Convert.ToDateTime(fechafinal).DayOfWeek) * 2) / 7);
            if ((int)Convert.ToDateTime(fechafinal).DayOfWeek == 6) totaldiastrabajados--;
            if ((int)Convert.ToDateTime(fechainicio).DayOfWeek == 0) totaldiastrabajados--;



            //calcular el total de prestaciones 
            if (int.Parse(fkidprestacionlaboral) == 1)
            {
                totalprestacion = totalprestacion + ((Convert.ToDecimal(sueldo) / 365) * totaldiastrabajados);
            }
            else
            {
                if (int.Parse(fkidprestacionlaboral) == 2)
                {
                    totalprestacion = totalprestacion + ((Convert.ToDecimal(sueldo) / 365) * totaldiastrabajados) + 250; //+ ((Convert.ToDecimal(aguinaldo)/12)*6);
                }

                else
                {
                    if (int.Parse(fkidprestacionlaboral) == 3)
                    {
                        decimal diasvacas = (totaldiastrabajados * 15) / 365;
                        decimal mit = (Convert.ToDecimal(sueldo) / 30) * 15;
                        totalprestacion = totalprestacion + (mit / 15) * diasvacas;

                    }
                    else
                    {
                        if (int.Parse(fkidprestacionlaboral) == 4)
                        {
                            totalprestacion = totalprestacion + ((Convert.ToDecimal(sueldo) / 365) * totaldiastrabajados);
                        }
                        else
                        {
                            if (int.Parse(fkidprestacionlaboral) == 5)
                            {
                                totalprestacion = totalprestacion + (Convert.ToDecimal(sueldo) / 30);
                            }

                            else
                            {
                                MessageBox.Show("ingrese un valor valido");
                            }
                        }
                    }
                }
            }


            //cadena de insertar
            string cadena = "INSERT INTO totalprestacion VALUES ('" + Id + "', '" + fkidempleado + "' , '" + fkidprestacionlaboral + "', '" + fechainicio + "', '" + fechafinal + "', '" + totaldiastrabajados + "', '" + totalprestacion + "');";

            OdbcCommand consulta = new OdbcCommand(cadena, cn.conexion());
            consulta.ExecuteNonQuery();
        }

        //Ivania Gatica 0901-18-19528

        public void funModificar(string Id, string fkidempleado, string fkidprestacionlaboral, string fechainicio, string fechafinal, int totaldiastrabajados, decimal totalprestacion)
        {
            string cadena = "UPDATE totalprestacion set pkprestacion ='" + Id
              + "',fkidempleado = " + fkidempleado + "',fkidprestacionlaboral ='" + fkidprestacionlaboral + "',fechainicio = " + fechainicio + "',fechafinal = " + fechafinal + "',totaldiastrabajados = " + totaldiastrabajados + "',totalprestacion = " + totalprestacion + "  where pkprestacion= '" + Id + "';";

            OdbcCommand consulta = new OdbcCommand(cadena, cn.conexion());
            consulta.ExecuteNonQuery();
        }



        //Ivania Gatica 0901-18-19528
        public void funEliminarPrestacion(string Id)
        {
            string cadena = "delete from totalprestacion where pkprestacion ='" + Id + "';";

            OdbcCommand consulta = new OdbcCommand(cadena, cn.conexion());
            consulta.ExecuteNonQuery();
        }
        //Ivania Gatica 0901-18-19528

        public (string, string, string, string, int, decimal) funBuscar(string Id, string fkidempleado, string fkidprestacionlaboral, string fechainicio, string fechafinal, int totaldiastrabajados, decimal totalprestacion)
        {
            string Query = "select * from totalprestacion where pkprestacion='" + Id + "';";

            OdbcCommand consulta = new OdbcCommand(Query, cn.conexion());
            consulta.ExecuteNonQuery();

            OdbcDataReader busqueda;
            busqueda = consulta.ExecuteReader();

            if (busqueda.Read())
            {
                fkidempleado = busqueda["fkidempleado"].ToString();
                fkidprestacionlaboral = busqueda["fkidprestacionlaboral"].ToString();
                fechainicio = busqueda["fechainicio"].ToString();
                fechafinal = busqueda["fechafinal"].ToString();
                totaldiastrabajados = int.Parse(busqueda["totaldiastrabajados"].ToString());
                totalprestacion = decimal.Parse(busqueda["totalprestacion"].ToString());

            }

            return (fkidprestacionlaboral, fkidempleado, fechainicio, fechafinal, totaldiastrabajados, totalprestacion);
        }


        //Ivania Gatica 0901-18-19528

        public OdbcDataAdapter llenarTbl(string tabla)// metodo  que obtinene el contenido de una tabla
        {
            // string para almacenar los campos de OBTENERCAMPOS y utilizar el 1ro
            string sql = "SELECT pkprestacion, fkidempleado, fkidprestacionlaboral, fechainicio, fechafinal, totaldiastrabajados, totalprestacion FROM " + tabla + "  ;";
            OdbcDataAdapter dataTable = new OdbcDataAdapter(sql, cn.conexion());
            return dataTable;
        }

    }
}