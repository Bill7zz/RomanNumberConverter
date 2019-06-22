using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataNumerosRomanos
{
    public class Decimal
    {
        public string ToRoman(int number)
        {
            string numeroRomano = ""; 

            while (number > 0)
            {
                // para los casos 900 90 9
                // se resta la unidad al numero entero sigueinte 
                // 1000 => 100 -1000 ----> CM

               
                if (number >= 1000)
                {
                    numeroRomano += "M";
                    number -= 1000;
                }

                if (number == 900)
                {
                    numeroRomano += "CM";
                    number -= 900;
                }

                if (number == 90)
                {
                    numeroRomano += "CM";
                    number -= 90;
                }

                if (number >= 500 && number < 1000)
                {
                    numeroRomano += "D";
                    number -= 500;
                }

                if (number >= 100 && number < 500)
                {
                    numeroRomano += "C";
                    number -= 100;
                }

                if (number >= 50 && number < 100)
                {
                    numeroRomano += "L";
                    number -= 50;
                }
                if (number >= 10 && number < 50)
                {
                    numeroRomano += "X";
                    number -= 10;
                }

                if (number == 9)
                {
                    numeroRomano += "IX";
                    number -= 9;
                }

                if (number >= 5 && number < 10)
                {
                    numeroRomano += "V";
                    number -= 5;
                }

                if (number == 4)
                {
                    numeroRomano += "IV";
                    number -= 4;
                }
                
                if (number > 0 && number < 5)
                {
                    numeroRomano += "I";
                    number -= 1;
                }
            }

            return numeroRomano;            
        }
    }
}
