using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleCuentasBancarias
{
    class Program
    {
        protected Program() {
        } 
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.White;

            #region Ejemplo Instanciación 1- Consignar
            CuentaBancaria ahorro = new CuentaAhorro();
            ahorro.Id = 1;
            ahorro.Numero = "524...";

            var saldo1=ahorro.Consignar(1000);

            Console.WriteLine($"Consignación: El nuevo saldo es {saldo1}");

            #endregion
            #region Ejemplo Instanciación 1- Retirar
            Console.WriteLine($"Retiro: El nuevo saldo es {ahorro.Retirar(1001)}");
            #endregion

            #region Ejemplo Instanciación 1 - Consignar
            CuentaBancaria corriente = new CuentaCorriente()
            {
                Id = 1,
                CupoSobreGiro=1000,
                Numero = "524..."
            };

            var saldo2 = corriente.Consignar(1000);

            Console.WriteLine($"Consignación: El nuevo saldo es {saldo2}");
            

            #endregion
            #region Ejemplo Instanciación 1- Retirar
            Console.WriteLine($"Retiro:El nuevo saldo es {corriente.Retirar(1001)}");
            #endregion
            Console.ReadKey();

        }
    }
}
