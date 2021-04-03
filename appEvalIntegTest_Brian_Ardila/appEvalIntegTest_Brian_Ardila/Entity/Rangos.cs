using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appEvalIntegTest_Brian_Ardila.Entity
{
    public class Rangos
    {
        public string Raza { get; set; }
        public decimal PesoMaximoRecomendado { get; set; }
        public decimal PesoMinimoRecomendado { get; set; } // Como el ultimo rango no tiene valor maximo 
        //este debe devuelve valor nulo
        public int EsperanzaDeVida { get; set; }
    }
}
