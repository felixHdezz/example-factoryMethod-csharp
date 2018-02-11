using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_Factory_Method
{
    class Cls_Resta:Cls_Atributos
    {
        public Cls_Resta(double num1, double num2)
        {
            num3 = num1 - num2;
        }
    }
}
