using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appEvalFinal_Brian_Ardila
{
    #region Delegados
    public delegate decimal DLGCalcularPromedio(List<Asignatura> notasEstudiante);
    public delegate bool DLGEsPromovido(decimal promedioEstudiante); 
    #endregion

    public enum TipoEstudiante
    {
        Primaria,
        Bachillerato
    }
    #region Clase aninada
    public class Asignatura
    {
        public int Codigo;
        public string Nombre;
        public decimal Nota;
    }

    #endregion
    public class Estudiante : Persona
    {
        #region Atributo
        public int grado;
        public int grupo;
        public decimal promedio;
        public int edad;
        List<Asignatura> listaNotas = new List<Asignatura>();
        #endregion

        #region Propiedades
        public int Edad
        {
            get { return this.edad; }
            set { this.edad = value; }
        }
        public int Grado
        {
            get { return this.grado; }
            set { this.grado = value; }
        }
        public decimal Promedio
        {
            get { return this.promedio; }
            set { this.promedio = value; }
        }
        public int Grupo
        {
            get { return this.grupo; }
            set { this.grupo = value; }
        }

        public List<Asignatura> ListaNotas
        {
            get { return this.listaNotas; }
            set { this.listaNotas = value; }
        }

        #endregion
        #region Constructor
        //Sobre cargado
        public Estudiante(DateTime myFechaNacimiento, string myNombre, string myApellido, int grado, int grupo) : base(myFechaNacimiento, myNombre, myApellido)
        {
            this.nombre = myNombre;
            this.apellido = myApellido;
            this.fechaNacimiento = myFechaNacimiento;
            this.grado = grado;
            this.grupo = grupo;
        }
        // Defecto
        public Estudiante()
        {

        }
        #endregion

        //Se crea el arreglo dinamico con longitud 0
        Estudiante[] arrEstudiantes = new Estudiante[0];

        #region Metodo
        /// <summary>
        /// Agrega un nuevo usuario al arreglo 
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="grado"></param>
        /// <param name="grupo"></param>
        /// <param name="promedio"></param>
        public virtual void Add(DateTime fechanacimiento, string nombre, string apellido, int grado, int grupo, List<Asignatura> notasEstudiante)
        {
            //Se crea un objeto y se instansian los parametros de la clase estudiante
            Estudiante Objestudiante = new Estudiante(fechanacimiento, nombre, apellido, grado, grupo);
            Objestudiante.ListaNotas = notasEstudiante;

            // Implementamos la instansia del delegate promedio
            DLGCalcularPromedio dLGPromedio = new DLGCalcularPromedio(PromedioEstudiante);
            dLGPromedio(Objestudiante.ListaNotas);
            Objestudiante.Promedio = dLGPromedio(Objestudiante.ListaNotas);
            //Implementamos la instansia del delegate calular edad
            DLGCalcularEdad dLGCalcularEdad = new DLGCalcularEdad(CalcularEdad);
            dLGCalcularEdad(Objestudiante.FechaNacimiento);
            Objestudiante.Edad = dLGCalcularEdad(Objestudiante.FechaNacimiento);

            //Aunmenta la longitud del arreglo
            Array.Resize<Estudiante>(ref arrEstudiantes, arrEstudiantes.Length + 1);
            arrEstudiantes[arrEstudiantes.Length - 1] = Objestudiante;


        }
        public virtual void Imprimir()
        {
            for (int f = 0; f < arrEstudiantes.Length; f++)
            {
                //forma de imprimir datos de un array dinamico
                Console.WriteLine("\nN°{0} - Nombre: {1} - Apellido {7} - Fecha de nacimiento: {5} - Edad : {6}  \n Grado: {2} - Gupo: {3} \n Promedio: {4} ", f + 1, arrEstudiantes[f].nombre, arrEstudiantes[f].grado, arrEstudiantes[f].grupo, arrEstudiantes[f].promedio, arrEstudiantes[f].fechaNacimiento, arrEstudiantes[f].edad, arrEstudiantes[f].apellido);

                Console.WriteLine("================================================");
            }
        }
        #endregion
        #region Funcion de los delegate
        public decimal PromedioEstudiante(List<Asignatura> notasEstudiante)
        {
            decimal suma = 0;
            foreach (Asignatura infoAsignatura in notasEstudiante)
            {
                suma = suma + infoAsignatura.Nota;
            }
            return (suma / notasEstudiante.Count);
        }

        public virtual bool PromoverEsT(decimal promedioEstudiante)
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
        #endregion
        

    }
}
