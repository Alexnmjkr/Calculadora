using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    class División : Operacion
    {
        public División(int n1, int n2) : base(n1, n2) { }

        public override double Calcular()
        {
            if (numero2 == 0)
            {
                Console.WriteLine("Error: No se puede divid entree cero");
                return 0;
            }
            return (double)numero1 / numero2;
        }
    }
}
