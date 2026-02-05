using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    abstract class Operacion
    {
        protected int numero1;
        protected int numero2;

        public Operacion(int n1, int n2)
        {
            numero1 = n1;
            numero2 = n2;
        }
        public abstract double Calcular();
        
    }
}
