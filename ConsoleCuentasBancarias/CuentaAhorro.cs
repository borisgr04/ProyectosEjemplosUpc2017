using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleCuentasBancarias
{
    class CuentaAhorro:CuentaBancaria
    {
        public override decimal Retirar(decimal valor)
        {
            if (Saldo >= valor)
            {
                return base.Retirar(valor);
            }
            else {
                return Saldo;
            }
            
        }
    }
}
