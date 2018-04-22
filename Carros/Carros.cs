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

        public elemento buscarCarro(string placa, elemento aux)
        {
            if (aux == null)
                return null;
            else if (aux.placa == placa)
                return aux;
            else
                return buscarCarro(placa, aux.proximo);
        }

        public void cadastrarCarro(string placa, string modelo, string cor,
            string proprietario, int ano)
        {
            if (inicio != null)
            {
                elemento aux = new elemento();
                aux.placa = placa;
                aux.modelo = modelo;
                aux.cor = cor;
                aux.nomeProprietario = proprietario;
                aux.anoFabricacao = ano;
                aux.qtdLavagens = 0;
                aux.proximo = inicio;
                inicio = aux;
            }
            else
            {
                inicio = new elemento();
                inicio.placa = placa;
                inicio.modelo = modelo;
                inicio.cor = cor;
                inicio.nomeProprietario = proprietario;
                inicio.anoFabricacao = ano;
                inicio.qtdLavagens = 0;
                inicio.proximo = null;
            }        
            Console.WriteLine("Carro cadastrado com sucesso.");
        }

        public void exibirCarro(elemento aux)
        {
            Console.WriteLine("Placa.................: {0}",aux.placa);
            Console.WriteLine("Modelo................: {0})",aux.placa);
            Console.WriteLine("Cor...................: {0}",aux.cor);
            Console.WriteLine("Proprietario..........: {0}",aux.nomeProprietario);
            Console.WriteLine("Ano de fabricação.....: {0}",aux.anoFabricacao);
            Console.WriteLine("Quantidade de lavagem.: {0}",aux.qtdLavagens);
            Console.WriteLine("======================================================");
        }

    }
}
