using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace produtoEstoque
{
    internal class retangulo
    {
        public double largura;
        public double altura;

        public double Area()
        {
        return largura  * altura;
        }
        public double  Perimetro()
        {

            return 2*(largura + altura);
        }
        public double diagonal ()
        {
            return Math.Sqrt (largura* largura + altura* altura);
        }
    }
}

