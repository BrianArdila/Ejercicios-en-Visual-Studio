using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace app_EvalFinal_Brian_Ardila
{
    public enum TipoEstudiante
    {
        Primaria,
        Bachillerato
    }

    #region Delegados
    public delegate double dlgPromedioAsignaturas(double NIngles, double NReligion, double NFilosofia, double NSociales);
    public delegate int EdadEstudiante(DateTime fechaNacimiento);
    public delegate bool EstudiantePromovido(double promedio, TipoEstudiante Nivel);
    #endregion
    public class Estudiante : Persona
    {
        #region Clases anidadas
        class EstudiantePrimaria { }
        class EstudianteBachillerato { }
        #endregion

        #region propiedades 
        
        public int Grado { get; set; }

        public int Grupo { get; set; }
        #endregion

        #region constructor
        //sobrecargado
        public Estudiante(DateTime fechaNacimiento, int grado, int grupo)
        {
            this.FechaNacimiento = fechaNacimiento;
            this.Grado = grado;
            this.Grupo = grupo;
        }
        //pordefecto
        public Estudiante() { }
        #endregion


        #region Funciones

        private double TotalPromedio(double NotaIngles, double NReligion, double NFilosofia, double NSociales)
        {
            return (NotaIngles + NReligion + NFilosofia + NSociales) / 4;
        }
        
        private int CalculoEdad(DateTime fechaNacimiento)
        {
            return 2018 - fechaNacimiento.Year;
        }
        
        private bool Promovido(double promedio, TipoEstudiante Nivel)
        {
            bool Espromovido = false;
            switch (Nivel)
            {
                case TipoEstudiante.Primaria:
                    if (promedio >= 3.5)
                    {
                        Espromovido = true;
                    }
                    else
                    {
                        Espromovido = false;
                    }
                    break;
                case TipoEstudiante.Bachillerato:
                    if (promedio >= 3.0)
                    {
                        Espromovido = true;
                    }
                    else
                    {
                        Espromovido = false;
                    }
                    break;
            }

            return Espromovido;
        }
        #endregion




    }
}
