using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6appIterator_Brian_Ardila
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

    /// <summary>
    /// Define la clase abstracta Iterator con metodos de manejo de los datos
    /// </summary>
    public abstract class Iterator
    {
        public abstract object Frist();
        public abstract object isDone();
        public abstract object Next();
        public abstract object CurrentItem();

    }

    /// <summary>
    /// Define la clase abstracta Aggegate con el metodo creador
    /// </summary>
    public abstract class Aggregate
    {
        public abstract Iterator CreateIterator();
       
    }

    /// <summary>
    /// Implementa iterator y permite saber la posicion de lo que se agrega 
    /// </summary>
    public class ConcreteIterator : Iterator
    {
        private ConcreteAggregate  _agregate;
        private int _current = 0;
        //constructor
        public ConcreteIterator(ConcreteAggregate agregate)
        {
            this._agregate = agregate;
        }

        public override object CurrentItem()
        {
            return this._agregate[CurrentItem];
        }

        public override object Frist()
        {
            return this._agregate[0];
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public override object isDone()
        {
            throw new NotImplementedException();
        }

        public override object Next()
        {
            object itemReturn = null;
            if (_current < _agregate.Count - 1)
            {
                itemReturn = _agregate[++_current];
            }
        }
    }


    public  class ConcreteAggregate : Aggregate
    {
        

        public override Iterator CreateIterator()
        {
            throw new NotImplementedException();
        }
    }

}
