using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace app_EvalFinal_Brian_Ardila
{
    
   
    public class Persona
    {
        #region Propiedades
        public string Nombres { get; set; }

        public string Apellidos { get; set; }

        public DateTime FechaNacimiento { get; set; }
        #endregion
        #region constructor
        public Persona(string nombres, string apellidos)
        {
            this.Nombres = nombres;
            this.Apellidos = apellidos;
        }
        public Persona() { }
        #endregion
    }
}
