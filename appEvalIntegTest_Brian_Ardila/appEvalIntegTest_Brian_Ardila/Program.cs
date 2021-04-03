using appEvalIntegTest_Brian_Ardila.Entity;
using appEvalIntegTest_Brian_Ardila.SaludDelosPerros;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appEvalIntegTest_Brian_Ardila
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
                switch (choose)
                {
                    case 1: 
                        Call.SegundoMenu();
                        break;

                    case 2:
                        Console.WriteLine("Gracias por usar nuestros servicios");
                        Call.continuar = true;
                        break;

                    default:
                        Console.WriteLine("Valor invalido");
                        break;
                }
            } while (!Call.continuar);
            Console.WriteLine("\nKey kiss");
            Console.ReadLine();
        }
        
    }
}
