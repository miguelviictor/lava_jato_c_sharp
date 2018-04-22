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
    }
}
