using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_Factory_Method
{
    class Cls_operacionConcreta:Interface_suma
    {


        public Cls_Atributos CreaOperacionSUMA(double num1, double num2)
        {
            return new Cls_Suma(num1,num2);
        }
        public Cls_Atributos creaoperacionRESTA(double num1, double num2)
        {
            return new Cls_Resta(num1, num2);
        }
        public Cls_Atributos creaoperacionMULTIPLICACION(double num1, double num2)
        {
            return new Cls_Multiplicacion(num1, num2);
        }
        public Cls_Atributos creaoperacionDIVICION(double num1, double num2)
        {
            return new Cls_Divicion(num1, num2);
        }


    }
}
