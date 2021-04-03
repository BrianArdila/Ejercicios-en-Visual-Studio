using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appTaxi_POO_Brian_Ardila
{
    class Empleado
    {

        #region Variables protegidas

        protected decimal SalarioBasico = 500000;

        #endregion


        #region enumeradores
        /// <summary>
        ///solo son accesibles dentro de la calse base y en las instancias(objetos) de las clases derivadas
        /// </summary>
        public enum TipoEstado
        {
            Ninguno = 0,
            Activo = 1,
            Inactivo = 2
        }

        #endregion


        #region Propiedades auto completadas
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Documento { get; set; }
        public string  Telefono { get; set; }
        public string Email { get; set; }
        public TipoEstado Estado  { get; set; }


        #endregion


        #region Metodos
        /// <summary>
        ///  devuelve el nombre completo del empleado
        /// </summary>
        /// <returns></returns>
        public string NombreCompleto()
        {
            return " " + this.Nombre + " " + this.Apellido;
            
        }


        #endregion



    }
}
