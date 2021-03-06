﻿using System;
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

        public bool enviarLavaJato(string placa)
        {
            elemento aux = buscarCarro(placa, topo);
            if(aux != null)
            {
                Console.Clear();
                elemento carrosRemovidos = new elemento();    
                
                while(topo != null)
                {
                    if (topo != aux)
                    {
                        if (carrosRemovidos == null)
                        {
                            carrosRemovidos.placa = topo.placa;
                            carrosRemovidos.proximo = null;
                            topo = topo.proximo;
                            Console.WriteLine("Carro da placa {0} removido da garagem.", carrosRemovidos.placa);
                        }
                        else
                        {
                            elemento aux1 = new elemento();
                            aux1.placa = topo.placa;
                            aux1.proximo = carrosRemovidos;
                            carrosRemovidos = aux1;
                            topo = topo.proximo;
                            Console.WriteLine("Carro da placa {0} removido da garagem.", carrosRemovidos.placa);
                        }
                    }
                    else
                    {                        
                        Console.WriteLine("\nCarro da placa {0} removido da garagem" +
                            "\ne enviado para o lava jato.\n", topo.placa);
                        topo = topo.proximo;                       
                        break;
                    }
                }      

                while(carrosRemovidos != null)
                {
                    if(topo!=null)
                    {
                        if (carrosRemovidos.placa != null)
                        {
                            elemento aux1 = new elemento();
                            aux1.placa = carrosRemovidos.placa;
                            aux1.proximo = topo;
                            topo = aux1;
                            carrosRemovidos = carrosRemovidos.proximo;
                            Console.WriteLine("Carro da placa {0} colocado na garagem.", topo.placa);
                        }
                        else
                        {
                            carrosRemovidos = carrosRemovidos.proximo;
                        }
                    }
                    else
                    {
                        topo.placa = carrosRemovidos.placa;
                        topo.proximo = null;
                        carrosRemovidos = carrosRemovidos.proximo;
                        Console.WriteLine("Carro da placa {0} colocado na garagem.", topo.placa);
                    }
                }
                return true;
            }
            else
            {
                Console.WriteLine("Este carro não se encontra na garagem.");
                return false;
            }
                
        }
    }
}
