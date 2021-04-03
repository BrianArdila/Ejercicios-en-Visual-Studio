using System;
using System.Collections.Generic;

namespace Taller_2___Patrones_de_Diseño
{
    class Program
    {
        public CatalogodePersonajes CatalogodePersonajes
        {
            get => default(CatalogodePersonajes);
            set
            {
            }
        }

        static void Main(string[] args)
        {
            Dictionary<string, PrototypePersonaje> PersonajesJugables = new Dictionary<string, PrototypePersonaje>();
            CatalogodePersonajes catalogodePersonajes = new CatalogodePersonajes();
            Console.WriteLine("==================================================================");
            Console.WriteLine("============ Cargando personajes predefinidos ======================");
            Console.WriteLine("==================================================================");
            catalogodePersonajes["EvilLord"] = new Superheroe("superheroe", "Imagen", "1.72 metros", "67 kg", "120 IQ", "Super Fuerza");
            catalogodePersonajes["DragonLord"] = new Villano(" villano", "NN", "15.72 metros", "500 kg", "900 IQ", "Aliento de Fuego");
            catalogodePersonajes["Pandora"] = new Soldado("guerrero", "Imagen", "2 metros", "77 kg", "200 IQ", "Uso de Multiples Armas");
            catalogodePersonajes["Cositus"] = new Guerillero("soldado", "NN", "1.9 metros", "79 kg", "120 IQ", "Manejo de Armas malditas");
           
            bool salir = true;
            do
            {
                Console.WriteLine("==================================================================");
                Console.WriteLine("=====================Catalogo de Personajes=======================");
                Console.WriteLine("==================================================================");
                Console.WriteLine("== Presione 1 Para agregar un personaje nuevo");
                Console.WriteLine("== Presione 2 Para buscar un personaje creado");
                Console.WriteLine("== Presione 3 Para eliminar un personaje nuevo");
                Console.WriteLine("== Presione 4 Para seleccionar un personaje previamente creado");
                Console.WriteLine("== Presione 5 Para Salir");
                Console.WriteLine("==================================================================");
                int Eleccion = Int32.Parse(Console.ReadLine());
                switch (Eleccion)
                {
                    case 1:
                        bool repetir = true;
                        do
                        {
                            Console.WriteLine("==================================================================");
                            Console.WriteLine("=====================Agregar  Personaje==========================");
                            Console.WriteLine("==================================================================");
                            Console.WriteLine("== Presione 1 Para agregar un superheroe");
                            Console.WriteLine("== Presione 2 Para agregar un villano");
                            Console.WriteLine("== Presione 3 Para agregar un guerillero");
                            Console.WriteLine("== Presione 4 Para agregar un soldado");
                            Console.WriteLine("==================================================================");
                            int choose = Int32.Parse(Console.ReadLine());
                            string nombre = "";
                            switch (choose)
                            {
                                case 1:
                                    Superheroe superheroe = catalogodePersonajes["EvilLord"].Clone() as Superheroe;
                                    Console.WriteLine("==================================================================");
                                    Console.WriteLine("== Ingrese un nombre");
                                    Console.WriteLine("==================================================================");
                                    nombre = Console.ReadLine();
                                    PersonajesJugables.Add(nombre, superheroe);
                                    Console.WriteLine("==================================================================");
                                    repetir = false;
                                    break;
                                case 2:
                                    Villano villano = catalogodePersonajes["DragonLord"].Clone() as Villano;
                                    Console.WriteLine("==================================================================");
                                    Console.WriteLine("== Ingrese un nombre");
                                    Console.WriteLine("==================================================================");
                                     nombre = Console.ReadLine();
                                    PersonajesJugables.Add(nombre, villano);
                                    repetir = false;
                                    break;
                                case 3:
                                    Guerillero guerillero = catalogodePersonajes["Pandora"].Clone() as Guerillero;
                                    Console.WriteLine("==================================================================");
                                    Console.WriteLine("== Ingrese un nombre");
                                    Console.WriteLine("==================================================================");
                                     nombre = Console.ReadLine();
                                    PersonajesJugables.Add(nombre, guerillero);
                                    repetir = false;
                                    break;
                                case 4:
                                    Soldado soldado = catalogodePersonajes["Cositus"].Clone() as Soldado;
                                    Console.WriteLine("==================================================================");
                                    Console.WriteLine("== Ingrese un nombre");
                                    Console.WriteLine("==================================================================");
                                     nombre = Console.ReadLine();
                                    PersonajesJugables.Add(nombre, soldado);
                                    repetir = false;
                                    break;
                                default:
                                    Console.WriteLine("Opción Invalida");
                                    break;
                            }
                        } while (repetir == true);
                        //salir = false;
                        Console.WriteLine("==================================================================");
                        Console.WriteLine("== Inicia el Juego");
                        break;
                    case 2:
                        Console.WriteLine("============================================================================");
                        Console.WriteLine("== Escriba el Nombre del personaje");
                        Console.WriteLine("============================================================================");

                        string Buscar = Console.ReadLine();

                        foreach (String key in PersonajesJugables.Keys)
                        {
                            if (key == Buscar)
                            {
                                foreach (var personaje in PersonajesJugables.Values)
                                {
                                    Console.WriteLine("Se encontro el personaje {0} Con las siguientes caracteristicas \n imagen: {1}  altura: {2} peso: {3} inteligencia: {4} habilidades: {5} Tipo de personaje: {6}", key, personaje.Imagen, personaje.Altura, personaje.Peso, personaje.Inteligencia, personaje.Habilidades, personaje.TipoPersonaje);
                                    break;
                                }
                            }
                        }

                        break;
                    case 3:
                        Console.WriteLine("============================================================================");
                        Console.WriteLine("== Escriba el Nombre del personaje");
                        Console.WriteLine("============================================================================");
                        string eliminar = Console.ReadLine();
                        foreach (String key in PersonajesJugables.Keys)
                        {
                            if (key == eliminar)
                            {
                                PersonajesJugables.Remove(eliminar);
                                Console.WriteLine("== Su personaje fue eliminado");
                                break;
                            }
                        }

                        break;
                    case 4:
                        Console.WriteLine("============================================================================");
                        Console.WriteLine("== Escriba el Nombre del personaje");
                        Console.WriteLine("============================================================================");
                        string Pj = Console.ReadLine();
                        foreach (String key in PersonajesJugables.Keys)
                        {
                            if (key == Pj)
                            {
                                Console.WriteLine("==================================================================");
                                Console.WriteLine("== Inicia el Juego");
                            }
                        }
                        break;
                    case 5:
                        salir = false;
                        break;
                    default:
                        Console.WriteLine("Opción Invalida");
                        break;
                }
            } while (salir == true);
            Console.WriteLine("Press any Key");
            Console.ReadKey();
        }

    }
    /// <summary>
    /// Prototype manager
    /// Aqui se implementa el CRUD
    /// </summary>
    public class CatalogodePersonajes
    {
        private Dictionary<string, PrototypePersonaje> ListPersonaje = new Dictionary<string, PrototypePersonaje>();

