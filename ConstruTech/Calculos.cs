using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstruTech
{
    class Calculos : Obras
    {
        public static void CalculoTerrenoIrregular()
        {
            Console.Clear();
            double mediaLargura, mediaComprimento, calculoArea;

            Console.Write("Comprimento Lado Direito: ");
            ladoDireito = double.Parse(Console.ReadLine());
            Console.Write("Comprimento Lado Esquerdo: ");
            ladoEsquerdo = double.Parse(Console.ReadLine());
            Console.Write("Comprimento Frente: ");
            frenteTerreno = double.Parse(Console.ReadLine());
            Console.Write("Comprimento Atrás: ");
            fundoTerreno = double.Parse(Console.ReadLine());

            Console.WriteLine("");

            Console.WriteLine("Média de Largura: {0}m", mediaLargura = frenteTerreno + fundoTerreno / 2);
            Console.WriteLine("Média de Comprimento: {0}m", mediaComprimento = ladoDireito + ladoEsquerdo / 2);

            calculoArea = mediaLargura * mediaComprimento;
            Console.WriteLine("Área Total: {0}m²", calculoArea);

            Console.ReadKey();
        }

        public static void CalculoTerrenoNormal()
        {
            while (escopo == true)
            {
                Console.Clear();

                Console.WriteLine("Insira a Largura: ");
                largura = double.Parse(Console.ReadLine());
                Console.WriteLine("Insira o Comprimento: ");
                comprimento = double.Parse(Console.ReadLine());

                result = largura * comprimento;

                Console.WriteLine("A área do terreno corresponde á: {0}m²", result);

                Console.WriteLine("Observação: Para aterro, é nescessário saber quandos metros de altura precisa aterrar," +
                    " já tens a altura correta? (SIM = ENTER / NÃO = ESC)");

                Console.WriteLine("");


                if (Console.ReadKey().Key == ConsoleKey.Enter)
                {
                    Console.WriteLine("Qual será a altura?");
                    double alturaTerreno = double.Parse(Console.ReadLine());

                    double total = alturaTerreno * comprimento * largura;

                    Console.WriteLine("Você irá precisar de {0}m³ de terra", total);

                    Console.WriteLine("Deseja Refazer o Cálculo? (SIM - QUALQUER TECLA / NÃO -> ESC)");

                    if (Console.ReadKey().Key == ConsoleKey.Escape)
                    {
                        escopo = false;
                    }

                    Console.Clear();
                }
                else if (Console.ReadKey().Key == ConsoleKey.Escape)
                {
                    Console.Clear();

                    Console.WriteLine("Escolha a Opção: 1 - MENU PRINCIPAL | 2 - REFAZER CÁLCULO | ESC - SAIR");
                    escolha = int.Parse(Console.ReadLine());

                    if (Console.ReadKey().Key == ConsoleKey.Escape)
                    {
                        escopo = false;
                    }
                    else if (Console.ReadKey().Key == ConsoleKey.NumPad1 || Console.ReadKey().Key == ConsoleKey.Oem1)
                    {
                        Program.InicioPrograma();
                    }
                    else if (Console.ReadKey().Key == ConsoleKey.NumPad2)
                    {
                        continue;
                    }
                }
            }
        }
    }
}

