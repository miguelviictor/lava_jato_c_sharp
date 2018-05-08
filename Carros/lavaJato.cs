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
        public int qtdAtendidos;

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

        public void exibirCarros(elemento aux)
        {
            if (aux != null)
            {
                AuxCarro.Carros.exibirCarro(AuxCarro.Carros.buscarCarro(aux.placa, AuxCarro.Carros.inicio));
                exibirCarros(aux.proximo);
            }
        }

        public elemento buscarCarro(string placa, elemento aux)
        {
            if (aux == null)
                return null;
            else if (aux.placa.Equals(placa))
                return aux;
            else
                return buscarCarro(placa, aux.proximo);
        }

        public void atenderCarro(string placa)
        {
            elemento aux = buscarCarro(placa, inicio);            
            if (aux != null)
            {
                qtdAtendidos++;
                AuxCarro.Carros.adicionaLavagem(placa, 1);                
                if (qtdAtendidos==5)
                {
                    Console.WriteLine("Parabéns! Lavagem gratuita. Você é o 5º cliente atendido desde o último ganhador!");
                    qtdAtendidos = 0;
                }
                if (AuxCarro.Carros.exibeQtdLavagens(placa)==3)
                {
                    Console.WriteLine("Parabéns! Lavagem gratuita. Esta é a sua 3ª lavagem desde a sua última premiação!");
                    AuxCarro.Carros.adicionaLavagem(placa, 0);
                }
                inicio = inicio.proximo;
                if (inicio == null)
                    fim = null;
                Console.WriteLine("Carro atendido no lavajato");
            }
            else
            {
                Console.WriteLine("ESTE VEÍCULO NÃO SE ENCONTRA NO LAVA-JATO");
            }
        }
    }
}
