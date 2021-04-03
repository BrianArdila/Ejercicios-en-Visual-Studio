using System;
using appEvalIntegTest_Brian_Ardila.SaludDelosPerros;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace appPruebasIntegradasTest
{
    [TestClass]
    public class ProgramPerrosDeberia
    {
        [TestMethod]
        public void RetornaElpesoSiPesoes25Mayorque20yMenorque28ynoEscoge5o11o17()
        {
            var programPerros = new ProgramPerros();
            Assert.AreEqual(25, programPerros.GetWeightDog(25,1));
        }
        [TestMethod]
        public void Retorna1siPesoes29Mayorque28()
        {
            var programPerros = new ProgramPerros();
            Assert.AreEqual(1, programPerros.GetWeightDog(29,1));
        }
        [TestMethod]
        public void Retorna1siPesoes19Menorque20()
        {
            var programPerros = new ProgramPerros();
            Assert.AreEqual(1, programPerros.GetWeightDog(19,1));
        }
    }
}
