using CapaModelo;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaControlador
{
    public class controladorNominasCierre
    {
        private SentenciasNominas sn = new SentenciasNominas();

        public void InsertarNomina(string fkIdEmpleado, string año, string mes, string diasLaborados, string horasOrdinarias, string horasExtraordinarias, string salarioTotal, string igss, string isr, string totalDeducciones, string salarioLiquido)
        {
            sn.funLlenarNominaMensual(fkIdEmpleado, año, mes, diasLaborados, horasOrdinarias, horasExtraordinarias, salarioTotal, igss, isr, totalDeducciones, salarioLiquido);
        }

        public void InsertarCierreDeNomina(string año, string mes, string totalAPagar)
        {
            sn.funLlenarCierreDeNominas(año, mes, totalAPagar);
        }

        public DataTable LlenarEmpleadosParaNominas(string año)
        {
            OdbcDataAdapter dt = sn.funObtenerEmpleadosNominas(año);
            DataTable table = new DataTable();
            dt.Fill(table);
            return table;
        }

        public DataTable LlenarNominas(int año, string mes)
        {
            OdbcDataAdapter dt = sn.funVerNominas(año, mes);
            DataTable table = new DataTable();
            dt.Fill(table);
            return table;
        }

        public DataTable LlenarCierreDeNominas(int año)
        {
            OdbcDataAdapter dt = sn.funVerCierresDeNomina(año);
            DataTable table = new DataTable();
            dt.Fill(table);
            return table;
        }
    }
}