using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backend
{
    public class Calculadora
    {
        public int Num1 { get; set; }
        public int Num2 { get; set; }
        public int Res { get; set; }


        /// <summary>
        /// Realiza la operacion y devuelve el resultado de la misma
        /// </summary>
        /// <param name="operacion"> +  o - o * o /</param>
        /// <param name="num1">Operando 1 </param>
        /// <param name="num2">Operando 2</param>
        /// <returns></returns>
        public string Operar(string operacion,
                          string num1,
                          string num2)
        {
            Num1 = int.Parse(num1);
            Num2 = int.Parse(num2);

            if (operacion == "+")
            {
                Res = Num1 + Num2;
            }
            else if (operacion == "*")
            {
                Res = Num1 * Num2;
            }
            else if (operacion == "-")
            {
                Res = Num1 - Num2;
            }
            else if (operacion == "/")
            {
                Res = Num1 / Num2;
            }
            else
            {
                return "error";
            }
            return Res.ToString();
        }

        //public int Operar (string operacion)
        //{
        //    if(operacion=="+")
        //    {
        //        Res = Num1 + Num2;
        //        return Res;
        //    }
        //    else if (operacion == "*")
        //    {
        //        Res = Num1 * Num2;
        //        return Res;
        //    }
        //    else if (operacion == "-")
        //    {
        //        Res = Num1 - Num2;
        //        return Res;
        //    }
        //    else if (operacion == "/")
        //    {
        //        Res = Num1 / Num2;
        //        return Res;
        //    }
        //    else
        //    {
        //        return 0;
        //    }
        //}
    }
}
