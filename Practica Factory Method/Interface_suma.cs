using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_Factory_Method
{
    interface Interface_suma
    {
        Cls_Atributos CreaOperacionSUMA(double num1, double num2);
        Cls_Atributos creaoperacionRESTA(double num1, double num2);
        Cls_Atributos creaoperacionMULTIPLICACION(double num1, double num2);
        Cls_Atributos creaoperacionDIVICION(double num1, double num2);
    }
}
