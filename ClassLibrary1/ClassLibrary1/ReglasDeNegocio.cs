using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticasEnCasa
{
    public class ReguladorReglasDeNegocio
    {
        public bool InactivarElCliente(DateTime fechaDeUltimaTransaccion, DateTime fechaActual)
        {
            bool estaInactivo=false;
            int diferenciaDeDias = (fechaActual - fechaDeUltimaTransaccion).TotalDays;
            if(diferenciaDeDias>=30){
                estaInactivo = true;
            }

            return estaInactivo;
        }
        public bool ValidarGarantia(int diasVencimiento)
        {
            bool esValidaGarantia = false;
            if (diasVencimiento > 7)
            {
                esValidaGarantia = true;
            }
            return esValidaGarantia;
        }
        public bool ValidarMultiplosDelMonto(double multiplosDelMonto, double montoMinimo)
        {
            bool esValidoMultiplo= false;
            double minimoMasBajo=0.01;
            if (multiplosDelMonto == montoMinimo || multiplosDelMonto > montoMinimo || multiplosDelMonto==minimoMasBajo)
            {
                esValidoMultiplo = true;
            }
            return esValidoMultiplo;
        }
    }
}
