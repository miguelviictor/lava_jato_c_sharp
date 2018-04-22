using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carros
{
    class Carros
    {
        public class elemento
        {
            public string placa;
            public string modelo;
            public string cor;
            public string nomeProprietario;
            public int anoFabricacao;
            public int qtdLavagens;
            public elemento proximo;
        }

        public elemento inicio = null;
    }
}
