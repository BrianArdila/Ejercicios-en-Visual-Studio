using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appTaxi_POO_Brian_Ardila
{
    class Program
    {
        static void Main(string[] args)
        {
            Taxista[] DatosTaxiTurno = new Taxista[]
            {
                #region Taxi 1

		
                new Taxista{ Matricula="CWN111",
                                    Nombre ="Alvaro",
                                    Apellido ="Gutierrez",
                                    Documento ="147852369",
                                    Telefono ="6412369",
                                    Email ="alvaro_G@taxi.com",
                                    Estado =Empleado.TipoEstado.Activo,
                                    Turno = Taxista.TipoTurno.N_Uno
                },

                 new Taxista{Matricula="CWN1112",
                                    Nombre ="Alvaro2",
                                    Apellido ="Gutierrez2",
                                    Documento ="1478523692",
                                    Telefono ="64123692",
                                    Email ="alvaro_G2@taxi.com",
                                    Estado =Empleado.TipoEstado.Ninguno,
                                    Turno = Taxista.TipoTurno.N_Tres
                },

                  new Taxista{Matricula="CWN1110",
                                    Nombre ="Alvaro0",
                                    Apellido ="Gutierrez0",
                                    Documento ="1478523690",
                                    Telefono ="64123690",
                                    Email ="alvaro_G0@taxi.com",
                                    Estado =Empleado.TipoEstado.Inactivo,
                                    Turno = Taxista.TipoTurno.N_Dos
                }, 
	#endregion

               #region Taxi 2
		   new Taxista{Matricula="CWN1116",
                                    Nombre ="Alvaro6",
                                    Apellido ="Gutierrez6",
                                    Documento ="1478523696",
                                    Telefono ="64123696",
                                    Email ="alvaro_G6@taxi.com",
                                    Estado =Empleado.TipoEstado.Activo,
                                    Turno = Taxista.TipoTurno.N_Tres
                },

                 new Taxista{Matricula="CWN1117",
                                    Nombre ="Alvaro7",
                                    Apellido ="Gutierrez7",
                                    Documento ="1478523697",
                                    Telefono ="64123697",
                                    Email ="alvaro_G7@taxi.com",
                                    Estado =Empleado.TipoEstado.Inactivo,
                                    Turno = Taxista.TipoTurno.N_Uno
                },

                  new Taxista{Matricula="CWN1118",
                                    Nombre ="Alvaro8",
                                    Apellido ="Gutierrez8",
                                    Documento ="1478523698",
                                    Telefono ="64123698",
                                    Email ="alvaro_G8@taxi.com",
                                    Estado =Empleado.TipoEstado.Activo,
                                    Turno = Taxista.TipoTurno.N_Dos
                }, 
	#endregion

                #region Taxi 3
		new Taxista{Matricula="CWN1113",
                                    Nombre ="Alvaro3",
                                    Apellido ="Gutierrez3",
                                    Documento ="1478523693",
                                    Telefono ="64123693",
                                    Email ="alvaro_G3@taxi.com",
                                    Estado =Empleado.TipoEstado.Inactivo,
                                    Turno = Taxista.TipoTurno.N_Uno
                },

                 new Taxista{Matricula="CWN1114",
                                    Nombre ="Alvaro4",
                                    Apellido ="Gutierrez4",
                                    Documento ="1478523694",
                                    Telefono ="64123694",
                                    Email ="alvaro_G4@taxi.com",
                                    Estado =Empleado.TipoEstado.Activo,
                                    Turno = Taxista.TipoTurno.N_Dos
                },

                  new Taxista{Matricula="CWN11145",
                                    Nombre ="Alvaro5",
                                    Apellido ="Gutierrez5",
                                    Documento ="14785236945",
                                    Telefono ="641236945",
                                    Email ="alvaro_G5@taxi.com",
                                    Estado =Empleado.TipoEstado.Activo,
                                    Turno = Taxista.TipoTurno.N_Tres
                }, 
	#endregion
            };

            Console.WriteLine("<<<ejecucion del programa hecho en clase>>>");
            Console.WriteLine();
            CapturarProducidoTurno(DatosTaxiTurno);
            Console.WriteLine();
            Console.WriteLine();
            ImprimirDevengados(DatosTaxiTurno);

            Console.WriteLine("Precione cual quier tecla para finalisar");
            Console.ReadKey();

            
        }

        public static void CapturarProducidoTurno(Taxista[] DatosTaxiTurno)
        {
            for (int i=0; i< DatosTaxiTurno.Length;i ++ )
            {
                //muestra en pantalla los datos del conductor y pide ingresar el producido
                Console.WriteLine("Conductor "+ i+ "=" + " Documento: " + DatosTaxiTurno[i].Documento+" Telefono: "+ DatosTaxiTurno[i].Telefono+ DatosTaxiTurno[i].NombreCompleto() +" del taxi con placas:  "+ DatosTaxiTurno[i].Matricula + " con el Turno :"+DatosTaxiTurno[i].Turno + " Escriba el produciodo del dia: ");

                //comprueba que el valor ingresado sea mayor que cero
                bool TotalRecudado = false;
                decimal Producido = 0;
                do
                {

                    //trata de realizar la conversion del dato ingresado por el usuario.
                    //si el proceso de conversion es exitoso entonces la variable "entrada valida"
                    //toma el valor de "true" y la variable "producido" guarda el valor convertido.
                    TotalRecudado = decimal.TryParse(Console.ReadLine(), out Producido);
                }

                while (TotalRecudado == false);

                //guarda el valor producido por el taxi
                DatosTaxiTurno[i].Recaudado = Producido;
            };
            
        }
        
        public static void ImprimirDevengados(Taxista[] DatosTaxiTurno)
        {
            for (int i = 0; i < DatosTaxiTurno.Length; i++)
            {
                Console.WriteLine("El devengado de: " + DatosTaxiTurno[i].NombreCompleto() + " del taxi " + DatosTaxiTurno[i].Matricula + " del turno: " + DatosTaxiTurno[i].Turno + " es: "  + DatosTaxiTurno[i].CalcularDevengadoTurno().ToString("C"));

            };

        }
    }
}
