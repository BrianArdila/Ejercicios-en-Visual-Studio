
using System;
using System.Collections;
using System.Collections.Generic;

namespace ObjectPooling
{
    class Estante
    {
        // Maximum objects allowed!  
        private static int _PoolMaxSize = 2;
        // My Collection Pool  
        private static readonly Queue<int> objPool = new Queue<int>(_PoolMaxSize);

        public Zapato GetZapato(int addZapato)
        {
            Zapato oZapato = new Zapato();
            // check from the collection pool. If exists return object else create new  
            if (Zapato.Counter >= _PoolMaxSize && objPool.Count > 0 && oZapato.Talla == addZapato)
            {
                // Retrieve from pool  
                oZapato = RetrieveFromPool(addZapato);
            }
            else
            {
                oZapato = GetNewZapato(addZapato);
            }
            return oZapato;
        }
        private Zapato GetNewZapato(int ass)
        {
            // Creates a new employee  
            Zapato oEmp = new Zapato();
            oEmp.Talla = ass;
            objPool.Enqueue(oEmp.Talla);
            return oEmp;
        }
        protected Zapato RetrieveFromPool(int aff)
        {
            Zapato oEmp = new Zapato();
            // if there is any objects in my collection  
            if (objPool.Count > 0)
            {
                foreach (int number in objPool)
                {
                    if (number == aff)
                    {

                        Console.WriteLine(number);
                        Zapato.Counter--;
                    }
                }

            }
            else
            {
                // return a new object  
                oEmp = new Zapato();
            }
            return oEmp;
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
        public static void Main()
        {
            Estante PedirZapato = new Estante();
            Zapato myZapato = PedirZapato.GetZapato(35);
            myZapato = PedirZapato.GetZapato(35);

            Console.ReadKey();

        }
    }

}

