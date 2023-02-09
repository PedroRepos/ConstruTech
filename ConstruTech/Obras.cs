using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstruTech
{
    class Obras
    {
        public static double largura;
        public static double comprimento;
        public static double ladoEsquerdo;
        public static double ladoDireito;
        public static double frenteTerreno;
        public static double fundoTerreno;

        public static double result;
        public static int escolha;

        public static bool escopo = true;
      
        public static void AreaTerreno()
        {
            while (escopo)
            {
                Console.Clear();
                Console.WriteLine("Selecionado: Area do Terreno");

                Console.WriteLine("");

                Console.WriteLine("Se a área for irregular, ou seja, com dimensões diferentes de frente, fundo e laterais," +
                        " utilizamos uma média para obter a área aproximada.");

                Console.Write("Os lados dos terrenos são Irregulares? (SIM - ENTER / NÃO - ESC)");

                Console.WriteLine("");

                if (Console.ReadKey().Key == ConsoleKey.Enter)
                {
                    Calculos.CalculoTerrenoIrregular();
                }
                else if (Console.ReadKey().Key == ConsoleKey.Escape)
                {
                    Calculos.CalculoTerrenoNormal();
                }
               
            }
        }
        public static void Contrapiso()
        {

        }
        public static void Alvenaria()
        {

        }
        public static void Colunas()
        {

        }
        public static void Laje()
        {

        }
        public static void Reboco()
        {

        }
        public static void Piso()
        {

        }
        public static void Tinta()
        {

        }
    }
}

