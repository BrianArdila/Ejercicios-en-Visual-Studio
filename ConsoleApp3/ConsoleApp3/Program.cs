using System;
using System.Collections.Generic;

namespace ObjectPooling
{
    class Estante
    {
        // Maximum objects allowed!  
        private static int _PoolMaxSize = 3;
        // My Collection Pool  
        private static readonly Queue<int> objPool = new Queue<int>(_PoolMaxSize);

        internal Zapato Zapato
        {
            get => default(Zapato);
            set
            {
            }
        }

        /// <summary>
        /// Esta propiedad nos crea o devuelve el zapato de talla X
        /// </summary>
        /// <param name="addZapato"></param>
        /// <returns></returns>
        public Zapato GetZapato(int addZapato)
        {
            Zapato oZapato;
            // check from the collection pool. If exists return object else create new  
            if (Zapato.Counter >= _PoolMaxSize && objPool.Count > 0)
            {
                // Retrieve from pool  
                oZapato = RetrieveFromPool(addZapato);
            }
            else
            {
                // Creates a new  
                oZapato = GetNewZapato(addZapato);
            }

            return oZapato;

        }

        /// <summary>
        /// Creates a new  Zapato
        /// </summary>
        /// <param name="addZ"></param>
        /// <returns></returns>
        private Zapato GetNewZapato(int addTalla)
        {
            Zapato oZap = new Zapato();
            bool Hayzapatoinpool = false;
            // check from the collection pool. 
            foreach (int TallainPool in objPool)
                {
                    if (TallainPool == addTalla)
                    {
                        // Retrieve from pool  
                        RetrieveFromPool(addTalla);
                        Hayzapatoinpool = true;
                        Zapato.Counter--;
                    }
                }

            if (Hayzapatoinpool == false)
            {
                // Creates a new  
                oZap.Talla = addTalla;
                objPool.Enqueue(oZap.Talla);
                Console.WriteLine("Construllendo su Zapato talla:{0} ", addTalla);

            }
               
            return oZap;
        }
        /// <summary>
        /// Devuelve el zapato de talla X
        /// </summary>
        /// <param name="addTalla"></param>
        /// <returns></returns>
        protected Zapato RetrieveFromPool(int addTalla)
        {
            Zapato oZap = new Zapato();
            // if there is any objects in my collection  
            if (objPool.Count > 0)
            {
                foreach (int TallainPool in objPool)
                {
                    if (TallainPool == addTalla)
                    {
                        Console.WriteLine("Recoja su  zapato con la talla:{0} ", addTalla);
                        Zapato.Counter--;
                    }
                }

            }
            else
            {
                // return a new object  
                oZap = new Zapato();
            }
            return oZap;
        }
    }

    class Zapato
    {
        public static int Counter = 0;
        public Zapato()
        {
            ++Counter;
        }
        private int _Talla;
        public int Talla
        {
            get
            {
                return _Talla;
            }
            set
            {
                _Talla = value;
            }
        }
    }
    public class Program
    {
        internal Estante Estante
        {
            get => default(Estante);
            set
            {
            }
        }

        internal Zapato Zapato
        {
            get => default(Zapato);
            set
            {
            }
        }

        public static void Main()
        {
            Estante PedirZapato = new Estante();

            Console.WriteLine("Para poder construir su zapato debe ingresar la talla de este");
            int tallaShoe = int.Parse(Console.ReadLine());
            PedirZapato.GetZapato(tallaShoe);
            Console.WriteLine("Para poder darle su zapato debe ingresar la talla de este");
            int pedirZapato = int.Parse(Console.ReadLine());
            PedirZapato.GetZapato(pedirZapato);

            Console.ReadKey();


        }
    }

}
