using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carros
{
    class Program
    {
        static int menu()
        {
            Console.WriteLine("1 - Colocar carro na garagem.");
            Console.WriteLine("2 - Exibir carros na garagem.");
            Console.WriteLine("3 - Levar carro para lava jato.");
            Console.WriteLine("4 - Exibir carros no lava jato.");
            Console.WriteLine("5 - Atender carro no lava jato.");
            Console.WriteLine("6 - Exibir cadastro de carros.");
            Console.WriteLine("7 - Sair.");
            return int.Parse(Console.ReadLine());
        }

        static void Main(string[] args)
        {
            Carros carros = new Carros();


            int opc = 0;
            while(opc != 7)
            {
                Console.Clear();
                opc = menu();

                switch (opc)
                {
                    case 1:
                        Console.Clear();
                        Console.ReadKey();
                        break;

                    case 2:
                        Console.Clear();
                        Console.ReadKey();
                        break;

                    case 3:
                        Console.Clear();
                        Console.ReadKey();
                        break;

                    case 4:
                        Console.Clear();
                        Console.ReadKey();
                        break;

                    case 5:
                        Console.Clear();
                        Console.ReadKey();
                        break;

                    case 6:
                        Console.Clear();
                        Console.ReadKey();
                        break;

                    case 7:
                        Console.Clear();
                        Console.WriteLine("Obrigado por utilizar nosso sistema");
                        Console.ReadKey();
                        break;

                    default:
                        Console.Clear();
                        Console.WriteLine("Opção inválida!!");
                        Console.ReadKey();
                        break;
                }        
            }
        }
    }
}
