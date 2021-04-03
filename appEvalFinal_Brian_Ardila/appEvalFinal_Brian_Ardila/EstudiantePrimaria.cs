using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appEvalFinal_Brian_Ardila
{
    class EstudiantePrimaria : Estudiante
    {
        #region Atributos


        #endregion
        #region Propiedades


        #endregion
        #region Constructor
        public EstudiantePrimaria() { }

        public EstudiantePrimaria(DateTime myFechaNacimiento, string myNombre, string myApellido, int grado, int grupo) : base(myFechaNacimiento, myNombre, myApellido, grado, grupo)
        {
        }
        #endregion


        //Se crea el arreglo dinamico con longitud 0
        EstudiantePrimaria[] EstudiantesDePrimaria = new EstudiantePrimaria[0];

        EstudiantePrimaria[] EstudiantesAprovados = new EstudiantePrimaria[0];

        EstudiantePrimaria[] EstudiantesReprovados = new EstudiantePrimaria[0];

        public override void Add(DateTime fechanacimiento, string nombre, string apellido, int grado, int grupo, List<Asignatura> notasEstudiante)
        {
            EstudiantePrimaria primaria = new EstudiantePrimaria(fechanacimiento, nombre, apellido, grado, grupo);
            primaria.ListaNotas = notasEstudiante;

            // Implementamos la instansia del delegate promedio
            DLGCalcularPromedio dLGPromedio = new DLGCalcularPromedio(PromedioEstudiante);
            dLGPromedio(primaria.ListaNotas);
            primaria.Promedio = dLGPromedio(primaria.ListaNotas);

            //Implementamos la instansia del delegate calular edad
            DLGCalcularEdad dLGCalcularEdad = new DLGCalcularEdad(CalcularEdad);
            dLGCalcularEdad(primaria.FechaNacimiento);
            primaria.Edad = dLGCalcularEdad(primaria.FechaNacimiento);

            DLGEsPromovido dLGEsPromovido = new DLGEsPromovido(PromoverEsT);
            bool Seleccion = dLGEsPromovido(primaria.Promedio);
            if (Seleccion)
            {
                EstudiantePrimaria Aprovado = new EstudiantePrimaria(fechanacimiento, nombre, apellido, grado, grupo);
                Array.Resize<EstudiantePrimaria>(ref EstudiantesAprovados, EstudiantesAprovados.Length + 1);
                EstudiantesAprovados[EstudiantesAprovados.Length - 1] = Aprovado;
            }
            else
            {
                EstudiantePrimaria Reprovado = new EstudiantePrimaria(fechanacimiento, nombre, apellido, grado, grupo);
                Array.Resize<EstudiantePrimaria>(ref EstudiantesReprovados, EstudiantesReprovados.Length + 1);
                EstudiantesReprovados[EstudiantesReprovados.Length - 1] = Reprovado;
            }
            Array.Resize<EstudiantePrimaria>(ref EstudiantesDePrimaria, EstudiantesDePrimaria.Length + 1);
            EstudiantesDePrimaria[EstudiantesDePrimaria.Length - 1] = primaria;
        }
        #region Metodo
        public override void Imprimir()
        {
            Console.WriteLine("============================================================");
            Console.WriteLine("Estudiantes De  Primaria : ");
            for (int f = 0; f < EstudiantesDePrimaria.Length; f++)
            {
                //forma de imprimir datos de un array dinamico
                Console.WriteLine("\nN°{0} - Nombre: {1} - Apellido : {7} - Fecha de nacimiento: {5} - Edad : {6}  \n Grado: {2} - Gupo: {3} \n Promedio: {4} ", f + 1, EstudiantesDePrimaria[f].nombre, EstudiantesDePrimaria[f].grado, EstudiantesDePrimaria[f].grupo, EstudiantesDePrimaria[f].promedio, EstudiantesDePrimaria[f].fechaNacimiento, EstudiantesDePrimaria[f].edad, EstudiantesDePrimaria[f].apellido);

                Console.WriteLine("---------------------------------------------------------------------");
            }
            ImprimirAprovados();
            ImprimirReprovados();
        }
        public void ImprimirReprovados()
        {
            Console.WriteLine("============================================================");
            Console.WriteLine("Estudiantes De  Primaria  Reprovado: ");
            for (int f = 0; f < EstudiantesReprovados.Length; f++)
            {
                //forma de imprimir datos de un array dinamico
                Console.WriteLine("\nN°{0} - Nombre: {1} - Apellido : {4}  \n Grado: {2} - Gupo: {3} ", f + 1, EstudiantesReprovados[f].nombre, EstudiantesReprovados[f].grado, EstudiantesReprovados[f].grupo,EstudiantesReprovados[f].apellido);

                Console.WriteLine("---------------------------------------------------------------------");
            }
        }
        public void ImprimirAprovados()
        {
            Console.WriteLine("============================================================");
            Console.WriteLine("Estudiantes De  Primaria Aprovados : ");
            for (int f = 0; f < EstudiantesAprovados.Length; f++)
            {
                //forma de imprimir datos de un array dinamico
                Console.WriteLine("\nN°{0} - Nombre: {1} - Apellido : {4}  \n Grado: {2} - Gupo: {3}", f + 1, EstudiantesAprovados[f].nombre, EstudiantesAprovados[f].grado, EstudiantesAprovados[f].grupo, EstudiantesAprovados[f].apellido);

                Console.WriteLine("---------------------------------------------------------------------");
            }
        }
        #endregion
        public override bool PromoverEsT(decimal promedioEstudiante)
        {

            bool Espromovido = false;
            if (promedioEstudiante >= 3.0m)
            {
                Espromovido = true;
            }
            else
            {
                Espromovido = false;
            }
            return Espromovido;
        }


    }
}
