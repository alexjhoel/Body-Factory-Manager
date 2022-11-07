using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Body_Factory_Manager
{
    internal class ValidarCedulas
    {
        public static bool ValidarCedula(string ci)
        {
            return ci.Length == 8 && ci[7].ToString() == Digito(ci);

        }

        private static string Digito(string ci)
        {
            int a = 0;
            int i = 0;
            if (ci.Length <= 6)
            {
                for (i = ci.Length; i < 7; i++)
                {
                    ci = '0' + ci;
                }
            }
            for (i = 0; i < 7; i++)
            {
                a += (int.Parse("2987634"[i].ToString()) * int.Parse(ci[i].ToString())) % 10;
            }
            if (a % 10 == 0)
            {
                return "0";
            }
            else
            {
                return (10 - a % 10).ToString();
            }
        }
    }
}
