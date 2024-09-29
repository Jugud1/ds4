using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio8._2
{
    public class CuentaCorriente : Cuenta
    {
        public CuentaCorriente(string prmtIdCuenta) : base(prmtIdCuenta)
        {

        }
        public override void CalcularIntereses()
        {

            System.Console.WriteLine("CuentaCorriente.CalcularIntereses() efectuado para" + "la cuenta {0}", getIdCuenta());

        }

    }

    public class CuentaAhorro : Cuenta
    {
        public CuentaAhorro(string prmtIdCuenta) : base(prmtIdCuenta)
        {
        }
        public override void CalcularIntereses()
        {
            System.Console.WriteLine("CuentaAhorro.CalcularIntereses() efectuado para " + "lacuenta {0}", getIdCuenta());
        }

    }

    internal class Program
    {
        public static void Main(string[] args)
        {

            const string Cuenta = new Cuenta("100");
            Cuenta cuenta = new Cuenta(Cuenta);
            CuentaCorriente cuentaCorriente =
            new CuentaCorriente(Cuenta);
            CuentaAhorro cuentaAhorro = new CuentaAhorro(Cuenta);
            cuenta.CalcularIntereses();
            cuentaCorriente.CalcularIntereses();
            cuentaAhorro.CalcularIntereses();


        }
    }
}
