using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    internal class Resta : Operacion
    {
        public Resta(int n1, int n2) : base(n1,n2) { }
        public override double Calcular()
        {
            return numero1 - numero2;
        }
    }
}
