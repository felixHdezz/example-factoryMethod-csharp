using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_Factory_Method
{
    class Cls_Multiplicacion: Cls_Atributos
    {
        public Cls_Multiplicacion(double num1, double num2)
        {
            num3 = num1 * num2;
        }
    }
}
