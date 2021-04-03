using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyectofinal
{
    //----------------------------------------------------------------------------------
    /// CONSTRUCCION E INTEGRACION DE SOFTWARE
    //----------------------------------------------------------------------------------
    // PATRON DE DISEÑO ITERATOR
    // Brian Ardila Codigo: 16372071 Ing. Softwarw
    // UNIVERSIDAD DE SANTANDER
    //----------------------------------------------------------------------------------
    
    public class Program
    {
        
        static void Main(string[] args)
        {
            ListaComponente listaComponente = new ListaComponente("", "", "", "", 0);
            Program program = new Program();
            Console.WriteLine("======================================================================= ");
            Console.WriteLine("======================== Bienvenido a CompuMax ==================== ");
            Console.WriteLine("======================================================================= ");
            Console.WriteLine("A continuación se cargara un computador por favor escoja los componentes.");
            Console.WriteLine("======================================================================= ");

            program.IngresarComponentes();

            Console.WriteLine("Presione cualquier tecla para salir de la aplicación");
            Console.ReadKey();

        }

        public static string Elemento { get; set; }
        public static string Marca { get; set; }
        public static string Modelo { get; set; }
        public static string Puerto { get; set; }
        public static int Precio { get; set; }
        /// <summary>
        /// Este modulo es el menu general de la app donde se podra agregar, eliminar, etc
        /// </summary>
        public void IngresarComponentes()
        {
            ListaComponente listaComponente = new ListaComponente(Elemento, Marca, Modelo, Puerto, Precio);
            Program program = new Program();
            bool salir = true;
            // Pre carga de la información disponible para la venta 
            String[,] Perifericoentrada = new String[6, 5]
                         {
                                { "Teclado", "Logitech", "K220","USB", "600" },
                                {"Teclado", "Genius", "Sk660","USB", "6000" },
                                {"Ratón", "Logitech", "L22","USB", "100" },
                                {"Ratón", "Genius", "PO66","USB", "600" },
                                {"Tableta grafica", "Ugee", "M708","VGA", "1000" },
                                {"Tableta grafica", "Huion", "Wacom","VGA", "1500" }

                         };
            String[,] Perifericosalida = new String[5, 5]
                        {
                            { "Pantalla", "Lenovo", "K2W0","HDMI", "12000" },
                            {"Pantalla", "Lino", "ER660","HDMI", "3000" },
                            {"Impresora", "HP", "SS59","USB", "1000" },
                            {"Impresora", "Acer", "G56","USB", "60000" },
                            {"Impresora láser", "Jgee", "Amd","USB", "1000" }

                        };
            String[,] procesador = new String[2, 5]
             {
                                {"Procesador", "Amd", "A8 3360 9na","zócalo ALG1366","419000" },
                                { "Procesador","Intel Core","I5 9400f 9na","zócalo LGA1366" ,"519000" }

             };
            //Menu
            do {
                Console.WriteLine("======================================================================= ");
                Console.WriteLine("======================== Componentes para la venta ==================== ");
                Console.WriteLine("======================================================================= ");
                Console.WriteLine($"== Presione 1 para agregar un elemento periférico de salida");
                Console.WriteLine($"== Presione 2 para agregar un elemento periférico de entrada");
                Console.WriteLine($"== Presione 3 para agregar un elemento de unidad central");
                Console.WriteLine($"== Presione 4 para eliminar un elemento de la factura");
                Console.WriteLine($"== Presione 5 para Visualisar su factura");
                Console.WriteLine($"== Presione 6 para Salir");
                Console.WriteLine("======================================================================= ");
                Console.WriteLine($"Escoja una opción:");
                int eleccion = Int32.Parse(Console.ReadLine());
                switch (eleccion)
                {
                    case 1:
                       
                        bool agregarotro = true;
                        do
                        {
                            program.Mostrar(Perifericosalida);

                            bool opcionincorrecta = true;
                            int decision;
                            do
                            {
                                Console.WriteLine("======================================================================= ");
                                Console.WriteLine($"Escoja una opción:");
                                decision = Int32.Parse(Console.ReadLine());
                                if (decision == 0 || decision == 1 || decision == 2 || decision == 3 || decision == 4 || decision == 5)
                                {
                                    opcionincorrecta = false;
                                }
                                else { Console.WriteLine("Opción Invalida"); }
                            } while (opcionincorrecta == true);

                            program.Buscar(Perifericosalida, decision);
                            var Pedido = new Elementosperiféricos(Elemento, Marca, Modelo, Puerto, Precio);
                            listaComponente.Agregar(Pedido);
                            Console.WriteLine("======================================================================= ");
                            Console.WriteLine($"== Presione 1 para ir al menu anterior");
                            Console.WriteLine($"== Presione cualquier tecla para agregar otro elemento");
                            Console.WriteLine("======================================================================= ");
                            Console.WriteLine($"Escoja una opción:");
                            int volver = Int32.Parse(Console.ReadLine());
                            if (volver == 1)
                            {
                                agregarotro = false;
                            }
                           
                        } while ( agregarotro == true);
                        
                        break;
                    case 2:
                        bool agregarotro1 = true;
                        do
                        {
                            program.Mostrar(Perifericoentrada);

                            bool opcionincorrecta = true;
                            int decision;
                            do
                            {
                                Console.WriteLine("======================================================================= ");
                                Console.WriteLine($"Escoja una opción:");
                                decision = Int32.Parse(Console.ReadLine());
                                if (decision == 0 || decision == 1 || decision == 2 || decision == 3 || decision == 4 || decision == 5)
                                {
                                    opcionincorrecta = false;
                                }
                                else { Console.WriteLine("Opción Invalida"); }
                            } while (opcionincorrecta == true);

                            program.Buscar(Perifericoentrada, decision);
                            var Pedido = new Elementosperiféricos(Elemento, Marca, Modelo, Puerto, Precio);
                            listaComponente.Agregar(Pedido);
                            Console.WriteLine("======================================================================= ");
                            Console.WriteLine($"== Presione 1 para ir al menu anterior");
                            Console.WriteLine($"== Presione cualquier tecla para agregar otro elemento");
                            Console.WriteLine("======================================================================= ");
                            Console.WriteLine($"Escoja una opción:");
                            int volver = Int32.Parse(Console.ReadLine());
                            if (volver == 1)
                            {
                                agregarotro1 = false;
                            }

                        } while (agregarotro1 == true);
                        
                        break;
                    case 3:
                        
                        bool agregarotro2 = true;
                        do
                        {
                            program.Mostrar(procesador);

                            bool opcionincorrecta = true;
                            int decision;
                            do
                            {
                                Console.WriteLine("======================================================================= ");
                                Console.WriteLine($"Escoja una opción:");
                                decision = Int32.Parse(Console.ReadLine());
                                if (decision == 0 || decision == 1 || decision == 2 || decision == 3 || decision == 4 || decision == 5)
                                {
                                    opcionincorrecta = false;
                                }
                                else { Console.WriteLine("Opción Invalida"); }
                            } while (opcionincorrecta == true);

                            program.Buscar(procesador, decision);
                            var Pedido = new Elementosperiféricos(Elemento, Marca, Modelo, Puerto, Precio);
                            listaComponente.Agregar(Pedido);
                            Console.WriteLine("======================================================================= ");
                            Console.WriteLine($"== Presione 1 para ir al menu anterior");
                            Console.WriteLine($"== Presione cualquier tecla para agregar otro elemento");
                            Console.WriteLine("======================================================================= ");
                            Console.WriteLine($"Escoja una opción:");
                            int volver = Int32.Parse(Console.ReadLine());
                            if (volver == 1)
                            {
                                agregarotro2 = false;
                            }

                        } while (agregarotro2 == true);
                        
                        break;
                    case 4:
                        bool eliminarotro = true;
                        do
                        {
                            Console.WriteLine("======================================================================= ");
                            Console.WriteLine($"== Para poder eliminar un item de la factura, por favor escriba el elemento y su modelo");
                            Console.WriteLine("======================================================================= ");
                            Console.WriteLine($"Escriba el elemento a eliminar");
                            string BuscarElemnto = Console.ReadLine();
                            Console.WriteLine($"Escriba el modelo del elemento a eliminar");
                            string BuscarModelo = Console.ReadLine();

                            for (int fila = 0; fila < Perifericoentrada.GetLength(0); fila++)
                            {
                                if (BuscarElemnto == Perifericoentrada[fila, 0] && BuscarModelo == Perifericoentrada[fila, 2] )
                                {
                                Elemento = Perifericoentrada[fila, 0];
                                Marca = Perifericoentrada[fila, 1];
                                Modelo = Perifericoentrada[fila, 2];
                                Puerto = Perifericoentrada[fila, 3];
                                Precio = Int32.Parse(Perifericoentrada[fila, 4]);
                                break;
                                }
                            }
                            for (int fila = 0; fila < Perifericosalida.GetLength(0); fila++)
                            {
                                if (BuscarElemnto == Perifericosalida[fila, 0] && BuscarModelo == Perifericosalida[fila, 2])
                                {
                                    Elemento = Perifericosalida[fila, 0];
                                    Marca = Perifericosalida[fila, 1];
                                    Modelo = Perifericosalida[fila, 2];
                                    Puerto = Perifericosalida[fila, 3];
                                    Precio = Int32.Parse(Perifericosalida[fila, 4]);
                                    break;
                                }
                            }
                            for (int fila = 0; fila < procesador.GetLength(0); fila++)
                            {
                                if (BuscarElemnto == procesador[fila, 0] && BuscarModelo == procesador[fila, 2])
                                {
                                    Elemento = procesador[fila, 0];
                                    Marca = procesador[fila, 1];
                                    Modelo = procesador[fila, 2];
                                    Puerto = procesador[fila, 3];
                                    Precio = Int32.Parse(procesador[fila, 4]);
                                    break;
                                }
                            }
                            var elementosaborrar = new Elementosperiféricos(Elemento, Marca, Modelo, Puerto, Precio);
                            listaComponente.Eliminar(elementosaborrar);
                            Console.WriteLine($"== el elemento {BuscarElemnto} con modelo {BuscarModelo} fue eliminado.");
                            Console.WriteLine("======================================================================= ");
                            Console.WriteLine($"== Presione 1 para ir al menu anterior");
                            Console.WriteLine($"== Presione cualquier tecla para Eliminar otro elemento");
                            Console.WriteLine("======================================================================= ");
                            Console.WriteLine($"Escoja una opción:");
                            int volver = Int32.Parse(Console.ReadLine());
                            if (volver == 1)
                            {
                                eliminarotro = false;
                            }

                        } while (eliminarotro == true);

                        break;
                    case 5:

                        Console.WriteLine("======================================================================= ");
                        Console.WriteLine("=============== Visualizar la lista de componentes ==================== ");
                        Console.WriteLine("======================================================================= ");
                        Console.WriteLine("======================================================================= ");
                        Console.WriteLine($"=========================================== Precio total es: {listaComponente.PrecioTotalLista()}");
                        Console.WriteLine($"Cantidad de componentes registrados es: {listaComponente.Contador()}");
                        Console.WriteLine("======================================================================= ");
                        Console.WriteLine($"== Presione 1 para confirmar y pagar su pedido");
                        Console.WriteLine($"== Presione cualquier tecla para ir al menu anterior");
                        Console.WriteLine("======================================================================= ");
                        Console.WriteLine($"Escoja una opción:");
                        int opcion = Int32.Parse(Console.ReadLine());
                        if (opcion == 1)
                        {
                            Console.WriteLine($"== Su pedido fue confirmado.");
                            Console.WriteLine($"== Por favor ingrese su targeta de credito.");
                            Console.WriteLine($"== Presione cualquier tecla para continuar");
                            string pago = Console.ReadLine();
                            Console.WriteLine($"== Su pago fue exitoso.");
                            salir = false;
                            Console.WriteLine($"== Gracias por comprar con nosotros.");
                        }
                       
                        break;
                    case 6:
                        
                            salir = false;
                        Console.WriteLine($"== Gracias por comprar con nosotros.");
                        break;
                    default:
                        Console.WriteLine("Opción Invalida");
                        break;
                }
            } while (salir == true);

          

        }

       public void Mostrar(String[,] Array)
        {
            Console.WriteLine("\n============= Listado de componentes ==================== ");
            Console.WriteLine("======================================================================= ");
            Console.WriteLine("Acontinuación se mostarar los elementos disponibles: ");

            for (int fila = 0; fila < Array.GetLength(0); fila++)
            {
                Console.WriteLine($"\nEscriba {fila} para escojer: ");
                Console.Write("Elemento: " + Array[fila, 0] + " Marca: " +Array[fila, 1] + " Modelo: " +Array[fila, 2] + " Puerto: " + Array[fila, 3] + " Precio: " + Array[fila, 4]);
                Console.WriteLine();
            }
            
        }


        public void Buscar(String[,] Array, int Nfila)
        {

            for (int fila = 0; fila < Array.GetLength(0); fila++)
            {
                if (fila == Nfila)
                {
                    Elemento = Array[fila, 0];
                    Marca = Array[fila, 1];
                    Modelo = Array[fila, 2];
                    Puerto = Array[fila, 3];
                    Precio = Int32.Parse(Array[fila, 4]);
                    break;
                }
            }

        }

        public IComponente IComponente
        {
            get => default(IComponente);
            set
            {
            }
        }
    }
    /// <summary>
    ///  Operaciones mínimas que serán utilizadas
    /// </summary>
    public abstract class IComponente
    {
        public  string Elemento { get; set; }
        public  string Marca { get; set; }
        public  string Modelo { get; set; }
        public  string Puerto { get; set; }
        public  int Precio { get; set; }
        // Constructor con los componentes precargados
        public IComponente(string elemento, string marca, string modelo, string puerto, int precio)
        {
            this.Elemento = elemento;
            this.Marca = marca;
            this.Modelo = modelo;
            this.Puerto = puerto;
            this.Precio = precio;
        }
        // Los metodos que vamos a heredar
        public abstract int Contador();
        public abstract int PrecioTotalLista();
    }
    
    /// <summary>
    /// Aqui estan todos los metodos basico Agregar,Eliminar,Buscar y los heredados
    /// </summary>
    public class ListaComponente : IComponente
    {
        private List<IComponente> factura = new List<IComponente>();
        public ListaComponente(string elemento, string marca, string modelo, string puerto, int precio) : base(elemento, marca, modelo, puerto, precio) { }
        //Agregarmos datos a la lista dinamica
        public void Agregar(IComponente componente)
        {
            factura.Add(componente);
           
        }
        //Eliminar datos de la lista dinamica
        public void Eliminar(IComponente componente)
        {
            List<IComponente> quitaritem = new List<IComponente>();
            foreach (var c in factura)
            {
                if (c.Modelo == componente.Modelo)
                {
                    quitaritem.Add(c);
                    break;
                }
            }

            foreach (var item in quitaritem)
            {
                factura.Remove(item);
            }
            
        }
        //Buscar datos de la lista dinamica
        public void Buscar(IComponente componente)
        {
            List<IComponente> quitaritem = new List<IComponente>();
            foreach (var c in factura)
            {
                if (c.Modelo == componente.Modelo)
                {
                    quitaritem.Add(c);
                    Console.WriteLine($"== {c.Elemento} \t {c.Marca} \t {c.Modelo} \t {c.Puerto} \t {c.Precio} ");
                    break;
                }
            }
        }
        //Contar datos de la lista dinamica
        public override int Contador()
        {
            int total = 0;
                foreach (var precio in factura)
                {
                    total += precio.Contador();
                }
            return total;
        }
        //Sumar todos los precios de la lista dinamica
        public override int PrecioTotalLista()
        {
            int total = 0;
                foreach (var precio in factura)
                {
                    total += precio.PrecioTotalLista();
                }
            return total;
        }
    }

    //clases concretas simples

    /// <summary>
    /// representa la parte más simple o pequeña de toda la estructura
    /// </summary>
    public class Elementosperiféricos : IComponente
    {
        public Elementosperiféricos(string elemento, string marca, string modelo, string puerto, int precio) : base(elemento, marca, modelo, puerto, precio)
        { }
        int contar = 0;
        public override int Contador()
        {
            contar = 1;
            return contar;
        }

        public override int PrecioTotalLista()
        {
            Console.WriteLine($"== {Elemento} \t {Marca} \t {Modelo} \t {Puerto} \t {Precio} ");
            return Precio;
        }
    }

}

