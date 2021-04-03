
using System;
// "Prototipo"
abstract class DiscoDuro 
{
    private string _so;
    private string _marcadisco;
    public string __servicio;

    public DiscoDuro(string So, string MarcaDisco)
    {
        _so = So;
        _marcadisco = MarcaDisco;
    }

    public string SO
    {
        get { return _so; }
        set { _so = value; }
    }

    public string MarcaDisco
    {
        get { return _marcadisco; }
        set { _marcadisco = value; }
    }

    public string Servicio {
        get { return __servicio; }
        set { __servicio = value; }
    }
    

    public  void Imprimir()
    {
        if (__servicio == null)
        {
            
            Console.WriteLine("Su Disco Duro fue clonado exitosamente con las siguientes caracteristicas:  \n Sistema Operativo: {0} \nMarca Disco: {1} ", SO, MarcaDisco);
            Console.Write("\n===========================================================================\n");
        }
        else
        {
            Console.Write("\n===========================================================================\n");
            Console.WriteLine("Su Disco Duro fue instalado exitosamente con las siguientes caracteristicas:  \n Sistema Operativo: {0} \nMarca Disco: {1} \nServidor: {2} ", SO, MarcaDisco, Servicio);
        }
        
    }
    
    abstract public DiscoDuro Clone();
}


class ClaseConcreta1 : DiscoDuro
{
    public ClaseConcreta1(string So, string MarcaDisco) : base(So, MarcaDisco) { }

    override public DiscoDuro Clone()
    {
        // Copia superficial
        return (DiscoDuro)this.MemberwiseClone();
    }

}

class ClaseConcreta2 : DiscoDuro
{
    public ClaseConcreta2(string So, string MarcaDisco) : base(So, MarcaDisco) { }

    override public DiscoDuro Clone()
    {
        // Copia superficial
        return (DiscoDuro)this.MemberwiseClone();
    }

    internal void Instalar(string servidor)
    {
        __servicio = servidor;
    }
}

public class Client
{

    public static void Main()
    {

        Console.Write("Escoja un Sistema Operativo \n");
        Console.Write("1º) Windows \n" + "2º) Mac OS \n" + "3º) Unix" + "4º) Solaris \n" + "5º) FreeBSD \n" + "6º) OpenBSD \n" + "7º) Android \n" + "8º) Google Chrome OS \n");
        Console.Write("Escriba una opción: ");
        string So = Console.ReadLine();
        Console.Write("\n===========================================================================\n");
        Console.Write("Escoja una Marca de Disco Duro \n");
        Console.Write("1º) Seagate \n" + "2º)  Hitachi \n" + "3º) Western" + "4º) Digital \n" + "5º) Toshiba \n" + "6º) Samsung \n");
        Console.Write("Escriba una opción: ");
        string MarcaDisco = Console.ReadLine();

        Console.Write("\n===========================================================================\n");



        ClaseConcreta1 p1 = new ClaseConcreta1(So, MarcaDisco);
        ClaseConcreta1 c1 = (ClaseConcreta1)p1.Clone();
        c1.Imprimir();

        Console.Write("Desea crear una máquina de prueba a partir de la imagen clonada.\n");
        Console.Write("Escoja una opción:  1) Si o 2) No \n Por favor digite el numero. \n ");
        int instalar = int.Parse(Console.ReadLine());

        if (instalar == 1)
        {
            Console.Write("Escoja una Tipo de Servidor \n");
            Console.Write("1º) Servidor de base de datos \n" + "2º)  Servidor de Aplicaciones \n" + "3º) Servidor Web \n");
            Console.Write("Escriba una opción: ");
            string Servidor = Console.ReadLine();
            ClaseConcreta2 p2 = new ClaseConcreta2(So, MarcaDisco);
            ClaseConcreta2 c2 = (ClaseConcreta2)p2.Clone();
            c2.Instalar(Servidor);
            c2.Imprimir();
        }

        Console.Write("\n===========================================================================\n");
        Console.WriteLine("Gracias por usar nuestros servicios");

        Console.ReadKey();
    }
}


