using CapaModelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//0901-18-17144 Luis De La Cruz
namespace CapaControlador
{
    public class controladorEnlacesContable
    {
        SentenciasEnlacesContables sn = new SentenciasEnlacesContables();

        public string calculoDebe(string fechaInicio, string fechaFinal)
        {
            string total = sn.calculoDebe(fechaInicio, fechaFinal);
            return total;
        }

        public string calculoHaber(string fechaInicio, string fechaFinal)
        {
            string total = sn.calculoHaber(fechaInicio, fechaFinal);
            return total;
        }

        //Insertar encabezado
        public void insertarEncabezado(string id, string fecha, string tipoPoliza)
        {
            sn.insertarEncabezado(id, fecha, tipoPoliza);

        }

        public string incrementarId()
        {
            string id = sn.incrementarId();

            return id;
        }

        public void insertarDetalle(string Id, string fecha, string idCuenta, string saldo, string idtipoOp, string concepto)
        {
            sn.insertarDetalle(Id, fecha, idCuenta, saldo, idtipoOp, concepto);
        }
    }
}
