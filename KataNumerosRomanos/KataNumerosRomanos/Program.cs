using System;

namespace KataNumerosRomanos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ingresar numero");
            int numero = Console.Read();

            var decimaMod = new KataNumerosRomanos.Decimal();


            Console.WriteLine(decimaMod.ToRoman(numero));
            






        }
    }
}
