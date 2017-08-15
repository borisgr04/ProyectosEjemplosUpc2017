using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleCuentasBancarias
{
    class CuentaCorriente:CuentaAhorro
    {
        public decimal CupoSobreGiro { get; set; }

        public override decimal Retirar(decimal valor)
        {
            if (-1*CupoSobreGiro <= (Saldo - valor))
            {
                return base.Retirar(valor);
            }
            else {
                return Saldo;
            }
            
        }
    }
}