        public PrototypePersonaje this[string key]
        {
            get { return ListPersonaje[key]; }
            set { ListPersonaje.Add(key, value); }
        }

        public PrototypePersonaje PrototypePersonaje
        {
            get => default(PrototypePersonaje);
            set
            {
            }
        }

        public void EliminarPersonaje(string key)
        {
            ListPersonaje.Remove(key);
        }

        public void BuscarPersonaje(string keys)
        {
            foreach (String key in ListPersonaje.Keys)
            {
                if (key == keys)
                {
                    Console.WriteLine("Se encontro el personaje");
                };
            }

        }

    }
    /// <summary>
    /// Prototype
    /// </summary>
    public abstract class PrototypePersonaje
    {
        public string TipoPersonaje { get; set; }
        public string Imagen { get; set; }
        public string Altura { get; set; }
        public string Peso { get; set; }
        public string Inteligencia { get; set; }
        public string Habilidades { get; set; }

        public PrototypePersonaje(string tipoPersonaje, string imagen, string altura, string peso, string inteligencia, string habilidades)
        {
            TipoPersonaje = tipoPersonaje;
            Imagen = imagen;
            Altura = altura;
            Peso = peso;
            Inteligencia = inteligencia;
            Habilidades = habilidades;
        }

        abstract public PrototypePersonaje Clone();
    }
    /// <summary>
    /// The 'ConcretePrototype' class
    /// </summary>
    class Superheroe : PrototypePersonaje
    {
        public Superheroe(string tipoPersonaje, string imagen, string altura, string peso, string inteligencia, string habilidades) : base(tipoPersonaje, imagen, altura, peso, inteligencia, habilidades)
        {  }

        override public PrototypePersonaje Clone()
        {
            // Copia superficial
            return (PrototypePersonaje)this.MemberwiseClone();
        }
    }
    /// <summary>
    /// The 'ConcretePrototype' class
    /// </summary>
    class Villano : PrototypePersonaje
    {
        public Villano(string tipoPersonaje, string imagen, string altura, string peso, string inteligencia, string habilidades) : base(tipoPersonaje, imagen, altura, peso, inteligencia, habilidades) { }
        override public PrototypePersonaje Clone()
        {
            // Copia superficial
            return (PrototypePersonaje)this.MemberwiseClone();
        }
    }
    /// <summary>
    /// The 'ConcretePrototype' class
    /// </summary>
    class Soldado : PrototypePersonaje
    {
        public Soldado(string tipoPersonaje, string imagen, string altura, string peso, string inteligencia, string habilidades) : base(tipoPersonaje, imagen, altura, peso, inteligencia, habilidades) {    }
        override public PrototypePersonaje Clone()
        {
            // Copia superficial
            return (PrototypePersonaje)this.MemberwiseClone();
        }
    }
    /// <summary>
    /// The 'ConcretePrototype' class
    /// </summary>
    class Guerillero : PrototypePersonaje
    {
        public Guerillero(string tipoPersonaje, string imagen, string altura, string peso, string inteligencia, string habilidades) : base(tipoPersonaje, imagen, altura, peso, inteligencia, habilidades) {     }
        override public PrototypePersonaje Clone()
        {
            // Copia superficial
            return (PrototypePersonaje)this.MemberwiseClone();
        }
    }

}
