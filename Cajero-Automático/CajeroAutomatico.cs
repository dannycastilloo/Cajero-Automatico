using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cajero_Automático
{
    public class CajeroAutomatico : CuentaBancaria
    {
        public double ConsultarSaldo()
        {
            return Saldo;
        }

        public double DepositarFondos(double Fondo)
        {
            return Saldo + Fondo;
        }

        public double RetirarEfectivo(double Retiro)
        {
            return Saldo - Retiro;
        }

        public string CambiarPin(string NuevoPin) 
        {
            return NuevoPin;
        }
    }
}
