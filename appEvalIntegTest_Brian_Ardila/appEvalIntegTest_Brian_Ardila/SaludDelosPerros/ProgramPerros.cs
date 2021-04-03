using appEvalIntegTest_Brian_Ardila.Contract;
using appEvalIntegTest_Brian_Ardila.Entity;
using appEvalIntegTest_Brian_Ardila.Repositorio;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appEvalIntegTest_Brian_Ardila.SaludDelosPerros
{
    public class ProgramPerros
    {
        public bool continuar = false;
        RangosRepositorios rangosRepositorios = new RangosRepositorios();

        public void MenuPrincipal(int choose)
        {
            switch (choose)
            {
                case 1 :
                    SegundoMenu();
                    break;

                case 2:
                    Console.WriteLine("Gracias por usar nuestros servicios");
                    continuar = true;
                    break;

                default:
                    Console.WriteLine("Valor invalido");
                    break;
            }
        }
        
        public void SegundoMenu()
        {
            
            do
            {
                int NumeroRaza = 1;

                Console.WriteLine("========================   Menu   ==========================");
                Console.WriteLine("Escoja una de las siguiente opciones");
                foreach (var Razalist in rangosRepositorios._rangosperros)
                {
                    Console.WriteLine($"Escriba {NumeroRaza} para " + Razalist.Raza);
                    NumeroRaza++;
                }
                Console.WriteLine("Escriba 0 para volver al Menu anterior");
                Console.WriteLine("============================================================");
                int choose = int.Parse(Console.ReadLine());
                ProgramPerros programPerros = new ProgramPerros();
                if (choose >= 1 && choose <= 18)
                {
                     Console.WriteLine("Ingrese el peso del perro");
                    int EnterWeight = int.Parse(Console.ReadLine());
                    programPerros.GetWeightDog(EnterWeight, choose);
                    continuar = true;
                    
                }
                else if (choose == 0)
                {
                    continuar = true;
                }
                else
                {
                    Console.WriteLine("Valor invalido");
                }

            } while (!continuar);
            continuar = false;

        }

        private readonly IRangoRepositorio _rangosperros;

        //public ProgramPerros(IRangoRepositorio rangosperros)
        //{
        //    _rangosperros = rangosperros;
        //}

        public decimal GetWeightDog(decimal weight, int EnterChoose)
        {

            decimal Kilos = 0;
            decimal PesoMinimoRecomendado=0;
            decimal PesoMaximoRecomendado=0;
            int NumeroRaza = 1;
            foreach (var RazaList in rangosRepositorios._rangosperros)
            {
                if (NumeroRaza == EnterChoose)
                {
                     PesoMinimoRecomendado = RazaList.PesoMinimoRecomendado;
                     PesoMaximoRecomendado = RazaList.PesoMaximoRecomendado;
                    
                }
                NumeroRaza++;
            }

            if (weight >= PesoMinimoRecomendado && weight <= PesoMaximoRecomendado)
            {
                Console.WriteLine($"¡Tu perro esta en un peso ideal!");
                return weight;
            }
            else if (weight < PesoMinimoRecomendado)
            {
                Kilos = PesoMinimoRecomendado - weight;
                Console.WriteLine($"¡Deberia darle de comer un poco mas a su perro! \nDeberia engordar {Kilos} KG para empezar a estar en su peso ideal");
                return Kilos;
            }
            else
            {
                Kilos = weight - PesoMaximoRecomendado;
                Console.WriteLine($"¡Deberia dejale de dar comida a su perro! \nDeberia adelgasar {Kilos} KG para empezar a estar en su peso ideal");
                return Kilos;
            }
        }

    }
}
