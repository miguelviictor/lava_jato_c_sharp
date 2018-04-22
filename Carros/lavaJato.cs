using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carros
{
    class LavaJato
    {
        public class elemento
        {
            public string placa;
            public elemento proximo;
        }

        public elemento inicio = null;
        public elemento fim = null;

        public void colocarFila(string placa)
        {
            elemento novo = new elemento();

            novo.placa = placa;
            novo.proximo = null;

            if (fim != null)
                fim.proximo = novo;
            else
                inicio = novo;

            fim = novo;

            Console.WriteLine("\nCarro colocado na fila do lavo jato.\n");
        }
    }
}
