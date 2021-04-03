using System;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appEvalUnitTest_Brian_Ardila.SaludDelosPerros
{
    public class ProgramPerros
    {
        public bool continuar = false;
        public string RazaProblematica = "";

        public void MenuPrincipal(int choose)
        {
            switch (choose)
            {
                case 1:
                    do
                    {
                        Console.WriteLine("========================   Menu   ==========================");
                        Console.WriteLine("Escoja una de las siguiente opciones");
                        Console.WriteLine("Escoja una de las siguiente dos opciones");
                        Console.WriteLine("Presione 1 para Afgano");
                        Console.WriteLine("Presione 2 para Akita");
                        Console.WriteLine("Presione 3 para American Bully");
                        Console.WriteLine("Presione 4 para American Pitbull Terrier");
                        Console.WriteLine("Presione 5 para Beagle");
                        Console.WriteLine("Presione 6 para Bichon Frise");
                        Console.WriteLine("Presione 7 para Bichon Maltes");
                        Console.WriteLine("Presione 8 para Bodeguero Andaluz");
                        Console.WriteLine("Presione 9 para Border Collie");
                        Console.WriteLine("Presione 10 para Border Terrier");
                        Console.WriteLine("Presione 11 para Boxer");
                        Console.WriteLine("Presione 12 para Bulldog");
                        Console.WriteLine("Presione 13 para Caniche");
                        Console.WriteLine("Presione 14 para Chihuahua");
                        Console.WriteLine("Presione 15 para Chow Chow");
                        Console.WriteLine("Presione 16 para Golden Retriever");
                        Console.WriteLine("Presione 17 para Labrador Retriever");
                        Console.WriteLine("Presione 18 para Raposero Americano");
                        Console.WriteLine("\nEscriba 0 para volver al Menu anterior");
                        Console.WriteLine("============================================================");
                        int choose2 = int.Parse(Console.ReadLine());
                        SegundoMenu(choose2);

                    } while (!continuar);
                    continuar = false;
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
        

        public void SegundoMenu(int choose)
        {
            ProgramPerros programPerros = new ProgramPerros();

            if (choose >= 1 && choose <= 4)
            {
                continuar = true;
                Console.WriteLine("Ingrese el peso del perro");
                decimal EnterWeight = decimal.Parse(Console.ReadLine());
                programPerros.GetWeightDog(EnterWeight);

            } else if (choose == 18)
            {
                continuar = true;
                Console.WriteLine("Ingrese el peso del perro");
                decimal EnterWeight = decimal.Parse(Console.ReadLine());
                programPerros.GetWeightDog(EnterWeight);
            }
            else if (choose >= 6 && choose <= 10)
            {
                continuar = true;
                Console.WriteLine("Ingrese el peso del perro");
                decimal EnterWeight = decimal.Parse(Console.ReadLine());
                programPerros.GetWeightDog(EnterWeight);

            } else if (choose >= 12 && choose <= 16)
            {
                continuar = true;
                Console.WriteLine("Ingrese el peso del perro");
                decimal EnterWeight = decimal.Parse(Console.ReadLine());
                programPerros.GetWeightDog(EnterWeight);
            }
            else if (choose == 0)
            {
                continuar = true;
            } else if (choose == 5)
            {
                continuar = true;
                Console.WriteLine("Ingrese el peso del perro");
                decimal EnterWeight = decimal.Parse(Console.ReadLine());
                programPerros.GetWeightBeagle(EnterWeight);

            } else if (choose == 11)
            {
                continuar = true;
                Console.WriteLine("Ingrese el peso del perro");
                decimal EnterWeight = decimal.Parse(Console.ReadLine());
                programPerros.GetWeightBoxer(EnterWeight);

            } else if (choose == 17)
            {
                continuar = true;
                Console.WriteLine("Ingrese el peso del perro");
                decimal EnterWeight = decimal.Parse(Console.ReadLine());
                programPerros.GetWeightLabradorRetriever(EnterWeight);

            }
            else
            {
                Console.WriteLine("Valor invalido");
            }
                
        }

        public decimal GetWeightBeagle( decimal weight)
        {
            decimal Kilos = 0;
            decimal PesoMinimoRecomendado = 8.0m;
            decimal PesoMaximoR = 14.0m;
            if (weight >= PesoMinimoRecomendado && weight <= PesoMaximoR)
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
                Kilos = weight - PesoMaximoR;
                Console.WriteLine($"¡Deberia dejale de dar comida a su perro! \nDeberia adelgasar {Kilos} KG para empezar a estar en su peso ideal");
                return Kilos;
            }

        }
        public decimal GetWeightBoxer(decimal weight)
        {
            decimal Kilos = 0;
            decimal PesoMinimoRecomendado = 20.0m;
            decimal PesoMaximo = 40.0m;
            if (weight >= PesoMinimoRecomendado && weight <= PesoMaximo)
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
                Kilos = weight - PesoMaximo;
                Console.WriteLine($"¡Deberia dejale de dar comida a su perro! \nDeberia adelgasar {Kilos} KG para empezar a estar en su peso ideal");
                return Kilos;
            }

        }
        public decimal GetWeightLabradorRetriever(decimal weight)
        {
            decimal Kilos = 0;
            decimal PesoMinimoRecom = 20.0m;
            decimal PesoMaximoRecom = 35.0m;
            if (weight >= PesoMinimoRecom && weight <= PesoMaximoRecom)
            {
                Console.WriteLine($"¡Tu perro esta en un peso ideal!");
                return weight;
            }
            else if (weight < PesoMinimoRecom)
            {
                Kilos = PesoMinimoRecom - weight;
                Console.WriteLine($"¡Deberia darle de comer un poco mas a su perro! \nDeberia engordar {Kilos} KG para empezar a estar en su peso ideal");
                return Kilos;
            }
            else
            {
                Kilos = weight - PesoMaximoRecom;
                Console.WriteLine($"¡Deberia dejale de dar comida a su perro! \nDeberia adelgasar {Kilos} KG para empezar a estar en su peso ideal");
                return Kilos;
            }
        }

        public decimal GetWeightDog(decimal weight)
        {
            decimal PesoMinimoRecomendado = 20.0m;
            decimal PesoMaximoRecomendado = 28.0m;
            
            decimal Kilos = 0;

            if (weight >= PesoMinimoRecomendado && weight <= PesoMaximoRecomendado)
            {
                Console.WriteLine($"¡Tu perro esta en un peso ideal!");
                return weight;
            } else if (weight < PesoMinimoRecomendado)
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
