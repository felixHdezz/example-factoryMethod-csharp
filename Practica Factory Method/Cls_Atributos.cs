using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_Factory_Method
{
    public abstract class Cls_Atributos
    {
        public double num1, num2, num3;

        public double Num3
        {
            get { return num3; }
            set { num3 = value; }
        }

        public double Num2
        {
            get { return num2; }
            set { num2 = value; }
        }

        public double Num1
        {
            get { return num1; }
            set { num1 = value; }
        }
    }
}
