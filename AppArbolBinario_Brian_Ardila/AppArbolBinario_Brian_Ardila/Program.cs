using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppArbolBinario_Brian_Ardila
{
    class Program
    {
        static void Main(string[] args)
        {
            ArbolBinarioOrdenado abo = new ArbolBinarioOrdenado();
            abo.Insertar(100);
            abo.Insertar(50);
            abo.Insertar(25);
            abo.Insertar(75);
            abo.Insertar(150);
            Console.WriteLine("Impresion pre-orden: ");
            abo.ImprimirPre();
            Console.WriteLine("Impresion entre-orden: ");
            abo.ImprimirEntre();
            Console.WriteLine("Impresion post-orden: ");
            abo.ImprimirPost();
            Console.ReadKey();
        }
    }
}
