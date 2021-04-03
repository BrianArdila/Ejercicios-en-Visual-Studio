using appEvalUnitTest_Brian_Ardila.SaludDelosPerros;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appEvalUnitTest_Brian_Ardila
{
    class Program
    {
        static void Main(string[] args)
        {
            ProgramPerros Call = new ProgramPerros();

            do
            {
                Console.WriteLine("=====================  Menu Principal ======================");
                Console.WriteLine("Escoja una de las siguiente dos opciones");
                Console.WriteLine("Presione 1 para Evaluar el estado de nutrición de su mascota");
                Console.WriteLine("Presione 2 para Salir");
                Console.WriteLine("============================================================");
                int choose = int.Parse(Console.ReadLine());
                Call.MenuPrincipal(choose);
            } while (!Call.continuar);
            Console.WriteLine("\nKey kiss");
            Console.ReadLine();
        }
    }
}
