using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleCuentasBancarias
{
    
    abstract class CuentaBancaria
    {
     
        public int Id { get; set; }
        public string Numero { get; set; }
        public decimal Saldo { get; private set; }

        public virtual decimal Consignar(decimal valor) {
            Saldo += valor;
            return Saldo; 
        }
        public virtual decimal Retirar(decimal valor)
        {
            Saldo -= valor;
            return Saldo;
        }
    }
}
