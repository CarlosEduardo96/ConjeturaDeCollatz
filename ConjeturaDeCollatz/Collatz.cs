using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConjeturaDeCollatz
{
    public class Collatz
    {
        private List<long> Resultados;

        public List<long> DameLista { get => Resultados; }

        public long Tamano
        {
            get {
                if (Resultados == null)
                    return 0;
                else
                    return Resultados.Count;
            }
        }

      
        public void CollatzEcu(long n)
        {
            Resultados = new List<long>();
            Resultados.Add(n);

            long resul = 0;

            while (true)
            {

                if (n == 1 || n<0)
                {
                    break;
                }
                if ((n % 2) == 0)
                {
                    resul = n / 2;
                    n = resul;

                }
                else
                {
                    resul = (n * 3) + 1;
                    n = resul;
                }

                Resultados.Add(n);
            }
        }

        public void CollatzComprobacion(long n, long contador, Historial Historial, long varable) {
            try {
                if (n == 1)
                {
                    Console.WriteLine($"Paso {contador + 1}: {n}");
                    Console.WriteLine("Fin del ciclo");
                }
                else if (Historial.Repetitivo())
                {
                    Console.WriteLine($"Paso {contador + 1}: {n}");
                    throw new Exception ("La conjetura es falsa");
                }
                else if (n < 0)
                {
                    Console.WriteLine($"Paso {contador + 1}: {n}");
                    throw new Exception("La conjetura es falsa valores menores a cero");
                }
                else
                {
                    Console.WriteLine($"Paso {contador + 1}: {n}");
                    Historial.Insertar(n);
                    if ((n % 2) == 0)
                        varable = n / 2;


                    else
                        varable = (n * 3) + 1;

                    CollatzComprobacion(varable, contador + 1, Historial, 0);


                }
                
            }
            catch (Exception ex) {
                throw ex;
            }

        }
    }
}
