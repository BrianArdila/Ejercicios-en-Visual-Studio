using appEvalIntegTest_Brian_Ardila.Contract;
using appEvalIntegTest_Brian_Ardila.Entity;
using appEvalIntegTest_Brian_Ardila.SaludDelosPerros;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appEvalIntegTest_Brian_Ardila.Repositorio
{
    public class RangosRepositorios : IRangoRepositorio
    {
        public readonly List<Rangos> _rangosperros;
        public RangosRepositorios()
        {
            string jsonFile = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\Json\MetricasPerros.json");
            _rangosperros = JsonConvert.DeserializeObject<List<Rangos>>(File.ReadAllText(jsonFile, Encoding.UTF8));
        }

        //public ProgramPerros WeightDog( int chooseRaza, decimal PesoMinimoRecomendado, decimal? PesoMaximoRecomendado)
        //{
        //    RangosRepositorios rangosRepositorios = new RangosRepositorios();
        //    int NumeroRaza = 1;
        //    foreach (var RazaList in rangosRepositorios._rangosperros)
        //    {
        //        if (NumeroRaza == chooseRaza)
        //        {
        //             PesoMinimoRecomendado = RazaList.PesoMinimoRecomendado;
        //             PesoMaximoRecomendado = RazaList.PesoMaximoRecomendado;

        //            Console.WriteLine("Ingrese el peso del perro");
        //            int EnterWeight = int.Parse(Console.ReadLine());
        //        }
        //        NumeroRaza++;
        //    }
        //    return PesoMinimoRecomendado;

        //    //throw new NotImplementedException();
        //}
    }
}