using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appEvalFinal_Brian_Ardila
{

    #region delegado
    public delegate int DLGCalcularEdad(DateTime Fechanacimiento); 
    #endregion
    public class Persona 
    {
        #region Atributos
        public DateTime fechaNacimiento;
        public string nombre;
        public string apellido;
        #endregion

        #region Propiedades
        public DateTime FechaNacimiento
        {
            get { return this.fechaNacimiento; }
            set { this.fechaNacimiento = value; }
        }
        public string Nombre
        {
            get { return this.nombre; }
            set { this.nombre = value; }
        }
        public string Apellido
        {
            get { return this.apellido; }
            set { this.apellido = value; }
        }

        #endregion

        #region Constructor
        //Sobre cargado
        public Persona(DateTime myFechaNacimiento, string myNombre, string myApellido)
        {
            this.fechaNacimiento = myFechaNacimiento;
            this.nombre = myNombre;
            this.apellido = myApellido;
        }
        //Defecto
        public Persona()
        {

        }
        #endregion

        #region funcion del delegate

        public int CalcularEdad(DateTime Fechanacimiento)
        {
            int Año = DateTime.Now.Year - Fechanacimiento.Year;
            //int Mes = DateTime.Now.Month - Fechanacimiento.Month;
            //int Dia = DateTime.Now.Day - Fechanacimiento.Day;
            return (Año);
        } 
        #endregion
    }
}
