using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appEvalFinal_Brian_Ardila
{
    class EstudianteBachillerato : Estudiante
    {
        #region Constructor
        public EstudianteBachillerato() { }

        public EstudianteBachillerato(DateTime myFechaNacimiento, string myNombre, string myApellido, int grado, int grupo) : base(myFechaNacimiento, myNombre, myApellido, grado, grupo)
        {
        }
        #endregion

        //Se crea el arreglo dinamico con longitud 0
        EstudianteBachillerato[] EstudiantesDeBachillerato = new EstudianteBachillerato[0];

        EstudiantePrimaria[] EstudiantesAprovados = new EstudiantePrimaria[0];

        EstudiantePrimaria[] EstudiantesReprovados = new EstudiantePrimaria[0];

        #region Metodo
        public override void Add(DateTime fechanacimiento, string nombre, string apellido, int grado, int grupo, List<Asignatura> notasEstudiante)
        {
            EstudianteBachillerato bachillerato = new EstudianteBachillerato(fechanacimiento, nombre, apellido, grado, grupo);
            bachillerato.ListaNotas = notasEstudiante;

            // Implementamos la instansia del delegate promedio
            DLGCalcularPromedio dLGPromedio = new DLGCalcularPromedio(PromedioEstudiante);
            dLGPromedio(bachillerato.ListaNotas);
            bachillerato.Promedio = dLGPromedio(bachillerato.ListaNotas);

            //Implementamos la instansia del delegate calular edad
            DLGCalcularEdad dLGCalcularEdad = new DLGCalcularEdad(CalcularEdad);
            dLGCalcularEdad(bachillerato.FechaNacimiento);
            bachillerato.Edad = dLGCalcularEdad(bachillerato.FechaNacimiento);

            DLGEsPromovido dLGEsPromovido = new DLGEsPromovido(PromoverEsT);
            bool Seleccion = dLGEsPromovido(bachillerato.Promedio);
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




            Array.Resize<EstudianteBachillerato>(ref EstudiantesDeBachillerato, EstudiantesDeBachillerato.Length + 1);
            EstudiantesDeBachillerato[EstudiantesDeBachillerato.Length - 1] = bachillerato;
        }
        public override void Imprimir()
        {
            Console.WriteLine("================================================");
            Console.WriteLine("Estudiantes De  Bachillerato : ");
            for (int f = 0; f < EstudiantesDeBachillerato.Length; f++)
            {
                //forma de imprimir datos de un array dinamico
                Console.WriteLine("\nN°{0} - Nombre: {1} - Apellido : {7} - Fecha de nacimiento: {5} - Edad : {6}  \n Grado: {2} - Gupo: {3} \n Promedio: {4} ", f + 1, EstudiantesDeBachillerato[f].nombre, EstudiantesDeBachillerato[f].grado, EstudiantesDeBachillerato[f].grupo, EstudiantesDeBachillerato[f].promedio, EstudiantesDeBachillerato[f].fechaNacimiento, EstudiantesDeBachillerato[f].edad, EstudiantesDeBachillerato[f].apellido);

                Console.WriteLine("--------------------------------------------------------------------------");
            }

            ImprimirAprovados();
            ImprimirReprovados();
        }
        public void ImprimirReprovados()
        {
            Console.WriteLine("============================================================");
            Console.WriteLine("Estudiantes De  Bachillerato Reprovados : ");
            for (int f = 0; f < EstudiantesReprovados.Length; f++)
            {
                //forma de imprimir datos de un array dinamico
                Console.WriteLine("\nN°{0} - Nombre: {1} - Apellido : {4} \n Grado: {2} - Gupo: {3} ", f + 1, EstudiantesReprovados[f].nombre, EstudiantesReprovados[f].grado, EstudiantesReprovados[f].grupo, EstudiantesReprovados[f].apellido);

                Console.WriteLine("---------------------------------------------------------------------");
            }
        }
        public void ImprimirAprovados()
        {
            Console.WriteLine("============================================================");
            Console.WriteLine("Estudiantes De  Bachillerato Aprovados : ");
            for (int f = 0; f < EstudiantesAprovados.Length; f++)
            {
                //forma de imprimir datos de un array dinamico
                Console.WriteLine("\nN°{0} - Nombre: {1} - Apellido : {4}\n Grado: {2} - Gupo: {3}", f + 1, EstudiantesAprovados[f].nombre, EstudiantesAprovados[f].grado, EstudiantesAprovados[f].grupo,EstudiantesAprovados[f].apellido);

                Console.WriteLine("---------------------------------------------------------------------");
            }
        }
        #endregion
        public override bool PromoverEsT(decimal promedioEstudiante)
        {
            bool Espromovido = false;
            if (promedioEstudiante >= 3.5m)
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
