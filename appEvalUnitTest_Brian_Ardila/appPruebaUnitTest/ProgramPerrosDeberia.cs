using System;
using appEvalUnitTest_Brian_Ardila.SaludDelosPerros;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace appPruebaUnitTest
{
    [TestClass]
    public class ProgramPerrosDeberia
    {
        [TestMethod]
        public void RetornaElpesoSiPesoes25Mayorque20yMenorque28ynoEscoge5o11o17()
        {
            var programPerros = new ProgramPerros();
            Assert.AreEqual(25, programPerros.GetWeightDog(25));
        }
        [TestMethod]
        public void Retorna1siPesoes29Mayorque28()
        {
            var programPerros = new ProgramPerros();
            Assert.AreEqual(1, programPerros.GetWeightDog(29));
        }
        [TestMethod]
        public void Retorna1siPesoes19Menorque20()
        {
            var programPerros = new ProgramPerros();
            Assert.AreEqual(1, programPerros.GetWeightDog(19));
        }

        [TestMethod]
        public void RetornaElpesoSiPesoes10Mayorque8yMenorque14ParaelRetriever()
        {
            var programPerros = new ProgramPerros();
            Assert.AreEqual(10, programPerros.GetWeightLabradorRetriever(10));
        }
        [TestMethod]
        public void Retorna1siPesoes15Mayorque14ParaelRetriever()
        {
            var programPerros = new ProgramPerros();
            Assert.AreEqual(1, programPerros.GetWeightLabradorRetriever(15));
        }
        [TestMethod]
        public void Retorna1siPesoes7Menorque8ParaelRetriever()
        {
            var programPerros = new ProgramPerros();
            Assert.AreEqual(1, programPerros.GetWeightLabradorRetriever(7));
        }

        [TestMethod]
        public void RetornaElpesoSiPesoes25Mayorque20yMenorque40ParaelBoxer()
        {
            var programPerros = new ProgramPerros();
            Assert.AreEqual(25, programPerros.GetWeightBoxer(25));
        }
        [TestMethod]
        public void Retorna1siPesoes41Mayorque40ParaelBoxer()
        {
            var programPerros = new ProgramPerros();
            Assert.AreEqual(1, programPerros.GetWeightBoxer(41));
        }
        [TestMethod]
        public void Retorna1siPesoes19Menorque20ParaelBoxer()
        {
            var programPerros = new ProgramPerros();
            Assert.AreEqual(1, programPerros.GetWeightBoxer(19));
        }

        [TestMethod]
        public void RetornaElpesoSiPesoes25Mayorque20yMenorque35ParaelBeagle()
        {
            var programPerros = new ProgramPerros();
            Assert.AreEqual(25, programPerros.GetWeightBeagle(25));
        }
        [TestMethod]
        public void Retorna1siPesoes36Mayorque35ParaelBeagle()
        {
            var programPerros = new ProgramPerros();
            Assert.AreEqual(1, programPerros.GetWeightBeagle(36));
        }
        [TestMethod]
        public void Retorna1siPesoes19Menorque20ParaelBeagle()
        {
            var programPerros = new ProgramPerros();
            Assert.AreEqual(1, programPerros.GetWeightBeagle(19));
        }
    }
}
