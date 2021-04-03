using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace appCalculadoraTexto_Brian_Ardila
{
    public class Client
    {
        public static void Main(string[] args)
        {
            
            string operador = "";
            string continuar;
            //Pedimos los numeros y la operacion a realizar
            do { 
                Console.WriteLine("Escriba en letras un numero a operar \n");
                string valor1 = Console.ReadLine();

                //Aqui mostraremos los mensajes que apareceran en nuestra consola igual que el menu de seleccion.
                Console.WriteLine("\n =========================================================");
                Console.WriteLine("Eliga un operador\n");
                Console.WriteLine("\nEscriba suma para sumar");
                Console.WriteLine("\nEscriba resta para restar");
                Console.WriteLine("\nEscriba multiplica para multiplicar");
                Console.WriteLine("\nEscriba divide para dividir");
                Console.Write("\n Eliga Una Opcion: ");
                operador = Console.ReadLine();

                Console.WriteLine("\n =========================================================");


                Console.WriteLine("Escriba en letras un numero a operar \n");
                string valor2 = Console.ReadLine();

                Console.WriteLine("\n =========================================================");
                Console.WriteLine("\n == Operación:  {0} {1} {2}     ==", valor1, operador, valor2);
                Console.WriteLine("\n =========================================================");

                //Creamos el arbol de expreciones y contexto
                ArrayList list = new ArrayList();
                Context context = new Context();
            // add Los argumentos (Los operadoes y numeros)
                list.Add(new NumericExpression(valor1));
                list.Add(new OperationExpression(operador));
                list.Add(new NumericExpression(valor2));
            //Interpreta cada exprecion
                foreach (AbstractExpression exp in list)
                {
                    exp.Interpret(context);
                }

                //Mostramos el resultado
                Console.WriteLine("Respuesta: {0}", context.ObtenerResultado());

                Console.WriteLine("\n =========================================================");

                Console.WriteLine("\n¿Desea Continuar? s/n: ");
                continuar = Console.ReadLine();
                Console.WriteLine("\n =========================================================");
            }
            while (continuar == "S" || continuar == "s");

            Console.ReadKey();
        }
    }
    /// <summary>
    /// Gestionamos las entradas y salidad del sistema
    /// </summary>
    class Context
    {
        private string sigOperador = "";
        private double Operador = 0;
        private double Resultado = 0;
        // Validamos de letras a numeros
        public int ObtenerNumero(string numero)
        {
            if (numero == "cero")
            {
                return 0;
            }
            else if (numero == "uno")
            {
                return 1;
            }
            else if (numero == "dos")
            {
                return 2;
            }
            else if (numero == "tres")
            {
                return 3;
            }
            else if (numero == "cuatro")
            {
                return 4;
            }
            else if (numero == "cinco")
            {
                return 5;
            }
            else if (numero == "seis")
            {
                return 6;
            }
            else if (numero == "siete")
            {
                return 7;
            }
            else if (numero == "ocho")
            {
                return 8;
            }
            else if (numero == "nueve")
            {
                return 9;
            }
            else
            {
                return -1;
            }

        }

        public void ConjuntoOperador(int operador)
        {
            this.Operador = operador;

        }
        //Validamos de letras a operador
        public void ObtenerOperador(string operador)
        {
            if (operador == "suma")
            {
                this.sigOperador = "+";
            }
            else if (operador == "resta")
            {
                this.sigOperador = "-";
            }
            else if (operador == "multiplica")
            {
                this.sigOperador = "*";
            }
            else if (operador == "divide")
            {
                this.sigOperador = "/";
            }

        }
        //Efectua la operación o calculo
        public void Calculo()
        {
            if (this.sigOperador == "-")
            {
                if (this.Resultado == 0)
                {
                    this.Resultado = Operador;
                }
                else
                {
                    this.Resultado -= Operador;
                }

            }
            else if (this.sigOperador == "+")
            {
                this.Resultado += Operador;
            }
            else if (this.sigOperador == "*")
            {
                if (this.Resultado == 0)
                {
                    this.Resultado = Operador;
                }
                else
                {
                    this.Resultado *= Operador;
                }
            }
            else if (this.sigOperador == "/")
            {
                if (this.Resultado == 0)
                {
                    this.Resultado = Operador;
                }
                else
                {
                    this.Resultado /= Operador;
                }
            }
        }
        //Return value
        public double ObtenerResultado()
        {
            return this.Resultado;
        }

    }
    //Definimos la interfaz
    abstract class AbstractExpression
    {
        public abstract void Interpret(Context context);
    }
    //Esta propiedad nos define los operadores (sumar,restar,multiplicar,dividir)
    class OperationExpression : AbstractExpression
    {
        private string operacion;
        
        public OperationExpression(String token)
        {
            this.operacion = token;
        }

        public override void Interpret(Context context)
        {
            context.ObtenerOperador(this.operacion);
            context.Calculo();
        }

    }
    //Esta propiedad define los operadores numericos (Los numeros ha sumar o etc)
    class NumericExpression : AbstractExpression
    {
        private string valor;

        public NumericExpression(String token)
        {
            this.valor = token;
        }

        public override void Interpret(Context context)
        {
            context.ConjuntoOperador(context.ObtenerNumero(this.valor));
            context.Calculo();
        }
    }


}