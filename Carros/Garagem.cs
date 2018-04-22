using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carros
{
    class Garagem
    {
        public class elemento
        {
            public string placa;
            public elemento proximo;
        }

        public elemento topo;

        public void guardarCarro(string placa)
        {
            elemento novo = new elemento();
            novo.placa = placa;
            novo.proximo = topo;
            topo = novo;
            Console.WriteLine("Carro colocado na garagem.");
        }
    }
}
