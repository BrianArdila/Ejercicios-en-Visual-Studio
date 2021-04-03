using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {

        static void Main(string[] args)
        {
            // Los 118 elementos de la tabla periodica
            Dictionary<string, string> TablaPeriodica = new Dictionary<string, string>();
            TablaPeriodica.Add("Ac", "Actinio");
            TablaPeriodica.Add("Al", "Aluminio");
            TablaPeriodica.Add("Am", "Americio");
            TablaPeriodica.Add("Sb", "Antimonio");
            TablaPeriodica.Add("Ar", "Argón");
            TablaPeriodica.Add("As", "Arsénico");
            TablaPeriodica.Add("At", "Ástato");
            TablaPeriodica.Add("S", "Azufre");
            TablaPeriodica.Add("Ba", "Bario");
            TablaPeriodica.Add("Be", "Berilio");
            TablaPeriodica.Add("Bk", "Berkelio");
            TablaPeriodica.Add("Bi", "Bismuto");
            TablaPeriodica.Add("Bh", "Bohrio");
            TablaPeriodica.Add("B", "Boro");
            TablaPeriodica.Add("Br", "Bromo");
            TablaPeriodica.Add("Cd", "Cadmio");
            TablaPeriodica.Add("Ca", "Californio");
            TablaPeriodica.Add("C", "Carbono");
            TablaPeriodica.Add("Ce", "Cerio");
            TablaPeriodica.Add("Cs", "Cesio");
            TablaPeriodica.Add("Cl", "Cloro");
            TablaPeriodica.Add("Co", "Cobalto");
            TablaPeriodica.Add("Cu", "Cobre");
            TablaPeriodica.Add("NC", "Copernicium");
            TablaPeriodica.Add("Cr", "Cromo");
            TablaPeriodica.Add("Cm", "Curio");
            TablaPeriodica.Add("Ds", "Darmstadio");
            TablaPeriodica.Add("Dy", "Disprosio");
            TablaPeriodica.Add("Db", "Dubnio");
            TablaPeriodica.Add("Es", "Einstenio");
            TablaPeriodica.Add("Er", "Erbio");
            TablaPeriodica.Add("Sc", "Escandio");
            TablaPeriodica.Add("Sn", "Estaño");
            TablaPeriodica.Add("Sr", "Estroncio");
            TablaPeriodica.Add("Eu", "Europio");
            TablaPeriodica.Add("Fm", "Fermio");
            TablaPeriodica.Add("Fl", "Flerovium");
            TablaPeriodica.Add("F", "Fluor");
            TablaPeriodica.Add("P", "Fósforo");
            TablaPeriodica.Add("Fr", "Francio");
            TablaPeriodica.Add("Gd", "Gadolinio");
            TablaPeriodica.Add("Ga", "Galio");
            TablaPeriodica.Add("Ge", "Germanio");
            TablaPeriodica.Add("Hf", "Hafnio");
            TablaPeriodica.Add("Hs", "Hassio");
            TablaPeriodica.Add("He", "Helio");
            TablaPeriodica.Add("H", "Hidrógeno");
            TablaPeriodica.Add("Fe", "Hierro");
            TablaPeriodica.Add("Ho", "Holmio");
            TablaPeriodica.Add("In", "Indio");
            TablaPeriodica.Add("I", "Iodo");
            TablaPeriodica.Add("Ir", "Iridio");
            TablaPeriodica.Add("Yb", "Iterbio");
            TablaPeriodica.Add("Y", "Itrio");
            TablaPeriodica.Add("Kr", "Kryptón");
            TablaPeriodica.Add("La", "Lantano");
            TablaPeriodica.Add("Lr", "Lawrencio");
            TablaPeriodica.Add("Li", "Litio");
            TablaPeriodica.Add("Lv", "Livermorium");
            TablaPeriodica.Add("Lu", "Lutecio");
            TablaPeriodica.Add("Mg", "Magnesio");
            TablaPeriodica.Add("Mn", "Manganeso");
            TablaPeriodica.Add("Mt", "Meitnerio");
            TablaPeriodica.Add("Md", "Mendelevio");
            TablaPeriodica.Add("Hg", "Mercurio");
            TablaPeriodica.Add("Mo", "Molibdeno");
            TablaPeriodica.Add("Mc", "Moscovium");
            TablaPeriodica.Add("Nd", "Neodimio");
            TablaPeriodica.Add("Ne", "Neón");
            TablaPeriodica.Add("Np", "Neptunio");
            TablaPeriodica.Add("Nh", "Nihonium");
            TablaPeriodica.Add("Nb", "Niobio");
            TablaPeriodica.Add("Ni", "Níquel");
            TablaPeriodica.Add("N", "Nitrógeno");
            TablaPeriodica.Add("No", "Nobelio");
            TablaPeriodica.Add("Og", "Oganesson");
            TablaPeriodica.Add("Au", "Oro");
            TablaPeriodica.Add("Os", "Osmio");
            TablaPeriodica.Add("O", "Oxígeno");
            TablaPeriodica.Add("Pd", "Paladio");
            TablaPeriodica.Add("Ag", "Plata");
            TablaPeriodica.Add("Pt", "Platino");
            TablaPeriodica.Add("Pb", "Plomo");
            TablaPeriodica.Add("Pu", "Plutonio");
            TablaPeriodica.Add("Po", "Polonio");
            TablaPeriodica.Add("K", "Potasio");
            TablaPeriodica.Add("Pr", "Praseodimio");
            TablaPeriodica.Add("Pm", "Promecio");
            TablaPeriodica.Add("Pa", "Protactinio");
            TablaPeriodica.Add("Ra", "Radio");
            TablaPeriodica.Add("Rn", "Radón");
            TablaPeriodica.Add("Re", "Renio");
            TablaPeriodica.Add("Rh", "Rodio");
            TablaPeriodica.Add("Rg", "Roentgenium");
            TablaPeriodica.Add("Rb", "Rubidio");
            TablaPeriodica.Add("Ru", "Rutenio");
            TablaPeriodica.Add("Rf", "Rutherfordio");
            TablaPeriodica.Add("Sm", "Samario");
            TablaPeriodica.Add("Sg", "Seaborgio");
            TablaPeriodica.Add("Se", "Selenio");
            TablaPeriodica.Add("Si", "Silicio");
            TablaPeriodica.Add("Na", "Sodio");
            TablaPeriodica.Add("Tl", "Talio");
            TablaPeriodica.Add("Ta", "Tantalio");
            TablaPeriodica.Add("Tc", "Tecnecio");
            TablaPeriodica.Add("Te", "Teluro");
            TablaPeriodica.Add("Ts", "Tennessine");
            TablaPeriodica.Add("Tb", "Terbio");
            TablaPeriodica.Add("Ti", "Titanio");
            TablaPeriodica.Add("Th", "Torio");
            TablaPeriodica.Add("Tm", "Tulio");
            TablaPeriodica.Add("U", "Uranio");
            TablaPeriodica.Add("V", "Vanadio");
            TablaPeriodica.Add("W", "Wolframio");
            TablaPeriodica.Add("Xe", "Xenón");
            TablaPeriodica.Add("Zn", "Zinc");
            TablaPeriodica.Add("Zr", "Zirconio");
            
            Console.Write("\nIngresa la Frase formada con los simbolos de los elementos quimicos\n");
            string Frase = Console.ReadLine();

            /* YO USO C*/
            object Suma = "";
            string Cadenarespuesta;

            for (int index = 1; index <= 2; index++)
            {
                int X = (Frase.Length - index);
                for (int index2 = 0; (index2 <= X); index2++)
                {
                    // Estrae la palabra del string frase y convierte el primero el mayuscula el resto en minuscula
                    string sSubCadenaContenedor = Frase.Substring(index2, index);
                    string sSubCadena = sSubCadenaContenedor.Substring(0, 1).ToUpper() + sSubCadenaContenedor.Substring(1).ToLower();
                    // Cambia el simbolo del elemento por el nombre completo de este
                    try
                    {
                        Cadenarespuesta = TablaPeriodica[sSubCadena];
                    }
                    catch { Cadenarespuesta = String.Empty; }
                    // Concatena la respuesta
                    if (Cadenarespuesta == String.Empty) { } else { Suma = Cadenarespuesta + " " + Suma; }

                }
            }
            Console.Write("\nEstos son los nombres de los elementos usados en la frase anterio\n");
            Console.WriteLine(Suma.ToString());
            /*Silicio PraseodimioOganessonRadioMolibdeno UranioAzufreOxígeno Carbono*/
            Console.Write("\nIngresa la Frase formada con los nombres de los elementos quimicos\nPor favor ingresar los Nombres con la primera letra en mayuscula\n");
            string Nombres = Console.ReadLine(); ;

            Suma = "";
            Cadenarespuesta = string.Empty;

            for (int index = 3; index <= Nombres.Length; index++)
            { 
                //Estrae el dato del string nombres y remplaza las palabras por los simbolos de esos elementos
                int X = (Nombres.Length - index);
                for (int index2 = 0; (index2 <= X); index2++)
                {
                    string sSubCadena = Nombres.Substring(index2, index);
                    try
                    {
                        //Aqui obtine la llave del diccionario
                        Cadenarespuesta = TablaPeriodica.FirstOrDefault(x => x.Value == sSubCadena).Key;
                    }
                    catch { Cadenarespuesta = String.Empty; }
                    if (Cadenarespuesta == null)
                    {
                    }
                    else
                    {
                        //aqui remplaza los nombres por simbolos
                        Nombres = Nombres.Replace(sSubCadena, Cadenarespuesta);
                        X = (Nombres.Length - index);
                    }

                }
            }

            Console.Write("\nEstos son los simbolos de los elementos usados en la frase anterior\n");
            Console.WriteLine(Nombres);

            Console.Write("\nPresiona cualquier tecla para terminar ... ");
            Console.ReadKey();
        }

    }
}

