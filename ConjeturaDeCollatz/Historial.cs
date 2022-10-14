using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConjeturaDeCollatz
{
    public class Historial
    {
        //Lista de objetos
        private long[] UltimaLista = null;
        private long[] ListaActual= null;

        //Constantes
        private int councidencia = 0;
        private int contador = 0;
        private int tamano=0;

        public long[] DameListaActual { get => ListaActual; }

        public int PosicionActual{ get => contador; }

        public int Tamano { get => tamano; }


        public Historial(int tamano) {
            ListaActual = new long[tamano];
            this.tamano = tamano;
        }

        
        public void Insertar(long n) {

            if ( contador < 0 || contador >( ListaActual.Length-1)) { 
                contador = 0;
                UltimaLista = ListaActual;
                ListaActual = new long[tamano];           
            }

            ListaActual[contador] = n;
            
            contador = contador + 1;
        }

        public bool Repetitivo() {
            bool ok = false;
            councidencia = 0;
            if (ListaActual != null && UltimaLista != null) {
                for (int i=0;  i< ListaActual.Length; i++) {
                    for (int j=0; j<UltimaLista.Length; j++) { 
                        if (ListaActual[i]!=0 && ListaActual[i]== UltimaLista[j]) {
                            councidencia = councidencia + 1;
                        }                    
                    }
                }

                if (councidencia >= 3)
                    ok = true;
            }
            return ok;
        }
    }
}
