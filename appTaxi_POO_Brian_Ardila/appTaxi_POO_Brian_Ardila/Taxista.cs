using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appTaxi_POO_Brian_Ardila
{
    class Taxista:Empleado
    {
        #region Enumeradores

        public enum TipoTurno
        {
            N_Uno = 1,
            N_Dos = 2,
            N_Tres = 3
        } 
        #endregion

        #region Propiedades auto completadas
        public string Matricula { get; set; }

        public TipoTurno Turno { get; set; }

        public decimal Recaudado { get; set; }

        public int MyProperty { get; set; }



        #endregion


        #region Metodos
        public decimal CalcularDevengadoTurno()
        {
            return this.SalarioBasico + (this.Recaudado * Convert.ToDecimal(0.3));
        }

        #region Metodo sobre cargado
        public decimal CalcularDevengadoTurno( decimal Bonificacion)
        {
            return this.SalarioBasico + (this.Recaudado * Convert.ToDecimal(0.3)) + Bonificacion;
        }
        #endregion
        #endregion
    }
}
