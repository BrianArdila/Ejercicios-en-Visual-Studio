using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appEvalFinal_Brian_Ardila
{
    class Program : Persona
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-----------------------------------------------------------------");
            Console.WriteLine("Programacion 2 - Ing.Software");
            Console.WriteLine("-----------------------------------------------------------------");
            Console.WriteLine("Codigo: 16372071");
            Console.WriteLine("Nombre: Brian Ardila");
            Console.WriteLine("-----------------------------------------------------------------");
            Console.WriteLine("-----------------------------------------------------------------");
            
            SeleccionarInicio();



            Console.WriteLine("Para cerrar el programa presione cual quier tecla ..........");
            Console.ReadKey();
        }
        
        public static void SeleccionarInicio()
        {

            Console.WriteLine("Seleccione tipo de arranque");
            Console.WriteLine("Escriba 1 para iniciar con DatosPrevios o 2 para iniciar con Ingresando Datos");
            string leer = Console.ReadLine();
            int Selec = int.Parse(leer);
            switch (Selec)
            {
                //Inicia con datos precargados
                case 1:
                    if (Selec == 1)
                    {
                        //Datos Precargados
                        List<Asignatura> EstudianteList = new List<Asignatura>();
                        List<Asignatura> EstudianteList1 = new List<Asignatura>();
                        List<Asignatura> EstudianteList2 = new List<Asignatura>();
                        List<Asignatura> EstudianteList3 = new List<Asignatura>();
                        #region Primaria
                        Estudiante estudiante = new EstudiantePrimaria();
                        #region add estudiante

                        #region add list
                        EstudianteList.Add(new Asignatura() { Codigo = 102, Nombre = "Sociales", Nota = 1.2m });
                        EstudianteList.Add(new Asignatura() { Codigo = 103, Nombre = "Fisica", Nota = 2.0m });
                        EstudianteList.Add(new Asignatura() { Codigo = 104, Nombre = "Ingles", Nota = 0.5m });
                        #endregion
                        estudiante.Add(DateTime.Parse("30/8/2004"), "Brian", "Ardila", 11, 1, EstudianteList);

                        #region add list
                        EstudianteList1.Add(new Asignatura() { Codigo = 102, Nombre = "Sociales", Nota = 1.2m });
                        EstudianteList1.Add(new Asignatura() { Codigo = 103, Nombre = "Fisica", Nota = 3.5m });
                        EstudianteList1.Add(new Asignatura() { Codigo = 104, Nombre = "Ingles", Nota = 4.5m });
                        #endregion
                        estudiante.Add(DateTime.Parse("25/2/2005"), "Serafin", "Perez", 11, 2, EstudianteList1);

                        #region add list
                        EstudianteList2.Add(new Asignatura() { Codigo = 102, Nombre = "Sociales", Nota = 4m });
                        EstudianteList2.Add(new Asignatura() { Codigo = 103, Nombre = "Fisica", Nota = 3.565m });
                        EstudianteList2.Add(new Asignatura() { Codigo = 104, Nombre = "Ingles", Nota = 2.9m });
                        #endregion
                        estudiante.Add(DateTime.Parse("4/9/2005"), "Omaira", "Gonzales", 11, 5, EstudianteList2);

                        #region add list
                        EstudianteList3.Add(new Asignatura() { Codigo = 102, Nombre = "Sociales", Nota = 5m });
                        EstudianteList3.Add(new Asignatura() { Codigo = 103, Nombre = "Fisica", Nota = 3.8m });
                        EstudianteList3.Add(new Asignatura() { Codigo = 104, Nombre = "Ingles", Nota = 0.5m });
                        #endregion
                        estudiante.Add(DateTime.Parse("15/12/2004"), "Giovanny", "Smit", 11, 3, EstudianteList3);
                        #endregion
                        estudiante.Imprimir(); 
                        #endregion
                        #region Bachiderato
                        Estudiante estudiante2 = new EstudianteBachillerato();
                        #region add estudiante

                        #region add list
                        EstudianteList.Add(new Asignatura() { Codigo = 102, Nombre = "Sociales", Nota = 4.2m });
                        EstudianteList.Add(new Asignatura() { Codigo = 103, Nombre = "Fisica", Nota = 3.0m });
                        EstudianteList.Add(new Asignatura() { Codigo = 104, Nombre = "Ingles", Nota = 2.5m });
                        #endregion
                        estudiante2.Add(DateTime.Parse("30/8/2004"), "Brian", "Ardila", 11, 1, EstudianteList);

                        #region add list
                        EstudianteList1.Add(new Asignatura() { Codigo = 102, Nombre = "Sociales", Nota = 1.2m });
                        EstudianteList1.Add(new Asignatura() { Codigo = 103, Nombre = "Fisica", Nota = 3.5m });
                        EstudianteList1.Add(new Asignatura() { Codigo = 104, Nombre = "Ingles", Nota = 4.5m });
                        #endregion
                        estudiante2.Add(DateTime.Parse("25/2/2005"), "Serafin", "Perez", 11, 2, EstudianteList1);

                        #region add list
                        EstudianteList2.Add(new Asignatura() { Codigo = 102, Nombre = "Sociales", Nota = 4m });
                        EstudianteList2.Add(new Asignatura() { Codigo = 103, Nombre = "Fisica", Nota = 3.565m });
                        EstudianteList2.Add(new Asignatura() { Codigo = 104, Nombre = "Ingles", Nota = 2.9m });
                        #endregion
                        estudiante2.Add(DateTime.Parse("4/9/2005"), "Omaira", "Gonzales", 11, 5, EstudianteList2);

                        #region add list
                        EstudianteList3.Add(new Asignatura() { Codigo = 102, Nombre = "Sociales", Nota = 5m });
                        EstudianteList3.Add(new Asignatura() { Codigo = 103, Nombre = "Fisica", Nota = 3.8m });
                        EstudianteList3.Add(new Asignatura() { Codigo = 104, Nombre = "Ingles", Nota = 3.5m });
                        #endregion
                        estudiante2.Add(DateTime.Parse("15/12/2004"), "Giovanny", "Smit", 11, 3, EstudianteList3);
                        #endregion
                        estudiante2.Imprimir();
                        #endregion
                    }
                    break;
                //Indica los parametros para que el usuario los ingrese
                case 2:
                    if (Selec == 2)
                    {
                        //DEtermina tipo de estudiante 
                       Console.WriteLine("Ingrese 1 para introducir estudiantes de primaria o Presione cual quier otro  numero  para introducir estudiantes de bachillerato : ");
                        string introducir = Console.ReadLine();
                        int Introducir = int.Parse(introducir);
                        if (Introducir == 1)
                        {

                                //Determina la cantidad de estudiantes a ingresar
                                Console.WriteLine("Escriba el numero de estudiantes a ingresar : ");
                                string Nestudiantes = Console.ReadLine();
                                int Ingresar = int.Parse(Nestudiantes);
                            List<Asignatura> EstudianteList = new List<Asignatura>();
                            Estudiante estudiante = new EstudiantePrimaria();
                            //Ingresa un nuevo estudiante la cantidad determinada por el ususario
                            for (int i = 0; i <= Ingresar - 1; i++)
                           {
                                    
                                // ingresar datos estudiante
                                Console.WriteLine("Escriba el Nombre del estudiante: ");
                                string name = Console.ReadLine();
                                Console.WriteLine("Escriba el Apellido del estudiante: ");
                                string Apellido = Console.ReadLine();
                                Console.WriteLine("Escriba el Grado del estudiante: ");
                                string Gestudiante = Console.ReadLine();
                                int Grado = int.Parse(Gestudiante);
                                Console.WriteLine("Escriba el Grupo del estudiante: ");
                                string Grupo = Console.ReadLine();
                                int grupo = int.Parse(Grupo);
                                Console.WriteLine("Escriba la fecha de nacimiento del estudiante(DD/MM/YY): ");
                                string Pestudiante = Console.ReadLine();
                                DateTime Fecha = DateTime.Parse(Pestudiante);
                                #region LLenar lista
                                //cantidad de asignaturas
                                Console.WriteLine("Escriba el numero de Asignaturas a ingresar: ");
                                string numeroAsig = Console.ReadLine();
                                int NumeroAsig = int.Parse(numeroAsig);
                                for (int p = 0; p <= NumeroAsig - 1; p++)
                                {
                                    // ingresa datos lista asignatura
                                    Console.WriteLine("Escriba el Codigo del la Asignatura: ");
                                    string Codigo = Console.ReadLine();
                                    int codigo = int.Parse(Codigo);
                                    Console.WriteLine("Escriba el nombre de la Asignatura: ");
                                    string Nasignatura = Console.ReadLine();
                                    Console.WriteLine("Escriba la nota del estudiante : ");
                                    string Nota = Console.ReadLine();
                                    decimal nota = decimal.Parse(Nota);
                                    #region add list
                                    EstudianteList.Add(new Asignatura() { Codigo = codigo, Nombre = Nasignatura, Nota = nota });
                                    #endregion
                                    Console.WriteLine("................................................................");
                                }
                                #endregion
                                estudiante.Add(Fecha, name, Apellido, Grado, grupo, EstudianteList);
                                Console.WriteLine("==========================================");
                            }

                            estudiante.Imprimir();
                        }
                       else
                       {
                            //Determina la cantidad de estudiantes a ingresar
                            Console.WriteLine("Escriba el numero de estudiantes a ingresar : ");
                            string Nestudiantes = Console.ReadLine();
                            int Ingresar = int.Parse(Nestudiantes);
                            List<Asignatura> EstudianteList = new List<Asignatura>();
                            Estudiante estudiante = new EstudiantePrimaria();
                            //Ingresa un nuevo estudiante la cantidad determinada por el ususario
                            for (int i = 0; i <= Ingresar - 1; i++)
                            {

                                // ingresar datos estudiante
                                Console.WriteLine("Escriba el Nombre del estudiante: ");
                                string name = Console.ReadLine();
                                Console.WriteLine("Escriba el Apellido del estudiante: ");
                                string Apellido = Console.ReadLine();
                                Console.WriteLine("Escriba el Grado del estudiante: ");
                                string Gestudiante = Console.ReadLine();
                                int Grado = int.Parse(Gestudiante);
                                Console.WriteLine("Escriba el Grupo del estudiante: ");
                                string Grupo = Console.ReadLine();
                                int grupo = int.Parse(Grupo);
                                Console.WriteLine("Escriba la fecha de nacimiento del estudiante(DD/MM/YY): ");
                                string Pestudiante = Console.ReadLine();
                                DateTime Fecha = DateTime.Parse(Pestudiante);
                                #region LLenar lista
                                //cantidad de asignaturas
                                Console.WriteLine("Escriba el numero de Asignaturas a ingresar: ");
                                string numeroAsig = Console.ReadLine();
                                int NumeroAsig = int.Parse(numeroAsig);
                                for (int p = 0; p <= NumeroAsig - 1; p++)
                                {
                                    // ingresa datos lista asignatura
                                    Console.WriteLine("Escriba el Codigo del la Asignatura: ");
                                    string Codigo = Console.ReadLine();
                                    int codigo = int.Parse(Codigo);
                                    Console.WriteLine("Escriba el nombre de la Asignatura: ");
                                    string Nasignatura = Console.ReadLine();
                                    Console.WriteLine("Escriba la nota del estudiante: ");
                                    string Nota = Console.ReadLine();
                                    decimal nota = decimal.Parse(Nota);
                                    #region add list
                                    EstudianteList.Add(new Asignatura() { Codigo = codigo, Nombre = Nasignatura, Nota = nota });
                                    #endregion
                                    Console.WriteLine("................................................................");
                                }
                                #endregion
                                estudiante.Add(Fecha, name, Apellido, Grado, grupo, EstudianteList);
                                Console.WriteLine("==========================================");
                            }

                            estudiante.Imprimir();
                        }

                    }
                    break;
            }
                 
        }
    }


}

