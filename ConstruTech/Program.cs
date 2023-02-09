using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstruTech
{
    class Program
    {
        static void Main(string[] args)
        {
            InicioPrograma();
        }

        public static void InicioPrograma()
        {
            //do
            //{
            //    key = Console.ReadKey();
            //    Console.WriteLine(key.Key + " foi pressionada.");

            //} while (key.Key != ConsoleKey.X);

            Console.Clear();

            Console.WriteLine("BEM VINDO! ESCOLHA A OPÇÃO DESEJADA: ");

            Console.WriteLine("1 - CALCULAR TERRENO");
            Console.WriteLine("2 - CALCULAR CONTRAPISO");
            Console.WriteLine("3 - CALCULAR ALVENARIA");
            Console.WriteLine("4 - CALCULAR COLUNAS");
            Console.WriteLine("5 - CALCULAR LAJE");
            Console.WriteLine("6 - CALCULAR REBOCO");
            Console.WriteLine("7 - CALCULAR REBOCO-GESSO");

            int escolha = int.Parse(Console.ReadLine());

            switch (escolha)
            {
                case 1:
                    Obras.AreaTerreno();
                    break;

                default:
                    break;
            }
        }
    }
}
