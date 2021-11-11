using CapaModelo;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaControlador
{  //Ivania Gatica 0901-18-19528
    public class controladorPrestaciones
    {

        totalPrestacion pr = new totalPrestacion();

        public OdbcDataReader llenarcbxPrestacion()
        {
            string sql = "SELECT nombre FROM prestacionlaboral;";
            return pr.llenarcbxPrestacion(sql);
        }

        public OdbcDataReader llenarcbxEmpleado()
        {
            string sql = "SELECT nombre FROM empleado;";
            return pr.llenarcbxEmpleado(sql);
        }




        //Ivania Gatica 0901-18-19528
        public void insertarPrestacion(string Id, string fkidempleado, string fkidprestacionlaboral, string fechainicio, string fechafinal, int totaldiastrabajados, decimal totalprestacion)
        {

            pr.funInsertar(Id, fkidempleado, fkidprestacionlaboral, fechainicio, fechafinal, totaldiastrabajados, totalprestacion);
        }

        public void modificarPrestacion(string Id, string fkidempleado, string fkidprestacionlaboral, String fechainicio, String fechafinal, int totaldiastrabajados, decimal totalprestacion)
        {

            pr.funModificar(Id, fkidempleado, fkidprestacionlaboral, fechainicio, fechafinal, totaldiastrabajados, totalprestacion);
        }


        //Ivania Gatica 0901-18-19528
        public (string, string, string, string, int, decimal) buscarPerfil(string Id, string fkidempleado, string fkidprestacionlaboral, string fechainicio, string fechafinal, int totaldiastrabajados, decimal totalprestacion)
        {
            pr.funBuscar(Id, fkidempleado, fkidprestacionlaboral, fechainicio, fechafinal, totaldiastrabajados, totalprestacion);
            return (fkidempleado, fkidprestacionlaboral, fechainicio, fechafinal, totaldiastrabajados, totalprestacion);
        }
        //Ivania Gatica 0901-18-19528
        public void eliminarPrestacion(string id)
        {
            pr.funEliminarPrestacion(id);
        }

        public string consultaPrestacion(string nombre)
        {
            string id = pr.consultaPrestacion(nombre);
            return id;
        }

        public string consultaEmpleado(string nombre)
        {
            string id = pr.consultaEmpleado(nombre);
            return id;
        }



        //Ivania Gatica 0901-18-19528
        public DataTable llenarTbl(string tabla)
        {
            OdbcDataAdapter dt = pr.llenarTbl(tabla);
            DataTable table = new DataTable();
            dt.Fill(table);
            return table;
        }

    }
}
