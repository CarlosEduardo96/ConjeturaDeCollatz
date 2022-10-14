using System;
using System.Collections.Generic;

namespace ConjeturaDeCollatz
{
    class Program
    {
        static void Main(string[] args)
        {
            bool ok = true;

            long contador = 1000000000000000064;
;
            while (ok)
            {
                try
                {
                    Collatz ecuacion = new Collatz();
                    ecuacion.CollatzComprobacion(contador, 0, new Historial(4), 0);
                    contador++;

                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    break;
                }
            }
            //while (ok)
            //{
            //    Collatz ecuacion = new Collatz();

            //    Console.Write("N: ");
            //    long r = long.Parse(Console.ReadLine());
            //    ecuacion.CollatzEcu(r);

            //    Console.WriteLine("Lista:");


            //    if (ecuacion.Tamano > 0)
            //    {
            //        for (int contador = 0; contador < ecuacion.Tamano; contador++)
            //        {
            //            Console.WriteLine($"valor {contador + 1}: {ecuacion.DameLista[contador]}");
            //        }
            //    }

            //}
        }       
    }
}
